using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000067 RID: 103
	internal sealed class Class70 : INotifyPropertyChanged
	{
		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600037F RID: 895 RVA: 0x0006BBA4 File Offset: 0x00069DA4
		// (remove) Token: 0x06000380 RID: 896 RVA: 0x0006BBDC File Offset: 0x00069DDC
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

		// Token: 0x06000381 RID: 897 RVA: 0x0006BC14 File Offset: 0x00069E14
		private void method_0(string string_0)
		{
			Class70.Class71 @class = new Class70.Class71();
			@class.class70_0 = this;
			@class.string_0 = string_0;
			if (this.propertyChangedEventHandler_0 != null)
			{
				try
				{
					if (frmMain.frmMain_0.tabDieuKhien.InvokeRequired)
					{
						frmMain.frmMain_0.tabDieuKhien.Invoke(new MethodInvoker(@class.method_0));
					}
					else
					{
						this.propertyChangedEventHandler_0(this, new PropertyChangedEventArgs(@class.string_0));
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0006BC98 File Offset: 0x00069E98
		public int method_1(string string_0)
		{
			int num = 0;
			if (this.list_0.Count > 0)
			{
				for (int i = this.list_0.Count - 1; i >= 0; i--)
				{
					if (this.list_0[i].TNKey == string_0 && this.list_0[i].RemainMS > 0L)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0006BD00 File Offset: 0x00069F00
		public int method_2(string string_0)
		{
			int num = 0;
			if (this.list_0.Count > 0)
			{
				for (int i = this.list_0.Count - 1; i >= 0; i--)
				{
					if (this.list_0[i].TNKey == string_0 && this.list_0[i].RemainMS > 0L)
					{
						num += this.list_0[i].int_2;
					}
				}
			}
			return num;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0006BD78 File Offset: 0x00069F78
		public void method_3(string string_0, ref int int_0, ref string string_1)
		{
			try
			{
				if (frmLogin.class101_0.globalSettings_0.Account.class70_0.list_0.Count > 0)
				{
					for (int i = 0; i < frmLogin.class101_0.globalSettings_0.Account.class70_0.list_0.Count; i++)
					{
						if (frmLogin.class101_0.globalSettings_0.Account.class70_0.list_0[i].TNKey == string_0)
						{
							TimeSpan timeSpan = TimeSpan.FromSeconds((double)frmLogin.class101_0.globalSettings_0.Account.class70_0.list_0[i].RemainMS);
							if (timeSpan.Days > 0)
							{
								string_1 = string.Format("{0}d {1}:{2}", timeSpan.Days.ToString(), timeSpan.Hours.ToString("00"), timeSpan.Minutes.ToString("00"));
							}
							else
							{
								string_1 = string.Format("{0}:{1}", timeSpan.Hours.ToString("00"), timeSpan.Minutes.ToString("00"));
							}
							int_0++;
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000419A File Offset: 0x0000239A
		internal bool method_4()
		{
			return frmLogin.class101_0.globalSettings_0.Account.RemainMSeconds > 0.0;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0006BEDC File Offset: 0x0006A0DC
		internal void method_5()
		{
			long num = frmLogin.stopwatch_0.ElapsedMilliseconds - this.long_0;
			if (this.list_0.Count > 0 && Monitor.TryEnter(frmLogin.object_0, 5000))
			{
				try
				{
					for (int i = this.list_0.Count - 1; i >= 0; i--)
					{
						if (this.list_0[i].RemainMS * 1000L > num)
						{
							this.list_0[i].RemainMS = (this.list_0[i].RemainMS * 1000L - num) / 1000L;
							if (this.list_0[i].long_0 > 0L)
							{
								this.list_0[i].long_0 = 0L;
							}
						}
						else
						{
							if (this.list_0[i].RemainMS > 0L)
							{
								this.list_0[i].RemainMS = 0L;
							}
							if (this.list_0[i].long_0 == 0L)
							{
								this.list_0[i].long_0 = frmLogin.stopwatch_0.ElapsedMilliseconds + 10000L;
							}
							else if (frmLogin.stopwatch_0.ElapsedMilliseconds >= this.list_0[i].long_0)
							{
								this.list_0.RemoveAt(i);
							}
						}
					}
				}
				catch (Exception)
				{
				}
				finally
				{
					Monitor.Exit(frmLogin.object_0);
				}
			}
			this.long_0 = frmLogin.stopwatch_0.ElapsedMilliseconds;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0006C098 File Offset: 0x0006A298
		internal void method_6()
		{
			for (;;)
			{
				if (frmLogin.class101_0.bool_3 && frmLogin.stopwatch_0.ElapsedMilliseconds >= frmLogin.long_42)
				{
					frmLogin.long_42 = frmLogin.stopwatch_0.ElapsedMilliseconds + 45000L;
					int num = 0;
					int num2 = 0;
					int num3 = 0;
					int num4 = 0;
					try
					{
						for (int i = frmLogin.class101_0.class210_0.Count - 1; i >= 0; i--)
						{
							if (frmLogin.class101_0.class210_0[i].class114_0.bool_152)
							{
								num++;
							}
							if (frmLogin.class101_0.class210_0[i].class114_0.bool_155 || frmLogin.class101_0.class210_0[i].class114_0.bool_156)
							{
								num2++;
							}
							if (frmLogin.class101_0.class210_0[i].class114_0.bool_160)
							{
								num3++;
							}
							if (frmLogin.class101_0.class210_0[i].autoSettings_0.AIMode == Class57.AIModes.THUONGNHAN)
							{
								num4++;
							}
						}
						goto IL_2A8;
					}
					catch (Exception)
					{
						goto IL_2A8;
					}
					IL_11A:
					string string_;
					bool flag;
					bool flag2;
					this.method_7(string_, num3, ref flag, ref flag2);
					if (flag)
					{
						Class83.smethod_66(frmMain.String_246, null, new object[0]);
					}
					if (!flag2)
					{
						goto IL_143;
					}
					continue;
					IL_2A8:
					flag = false;
					string_ = "tnyto";
					flag2 = false;
					if (num3 > 0)
					{
						goto IL_11A;
					}
					IL_143:
					if (num2 > 0)
					{
						string_ = "tnq12";
						this.method_7(string_, num2, ref flag, ref flag2);
						if (flag)
						{
							Class83.smethod_66(frmMain.String_30, null, new object[0]);
						}
						if (flag2)
						{
							continue;
						}
					}
					if (num > 0)
					{
						string_ = "tnchedo";
						this.method_7(string_, num, ref flag, ref flag2);
						if (flag2)
						{
							continue;
						}
					}
					if (num4 > 0)
					{
						string_ = "tntrader";
						this.method_7(string_, num4, ref flag, ref flag2);
						if (flag2)
						{
							continue;
						}
					}
					if (frmLogin.class101_0.globalSettings_0.WasPro && frmLogin.class101_0.globalSettings_0.Account.RemainMSeconds <= 300000.0 && frmLogin.class101_0.globalSettings_0.Account.int_1 == 0)
					{
						List<Class39> list = new List<Class39>();
						list.Add(new Class39());
						if (frmLiteBuy.smethod_0(list) <= frmLogin.class101_0.globalSettings_0.Account.TotalBalance)
						{
							frmLogin.frmLiteBuy_0.method_11("time", list[0], "", false);
							if (frmLogin.class101_0.globalSettings_0.Account.RemainMSeconds > 300000.0)
							{
								frmLogin.class101_0.globalSettings_0.Account.int_1++;
								Class83.smethod_66("Tự gia hạn thêm 24 giờ chơi để tránh bị gián đoạn auto.", null, new object[0]);
							}
						}
					}
				}
				Thread.Sleep(30000);
			}
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0006C378 File Offset: 0x0006A578
		private void method_7(string string_0, int int_0, ref bool bool_0, ref bool bool_1)
		{
			int num = this.method_2(string_0);
			if (string_0 == "tntrader" && num == 0)
			{
				num = frmLogin.class101_0.globalSettings_0.TNFreeAcc;
			}
			int int_ = int_0 - num;
			int num2 = 0;
			bool flag = false;
			Class39 @class = null;
			bool_0 = false;
			bool flag2 = false;
			if (string_0 == "tnyto" && frmLogin.class101_0.globalSettings_0.cboxYTOGiaHan)
			{
				flag2 = true;
			}
			else if (string_0 == "tnq12" && frmLogin.class101_0.globalSettings_0.cboxQ12AutoExtend)
			{
				flag2 = true;
			}
			else if (string_0 == "tnchedo")
			{
				flag2 = true;
				flag = true;
			}
			else if (string_0 == "tntrader")
			{
				flag2 = false;
			}
			bool flag3 = false;
			if (frmLogin.class101_0.globalSettings_0.WasPro && frmLogin.class101_0.globalSettings_0.Account.int_1 == 0)
			{
				flag3 = true;
			}
			if (!flag3 && flag)
			{
				flag3 = true;
			}
			if (num == 0 && flag2 && flag3)
			{
				if (string_0 == "tnchedo")
				{
					if (frmLogin.class101_0.globalSettings_0.cboxCDExtend && frmLogin.class101_0.globalSettings_0.cboCDExtend != "")
					{
						@class = Class70.smethod_0(string_0, frmLogin.class101_0.globalSettings_0.cboCDExtend);
					}
				}
				else
				{
					@class = Class70.smethod_1(string_0);
				}
				if (@class != null && @class.double_0 <= frmLogin.class101_0.globalSettings_0.Account.TotalBalance)
				{
					frmLogin.frmLiteBuy_0.method_11(string_0, @class, "", false);
					num = this.method_2(string_0);
					int_ = int_0 - num;
					bool_1 = true;
				}
			}
			if (frmLogin.class101_0.globalSettings_0.AppMode == Class57.Enum8.const_0 && !flag)
			{
				int_ = 999;
			}
			Class70.smethod_2(string_0, int_, ref num2, ref bool_0);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0006C538 File Offset: 0x0006A738
		internal static Class39 smethod_0(string string_0, string string_1)
		{
			if (frmLogin.class101_0.globalSettings_0.Account.list_1.Count > 0)
			{
				for (int i = 0; i < frmLogin.class101_0.globalSettings_0.Account.list_1.Count; i++)
				{
					if (frmLogin.class101_0.globalSettings_0.Account.list_1[i].string_0 == string_0 && frmLogin.class101_0.globalSettings_0.Account.list_1[i].String_1 == string_1)
					{
						return frmLogin.class101_0.globalSettings_0.Account.list_1[i];
					}
				}
			}
			return null;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0006C5F4 File Offset: 0x0006A7F4
		internal static Class39 smethod_1(string string_0)
		{
			Class39 @class = null;
			if (frmLogin.frmLiteBuy_0.list_1.Count > 0)
			{
				try
				{
					for (int i = 0; i < frmLogin.frmLiteBuy_0.list_1.Count; i++)
					{
						if (frmLogin.frmLiteBuy_0.list_1[i].string_0 == string_0)
						{
							@class = frmLogin.frmLiteBuy_0.list_1[i];
							break;
						}
					}
				}
				catch (Exception)
				{
				}
			}
			if (@class == null && frmLogin.class101_0.globalSettings_0.Account.list_1.Count > 0)
			{
				double num = 9999.0;
				for (int j = 0; j < frmLogin.class101_0.globalSettings_0.Account.list_1.Count; j++)
				{
					if (frmLogin.class101_0.globalSettings_0.Account.list_1[j].string_0 == string_0 && frmLogin.class101_0.globalSettings_0.Account.list_1[j].double_0 < num)
					{
						@class = frmLogin.class101_0.globalSettings_0.Account.list_1[j];
						num = frmLogin.class101_0.globalSettings_0.Account.list_1[j].double_0;
					}
				}
			}
			return @class;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0006C754 File Offset: 0x0006A954
		private static void smethod_2(string string_0, int int_0, ref int int_1, ref bool bool_0)
		{
			try
			{
				if (int_0 > 0)
				{
					for (int i = frmLogin.class101_0.class210_0.Count - 1; i >= 0; i--)
					{
						bool flag = false;
						if (string_0 == "tnyto" && frmLogin.class101_0.class210_0[i].class114_0.bool_160)
						{
							flag = true;
						}
						else if (string_0 == "tnq12" && (frmLogin.class101_0.class210_0[i].class114_0.bool_155 || frmLogin.class101_0.class210_0[i].class114_0.bool_156))
						{
							flag = true;
						}
						else if (string_0 == "tntrader" && frmLogin.class101_0.class210_0[i].autoSettings_0.AIMode == Class57.AIModes.THUONGNHAN)
						{
							flag = true;
						}
						else if (string_0 == "tnchedo" && frmLogin.class101_0.class210_0[i].class114_0.bool_152)
						{
							flag = true;
						}
						if (flag)
						{
							if (string_0 == "tnyto")
							{
								frmLogin.class101_0.class210_0[i].class114_0.bool_160 = false;
							}
							else if (string_0 == "tnq12")
							{
								frmLogin.class101_0.class210_0[i].class114_0.bool_155 = false;
								frmLogin.class101_0.class210_0[i].class114_0.bool_156 = false;
							}
							else if (string_0 == "tnchedo")
							{
								frmLogin.class101_0.class210_0[i].class114_0.bool_152 = false;
							}
							else if (string_0 == "tntrader")
							{
								frmLogin.class101_0.class210_0[i].autoSettings_0.AIMode = Class57.AIModes.DANHQUANHDIEM;
							}
							if (!frmLogin.class101_0.class210_0[i].class75_0.bool_22)
							{
								bool_0 = true;
							}
							int_1++;
							if (int_1 >= int_0)
							{
								break;
							}
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x040001DC RID: 476
		[CompilerGenerated]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x040001DD RID: 477
		internal List<Class41> list_0 = new List<Class41>();

		// Token: 0x040001DE RID: 478
		private long long_0;

		// Token: 0x02000068 RID: 104
		[CompilerGenerated]
		private sealed class Class71
		{
			// Token: 0x0600038D RID: 909 RVA: 0x000041BE File Offset: 0x000023BE
			internal void method_0()
			{
				this.class70_0.propertyChangedEventHandler_0(this.class70_0, new PropertyChangedEventArgs(this.string_0));
			}

			// Token: 0x040001DF RID: 479
			public Class70 class70_0;

			// Token: 0x040001E0 RID: 480
			public string string_0;
		}
	}
}
