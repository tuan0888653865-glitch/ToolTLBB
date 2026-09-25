using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace ns0
{
	// Token: 0x020000C6 RID: 198
	internal sealed class Class59 : Class57
	{
		// Token: 0x060007DF RID: 2015 RVA: 0x00099E70 File Offset: 0x00098070
		internal Class59(Class58 class58_1)
		{
			this.class58_0 = class58_1;
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x00009786 File Offset: 0x00007986
		// (set) Token: 0x060007E1 RID: 2017 RVA: 0x0009A320 File Offset: 0x00098520
		internal unsafe int SelfAutoRef
		{
			get
			{
				return this.int_10;
			}
			set
			{
				this.int_10 = value;
				Class83.random_0.NextBytes(this.byte_3);
				this.pByte_2[931] = this.byte_3[0];
				this.pByte_2[932] = this.byte_3[1];
				this.pByte_2[933] = this.byte_3[2];
				this.pByte_2[934] = this.byte_3[3];
			}
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x0009A398 File Offset: 0x00098598
		internal void method_1(IntPtr intptr_44)
		{
			IntPtr value = 0;
			int num = 0;
			bool flag = false;
			for (;;)
			{
				Class159.Struct4 @struct = default(Class159.Struct4);
				if (Class159.VirtualQueryEx(intptr_44, value, out @struct, Marshal.SizeOf(@struct)) == 0)
				{
					break;
				}
				if ((@struct.uint_2 & 4096U) != 0U && (@struct.uint_3 & 256U) == 0U)
				{
					Class138 @class = new Class138();
					@class.intptr_1 = @struct.intptr_1;
					@class.uint_0 = @struct.uint_0;
					@class.intptr_0 = @struct.intptr_0;
					@class.uint_3 = @struct.uint_3;
					@class.uint_1 = @struct.uint_1;
					@class.uint_2 = @struct.uint_2;
					@class.uint_4 = @struct.uint_4;
					this.list_1.Add(@class);
				}
				num++;
				try
				{
					value = new IntPtr((long)@struct.intptr_0.ToInt32() + (long)((ulong)@struct.uint_1));
					goto IL_E6;
				}
				catch (Exception)
				{
					flag = true;
					goto IL_E6;
				}
				IL_DE:
				if (flag)
				{
					break;
				}
				continue;
				IL_E6:
				if ((int)value >= 2147418112)
				{
					break;
				}
				goto IL_DE;
			}
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0009A4A8 File Offset: 0x000986A8
		internal static IntPtr smethod_0(byte[] byte_5, byte[] byte_6, int int_15 = 1)
		{
			try
			{
				int[] array = new int[256];
				int i = 0;
				int num = byte_6.Length - 1;
				for (int j = 0; j < 256; j++)
				{
					array[j] = byte_6.Length;
				}
				for (int k = 0; k < num; k++)
				{
					array[(int)byte_6[k]] = num - k;
				}
				int num2 = 0;
				IL_7D:
				while (i <= byte_5.Length - byte_6.Length)
				{
					int num3 = num;
					while (byte_5[i + num3] == byte_6[num3])
					{
						if (num3 != 0)
						{
							num3--;
						}
						else
						{
							num2++;
							if (num2 == int_15)
							{
								return new IntPtr(i);
							}
							IL_73:
							i += array[(int)byte_5[i + num]];
							goto IL_7D;
						}
					}
					goto IL_73;
				}
			}
			catch (Exception)
			{
			}
			return IntPtr.Zero;
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x0009A564 File Offset: 0x00098764
		internal static int smethod_1(Class58 class58_1, byte[] byte_5, int int_15 = 1, bool bool_26 = false, int int_16 = 0, int int_17 = 0)
		{
			if (class58_1.class59_0.intptr_3 == IntPtr.Zero)
			{
				return 0;
			}
			if (class58_1.class59_0.list_1.Count == 0)
			{
				class58_1.class59_0.method_1(class58_1.class59_0.intptr_3);
			}
			int num = 0;
			IntPtr value = IntPtr.Zero;
			for (int i = 0; i < class58_1.class59_0.list_1.Count; i++)
			{
				try
				{
					byte[] byte_6 = new byte[class58_1.class59_0.list_1[i].uint_1];
					Class159.ReadProcessMemory((int)class58_1.class59_0.intptr_3, class58_1.class59_0.list_1[i].intptr_0, byte_6, class58_1.class59_0.list_1[i].uint_1, ref num);
					value = Class59.smethod_0(byte_6, byte_5, int_15);
					if (value != IntPtr.Zero)
					{
						int num2 = class58_1.class59_0.list_1[i].intptr_0.ToInt32() + value.ToInt32();
						int num3 = num2;
						if (bool_26)
						{
							num2 += int_16;
							byte[] value2 = new byte[4];
							Class159.ReadProcessMemory((int)class58_1.class59_0.intptr_3, (IntPtr)num2, value2, 4U, ref num);
							num3 = BitConverter.ToInt32(value2, 0);
						}
						if (num3 != 0)
						{
							num3 += int_17;
						}
						return num3;
					}
				}
				catch (Exception)
				{
				}
			}
			return 0;
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x0009A6E4 File Offset: 0x000988E4
		internal static string smethod_2(string string_24, ref IntPtr intptr_44, ref IntPtr intptr_45, UIntPtr uintptr_15)
		{
			intptr_45 = Class159.OpenFileMapping(983071U, false, string_24);
			uint lastError = Class159.GetLastError();
			if (lastError != 0U)
			{
				if (lastError == 2U)
				{
					throw new FileNotFoundException(string_24);
				}
				Class83.smethod_96("Unprocessed error ID: ", new object[]
				{
					lastError.ToString()
				});
			}
			if (intptr_45 == Class159.intptr_0)
			{
				Class83.smethod_100("Cannot read the mapped object - null returned", new object[0]);
				return "";
			}
			intptr_44 = Class159.MapViewOfFile(intptr_45, 983071U, 0U, 0U, uintptr_15);
			if (intptr_44 == IntPtr.Zero)
			{
				Class83.smethod_100("Cannot create the file view", new object[0]);
				return "";
			}
			if (intptr_44 != IntPtr.Zero)
			{
				return Marshal.PtrToStringAuto(intptr_44);
			}
			return "";
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x0009A7A4 File Offset: 0x000989A4
		internal bool method_2()
		{
			if (!this.bool_17)
			{
				this.string_10 = Class83.smethod_98(24);
				Class83.smethod_101(ref this.intptr_17, ref this.intptr_16, this.string_10, this.uintptr_2);
				this.string_17 = Class83.smethod_98(24);
				Class83.smethod_101(ref this.intptr_31, ref this.intptr_30, this.string_17, this.uintptr_9);
				this.string_18 = Class83.smethod_98(24);
				Class83.smethod_101(ref this.intptr_33, ref this.intptr_32, this.string_18, this.uintptr_10);
				this.string_19 = Class83.smethod_98(24);
				Class83.smethod_101(ref this.intptr_35, ref this.intptr_34, this.string_19, this.uintptr_11);
				this.string_20 = Class83.smethod_98(24);
				Class83.smethod_101(ref this.intptr_37, ref this.intptr_36, this.string_20, this.uintptr_12);
				this.string_21 = Class83.smethod_98(24);
				Class83.smethod_101(ref this.intptr_39, ref this.intptr_38, this.string_21, this.uintptr_13);
				this.string_22 = Class83.smethod_98(24);
				Class83.smethod_101(ref this.intptr_41, ref this.intptr_40, this.string_22, this.uintptr_14);
				this.bool_17 = true;
			}
			return true;
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x0009A8EC File Offset: 0x00098AEC
		internal void method_3(uint uint_2, Class156 class156_0, ref IntPtr intptr_44, int int_15 = 0, bool bool_26 = true)
		{
			if (uint_2 > 0U && this.intptr_10 != IntPtr.Zero)
			{
				int num = 10000;
				if (bool_26 || intptr_44 == IntPtr.Zero)
				{
					intptr_44 = Class159.VirtualAllocEx(this.intptr_3, IntPtr.Zero, (IntPtr)num, 12288U, 4U);
				}
				if (intptr_44 != IntPtr.Zero)
				{
					byte[] array = new byte[num];
					if (class156_0.string_0 != "" || class156_0.string_1 != "" || class156_0.string_2 != "" || class156_0.string_3 != "")
					{
						Array.Clear(array, 0, num);
						if (class156_0.string_0 != "" && class156_0.string_0.Length < 5000)
						{
							byte[] array2 = Class83.smethod_138(class156_0.string_0, this.int_2);
							Array.Copy(array2, 0, array, 0, array2.Length);
						}
						if (class156_0.string_1 != "" && class156_0.string_1.Length < 1000)
						{
							byte[] array3 = Class83.smethod_138(class156_0.string_1, this.int_2);
							Array.Copy(array3, 0, array, 5000, array3.Length);
						}
						if (class156_0.string_2 != "" && class156_0.string_2.Length < 1000)
						{
							byte[] array4 = Class83.smethod_138(class156_0.string_2, this.int_2);
							Array.Copy(array4, 0, array, 6000, array4.Length);
						}
						if (class156_0.string_3 != "" && class156_0.string_3.Length < 1000)
						{
							byte[] array5 = Class83.smethod_138(class156_0.string_3, this.int_2);
							Array.Copy(array5, 0, array, 7000, array5.Length);
						}
					}
					int num2 = 0;
					Class159.WriteProcessMemory(this.intptr_3, intptr_44, array, (uint)num, num2);
					Class159.PostMessage(this.intptr_10, uint_2, (IntPtr)int_15, intptr_44);
				}
			}
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x0009AB08 File Offset: 0x00098D08
		internal void method_4(uint uint_2, Class157 class157_0)
		{
			if (uint_2 > 0U && this.intptr_10 != IntPtr.Zero)
			{
				int num = 1042;
				IntPtr value = Class159.VirtualAllocEx(this.intptr_3, IntPtr.Zero, (IntPtr)num, 12288U, 4U);
				if (value != IntPtr.Zero)
				{
					byte[] array = new byte[num];
					IntPtr intPtr = Marshal.AllocHGlobal(num);
					Marshal.StructureToPtr(class157_0, intPtr, false);
					Marshal.Copy(intPtr, array, 0, num);
					if (class157_0.string_0 != "" || class157_0.string_1 != "")
					{
						Array.Clear(array, 42, 1000);
						if (class157_0.string_0 != "")
						{
							byte[] bytes = Encoding.ASCII.GetBytes(class157_0.string_0);
							Array.Copy(bytes, 0, array, 42, bytes.Length);
						}
						if (class157_0.string_1 != "")
						{
							byte[] bytes2 = Encoding.ASCII.GetBytes(class157_0.string_1);
							Array.Copy(bytes2, 0, array, 542, bytes2.Length);
						}
					}
					Marshal.FreeHGlobal(intPtr);
					int num2 = 0;
					Class159.WriteProcessMemory(this.intptr_3, value, array, (uint)num, num2);
					Class159.PostMessage(this.intptr_10, uint_2, (IntPtr)0, value);
				}
			}
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x0009AC54 File Offset: 0x00098E54
		internal unsafe void method_5(string string_24)
		{
			bool flag = false;
			string text = "";
			if (Class159.WaitForSingleObject(this.intptr_11, 5U) == 0U)
			{
				try
				{
					Class59.smethod_4(ref this.pByte_5, this.string_8, string_24);
					goto IL_90;
				}
				finally
				{
					Class159.ReleaseMutex(this.intptr_11);
				}
				IL_38:
				if ((IntPtr)((void*)this.pByte_5) != IntPtr.Zero)
				{
					for (int i = 0; i < 5; i++)
					{
						text = Class208.smethod_7(this.pByte_5);
					}
				}
				text = text.Replace("\0", "");
				if (text == "Ready")
				{
					flag = true;
				}
				else
				{
					Thread.Sleep(50);
				}
				IL_90:
				if (!flag)
				{
					goto IL_38;
				}
			}
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0009AD04 File Offset: 0x00098F04
		internal static bool smethod_3(ref IntPtr intptr_44, string string_24, string string_25)
		{
			if (intptr_44 != IntPtr.Zero)
			{
				if (!string_25.EndsWith(";"))
				{
					string_25 += ";";
				}
				bool result;
				try
				{
					if (string_25.Length <= 2048)
					{
						IntPtr intPtr = Marshal.StringToHGlobalAuto(string_25);
						Class159.CopyMemory(intptr_44, intPtr, (uint)(string_25.Length * 2));
					}
					result = true;
				}
				catch (Exception)
				{
					result = false;
				}
				return result;
			}
			return false;
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0009AD7C File Offset: 0x00098F7C
		internal unsafe static bool smethod_4(ref byte* pByte_14, string string_24, string string_25)
		{
			if ((IntPtr)pByte_14 != IntPtr.Zero)
			{
				if (!string_25.EndsWith(";"))
				{
					string_25 += ";";
				}
				bool result;
				try
				{
					if (string_25.Length <= 2048)
					{
						Class159.memset((IntPtr)pByte_14, 0, 2048);
						char[] array = string_25.ToCharArray();
						for (int i = 0; i < string_25.Length; i++)
						{
							*(pByte_14 + (IntPtr)i) = (byte)array[i];
						}
					}
					result = true;
				}
				catch (Exception)
				{
					result = false;
				}
				return result;
			}
			return false;
		}

		// Token: 0x040009D2 RID: 2514
		internal Class58 class58_0;

		// Token: 0x040009D3 RID: 2515
		internal int int_0 = 300;

		// Token: 0x040009D4 RID: 2516
		internal Delegate7 delegate7_0;

		// Token: 0x040009D5 RID: 2517
		internal Delegate7 delegate7_1;

		// Token: 0x040009D6 RID: 2518
		internal bool bool_0;

		// Token: 0x040009D7 RID: 2519
		internal string string_0 = "";

		// Token: 0x040009D8 RID: 2520
		internal Class136 class136_0;

		// Token: 0x040009D9 RID: 2521
		internal List<Class66> list_0 = new List<Class66>();

		// Token: 0x040009DA RID: 2522
		internal int int_1;

		// Token: 0x040009DB RID: 2523
		internal int int_2 = 1;

		// Token: 0x040009DC RID: 2524
		internal int int_3;

		// Token: 0x040009DD RID: 2525
		internal List<Class138> list_1 = new List<Class138>();

		// Token: 0x040009DE RID: 2526
		internal DateTime dateTime_0 = DateTime.MaxValue;

		// Token: 0x040009DF RID: 2527
		internal string string_1 = "";

		// Token: 0x040009E0 RID: 2528
		internal IntPtr intptr_0 = IntPtr.Zero;

		// Token: 0x040009E1 RID: 2529
		internal IntPtr intptr_1 = IntPtr.Zero;

		// Token: 0x040009E2 RID: 2530
		internal IntPtr intptr_2 = IntPtr.Zero;

		// Token: 0x040009E3 RID: 2531
		internal IntPtr intptr_3;

		// Token: 0x040009E4 RID: 2532
		internal byte[] byte_0 = new byte[30];

		// Token: 0x040009E5 RID: 2533
		internal int int_4 = 4194304;

		// Token: 0x040009E6 RID: 2534
		internal IntPtr intptr_4 = IntPtr.Zero;

		// Token: 0x040009E7 RID: 2535
		internal IntPtr intptr_5 = IntPtr.Zero;

		// Token: 0x040009E8 RID: 2536
		internal IntPtr intptr_6 = IntPtr.Zero;

		// Token: 0x040009E9 RID: 2537
		internal IntPtr intptr_7 = IntPtr.Zero;

		// Token: 0x040009EA RID: 2538
		internal IntPtr intptr_8 = IntPtr.Zero;

		// Token: 0x040009EB RID: 2539
		internal IntPtr intptr_9 = IntPtr.Zero;

		// Token: 0x040009EC RID: 2540
		internal IntPtr intptr_10 = IntPtr.Zero;

		// Token: 0x040009ED RID: 2541
		internal int int_5;

		// Token: 0x040009EE RID: 2542
		internal string string_2 = "TianLongBaBu WndClass";

		// Token: 0x040009EF RID: 2543
		internal string string_3 = "TTL";

		// Token: 0x040009F0 RID: 2544
		internal uint uint_0;

		// Token: 0x040009F1 RID: 2545
		internal bool bool_1;

		// Token: 0x040009F2 RID: 2546
		internal bool bool_2;

		// Token: 0x040009F3 RID: 2547
		internal string string_4 = "";

		// Token: 0x040009F4 RID: 2548
		internal string string_5 = "";

		// Token: 0x040009F5 RID: 2549
		internal string string_6 = "";

		// Token: 0x040009F6 RID: 2550
		internal IntPtr intptr_11 = IntPtr.Zero;

		// Token: 0x040009F7 RID: 2551
		internal string string_7 = "";

		// Token: 0x040009F8 RID: 2552
		internal bool bool_3;

		// Token: 0x040009F9 RID: 2553
		internal string string_8 = "";

		// Token: 0x040009FA RID: 2554
		internal UIntPtr uintptr_0 = (UIntPtr)2048UL;

		// Token: 0x040009FB RID: 2555
		internal IntPtr intptr_12 = IntPtr.Zero;

		// Token: 0x040009FC RID: 2556
		internal IntPtr intptr_13 = IntPtr.Zero;

		// Token: 0x040009FD RID: 2557
		internal string string_9 = "tinydllname";

		// Token: 0x040009FE RID: 2558
		internal IntPtr intptr_14 = IntPtr.Zero;

		// Token: 0x040009FF RID: 2559
		internal IntPtr intptr_15 = IntPtr.Zero;

		// Token: 0x04000A00 RID: 2560
		internal UIntPtr uintptr_1 = (UIntPtr)512UL;

		// Token: 0x04000A01 RID: 2561
		internal string string_10 = "";

		// Token: 0x04000A02 RID: 2562
		internal IntPtr intptr_16 = IntPtr.Zero;

		// Token: 0x04000A03 RID: 2563
		internal IntPtr intptr_17 = IntPtr.Zero;

		// Token: 0x04000A04 RID: 2564
		internal UIntPtr uintptr_2 = (UIntPtr)2048UL;

		// Token: 0x04000A05 RID: 2565
		internal string string_11 = "";

		// Token: 0x04000A06 RID: 2566
		internal IntPtr intptr_18 = IntPtr.Zero;

		// Token: 0x04000A07 RID: 2567
		internal IntPtr intptr_19 = IntPtr.Zero;

		// Token: 0x04000A08 RID: 2568
		internal UIntPtr uintptr_3 = (UIntPtr)2048UL;

		// Token: 0x04000A09 RID: 2569
		internal UIntPtr uintptr_4 = (UIntPtr)50000UL;

		// Token: 0x04000A0A RID: 2570
		internal string string_12 = "";

		// Token: 0x04000A0B RID: 2571
		internal IntPtr intptr_20 = IntPtr.Zero;

		// Token: 0x04000A0C RID: 2572
		internal IntPtr intptr_21 = IntPtr.Zero;

		// Token: 0x04000A0D RID: 2573
		internal UIntPtr uintptr_5 = (UIntPtr)5048UL;

		// Token: 0x04000A0E RID: 2574
		internal string string_13 = "";

		// Token: 0x04000A0F RID: 2575
		internal IntPtr intptr_22 = IntPtr.Zero;

		// Token: 0x04000A10 RID: 2576
		internal IntPtr intptr_23 = IntPtr.Zero;

		// Token: 0x04000A11 RID: 2577
		internal UIntPtr uintptr_6 = (UIntPtr)4096UL;

		// Token: 0x04000A12 RID: 2578
		internal string string_14 = "";

		// Token: 0x04000A13 RID: 2579
		internal IntPtr intptr_24 = IntPtr.Zero;

		// Token: 0x04000A14 RID: 2580
		internal IntPtr intptr_25 = IntPtr.Zero;

		// Token: 0x04000A15 RID: 2581
		internal UIntPtr uintptr_7 = (UIntPtr)4096UL;

		// Token: 0x04000A16 RID: 2582
		internal string string_15 = "";

		// Token: 0x04000A17 RID: 2583
		internal IntPtr intptr_26 = IntPtr.Zero;

		// Token: 0x04000A18 RID: 2584
		internal IntPtr intptr_27 = IntPtr.Zero;

		// Token: 0x04000A19 RID: 2585
		internal UIntPtr uintptr_8 = (UIntPtr)1024UL;

		// Token: 0x04000A1A RID: 2586
		internal string string_16 = "";

		// Token: 0x04000A1B RID: 2587
		internal IntPtr intptr_28 = IntPtr.Zero;

		// Token: 0x04000A1C RID: 2588
		internal IntPtr intptr_29 = IntPtr.Zero;

		// Token: 0x04000A1D RID: 2589
		internal string string_17 = "";

		// Token: 0x04000A1E RID: 2590
		internal UIntPtr uintptr_9 = (UIntPtr)500000UL;

		// Token: 0x04000A1F RID: 2591
		internal IntPtr intptr_30 = IntPtr.Zero;

		// Token: 0x04000A20 RID: 2592
		internal IntPtr intptr_31 = IntPtr.Zero;

		// Token: 0x04000A21 RID: 2593
		internal string string_18 = "";

		// Token: 0x04000A22 RID: 2594
		internal UIntPtr uintptr_10 = (UIntPtr)1024000UL;

		// Token: 0x04000A23 RID: 2595
		internal IntPtr intptr_32 = IntPtr.Zero;

		// Token: 0x04000A24 RID: 2596
		internal IntPtr intptr_33 = IntPtr.Zero;

		// Token: 0x04000A25 RID: 2597
		internal string string_19 = "";

		// Token: 0x04000A26 RID: 2598
		internal UIntPtr uintptr_11 = (UIntPtr)1024000UL;

		// Token: 0x04000A27 RID: 2599
		internal IntPtr intptr_34 = IntPtr.Zero;

		// Token: 0x04000A28 RID: 2600
		internal IntPtr intptr_35 = IntPtr.Zero;

		// Token: 0x04000A29 RID: 2601
		internal string string_20 = "";

		// Token: 0x04000A2A RID: 2602
		internal UIntPtr uintptr_12 = (UIntPtr)64000UL;

		// Token: 0x04000A2B RID: 2603
		internal IntPtr intptr_36 = IntPtr.Zero;

		// Token: 0x04000A2C RID: 2604
		internal IntPtr intptr_37 = IntPtr.Zero;

		// Token: 0x04000A2D RID: 2605
		internal string string_21 = "";

		// Token: 0x04000A2E RID: 2606
		internal UIntPtr uintptr_13 = (UIntPtr)64000UL;

		// Token: 0x04000A2F RID: 2607
		internal IntPtr intptr_38 = IntPtr.Zero;

		// Token: 0x04000A30 RID: 2608
		internal IntPtr intptr_39 = IntPtr.Zero;

		// Token: 0x04000A31 RID: 2609
		internal string string_22 = "";

		// Token: 0x04000A32 RID: 2610
		internal UIntPtr uintptr_14 = (UIntPtr)32000UL;

		// Token: 0x04000A33 RID: 2611
		internal IntPtr intptr_40 = IntPtr.Zero;

		// Token: 0x04000A34 RID: 2612
		internal IntPtr intptr_41 = IntPtr.Zero;

		// Token: 0x04000A35 RID: 2613
		internal unsafe byte* pByte_0;

		// Token: 0x04000A36 RID: 2614
		internal unsafe byte* pByte_1;

		// Token: 0x04000A37 RID: 2615
		internal unsafe byte* pByte_2;

		// Token: 0x04000A38 RID: 2616
		internal unsafe byte* pByte_3;

		// Token: 0x04000A39 RID: 2617
		internal unsafe byte* pByte_4;

		// Token: 0x04000A3A RID: 2618
		internal unsafe byte* pByte_5;

		// Token: 0x04000A3B RID: 2619
		internal unsafe byte* pByte_6;

		// Token: 0x04000A3C RID: 2620
		internal unsafe byte* pByte_7;

		// Token: 0x04000A3D RID: 2621
		internal unsafe byte* pByte_8;

		// Token: 0x04000A3E RID: 2622
		internal unsafe byte* pByte_9;

		// Token: 0x04000A3F RID: 2623
		internal unsafe byte* pByte_10;

		// Token: 0x04000A40 RID: 2624
		internal unsafe byte* pByte_11;

		// Token: 0x04000A41 RID: 2625
		internal unsafe byte* pByte_12;

		// Token: 0x04000A42 RID: 2626
		internal unsafe byte* pByte_13;

		// Token: 0x04000A43 RID: 2627
		internal byte[] byte_1 = new byte[4000];

		// Token: 0x04000A44 RID: 2628
		internal char[] char_0 = new char[90];

		// Token: 0x04000A45 RID: 2629
		internal Class57.Enum3 enum3_0;

		// Token: 0x04000A46 RID: 2630
		internal Class159.Delegate4 delegate4_0;

		// Token: 0x04000A47 RID: 2631
		internal Class159.Delegate5 delegate5_0;

		// Token: 0x04000A48 RID: 2632
		internal bool bool_4;

		// Token: 0x04000A49 RID: 2633
		internal bool bool_5;

		// Token: 0x04000A4A RID: 2634
		internal int int_6;

		// Token: 0x04000A4B RID: 2635
		internal bool bool_6;

		// Token: 0x04000A4C RID: 2636
		internal int int_7 = 30;

		// Token: 0x04000A4D RID: 2637
		internal long long_0;

		// Token: 0x04000A4E RID: 2638
		internal long long_1;

		// Token: 0x04000A4F RID: 2639
		internal Class158[] class158_0 = new Class158[30];

		// Token: 0x04000A50 RID: 2640
		internal Class158[] class158_1 = new Class158[20];

		// Token: 0x04000A51 RID: 2641
		internal byte[] byte_2 = new byte[800];

		// Token: 0x04000A52 RID: 2642
		internal int int_8;

		// Token: 0x04000A53 RID: 2643
		internal bool bool_7;

		// Token: 0x04000A54 RID: 2644
		internal uint uint_1;

		// Token: 0x04000A55 RID: 2645
		internal bool bool_8;

		// Token: 0x04000A56 RID: 2646
		internal bool bool_9;

		// Token: 0x04000A57 RID: 2647
		internal int int_9;

		// Token: 0x04000A58 RID: 2648
		internal long long_2;

		// Token: 0x04000A59 RID: 2649
		internal long long_3;

		// Token: 0x04000A5A RID: 2650
		internal long long_4;

		// Token: 0x04000A5B RID: 2651
		internal bool bool_10;

		// Token: 0x04000A5C RID: 2652
		internal long long_5;

		// Token: 0x04000A5D RID: 2653
		internal long long_6;

		// Token: 0x04000A5E RID: 2654
		internal long long_7;

		// Token: 0x04000A5F RID: 2655
		internal bool bool_11;

		// Token: 0x04000A60 RID: 2656
		private byte[] byte_3 = new byte[4];

		// Token: 0x04000A61 RID: 2657
		internal int int_10;

		// Token: 0x04000A62 RID: 2658
		internal bool bool_12;

		// Token: 0x04000A63 RID: 2659
		internal int int_11;

		// Token: 0x04000A64 RID: 2660
		internal bool bool_13;

		// Token: 0x04000A65 RID: 2661
		internal bool bool_14;

		// Token: 0x04000A66 RID: 2662
		internal bool bool_15;

		// Token: 0x04000A67 RID: 2663
		internal int int_12;

		// Token: 0x04000A68 RID: 2664
		internal IntPtr intptr_42 = IntPtr.Zero;

		// Token: 0x04000A69 RID: 2665
		internal IntPtr intptr_43 = IntPtr.Zero;

		// Token: 0x04000A6A RID: 2666
		internal bool bool_16 = true;

		// Token: 0x04000A6B RID: 2667
		internal long long_8;

		// Token: 0x04000A6C RID: 2668
		private bool bool_17;

		// Token: 0x04000A6D RID: 2669
		internal bool bool_18;

		// Token: 0x04000A6E RID: 2670
		internal Class99 class99_0;

		// Token: 0x04000A6F RID: 2671
		internal long long_9;

		// Token: 0x04000A70 RID: 2672
		internal long long_10;

		// Token: 0x04000A71 RID: 2673
		internal long long_11;

		// Token: 0x04000A72 RID: 2674
		internal bool bool_19;

		// Token: 0x04000A73 RID: 2675
		internal bool bool_20;

		// Token: 0x04000A74 RID: 2676
		internal long long_12;

		// Token: 0x04000A75 RID: 2677
		internal long long_13;

		// Token: 0x04000A76 RID: 2678
		internal int int_13;

		// Token: 0x04000A77 RID: 2679
		internal bool bool_21;

		// Token: 0x04000A78 RID: 2680
		internal bool bool_22;

		// Token: 0x04000A79 RID: 2681
		internal int int_14 = -1;

		// Token: 0x04000A7A RID: 2682
		internal bool bool_23;

		// Token: 0x04000A7B RID: 2683
		internal bool bool_24;

		// Token: 0x04000A7C RID: 2684
		internal string string_23 = "";

		// Token: 0x04000A7D RID: 2685
		internal bool bool_25;

		// Token: 0x04000A7E RID: 2686
		internal byte byte_4;
	}
}
