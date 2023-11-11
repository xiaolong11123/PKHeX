using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PKHeX.Core;

namespace PKHeX.WinForms.Controls;

public partial class PokePreview : Form
{
    public PokePreview()
    {
        InitializeComponent();
        InitialWidth = Width;
    }

    private readonly int InitialWidth;

    private static readonly Image[] GenderImages =
    {
        Properties.Resources.gender_0,
        Properties.Resources.gender_1,
        Properties.Resources.gender_2,
    };

    public void Populate(PKM pk)
    {
        var la = new LegalityAnalysis(pk);
        PopulateHeader(pk);
        PopulateMoves(pk, la);
        PopulateText(pk, la);
    }

    private void PopulateHeader(PKM pk)
    {
        L_Name.Text = pk.Nickname;
        PopulateBall(pk);
        PopulateGender(pk);
    }

    private void PopulateBall(PKM pk)
    {
        int ball = (int)Ball.Poke;
        if (pk.Format >= 3)
            ball = pk.Ball;
        PB_Ball.Image = Drawing.PokeSprite.SpriteUtil.GetBallSprite(ball);
    }

    private void PopulateGender(PKM pk)
    {
        if (pk.Format == 1)
        {
            PB_Gender.Image = null;
            return;
        }

        var gender = pk.Gender;
        if (gender > GenderImages.Length)
            gender = 2;
        PB_Gender.Image = GenderImages[gender];
    }

    private void PopulateMoves(PKM pk, LegalityAnalysis la)
    {
        var context = pk.Context;
        var names = GameInfo.Strings.movelist;
        Move1.Populate(pk, pk.Move1, context, names, la.Info.Moves[0].Valid);
        Move2.Populate(pk, pk.Move2, context, names, la.Info.Moves[1].Valid);
        Move3.Populate(pk, pk.Move3, context, names, la.Info.Moves[2].Valid);
        Move4.Populate(pk, pk.Move4, context, names, la.Info.Moves[3].Valid);
    }

    private void PopulateText(PKM pk, LegalityAnalysis la)
    {
        var (stats, enc) = GetStatsString(pk, la);
        var settings = Main.Settings.Hover;
        var height = FLP_List.Top + FLP_Moves.Height + FLP_Moves.Margin.Vertical + 4; // 1px border * 4
        var width = InitialWidth;
        ToggleLabel(L_Stats, stats, settings.HoverSlotShowPaste, ref width, ref height);
        ToggleLabel(L_Etc, enc, settings.HoverSlotShowEncounter, ref width, ref height);
        Size = new Size(width, height);
    }

    private void ToggleLabel(Control display, string text, bool visible, ref int width, ref int height)
    {
        if (!visible)
        {
            display.Visible = false;
            return;
        }

        const TextFormatFlags flags = TextFormatFlags.LeftAndRightPadding | TextFormatFlags.VerticalCenter;

        var size = TextRenderer.MeasureText(text, Font, new Size(), flags);
        width = Math.Max(width, display.Margin.Horizontal + size.Width);
        var actHeight = size.Height;
        height += actHeight + display.Margin.Vertical;
        display.Width = size.Width;
        display.Height = actHeight;
        display.Text = text;
        display.Visible = true;
    }

    private static (string Detail, string Encounter) GetStatsString(PKM pk, LegalityAnalysis la)
    {
        var setText = SummaryPreviewer.GetPreviewText(pk, la);
        var sb = new StringBuilder();
        var lines = setText.AsSpan().EnumerateLines();
        if (!lines.MoveNext())
            throw new ArgumentException("Invalid text format", nameof(pk));

        var first = lines.Current;
        var itemIndex = first.IndexOf('@');
        if (itemIndex != -1) // Held Item
        {
            var remaining = first[(itemIndex + 2)..];
            if (remaining[^1] == ')')
                remaining = remaining[..^3]; // lop off gender
            var item = remaining.Trim().ToString();
            sb.AppendLine(item);
        }

        while (lines.MoveNext())
        {
            var line = lines.Current;
            if (IsMoveLine(line))
            {
                while (lines.MoveNext())
                {
                    if (!IsMoveLine(lines.Current))
                        break;
                }
                break;
            }
            sb.AppendLine(line.ToString());
        }

        var detail = sb.ToString();
        sb.Clear();
        while (lines.MoveNext())
        {
            var line = lines.Current;
            sb.AppendLine(line.ToString());
        }
        var enc = sb.ToString();
        return (detail.TrimEnd(), enc.TrimEnd());

        static bool IsMoveLine(ReadOnlySpan<char> line) => line.Length != 0 && line[0] == '-';
    }
}