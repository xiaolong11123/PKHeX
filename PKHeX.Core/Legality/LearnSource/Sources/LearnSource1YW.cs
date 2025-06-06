using System;
using System.Diagnostics.CodeAnalysis;
using static PKHeX.Core.LearnMethod;
using static PKHeX.Core.LearnEnvironment;
using static PKHeX.Core.PersonalInfo1;

namespace PKHeX.Core;

/// <summary>
/// Exposes information about how moves are learned in <see cref="YW"/>.
/// </summary>
public sealed class LearnSource1YW : ILearnSource<PersonalInfo1>
{
    public static readonly LearnSource1YW Instance = new();
    private static readonly PersonalTable1 Personal = PersonalTable.Y;
    private static readonly Learnset[] Learnsets = LearnsetReader.GetArray(BinLinkerAccessor16.Get(Util.GetBinaryResource("lvlmove_y.pkl"), "yw"u8));
    private const LearnEnvironment Game = YW;
    private const int MaxSpecies = Legal.MaxSpeciesID_1;

    public LearnEnvironment Environment => Game;

    public Learnset GetLearnset(ushort species, byte form) => Learnsets[species < Learnsets.Length ? species : 0];

    public bool TryGetPersonal(ushort species, byte form, [NotNullWhen(true)] out PersonalInfo1? pi)
    {
        if (form is not 0 || species > MaxSpecies)
        {
            pi = null;
            return false;
        }
        pi = Personal[species];
        return true;
    }

    public MoveLearnInfo GetCanLearn(PKM pk, PersonalInfo1 pi, EvoCriteria evo, ushort move, MoveSourceType types = MoveSourceType.All, LearnOption option = LearnOption.Current)
    {
        if (move > Legal.MaxMoveID_1) // byte
            return default;

        if (types.HasFlag(MoveSourceType.Machine) && GetIsTM(pi, (byte)move))
            return new(TMHM, Game);

        if (types.HasFlag(MoveSourceType.SpecialTutor) && GetIsTutor(evo.Species, (byte)move))
            return new(Tutor, Game);

        if (types.HasFlag(MoveSourceType.LevelUp))
        {
            var learn = Learnsets[evo.Species];
            if (learn.TryGetLevelLearnMove(move, out var level) && evo.InsideLevelRange(level))
                return new(LevelUp, Game, level);
        }

        return default;
    }

    private static bool GetIsTutor(ushort species, byte move)
    {
        // No special tutors besides Stadium, which is GB-era only.
        if (!ParseSettings.AllowGBStadium2)
            return false;

        // Surf Pikachu via Stadium
        if (move != (int)Move.Surf)
            return false;
        return species is (int)Species.Pikachu or (int)Species.Raichu;
    }

    private static bool GetIsTM(PersonalInfo1 info, byte move)
    {
        var index = MachineMoves.IndexOf(move);
        if (index == -1)
            return false;
        return info.GetIsLearnTM(index);
    }

    public void GetAllMoves(Span<bool> result, PKM pk, EvoCriteria evo, MoveSourceType types = MoveSourceType.All)
    {
        if (!TryGetPersonal(evo.Species, evo.Form, out var pi))
            return;

        if (types.HasFlag(MoveSourceType.LevelUp))
        {
            var learn = Learnsets[evo.Species];
            var span = learn.GetMoveRange(evo.LevelMax, evo.LevelMin);
            foreach (var move in span)
                result[move] = true;
        }

        if (types.HasFlag(MoveSourceType.Machine))
            pi.SetAllLearnTM(result, MachineMoves);

        if (types.HasFlag(MoveSourceType.SpecialTutor))
        {
            if (GetIsTutor(evo.Species, (int)Move.Surf))
                result[(int)Move.Surf] = true;
        }
    }

    public void SetEncounterMoves(ushort species, byte form, byte level, Span<ushort> init)
    {
        if (!TryGetPersonal(species, 0, out var personal))
            return;

        var learn = Learnsets[species];
        personal.GetMoves(init);
        var start = (init.LastIndexOfAnyExcept<ushort>(0) + 1) & 3;
        learn.SetEncounterMoves(level, init, start);
    }
}
