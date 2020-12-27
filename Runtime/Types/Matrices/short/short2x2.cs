using DevTools;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Burst.CompilerServices;
using Unity.Mathematics;

namespace MaxMath
{
    [Serializable]  [StructLayout(LayoutKind.Sequential, Size = 8)]
    unsafe public struct short2x2 : IEquatable<short2x2>, IFormattable
    {
        public short2 c0;
        public short2 c1;


        public static short2x2 identity => new short2x2(1, 0,   0, 1);

        public static short2x2 zero => default(short2x2);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short2x2(short2 c0, short2 c1)
        {
            this.c0 = c0;
            this.c1 = c1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short2x2(short m00, short m01,
                        short m10, short m11)
        {
            this.c0 = new short2(m00, m10);
            this.c1 = new short2(m01, m11);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short2x2(short v)
        {
            this.c0 = v;
            this.c1 = v;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator short2x2(short v) => new short2x2(v);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short2x2(ushort2x2 input) => new short2x2((short2)input.c0, (short2)input.c1);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short2x2(int2x2 input) => new short2x2((short2)input.c0, (short2)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short2x2(uint2x2 input) => new short2x2((short2)input.c0, (short2)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short2x2(long2x2 input) => new short2x2((short2)input.c0, (short2)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short2x2(ulong2x2 input) => new short2x2((short2)input.c0, (short2)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short2x2(float2x2 input) => new short2x2((short2)input.c0, (short2)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short2x2(double2x2 input) => new short2x2((short2)input.c0, (short2)input.c1);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int2x2(short2x2 input) => new int2x2((int2)input.c0, (int2)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2x2(short2x2 input) => new uint2x2((uint2)input.c0, (uint2)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long2x2(short2x2 input) => new long2x2((long2)input.c0, (long2)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong2x2(short2x2 input) => new ulong2x2((ulong2)input.c0, (ulong2)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2x2(short2x2 input) => new float2x2((float2)input.c0, (float2)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x2(short2x2 input) => new double2x2((double2)input.c0, (double2)input.c1);


        public ref short2 this[int index]
        {
            get
            {
Assert.IsWithinArrayBounds(index, 2);

                fixed (void* ptr = &this)
                {
                    return ref ((short2*)ptr)[index];
                }
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short2x2 operator + (short2x2 lhs, short2x2 rhs) => new short2x2 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short2x2 operator - (short2x2 lhs, short2x2 rhs) => new short2x2 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short2x2 operator * (short2x2 lhs, short2x2 rhs) => new short2x2(lhs.c0 * rhs.c0, lhs.c1 * rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short2x2 operator / (short2x2 lhs, short2x2 rhs) => new short2x2 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short2x2 operator % (short2x2 lhs, short2x2 rhs) => new short2x2 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short2x2 operator * (short2x2 lhs, short rhs) => rhs * lhs;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short2x2 operator * (short lhs, short2x2 rhs) => new short2x2 (lhs * rhs.c0, lhs * rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short2x2 operator / (short2x2 lhs, short rhs) => new short2x2 (lhs.c0 / rhs, lhs.c1 / rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short2x2 operator % (short2x2 lhs, short rhs) => new short2x2 (lhs.c0 % rhs, lhs.c1 % rhs);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short2x2 operator & (short2x2 lhs, short2x2 rhs) => new short2x2 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short2x2 operator | (short2x2 lhs, short2x2 rhs) => new short2x2 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short2x2 operator ^ (short2x2 lhs, short2x2 rhs) => new short2x2 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short2x2 operator - (short2x2 val) => new short2x2(-val.c0, -val.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short2x2 operator ++ (short2x2 val) => new short2x2 (++val.c0, ++val.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short2x2 operator -- (short2x2 val) => new short2x2 (--val.c0, --val.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short2x2 operator ~ (short2x2 val) => new short2x2 (~val.c0, ~val.c1);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short2x2 operator << (short2x2 x, int n) => new short2x2 (x.c0 << n, x.c1 << n);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short2x2 operator >> (short2x2 x, int n) => new short2x2 (x.c0 >> n, x.c1 >> n);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator == (short2x2 lhs, short2x2 rhs) => new bool2x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator < (short2x2 lhs, short2x2 rhs) => new bool2x2 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator > (short2x2 lhs, short2x2 rhs) => new bool2x2 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator != (short2x2 lhs, short2x2 rhs) => new bool2x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator <= (short2x2 lhs, short2x2 rhs) => new bool2x2 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator >= (short2x2 lhs, short2x2 rhs) => new bool2x2 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(short2x2 other) => this.c0.Equals(other.c0) & this.c1.Equals(other.c1);
        public override bool Equals(object obj) => Equals((short2x2)obj);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => c0.GetHashCode() ^ c1.GetHashCode();


        public override string ToString() => $"short2x2({c0.x}, {c1.x},  {c0.y}, {c1.y})";
        public string ToString(string format, IFormatProvider formatProvider) => $"short2x2({c0.x.ToString(format, formatProvider)}, {c1.x.ToString(format, formatProvider)},  {c0.y.ToString(format, formatProvider)}, {c1.y.ToString(format, formatProvider)})";
    }
}