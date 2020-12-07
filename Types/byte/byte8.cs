﻿using DevTools;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using Unity.Burst.Intrinsics;
using Unity.Burst.CompilerServices;

namespace MaxMath
{
    [Serializable] [StructLayout(LayoutKind.Explicit, Size = 8)]
    unsafe public struct byte8 : IEquatable<byte8>
    {
        [FieldOffset(0)] internal long cast_long;

        [FieldOffset(0)] public byte x0;
        [FieldOffset(1)] public byte x1;
        [FieldOffset(2)] public byte x2;
        [FieldOffset(3)] public byte x3;
        [FieldOffset(4)] public byte x4;
        [FieldOffset(5)] public byte x5;
        [FieldOffset(6)] public byte x6;
        [FieldOffset(7)] public byte x7;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte8(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7)
        {
            this = X86.Sse2.set_epi8(0, 0, 0, 0, 0, 0, 0, 0, (sbyte)x7, (sbyte)x6, (sbyte)x5, (sbyte)x4, (sbyte)x3, (sbyte)x2, (sbyte)x1, (sbyte)x0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte8(byte x0x8)
        {
            this = X86.Sse2.set1_epi8((sbyte)x0x8);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte8(byte2 x01, byte2 x23, byte2 x45, byte2 x67)
        {
            this = new byte8(new byte4(x01, x23), new byte4(x45, x67));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte8(byte2 x01, byte3 x234, byte3 x567)
        {
            this = new byte8((byte4)X86.Sse2.unpacklo_epi16(x01, x234),
                             (byte4)X86.Sse4_1.insert_epi8(X86.Sse2.bslli_si128(x567, sizeof(byte)), x234.z, 0));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte8(byte3 x012, byte2 x34, byte3 x567)
        {
            this = new byte8((byte4)X86.Sse4_1.insert_epi8(x012, x34.x, 3),
                             (byte4)X86.Sse4_1.insert_epi8(X86.Sse2.bslli_si128(x567, sizeof(byte)), x34.y, 0));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte8(byte3 x012, byte3 x345, byte2 x67)
        {
            this = new byte8((byte4)X86.Sse4_1.insert_epi8(x012, x345.x, 3),
                             (byte4)X86.Sse2.unpacklo_epi16(X86.Sse2.bsrli_si128(x345, sizeof(byte)), x67));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte8(byte4 x0123, byte2 x45, byte2 x67)
        {
            this = new byte8(x0123, new byte4(x45, x67));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte8(byte2 x01, byte4 x2345, byte2 x67)
        {
            this = new byte8((byte4)X86.Sse2.unpacklo_epi16(x01, x2345),
                             (byte4)X86.Sse2.unpacklo_epi16(X86.Sse2.bsrli_si128(x2345, 2 * sizeof(byte)), x67));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte8(byte2 x01, byte2 x23, byte4 x4567)
        {
            this = new byte8(new byte4(x01, x23), x4567);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte8(byte4 x0123, byte4 x4567)
        {
            this = X86.Sse2.unpacklo_epi32(x0123, x4567);
        }


        public byte4 v4_0 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => (v128)this; }
        public byte4 v4_1 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Ssse3.shuffle_epi8(this, new v128(1, 2, 3, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)); }
        public byte4 v4_2 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.shufflelo_epi16(this, X86.Sse.SHUFFLE(0, 0, 2, 1)); }
        public byte4 v4_3 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Ssse3.shuffle_epi8(this, new v128(3, 4, 5, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)); }
        public byte4 v4_4 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.shufflelo_epi16(this, X86.Sse.SHUFFLE(0, 0, 3, 2)); }

        public byte3 v3_0 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => (v128)this; }
        public byte3 v3_1 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Ssse3.shuffle_epi8(this, new v128(1, 2, 3, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)); }
        public byte3 v3_2 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.shufflelo_epi16(this, X86.Sse.SHUFFLE(0, 0, 2, 1)); }
        public byte3 v3_3 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Ssse3.shuffle_epi8(this, new v128(3, 4, 5, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)); }
        public byte3 v3_4 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.shufflelo_epi16(this, X86.Sse.SHUFFLE(0, 0, 3, 2)); }
        public byte3 v3_5 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Ssse3.shuffle_epi8(this, new v128(5, 6, 7, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)); }

        public byte2 v2_0 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => (v128)this; }
        public byte2 v2_1 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Ssse3.shuffle_epi8(this, new v128(1, 2, 3, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)); }
        public byte2 v2_2 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.shufflelo_epi16(this, X86.Sse.SHUFFLE(0, 0, 2, 1)); }
        public byte2 v2_3 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Ssse3.shuffle_epi8(this, new v128(3, 4, 5, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)); }
        public byte2 v2_4 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.shufflelo_epi16(this, X86.Sse.SHUFFLE(0, 0, 3, 2)); }
        public byte2 v2_5 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Ssse3.shuffle_epi8(this, new v128(5, 6, 7, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)); }
        public byte2 v2_6 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.shufflelo_epi16(this, X86.Sse.SHUFFLE(0, 0, 0, 3)); }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator v128(byte8 input) => X86.Sse2.set1_epi64x(input.cast_long);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator byte8(v128 input) => new byte8{ cast_long = X86.Sse4_1.extract_epi64(input, 0) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator byte8(byte input) => new byte8(input);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte8(sbyte8 input) => (v128)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte8(ushort8 input) => Cast.ShortToByte(input);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte8(short8 input) => Cast.ShortToByte(input);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte8(uint8 input) => Cast.Int8ToByte8(input);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte8(int8 input) => Cast.Int8ToByte8(input);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte8(float8 input) => (byte8)(int8)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ushort8(byte8 input) => X86.Sse4_1.cvtepu8_epi16(input);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator short8(byte8 input) => X86.Sse4_1.cvtepu8_epi16(input);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint8(byte8 input) => X86.Avx2.mm256_cvtepu8_epi32(input);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int8(byte8 input) => X86.Avx2.mm256_cvtepu8_epi32(input);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float8(byte8 input) => (float8)(int8)input;


        public byte this[[AssumeRange(0, 7)] int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
Assert.IsWithinArrayBounds(index, 8);
                
                fixed (void* ptr = &this)
                {
                    return ((byte*)ptr)[index];
                }
            }
    
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsWithinArrayBounds(index, 8);

                fixed (void* ptr = &this)
                {
                    ((byte*)ptr)[index] = value;
                }
            }
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte8 operator + (byte8 lhs, byte8 rhs) => X86.Sse2.add_epi8(lhs, rhs);
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte8 operator - (byte8 lhs, byte8 rhs) => X86.Sse2.sub_epi8(lhs, rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte8 operator * (byte8 lhs, byte8 rhs) => (byte8)((ushort8)lhs * (ushort8)rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte8 operator /(byte8 lhs, byte8 rhs) => new byte8((byte)(lhs.x0 / rhs.x0),    (byte)(lhs.x1 / rhs.x1),    (byte)(lhs.x2 / rhs.x2),    (byte)(lhs.x3 / rhs.x3),    (byte)(lhs.x4 / rhs.x4),    (byte)(lhs.x5 / rhs.x5),    (byte)(lhs.x6 / rhs.x6),    (byte)(lhs.x7 / rhs.x7));
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte8 operator % (byte8 lhs, byte8 rhs) => new byte8((byte)(lhs.x0 % rhs.x0),    (byte)(lhs.x1 % rhs.x1),    (byte)(lhs.x2 % rhs.x2),    (byte)(lhs.x3 % rhs.x3),    (byte)(lhs.x4 % rhs.x4),    (byte)(lhs.x5 % rhs.x5),    (byte)(lhs.x6 % rhs.x6),    (byte)(lhs.x7 % rhs.x7));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte8 operator / (byte8 lhs, byte rhs) => Operator.div(lhs, rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte8 operator % (byte8 lhs, byte rhs) => Operator.rem(lhs, rhs);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte8 operator & (byte8 lhs, byte8 rhs) => X86.Sse2.and_si128(lhs, rhs);
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte8 operator | (byte8 lhs, byte8 rhs) => X86.Sse2.or_si128(lhs, rhs);
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte8 operator ^ (byte8 lhs, byte8 rhs) => X86.Sse2.xor_si128(lhs, rhs);
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte8 operator ++ (byte8 x) => X86.Sse2.add_epi8(x, new v128((byte)1));
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte8 operator -- (byte8 x) => X86.Sse2.sub_epi8(x, new v128((byte)1));
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte8 operator ~ (byte8 x) => X86.Sse2.andnot_si128(x, new v128((sbyte)-1));


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte8 operator <<(byte8 x, int n) => Operator.shl_byte(x, n);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte8 operator >> (byte8 x, int n) => Operator.shrl_byte(x, n);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator == (byte8 lhs, byte8 rhs) => TestIsTrue(X86.Sse2.cmpeq_epi8(lhs, rhs));
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator < (byte8 lhs, byte8 rhs) => (short8)lhs < (short8)rhs;
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator > (byte8 lhs, byte8 rhs) => (short8)lhs > (short8)rhs;
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator != (byte8 lhs, byte8 rhs) => TestIsFalse(X86.Sse2.cmpeq_epi8(lhs, rhs));
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator <= (byte8 lhs, byte8 rhs) => (short8)lhs <= (short8)rhs;
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator >= (byte8 lhs, byte8 rhs) => (short8)lhs >= (short8)rhs;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool4x2 TestIsTrue(v128 input) 
        {
            long result = 0x0101_0101_0101_0101L & X86.Sse4_1.extract_epi64(input, 0);

            return *(bool4x2*)&result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool4x2 TestIsFalse(v128 input)
        {
            long result = maxmath.andn(0x0101_0101_0101_0101L, X86.Sse4_1.extract_epi64(input, 0));

            return *(bool4x2*)&result;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(byte8 other) => maxmath.cvt_boolean(X86.Sse4_1.testc_si128(X86.Sse2.cmpeq_epi8(this, other), new v128(-1L, 0L)));

        public override bool Equals(object obj) => Equals((byte8)obj);
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => X86.Sse4_1.extract_epi64(this, 0).GetHashCode();


        public override string ToString() => $"byte8({x0}, {x1}, {x2}, {x3},    {x4}, {x5}, {x6}, {x7})";
    }
}