using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace ns0
{
	// Token: 0x020000C7 RID: 199
	internal sealed class Class159
	{
		// Token: 0x060007EE RID: 2030
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern IntPtr CreateFileMapping(IntPtr intptr_1, IntPtr intptr_2, Class159.Enum(19 enum19_0, uint uint_14, uint uint_15, string string_0);

		// Token: 0x060007EF RID: 2031
		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern bool UnmapViewOfFile(IntPtr intptr_1);

		// Token: 0x060007F0 RID: 2032
		[DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool GetVolumeInformation(string string_0, StringBuilder stringBuilder_0, int int_0, out uint uint_14, out uint uint_15, out Class159.Enum21 enum21_0, StringBuilder stringBuilder_1, int int_1);

		// Token: 0x060007F1 RID: 2033
		[DllImport("psapi")]
		internal static extern bool EnumProcesses([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4)] [In] [Out] int[] int_0, int int_1, [MarshalAs(UnmanagedType.U4)] out int int_2);

		// Token: 0x060007F2 RID: 2034
		[DllImport("kernel32.dll")]
		internal static extern int VirtualQueryEx(IntPtr intptr_1, IntPtr intptr_2, out Class159.Struct4 struct4_0, int int_0);

		// Token: 0x060007F3 RID: 2035
		[DllImport("kernel32.dll", EntryPoint = "VirtualQueryEx")]
		internal static extern int VirtualQueryEx_1(IntPtr intptr_1, IntPtr intptr_2, out Class159.Struct3 struct3_0, int int_0);

		// Token: 0x060007F4 RID: 2036
		[DllImport("user32.dll")]
		internal static extern short VkKeyScan(char char_0);

		// Token: 0x060007F5 RID: 2037
		[DllImport("user32.dll")]
		internal static extern IntPtr SetCapture(IntPtr intptr_1);

		// Token: 0x060007F6 RID: 2038
		[DllImport("user32.dll")]
		internal static extern bool ReleaseCapture();

		// Token: 0x060007F7 RID: 2039
		[DllImport("user32.dll")]
		internal static extern uint MapVirtualKey(uint uint_14, uint uint_15);

		// Token: 0x060007F8 RID: 2040
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool FreeLibrary(IntPtr intptr_1);

		// Token: 0x060007F9 RID: 2041
		[DllImport("user32.dll")]
		internal static extern int ShowWindow(IntPtr intptr_1, uint uint_14);

		// Token: 0x060007FA RID: 2042
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern IntPtr LoadLibrary(string string_0);

		// Token: 0x060007FB RID: 2043
		[DllImport("user32.dll", SetLastError = true)]
		internal static extern IntPtr FindWindow(string string_0, string string_1);

		// Token: 0x060007FC RID: 2044
		[DllImport("user32.dll", SetLastError = true)]
		internal static extern IntPtr FindWindowEx(IntPtr intptr_1, IntPtr intptr_2, string string_0, string string_1);

		// Token: 0x060007FD RID: 2045
		[DllImport("user32.dll", SetLastError = true)]
		internal static extern uint GetWindowThreadProcessId(IntPtr intptr_1, out uint uint_14);

		// Token: 0x060007FE RID: 2046
		[DllImport("user32", CharSet = CharSet.Auto)]
		public static extern int GetClassName(IntPtr intptr_1, StringBuilder stringBuilder_0, int int_0);

		// Token: 0x060007FF RID: 2047
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern uint RegisterWindowMessage(string string_0);

		// Token: 0x06000800 RID: 2048
		[DllImport("psapi.dll")]
		internal static extern uint GetModuleFileNameEx(IntPtr intptr_1, IntPtr intptr_2, StringBuilder stringBuilder_0, [MarshalAs(UnmanagedType.U4)] [In] int int_0);

		// Token: 0x06000801 RID: 2049
		[DllImport("psapi.dll")]
		internal static extern uint GetModuleBaseName(IntPtr intptr_1, IntPtr intptr_2, StringBuilder stringBuilder_0, uint uint_14);

		// Token: 0x06000802 RID: 2050
		[DllImport("user32.dll")]
		internal static extern bool RegisterHotKey(IntPtr intptr_1, int int_0, int int_1, int int_2);

		// Token: 0x06000803 RID: 2051
		[DllImport("user32.dll")]
		internal static extern bool UnregisterHotKey(IntPtr intptr_1, int int_0);

		// Token: 0x06000804 RID: 2052
		[DllImport("user32.dll")]
		internal static extern bool ClientToScreen(IntPtr intptr_1, ref Point point_0);

		// Token: 0x06000805 RID: 2053
		[DllImport("user32.dll")]
		internal static extern uint SendInput(uint uint_14, [MarshalAs(UnmanagedType.LPArray)] [In] Struct6[] struct6_0, int int_0);

		// Token: 0x06000806 RID: 2054
		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool PostMessage(IntPtr intptr_1, uint uint_14, IntPtr intptr_2, IntPtr intptr_3);

		// Token: 0x06000807 RID: 2055
		[DllImport("User32.dll")]
		internal static extern int SendMessage(int int_0, int int_1, int int_2, int int_3);

		// Token: 0x06000808 RID: 2056
		[DllImport("user32.dll")]
		internal static extern bool SetForegroundWindow(IntPtr intptr_1);

		// Token: 0x06000809 RID: 2057
		[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr memset(IntPtr intptr_1, int int_0, int int_1);

		// Token: 0x0600080A RID: 2058
		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern uint WaitForSingleObject(IntPtr intptr_1, uint uint_14);

		// Token: 0x0600080B RID: 2059
		[DllImport("kernel32.dll")]
		internal static extern bool ReleaseMutex(IntPtr intptr_1);

		// Token: 0x0600080C RID: 2060
		[DllImport("user32")]
		internal static extern int EnumWindows(Class159.Delegate6 delegate6_0, int int_0);

		// Token: 0x0600080D RID: 2061
		[DllImport("user32", CharSet = CharSet.Auto)]
		internal static extern int GetWindowText(IntPtr intptr_1, StringBuilder stringBuilder_0, int int_0);

		// Token: 0x0600080E RID: 2062
		[DllImport("user32")]
		public static extern int GetWindowRect(IntPtr intptr_1, ref Class159.Struct5 struct5_0);

		// Token: 0x0600080F RID: 2063
		[DllImport("kernel32.dll")]
		internal static extern IntPtr CreateMutex(IntPtr intptr_1, bool bool_0, string string_0);

		// Token: 0x06000810 RID: 2064
		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern IntPtr OpenProcess(uint uint_14, int int_0, uint uint_15);

		// Token: 0x06000811 RID: 2065
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool IsWow64Process([In] IntPtr intptr_1, [MarshalAs(UnmanagedType.Bool)] out bool bool_0);

		// Token: 0x06000812 RID: 2066
		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int CloseHandle(IntPtr intptr_1);

		// Token: 0x06000813 RID: 2067
		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern uint GetLastError();

		// Token: 0x06000814 RID: 2068
		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern IntPtr GetProcAddress(IntPtr intptr_1, string string_0);

		// Token: 0x06000815 RID: 2069
		[DllImport("user32.dll", SetLastError = true)]
		internal static extern IntPtr SetWindowsHookEx(Class159.Enum18 enum18_0, IntPtr intptr_1, uint uint_14);

		// Token: 0x06000816 RID: 2070
		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool UnhookWindowsHookEx(IntPtr intptr_1);

		// Token: 0x06000817 RID: 2071
		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern IntPtr GetModuleHandle(string string_0);

		// Token: 0x06000818 RID: 2072
		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern IntPtr VirtualAllocEx(IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, uint uint_14, uint uint_15);

		// Token: 0x06000819 RID: 2073
		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int WriteProcessMemory(IntPtr intptr_1, IntPtr intptr_2, byte[] byte_0, uint uint_14, int int_0);

		// Token: 0x0600081A RID: 2074
		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern bool VirtualProtect(IntPtr intptr_1, uint uint_14, uint uint_15, out uint uint_16);

		// Token: 0x0600081B RID: 2075
		[DllImport("kernel32.dll")]
		internal static extern bool VirtualProtectEx(IntPtr intptr_1, IntPtr intptr_2, UIntPtr uintptr_0, uint uint_14, out uint uint_15);

		// Token: 0x0600081C RID: 2076
		[DllImport("kernel32.dll")]
		internal static extern bool ReadProcessMemory(int int_0, IntPtr intptr_1, byte[] byte_0, uint uint_14, ref int int_1);

		// Token: 0x0600081D RID: 2077
		[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory")]
		internal static extern bool ReadProcessMemory_1(int int_0, uint uint_14, byte[] byte_0, uint uint_15, ref int int_1);

		// Token: 0x0600081E RID: 2078
		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern IntPtr CreateRemoteThread(IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4, IntPtr intptr_5, uint uint_14, IntPtr intptr_6);

		// Token: 0x0600081F RID: 2079
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern IntPtr OpenFileMapping(uint uint_14, bool bool_0, string string_0);

		// Token: 0x06000820 RID: 2080
		[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr memcpy(IntPtr intptr_1, IntPtr intptr_2, uint uint_14);

		// Token: 0x06000821 RID: 2081
		[DllImport("kernel32.dll")]
		internal static extern void CopyMemory(IntPtr intptr_1, IntPtr intptr_2, uint uint_14);

		// Token: 0x06000822 RID: 2082
		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern IntPtr MapViewOfFile(IntPtr intptr_1, uint uint_14, uint uint_15, uint uint_16, UIntPtr uintptr_0);

		// Token: 0x06000823 RID: 2083 RVA: 0x0000978E File Offset: 0x0000798E
		internal static int smethod_0(int int_0, int int_1)
		{
			return int_1 << 16 | (int_0 & 65535);
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x0000979C File Offset: 0x0000799C
		internal bool method_0(Process process_0)
		{
			return false;
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x0000979C File Offset: 0x0000799C
		internal bool method_1()
		{
			return false;
		}

		// Token: 0x06000826 RID: 2086
		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern void SetLastError(uint uint_14);

		// Token: 0x06000827 RID: 2087 RVA: 0x0009AE74 File Offset: 0x00099074
		internal static void smethod_1(IntPtr intptr_1)
		{
			IntPtr intPtr = 0;
			int num = 0;
			bool flag = false;
			for (;;)
			{
				Class159.Struct3 @struct = default(Class159.Struct3);
				Class159.GetLastError();
				Class159.SetLastError(0U);
				Class159.VirtualQueryEx_1(intptr_1, intPtr, out @struct, Marshal.SizeOf(@struct));
				Class159.GetLastError();
				if ((@struct.uint_4 & 4096U) != 0U && (@struct.uint_5 & 256U) == 0U)
				{
					Class159.Class160 @class = new Class159.Class160();
					@class.uint_1 = @struct.uint_1;
					@class.uint_2 = @struct.uint_2;
					@class.uint_0 = @struct.uint_0;
					@class.uint_5 = @struct.uint_5;
					@class.uint_3 = @struct.uint_3;
					@class.uint_4 = @struct.uint_4;
					@class.uint_6 = @struct.uint_6;
					Class159.list_0.Add(@class);
				}
				num++;
				try
				{
					intPtr = new IntPtr((long)((ulong)(@struct.uint_0 + @struct.uint_3)));
					goto IL_F7;
				}
				catch (Exception)
				{
					flag = true;
					goto IL_F7;
				}
				IL_6E:
				if (flag)
				{
					break;
				}
				continue;
				IL_F7:
				if ((int)intPtr >= 2147418112)
				{
					break;
				}
				goto IL_6E;
			}
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x0009AF98 File Offset: 0x00099198
		internal static int smethod_2(byte[] byte_0, byte[] byte_1)
		{
			try
			{
				int[] array = new int[256];
				int i = 0;
				int num = byte_1.Length - 1;
				for (int j = 0; j < 256; j++)
				{
					array[j] = byte_1.Length;
				}
				for (int k = 0; k < num; k++) { }
				{
					array[(int)byte_1[k]] = num - k;
				}
				int num2 = 0;
				while (i <= byte_0.Length - byte_1.Length)
				{
					int num3 = num;
					while (byte_0[i + num3] == byte_1[num3])
					{
						if (num3 == 0)
						{
							num2++;
							return i;
						}
						num3--;
					}
					i += array[(int)byte_0[i + num]];
				}
			}
			catch (Exception)
			{
			}
			return -1;
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x0009B044 File Offset: 0x00099244
		internal static int smethod_3(IntPtr intptr_1, byte[] byte_0, int int_0 = 0, bool bool_0 = false, int int_1 = 0, int int_2 = 0)
		{
			if (intptr_1 == IntPtr.Zero)
			{
				return 0;
			}
			if (Class159.list_0.Count == 0)
			{
				Class159.smethod_1(intptr_1);
			}
			int num = 0;
			int num2 = -1;
			for (int i = 0; i < Class159.list_0.Count; i++)
			{
				try
				{
					byte[] byte_ = new byte[Class159.list_0[i].uint_3];
					Class159.ReadProcessMemory((int)intptr_1, (IntPtr)((long)((ulong)Class159.list_0[i].uint_0)), byte_, Class159.list_0[i].uint_3, ref num);
					int num3 = Class159.smethod_2(byte_, byte_0);
					if (num3 >= 0)
					{
						uint num4 = Class159.list_0[i].uint_0 + (uint)num3;
						uint num5 = num4;
						if (bool_0)
						{
							num4 += (uint)int_1;
							byte[] array = new byte[4];
							Class159.ReadProcessMemory_1((int)intptr_1, num4, array, 4U, ref num);
							num5 = BitConverter.ToUInt32(array, 0);
						}
						if (num5 != 0U)
						{
							num5 += (uint)int_2;
						}
						if (num5 > 0U)
						{
							num2++;
							if (num2 >= int_0)
							{
								return (int)num5;
							}
						}
					}
				}
				catch (Exception)
				{
				}
			}
			return 0;
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x0009B16C File Offset: 0x0009936C
		internal Class159.Enum17 method_2(IntPtr intptr_1, string string_0, bool bool_0)
		{
			if (bool_0 && !this.method_1())
			{
				return Class159.Enum17.const_8;
			}
			if (intptr_1 == Class159.intptr_0)
			{
				return Class159.Enum17.const_1;
			}
			IntPtr procAddress = Class159.GetProcAddress(Class159.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
			if (procAddress == Class159.intptr_0)
			{
				return Class159.Enum17.const_5;
			}
			IntPtr intPtr = Class159.VirtualAllocEx(intptr_1, (IntPtr)null, (IntPtr)string_0.Length, 12288U, 64U);
			if (intPtr == Class159.intptr_0)
			{
				return Class159.Enum17.const_6;
			}
			byte[] bytes = Encoding.UTF8.GetBytes(string_0);
			if (Class159.WriteProcessMemory(intptr_1, intPtr, bytes, (uint)bytes.Length, 0) == 0)
			{
				return Class159.Enum17.const_7;
			}
			if (Class159.CreateRemoteThread(intptr_1, (IntPtr)null, Class159.intptr_0, procAddress, intPtr, 0U, (IntPtr)null) == Class159.intptr_0)
			{
				int nativeErrorCode = new Win32Exception(Marshal.GetLastWin32Error()).NativeErrorCode;
				string message = new Win32Exception(Marshal.GetLastWin32Error()).Message;
				if (nativeErrorCode == 5)
				{
					return Class159.Enum17.const_4;
				}
			}
			Class159.CloseHandle(intptr_1);
			int nativeErrorCode2 = new Win32Exception(Marshal.GetLastWin32Error()).NativeErrorCode;
			string message2 = new Win32Exception(Marshal.GetLastWin32Error()).Message;
			if (nativeErrorCode2 > 0 && nativeErrorCode2 != 183)
			{
				Class83.smethod_100("Error while injecting {0}", new object[]
				{
					message2
				});
				Class83.smethod_96("Error injecting DLL, message {0}", new object[]
				{
					message2
				});
				return Class159.Enum17.const_2;
			}
			return Class159.Enum17.const_3;
		}

		// Token: 0x04000A7F RID: 2687
		internal static readonly IntPtr intptr_0 = (IntPtr)0;

		// Token: 0x04000A80 RID: 2688
		internal static uint uint_0 = 256U;

		// Token: 0x04000A81 RID: 2689
		internal static uint uint_1 = 257U;

		// Token: 0x04000A82 RID: 2690
		internal static uint uint_2 = 258U;

		// Token: 0x04000A83 RID: 2691
		internal static uint uint_3 = 1U;

		// Token: 0x04000A84 RID: 2692
		internal static uint uint_4 = 514U;

		// Token: 0x04000A85 RID: 2693
		internal static uint uint_5 = 513U;

		// Token: 0x04000A86 RID: 2694
		internal static uint uint_6;

		// Token: 0x04000A87 RID: 2695
		internal static uint uint_7;

		// Token: 0x04000A88 RID: 2696
		internal static uint uint_8;

		// Token: 0x04000A89 RID: 2697
		internal static uint uint_9;

		// Token: 0x04000A8A RID: 2698
		internal static uint uint_10;

		// Token: 0x04000A8B RID: 2699
		internal static uint uint_11;

		// Token: 0x04000A8C RID: 2700
		internal static uint uint_12;

		// Token: 0x04000A8D RID: 2701
		internal static uint uint_13;

		// Token: 0x04000A8E RID: 2702
		internal static List<Class159.Class160> list_0 = new List<Class159.Class160>();

		// Token: 0x020000C8 RID: 200
		internal enum Enum17
		{
			// Token: 0x04000A90 RID: 2704
			const_0,
			// Token: 0x04000A91 RID: 2705
			const_1,
			// Token: 0x04000A92 RID: 2706
			const_2,
			// Token: 0x04000A93 RID: 2707
			const_3,
			// Token: 0x04000A94 RID: 2708
			const_4,
			// Token: 0x04000A95 RID: 2709
			const_5,
			// Token: 0x04000A96 RID: 2710
			const_6,
			// Token: 0x04000A97 RID: 2711
			const_7,
			// Token: 0x04000A98 RID: 2712
			const_8,
			// Token: 0x04000A99 RID: 2713
			const_9
		}

		// Token: 0x020000C9 RID: 201
		internal enum Enum18
		{
			// Token: 0x04000A9B RID: 2715
			const_0,
			// Token: 0x04000A9C RID: 2716
			const_1,
			// Token: 0x04000A9D RID: 2717
			const_2,
			// Token: 0x04000A9E RID: 2718
			const_3,
			// Token: 0x04000A9F RID: 2719
			const_4,
			// Token: 0x04000AA0 RID: 2720
			const_5,
			// Token: 0x04000AA1 RID: 2721
			const_6,
			// Token: 0x04000AA2 RID: 2722
			const_7,
			// Token: 0x04000AA3 RID: 2723
			const_8,
			// Token: 0x04000AA4 RID: 2724
			const_9,
			// Token: 0x04000AA5 RID: 2725
			const_10,
			// Token: 0x04000AA6 RID: 2726
			const_11,
			// Token: 0x04000AA7 RID: 2727
			const_12,
			// Token: 0x04000AA8 RID: 2728
			const_13,
			// Token: 0x04000AA9 RID: 2729
			const_14
		}

		// Token: 0x020000CA RID: 202
		// (Invoke) Token: 0x0600082C RID: 2092
		internal delegate bool Delegate4(uint wHandle);

		// Token: 0x020000CB RID: 203
		// (Invoke) Token: 0x06000830 RID: 2096
		internal delegate bool Delegate5();

		// Token: 0x020000CC RID: 204
		[Flags]
		internal enum Enum19 : uint
		{
			// Token: 0x04000AAB RID: 2731
			flag_0 = 2U,
			// Token: 0x04000AAC RID: 2732
			flag_1 = 4U,
			// Token: 0x04000AAD RID: 2733
			flag_2 = 8U,
			// Token: 0x04000AAE RID: 2734
			flag_3 = 32U,
			// Token: 0x04000AAF RID: 2735
			flag_4 = 64U,
			// Token: 0x04000AB0 RID: 2736
			flag_5 = 134217728U,
			// Token: 0x04000AB1 RID: 2737
			flag_6 = 16777216U,
			// Token: 0x04000AB2 RID: 2738
			flag_7 = 268435456U,
			// Token: 0x04000AB3 RID: 2739
			flag_8 = 67108864U
		}

		// Token: 0x020000CD RID: 205
		internal struct Struct3
		{
			// Token: 0x04000AB4 RID: 2740
			internal uint uint_0;

			// Token: 0x04000AB5 RID: 2741
			internal uint uint_1;

			// Token: 0x04000AB6 RID: 2742
			internal uint uint_2;

			// Token: 0x04000AB7 RID: 2743
			internal uint uint_3;

			// Token: 0x04000AB8 RID: 2744
			internal uint uint_4;

			// Token: 0x04000AB9 RID: 2745
			internal uint uint_5;

			// Token: 0x04000ABA RID: 2746
			internal uint uint_6;
		}

		// Token: 0x020000CE RID: 206
		internal struct Struct4
		{
			// Token: 0x04000ABB RID: 2747
			internal IntPtr intptr_0;

			// Token: 0x04000ABC RID: 2748
			internal IntPtr intptr_1;

			// Token: 0x04000ABD RID: 2749
			internal uint uint_0;

			// Token: 0x04000ABE RID: 2750
			internal uint uint_1;

			// Token: 0x04000ABF RID: 2751
			internal uint uint_2;

			// Token: 0x04000AC0 RID: 2752
			internal uint uint_3;

			// Token: 0x04000AC1 RID: 2753
			internal uint uint_4;
		}

		// Token: 0x020000CF RID: 207
		internal enum Enum20
		{
			// Token: 0x04000AC3 RID: 2755
			const_0 = 1,
			// Token: 0x04000AC4 RID: 2756
			const_1,
			// Token: 0x04000AC5 RID: 2757
			const_2 = 4,
			// Token: 0x04000AC6 RID: 2758
			const_3 = 8,
			// Token: 0x04000AC7 RID: 2759
			const_4 = 16,
			// Token: 0x04000AC8 RID: 2760
			const_5 = 32,
			// Token: 0x04000AC9 RID: 2761
			const_6 = 64,
			// Token: 0x04000ACA RID: 2762
			const_7 = 128,
			// Token: 0x04000ACB RID: 2763
			const_8 = 256,
			// Token: 0x04000ACC RID: 2764
			const_9 = 512,
			// Token: 0x04000ACD RID: 2765
			const_10 = 1024
		}

		// Token: 0x020000D0 RID: 208
		[Flags]
		internal enum Enum21 : uint
		{
			// Token: 0x04000ACF RID: 2767
			flag_0 = 2U,
			// Token: 0x04000AD0 RID: 2768
			flag_1 = 1U,
			// Token: 0x04000AD1 RID: 2769
			flag_2 = 536870912U,
			// Token: 0x04000AD2 RID: 2770
			flag_3 = 16U,
			// Token: 0x04000AD3 RID: 2771
			flag_4 = 262144U,
			// Token: 0x04000AD4 RID: 2772
			flag_5 = 8U,
			// Token: 0x04000AD5 RID: 2773
			flag_6 = 524288U,
			// Token: 0x04000AD6 RID: 2774
			flag_7 = 1048576U,
			// Token: 0x04000AD7 RID: 2775
			flag_8 = 131072U,
			// Token: 0x04000AD8 RID: 2776
			flag_9 = 8388608U,
			// Token: 0x04000AD9 RID: 2777
			flag_10 = 4194304U,
			// Token: 0x04000ADA RID: 2778
			flag_11 = 65536U,
			// Token: 0x04000ADB RID: 2779
			flag_12 = 16777216U,
			// Token: 0x04000ADC RID: 2780
			flag_13 = 128U,
			// Token: 0x04000ADD RID: 2781
			flag_14 = 64U,
			// Token: 0x04000ADE RID: 2782
			flag_15 = 2097152U,
			// Token: 0x04000ADF RID: 2783
			flag_16 = 33554432U,
			// Token: 0x04000AE0 RID: 2784
			flag_17 = 4U,
			// Token: 0x04000AE1 RID: 2785
			flag_18 = 32768U,
			// Token: 0x04000AE2 RID: 2786
			flag_19 = 32U
		}

		// Token: 0x020000D1 RID: 209
		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		public struct Struct5
		{
			// Token: 0x04000AE3 RID: 2787
			public int int_0;

			// Token: 0x04000AE4 RID: 2788
			public int int_1;

			// Token: 0x04000AE5 RID: 2789
			public int int_2;

			// Token: 0x04000AE6 RID: 2790
			public int int_3;
		}

		// Token: 0x020000D2 RID: 210
		// (Invoke) Token: 0x06000834 RID: 2100
		internal delegate int Delegate6(IntPtr hwnd, int lParam);

		// Token: 0x020000D3 RID: 211
		internal sealed class Class160
		{
			// Token: 0x04000AE7 RID: 2791
			internal uint uint_0;

			// Token: 0x04000AE8 RID: 2792
			internal uint uint_1;

			// Token: 0x04000AE9 RID: 2793
			internal uint uint_2;

			// Token: 0x04000AEA RID: 2794
			internal uint uint_3;

			// Token: 0x04000AEB RID: 2795
			internal uint uint_4;

			// Token: 0x04000AEC RID: 2796
			internal uint uint_5;

			// Token: 0x04000AED RID: 2797
			internal uint uint_6;

			// Token: 0x04000AEE RID: 2798
			internal byte[] byte_0;
		}
	}
}
