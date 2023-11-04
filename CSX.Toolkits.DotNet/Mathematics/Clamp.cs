using System;

namespace CSX.Toolkits.DotNet.Mathematics;

public static partial class Clamp
{
    // As Byte

    public static byte ClampAsByte(this int value)
        => (byte)Math.Clamp(value, 0, 255);

    public static byte ClampAsByte(this short value)
        => (byte)Math.Clamp(value, (short)0, (short)255);

    public static byte ClampAsByte(this long value)
        => (byte)Math.Clamp(value, 0, 255);

    public static byte ClampAsByte(this float value)
        => (byte)Math.Clamp(value, 0, 255);

    public static byte ClampAsByte(this double value)
        => (byte)Math.Clamp(value, 0, 255);

    public static byte ClampAsByte(this decimal value)
        => (byte)Math.Clamp(value, 0, 255);
}