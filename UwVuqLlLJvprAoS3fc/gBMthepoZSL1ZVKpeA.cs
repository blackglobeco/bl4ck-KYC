using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using g8T6n6RbLPwmR1ScAJ;

namespace UwVuqLlLJvprAoS3fc;

internal class gBMthepoZSL1ZVKpeA
{
	private delegate void PQMMJG7VyMAxBFbm6p(object o);

	internal class F9PM6MZtTNkOqi52iJ : Attribute
	{
		internal class Wl7MnODKkrZ6Bh6C4wF<T>
		{
			public Wl7MnODKkrZ6Bh6C4wF()
			{
				dil2BPgckjnUlJwuku.UrZapk9nD();
				base._002Ector();
			}
		}

		public F9PM6MZtTNkOqi52iJ(object P_0)
		{
		}
	}

	internal class xTuFuFBOZeLGGT4vUi
	{
		internal static string reTlcDMFua(string P_0, string P_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(P_0);
			byte[] key = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] iV = on60bLPwm(Encoding.Unicode.GetBytes(P_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = vPcVkjnUl();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint kVigGJwa7MmmVecn9y(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr voSoEQ21oYJvG6Puy1();

	internal struct bqOOkFIIPmT7b9OaZC
	{
		internal bool MuWlxphtb0;

		internal byte[] cEWlsYBUE0;
	}

	internal class O6dh0ELPRTc6CQahBP
	{
		private BinaryReader wETl2SS809;

		public O6dh0ELPRTc6CQahBP(Stream P_0)
		{
			wETl2SS809 = new BinaryReader(P_0);
		}

		[SpecialName]
		internal Stream nW4lBacjpc()
		{
			return wETl2SS809.BaseStream;
		}

		internal byte[] sMLlkdoJ60(int P_0)
		{
			return wETl2SS809.ReadBytes(P_0);
		}

		internal int I5LlJVOMeQ(byte[] P_0, int P_1, int P_2)
		{
			return wETl2SS809.Read(P_0, P_1, P_2);
		}

		internal int qdll7OAZFb()
		{
			return wETl2SS809.ReadInt32();
		}

		internal void QEmlZSRGOw()
		{
			wETl2SS809.Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr EGys2wWRFjycbEMAIX(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr qDpHByO418JF0HdE1R(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int jDIuK3og8jGii502q8(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int yELBDsnIOkP2xpqE5M(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr HiQw6R9JAsUpCLlJBT(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int J10w5Rf973Fgv8P7Wd(IntPtr ptr);

	[Flags]
	private enum oXQlWXjnUhUCT01WFm
	{

	}

	private static bool S0VKigGJa;

	private static List<string> REMDXAIXxD;

	private static byte[] aIuDgK3g8j;

	private static IntPtr giiDR502q8;

	private static object sP2DHxpqE5;

	private static int NsUDVpCLlJ;

	private static bool vTQDu10w5R;

	private static long bnUDYhUCT0;

	private static long i0CD663syi;

	private static bool HcLDxxq5YJ;

	private static bool BmwDsdqaTf;

	private static IntPtr gFUDJSgT9X;

	[F9PM6MZtTNkOqi52iJ(typeof(F9PM6MZtTNkOqi52iJ.Wl7MnODKkrZ6Bh6C4wF<object>[]))]
	private static bool firstrundone;

	internal static Hashtable wo1D7fLWvm;

	private static EGys2wWRFjycbEMAIX DdlDZkxONl;

	private static qDpHByO418JF0HdE1R sPnDBtdmpC;

	private static yELBDsnIOkP2xpqE5M WaOD28GCXh;

	private static Dictionary<int, int> AaZ5C16dh;

	private static object r2wDDRFjyc;

	internal static RSACryptoServiceProvider RIPMmT7b9;

	private static HiQw6R9JAsUpCLlJBT FbxDIgIUp6;

	private static byte[] R0HDldE1Ru;

	private static IntPtr JQMDW05qHS;

	private static SortedList D73D0Fgv8P;

	private static jDIuK3og8jGii502q8 C0TDwuRAdm;

	private static bool jy1mDqOOk;

	private static int GUKDk4e99u;

	private static int[] X4iDtQw6RJ;

	private static bool OoYTJvG6P;

	private static int tWdDU6XQlW;

	private static uint[] CyB8oSoEQ;

	private static int ppTDclIAcs;

	private static J10w5Rf973Fgv8P7Wd srHDLNNYti;

	private static List<int> cHBDpy418J;

	private static IntPtr yELDGBDsIO;

	internal static kVigGJwa7MmmVecn9y ymUDdcGlHW;

	private static int JahDEBPjGy;

	internal static Assembly tMmvmVecn;

	private static object kEPzRTc6C;

	internal static kVigGJwa7MmmVecn9y OWFDym8WxI;

	static gBMthepoZSL1ZVKpeA()
	{
		S0VKigGJa = false;
		tMmvmVecn = typeof(gBMthepoZSL1ZVKpeA).Assembly;
		CyB8oSoEQ = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		OoYTJvG6P = false;
		jy1mDqOOk = false;
		RIPMmT7b9 = null;
		AaZ5C16dh = null;
		kEPzRTc6C = new object();
		JahDEBPjGy = 0;
		r2wDDRFjyc = new object();
		REMDXAIXxD = null;
		cHBDpy418J = null;
		R0HDldE1Ru = new byte[0];
		aIuDgK3g8j = new byte[0];
		giiDR502q8 = IntPtr.Zero;
		yELDGBDsIO = IntPtr.Zero;
		sP2DHxpqE5 = new string[0];
		X4iDtQw6RJ = new int[0];
		NsUDVpCLlJ = 1;
		vTQDu10w5R = false;
		D73D0Fgv8P = new SortedList();
		tWdDU6XQlW = 0;
		bnUDYhUCT0 = 0L;
		OWFDym8WxI = null;
		ymUDdcGlHW = null;
		i0CD663syi = 0L;
		ppTDclIAcs = 0;
		HcLDxxq5YJ = false;
		BmwDsdqaTf = false;
		GUKDk4e99u = 0;
		gFUDJSgT9X = IntPtr.Zero;
		firstrundone = false;
		wo1D7fLWvm = new Hashtable();
		DdlDZkxONl = null;
		sPnDBtdmpC = null;
		C0TDwuRAdm = null;
		WaOD28GCXh = null;
		FbxDIgIUp6 = null;
		srHDLNNYti = null;
		JQMDW05qHS = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void FwSxmb5nO()
	{
	}

	internal static byte[] N15X2cY3J(byte[] P_0)
	{
		uint[] array = new uint[16];
		uint num = (uint)((448 - P_0.Length * 8 % 512 + 512) % 512);
		if (num == 0)
		{
			num = 512u;
		}
		uint num2 = (uint)(P_0.Length + num / 8 + 8);
		ulong num3 = (ulong)P_0.Length * 8uL;
		byte[] array2 = new byte[num2];
		for (int i = 0; i < P_0.Length; i++)
		{
			array2[i] = P_0[i];
		}
		array2[P_0.Length] |= 128;
		for (int num4 = 8; num4 > 0; num4--)
		{
			array2[num2 - num4] = (byte)((num3 >> (8 - num4) * 8) & 0xFF);
		}
		uint num5 = (uint)(array2.Length * 8) / 32u;
		uint num6 = 1732584193u;
		uint num7 = 4023233417u;
		uint num8 = 2562383102u;
		uint num9 = 271733878u;
		for (uint num10 = 0u; num10 < num5 / 16; num10++)
		{
			uint num11 = num10 << 6;
			for (uint num12 = 0u; num12 < 61; num12 += 4)
			{
				array[num12 >> 2] = (uint)((array2[num11 + (num12 + 3)] << 24) | (array2[num11 + (num12 + 2)] << 16) | (array2[num11 + (num12 + 1)] << 8) | array2[num11 + num12]);
			}
			uint num13 = num6;
			uint num14 = num7;
			uint num15 = num8;
			uint num16 = num9;
			NWNp5BRFs(ref num6, num7, num8, num9, 0u, 7, 1u, array);
			NWNp5BRFs(ref num9, num6, num7, num8, 1u, 12, 2u, array);
			NWNp5BRFs(ref num8, num9, num6, num7, 2u, 17, 3u, array);
			NWNp5BRFs(ref num7, num8, num9, num6, 3u, 22, 4u, array);
			NWNp5BRFs(ref num6, num7, num8, num9, 4u, 7, 5u, array);
			NWNp5BRFs(ref num9, num6, num7, num8, 5u, 12, 6u, array);
			NWNp5BRFs(ref num8, num9, num6, num7, 6u, 17, 7u, array);
			NWNp5BRFs(ref num7, num8, num9, num6, 7u, 22, 8u, array);
			NWNp5BRFs(ref num6, num7, num8, num9, 8u, 7, 9u, array);
			NWNp5BRFs(ref num9, num6, num7, num8, 9u, 12, 10u, array);
			NWNp5BRFs(ref num8, num9, num6, num7, 10u, 17, 11u, array);
			NWNp5BRFs(ref num7, num8, num9, num6, 11u, 22, 12u, array);
			NWNp5BRFs(ref num6, num7, num8, num9, 12u, 7, 13u, array);
			NWNp5BRFs(ref num9, num6, num7, num8, 13u, 12, 14u, array);
			NWNp5BRFs(ref num8, num9, num6, num7, 14u, 17, 15u, array);
			NWNp5BRFs(ref num7, num8, num9, num6, 15u, 22, 16u, array);
			Q59l6jZOT(ref num6, num7, num8, num9, 1u, 5, 17u, array);
			Q59l6jZOT(ref num9, num6, num7, num8, 6u, 9, 18u, array);
			Q59l6jZOT(ref num8, num9, num6, num7, 11u, 14, 19u, array);
			Q59l6jZOT(ref num7, num8, num9, num6, 0u, 20, 20u, array);
			Q59l6jZOT(ref num6, num7, num8, num9, 5u, 5, 21u, array);
			Q59l6jZOT(ref num9, num6, num7, num8, 10u, 9, 22u, array);
			Q59l6jZOT(ref num8, num9, num6, num7, 15u, 14, 23u, array);
			Q59l6jZOT(ref num7, num8, num9, num6, 4u, 20, 24u, array);
			Q59l6jZOT(ref num6, num7, num8, num9, 9u, 5, 25u, array);
			Q59l6jZOT(ref num9, num6, num7, num8, 14u, 9, 26u, array);
			Q59l6jZOT(ref num8, num9, num6, num7, 3u, 14, 27u, array);
			Q59l6jZOT(ref num7, num8, num9, num6, 8u, 20, 28u, array);
			Q59l6jZOT(ref num6, num7, num8, num9, 13u, 5, 29u, array);
			Q59l6jZOT(ref num9, num6, num7, num8, 2u, 9, 30u, array);
			Q59l6jZOT(ref num8, num9, num6, num7, 7u, 14, 31u, array);
			Q59l6jZOT(ref num7, num8, num9, num6, 12u, 20, 32u, array);
			D5HgBMthe(ref num6, num7, num8, num9, 5u, 4, 33u, array);
			D5HgBMthe(ref num9, num6, num7, num8, 8u, 11, 34u, array);
			D5HgBMthe(ref num8, num9, num6, num7, 11u, 16, 35u, array);
			D5HgBMthe(ref num7, num8, num9, num6, 14u, 23, 36u, array);
			D5HgBMthe(ref num6, num7, num8, num9, 1u, 4, 37u, array);
			D5HgBMthe(ref num9, num6, num7, num8, 4u, 11, 38u, array);
			D5HgBMthe(ref num8, num9, num6, num7, 7u, 16, 39u, array);
			D5HgBMthe(ref num7, num8, num9, num6, 10u, 23, 40u, array);
			D5HgBMthe(ref num6, num7, num8, num9, 13u, 4, 41u, array);
			D5HgBMthe(ref num9, num6, num7, num8, 0u, 11, 42u, array);
			D5HgBMthe(ref num8, num9, num6, num7, 3u, 16, 43u, array);
			D5HgBMthe(ref num7, num8, num9, num6, 6u, 23, 44u, array);
			D5HgBMthe(ref num6, num7, num8, num9, 9u, 4, 45u, array);
			D5HgBMthe(ref num9, num6, num7, num8, 12u, 11, 46u, array);
			D5HgBMthe(ref num8, num9, num6, num7, 15u, 16, 47u, array);
			D5HgBMthe(ref num7, num8, num9, num6, 2u, 23, 48u, array);
			BZSRL1ZVK(ref num6, num7, num8, num9, 0u, 6, 49u, array);
			BZSRL1ZVK(ref num9, num6, num7, num8, 7u, 10, 50u, array);
			BZSRL1ZVK(ref num8, num9, num6, num7, 14u, 15, 51u, array);
			BZSRL1ZVK(ref num7, num8, num9, num6, 5u, 21, 52u, array);
			BZSRL1ZVK(ref num6, num7, num8, num9, 12u, 6, 53u, array);
			BZSRL1ZVK(ref num9, num6, num7, num8, 3u, 10, 54u, array);
			BZSRL1ZVK(ref num8, num9, num6, num7, 10u, 15, 55u, array);
			BZSRL1ZVK(ref num7, num8, num9, num6, 1u, 21, 56u, array);
			BZSRL1ZVK(ref num6, num7, num8, num9, 8u, 6, 57u, array);
			BZSRL1ZVK(ref num9, num6, num7, num8, 15u, 10, 58u, array);
			BZSRL1ZVK(ref num8, num9, num6, num7, 6u, 15, 59u, array);
			BZSRL1ZVK(ref num7, num8, num9, num6, 13u, 21, 60u, array);
			BZSRL1ZVK(ref num6, num7, num8, num9, 4u, 6, 61u, array);
			BZSRL1ZVK(ref num9, num6, num7, num8, 11u, 10, 62u, array);
			BZSRL1ZVK(ref num8, num9, num6, num7, 2u, 15, 63u, array);
			BZSRL1ZVK(ref num7, num8, num9, num6, 9u, 21, 64u, array);
			num6 += num13;
			num7 += num14;
			num8 += num15;
			num9 += num16;
		}
		byte[] array3 = new byte[16];
		Array.Copy(BitConverter.GetBytes(num6), 0, array3, 0, 4);
		Array.Copy(BitConverter.GetBytes(num7), 0, array3, 4, 4);
		Array.Copy(BitConverter.GetBytes(num8), 0, array3, 8, 4);
		Array.Copy(BitConverter.GetBytes(num9), 0, array3, 12, 4);
		return array3;
	}

	private static void NWNp5BRFs(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + ceAGvwVuq(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + CyB8oSoEQ[P_6 - 1], P_5);
	}

	private static void Q59l6jZOT(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + ceAGvwVuq(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + CyB8oSoEQ[P_6 - 1], P_5);
	}

	private static void D5HgBMthe(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + ceAGvwVuq(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + CyB8oSoEQ[P_6 - 1], P_5);
	}

	private static void BZSRL1ZVK(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + ceAGvwVuq(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + CyB8oSoEQ[P_6 - 1], P_5);
	}

	private static uint ceAGvwVuq(uint P_0, ushort P_1)
	{
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	internal static bool yLJHvprAo()
	{
		if (!OoYTJvG6P)
		{
			swuukuG8T();
			OoYTJvG6P = true;
		}
		return jy1mDqOOk;
	}

	internal gBMthepoZSL1ZVKpeA()
	{
	}

	private void N3ftclil2(byte[] P_0, byte[] P_1, byte[] P_2)
	{
		int num = P_2.Length % 4;
		int num2 = P_2.Length / 4;
		byte[] array = new byte[P_2.Length];
		int num3 = P_0.Length / 4;
		uint num4 = 0u;
		uint num5 = 0u;
		uint num6 = 0u;
		if (num > 0)
		{
			num2++;
		}
		uint num7 = 0u;
		for (int i = 0; i < num2; i++)
		{
			int num8 = i % num3;
			int num9 = i * 4;
			num7 = (uint)(num8 * 4);
			num5 = (uint)((P_0[num7 + 3] << 24) | (P_0[num7 + 2] << 16) | (P_0[num7 + 1] << 8) | P_0[num7]);
			uint num10 = 255u;
			int num11 = 0;
			if (i == num2 - 1 && num > 0)
			{
				num6 = 0u;
				num4 += num5;
				for (int j = 0; j < num; j++)
				{
					if (j > 0)
					{
						num6 <<= 8;
					}
					num6 |= P_2[^(1 + j)];
				}
			}
			else
			{
				num4 += num5;
				num7 = (uint)num9;
				num6 = (uint)((P_2[num7 + 3] << 24) | (P_2[num7 + 2] << 16) | (P_2[num7 + 1] << 8) | P_2[num7]);
			}
			uint num12 = num4;
			num4 = 0u;
			uint num13 = 1676933522u;
			uint num14 = num12;
			uint num15 = 936061030u;
			uint num16 = 604978158u;
			uint num17 = 860967095u;
			num14 -= num16;
			uint num18 = ((num13 >> 4) | (num13 << 28)) + num16;
			uint num19 = num18 & 0x55555555u;
			num18 &= 0xAAAAAAAAu;
			num13 = (num18 >> 1) | (num19 << 1);
			num15 ^= num14;
			if (num16 == 0)
			{
				num16--;
			}
			uint num20 = num14 / num16 + num16;
			num16 = (num14 - num14) * num20 + num14;
			if (num17 == 0)
			{
				num17--;
			}
			num20 = num14 / num17 + num17;
			num17 = num14 - num14 + num20 + num14;
			num14 ^= num14 >> 6;
			num14 += num15;
			num14 ^= num14 << 1;
			num14 += num16;
			num14 ^= num14 >> 11;
			num14 += num17;
			num14 = (((num14 << 6) - num13) ^ num15) - num14;
			num4 = num12 + (uint)(double)num14;
			if (i == num2 - 1 && num > 0)
			{
				uint num21 = num4 ^ num6;
				for (int k = 0; k < num; k++)
				{
					if (k > 0)
					{
						num10 <<= 8;
						num11 += 8;
					}
					array[num9 + k] = (byte)((num21 & num10) >> num11);
				}
			}
			else
			{
				uint num22 = num4 ^ num6;
				array[num9] = (byte)(num22 & 0xFFu);
				array[num9 + 1] = (byte)((num22 & 0xFF00) >> 8);
				array[num9 + 2] = (byte)((num22 & 0xFF0000) >> 16);
				array[num9 + 3] = (byte)((num22 & 0xFF000000u) >> 24);
			}
		}
		R0HDldE1Ru = array;
	}

	internal static SymmetricAlgorithm vPcVkjnUl()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (yLJHvprAo())
		{
			return new AesCryptoServiceProvider();
		}
		try
		{
			return new RijndaelManaged();
		}
		catch
		{
			try
			{
				return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
			}
			catch
			{
				return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
			}
		}
	}

	internal static void swuukuG8T()
	{
		try
		{
			new MD5CryptoServiceProvider();
		}
		catch
		{
			jy1mDqOOk = true;
			return;
		}
		try
		{
			jy1mDqOOk = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] on60bLPwm(byte[] P_0)
	{
		if (!yLJHvprAo())
		{
			return new MD5CryptoServiceProvider().ComputeHash(P_0);
		}
		return N15X2cY3J(P_0);
	}

	internal static void f1SUcAJqE(HashAlgorithm P_0, Stream P_1, uint P_2, byte[] P_3)
	{
		while (P_2 != 0)
		{
			int num = ((P_2 > (uint)P_3.Length) ? P_3.Length : ((int)P_2));
			P_1.Read(P_3, 0, num);
			jfCYCya4r(P_0, P_3, 0, num);
			P_2 -= (uint)num;
		}
	}

	internal static void jfCYCya4r(HashAlgorithm P_0, byte[] P_1, int P_2, int P_3)
	{
		P_0.TransformBlock(P_1, P_2, P_3, P_1, P_2);
	}

	internal static uint nLbyxFJId(uint P_0, int P_1, long P_2, BinaryReader P_3)
	{
		for (int i = 0; i < P_1; i++)
		{
			P_3.BaseStream.Position = P_2 + (i * 40 + 8);
			uint num = P_3.ReadUInt32();
			uint num2 = P_3.ReadUInt32();
			P_3.ReadUInt32();
			uint num3 = P_3.ReadUInt32();
			if (num2 <= P_0 && P_0 < num2 + num)
			{
				return num3 + P_0 - num2;
			}
		}
		return 0u;
	}

	public static void AIl6QSCQL(RuntimeTypeHandle P_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(P_0);
			if (AaZ5C16dh == null)
			{
				lock (kEPzRTc6C)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(gBMthepoZSL1ZVKpeA).Assembly.GetManifestResourceStream("ZCg8o9w5y5cj9Stdxc.ZZk41I2y4KgIRNtnDR"));
					binaryReader.BaseStream.Position = 0L;
					byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
					binaryReader.Close();
					if (array.Length != 0)
					{
						int num = array.Length % 4;
						int num2 = array.Length / 4;
						byte[] array2 = new byte[array.Length];
						uint num3 = 0u;
						uint num4 = 0u;
						if (num > 0)
						{
							num2++;
						}
						uint num5 = 0u;
						for (int i = 0; i < num2; i++)
						{
							int num6 = i * 4;
							uint num7 = 255u;
							int num8 = 0;
							if (i == num2 - 1 && num > 0)
							{
								num4 = 0u;
								for (int j = 0; j < num; j++)
								{
									if (j > 0)
									{
										num4 <<= 8;
									}
									num4 |= array[^(1 + j)];
								}
							}
							else
							{
								num5 = (uint)num6;
								num4 = (uint)((array[num5 + 3] << 24) | (array[num5 + 2] << 16) | (array[num5 + 1] << 8) | array[num5]);
							}
							num3 = num3;
							num3 += F06syqhcw(num3);
							if (i == num2 - 1 && num > 0)
							{
								uint num9 = num3 ^ num4;
								for (int k = 0; k < num; k++)
								{
									if (k > 0)
									{
										num7 <<= 8;
										num8 += 8;
									}
									array2[num6 + k] = (byte)((num9 & num7) >> num8);
								}
							}
							else
							{
								uint num10 = num3 ^ num4;
								array2[num6] = (byte)(num10 & 0xFFu);
								array2[num6 + 1] = (byte)((num10 & 0xFF00) >> 8);
								array2[num6 + 2] = (byte)((num10 & 0xFF0000) >> 16);
								array2[num6 + 3] = (byte)((num10 & 0xFF000000u) >> 24);
							}
						}
						array = array2;
						array2 = null;
						int num11 = array.Length / 8;
						O6dh0ELPRTc6CQahBP o6dh0ELPRTc6CQahBP = new O6dh0ELPRTc6CQahBP(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = o6dh0ELPRTc6CQahBP.qdll7OAZFb();
							int value = o6dh0ELPRTc6CQahBP.qdll7OAZFb();
							dictionary.Add(key, value);
						}
						o6dh0ELPRTc6CQahBP.QEmlZSRGOw();
					}
					AaZ5C16dh = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			for (int m = 0; m < fields.Length; m++)
			{
				try
				{
					FieldInfo fieldInfo = fields[m];
					int metadataToken = fieldInfo.MetadataToken;
					int num12 = AaZ5C16dh[metadataToken];
					bool flag = (num12 & 0x40000000) > 0;
					num12 &= 0x3FFFFFFF;
					MethodInfo methodInfo = (MethodInfo)typeof(gBMthepoZSL1ZVKpeA).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
					if (methodInfo.IsStatic)
					{
						fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
						continue;
					}
					ParameterInfo[] parameters = methodInfo.GetParameters();
					int num13 = parameters.Length + 1;
					Type[] array3 = new Type[num13];
					if (methodInfo.DeclaringType.IsValueType)
					{
						array3[0] = methodInfo.DeclaringType.MakeByRefType();
					}
					else
					{
						array3[0] = typeof(object);
					}
					for (int n = 0; n < parameters.Length; n++)
					{
						array3[n + 1] = parameters[n].ParameterType;
					}
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, skipVisibility: true);
					ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
					for (int num14 = 0; num14 < num13; num14++)
					{
						switch (num14)
						{
						case 0:
							iLGenerator.Emit(OpCodes.Ldarg_0);
							break;
						case 1:
							iLGenerator.Emit(OpCodes.Ldarg_1);
							break;
						case 2:
							iLGenerator.Emit(OpCodes.Ldarg_2);
							break;
						case 3:
							iLGenerator.Emit(OpCodes.Ldarg_3);
							break;
						default:
							iLGenerator.Emit(OpCodes.Ldarg_S, num14);
							break;
						}
					}
					iLGenerator.Emit(OpCodes.Tailcall);
					iLGenerator.Emit(flag ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
					iLGenerator.Emit(OpCodes.Ret);
					fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeFromHandle));
				}
				catch (Exception)
				{
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private static uint bDQxHjdMC(uint P_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint F06syqhcw(uint P_0)
	{
		return 0u;
	}

	internal static void fULkRmyUC()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void tDSJJEF6p(Stream P_0, int P_1)
	{
		int num = 22;
		byte[] array2 = default(byte[]);
		int num4 = default(int);
		byte[] array = default(byte[]);
		int num3 = default(int);
		byte[] array5 = default(byte[]);
		int num5 = default(int);
		byte[] array3 = default(byte[]);
		Stream stream = default(Stream);
		ICryptoTransform transform = default(ICryptoTransform);
		byte[] array6 = default(byte[]);
		byte[] array4 = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 159:
					array2[7] = (byte)num4;
					num2 = 3;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 17;
					}
					continue;
				case 253:
					array[28] = (byte)num3;
					num = 179;
					break;
				case 127:
					num4 = 222 - 74;
					num2 = 38;
					continue;
				case 109:
					num4 = 144 - 48;
					num2 = 101;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 94;
					}
					continue;
				case 33:
					array[5] = (byte)num3;
					num2 = 19;
					continue;
				case 1:
					num3 = 89 + 59;
					num2 = 183;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 321;
					}
					continue;
				case 310:
					num3 = 92 + 76;
					num2 = 289;
					continue;
				case 27:
					array[20] = 155;
					num2 = 54;
					if (S84nICW6T6Vig0hTkt())
					{
						num2 = 214;
					}
					continue;
				case 26:
					num3 = 60 + 81;
					num2 = 171;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 316;
					}
					continue;
				case 177:
					array[18] = 9;
					num2 = 207;
					continue;
				case 180:
					num3 = 236 + 16;
					num2 = 60;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 17;
					}
					continue;
				case 294:
					num4 = 22 + 118;
					num2 = 106;
					continue;
				case 149:
					array2[10] = (byte)num4;
					num2 = 161;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 271;
					}
					continue;
				case 61:
					array5[num5] ^= array3[num5];
					num2 = 150;
					continue;
				case 231:
					array2[7] = (byte)num4;
					num2 = 175;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 260;
					}
					continue;
				case 157:
					array2[10] = 188;
					num = 309;
					break;
				case 245:
					array[23] = 109;
					num2 = 218;
					continue;
				case 147:
					num3 = 109 + 111;
					num2 = 42;
					continue;
				case 78:
					array2[9] = (byte)num4;
					num2 = 287;
					continue;
				case 170:
					array[4] = 82;
					num2 = 151;
					if (bJ31R0I4PyTMsCmiKJ() != null)
					{
						num2 = 120;
					}
					continue;
				case 134:
					array2[12] = 156;
					num2 = 154;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 97;
					}
					continue;
				case 317:
					num4 = 60 + 5;
					num2 = 116;
					continue;
				case 243:
					array[11] = 218;
					num2 = 299;
					continue;
				case 67:
					array2[13] = (byte)num4;
					num2 = 9;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 15;
					}
					continue;
				case 152:
					array[19] = 132;
					num2 = 198;
					if (bJ31R0I4PyTMsCmiKJ() != null)
					{
						num2 = 55;
					}
					continue;
				case 59:
					num3 = 96 - 83;
					num2 = 77;
					continue;
				case 42:
					array[15] = (byte)num3;
					num2 = 44;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 44;
					}
					continue;
				case 153:
					array[4] = (byte)num3;
					num2 = 170;
					continue;
				case 101:
					array2[14] = (byte)num4;
					num2 = 307;
					continue;
				case 221:
					array2[0] = (byte)num4;
					num2 = 186;
					continue;
				case 198:
					array[19] = 119;
					num2 = 15;
					if (S84nICW6T6Vig0hTkt())
					{
						num2 = 70;
					}
					continue;
				case 232:
					num4 = 233 - 77;
					num2 = 149;
					continue;
				case 244:
					array[12] = 162;
					num2 = 13;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 23;
					}
					continue;
				case 264:
					array2[12] = (byte)num4;
					num2 = 280;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 75;
					}
					continue;
				case 186:
					array2[0] = 133;
					num2 = 137;
					continue;
				case 156:
					array2[11] = (byte)num4;
					num2 = 288;
					continue;
				case 53:
					array[17] = 149;
					num2 = 45;
					continue;
				case 155:
					num4 = 105 - 100;
					num = 62;
					break;
				case 18:
					num3 = 214 - 71;
					num2 = 336;
					continue;
				case 192:
					num3 = 254 - 84;
					num2 = 300;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 259;
					}
					continue;
				case 212:
					array[28] = 110;
					num2 = 322;
					continue;
				case 46:
					array2[10] = 140;
					num2 = 232;
					continue;
				case 40:
					array[5] = 114;
					num2 = 43;
					if (S84nICW6T6Vig0hTkt())
					{
						num2 = 95;
					}
					continue;
				case 171:
					num3 = 233 - 77;
					num2 = 69;
					continue;
				case 25:
					num3 = 110 + 77;
					num2 = 88;
					continue;
				case 319:
					array[26] = (byte)num3;
					num2 = 268;
					continue;
				case 72:
					array2[3] = (byte)num4;
					num2 = 199;
					continue;
				case 128:
					array[17] = 44;
					num2 = 240;
					continue;
				case 124:
					array[12] = 133;
					num2 = 215;
					continue;
				case 295:
					array2[6] = 94;
					num2 = 148;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 95;
					}
					continue;
				case 43:
					array[23] = 30;
					num2 = 236;
					continue;
				case 30:
					array[19] = (byte)num3;
					num2 = 13;
					continue;
				case 139:
					num3 = 167 - 55;
					num2 = 65;
					continue;
				case 144:
					array[6] = 136;
					num2 = 283;
					continue;
				case 163:
					array[17] = (byte)num3;
					num2 = 128;
					continue;
				case 28:
					array[8] = 56;
					num2 = 302;
					continue;
				case 190:
					array[9] = 152;
					num2 = 39;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 145;
					}
					continue;
				case 282:
					lCU91MV81g7FItE82b(array3);
					num2 = 183;
					continue;
				case 272:
					array[16] = 126;
					num2 = 208;
					continue;
				case 120:
				{
					CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					oAMTUES3qfZKdD7e9G(cryptoStream, array6, 0, array6.Length);
					qxjSunk6gRIYWbsSlN(cryptoStream);
					R0HDldE1Ru = (byte[])NcRiTCl37YckVPmtOL(stream);
					JamXAJKupldmv4UZeW(stream);
					JamXAJKupldmv4UZeW(cryptoStream);
					num2 = 327;
					continue;
				}
				case 168:
				case 293:
					if (num5 >= array3.Length)
					{
						num2 = 324;
						if (!S84nICW6T6Vig0hTkt())
						{
							num2 = 243;
						}
						continue;
					}
					goto case 61;
				case 162:
					array[3] = 159;
					num2 = 306;
					if (bJ31R0I4PyTMsCmiKJ() != null)
					{
						num2 = 96;
					}
					continue;
				case 125:
					array[12] = (byte)num3;
					num2 = 298;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 105;
					}
					continue;
				case 257:
					array2[6] = (byte)num4;
					num2 = 23;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 295;
					}
					continue;
				case 195:
					array[22] = 161;
					num2 = 98;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 50;
					}
					continue;
				case 280:
					num4 = 11 + 50;
					num2 = 67;
					continue;
				case 86:
					JahDEBPjGy = 80;
					num2 = 169;
					if (bJ31R0I4PyTMsCmiKJ() != null)
					{
						num2 = 102;
					}
					continue;
				case 95:
					num3 = 235 - 78;
					num2 = 1;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 33;
					}
					continue;
				case 183:
					array4 = (byte[])b7rqLAPRt92ZK34n1s(DN1NmVBkITnlamOluB(tMmvmVecn));
					num2 = 49;
					continue;
				case 211:
					num3 = 111 + 81;
					num2 = 223;
					continue;
				case 291:
					array[22] = 117;
					num2 = 29;
					continue;
				case 167:
					array2[1] = 128;
					num2 = 42;
					if (S84nICW6T6Vig0hTkt())
					{
						num2 = 68;
					}
					continue;
				case 174:
					array[10] = (byte)num3;
					num2 = 320;
					continue;
				case 309:
					array2[11] = 161;
					num2 = 228;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 4;
					}
					continue;
				case 275:
					array[24] = (byte)num3;
					num2 = 112;
					continue;
				case 188:
					array2[15] = 154;
					num2 = 229;
					continue;
				case 5:
					num3 = 154 - 51;
					num = 135;
					break;
				case 9:
					num3 = 95 + 56;
					num2 = 253;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 195;
					}
					continue;
				case 35:
				case 233:
					num5 = 0;
					num2 = 168;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 59;
					}
					continue;
				case 172:
					array[23] = (byte)num3;
					num2 = 245;
					continue;
				case 321:
					array[1] = (byte)num3;
					num2 = 181;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 247;
					}
					continue;
				case 12:
					array2[0] = 119;
					num2 = 315;
					continue;
				case 267:
					array3[5] = array4[2];
					num2 = 129;
					continue;
				case 117:
					array[29] = 96;
					num2 = 80;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 57;
					}
					continue;
				case 31:
					array[8] = (byte)num3;
					num2 = 332;
					continue;
				case 181:
					array[12] = 96;
					num2 = 124;
					continue;
				case 111:
					num4 = 183 - 61;
					num2 = 92;
					continue;
				case 85:
					array2[4] = 152;
					num2 = 0;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 127;
					}
					continue;
				case 269:
					array2[1] = (byte)num4;
					num2 = 297;
					continue;
				case 57:
					num3 = 58 + 73;
					num2 = 151;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 185;
					}
					continue;
				case 60:
					array[2] = (byte)num3;
					num2 = 25;
					if (S84nICW6T6Vig0hTkt())
					{
						num2 = 26;
					}
					continue;
				case 151:
					array[4] = 138;
					num = 11;
					break;
				case 204:
					array3[1] = array4[0];
					num2 = 14;
					if (bJ31R0I4PyTMsCmiKJ() != null)
					{
						num2 = 14;
					}
					continue;
				case 230:
					num4 = 146 - 48;
					num2 = 104;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 210;
					}
					continue;
				case 16:
					array[14] = 208;
					num = 263;
					break;
				case 259:
					array[2] = 102;
					num2 = 166;
					continue;
				case 199:
					array2[3] = 209;
					num = 164;
					break;
				case 55:
					num3 = 126 + 117;
					num2 = 251;
					continue;
				case 304:
					array[30] = 161;
					num2 = 16;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 136;
					}
					continue;
				case 318:
					array[2] = (byte)num3;
					num2 = 180;
					if (bJ31R0I4PyTMsCmiKJ() != null)
					{
						num2 = 8;
					}
					continue;
				case 123:
					num3 = 102 + 108;
					num2 = 112;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 314;
					}
					continue;
				case 196:
					array[11] = 138;
					num2 = 243;
					continue;
				case 330:
					array[30] = (byte)num3;
					num2 = 278;
					continue;
				case 299:
					num3 = 230 - 76;
					num2 = 125;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 86;
					}
					continue;
				case 182:
					num3 = 114 + 67;
					num2 = 47;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 47;
					}
					continue;
				case 2:
					array[18] = 126;
					num2 = 123;
					continue;
				case 135:
					array[7] = (byte)num3;
					num2 = 41;
					continue;
				case 66:
					if (array4.Length != 0)
					{
						num2 = 204;
						continue;
					}
					goto case 35;
				case 131:
					num3 = 162 - 54;
					num2 = 319;
					continue;
				case 209:
					num3 = 93 - 88;
					num2 = 205;
					if (bJ31R0I4PyTMsCmiKJ() != null)
					{
						num2 = 55;
					}
					continue;
				case 173:
					array2[5] = (byte)num4;
					num2 = 333;
					continue;
				case 219:
					array2[5] = 73;
					num2 = 237;
					continue;
				case 296:
					array[2] = 81;
					num2 = 259;
					continue;
				case 285:
					array[10] = (byte)num3;
					num2 = 308;
					continue;
				case 303:
					array2[15] = 85;
					num2 = 38;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 323;
					}
					continue;
				case 228:
					num4 = 184 - 61;
					num2 = 325;
					continue;
				case 193:
					array[13] = 157;
					num2 = 182;
					continue;
				case 89:
					array2[4] = 67;
					num2 = 249;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 130;
					}
					continue;
				case 265:
					array[2] = 63;
					num2 = 296;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 29;
					}
					continue;
				case 97:
					array[27] = (byte)num3;
					num2 = 99;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 58;
					}
					continue;
				case 70:
					array[19] = 99;
					num2 = 119;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 32;
					}
					continue;
				case 115:
					array[25] = 86;
					num2 = 139;
					continue;
				case 91:
					array[31] = 221;
					num2 = 100;
					if (bJ31R0I4PyTMsCmiKJ() != null)
					{
						num2 = 43;
					}
					continue;
				case 80:
					array[29] = 116;
					num2 = 20;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 55;
					}
					continue;
				case 118:
					array[13] = (byte)num3;
					num2 = 239;
					continue;
				case 52:
					array[15] = 169;
					num2 = 147;
					continue;
				case 201:
					array2[8] = 29;
					num2 = 206;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 187;
					}
					continue;
				case 324:
					if (P_1 == -1)
					{
						num2 = 329;
						continue;
					}
					goto case 252;
				case 242:
					array[24] = 74;
					num2 = 7;
					if (S84nICW6T6Vig0hTkt())
					{
						num2 = 217;
					}
					continue;
				case 301:
					num3 = 75 + 124;
					num2 = 48;
					continue;
				case 34:
					array2[9] = (byte)num4;
					num2 = 227;
					continue;
				case 76:
					num3 = 251 - 83;
					num2 = 163;
					continue;
				case 334:
					array[22] = (byte)num3;
					num2 = 64;
					continue;
				case 112:
					num3 = 206 - 68;
					num2 = 26;
					if (S84nICW6T6Vig0hTkt())
					{
						num2 = 84;
					}
					continue;
				case 161:
					array[19] = (byte)num3;
					num2 = 59;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 152;
					}
					continue;
				case 138:
					array2[6] = 89;
					num2 = 4;
					continue;
				case 284:
					num3 = 229 - 76;
					num2 = 31;
					continue;
				case 143:
					array[11] = (byte)num3;
					num2 = 196;
					continue;
				case 102:
					num3 = 226 - 75;
					num2 = 337;
					continue;
				case 207:
					num3 = 158 - 52;
					num2 = 286;
					continue;
				case 184:
					array[0] = (byte)num3;
					num2 = 121;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 29;
					}
					continue;
				case 258:
					array[20] = (byte)num3;
					num2 = 246;
					continue;
				case 302:
					array[9] = 112;
					num2 = 94;
					if (bJ31R0I4PyTMsCmiKJ() != null)
					{
						num2 = 3;
					}
					continue;
				case 146:
					num3 = 200 - 66;
					num2 = 311;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 184;
					}
					continue;
				case 314:
					array[18] = (byte)num3;
					num2 = 41;
					if (S84nICW6T6Vig0hTkt())
					{
						num2 = 220;
					}
					continue;
				case 322:
					num3 = 226 - 75;
					num2 = 7;
					continue;
				case 248:
					array2 = new byte[16];
					num2 = 12;
					if (bJ31R0I4PyTMsCmiKJ() != null)
					{
						num2 = 11;
					}
					continue;
				case 238:
					num3 = 229 - 76;
					num2 = 335;
					continue;
				case 311:
					array[1] = (byte)num3;
					num2 = 209;
					if (bJ31R0I4PyTMsCmiKJ() != null)
					{
						num2 = 152;
					}
					continue;
				case 39:
					array2[8] = (byte)num4;
					num2 = 133;
					continue;
				case 98:
					num3 = 150 - 50;
					num2 = 292;
					continue;
				case 327:
					array6 = R0HDldE1Ru;
					num = 252;
					break;
				case 56:
					array2[9] = 103;
					num2 = 111;
					continue;
				case 197:
					array[9] = (byte)num3;
					num2 = 225;
					continue;
				case 286:
					array[19] = (byte)num3;
					num2 = 3;
					if (S84nICW6T6Vig0hTkt())
					{
						num2 = 3;
					}
					continue;
				case 187:
					array2[4] = 141;
					num2 = 219;
					continue;
				case 51:
					array2[13] = 118;
					num2 = 230;
					continue;
				case 251:
					array[29] = (byte)num3;
					num2 = 5;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 105;
					}
					continue;
				case 224:
					array3[9] = array4[4];
					num2 = 6;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 1;
					}
					continue;
				case 236:
					num3 = 155 - 51;
					num = 275;
					break;
				case 227:
					array2[10] = 124;
					num2 = 46;
					continue;
				case 58:
					array2[7] = 141;
					num2 = 69;
					if (S84nICW6T6Vig0hTkt())
					{
						num2 = 113;
					}
					continue;
				case 122:
					array2[2] = 66;
					num2 = 89;
					if (S84nICW6T6Vig0hTkt())
					{
						num2 = 331;
					}
					continue;
				case 126:
					array[5] = 94;
					num2 = 132;
					continue;
				case 175:
					num3 = 187 - 62;
					num2 = 172;
					continue;
				case 300:
					array[27] = (byte)num3;
					num2 = 8;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 5;
					}
					continue;
				case 336:
					array[26] = (byte)num3;
					num2 = 59;
					continue;
				case 71:
					array[7] = 132;
					num2 = 5;
					continue;
				case 88:
					array[1] = (byte)num3;
					num2 = 191;
					continue;
				case 194:
					array[30] = 110;
					num2 = 202;
					continue;
				case 3:
					num3 = 27 + 117;
					num = 30;
					break;
				case 298:
					array[12] = 95;
					num2 = 244;
					if (bJ31R0I4PyTMsCmiKJ() != null)
					{
						num2 = 200;
					}
					continue;
				case 116:
					array2[14] = (byte)num4;
					num = 109;
					break;
				case 328:
					array[6] = (byte)num3;
					num2 = 108;
					continue;
				case 234:
					array[6] = (byte)num3;
					num = 71;
					break;
				case 333:
					array2[5] = 156;
					num2 = 37;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 16;
					}
					continue;
				case 316:
					array[3] = (byte)num3;
					num2 = 54;
					continue;
				case 23:
					array[12] = 117;
					num2 = 181;
					if (bJ31R0I4PyTMsCmiKJ() != null)
					{
						num2 = 55;
					}
					continue;
				case 21:
					array = new byte[32];
					num = 216;
					break;
				case 178:
					array2[2] = 149;
					num2 = 122;
					continue;
				case 203:
					array2[11] = 100;
					num2 = 19;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 226;
					}
					continue;
				case 189:
					array[28] = (byte)num3;
					num2 = 212;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 31;
					}
					continue;
				case 254:
					num3 = 0 + 72;
					num2 = 0;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 20;
					}
					continue;
				case 270:
					array[31] = 39;
					num2 = 19;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 91;
					}
					continue;
				case 191:
					array[1] = 124;
					num2 = 0;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 1;
					}
					continue;
				case 164:
					num4 = 216 - 72;
					num2 = 273;
					continue;
				case 278:
					array[31] = 86;
					num2 = 17;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 270;
					}
					continue;
				case 83:
					array2[5] = 143;
					num2 = 24;
					continue;
				case 92:
					array2[9] = (byte)num4;
					num2 = 130;
					continue;
				case 306:
					num3 = 132 - 44;
					num2 = 153;
					continue;
				case 36:
					stream = (Stream)v2TsDByfMryH4eLMp5();
					num2 = 120;
					continue;
				case 69:
					array[6] = (byte)num3;
					num2 = 10;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 8;
					}
					continue;
				case 20:
					array[14] = (byte)num3;
					num2 = 16;
					continue;
				case 24:
					array2[6] = 152;
					num2 = 138;
					continue;
				case 104:
					array[7] = (byte)num3;
					num2 = 284;
					continue;
				case 130:
					array2[9] = 209;
					num2 = 241;
					continue;
				case 288:
					array2[11] = 98;
					num2 = 203;
					continue;
				case 108:
					array[6] = 112;
					num2 = 171;
					continue;
				case 10:
					num3 = 217 + 30;
					num2 = 3;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 234;
					}
					continue;
				case 202:
					array[30] = 140;
					num2 = 244;
					if (S84nICW6T6Vig0hTkt())
					{
						num2 = 304;
					}
					continue;
				case 29:
					array[23] = 132;
					num2 = 175;
					continue;
				case 214:
					array[21] = 35;
					num2 = 102;
					continue;
				case 140:
					array[3] = 137;
					num2 = 87;
					continue;
				case 289:
					array[25] = (byte)num3;
					num2 = 115;
					continue;
				case 11:
					array[4] = 14;
					num2 = 40;
					continue;
				case 213:
					array[5] = 116;
					num2 = 144;
					if (bJ31R0I4PyTMsCmiKJ() != null)
					{
						num2 = 38;
					}
					continue;
				case 166:
					num3 = 182 - 60;
					num2 = 318;
					continue;
				case 136:
					num3 = 195 - 112;
					num2 = 330;
					continue;
				case 247:
					array[1] = 66;
					num2 = 146;
					continue;
				case 121:
					array[0] = 93;
					num2 = 261;
					continue;
				case 44:
					array[16] = 157;
					num2 = 0;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 0;
					}
					continue;
				case 210:
					array2[13] = (byte)num4;
					num2 = 155;
					continue;
				case 38:
					array2[4] = (byte)num4;
					num2 = 89;
					continue;
				default:
					array[16] = 152;
					num2 = 238;
					continue;
				case 273:
					array2[4] = (byte)num4;
					num2 = 85;
					if (bJ31R0I4PyTMsCmiKJ() != null)
					{
						num2 = 32;
					}
					continue;
				case 239:
					array[13] = 177;
					num2 = 107;
					continue;
				case 100:
					array5 = array;
					num2 = 248;
					continue;
				case 37:
					num4 = 1 + 61;
					num2 = 277;
					continue;
				case 132:
					array[5] = 195;
					num2 = 213;
					continue;
				case 22:
				{
					O6dh0ELPRTc6CQahBP o6dh0ELPRTc6CQahBP = new O6dh0ELPRTc6CQahBP(P_0);
					vMLxa24xeEWRIVXWEl(kl4BP1r7jjscgjbuBE(o6dh0ELPRTc6CQahBP), 0L);
					array6 = (byte[])sa5qxYLP6wVk3T5rDQ(o6dh0ELPRTc6CQahBP, (int)FilKn2inMeLbb0UD2u(kl4BP1r7jjscgjbuBE(o6dh0ELPRTc6CQahBP)));
					RPvEdCtYX0Mj3CSlL9(o6dh0ELPRTc6CQahBP);
					num2 = 21;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 9;
					}
					continue;
				}
				case 229:
					array2[15] = 185;
					num2 = 165;
					if (bJ31R0I4PyTMsCmiKJ() != null)
					{
						num2 = 105;
					}
					continue;
				case 216:
					num3 = 171 - 57;
					num2 = 98;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 184;
					}
					continue;
				case 15:
					array2[13] = 85;
					num2 = 51;
					continue;
				case 54:
					array[3] = 162;
					num2 = 279;
					continue;
				case 252:
					if (!QQjpouv8xU14qWEG5q(CIAsgbhNWmQLZ56BTk(tMmvmVecn), null))
					{
						num2 = 262;
						if (!S84nICW6T6Vig0hTkt())
						{
							num2 = 41;
						}
						continue;
					}
					goto case 86;
				case 133:
					array2[8] = 227;
					num2 = 201;
					if (bJ31R0I4PyTMsCmiKJ() != null)
					{
						num2 = 188;
					}
					continue;
				case 99:
					num3 = 95 + 34;
					num2 = 189;
					if (S84nICW6T6Vig0hTkt())
					{
						num2 = 189;
					}
					continue;
				case 47:
					array[13] = (byte)num3;
					num2 = 31;
					if (S84nICW6T6Vig0hTkt())
					{
						num2 = 176;
					}
					continue;
				case 332:
					array[8] = 161;
					num2 = 28;
					continue;
				case 320:
					num3 = 171 + 77;
					num2 = 285;
					continue;
				case 93:
					array2[10] = (byte)num4;
					num = 157;
					break;
				case 297:
					array2[1] = 215;
					num2 = 96;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 167;
					}
					continue;
				case 246:
					num3 = 125 - 41;
					num2 = 110;
					continue;
				case 200:
					array2[3] = 92;
					num2 = 114;
					if (S84nICW6T6Vig0hTkt())
					{
						num2 = 266;
					}
					continue;
				case 49:
					if (array4 == null)
					{
						num2 = 25;
						if (S84nICW6T6Vig0hTkt())
						{
							num2 = 35;
						}
						continue;
					}
					goto case 66;
				case 315:
					num4 = 160 - 53;
					num2 = 221;
					continue;
				case 305:
					array2[12] = 231;
					num2 = 114;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 134;
					}
					continue;
				case 237:
					num4 = 216 - 72;
					num2 = 124;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 173;
					}
					continue;
				case 96:
					array[20] = 105;
					num = 281;
					break;
				case 249:
					array2[4] = 237;
					num2 = 187;
					continue;
				case 68:
					array2[1] = 199;
					num2 = 79;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 30;
					}
					continue;
				case 48:
					array[22] = (byte)num3;
					num = 195;
					break;
				case 225:
					array[10] = 94;
					num2 = 170;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 256;
					}
					continue;
				case 287:
					num4 = 112 - 70;
					num2 = 34;
					continue;
				case 137:
					num4 = 16 + 109;
					num2 = 233;
					if (S84nICW6T6Vig0hTkt())
					{
						num2 = 269;
					}
					continue;
				case 222:
					array2[9] = (byte)num4;
					num2 = 56;
					continue;
				case 279:
					array[3] = 130;
					num2 = 140;
					continue;
				case 145:
					num3 = 49 + 124;
					num = 197;
					break;
				case 65:
					array[26] = (byte)num3;
					num2 = 131;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 123;
					}
					continue;
				case 13:
					num3 = 24 + 37;
					num2 = 161;
					continue;
				case 17:
					num4 = 138 + 55;
					num2 = 231;
					continue;
				case 208:
					num3 = 227 - 75;
					num2 = 158;
					continue;
				case 141:
					num3 = 208 - 69;
					num2 = 328;
					continue;
				case 255:
					num3 = 26 + 84;
					num2 = 198;
					if (S84nICW6T6Vig0hTkt())
					{
						num2 = 334;
					}
					continue;
				case 313:
					num3 = 181 + 52;
					num2 = 97;
					if (bJ31R0I4PyTMsCmiKJ() != null)
					{
						num2 = 39;
					}
					continue;
				case 19:
					array[5] = 150;
					num2 = 126;
					continue;
				case 185:
					array[0] = (byte)num3;
					num2 = 4;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 25;
					}
					continue;
				case 150:
					num5++;
					num2 = 293;
					continue;
				case 261:
					array[0] = 14;
					num = 57;
					break;
				case 81:
					array[29] = 215;
					num = 117;
					break;
				case 250:
					num4 = 231 - 77;
					num2 = 156;
					continue;
				case 241:
					num4 = 98 + 90;
					num2 = 78;
					continue;
				case 292:
					array[22] = (byte)num3;
					num2 = 291;
					if (bJ31R0I4PyTMsCmiKJ() != null)
					{
						num2 = 254;
					}
					continue;
				case 107:
					array[14] = 180;
					num2 = 254;
					continue;
				case 276:
					array[16] = 118;
					num2 = 64;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 272;
					}
					continue;
				case 176:
					num3 = 164 - 54;
					num2 = 118;
					if (bJ31R0I4PyTMsCmiKJ() != null)
					{
						num2 = 31;
					}
					continue;
				case 75:
					array[23] = (byte)num3;
					num2 = 13;
					if (S84nICW6T6Vig0hTkt())
					{
						num2 = 43;
					}
					continue;
				case 73:
					array[18] = 131;
					num2 = 177;
					continue;
				case 312:
					return;
				case 290:
					num3 = 69 + 103;
					num2 = 160;
					continue;
				case 113:
					num4 = 138 - 46;
					num2 = 159;
					continue;
				case 206:
					num4 = 201 - 67;
					num2 = 129;
					if (S84nICW6T6Vig0hTkt())
					{
						num2 = 222;
					}
					continue;
				case 274:
					array3[13] = array4[6];
					num2 = 42;
					if (S84nICW6T6Vig0hTkt())
					{
						num2 = 82;
					}
					continue;
				case 226:
					array2[11] = 29;
					num2 = 129;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 305;
					}
					continue;
				case 218:
					num3 = 247 - 82;
					num = 75;
					break;
				case 329:
				{
					object obj = Tvs1lEnopWD1TCpgfi();
					GTpesoZqi1nUCEfDLk(obj, CipherMode.CBC);
					transform = (ICryptoTransform)LYfVwI9GyYDa1TyOXo(obj, array5, array3);
					num2 = 36;
					continue;
				}
				case 114:
					array[6] = (byte)num3;
					num2 = 129;
					if (S84nICW6T6Vig0hTkt())
					{
						num2 = 141;
					}
					continue;
				case 94:
					array[9] = 166;
					num2 = 190;
					continue;
				case 154:
					num4 = 189 + 39;
					num2 = 264;
					continue;
				case 331:
					array2[3] = 219;
					num = 142;
					break;
				case 326:
					array2[15] = (byte)num4;
					num2 = 188;
					if (bJ31R0I4PyTMsCmiKJ() != null)
					{
						num2 = 50;
					}
					continue;
				case 325:
					array2[11] = (byte)num4;
					num2 = 215;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 250;
					}
					continue;
				case 158:
					array[17] = (byte)num3;
					num2 = 53;
					continue;
				case 277:
					array2[5] = (byte)num4;
					num2 = 83;
					continue;
				case 7:
					array[28] = (byte)num3;
					num2 = 9;
					continue;
				case 84:
					array[24] = (byte)num3;
					num2 = 12;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 242;
					}
					continue;
				case 106:
					array2[15] = (byte)num4;
					num2 = 50;
					continue;
				case 283:
					num3 = 172 - 57;
					num2 = 114;
					continue;
				case 240:
					array[18] = 152;
					num2 = 2;
					continue;
				case 41:
					num3 = 55 - 10;
					num2 = 104;
					continue;
				case 90:
					array[18] = (byte)num3;
					num = 73;
					break;
				case 4:
					num4 = 7 + 31;
					num2 = 121;
					if (S84nICW6T6Vig0hTkt())
					{
						num2 = 257;
					}
					continue;
				case 63:
					num4 = 83 + 122;
					num2 = 93;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 88;
					}
					continue;
				case 160:
					array[21] = (byte)num3;
					num2 = 57;
					if (S84nICW6T6Vig0hTkt())
					{
						num2 = 255;
					}
					continue;
				case 335:
					array[16] = (byte)num3;
					num2 = 211;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 84;
					}
					continue;
				case 220:
					num3 = 109 + 77;
					num2 = 90;
					continue;
				case 110:
					array[20] = (byte)num3;
					num = 96;
					break;
				case 8:
					array[27] = 132;
					num2 = 313;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 265;
					}
					continue;
				case 79:
					array2[2] = 149;
					num2 = 178;
					continue;
				case 169:
				case 262:
					new gBMthepoZSL1ZVKpeA().N3ftclil2(array5, array3, array6);
					num2 = 312;
					continue;
				case 129:
					array3[7] = array4[3];
					num2 = 224;
					continue;
				case 308:
					num3 = 236 - 78;
					num2 = 95;
					if (S84nICW6T6Vig0hTkt())
					{
						num2 = 143;
					}
					continue;
				case 82:
					array3[15] = array4[7];
					num2 = 97;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 233;
					}
					continue;
				case 223:
					array[16] = (byte)num3;
					num2 = 3;
					if (S84nICW6T6Vig0hTkt())
					{
						num2 = 276;
					}
					continue;
				case 235:
					array[30] = 35;
					num2 = 89;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 194;
					}
					continue;
				case 50:
					num4 = 105 + 5;
					num2 = 326;
					continue;
				case 281:
					num3 = 248 - 82;
					num2 = 74;
					continue;
				case 266:
					num4 = 194 - 64;
					num2 = 72;
					continue;
				case 87:
					array[3] = 175;
					num2 = 162;
					continue;
				case 45:
					array[17] = 142;
					num2 = 26;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 76;
					}
					continue;
				case 74:
					array[20] = (byte)num3;
					num2 = 27;
					continue;
				case 77:
					array[26] = (byte)num3;
					num = 192;
					break;
				case 307:
					array2[14] = 239;
					num2 = 303;
					continue;
				case 256:
					num3 = 109 + 33;
					num2 = 174;
					continue;
				case 217:
					array[25] = 150;
					num2 = 310;
					continue;
				case 64:
					array[22] = 164;
					num2 = 66;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 301;
					}
					continue;
				case 165:
					array3 = array2;
					num2 = 282;
					continue;
				case 260:
					num4 = 5 + 79;
					num = 39;
					break;
				case 6:
					array3[11] = array4[5];
					num2 = 274;
					continue;
				case 205:
					array[1] = (byte)num3;
					num2 = 265;
					continue;
				case 119:
					num3 = 175 - 58;
					num2 = 131;
					if (S84nICW6T6Vig0hTkt())
					{
						num2 = 258;
					}
					continue;
				case 32:
					array2[15] = (byte)num4;
					num2 = 294;
					continue;
				case 14:
					array3[3] = array4[1];
					num2 = 267;
					continue;
				case 179:
					num3 = 183 - 61;
					num2 = 103;
					continue;
				case 215:
					array[13] = 119;
					num2 = 193;
					if (bJ31R0I4PyTMsCmiKJ() != null)
					{
						num2 = 145;
					}
					continue;
				case 103:
					array[29] = (byte)num3;
					num2 = 27;
					if (S84nICW6T6Vig0hTkt())
					{
						num2 = 81;
					}
					continue;
				case 323:
					num4 = 20 + 58;
					num2 = 32;
					if (bJ31R0I4PyTMsCmiKJ() != null)
					{
						num2 = 21;
					}
					continue;
				case 271:
					array2[10] = 126;
					num2 = 63;
					continue;
				case 263:
					array[15] = 140;
					num2 = 52;
					continue;
				case 62:
					array2[13] = (byte)num4;
					num2 = 317;
					continue;
				case 268:
					array[26] = 118;
					num2 = 10;
					if (bJ31R0I4PyTMsCmiKJ() == null)
					{
						num2 = 18;
					}
					continue;
				case 142:
					array2[3] = 206;
					num2 = 200;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 38;
					}
					continue;
				case 337:
					array[21] = (byte)num3;
					num2 = 290;
					continue;
				case 148:
					array2[6] = 50;
					num2 = 58;
					if (!S84nICW6T6Vig0hTkt())
					{
						num2 = 7;
					}
					continue;
				case 105:
					array[30] = 68;
					num2 = 235;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string wsO7HTGYd(int P_0)
	{
		if (R0HDldE1Ru.Length == 0)
		{
			REMDXAIXxD = new List<string>();
			cHBDpy418J = new List<int>();
			tDSJJEF6p(tMmvmVecn.GetManifestResourceStream("Md7ic5FvtxlEolh6bD.341CiWQmg3aa1AN1K0"), P_0);
		}
		if (JahDEBPjGy < 75)
		{
			if (tMmvmVecn != new StackFrame(1).GetMethod().DeclaringType.Assembly)
			{
				throw new Exception();
			}
			JahDEBPjGy++;
		}
		lock (r2wDDRFjyc)
		{
			int num = BitConverter.ToInt32(R0HDldE1Ru, P_0);
			if (num < cHBDpy418J.Count && cHBDpy418J[num] == P_0)
			{
				return REMDXAIXxD[num];
			}
			try
			{
				dil2BPgckjnUlJwuku.UrZapk9nD();
				byte[] array = new byte[num];
				Array.Copy(R0HDldE1Ru, P_0 + 4, array, 0, num);
				string @string = Encoding.Unicode.GetString(array, 0, array.Length);
				REMDXAIXxD.Add(@string);
				cHBDpy418J.Add(P_0);
				Array.Copy(BitConverter.GetBytes(REMDXAIXxD.Count - 1), 0, R0HDldE1Ru, P_0, 4);
				return @string;
			}
			catch
			{
			}
		}
		return "";
	}

	internal static string T1sZb1VvD(string P_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(P_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int Y0HBSFcr0()
	{
		return 5;
	}

	private static void TVtwfqXgW()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate XRm2fXgqD(IntPtr P_0, Type P_1)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[2] { P_0, P_1 });
	}

	internal static object NPhL76lHM(object P_0)
	{
		try
		{
			if (File.Exists(((Assembly)P_0).Location))
			{
				return ((Assembly)P_0).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)P_0).GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return ((Assembly)P_0).GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(P_0.GetType().GetProperty("Location").GetValue(P_0, new object[0])
				.ToString()))
			{
				return P_0.GetType().GetProperty("Location").GetValue(P_0, new object[0])
					.ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	[DllImport("kernel32", EntryPoint = "LoadLibrary")]
	public static extern IntPtr E4kWl7sCS(string P_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	public static extern IntPtr TpiOUewQV(IntPtr P_0, string P_1);

	private static IntPtr El3oll2gB(IntPtr P_0, string P_1, uint P_2)
	{
		if (DdlDZkxONl == null)
		{
			DdlDZkxONl = (EGys2wWRFjycbEMAIX)Marshal.GetDelegateForFunctionPointer(TpiOUewQV(xTuFFuFOZ(), "Find ".Trim() + "ResourceA"), typeof(EGys2wWRFjycbEMAIX));
		}
		return DdlDZkxONl(P_0, P_1, P_2);
	}

	private static IntPtr PKsnxK0wr(IntPtr P_0, uint P_1, uint P_2, uint P_3)
	{
		if (sPnDBtdmpC == null)
		{
			sPnDBtdmpC = (qDpHByO418JF0HdE1R)Marshal.GetDelegateForFunctionPointer(TpiOUewQV(xTuFFuFOZ(), "Virtual ".Trim() + "Alloc"), typeof(qDpHByO418JF0HdE1R));
		}
		return sPnDBtdmpC(P_0, P_1, P_2, P_3);
	}

	private static int Woa9C06rA(IntPtr P_0, IntPtr P_1, [In][Out] byte[] P_2, uint P_3, out IntPtr P_4)
	{
		if (C0TDwuRAdm == null)
		{
			C0TDwuRAdm = (jDIuK3og8jGii502q8)Marshal.GetDelegateForFunctionPointer(TpiOUewQV(xTuFFuFOZ(), "Write ".Trim() + "Process ".Trim() + "Memory"), typeof(jDIuK3og8jGii502q8));
		}
		return C0TDwuRAdm(P_0, P_1, P_2, P_3, out P_4);
	}

	private static int weAfrU7CZ(IntPtr P_0, int P_1, int P_2, ref int P_3)
	{
		if (WaOD28GCXh == null)
		{
			WaOD28GCXh = (yELBDsnIOkP2xpqE5M)Marshal.GetDelegateForFunctionPointer(TpiOUewQV(xTuFFuFOZ(), "Virtual ".Trim() + "Protect"), typeof(yELBDsnIOkP2xpqE5M));
		}
		return WaOD28GCXh(P_0, P_1, P_2, ref P_3);
	}

	private static IntPtr MEpjih5pT(uint P_0, int P_1, uint P_2)
	{
		if (FbxDIgIUp6 == null)
		{
			FbxDIgIUp6 = (HiQw6R9JAsUpCLlJBT)Marshal.GetDelegateForFunctionPointer(TpiOUewQV(xTuFFuFOZ(), "Open ".Trim() + "Process"), typeof(HiQw6R9JAsUpCLlJBT));
		}
		return FbxDIgIUp6(P_0, P_1, P_2);
	}

	private static int rSXaIHKet(IntPtr P_0)
	{
		if (srHDLNNYti == null)
		{
			srHDLNNYti = (J10w5Rf973Fgv8P7Wd)Marshal.GetDelegateForFunctionPointer(TpiOUewQV(xTuFFuFOZ(), "Close ".Trim() + "Handle"), typeof(J10w5Rf973Fgv8P7Wd));
		}
		return srHDLNNYti(P_0);
	}

	[SpecialName]
	private static IntPtr xTuFFuFOZ()
	{
		if (JQMDW05qHS == IntPtr.Zero)
		{
			JQMDW05qHS = E4kWl7sCS("kernel ".Trim() + "32.dll");
		}
		return JQMDW05qHS;
	}

	private static byte[] jq5eeqteH(string P_0)
	{
		using FileStream fileStream = new FileStream(P_0, FileMode.Open, FileAccess.Read, FileShare.Read);
		int num = 0;
		int num2 = (int)fileStream.Length;
		byte[] array = new byte[num2];
		while (num2 > 0)
		{
			int num3 = fileStream.Read(array, num, num2);
			num += num3;
			num2 -= num3;
		}
		return array;
	}

	internal static Stream ATdCBt6nT()
	{
		return new MemoryStream();
	}

	internal static byte[] Gd54uN8KB(Stream P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	private static byte[] Lmh3AWZ0o(byte[] P_0)
	{
		Stream stream = ATdCBt6nT();
		SymmetricAlgorithm symmetricAlgorithm = vPcVkjnUl();
		symmetricAlgorithm.Key = new byte[32]
		{
			42, 37, 48, 56, 139, 38, 220, 46, 196, 95,
			47, 23, 135, 0, 36, 57, 99, 194, 7, 193,
			160, 148, 241, 221, 241, 14, 200, 146, 194, 250,
			254, 96
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			178, 174, 251, 117, 75, 21, 196, 181, 132, 93,
			207, 73, 188, 211, 223, 99
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(P_0, 0, P_0.Length);
		cryptoStream.Close();
		byte[] result = Gd54uN8KB(stream);
		dil2BPgckjnUlJwuku.UrZapk9nD();
		return result;
	}

	private byte[] kSKQGkVrD()
	{
		return null;
	}

	private byte[] AG3h8lRto()
	{
		return null;
	}

	private byte[] liQrAUlfm()
	{
		_ = "{11111-22222-20001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	private byte[] KcXPhPgAT()
	{
		_ = "{11111-22222-20001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	private byte[] PPsAxmh8m()
	{
		_ = "{11111-22222-30001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	private byte[] c7aSUYdNQ()
	{
		_ = "{11111-22222-30001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] YMJ1GVyMA()
	{
		_ = "{11111-22222-40001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] qBFNbm6pe()
	{
		_ = "{11111-22222-40001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] CPMq6MtTN()
	{
		_ = "{11111-22222-50001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] rOqbi52iJ()
	{
		_ = "{11111-22222-50001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal static object kl4BP1r7jjscgjbuBE(object P_0)
	{
		return ((O6dh0ELPRTc6CQahBP)P_0).nW4lBacjpc();
	}

	internal static void vMLxa24xeEWRIVXWEl(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long FilKn2inMeLbb0UD2u(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object sa5qxYLP6wVk3T5rDQ(object P_0, int P_1)
	{
		return ((O6dh0ELPRTc6CQahBP)P_0).sMLlkdoJ60(P_1);
	}

	internal static void RPvEdCtYX0Mj3CSlL9(object P_0)
	{
		((O6dh0ELPRTc6CQahBP)P_0).QEmlZSRGOw();
	}

	internal static void lCU91MV81g7FItE82b(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	internal static object DN1NmVBkITnlamOluB(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object b7rqLAPRt92ZK34n1s(object P_0)
	{
		return ((AssemblyName)P_0).GetPublicKeyToken();
	}

	internal static object Tvs1lEnopWD1TCpgfi()
	{
		return vPcVkjnUl();
	}

	internal static void GTpesoZqi1nUCEfDLk(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	internal static object LYfVwI9GyYDa1TyOXo(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[]?)P_2);
	}

	internal static object v2TsDByfMryH4eLMp5()
	{
		return ATdCBt6nT();
	}

	internal static void oAMTUES3qfZKdD7e9G(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void qxjSunk6gRIYWbsSlN(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object NcRiTCl37YckVPmtOL(object P_0)
	{
		return Gd54uN8KB((Stream)P_0);
	}

	internal static void JamXAJKupldmv4UZeW(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static object CIAsgbhNWmQLZ56BTk(object P_0)
	{
		return ((Assembly)P_0).EntryPoint;
	}

	internal static bool QQjpouv8xU14qWEG5q(object P_0, object P_1)
	{
		return (MethodInfo?)P_0 == (MethodInfo?)P_1;
	}

	internal static bool S84nICW6T6Vig0hTkt()
	{
		return (object)null == null;
	}

	internal static object bJ31R0I4PyTMsCmiKJ()
	{
		return null;
	}
}
