using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000098 RID: 152
	internal sealed class Class114 : INotifyPropertyChanged
	{
		// Token: 0x0600074E RID: 1870 RVA: 0x00098068 File Offset: 0x00096268
		internal Class114(Class58 class58_1)
		{
			this.class58_0 = class58_1;
			for (int i = 0; i < 30; i++)
			{
				this.list_5.Add(-1);
			}
			this.stopwatch_2.Start();
			this.stopwatch_23.Start();
			this.stopwatch_19.Start();
			this.stopwatch_27.Start();
			this.class48_0 = new Class48(this);
			this.stopwatch_16.Start();
			this.stopwatch_20.Start();
			this.stopwatch_1.Start();
			this.stopwatch_18.Start();
			this.stopwatch_22.Start();
			this.stopwatch_11.Start();
			this.stopwatch_8.Start();
			this.stopwatch_4.Start();
			this.stopwatch_6.Start();
			this.stopwatch_7.Start();
			this.stopwatch_14.Start();
			this.stopwatch_3.Start();
			this.stopwatch_24.Start();
			this.stopwatch_26.Start();
			this.stopwatch_0.Start();
			this.stopwatch_12.Start();
			this.stopwatch_13.Start();
			this.stopwatch_5.Start();
			this.stopwatch_15.Start();
			this.stopwatch_21.Start();
			this.stopwatch_9.Start();
			this.stopwatch_10.Start();
			this.stopwatch_28.Start();
			this.stopwatch_17.Start();
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600074F RID: 1871 RVA: 0x000986A4 File Offset: 0x000968A4
		// (remove) Token: 0x06000750 RID: 1872 RVA: 0x000986DC File Offset: 0x000968DC
		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			add
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00098714 File Offset: 0x00096914
		protected void method_0(string string_15)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(string_15));
			}
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00098738 File Offset: 0x00096938
		private unsafe static T[] smethod_0<T>(void* pVoid_0, int int_132, int int_133) where T : struct
		{
			T[] array = new T[int_132];
			for (int i = 0; i < int_132; i++)
			{
				IntPtr ptr = new IntPtr((void*)((byte*)pVoid_0 + i * int_133));
				array[i] = (T)((object)Marshal.PtrToStructure(ptr, typeof(T)));
			}
			return array;
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00098784 File Offset: 0x00096984
		internal unsafe static void smethod_1()
		{
			Process currentProcess = Process.GetCurrentProcess();
			IntPtr intPtr = Class159.OpenProcess(33554432U, 0, (uint)currentProcess.Id);
			byte[] array = new byte[]
			{
				77,
				105,
				4,
				61,
				166,
				5,
				231,
				43,
				184,
				244,
				140,
				241,
				196,
				204,
				181,
				106
			};
			if (!frmLogin.bool_24)
			{
				int num = 0;
				bool flag = false;
				for (int i = 0; i <= 20; i++)
				{
					num = Class159.smethod_3(intPtr, array, i, false, 0, 0);
					if (num > 0)
					{
						byte[] array2 = new byte[4];
						int num2 = 0;
						Class159.ReadProcessMemory((int)intPtr, (IntPtr)(num + array.Length), array2, 4U, ref num2);
						if (array2[0] == 243 && array2[1] == 64 && array2[2] == 10 && array2[3] == 141)
						{
							flag = true;
							IL_AF:
							if (num > 0 && flag)
							{
								num += frmLogin.random_0.Next(768, 1280);
								frmLogin.bool_24 = true;
								goto IL_D4;
							}
							goto IL_D4;
						}
					}
				}
				goto IL_AF;
			}
			IL_D4:
			if (!frmLogin.bool_25)
			{
				byte[] array3 = new byte[]
				{
					35,
					83,
					116,
					114,
					105,
					110
				};
				int num3 = 0;
				for (int j = 0; j <= 5; j++)
				{
					num3 = Class159.smethod_3(intPtr, array3, j, false, 0, 0);
					if (num3 > 0)
					{
						byte[] array4 = new byte[4];
						int num4 = 0;
						Class159.ReadProcessMemory((int)intPtr, (IntPtr)(num3 + array3.Length), array4, 4U, ref num4);
						if (array4[0] == 103 && array4[1] == 115 && array4[2] == 0 && array4[3] == 0)
						{
							break;
						}
					}
				}
				if (num3 > 0)
				{
					List<int> list = new List<int>
					{
						64,
						96,
						128,
						72,
						104,
						136
					};
					byte[] array5 = new byte[4];
					for (int k = 0; k < list.Count; k++)
					{
						frmLogin.random_0.NextBytes(array5);
						int num5 = num3 + list[k];
						try
						{
							uint num6;
							if (Class159.VirtualProtect((IntPtr)num5, 4U, 64U, out num6))
							{
								byte* ptr = num5;
								for (int l = 0; l < array5.Length; l++)
								{
									ptr[l] = array5[l];
								}
								frmLogin.bool_25 = true;
							}
						}
						catch (Exception)
						{
						}
					}
				}
			}
			Class159.CloseHandle(intPtr);
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x000989C4 File Offset: 0x00096BC4
		internal unsafe static void smethod_2()
		{
			Class58 @class = new Class58();
			Process currentProcess = Process.GetCurrentProcess();
			IntPtr intPtr = Class159.OpenProcess(33554432U, 0, (uint)currentProcess.Id);
			@class.class59_0.intptr_3 = intPtr;
			byte[] array = new byte[]
			{
				166,
				213,
				10,
				146,
				100,
				61
			};
			if (!frmLogin.bool_24)
			{
				int num = 0;
				bool flag = false;
				for (int i = 1; i <= 3; i++)
				{
					num = Class59.smethod_1(@class, array, i, false, 0, 0);
					if (num > 0)
					{
						byte[] array2 = new byte[4];
						int num2 = 0;
						Class159.ReadProcessMemory((int)@class.class59_0.intptr_3, (IntPtr)(num + 6), array2, 4U, ref num2);
						if (array2[0] == 27 && array2[1] == 34 && array2[2] == 9 && array2[3] == 246)
						{
							flag = true;
							IL_C8:
							if (num > 0 && flag)
							{
								num += frmLogin.random_0.Next(768, 1280);
								byte[] array3 = new byte[frmLogin.random_0.Next(256, 512)];
								frmLogin.random_0.NextBytes(array3);
								Class159.WriteProcessMemory(@class.class59_0.intptr_3, (IntPtr)num, array3, (uint)array3.Length, 0);
								frmLogin.bool_24 = true;
								goto IL_136;
							}
							goto IL_136;
						}
					}
				}
				goto IL_C8;
			}
			IL_136:
			if (!frmLogin.bool_25)
			{
				byte[] array4 = new byte[]
				{
					35,
					83,
					116,
					114,
					105,
					110
				};
				int num3 = 0;
				for (int j = 1; j <= 3; j++)
				{
					num3 = Class59.smethod_1(@class, array4, j, false, 0, 0);
					if (num3 > 0)
					{
						byte[] array5 = new byte[4];
						int num4 = 0;
						Class159.ReadProcessMemory((int)@class.class59_0.intptr_3, (IntPtr)(num3 + 6), array5, 4U, ref num4);
						if (array5[0] == 103 && array5[1] == 115 && array5[2] == 0 && array5[3] == 0)
						{
							break;
						}
					}
				}
				if (num3 > 0)
				{
					List<int> list = new List<int>
					{
						64,
						96,
						128,
						72,
						104,
						136
					};
					byte[] array6 = new byte[4];
					for (int k = 0; k < list.Count; k++)
					{
						frmLogin.random_0.NextBytes(array6);
						int num5 = num3 + list[k];
						try
						{
							uint num6;
							if (Class159.VirtualProtect((IntPtr)num5, 4U, 64U, out num6))
							{
								byte* ptr = num5;
								for (int l = 0; l < array6.Length; l++)
								{
									ptr[l] = array6[l];
								}
								frmLogin.bool_25 = true;
							}
						}
						catch (Exception)
						{
						}
					}
				}
			}
			Class159.CloseHandle(intPtr);
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00098C6C File Offset: 0x00096E6C
		internal unsafe static void smethod_3()
		{
			Process currentProcess = Process.GetCurrentProcess();
			IntPtr intPtr = Class159.OpenProcess(33554432U, 0, (uint)currentProcess.Id);
			if (currentProcess != null && intPtr != IntPtr.Zero)
			{
				if (currentProcess.Handle != IntPtr.Zero)
				{
					int num = (int)currentProcess.MainModule.BaseAddress;
					byte[] array = new byte[4];
					List<int> list = new List<int>
					{
						220,
						154,
						8208,
						8212
					};
					if (!frmLogin.bool_26)
					{
						for (int i = 0; i < list.Count; i++)
						{
							frmLogin.random_0.NextBytes(array);
							int num2 = num + list[i];
							try
							{
								uint num3;
								if (Class159.VirtualProtect((IntPtr)num2, 4U, 64U, out num3))
								{
									byte* ptr = num2;
									for (int j = 0; j < array.Length; j++)
									{
										ptr[j] = array[j];
									}
								}
							}
							catch (Exception)
							{
							}
							frmLogin.bool_26 = true;
						}
					}
				}
				Class159.CloseHandle(intPtr);
			}
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00008D0A File Offset: 0x00006F0A
		internal void method_1(Class59 class59_1)
		{
			this.class59_0 = class59_1;
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00008D13 File Offset: 0x00006F13
		private unsafe bool method_2()
		{
			return this.class59_0 == null || (IntPtr)((void*)this.class59_0.pByte_2) != IntPtr.Zero;
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x00008D39 File Offset: 0x00006F39
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x00008D41 File Offset: 0x00006F41
		internal Class57.Menpais Menpai
		{
			get
			{
				return this.menpais_0;
			}
			set
			{
				if (this.menpais_0 != value)
				{
					this.menpais_0 = value;
					if (this.class58_0 != null && this.class58_0.autoSettings_0 != null)
					{
						this.class58_0.autoSettings_0.savedMenpai = value;
					}
				}
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x00098D94 File Offset: 0x00096F94
		internal string StatusDisplay
		{
			get
			{
				if (this.bool_32)
				{
					return "PK";
				}
				if (this.Status == Class57.Enum13.const_0)
				{
					return frmMain.String_551;
				}
				if (this.Status == Class57.Enum13.const_13)
				{
					return frmMain.String_550;
				}
				if (this.Status == Class57.Enum13.const_12)
				{
					return frmMain.String_549;
				}
				if (this.Status == Class57.Enum13.const_14)
				{
					return frmMain.String_548;
				}
				if (this.Status == Class57.Enum13.const_7)
				{
					return frmMain.String_547;
				}
				if (this.Status == Class57.Enum13.const_10)
				{
					return frmMain.String_546;
				}
				if (this.Status == Class57.Enum13.const_11)
				{
					return frmMain.String_545;
				}
				if (this.Status == Class57.Enum13.const_5)
				{
					return frmMain.String_544;
				}
				if (this.Status == Class57.Enum13.const_15)
				{
					return frmMain.String_543;
				}
				if (this.Status == Class57.Enum13.const_8)
				{
					return frmMain.String_542;
				}
				if (this.Status == Class57.Enum13.const_16)
				{
					return frmMain.String_541;
				}
				if (this.Status == Class57.Enum13.const_9)
				{
					return frmMain.String_540;
				}
				if (this.Status == Class57.Enum13.const_21)
				{
					return frmMain.String_539;
				}
				return frmMain.String_538;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x00098EA8 File Offset: 0x000970A8
		internal int MenpaiRunDelay
		{
			get
			{
				if (this.Menpai == Class57.Menpais.TIEUDAO)
				{
					return 22000;
				}
				if (this.Menpai == Class57.Menpais.CAIBANG)
				{
					return 62000;
				}
				if (this.Menpai == Class57.Menpais.THIEULAM)
				{
					return 62000;
				}
				if (this.Menpai == Class57.Menpais.DUONGMON)
				{
					return 122000;
				}
				if (this.Menpai == Class57.Menpais.THIENLONG)
				{
					return 0;
				}
				if (this.Menpai == Class57.Menpais.THIENSON)
				{
					return 32000;
				}
				if (this.Menpai == Class57.Menpais.NGAMI)
				{
					return 1;
				}
				if (this.Menpai == Class57.Menpais.TINHTUC)
				{
					return 1;
				}
				if (this.Menpai == Class57.Menpais.VODANG)
				{
					return 122000;
				}
				if (this.Menpai == Class57.Menpais.MODUNG)
				{
					return 32000;
				}
				if (this.Menpai == Class57.Menpais.MINHGIAO)
				{
					return 62000;
				}
				if (this.Menpai == Class57.Menpais.QUYCOC)
				{
					return 32000;
				}
				if (this.Menpai == Class57.Menpais.DAOHOA)
				{
					return 1;
				}
				if (this.Menpai == Class57.Menpais.TUYETTINH)
				{
					return 32000;
				}
				return 1;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x00098F7C File Offset: 0x0009717C
		internal int MenpaiRunSkill
		{
			get
			{
				if (this.Menpai == Class57.Menpais.TIEUDAO)
				{
					return 524;
				}
				if (this.Menpai == Class57.Menpais.CAIBANG)
				{
					return 344;
				}
				if (this.Menpai == Class57.Menpais.THIEULAM)
				{
					return 284;
				}
				if (this.Menpai == Class57.Menpais.DUONGMON)
				{
					return 2904;
				}
				if (this.Menpai == Class57.Menpais.THIENLONG)
				{
					return 464;
				}
				if (this.Menpai == Class57.Menpais.THIENSON)
				{
					return 494;
				}
				if (this.Menpai == Class57.Menpais.NGAMI)
				{
					return -1;
				}
				if (this.Menpai == Class57.Menpais.TINHTUC)
				{
					return -1;
				}
				if (this.Menpai == Class57.Menpais.VODANG)
				{
					return 379;
				}
				if (this.Menpai == Class57.Menpais.MODUNG)
				{
					return 764;
				}
				if (this.Menpai == Class57.Menpais.MINHGIAO)
				{
					return 314;
				}
				if (this.Menpai == Class57.Menpais.QUYCOC)
				{
					return 1854;
				}
				if (this.Menpai == Class57.Menpais.DAOHOA)
				{
					return -1;
				}
				Class57.Menpais menpai = this.Menpai;
				return -1;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x00099050 File Offset: 0x00097250
		internal string MenpaiDisplayName
		{
			get
			{
				if (this.Menpai == Class57.Menpais.TIEUDAO)
				{
					return frmMain.String_442;
				}
				if (this.Menpai == Class57.Menpais.CAIBANG)
				{
					return frmMain.String_443;
				}
				if (this.Menpai == Class57.Menpais.THIEULAM)
				{
					return frmMain.String_441;
				}
				if (this.Menpai == Class57.Menpais.DUONGMON)
				{
					return frmMain.String_440;
				}
				if (this.Menpai == Class57.Menpais.THIENLONG)
				{
					return frmMain.String_439;
				}
				if (this.Menpai == Class57.Menpais.THIENSON)
				{
					return frmMain.String_438;
				}
				if (this.Menpai == Class57.Menpais.NGAMI)
				{
					return frmMain.String_437;
				}
				if (this.Menpai == Class57.Menpais.TINHTUC)
				{
					return frmMain.String_436;
				}
				if (this.Menpai == Class57.Menpais.VODANG)
				{
					return frmMain.String_435;
				}
				if (this.Menpai == Class57.Menpais.MODUNG)
				{
					return frmMain.String_434;
				}
				if (this.Menpai == Class57.Menpais.MINHGIAO)
				{
					return frmMain.String_433;
				}
				if (this.Menpai == Class57.Menpais.QUYCOC)
				{
					return frmMain.String_430;
				}
				if (this.Menpai == Class57.Menpais.DAOHOA)
				{
					return frmMain.String_431;
				}
				if (this.Menpai == Class57.Menpais.TUYETTINH)
				{
					return frmMain.String_432;
				}
				return frmMain.String_429;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x00008D79 File Offset: 0x00006F79
		// (set) Token: 0x0600075F RID: 1887 RVA: 0x00008D81 File Offset: 0x00006F81
		internal Class57.Enum13 Status
		{
			get
			{
				return this.enum13_0;
			}
			set
			{
				this.enum13_0 = value;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x00008D8A File Offset: 0x00006F8A
		internal Class57.Enum11 CharType
		{
			get
			{
				if (this.list_4.Contains(this.Menpai))
				{
					return Class57.Enum11.const_0;
				}
				return Class57.Enum11.const_1;
			}
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x000024E9 File Offset: 0x000006E9
		internal void method_3()
		{
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x00008DA2 File Offset: 0x00006FA2
		internal string DatabaseIDStr
		{
			get
			{
				if (this.int_11 != 0)
				{
					return this.int_11.ToString("X8");
				}
				return "";
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x00099138 File Offset: 0x00097338
		internal string MapName
		{
			get
			{
				if (this.MapID >= 0 && frmLogin.class101_0.list_3.Count > 0)
				{
					using (List<Class147>.Enumerator enumerator = frmLogin.class101_0.list_3.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Class147 @class = enumerator.Current;
							if (@class.int_0 == this.MapID)
							{
								return @class.string_0;
							}
						}
						goto IL_6A;
					}
					string result;
					return result;
				}
				IL_6A:
				return "";
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x00008DC2 File Offset: 0x00006FC2
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x00008DCA File Offset: 0x00006FCA
		internal int MapID
		{
			get
			{
				return this.int_15;
			}
			set
			{
				this.int_15 = value;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x00008DD3 File Offset: 0x00006FD3
		// (set) Token: 0x06000767 RID: 1895 RVA: 0x00008DDB File Offset: 0x00006FDB
		internal int mapIDforLUA
		{
			get
			{
				return this.int_16;
			}
			set
			{
				this.int_16 = value;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x00008DE4 File Offset: 0x00006FE4
		internal string IDHex
		{
			get
			{
				return Class83.smethod_99(this.int_9, true);
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x00008DF2 File Offset: 0x00006FF2
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x00008DFA File Offset: 0x00006FFA
		internal string HPPerDisplay
		{
			get
			{
				return this.string_4;
			}
			set
			{
				if (value != this.string_4)
				{
					this.string_4 = value;
					this.method_0("HPPerDisplay");
				}
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x000991C4 File Offset: 0x000973C4
		internal double HPPercent
		{
			get
			{
				if (this.int_18 > 0)
				{
					double result = (double)this.int_17 * 100.0 / (double)this.int_18;
					string hpperDisplay = result.ToString("0.0").Replace(".0", "");
					this.HPPerDisplay = hpperDisplay;
					return result;
				}
				this.HPPerDisplay = "0%";
				return 0.0;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x00008E1C File Offset: 0x0000701C
		internal double MPPercent
		{
			get
			{
				if (this.int_20 > 0)
				{
					return (double)this.int_19 * 100.0 / (double)this.int_20;
				}
				return 0.0;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x00008E4A File Offset: 0x0000704A
		internal double RagePercent
		{
			get
			{
				if (this.int_22 > 0)
				{
					return (double)this.int_21 * 100.0 / (double)this.int_22;
				}
				return 0.0;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x00008E78 File Offset: 0x00007078
		internal int MaxExp
		{
			get
			{
				if (this.int_39 > 0 && this.int_39 <= 119)
				{
					return this.int_0[this.int_39];
				}
				return 0;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x00099238 File Offset: 0x00097438
		internal double ExpPercent
		{
			get
			{
				if (this.int_39 > 0)
				{
					double result;
					try
					{
						result = (double)this.int_25 * 100.0 / (double)this.int_0[this.int_39];
					}
					catch (IndexOutOfRangeException)
					{
						result = 0.0;
					}
					return result;
				}
				return 0.0;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x00008E9C File Offset: 0x0000709C
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x00008EA4 File Offset: 0x000070A4
		internal byte ActionStatus
		{
			get
			{
				return this.byte_4;
			}
			set
			{
				if (value == 0 && this.byte_4 == 2)
				{
					frmLogin.long_37 = frmLogin.stopwatch_0.ElapsedMilliseconds;
				}
				else
				{
					frmLogin.long_37 = 0L;
				}
				this.byte_4 = value;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x00008ED1 File Offset: 0x000070D1
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x0009929C File Offset: 0x0009749C
		internal int isSceneTrans
		{
			get
			{
				return this.int_43;
			}
			set
			{
				if (value != this.int_43)
				{
					this.long_101 = frmLogin.stopwatch_0.ElapsedMilliseconds;
				}
				if (this.int_43 == 1)
				{
					this.long_102 = frmLogin.stopwatch_0.ElapsedMilliseconds + 60000L;
				}
				this.int_43 = value;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x00008ED9 File Offset: 0x000070D9
		internal int ThreadStamp
		{
			get
			{
				if (this.class59_0 != null)
				{
					return Class208.smethod_2(this.class59_0.pByte_2, 875);
				}
				return 0;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000775 RID: 1909 RVA: 0x00008EFA File Offset: 0x000070FA
		internal long PacketWriteIndex
		{
			get
			{
				if (this.class59_0 != null)
				{
					return Class208.smethod_3(this.class59_0.pByte_2, 883);
				}
				return 0L;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x00008F1C File Offset: 0x0000711C
		internal long QuaiWriteIndex
		{
			get
			{
				if (this.class59_0 != null)
				{
					return Class208.smethod_3(this.class59_0.pByte_2, 899);
				}
				return 0L;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000777 RID: 1911 RVA: 0x00008F3E File Offset: 0x0000713E
		internal long HKWriteIndex
		{
			get
			{
				if (this.class59_0 != null)
				{
					return Class208.smethod_3(this.class59_0.pByte_2, 935);
				}
				return 0L;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x00008F60 File Offset: 0x00007160
		internal long NguoiWriteIndex
		{
			get
			{
				if (this.class59_0 != null)
				{
					return Class208.smethod_3(this.class59_0.pByte_2, 907);
				}
				return 0L;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000779 RID: 1913 RVA: 0x00008F82 File Offset: 0x00007182
		internal long BocWriteIndex
		{
			get
			{
				if (this.class59_0 != null)
				{
					return Class208.smethod_3(this.class59_0.pByte_2, 915);
				}
				return 0L;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x00008FA4 File Offset: 0x000071A4
		internal long MsgWriteIndex
		{
			get
			{
				if (this.class59_0 != null)
				{
					return Class208.smethod_3(this.class59_0.pByte_2, 923);
				}
				return 0L;
			}
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x000024E9 File Offset: 0x000006E9
		internal static void smethod_4()
		{
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00008FC6 File Offset: 0x000071C6
		internal static void smethod_5()
		{
			Class114.smethod_3();
			Class114.smethod_1();
			if (!frmLogin.bool_24 || !frmLogin.bool_25 || !frmLogin.bool_26)
			{
				Class83.smethod_62(false);
			}
		}

		// Token: 0x04000634 RID: 1588
		[CompilerGenerated]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x04000635 RID: 1589
		private Class59 class59_0;

		// Token: 0x04000636 RID: 1590
		internal List<Class61> list_0 = new List<Class61>();

		// Token: 0x04000637 RID: 1591
		private Class58 class58_0;

		// Token: 0x04000638 RID: 1592
		internal List<int> list_1 = new List<int>();

		// Token: 0x04000639 RID: 1593
		internal long long_0;

		// Token: 0x0400063A RID: 1594
		internal long long_1;

		// Token: 0x0400063B RID: 1595
		internal bool bool_0;

		// Token: 0x0400063C RID: 1596
		internal List<Class60> list_2 = new List<Class60>();

		// Token: 0x0400063D RID: 1597
		internal List<Class57.Enum13> list_3 = new List<Class57.Enum13>
		{
			Class57.Enum13.const_13,
			Class57.Enum13.const_12,
			Class57.Enum13.const_3,
			Class57.Enum13.const_2,
			Class57.Enum13.const_8,
			Class57.Enum13.const_18,
			Class57.Enum13.const_11,
			Class57.Enum13.const_10
		};

		// Token: 0x0400063E RID: 1598
		internal string string_0 = "";

		// Token: 0x0400063F RID: 1599
		internal Class57.Enum10 enum10_0;

		// Token: 0x04000640 RID: 1600
		private Class57.Menpais menpais_0 = Class57.Menpais.NOMENPAI;

		// Token: 0x04000641 RID: 1601
		internal long long_2;

		// Token: 0x04000642 RID: 1602
		private Class57.Enum13 enum13_0;

		// Token: 0x04000643 RID: 1603
		private List<Class57.Menpais> list_4 = new List<Class57.Menpais>
		{
			Class57.Menpais.NOMENPAI,
			Class57.Menpais.CAIBANG,
			Class57.Menpais.THIENSON,
			Class57.Menpais.MINHGIAO,
			Class57.Menpais.THIEULAM,
			Class57.Menpais.MODUNG
		};

		// Token: 0x04000644 RID: 1604
		internal int[] int_0 = new int[]
		{
			0,
			90,
			324,
			630,
			1152,
			1620,
			1800,
			1980,
			2160,
			2340,
			6300,
			7020,
			7776,
			8874,
			10044,
			11628,
			13320,
			15498,
			18216,
			21528,
			25488,
			30150,
			35568,
			41796,
			48888,
			57420,
			67500,
			78678,
			91008,
			104544,
			123624,
			144270,
			166536,
			190476,
			216144,
			243594,
			272880,
			304056,
			337176,
			372294,
			409860,
			449955,
			492660,
			538056,
			586224,
			637245,
			691200,
			748170,
			808236,
			871479,
			937980,
			1007820,
			1081080,
			1157841,
			1238184,
			1322190,
			1409940,
			1501515,
			1596996,
			1696464,
			1800000,
			1907685,
			2019600,
			2135826,
			2256444,
			2381535,
			2516850,
			2667825,
			2835000,
			3018915,
			3220110,
			3439125,
			3676500,
			3932775,
			4208490,
			4518405,
			4863600,
			5245155,
			5664150,
			6121665,
			6739740,
			7676775,
			9098370,
			11177325,
			14093640,
			18034515,
			23194350,
			29774745,
			37984500,
			48039615,
			60163290,
			74585925,
			91545120,
			111285675,
			134059590,
			160126065,
			189751500,
			223209495,
			260780850,
			302753565,
			307564920,
			312506775,
			317581830,
			322792785,
			328142340,
			333633195,
			339268050,
			345049605,
			350980560,
			357063615,
			363301470,
			369696825,
			376252380,
			382970835,
			389854890,
			396907245,
			404130600,
			411527655,
			419101110,
			426853665,
			434788020,
			442906875,
			451212930,
			459708885,
			468397440,
			477281295,
			486363150,
			495645705,
			505131660,
			514823715,
			524724570,
			534836925,
			545163480,
			555706935,
			566469990,
			577455345,
			588665700,
			600103755,
			611772210,
			623673765,
			635811120,
			648186975,
			660804030,
			673664985,
			686772540,
			724294215,
			766577250,
			813979845,
			866867400,
			925612515
		};

		// Token: 0x04000645 RID: 1605
		internal List<int> list_5 = new List<int>();

		// Token: 0x04000646 RID: 1606
		internal Class119 class119_0;

		// Token: 0x04000647 RID: 1607
		internal int int_1;

		// Token: 0x04000648 RID: 1608
		internal int int_2 = -1;

		// Token: 0x04000649 RID: 1609
		internal int int_3;

		// Token: 0x0400064A RID: 1610
		internal int int_4;

		// Token: 0x0400064B RID: 1611
		internal int int_5 = -1;

		// Token: 0x0400064C RID: 1612
		internal Class57.FightingModes fightingModes_0;

		// Token: 0x0400064D RID: 1613
		internal List<Class120> list_6 = new List<Class120>();

		// Token: 0x0400064E RID: 1614
		internal bool bool_1 = true;

		// Token: 0x0400064F RID: 1615
		internal Stopwatch stopwatch_0 = new Stopwatch();

		// Token: 0x04000650 RID: 1616
		internal long long_3;

		// Token: 0x04000651 RID: 1617
		internal int int_6;

		// Token: 0x04000652 RID: 1618
		internal int int_7;

		// Token: 0x04000653 RID: 1619
		internal int int_8;

		// Token: 0x04000654 RID: 1620
		internal int int_9;

		// Token: 0x04000655 RID: 1621
		internal int int_10 = -1;

		// Token: 0x04000656 RID: 1622
		internal int int_11;

		// Token: 0x04000657 RID: 1623
		internal int int_12;

		// Token: 0x04000658 RID: 1624
		internal int int_13;

		// Token: 0x04000659 RID: 1625
		internal long long_4;

		// Token: 0x0400065A RID: 1626
		internal int int_14 = -1;

		// Token: 0x0400065B RID: 1627
		internal long long_5;

		// Token: 0x0400065C RID: 1628
		private int int_15 = -1;

		// Token: 0x0400065D RID: 1629
		private int int_16 = -1;

		// Token: 0x0400065E RID: 1630
		internal string string_1 = "";

		// Token: 0x0400065F RID: 1631
		internal string string_2 = "";

		// Token: 0x04000660 RID: 1632
		internal string string_3 = "";

		// Token: 0x04000661 RID: 1633
		internal int int_17;

		// Token: 0x04000662 RID: 1634
		internal int int_18;

		// Token: 0x04000663 RID: 1635
		private string string_4 = "0%";

		// Token: 0x04000664 RID: 1636
		internal int int_19;

		// Token: 0x04000665 RID: 1637
		internal int int_20;

		// Token: 0x04000666 RID: 1638
		internal int int_21;

		// Token: 0x04000667 RID: 1639
		internal int int_22 = 1000;

		// Token: 0x04000668 RID: 1640
		internal int int_23;

		// Token: 0x04000669 RID: 1641
		internal int int_24 = -1;

		// Token: 0x0400066A RID: 1642
		internal int int_25;

		// Token: 0x0400066B RID: 1643
		internal int int_26;

		// Token: 0x0400066C RID: 1644
		internal float float_0;

		// Token: 0x0400066D RID: 1645
		internal List<Class47> list_7;

		// Token: 0x0400066E RID: 1646
		internal List<Class47> list_8;

		// Token: 0x0400066F RID: 1647
		internal bool bool_2;

		// Token: 0x04000670 RID: 1648
		internal int int_27;

		// Token: 0x04000671 RID: 1649
		internal bool bool_3;

		// Token: 0x04000672 RID: 1650
		internal float float_1;

		// Token: 0x04000673 RID: 1651
		internal float float_2;

		// Token: 0x04000674 RID: 1652
		internal long long_6;

		// Token: 0x04000675 RID: 1653
		internal int int_28 = 3000;

		// Token: 0x04000676 RID: 1654
		internal float float_3;

		// Token: 0x04000677 RID: 1655
		internal float float_4;

		// Token: 0x04000678 RID: 1656
		internal float float_5;

		// Token: 0x04000679 RID: 1657
		internal Stopwatch stopwatch_1 = new Stopwatch();

		// Token: 0x0400067A RID: 1658
		internal Stopwatch stopwatch_2 = new Stopwatch();

		// Token: 0x0400067B RID: 1659
		internal float float_6;

		// Token: 0x0400067C RID: 1660
		internal Stopwatch stopwatch_3 = new Stopwatch();

		// Token: 0x0400067D RID: 1661
		internal Class57.Enum13 enum13_1;

		// Token: 0x0400067E RID: 1662
		internal int int_29 = -1;

		// Token: 0x0400067F RID: 1663
		internal bool bool_4;

		// Token: 0x04000680 RID: 1664
		internal bool bool_5;

		// Token: 0x04000681 RID: 1665
		internal bool bool_6;

		// Token: 0x04000682 RID: 1666
		internal int int_30;

		// Token: 0x04000683 RID: 1667
		internal bool bool_7;

		// Token: 0x04000684 RID: 1668
		internal bool bool_8;

		// Token: 0x04000685 RID: 1669
		internal Stopwatch stopwatch_4 = new Stopwatch();

		// Token: 0x04000686 RID: 1670
		internal long long_7;

		// Token: 0x04000687 RID: 1671
		internal Stopwatch stopwatch_5 = new Stopwatch();

		// Token: 0x04000688 RID: 1672
		internal long long_8;

		// Token: 0x04000689 RID: 1673
		internal long long_9;

		// Token: 0x0400068A RID: 1674
		internal long long_10 = 5000L;

		// Token: 0x0400068B RID: 1675
		internal int int_31;

		// Token: 0x0400068C RID: 1676
		internal bool bool_9;

		// Token: 0x0400068D RID: 1677
		internal bool bool_10;

		// Token: 0x0400068E RID: 1678
		internal Class47 class47_0 = new Class47();

		// Token: 0x0400068F RID: 1679
		internal Class47 class47_1 = new Class47();

		// Token: 0x04000690 RID: 1680
		internal Class57.Enum13 enum13_2;

		// Token: 0x04000691 RID: 1681
		internal Stopwatch stopwatch_6 = new Stopwatch();

		// Token: 0x04000692 RID: 1682
		internal Stopwatch stopwatch_7 = new Stopwatch();

		// Token: 0x04000693 RID: 1683
		internal Stopwatch stopwatch_8 = new Stopwatch();

		// Token: 0x04000694 RID: 1684
		internal bool bool_11;

		// Token: 0x04000695 RID: 1685
		internal Stopwatch stopwatch_9 = new Stopwatch();

		// Token: 0x04000696 RID: 1686
		internal Stopwatch stopwatch_10 = new Stopwatch();

		// Token: 0x04000697 RID: 1687
		internal float float_7;

		// Token: 0x04000698 RID: 1688
		internal float float_8;

		// Token: 0x04000699 RID: 1689
		internal float float_9 = -1f;

		// Token: 0x0400069A RID: 1690
		internal float float_10 = -1f;

		// Token: 0x0400069B RID: 1691
		internal int int_32 = -1;

		// Token: 0x0400069C RID: 1692
		internal bool bool_12;

		// Token: 0x0400069D RID: 1693
		internal int int_33 = -1;

		// Token: 0x0400069E RID: 1694
		internal int int_34;

		// Token: 0x0400069F RID: 1695
		internal int int_35;

		// Token: 0x040006A0 RID: 1696
		internal bool bool_13 = true;

		// Token: 0x040006A1 RID: 1697
		internal bool bool_14;

		// Token: 0x040006A2 RID: 1698
		internal int int_36;

		// Token: 0x040006A3 RID: 1699
		internal Stopwatch stopwatch_11 = new Stopwatch();

		// Token: 0x040006A4 RID: 1700
		internal List<Label> list_9 = new List<Label>();

		// Token: 0x040006A5 RID: 1701
		internal bool bool_15;

		// Token: 0x040006A6 RID: 1702
		internal long long_11;

		// Token: 0x040006A7 RID: 1703
		internal bool bool_16;

		// Token: 0x040006A8 RID: 1704
		internal Stopwatch stopwatch_12 = new Stopwatch();

		// Token: 0x040006A9 RID: 1705
		internal bool bool_17;

		// Token: 0x040006AA RID: 1706
		internal Stopwatch stopwatch_13 = new Stopwatch();

		// Token: 0x040006AB RID: 1707
		internal bool bool_18;

		// Token: 0x040006AC RID: 1708
		internal long long_12;

		// Token: 0x040006AD RID: 1709
		internal Stopwatch stopwatch_14 = new Stopwatch();

		// Token: 0x040006AE RID: 1710
		internal long long_13;

		// Token: 0x040006AF RID: 1711
		internal bool bool_19 = true;

		// Token: 0x040006B0 RID: 1712
		internal long long_14;

		// Token: 0x040006B1 RID: 1713
		internal bool bool_20 = true;

		// Token: 0x040006B2 RID: 1714
		internal float float_11;

		// Token: 0x040006B3 RID: 1715
		internal float float_12;

		// Token: 0x040006B4 RID: 1716
		internal float float_13;

		// Token: 0x040006B5 RID: 1717
		internal float float_14;

		// Token: 0x040006B6 RID: 1718
		internal float float_15;

		// Token: 0x040006B7 RID: 1719
		internal float float_16;

		// Token: 0x040006B8 RID: 1720
		internal double double_0;

		// Token: 0x040006B9 RID: 1721
		internal int int_37;

		// Token: 0x040006BA RID: 1722
		internal byte byte_0;

		// Token: 0x040006BB RID: 1723
		internal byte byte_1;

		// Token: 0x040006BC RID: 1724
		internal byte byte_2;

		// Token: 0x040006BD RID: 1725
		internal int int_38 = -1;

		// Token: 0x040006BE RID: 1726
		internal byte byte_3;

		// Token: 0x040006BF RID: 1727
		internal byte byte_4;

		// Token: 0x040006C0 RID: 1728
		internal byte byte_5;

		// Token: 0x040006C1 RID: 1729
		internal bool bool_21;

		// Token: 0x040006C2 RID: 1730
		internal bool bool_22;

		// Token: 0x040006C3 RID: 1731
		internal bool bool_23;

		// Token: 0x040006C4 RID: 1732
		internal bool bool_24;

		// Token: 0x040006C5 RID: 1733
		internal int int_39;

		// Token: 0x040006C6 RID: 1734
		internal bool bool_25;

		// Token: 0x040006C7 RID: 1735
		internal long long_15;

		// Token: 0x040006C8 RID: 1736
		internal bool bool_26;

		// Token: 0x040006C9 RID: 1737
		internal bool bool_27;

		// Token: 0x040006CA RID: 1738
		internal bool bool_28;

		// Token: 0x040006CB RID: 1739
		internal bool bool_29;

		// Token: 0x040006CC RID: 1740
		internal bool bool_30;

		// Token: 0x040006CD RID: 1741
		internal Stopwatch stopwatch_15 = new Stopwatch();

		// Token: 0x040006CE RID: 1742
		internal int int_40;

		// Token: 0x040006CF RID: 1743
		internal long long_16;

		// Token: 0x040006D0 RID: 1744
		internal long long_17;

		// Token: 0x040006D1 RID: 1745
		internal Class57.Enum1 enum1_0 = Class57.Enum1.const_1;

		// Token: 0x040006D2 RID: 1746
		internal long long_18;

		// Token: 0x040006D3 RID: 1747
		internal int int_41;

		// Token: 0x040006D4 RID: 1748
		internal Stopwatch stopwatch_16 = new Stopwatch();

		// Token: 0x040006D5 RID: 1749
		internal Stopwatch stopwatch_17 = new Stopwatch();

		// Token: 0x040006D6 RID: 1750
		internal Class48 class48_0;

		// Token: 0x040006D7 RID: 1751
		internal long long_19;

		// Token: 0x040006D8 RID: 1752
		internal long long_20 = frmLogin.stopwatch_0.ElapsedMilliseconds;

		// Token: 0x040006D9 RID: 1753
		internal int int_42;

		// Token: 0x040006DA RID: 1754
		private int int_43;

		// Token: 0x040006DB RID: 1755
		internal int int_44;

		// Token: 0x040006DC RID: 1756
		internal int int_45;

		// Token: 0x040006DD RID: 1757
		internal int int_46;

		// Token: 0x040006DE RID: 1758
		internal int int_47;

		// Token: 0x040006DF RID: 1759
		internal long long_21;

		// Token: 0x040006E0 RID: 1760
		internal int int_48;

		// Token: 0x040006E1 RID: 1761
		internal int int_49 = 60000;

		// Token: 0x040006E2 RID: 1762
		internal Stopwatch stopwatch_18 = new Stopwatch();

		// Token: 0x040006E3 RID: 1763
		internal Class57.Enum13 enum13_3;

		// Token: 0x040006E4 RID: 1764
		internal bool bool_31;

		// Token: 0x040006E5 RID: 1765
		internal long long_22;

		// Token: 0x040006E6 RID: 1766
		internal bool bool_32;

		// Token: 0x040006E7 RID: 1767
		internal long long_23;

		// Token: 0x040006E8 RID: 1768
		internal Stopwatch stopwatch_19 = new Stopwatch();

		// Token: 0x040006E9 RID: 1769
		internal bool bool_33;

		// Token: 0x040006EA RID: 1770
		internal Stopwatch stopwatch_20 = new Stopwatch();

		// Token: 0x040006EB RID: 1771
		internal Stopwatch stopwatch_21 = new Stopwatch();

		// Token: 0x040006EC RID: 1772
		internal long long_24;

		// Token: 0x040006ED RID: 1773
		internal int int_50 = 25000;

		// Token: 0x040006EE RID: 1774
		internal int int_51 = 900000;

		// Token: 0x040006EF RID: 1775
		internal bool bool_34;

		// Token: 0x040006F0 RID: 1776
		internal bool bool_35;

		// Token: 0x040006F1 RID: 1777
		internal List<Class109> list_10 = new List<Class109>();

		// Token: 0x040006F2 RID: 1778
		internal List<Class109> list_11 = new List<Class109>();

		// Token: 0x040006F3 RID: 1779
		internal bool bool_36;

		// Token: 0x040006F4 RID: 1780
		internal Stopwatch stopwatch_22 = new Stopwatch();

		// Token: 0x040006F5 RID: 1781
		internal bool bool_37;

		// Token: 0x040006F6 RID: 1782
		internal bool bool_38;

		// Token: 0x040006F7 RID: 1783
		internal Stopwatch stopwatch_23 = new Stopwatch();

		// Token: 0x040006F8 RID: 1784
		internal bool bool_39;

		// Token: 0x040006F9 RID: 1785
		internal int int_52 = 7;

		// Token: 0x040006FA RID: 1786
		internal bool bool_40;

		// Token: 0x040006FB RID: 1787
		internal bool bool_41;

		// Token: 0x040006FC RID: 1788
		internal long long_25;

		// Token: 0x040006FD RID: 1789
		internal bool bool_42;

		// Token: 0x040006FE RID: 1790
		internal Stopwatch stopwatch_24 = new Stopwatch();

		// Token: 0x040006FF RID: 1791
		internal Stopwatch stopwatch_25 = new Stopwatch();

		// Token: 0x04000700 RID: 1792
		internal string string_5 = "";

		// Token: 0x04000701 RID: 1793
		internal Stopwatch stopwatch_26 = new Stopwatch();

		// Token: 0x04000702 RID: 1794
		internal bool bool_43;

		// Token: 0x04000703 RID: 1795
		internal bool bool_44;

		// Token: 0x04000704 RID: 1796
		internal int int_53;

		// Token: 0x04000705 RID: 1797
		internal int int_54;

		// Token: 0x04000706 RID: 1798
		internal DateTime dateTime_0;

		// Token: 0x04000707 RID: 1799
		internal TimeSpan timeSpan_0;

		// Token: 0x04000708 RID: 1800
		internal Stopwatch stopwatch_27 = new Stopwatch();

		// Token: 0x04000709 RID: 1801
		internal int int_55;

		// Token: 0x0400070A RID: 1802
		internal long long_26;

		// Token: 0x0400070B RID: 1803
		internal bool bool_45;

		// Token: 0x0400070C RID: 1804
		internal object object_0 = new object();

		// Token: 0x0400070D RID: 1805
		internal int int_56 = -1;

		// Token: 0x0400070E RID: 1806
		internal Stopwatch stopwatch_28 = new Stopwatch();

		// Token: 0x0400070F RID: 1807
		internal int int_57 = -1;

		// Token: 0x04000710 RID: 1808
		internal long long_27;

		// Token: 0x04000711 RID: 1809
		internal bool bool_46;

		// Token: 0x04000712 RID: 1810
		internal bool bool_47;

		// Token: 0x04000713 RID: 1811
		internal long long_28;

		// Token: 0x04000714 RID: 1812
		internal bool bool_48;

		// Token: 0x04000715 RID: 1813
		internal int int_58 = -1;

		// Token: 0x04000716 RID: 1814
		internal string string_6 = "";

		// Token: 0x04000717 RID: 1815
		internal string string_7 = "";

		// Token: 0x04000718 RID: 1816
		internal int int_59 = -1;

		// Token: 0x04000719 RID: 1817
		internal int int_60 = -1;

		// Token: 0x0400071A RID: 1818
		internal int int_61;

		// Token: 0x0400071B RID: 1819
		internal bool bool_49;

		// Token: 0x0400071C RID: 1820
		internal int int_62;

		// Token: 0x0400071D RID: 1821
		internal int int_63;

		// Token: 0x0400071E RID: 1822
		private int int_64;

		// Token: 0x0400071F RID: 1823
		internal int int_65;

		// Token: 0x04000720 RID: 1824
		internal int int_66;

		// Token: 0x04000721 RID: 1825
		internal int int_67;

		// Token: 0x04000722 RID: 1826
		internal int int_68;

		// Token: 0x04000723 RID: 1827
		internal int int_69 = -1;

		// Token: 0x04000724 RID: 1828
		internal int int_70;

		// Token: 0x04000725 RID: 1829
		internal int int_71;

		// Token: 0x04000726 RID: 1830
		internal int int_72;

		// Token: 0x04000727 RID: 1831
		internal int int_73;

		// Token: 0x04000728 RID: 1832
		private int int_74;

		// Token: 0x04000729 RID: 1833
		internal int int_75;

		// Token: 0x0400072A RID: 1834
		internal int int_76;

		// Token: 0x0400072B RID: 1835
		internal int int_77;

		// Token: 0x0400072C RID: 1836
		internal string string_8 = "";

		// Token: 0x0400072D RID: 1837
		private int int_78 = -1;

		// Token: 0x0400072E RID: 1838
		internal int int_79 = -1;

		// Token: 0x0400072F RID: 1839
		internal List<Class64> list_12 = new List<Class64>();

		// Token: 0x04000730 RID: 1840
		internal List<Class64> list_13 = new List<Class64>();

		// Token: 0x04000731 RID: 1841
		internal long long_29;

		// Token: 0x04000732 RID: 1842
		internal bool bool_50;

		// Token: 0x04000733 RID: 1843
		internal bool bool_51;

		// Token: 0x04000734 RID: 1844
		internal bool bool_52;

		// Token: 0x04000735 RID: 1845
		internal bool bool_53;

		// Token: 0x04000736 RID: 1846
		internal bool bool_54;

		// Token: 0x04000737 RID: 1847
		internal bool bool_55;

		// Token: 0x04000738 RID: 1848
		internal long long_30;

		// Token: 0x04000739 RID: 1849
		internal long long_31;

		// Token: 0x0400073A RID: 1850
		internal long long_32;

		// Token: 0x0400073B RID: 1851
		internal long long_33;

		// Token: 0x0400073C RID: 1852
		internal int int_80;

		// Token: 0x0400073D RID: 1853
		internal bool bool_56 = true;

		// Token: 0x0400073E RID: 1854
		internal int int_81;

		// Token: 0x0400073F RID: 1855
		internal long long_34;

		// Token: 0x04000740 RID: 1856
		internal long long_35;

		// Token: 0x04000741 RID: 1857
		internal long long_36;

		// Token: 0x04000742 RID: 1858
		internal long long_37;

		// Token: 0x04000743 RID: 1859
		internal long long_38;

		// Token: 0x04000744 RID: 1860
		internal long long_39;

		// Token: 0x04000745 RID: 1861
		internal long long_40;

		// Token: 0x04000746 RID: 1862
		internal bool bool_57;

		// Token: 0x04000747 RID: 1863
		internal bool bool_58;

		// Token: 0x04000748 RID: 1864
		internal bool bool_59;

		// Token: 0x04000749 RID: 1865
		internal bool bool_60;

		// Token: 0x0400074A RID: 1866
		internal long long_41;

		// Token: 0x0400074B RID: 1867
		internal bool bool_61;

		// Token: 0x0400074C RID: 1868
		internal int int_82;

		// Token: 0x0400074D RID: 1869
		internal bool bool_62;

		// Token: 0x0400074E RID: 1870
		internal long long_42;

		// Token: 0x0400074F RID: 1871
		internal bool bool_63;

		// Token: 0x04000750 RID: 1872
		internal bool bool_64;

		// Token: 0x04000751 RID: 1873
		internal long long_43;

		// Token: 0x04000752 RID: 1874
		internal List<Class119> list_14 = new List<Class119>();

		// Token: 0x04000753 RID: 1875
		internal long long_44;

		// Token: 0x04000754 RID: 1876
		internal bool bool_65;

		// Token: 0x04000755 RID: 1877
		internal bool bool_66;

		// Token: 0x04000756 RID: 1878
		internal bool bool_67;

		// Token: 0x04000757 RID: 1879
		internal bool bool_68;

		// Token: 0x04000758 RID: 1880
		internal bool bool_69;

		// Token: 0x04000759 RID: 1881
		internal bool bool_70;

		// Token: 0x0400075A RID: 1882
		internal bool bool_71;

		// Token: 0x0400075B RID: 1883
		internal bool bool_72;

		// Token: 0x0400075C RID: 1884
		internal bool bool_73;

		// Token: 0x0400075D RID: 1885
		internal bool bool_74;

		// Token: 0x0400075E RID: 1886
		internal bool bool_75;

		// Token: 0x0400075F RID: 1887
		internal bool bool_76;

		// Token: 0x04000760 RID: 1888
		internal long long_45;

		// Token: 0x04000761 RID: 1889
		internal bool bool_77;

		// Token: 0x04000762 RID: 1890
		internal bool bool_78;

		// Token: 0x04000763 RID: 1891
		internal bool bool_79;

		// Token: 0x04000764 RID: 1892
		internal bool bool_80;

		// Token: 0x04000765 RID: 1893
		internal bool bool_81;

		// Token: 0x04000766 RID: 1894
		internal bool bool_82;

		// Token: 0x04000767 RID: 1895
		internal bool bool_83;

		// Token: 0x04000768 RID: 1896
		internal bool bool_84;

		// Token: 0x04000769 RID: 1897
		internal string string_9 = "";

		// Token: 0x0400076A RID: 1898
		internal long long_46;

		// Token: 0x0400076B RID: 1899
		internal bool bool_85;

		// Token: 0x0400076C RID: 1900
		internal int int_83;

		// Token: 0x0400076D RID: 1901
		internal bool bool_86;

		// Token: 0x0400076E RID: 1902
		internal bool bool_87;

		// Token: 0x0400076F RID: 1903
		internal long long_47;

		// Token: 0x04000770 RID: 1904
		internal long long_48;

		// Token: 0x04000771 RID: 1905
		internal long long_49;

		// Token: 0x04000772 RID: 1906
		internal long long_50;

		// Token: 0x04000773 RID: 1907
		internal long long_51;

		// Token: 0x04000774 RID: 1908
		internal long long_52;

		// Token: 0x04000775 RID: 1909
		internal long long_53;

		// Token: 0x04000776 RID: 1910
		internal long long_54;

		// Token: 0x04000777 RID: 1911
		internal long long_55;

		// Token: 0x04000778 RID: 1912
		internal long long_56;

		// Token: 0x04000779 RID: 1913
		internal long long_57;

		// Token: 0x0400077A RID: 1914
		internal long long_58;

		// Token: 0x0400077B RID: 1915
		internal long long_59;

		// Token: 0x0400077C RID: 1916
		internal bool bool_88;

		// Token: 0x0400077D RID: 1917
		internal bool bool_89;

		// Token: 0x0400077E RID: 1918
		internal bool bool_90;

		// Token: 0x0400077F RID: 1919
		internal int int_84;

		// Token: 0x04000780 RID: 1920
		internal long long_60;

		// Token: 0x04000781 RID: 1921
		internal bool bool_91;

		// Token: 0x04000782 RID: 1922
		internal bool bool_92;

		// Token: 0x04000783 RID: 1923
		internal bool bool_93;

		// Token: 0x04000784 RID: 1924
		internal bool bool_94;

		// Token: 0x04000785 RID: 1925
		internal int int_85;

		// Token: 0x04000786 RID: 1926
		internal int int_86;

		// Token: 0x04000787 RID: 1927
		internal int int_87;

		// Token: 0x04000788 RID: 1928
		internal int int_88;

		// Token: 0x04000789 RID: 1929
		internal int int_89;

		// Token: 0x0400078A RID: 1930
		internal int int_90;

		// Token: 0x0400078B RID: 1931
		internal int int_91;

		// Token: 0x0400078C RID: 1932
		internal int int_92;

		// Token: 0x0400078D RID: 1933
		internal int int_93;

		// Token: 0x0400078E RID: 1934
		internal int int_94;

		// Token: 0x0400078F RID: 1935
		internal int int_95;

		// Token: 0x04000790 RID: 1936
		internal int int_96;

		// Token: 0x04000791 RID: 1937
		internal int int_97;

		// Token: 0x04000792 RID: 1938
		internal int int_98;

		// Token: 0x04000793 RID: 1939
		internal int int_99;

		// Token: 0x04000794 RID: 1940
		internal int int_100;

		// Token: 0x04000795 RID: 1941
		internal int int_101;

		// Token: 0x04000796 RID: 1942
		internal int int_102;

		// Token: 0x04000797 RID: 1943
		internal int int_103;

		// Token: 0x04000798 RID: 1944
		internal int int_104;

		// Token: 0x04000799 RID: 1945
		internal int int_105;

		// Token: 0x0400079A RID: 1946
		internal int int_106;

		// Token: 0x0400079B RID: 1947
		internal int int_107;

		// Token: 0x0400079C RID: 1948
		internal long long_61;

		// Token: 0x0400079D RID: 1949
		internal int int_108;

		// Token: 0x0400079E RID: 1950
		internal string string_10 = "";

		// Token: 0x0400079F RID: 1951
		internal int int_109;

		// Token: 0x040007A0 RID: 1952
		internal bool bool_95;

		// Token: 0x040007A1 RID: 1953
		internal int int_110;

		// Token: 0x040007A2 RID: 1954
		internal int int_111;

		// Token: 0x040007A3 RID: 1955
		internal bool bool_96;

		// Token: 0x040007A4 RID: 1956
		internal bool bool_97;

		// Token: 0x040007A5 RID: 1957
		internal bool bool_98;

		// Token: 0x040007A6 RID: 1958
		internal bool bool_99;

		// Token: 0x040007A7 RID: 1959
		internal bool bool_100;

		// Token: 0x040007A8 RID: 1960
		internal bool bool_101;

		// Token: 0x040007A9 RID: 1961
		internal bool bool_102;

		// Token: 0x040007AA RID: 1962
		internal bool bool_103;

		// Token: 0x040007AB RID: 1963
		internal bool bool_104;

		// Token: 0x040007AC RID: 1964
		internal bool bool_105;

		// Token: 0x040007AD RID: 1965
		internal int int_112;

		// Token: 0x040007AE RID: 1966
		internal bool bool_106;

		// Token: 0x040007AF RID: 1967
		internal bool bool_107;

		// Token: 0x040007B0 RID: 1968
		internal long long_62;

		// Token: 0x040007B1 RID: 1969
		internal bool bool_108;

		// Token: 0x040007B2 RID: 1970
		internal bool bool_109;

		// Token: 0x040007B3 RID: 1971
		internal long long_63;

		// Token: 0x040007B4 RID: 1972
		internal long long_64;

		// Token: 0x040007B5 RID: 1973
		internal long long_65;

		// Token: 0x040007B6 RID: 1974
		internal long long_66;

		// Token: 0x040007B7 RID: 1975
		internal long long_67;

		// Token: 0x040007B8 RID: 1976
		internal long long_68;

		// Token: 0x040007B9 RID: 1977
		internal long long_69;

		// Token: 0x040007BA RID: 1978
		internal long long_70;

		// Token: 0x040007BB RID: 1979
		internal int int_113;

		// Token: 0x040007BC RID: 1980
		internal int int_114;

		// Token: 0x040007BD RID: 1981
		internal long long_71;

		// Token: 0x040007BE RID: 1982
		internal long long_72;

		// Token: 0x040007BF RID: 1983
		internal long long_73;

		// Token: 0x040007C0 RID: 1984
		internal long long_74;

		// Token: 0x040007C1 RID: 1985
		internal long long_75;

		// Token: 0x040007C2 RID: 1986
		internal long long_76;

		// Token: 0x040007C3 RID: 1987
		internal string string_11 = "";

		// Token: 0x040007C4 RID: 1988
		internal string string_12 = "";

		// Token: 0x040007C5 RID: 1989
		internal bool bool_110 = true;

		// Token: 0x040007C6 RID: 1990
		internal long long_77;

		// Token: 0x040007C7 RID: 1991
		internal bool bool_111;

		// Token: 0x040007C8 RID: 1992
		internal bool bool_112;

		// Token: 0x040007C9 RID: 1993
		internal bool bool_113;

		// Token: 0x040007CA RID: 1994
		internal bool bool_114;

		// Token: 0x040007CB RID: 1995
		internal bool bool_115;

		// Token: 0x040007CC RID: 1996
		internal int int_115 = -1;

		// Token: 0x040007CD RID: 1997
		internal int int_116 = -1;

		// Token: 0x040007CE RID: 1998
		internal int int_117 = -1;

		// Token: 0x040007CF RID: 1999
		internal bool bool_116;

		// Token: 0x040007D0 RID: 2000
		internal bool bool_117;

		// Token: 0x040007D1 RID: 2001
		internal bool bool_118;

		// Token: 0x040007D2 RID: 2002
		internal int int_118 = -1;

		// Token: 0x040007D3 RID: 2003
		internal bool bool_119;

		// Token: 0x040007D4 RID: 2004
		internal long long_78;

		// Token: 0x040007D5 RID: 2005
		internal bool bool_120;

		// Token: 0x040007D6 RID: 2006
		internal long long_79;

		// Token: 0x040007D7 RID: 2007
		internal long long_80;

		// Token: 0x040007D8 RID: 2008
		internal bool bool_121;

		// Token: 0x040007D9 RID: 2009
		internal bool bool_122;

		// Token: 0x040007DA RID: 2010
		internal int int_119 = -1;

		// Token: 0x040007DB RID: 2011
		internal bool bool_123;

		// Token: 0x040007DC RID: 2012
		internal bool bool_124;

		// Token: 0x040007DD RID: 2013
		internal long long_81;

		// Token: 0x040007DE RID: 2014
		internal bool bool_125;

		// Token: 0x040007DF RID: 2015
		internal Class57.Menpais menpais_1 = Class57.Menpais.NOMENPAI;

		// Token: 0x040007E0 RID: 2016
		internal bool bool_126;

		// Token: 0x040007E1 RID: 2017
		internal float float_17;

		// Token: 0x040007E2 RID: 2018
		internal float float_18;

		// Token: 0x040007E3 RID: 2019
		internal long long_82;

		// Token: 0x040007E4 RID: 2020
		internal bool bool_127;

		// Token: 0x040007E5 RID: 2021
		internal bool bool_128;

		// Token: 0x040007E6 RID: 2022
		internal long long_83;

		// Token: 0x040007E7 RID: 2023
		internal string string_13;

		// Token: 0x040007E8 RID: 2024
		internal long long_84;

		// Token: 0x040007E9 RID: 2025
		internal long long_85;

		// Token: 0x040007EA RID: 2026
		internal long long_86;

		// Token: 0x040007EB RID: 2027
		internal long long_87;

		// Token: 0x040007EC RID: 2028
		internal float float_19;

		// Token: 0x040007ED RID: 2029
		internal float float_20;

		// Token: 0x040007EE RID: 2030
		internal long long_88;

		// Token: 0x040007EF RID: 2031
		internal bool bool_129;

		// Token: 0x040007F0 RID: 2032
		internal long long_89;

		// Token: 0x040007F1 RID: 2033
		internal bool bool_130 = true;

		// Token: 0x040007F2 RID: 2034
		internal bool bool_131 = true;

		// Token: 0x040007F3 RID: 2035
		internal bool bool_132;

		// Token: 0x040007F4 RID: 2036
		internal bool bool_133;

		// Token: 0x040007F5 RID: 2037
		internal bool bool_134;

		// Token: 0x040007F6 RID: 2038
		internal bool bool_135;

		// Token: 0x040007F7 RID: 2039
		internal bool bool_136;

		// Token: 0x040007F8 RID: 2040
		internal bool bool_137;

		// Token: 0x040007F9 RID: 2041
		internal bool bool_138;

		// Token: 0x040007FA RID: 2042
		internal bool bool_139;

		// Token: 0x040007FB RID: 2043
		internal bool bool_140;

		// Token: 0x040007FC RID: 2044
		internal bool bool_141;

		// Token: 0x040007FD RID: 2045
		internal bool bool_142;

		// Token: 0x040007FE RID: 2046
		internal bool bool_143;

		// Token: 0x040007FF RID: 2047
		internal bool bool_144;

		// Token: 0x04000800 RID: 2048
		internal bool bool_145;

		// Token: 0x04000801 RID: 2049
		internal bool bool_146;

		// Token: 0x04000802 RID: 2050
		internal bool bool_147;

		// Token: 0x04000803 RID: 2051
		internal bool bool_148;

		// Token: 0x04000804 RID: 2052
		internal long long_90;

		// Token: 0x04000805 RID: 2053
		internal bool bool_149;

		// Token: 0x04000806 RID: 2054
		internal bool bool_150;

		// Token: 0x04000807 RID: 2055
		internal long long_91;

		// Token: 0x04000808 RID: 2056
		internal bool bool_151;

		// Token: 0x04000809 RID: 2057
		internal Class57.Enum13 enum13_4;

		// Token: 0x0400080A RID: 2058
		internal long long_92;

		// Token: 0x0400080B RID: 2059
		internal bool bool_152;

		// Token: 0x0400080C RID: 2060
		internal List<int> list_15 = new List<int>();

		// Token: 0x0400080D RID: 2061
		internal bool bool_153;

		// Token: 0x0400080E RID: 2062
		internal bool bool_154;

		// Token: 0x0400080F RID: 2063
		internal long long_93;

		// Token: 0x04000810 RID: 2064
		internal int int_120;

		// Token: 0x04000811 RID: 2065
		internal long long_94;

		// Token: 0x04000812 RID: 2066
		internal bool bool_155;

		// Token: 0x04000813 RID: 2067
		internal bool bool_156;

		// Token: 0x04000814 RID: 2068
		internal bool bool_157;

		// Token: 0x04000815 RID: 2069
		internal bool bool_158;

		// Token: 0x04000816 RID: 2070
		internal List<int> list_16 = new List<int>();

		// Token: 0x04000817 RID: 2071
		internal bool bool_159;

		// Token: 0x04000818 RID: 2072
		internal List<Class114.Class115> list_17 = new List<Class114.Class115>();

		// Token: 0x04000819 RID: 2073
		internal bool bool_160;

		// Token: 0x0400081A RID: 2074
		internal bool bool_161;

		// Token: 0x0400081B RID: 2075
		internal long long_95;

		// Token: 0x0400081C RID: 2076
		internal long long_96;

		// Token: 0x0400081D RID: 2077
		internal int int_121 = -1;

		// Token: 0x0400081E RID: 2078
		internal int int_122 = -1;

		// Token: 0x0400081F RID: 2079
		internal int int_123 = -1;

		// Token: 0x04000820 RID: 2080
		internal long long_97 = -1L;

		// Token: 0x04000821 RID: 2081
		internal long long_98;

		// Token: 0x04000822 RID: 2082
		internal bool bool_162;

		// Token: 0x04000823 RID: 2083
		internal bool bool_163;

		// Token: 0x04000824 RID: 2084
		internal string string_14 = "";

		// Token: 0x04000825 RID: 2085
		internal bool bool_164;

		// Token: 0x04000826 RID: 2086
		internal bool bool_165;

		// Token: 0x04000827 RID: 2087
		internal bool bool_166;

		// Token: 0x04000828 RID: 2088
		internal bool bool_167;

		// Token: 0x04000829 RID: 2089
		internal bool bool_168;

		// Token: 0x0400082A RID: 2090
		internal bool bool_169;

		// Token: 0x0400082B RID: 2091
		internal int int_124;

		// Token: 0x0400082C RID: 2092
		internal int int_125;

		// Token: 0x0400082D RID: 2093
		internal long long_99;

		// Token: 0x0400082E RID: 2094
		internal bool bool_170;

		// Token: 0x0400082F RID: 2095
		internal long long_100;

		// Token: 0x04000830 RID: 2096
		internal bool bool_171;

		// Token: 0x04000831 RID: 2097
		internal bool bool_172;

		// Token: 0x04000832 RID: 2098
		internal bool bool_173;

		// Token: 0x04000833 RID: 2099
		internal bool bool_174;

		// Token: 0x04000834 RID: 2100
		internal bool bool_175;

		// Token: 0x04000835 RID: 2101
		internal bool bool_176;

		// Token: 0x04000836 RID: 2102
		internal bool bool_177;

		// Token: 0x04000837 RID: 2103
		internal bool bool_178;

		// Token: 0x04000838 RID: 2104
		internal bool bool_179;

		// Token: 0x04000839 RID: 2105
		internal bool bool_180;

		// Token: 0x0400083A RID: 2106
		internal bool bool_181;

		// Token: 0x0400083B RID: 2107
		internal bool bool_182;

		// Token: 0x0400083C RID: 2108
		internal bool bool_183;

		// Token: 0x0400083D RID: 2109
		internal bool bool_184;

		// Token: 0x0400083E RID: 2110
		internal bool bool_185;

		// Token: 0x0400083F RID: 2111
		internal int int_126;

		// Token: 0x04000840 RID: 2112
		internal bool bool_186;

		// Token: 0x04000841 RID: 2113
		internal bool bool_187;

		// Token: 0x04000842 RID: 2114
		internal List<Class47> list_18;

		// Token: 0x04000843 RID: 2115
		internal long long_101;

		// Token: 0x04000844 RID: 2116
		internal long long_102;

		// Token: 0x04000845 RID: 2117
		internal bool bool_188;

		// Token: 0x04000846 RID: 2118
		internal int int_127;

		// Token: 0x04000847 RID: 2119
		internal bool bool_189;

		// Token: 0x04000848 RID: 2120
		internal int int_128;

		// Token: 0x04000849 RID: 2121
		internal bool bool_190;

		// Token: 0x0400084A RID: 2122
		internal int int_129;

		// Token: 0x0400084B RID: 2123
		internal bool bool_191;

		// Token: 0x0400084C RID: 2124
		internal int int_130;

		// Token: 0x0400084D RID: 2125
		internal bool bool_192;

		// Token: 0x0400084E RID: 2126
		internal long long_103;

		// Token: 0x0400084F RID: 2127
		internal bool bool_193;

		// Token: 0x04000850 RID: 2128
		internal bool bool_194;

		// Token: 0x04000851 RID: 2129
		internal bool bool_195;

		// Token: 0x04000852 RID: 2130
		public bool bool_196;

		// Token: 0x04000853 RID: 2131
		public int int_131;

		// Token: 0x04000854 RID: 2132
		public long long_104;

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x0600077E RID: 1918
		internal delegate void Delegate3();

		// Token: 0x0200009A RID: 154
		internal sealed class Class115
		{
			// Token: 0x04000855 RID: 2133
			internal int int_0;

			// Token: 0x04000856 RID: 2134
			internal long long_0;
		}
	}
}
