using System;

namespace PKHeX.Core;

/// <summary>
/// Details about moves in <see cref="EntityContext.Gen5"/>
/// </summary>
internal static class MoveInfo5
{
    public static ReadOnlySpan<byte> PP =>
    [
        00, 35, 25, 10, 15, 20, 20, 15, 15, 15, 35, 30, 05, 10, 30, 30, 35, 35, 20, 15,
        20, 20, 15, 20, 30, 05, 10, 15, 15, 15, 25, 20, 05, 35, 15, 20, 20, 10, 15, 30,
        35, 20, 20, 30, 25, 40, 20, 15, 20, 20, 20, 30, 25, 15, 30, 25, 05, 15, 10, 05,
        20, 20, 20, 05, 35, 20, 25, 20, 20, 20, 15, 25, 15, 10, 40, 25, 10, 35, 30, 15,
        10, 40, 10, 15, 30, 15, 20, 10, 15, 10, 05, 10, 10, 25, 10, 20, 40, 30, 30, 20,
        20, 15, 10, 40, 15, 10, 30, 20, 20, 10, 40, 40, 30, 30, 30, 20, 30, 10, 10, 20,
        05, 10, 30, 20, 20, 20, 05, 15, 15, 20, 15, 15, 35, 20, 15, 10, 10, 30, 15, 40,
        20, 15, 10, 05, 10, 30, 10, 15, 20, 15, 40, 40, 10, 05, 15, 10, 10, 10, 15, 30,
        30, 10, 10, 20, 10, 01, 01, 10, 10, 10, 05, 15, 25, 15, 10, 15, 30, 05, 40, 15,
        10, 25, 10, 30, 10, 20, 10, 10, 10, 10, 10, 20, 05, 40, 05, 05, 15, 05, 10, 05,
        10, 10, 10, 10, 20, 20, 40, 15, 10, 20, 20, 25, 05, 15, 10, 05, 20, 15, 20, 25,
        20, 05, 30, 05, 10, 20, 40, 05, 20, 40, 20, 15, 35, 10, 05, 05, 05, 15, 05, 20,
        05, 05, 15, 20, 10, 05, 05, 15, 10, 15, 15, 10, 10, 10, 20, 10, 10, 10, 10, 15,
        15, 15, 10, 20, 20, 10, 20, 20, 20, 20, 20, 10, 10, 10, 20, 20, 05, 15, 10, 10,
        15, 10, 20, 05, 05, 10, 10, 20, 05, 10, 20, 10, 20, 20, 20, 05, 05, 15, 20, 10,
        15, 20, 15, 10, 10, 15, 10, 05, 05, 10, 15, 10, 05, 20, 25, 05, 40, 10, 05, 40,
        15, 20, 20, 05, 15, 20, 30, 15, 15, 05, 10, 30, 20, 30, 15, 05, 40, 15, 05, 20,
        05, 15, 25, 40, 15, 20, 15, 20, 15, 20, 10, 20, 20, 05, 05, 10, 05, 40, 10, 10,
        05, 10, 10, 15, 10, 20, 30, 30, 10, 20, 05, 10, 10, 15, 10, 10, 05, 15, 05, 10,
        10, 30, 20, 20, 10, 10, 05, 05, 10, 05, 20, 10, 20, 10, 15, 10, 20, 20, 20, 15,
        15, 10, 15, 20, 15, 10, 10, 10, 20, 10, 30, 05, 10, 15, 10, 10, 05, 20, 30, 10,
        30, 15, 15, 15, 15, 30, 10, 20, 15, 10, 10, 20, 15, 05, 05, 15, 15, 05, 10, 05,
        20, 05, 15, 20, 05, 20, 20, 20, 20, 10, 20, 10, 15, 20, 15, 10, 10, 05, 10, 05,
        05, 10, 05, 05, 10, 05, 05, 05, 15, 10, 10, 10, 10, 10, 10, 15, 20, 15, 10, 15,
        10, 15, 10, 20, 10, 15, 10, 20, 20, 20, 20, 20, 15, 15, 15, 15, 15, 15, 20, 15,
        10, 15, 15, 15, 15, 10, 10, 10, 10, 10, 15, 15, 15, 15, 05, 05, 15, 05, 10, 10,
        10, 20, 20, 20, 10, 10, 30, 15, 15, 10, 15, 25, 10, 20, 10, 10, 10, 20, 10, 10,
        10, 10, 10, 15, 15, 05, 05, 10, 10, 10, 05, 05, 10, 05, 05, 15, 10, 05, 05, 05,
    ];

    public static ReadOnlySpan<byte> Type =>
    [
        00, 00, 01, 00, 00, 00, 00, 09, 14, 12, 00, 00, 00, 00, 00, 00, 02, 02, 00, 02,
        00, 00, 11, 00, 01, 00, 01, 01, 04, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00,
        03, 06, 06, 00, 16, 00, 00, 00, 00, 00, 00, 03, 09, 09, 14, 10, 10, 10, 14, 14,
        13, 10, 14, 00, 02, 02, 01, 01, 01, 01, 00, 11, 11, 11, 00, 11, 11, 03, 11, 11,
        11, 06, 15, 09, 12, 12, 12, 12, 05, 04, 04, 04, 03, 13, 13, 13, 13, 13, 00, 00,
        13, 07, 00, 00, 00, 00, 00, 00, 00, 07, 10, 00, 13, 13, 14, 13, 00, 00, 00, 02,
        00, 00, 07, 03, 03, 04, 09, 10, 10, 00, 00, 00, 00, 13, 13, 00, 01, 00, 13, 03,
        00, 06, 00, 02, 00, 10, 00, 11, 00, 13, 00, 03, 10, 00, 00, 04, 13, 05, 00, 00,
        00, 00, 00, 00, 00, 00, 00, 01, 16, 06, 00, 07, 09, 00, 07, 00, 00, 02, 11, 01,
        07, 14, 00, 01, 00, 16, 00, 00, 03, 04, 10, 04, 12, 00, 07, 00, 14, 01, 04, 00,
        15, 05, 11, 00, 00, 05, 00, 00, 00, 12, 06, 08, 00, 00, 00, 00, 00, 00, 00, 00,
        00, 09, 04, 01, 06, 15, 00, 00, 16, 00, 00, 08, 08, 01, 00, 11, 00, 00, 01, 15,
        10, 09, 16, 13, 00, 00, 05, 07, 13, 01, 10, 16, 00, 00, 00, 00, 00, 09, 14, 16,
        16, 09, 16, 00, 01, 00, 00, 00, 12, 16, 00, 13, 13, 00, 00, 11, 01, 13, 00, 01,
        01, 00, 16, 00, 09, 13, 13, 00, 07, 16, 00, 10, 01, 00, 06, 13, 13, 02, 00, 09,
        04, 14, 11, 00, 00, 03, 00, 09, 10, 08, 07, 00, 11, 16, 02, 09, 00, 05, 06, 08,
        11, 00, 13, 10, 06, 07, 13, 01, 04, 14, 10, 11, 02, 14, 08, 00, 00, 15, 11, 01,
        02, 04, 03, 00, 12, 11, 10, 13, 11, 15, 05, 12, 10, 08, 13, 02, 13, 13, 01, 01,
        08, 13, 10, 00, 00, 02, 02, 00, 08, 06, 01, 16, 16, 16, 16, 13, 00, 13, 00, 13,
        03, 00, 00, 00, 13, 13, 16, 00, 11, 16, 03, 13, 10, 12, 09, 01, 01, 05, 03, 16,
        16, 10, 11, 02, 06, 06, 15, 15, 05, 01, 01, 01, 11, 02, 04, 16, 00, 16, 08, 14,
        14, 07, 12, 14, 09, 07, 04, 13, 13, 08, 08, 00, 02, 13, 15, 12, 09, 11, 11, 05,
        03, 03, 08, 08, 05, 00, 05, 11, 02, 00, 06, 12, 11, 10, 06, 06, 06, 05, 00, 15,
        15, 13, 00, 09, 16, 11, 07, 07, 16, 05, 13, 13, 13, 13, 03, 08, 06, 13, 13, 05,
        01, 09, 03, 06, 08, 13, 12, 10, 09, 03, 01, 03, 16, 00, 00, 00, 00, 00, 00, 03,
        13, 01, 13, 10, 00, 13, 07, 02, 08, 01, 09, 16, 02, 00, 00, 01, 00, 09, 10, 09,
        11, 12, 06, 04, 14, 15, 00, 12, 12, 04, 15, 13, 11, 01, 10, 09, 11, 06, 11, 16,
        13, 00, 02, 00, 08, 09, 00, 00, 01, 14, 12, 09, 09, 14, 14, 16, 14, 09, 09, 12,
    ];
}
