﻿using System.Runtime.CompilerServices;
using Unity.Mathematics;
using Unity.Burst.Intrinsics;

namespace MaxMath
{
    unsafe public static partial class maxmath
    {
        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte avg(byte x, byte y)
        {
            return (byte)((x + y + 1) / 2u);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte avg(byte2 c)
        {
            return (byte)((1 + csum(c)) / 2u);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 avg(byte2 x, byte2 y)
        {
            return X86.Sse2.avg_epu8(x, y);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte avg(byte3 c)
        {
            return (byte)((1 + csum(c)) / 3u);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 avg(byte3 x, byte3 y)
        {
            return X86.Sse2.avg_epu8(x, y);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte avg(byte4 c)
        {
            return (byte)((1 + csum(c)) / 4u);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte4 avg(byte4 x, byte4 y)
        {
            return X86.Sse2.avg_epu8(x, y);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte avg(byte8 c)
        {
            return (byte)((1 + csum(c)) / 8u);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte8 avg(byte8 x, byte8 y)
        {
            return X86.Sse2.avg_epu8(x, y);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte avg(byte16 c)
        {
            return (byte)((1 + csum(c)) / 16u);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte16 avg(byte16 x, byte16 y)
        {
            return X86.Sse2.avg_epu8(x, y);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte avg(byte32 c)
        {
            return (byte)((1 + csum(c)) / 32u);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte32 avg(byte32 x, byte32 y)
        {
            return X86.Avx2.mm256_avg_epu8(x, y);
        }


        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte avg(sbyte x, sbyte y)
        {
            int intermediate = x + y;

            return (sbyte)((intermediate + cvt_uint8(intermediate > 0)) / 2);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte2 avg(sbyte2 x, sbyte2 y)
        {
            short2 result = ((short2)x + (short2)y);

            // if intermediate sum is positive add 1
            short2 mask = X86.Sse2.cmpgt_epi16(result, default(short2));
            result = (result + (mask & new short2(1))) >> 1;

            return (sbyte2)result;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte avg(sbyte2 c)
        {
            int intermediate = csum(c);

            return (sbyte)((intermediate + cvt_uint8(intermediate > 0)) / 2);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte3 avg(sbyte3 x, sbyte3 y)
        {
            short3 result = ((short3)x + (short3)y);

            // if intermediate sum is positive add 1
            short3 mask = X86.Sse2.cmpgt_epi16(result, default(short3));
            result = (result + (mask & new short3(1))) >> 1;

            return (sbyte3)result;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte avg(sbyte3 c)
        {
            int intermediate = csum(c);

            return (sbyte)((intermediate + cvt_uint8(intermediate > 0)) / 3);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte4 avg(sbyte4 x, sbyte4 y)
        {
            short4 result = ((short4)x + (short4)y);

            // if intermediate sum is positive add 1
            short4 mask = X86.Sse2.cmpgt_epi16(result, default(short4));
            result = (result + (mask & new short4(1))) >> 1;

            return (sbyte4)result;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte avg(sbyte4 c)
        {
            int intermediate = csum(c);

            return (sbyte)((intermediate + cvt_uint8(intermediate > 0)) / 8);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte8 avg(sbyte8 x, sbyte8 y)
        {
            short8 result = ((short8)x + (short8)y);

            // if intermediate sum is positive add 1
            short8 mask = X86.Sse2.cmpgt_epi16(result, default(short8));
            result = (result + (mask & new short8(1))) >> 1;

            return (sbyte8)result;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte avg(sbyte8 c)
        {
            int intermediate = csum(c);

            return (sbyte)((intermediate + cvt_uint8(intermediate > 0)) / 8);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte16 avg(sbyte16 x, sbyte16 y)
        {
            short16 result = ((short16)x + (short16)y);

            // if intermediate sum is positive add 1
            short16 mask = X86.Avx2.mm256_cmpgt_epi16(result, default(short16));
            result = (result + (mask & new short16(1))) >> 1;

            return (sbyte16)result;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte avg(sbyte16 c)
        {
            int intermediate = csum(c);

            return (sbyte)((intermediate + cvt_uint8(intermediate > 0)) / 16);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte32 avg(sbyte32 x, sbyte32 y)
        {
            short16 result_lo = (short16)x.v16_0 + (short16)y.v16_0;
            short16 result_hi = (short16)x.v16_16 + (short16)y.v16_16;

            // if intermediate sum is positive add 1
            short16 mask = X86.Avx2.mm256_cmpgt_epi16(result_lo, default(short16));
            result_lo = (result_lo + (mask & new short16(1))) >> 1;
            mask = X86.Avx2.mm256_cmpgt_epi16(result_hi, default(short16));
            result_hi = (result_hi + (mask & new short16(1))) >> 1;

            return X86.Avx2.mm256_permute4x64_epi64(X86.Avx2.mm256_packs_epi16(result_lo, result_hi), X86.Sse.SHUFFLE(3, 1, 2, 0));
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte avg(sbyte32 c)
        {
            int intermediate = csum(c);

            return (sbyte)((intermediate + cvt_uint8(intermediate > 0)) / 32);
        }


        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort avg(ushort x, ushort y)
        {
            return (ushort)((x + y + 1) / 2u);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort2 avg(ushort2 x, ushort2 y)
        {
            return X86.Sse2.avg_epu16(x, y);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort avg(ushort2 c)
        {
            return (ushort)((1 + csum(c)) / 2u);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort3 avg(ushort3 x, ushort3 y)
        {
            return X86.Sse2.avg_epu16(x, y);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort avg(ushort3 c)
        {
            return (ushort)((1 + csum(c)) / 3u);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort4 avg(ushort4 x, ushort4 y)
        {
            return X86.Sse2.avg_epu16(x, y);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort avg(ushort4 c)
        {
            return (ushort)((1 + csum(c)) / 4u);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort8 avg(ushort8 x, ushort8 y)
        {
            return X86.Sse2.avg_epu16(x, y);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort avg(ushort8 c)
        {
            return (ushort)((1 + csum(c)) / 8u);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort16 avg(ushort16 x, ushort16 y)
        {
            return X86.Avx2.mm256_avg_epu16(x, y);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort avg(ushort16 c)
        {
            return (ushort)((1 + csum(c)) / 16u);
        }


        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short avg(short x, short y)
        {
            int intermediate = x + y;

            return (short)((intermediate + cvt_uint8(intermediate > 0)) / 2);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short2 avg(short2 x, short2 y)
        {
            int2 result = ((int2)x + (int2)y);

            // if intermediate sum is positive add 1
            v128 mask = X86.Sse2.and_si128(new v128((int)1), X86.Sse2.cmpgt_epi32(*(v128*)&result, default(v128)));
            result = (result + *(int2*)&mask) >> 1;

            return (short2)result;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short avg(short2 c)
        {
            int intermediate = csum(c);

            return (short)((intermediate + cvt_uint8(intermediate > 0)) / 2);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 avg(short3 x, short3 y)
        {
            int3 result = ((int3)x + (int3)y);

            // if intermediate sum is positive add 1
            v128 mask = X86.Sse2.and_si128(new v128((int)1), X86.Sse2.cmpgt_epi32(*(v128*)&result, default(v128)));
            result = (result + *(int3*)&mask) >> 1;

            return (short3)result;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short avg(short3 c)
        {
            int intermediate = csum(c);

            return (short)((intermediate + cvt_uint8(intermediate > 0)) / 3);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 avg(short4 x, short4 y)
        {
            int4 result = ((int4)x + (int4)y);

            // if intermediate sum is positive add 1
            v128 mask = X86.Sse2.and_si128(new v128((int)1), X86.Sse2.cmpgt_epi32(*(v128*)&result, default(v128)));
            result = (result + *(int4*)&mask) >> 1;

            return (short4)result;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short avg(short4 c)
        {
            int intermediate = csum(c);

            return (short)((intermediate + cvt_uint8(intermediate > 0)) / 4);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short8 avg(short8 x, short8 y)
        {
            int8 result = ((int8)x + (int8)y);

            // if intermediate sum is positive add 1
            int8 mask = X86.Avx2.mm256_cmpgt_epi32(result, default(int8));
            result = (result + (mask & new int8(1))) >> 1;

            return X86.Sse2.packs_epi32(X86.Avx.mm256_castsi256_si128(result), 
                                        X86.Avx2.mm256_extracti128_si256(result, 1));
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short avg(short8 c)
        {
            int intermediate = csum(c);

            return (short)((intermediate + cvt_uint8(intermediate > 0)) / 8);
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short16 avg(short16 x, short16 y)
        {
            int8 result_lo = (int8)x.v8_0 + (int8)y.v8_0;
            int8 result_hi = (int8)x.v8_8 + (int8)y.v8_8;

            // if intermediate sum is positive add 1
            int8 mask = X86.Avx2.mm256_cmpgt_epi32(result_lo, default(int8));
            result_lo = (result_lo + (mask & new int8(1))) >> 1;
            mask = X86.Avx2.mm256_cmpgt_epi32(result_hi, default(int8));
            result_hi = (result_hi + (mask & new int8(1))) >> 1;

            return X86.Avx2.mm256_permute4x64_epi64(X86.Avx2.mm256_packs_epi32(result_lo, result_hi), X86.Sse.SHUFFLE(3, 1, 2, 0));
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short avg(short16 c)
        {
            int intermediate = csum(c);

            return (short)((intermediate + cvt_uint8(intermediate > 0)) / 16);
        }


        // NO OVERFLOW PROTECTION FROM HERE ON


        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint avg(uint x, uint y)
        {
            return (x + y + 1) / 2;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 avg(uint2 x, uint2 y)
        {
            return (x + y + 1) >> 1;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint avg(uint2 c)
        {
            return (1 + math.csum(c)) / 2;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 avg(uint3 x, uint3 y)
        {
            return (x + y + 1) >> 1;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint avg(uint3 c)
        {
            return (1 + math.csum(c)) / 3;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 avg(uint4 x, uint4 y)
        {
            return (x + y + 1) >> 1;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint avg(uint4 c)
        {
            return (1 + math.csum(c)) / 4u;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint8 avg(uint8 x, uint8 y)
        {
            return (x + y + 1) >> 1;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint avg(uint8 c)
        {
            return (1 + csum(c)) / 8u;
        }


        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int avg(int x, int y)
        {
            int intermediate = x + y;

            return (intermediate + cvt_uint8(intermediate > 0)) / 2;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 avg(int2 x, int2 y)
        {
            int2 result = x + y;
            result += math.select(default(int2), new int2(1), result > 0);

            return result >> 1;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int avg(int2 c)
        {
            int intermediate = math.csum(c);

            return (intermediate + cvt_uint8(intermediate > 0)) / 2;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 avg(int3 x, int3 y)
        {
            int3 result = x + y;
            result += math.select(default(int3), new int3(1), result > 0);

            return result >> 1;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int avg(int3 c)
        {
            int intermediate = math.csum(c);

            return (intermediate + cvt_uint8(intermediate > 0)) / 3;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 avg(int4 x, int4 y)
        {
            int4 result = x + y;
            result += math.select(default(int4), new int4(1), result > 0);

            return result >> 1;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int avg(int4 c)
        {
            int intermediate = math.csum(c);

            return (intermediate + cvt_uint8(intermediate > 0)) / 4;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int8 avg(int8 x, int8 y)
        {
            int8 result = x + y;

            // if intermediate sum is positive add 1
            int8 mask = X86.Avx2.mm256_cmpgt_epi32(result, default(int8));
            result += mask & new int8(1);

            return result >> 1;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int avg(int8 c)
        {
            int intermediate = csum(c);

            return (intermediate + cvt_uint8(intermediate > 0)) / 8;
        }


        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong avg(ulong x, ulong y)
        {
            return (x + y + 1) / 2;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 avg(ulong2 x, ulong2 y)
        {
            return (x + y + 1) >> 1;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong avg(ulong2 c)
        {
            return (1 + csum(c)) / 2;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 avg(ulong3 x, ulong3 y)
        {
            return (x + y + 1) >> 1;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong avg(ulong3 c)
        {
            return (1 + csum(c)) / 3;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 avg(ulong4 x, ulong4 y)
        {
            return (x + y + 1) >> 1;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong avg(ulong4 c)
        {
            return (1 + csum(c)) / 4;
        }


        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long avg(long x, long y)
        {
            long intermediate = x + y;

            return (intermediate + cvt_uint8(intermediate > 0)) / 2;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long2 avg(long2 x, long2 y)
        {
            long2 result = x + y;

            // if intermediate sum is positive add 1
            long2 mask = X86.Sse4_2.cmpgt_epi64(result, default(long2));
            result += mask & new long2(1);

            return result >> 1;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long avg(long2 c)
        {
            long intermediate = csum(c);

            return (intermediate + cvt_uint8(intermediate > 0)) / 2;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 avg(long3 x, long3 y)
        {
            long3 result = x + y;

            // if intermediate sum is positive add 1
            long3 mask = X86.Avx2.mm256_cmpgt_epi64(result, default(long3));
            result += mask & new long3(1);

            return result >> 1;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long avg(long3 c)
        {
            long intermediate = csum(c);

            return (intermediate + cvt_uint8(intermediate > 0)) / 3;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 avg(long4 x, long4 y)
        {
            long4 result = x + y;

            // if intermediate sum is positive add 1
            long4 mask = X86.Avx2.mm256_cmpgt_epi64(result, default(long4));
            result += mask & new long4(1);

            return result >> 1;
        }

        /// <summary>       With rounding from | x + 0.5 | to | x + 1 |      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long avg(long4 c)
        {
            long intermediate = csum(c);

            return (intermediate + cvt_uint8(intermediate > 0)) / 4;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float avg(float x, float y)
        {
            return 0.5f * (x + y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 avg(float2 x, float2 y)
        {
            return 0.5f * (x + y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float avg(float2 c)
        {
            return 0.5f * math.csum(c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 avg(float3 x, float3 y)
        {
            return 0.5f * (x + y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float avg(float3 c)
        {
            return (1f / 3f) * math.csum(c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 avg(float4 x, float4 y)
        {
            return 0.5f * (x + y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float avg(float4 c)
        {
            return 0.25f * math.csum(c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float8 avg(float8 x, float8 y)
        {
            return 0.5f * (x + y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float avg(float8 c)
        {
            return 0.125f * csum(c);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double avg(double x, double y)
        {
            return 0.5d * (x + y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 avg(double2 x, double2 y)
        {
            return 0.5d * (x + y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double avg(double2 c)
        {
            return 0.5d * math.csum(c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 avg(double3 x, double3 y)
        {
            return 0.5d * (x + y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double avg(double3 c)
        {
            return (1d / 3d) * math.csum(c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 avg(double4 x, double4 y)
        {
            return 0.5d * (x + y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double avg(double4 c)
        {
            return 0.25d * math.csum(c);
        }
    }
}