﻿using DevTools;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using Unity.Burst.Intrinsics;
using Unity.Burst.CompilerServices;
using Unity.Burst;

namespace MaxMath
{
    [Serializable] [StructLayout(LayoutKind.Explicit, Size = 32)]
    unsafe public struct ushort16 : IEquatable<ushort16>
    {
        [NoAlias] [FieldOffset(0)]  public ushort x0;
        [NoAlias] [FieldOffset(2)]  public ushort x1;
        [NoAlias] [FieldOffset(4)]  public ushort x2;
        [NoAlias] [FieldOffset(6)]  public ushort x3;
        [NoAlias] [FieldOffset(8)]  public ushort x4;
        [NoAlias] [FieldOffset(10)] public ushort x5;
        [NoAlias] [FieldOffset(12)] public ushort x6;
        [NoAlias] [FieldOffset(14)] public ushort x7;
        [NoAlias] [FieldOffset(16)] public ushort x8;
        [NoAlias] [FieldOffset(18)] public ushort x9;
        [NoAlias] [FieldOffset(20)] public ushort x10;
        [NoAlias] [FieldOffset(22)] public ushort x11;
        [NoAlias] [FieldOffset(24)] public ushort x12;
        [NoAlias] [FieldOffset(26)] public ushort x13;
        [NoAlias] [FieldOffset(28)] public ushort x14;
        [NoAlias] [FieldOffset(30)] public ushort x15;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort16(ushort x0, ushort x1, ushort x2, ushort x3, ushort x4, ushort x5, ushort x6, ushort x7, ushort x8, ushort x9, ushort x10, ushort x11, ushort x12, ushort x13, ushort x14, ushort x15)
        {
            this = X86.Avx.mm256_set_epi16((short)x15, (short)x14, (short)x13, (short)x12, (short)x11, (short)x10, (short)x9, (short)x8, (short)x7, (short)x6, (short)x5, (short)x4, (short)x3, (short)x2, (short)x1, (short)x0);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort16(ushort x0x16)
        {
            this = X86.Avx.mm256_set1_epi16((short)x0x16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort16(ushort2 x01, ushort2 x23, ushort2 x45, ushort2 x67, ushort2 x89, ushort2 x10_11, ushort2 x12_13, ushort2 x14_15)
        {
            this = new ushort16(new ushort8(x01, x23, x45, x67), new ushort8(x89, x10_11, x12_13, x14_15));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort16(ushort4 x0123, ushort4 x4567, ushort4 x8_9_10_11, ushort4 x12_13_14_15)
        {
            this = new ushort16(new ushort8(x0123, x4567), new ushort8(x8_9_10_11, x12_13_14_15));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort16(ushort4 x0123, ushort3 x456, ushort3 x789, ushort3 x10_11_12, ushort3 x13_14_15)
        {
            this = new ushort16((ushort8)X86.Sse2.insert_epi16(X86.Sse2.unpacklo_epi64(x0123, x456), x789.x, 7),
                                new ushort8(x789.yz, x10_11_12, x13_14_15));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort16(ushort3 x012, ushort4 x3456, ushort3 x789, ushort3 x10_11_12, ushort3 x13_14_15)
        {
            this = new ushort16(new ushort8(new ushort4(x012, x3456.x), new ushort4(x3456.yzw, x789.x)),
                                new ushort8(x789.yz, x10_11_12, x13_14_15));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort16(ushort3 x012, ushort3 x345, ushort4 x6789, ushort3 x10_11_12, ushort3 x13_14_15)
        {
            this = new ushort16(new ushort8(x012, x345, x6789.xy),
                                new ushort8(x6789.zw, x10_11_12, x13_14_15));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort16(ushort3 x012, ushort3 x345, ushort3 x678, ushort4 x9_10_11_12, ushort3 x13_14_15)
        {
            this = new ushort16(new ushort8(x012, x345, x678.xy),
                                new ushort8(new ushort4(x678.z, x9_10_11_12.xyz), new ushort4(x9_10_11_12.w, x13_14_15)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort16(ushort3 x012, ushort3 x345, ushort3 x678, ushort3 x9_10_11, ushort4 x12_13_14_15)
        {
            this = new ushort16(new ushort8(x012, x345, x678.xy),
                                new ushort8(new ushort4(x678.z, x9_10_11), x12_13_14_15));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort16(ushort8 x01234567, ushort4 x8_9_10_11, ushort4 x12_13_14_15)
        {
            this = new ushort16(x01234567, new ushort8(x8_9_10_11, x12_13_14_15));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort16(ushort4 x0123, ushort8 x4_5_6_7_8_9_10_11, ushort4 x12_13_14_15)
        {
            this = X86.Avx.mm256_set_m128i(X86.Sse2.unpacklo_epi64(X86.Sse2.bsrli_si128(x4_5_6_7_8_9_10_11, 4 * sizeof(ushort)), x12_13_14_15),
                                           X86.Sse2.unpacklo_epi64(x0123, x4_5_6_7_8_9_10_11));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort16(ushort4 x0123, ushort4 x4567, ushort8 x8_9_10_11_12_13_14_15)
        {
            this = new ushort16(new ushort8(x0123, x4567), x8_9_10_11_12_13_14_15);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort16(ushort8 x01234567, ushort8 x8_9_10_11_12_13_14_15)
        {
            this = X86.Avx.mm256_set_m128i(x8_9_10_11_12_13_14_15, x01234567);
        }


        public ushort8 v8_0 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Avx.mm256_castsi256_si128(this); }
        public ushort8 v8_1 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.insert_epi16(X86.Sse2.bsrli_si128(X86.Avx.mm256_castsi256_si128(this), sizeof(ushort)), X86.Avx2.mm256_extract_epi16(this, 8), 7); }
        public ushort8 v8_2 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Avx.mm256_castsi256_si128(X86.Avx2.mm256_permutevar8x32_epi32(this, new v256(1, 2, 3, 4,   0, 0, 0, 0))); }
        public ushort8 v8_3 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.or_si128(X86.Sse2.bsrli_si128(X86.Avx.mm256_castsi256_si128(this), 3 * sizeof(ushort)), X86.Sse2.bslli_si128(X86.Avx2.mm256_extracti128_si256(this, 1), 5 * sizeof(ushort))); }
        public ushort8 v8_4 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Avx.mm256_castsi256_si128(X86.Avx2.mm256_permutevar8x32_epi32(this, new v256(2, 3, 4, 5,   0, 0, 0, 0))); }
        public ushort8 v8_5 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.or_si128(X86.Sse2.bsrli_si128(X86.Avx.mm256_castsi256_si128(this), 5 * sizeof(ushort)), X86.Sse2.bslli_si128(X86.Avx2.mm256_extracti128_si256(this, 1), 3 * sizeof(ushort))); }
        public ushort8 v8_6 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Avx.mm256_castsi256_si128(X86.Avx2.mm256_permutevar8x32_epi32(this, new v256(3, 4, 5, 6,   0, 0, 0, 0))); }
        public ushort8 v8_7 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.insert_epi16(X86.Sse2.bslli_si128(X86.Avx2.mm256_extracti128_si256(this, 1), sizeof(ushort)), X86.Avx2.mm256_extract_epi16(this, 7), 0); }
        public ushort8 v8_8 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Avx2.mm256_extracti128_si256(this, 1); }

        public ushort4 v4_0 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Avx.mm256_castsi256_si128(this); }
        public ushort4 v4_1 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.bsrli_si128(X86.Avx.mm256_castsi256_si128(this), sizeof(ushort)); }
        public ushort4 v4_2 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.shuffle_epi32(X86.Avx.mm256_castsi256_si128(this), X86.Sse.SHUFFLE(0, 0,   2, 1)); }
        public ushort4 v4_3 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.bsrli_si128(X86.Avx.mm256_castsi256_si128(this), 3 * sizeof(ushort)); }
        public ushort4 v4_4 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.shuffle_epi32(X86.Avx.mm256_castsi256_si128(this), X86.Sse.SHUFFLE(0, 0,   3, 2)); }
        public ushort4 v4_5 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.insert_epi16(X86.Sse2.bsrli_si128(X86.Avx.mm256_castsi256_si128(this), 5 * sizeof(ushort)), X86.Avx2.mm256_extract_epi16(this, 8), 3); }
        public ushort4 v4_6 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Avx.mm256_castsi256_si128(X86.Avx2.mm256_permutevar8x32_epi32(this, new v256(3, 4,   0, 0, 0, 0, 0, 0))); }
        public ushort4 v4_7 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.insert_epi16(X86.Sse2.bslli_si128(X86.Avx2.mm256_extracti128_si256(this, 1), sizeof(ushort)), X86.Avx2.mm256_extract_epi16(this, 7), 0); }
        public ushort4 v4_8 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Avx2.mm256_extracti128_si256(this, 1); }
        public ushort4 v4_9 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.bsrli_si128(X86.Avx2.mm256_extracti128_si256(this, 1), sizeof(ushort)); }
        public ushort4 v4_10 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Avx.mm256_castsi256_si128(X86.Avx2.mm256_permutevar8x32_epi32(this, new v256(5, 6,   0, 0, 0, 0, 0, 0))); }
        public ushort4 v4_11 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.bsrli_si128(X86.Avx2.mm256_extracti128_si256(this, 1), 3 * sizeof(ushort)); }
        public ushort4 v4_12 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Avx.mm256_castsi256_si128(X86.Avx2.mm256_permutevar8x32_epi32(this, new v256(6, 7,   0, 0, 0, 0, 0, 0))); }

        public ushort3 v3_0 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Avx.mm256_castsi256_si128(this); }
        public ushort3 v3_1 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.shufflelo_epi16(X86.Avx.mm256_castsi256_si128(this), X86.Sse.SHUFFLE(0,   3, 2, 1)); }
        public ushort3 v3_2 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.shuffle_epi32(X86.Avx.mm256_castsi256_si128(this), X86.Sse.SHUFFLE(0, 0,   2, 1)); }
        public ushort3 v3_3 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.bsrli_si128(X86.Avx.mm256_castsi256_si128(this), 3 * sizeof(ushort)); }
        public ushort3 v3_4 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.shuffle_epi32(X86.Avx.mm256_castsi256_si128(this), X86.Sse.SHUFFLE(0, 0,   3, 2)); }
        public ushort3 v3_5 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.bsrli_si128(X86.Avx.mm256_castsi256_si128(this), 5 * sizeof(ushort)); }
        public ushort3 v3_6 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Avx.mm256_castsi256_si128(X86.Avx2.mm256_permutevar8x32_epi32(this, new v256(3, 4,   0, 0, 0, 0, 0, 0))); }
        public ushort3 v3_7 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.insert_epi16(X86.Sse2.bslli_si128(X86.Avx2.mm256_extracti128_si256(this, 1), sizeof(ushort)), X86.Avx2.mm256_extract_epi16(this, 7), 0); }
        public ushort3 v3_8 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Avx2.mm256_extracti128_si256(this, 1); }
        public ushort3 v3_9 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.shufflelo_epi16(X86.Avx2.mm256_extracti128_si256(this, 1), X86.Sse.SHUFFLE(0,   3, 2, 1)); }
        public ushort3 v3_10 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.shuffle_epi32(X86.Avx2.mm256_extracti128_si256(this, 1), X86.Sse.SHUFFLE(0, 0,   2, 1)); }
        public ushort3 v3_11 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.bsrli_si128(X86.Avx2.mm256_extracti128_si256(this, 1), 3 * sizeof(ushort)); }
        public ushort3 v3_12 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.shuffle_epi32(X86.Avx2.mm256_extracti128_si256(this, 1), X86.Sse.SHUFFLE(0, 0,   3, 2)); }
        public ushort3 v3_13 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.bsrli_si128(X86.Avx2.mm256_extracti128_si256(this, 1), 5 * sizeof(ushort)); }

        public ushort2 v2_0 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Avx.mm256_castsi256_si128(this); }
        public ushort2 v2_1 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.shufflelo_epi16(X86.Avx.mm256_castsi256_si128(this), X86.Sse.SHUFFLE(0, 0,   2, 1)); }
        public ushort2 v2_2 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.shufflelo_epi16(X86.Avx.mm256_castsi256_si128(this), X86.Sse.SHUFFLE(0, 0,   3, 2)); }
        public ushort2 v2_3 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.bsrli_si128(X86.Avx.mm256_castsi256_si128(this), 3 * sizeof(ushort)); }
        public ushort2 v2_4 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.shuffle_epi32(X86.Avx.mm256_castsi256_si128(this), X86.Sse.SHUFFLE(0, 0, 0,   2)); }
        public ushort2 v2_5 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.bsrli_si128(X86.Avx.mm256_castsi256_si128(this), 5 * sizeof(ushort)); }
        public ushort2 v2_6 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.shuffle_epi32(X86.Avx.mm256_castsi256_si128(this), X86.Sse.SHUFFLE(0, 0, 0,   3)); }
        public ushort2 v2_7 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ushort2((ushort)X86.Avx2.mm256_extract_epi16(this, 7), (ushort)X86.Avx2.mm256_extract_epi16(this, 8)); }
        public ushort2 v2_8 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Avx2.mm256_extracti128_si256(this, 1); }
        public ushort2 v2_9 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.shufflelo_epi16(X86.Avx2.mm256_extracti128_si256(this, 1), X86.Sse.SHUFFLE(0, 0,   2, 1)); }
        public ushort2 v2_10 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.shufflelo_epi16(X86.Avx2.mm256_extracti128_si256(this, 1), X86.Sse.SHUFFLE(0, 0,   3, 2)); }
        public ushort2 v2_11 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.bsrli_si128(X86.Avx2.mm256_extracti128_si256(this, 1), 3 * sizeof(ushort)); }
        public ushort2 v2_12 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.shuffle_epi32(X86.Avx2.mm256_extracti128_si256(this, 1), X86.Sse.SHUFFLE(0, 0, 0,   2)); }
        public ushort2 v2_13 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.bsrli_si128(X86.Avx2.mm256_extracti128_si256(this, 1), 5 * sizeof(ushort)); }
        public ushort2 v2_14 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => X86.Sse2.shuffle_epi32(X86.Avx2.mm256_extracti128_si256(this, 1), X86.Sse.SHUFFLE(0, 0, 0, 3)); }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]  // Burst optimizes this;    (worse) alternatives:   X86.Sse4_1.stream_load_si128(void* ptr)   X86.Sse.load_ps(void* ptr)
        public static implicit operator v256(ushort16 input) => new v256(input.x0, input.x1, input.x2, input.x3, input.x4, input.x5, input.x6, input.x7, input.x8, input.x9, input.x10, input.x11, input.x12, input.x13, input.x14, input.x15);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]  // Burst optimizes this;    (worse) alternatives:   X86.Sse.store_ps(void* ptr, v256 x)
        public static implicit operator ushort16(v256 input) => new ushort16 { x0 = input.UShort0, x1 = input.UShort1, x2 = input.UShort2, x3 = input.UShort3, x4 = input.UShort4, x5 = input.UShort5, x6 = input.UShort6, x7 = input.UShort7, x8 = input.UShort8, x9 = input.UShort9, x10 = input.UShort10, x11 = input.UShort11, x12 = input.UShort12, x13 = input.UShort13, x14 = input.UShort14, x15 = input.UShort15 };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ushort16(ushort input) => new ushort16(input);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort16(short16 input) => (v256)input;


        public ushort this[[AssumeRange(0, 15)] int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
Assert.IsWithinArrayBounds(index, 16);
                
                fixed (void* ptr = &this)
                {
                    return ((ushort*)ptr)[index];
                }
            }
    
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsWithinArrayBounds(index, 16);

                fixed (void* ptr = &this)
                {
                    ((ushort*)ptr)[index] = value;
                }
            }
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort16 operator + (ushort16 lhs, ushort16 rhs) => X86.Avx2.mm256_add_epi16(lhs, rhs);
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort16 operator - (ushort16 lhs, ushort16 rhs) => X86.Avx2.mm256_sub_epi16(lhs, rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort16 operator * (ushort16 lhs, ushort16 rhs) => X86.Avx2.mm256_mullo_epi16(lhs, rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort16 operator / (ushort16 lhs, ushort16 rhs) => new ushort16((ushort)(lhs.x0 / rhs.x0),    (ushort)(lhs.x1 / rhs.x1),    (ushort)(lhs.x2 / rhs.x2),    (ushort)(lhs.x3 / rhs.x3),    (ushort)(lhs.x4 / rhs.x4),    (ushort)(lhs.x5 / rhs.x5),    (ushort)(lhs.x6 / rhs.x6),    (ushort)(lhs.x7 / rhs.x7), (ushort)(lhs.x8 / rhs.x8), (ushort)(lhs.x9 / rhs.x9), (ushort)(lhs.x10 / rhs.x10), (ushort)(lhs.x11 / rhs.x11), (ushort)(lhs.x12 / rhs.x12), (ushort)(lhs.x13 / rhs.x13), (ushort)(lhs.x14 / rhs.x14), (ushort)(lhs.x15 / rhs.x15));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort16 operator % (ushort16 lhs, ushort16 rhs) => new ushort16((ushort)(lhs.x0 % rhs.x0),    (ushort)(lhs.x1 % rhs.x1),    (ushort)(lhs.x2 % rhs.x2),    (ushort)(lhs.x3 % rhs.x3),    (ushort)(lhs.x4 % rhs.x4),    (ushort)(lhs.x5 % rhs.x5),    (ushort)(lhs.x6 % rhs.x6),    (ushort)(lhs.x7 % rhs.x7), (ushort)(lhs.x8 % rhs.x8), (ushort)(lhs.x9 % rhs.x9), (ushort)(lhs.x10 % rhs.x10), (ushort)(lhs.x11 % rhs.x11), (ushort)(lhs.x12 % rhs.x12), (ushort)(lhs.x13 % rhs.x13), (ushort)(lhs.x14 % rhs.x14), (ushort)(lhs.x15 % rhs.x15));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort16 operator / (ushort16 lhs, ushort rhs) => Operator.div(lhs, rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort16 operator % (ushort16 lhs, ushort rhs) => Operator.rem(lhs, rhs);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort16 operator & (ushort16 lhs, ushort16 rhs) => X86.Avx2.mm256_and_si256(lhs, rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort16 operator | (ushort16 lhs, ushort16 rhs) => X86.Avx2.mm256_or_si256(lhs, rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort16 operator ^ (ushort16 lhs, ushort16 rhs) => X86.Avx2.mm256_xor_si256(lhs, rhs);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort16 operator ++ (ushort16 x) => X86.Avx2.mm256_add_epi16(x, new v256((ushort)1));
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort16 operator -- (ushort16 x) => X86.Avx2.mm256_sub_epi16(x, new v256((ushort)1));
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort16 operator ~ (ushort16 x) => X86.Avx2.mm256_andnot_si256(x, new v256((short)-1));


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort16 operator << (ushort16 x, int n) => Operator.shl_short(x, n);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort16 operator >> (ushort16 x, int n)
        {
            switch(n)
            {
                case 0:  return x;

                case 1:  return X86.Avx2.mm256_srli_epi16(x, 1);
                case 2:  return X86.Avx2.mm256_srli_epi16(x, 2);
                case 3:  return X86.Avx2.mm256_srli_epi16(x, 3);
                case 4:  return X86.Avx2.mm256_srli_epi16(x, 4);
                case 5:  return X86.Avx2.mm256_srli_epi16(x, 5);
                case 6:  return X86.Avx2.mm256_srli_epi16(x, 6);
                case 7:  return X86.Avx2.mm256_srli_epi16(x, 7);
                case 8:  return X86.Avx2.mm256_srli_epi16(x, 8);
                case 9:  return X86.Avx2.mm256_srli_epi16(x, 9);
                case 10: return X86.Avx2.mm256_srli_epi16(x, 10);
                case 11: return X86.Avx2.mm256_srli_epi16(x, 11);
                case 12: return X86.Avx2.mm256_srli_epi16(x, 12);
                case 13: return X86.Avx2.mm256_srli_epi16(x, 13);
                case 14: return X86.Avx2.mm256_srli_epi16(x, 14);
                case 15: return X86.Avx2.mm256_srli_epi16(x, 15);

                default: return X86.Avx2.mm256_srli_epi16(x, 16);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator == (ushort16 lhs, ushort16 rhs) => TestIsTrue(X86.Avx2.mm256_cmpeq_epi16(lhs, rhs));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator < (ushort16 lhs, ushort16 rhs) => TestIsTrue(Operator.greater_mask_ushort(rhs, lhs));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator > (ushort16 lhs, ushort16 rhs) => TestIsTrue(Operator.greater_mask_ushort(lhs, rhs));


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator != (ushort16 lhs, ushort16 rhs) => TestIsFalse(X86.Avx2.mm256_cmpeq_epi16(lhs, rhs));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator <= (ushort16 lhs, ushort16 rhs) => TestIsFalse(Operator.greater_mask_ushort(lhs, rhs));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator >= (ushort16 lhs, ushort16 rhs) => TestIsFalse(Operator.greater_mask_ushort(rhs, lhs));


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool4x4 TestIsTrue(v256 input)
        {
            v128 cast = X86.Sse2.and_si128(new v128((sbyte)1), (byte16)(ushort16)input);

            return *(bool4x4*)&cast;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool4x4 TestIsFalse(v256 input)
        {
            v128 cast = X86.Sse2.andnot_si128((byte16)(ushort16)input, new v128((sbyte)1));

            return *(bool4x4*)&cast;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(ushort16 other) => maxmath.cvt_boolean(X86.Avx.mm256_testc_ps(X86.Avx2.mm256_cmpeq_epi16(this, other), new v256(-1)));

        public override bool Equals(object obj) => Equals((ushort16)obj);
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Hash._256bit(this);


        public override string ToString() =>  $"ushort16({x0}, {x1}, {x2}, {x3},    {x4}, {x5}, {x6}, {x7},    {x8}, {x9}, {x10}, {x11},    {x12}, {x13}, {x14}, {x15})";
    }
}