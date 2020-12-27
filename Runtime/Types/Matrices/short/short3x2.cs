using DevTools;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Burst.CompilerServices;
using Unity.Mathematics;

namespace MaxMath
{
    [Serializable]  [StructLayout(LayoutKind.Sequential, Size = 12)]
    unsafe public struct short3x2 : IEquatable<short3x2>, IFormattable
    {
        public short3 c0;
        public short3 c1;


        public static short3x2 zero => default(short3x2);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short3x2(short3 c0, short3 c1)
        {
            this.c0 = c0;
            this.c1 = c1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short3x2(short m00, short m01,
                        short m10, short m11,
                        short m20, short m21)
        {
            this.c0 = new short3(m00, m10, m20);
            this.c1 = new short3(m01, m11, m21);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short3x2(short v)
        {
            this.c0 = v;
            this.c1 = v;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator short3x2(short v) => new short3x2(v);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short3x2(ushort3x2 input) => new short3x2((short3)input.c0, (short3)input.c1);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short3x2(int3x2 input) => new short3x2((short3)input.c0, (short3)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short3x2(uint3x2 input) => new short3x2((short3)input.c0, (short3)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short3x2(long3x2 input) => new short3x2((short3)input.c0, (short3)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short3x2(ulong3x2 input) => new short3x2((short3)input.c0, (short3)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short3x2(float3x2 input) => new short3x2((short3)input.c0, (short3)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short3x2(double3x2 input) => new short3x2((short3)input.c0, (short3)input.c1);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int3x2(short3x2 input) => new int3x2((int3)input.c0, (int3)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x2(short3x2 input) => new uint3x2((uint3)input.c0, (uint3)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long3x2(short3x2 input) => new long3x2((long3)input.c0, (long3)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong3x2(short3x2 input) => new ulong3x2((ulong3)input.c0, (ulong3)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3x2(short3x2 input) => new float3x2((float3)input.c0, (float3)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double3x2(short3x2 input) => new double3x2((double3)input.c0, (double3)input.c1);


        public ref short3 this[int index]
        {
            get
            {
Assert.IsWithinArrayBounds(index, 2);

                fixed (void* ptr = &this)
                {
                    return ref ((short3*)ptr)[index];
                }
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3x2 operator + (short3x2 lhs, short3x2 rhs) => new short3x2 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3x2 operator - (short3x2 lhs, short3x2 rhs) => new short3x2 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3x2 operator * (short3x2 lhs, short3x2 rhs) => new short3x2(lhs.c0 * rhs.c0, lhs.c1 * rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3x2 operator / (short3x2 lhs, short3x2 rhs) => new short3x2 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3x2 operator % (short3x2 lhs, short3x2 rhs) => new short3x2 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3x2 operator * (short3x2 lhs, short rhs) => rhs * lhs;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3x2 operator * (short lhs, short3x2 rhs) => new short3x2 (lhs * rhs.c0, lhs * rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3x2 operator / (short3x2 lhs, short rhs) => new short3x2 (lhs.c0 / rhs, lhs.c1 / rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3x2 operator % (short3x2 lhs, short rhs) => new short3x2 (lhs.c0 % rhs, lhs.c1 % rhs);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3x2 operator & (short3x2 lhs, short3x2 rhs) => new short3x2 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3x2 operator | (short3x2 lhs, short3x2 rhs) => new short3x2 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3x2 operator ^ (short3x2 lhs, short3x2 rhs) => new short3x2 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3x2 operator - (short3x2 val) => new short3x2 (-val.c0, -val.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3x2 operator ++ (short3x2 val) => new short3x2 (++val.c0, ++val.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3x2 operator -- (short3x2 val) => new short3x2 (--val.c0, --val.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3x2 operator ~ (short3x2 val) => new short3x2 (~val.c0, ~val.c1);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3x2 operator << (short3x2 x, int n) => new short3x2 (x.c0 << n, x.c1 << n);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3x2 operator >> (short3x2 x, int n) => new short3x2 (x.c0 >> n, x.c1 >> n);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator == (short3x2 lhs, short3x2 rhs) => new bool3x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator < (short3x2 lhs, short3x2 rhs) => new bool3x2 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator > (short3x2 lhs, short3x2 rhs) => new bool3x2 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator != (short3x2 lhs, short3x2 rhs) => new bool3x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator <= (short3x2 lhs, short3x2 rhs) => new bool3x2 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator >= (short3x2 lhs, short3x2 rhs) => new bool3x2 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(short3x2 other) => this.c0.Equals(other.c0) & this.c1.Equals(other.c1);
        public override bool Equals(object obj) => Equals((short3x2)obj);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => c0.GetHashCode() ^ c1.GetHashCode();


        public override string ToString() => $"short3x2({c0.x}, {c1.x},  {c0.y}, {c1.y},  {c0.z}, {c1.z})";
        public string ToString(string format, IFormatProvider formatProvider) => $"short3x2({c0.x.ToString(format, formatProvider)}, {c1.x.ToString(format, formatProvider)},  {c0.y.ToString(format, formatProvider)}, {c1.y.ToString(format, formatProvider)},  {c0.z.ToString(format, formatProvider)}, {c1.z.ToString(format, formatProvider)})";
    }
}