using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic;
using SmartBot;

namespace ns0
{
	// Token: 0x02000045 RID: 69
	internal sealed class Class55
	{
		// Token: 0x06000349 RID: 841 RVA: 0x00069F78 File Offset: 0x00068178
		internal static void smethod_0(Class58 class58_0)
		{
			Class55.Class56 @class = new Class55.Class56();
			@class.class58_0 = class58_0;
			if (@class.class58_0 != null)
			{
				new Thread(new ThreadStart(@class.method_0))
				{
					IsBackground = true
				}.Start();
			}
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00069FB8 File Offset: 0x000681B8
		internal static int smethod_1(PlayerListItem playerListItem_0, PlayerListItem playerListItem_1)
		{
			if (playerListItem_0.Name == playerListItem_1.Name)
			{
				return 0;
			}
			List<string> list = new List<string>();
			list.Add(playerListItem_0.Name);
			list.Add(playerListItem_1.Name);
			list.Sort();
			if (list[0] == playerListItem_0.Name)
			{
				return -1;
			}
			return 1;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0006A014 File Offset: 0x00068214
		internal static void smethod_2(List<Class58> list_0)
		{
			if (list_0 != null && list_0.Count > 0)
			{
				foreach (Class58 @class in list_0)
				{
					if (@class != null)
					{
						Class55.smethod_3(@class, false);
					}
				}
			}
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0006A074 File Offset: 0x00068274
		internal static void smethod_3(Class58 class58_0, bool bool_0 = false)
		{
			if (class58_0 != null)
			{
				if (!bool_0)
				{
					if ((!class58_0.class114_0.bool_20 && class58_0.class114_0.bool_130) || (class58_0.class114_0.bool_20 && class58_0.class114_0.bool_130))
					{
						class58_0.method_117(class58_0.class59_0.intptr_10, 0);
						class58_0.class114_0.bool_20 = true;
						return;
					}
					if (!class58_0.class114_0.bool_130 && class58_0.class114_0.bool_20)
					{
						class58_0.method_117(class58_0.class59_0.intptr_10, 1);
						class58_0.class114_0.bool_130 = true;
						return;
					}
					if (!class58_0.class114_0.bool_20 && !class58_0.class114_0.bool_130)
					{
						class58_0.method_117(class58_0.class59_0.intptr_10, 2);
						class58_0.class114_0.bool_20 = true;
						class58_0.class114_0.bool_130 = true;
					}
				}
				if (bool_0)
				{
					class58_0.method_117(class58_0.class59_0.intptr_10, 3);
				}
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0006A174 File Offset: 0x00068374
		internal static void smethod_4(List<Class58> list_0)
		{
			if (list_0 != null && list_0.Count > 0)
			{
				foreach (Class58 @class in list_0)
				{
					if (@class != null)
					{
						Class55.smethod_3(@class, false);
						@class.method_119(@class.class59_0.intptr_10, 21);
					}
				}
			}
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0006A1E8 File Offset: 0x000683E8
		internal static void smethod_5(List<Class58> list_0, int int_0 = 0)
		{
			if (list_0 != null && list_0.Count > 0)
			{
				foreach (Class58 @class in list_0)
				{
					if (@class != null)
					{
						Class55.smethod_14(@class, int_0);
					}
				}
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0006A248 File Offset: 0x00068448
		internal static void smethod_6(List<Class58> list_0)
		{
			if (list_0 != null && list_0.Count > 0)
			{
				foreach (Class58 @class in list_0)
				{
					if (@class != null)
					{
						@class.method_148();
						Class55.smethod_8(@class, true, false);
					}
				}
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0006A2B0 File Offset: 0x000684B0
		internal static bool smethod_7(int int_0)
		{
			bool result = false;
			if (frmLogin.class101_0.globalSettings_0.ProcessListIgnored.Count > 0)
			{
				try
				{
					for (int i = frmLogin.class101_0.globalSettings_0.ProcessListIgnored.Count - 1; i >= 0; i--)
					{
						if (frmLogin.class101_0.globalSettings_0.ProcessListIgnored[i].int_0 == int_0)
						{
							result = true;
							break;
						}
					}
				}
				catch (Exception)
				{
				}
			}
			return result;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0006A330 File Offset: 0x00068530
		internal static void smethod_8(Class58 class58_0, bool bool_0 = false, bool bool_1 = false)
		{
			class58_0.class59_0.bool_22 = bool_1;
			if (!bool_0)
			{
				if (class58_0 != null)
				{
					frmLogin.class101_0.list_15.Add(class58_0);
					frmLogin.class101_0.class210_0.method_0(class58_0);
					class58_0.class59_0.bool_21 = true;
					class58_0.IsAIEnabled = false;
					class58_0.class59_0.bool_18 = false;
					Class159.PostMessage(class58_0.class59_0.intptr_10, frmLogin.class101_0.globalSettings_0.WM_PSEUDOCODE, (IntPtr)0, (IntPtr)0);
					return;
				}
			}
			else
			{
				class58_0.class59_0.bool_8 = true;
				if (class58_0.class59_0.enum3_0 != Class57.Enum3.const_0 || bool_0)
				{
					if (bool_0)
					{
						class58_0.class59_0.enum3_0 = Class57.Enum3.const_0;
					}
					Class55.smethod_11(class58_0);
					if (bool_0)
					{
						Class55.smethod_10(class58_0);
						Class55.smethod_9(class58_0);
					}
					class58_0.class59_0.bool_13 = true;
					if (class58_0.class114_0 != null)
					{
						class58_0.class114_0.bool_0 = false;
					}
					if (bool_0)
					{
						class58_0.class59_0.bool_1 = false;
						try
						{
							if (class58_0.gclass2_0 != null)
							{
								class58_0.gclass2_0.bool_1 = false;
								class58_0.gclass2_0.bool_2 = false;
								class58_0.gclass2_0.bool_3 = false;
								class58_0.gclass2_0.GameStarted = false;
								class58_0.gclass2_0.bool_5 = false;
								class58_0.gclass2_0.RefAutoAccount = null;
							}
						}
						catch (Exception)
						{
						}
						frmLogin.class101_0.class210_0.method_0(class58_0);
					}
				}
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0006A4A8 File Offset: 0x000686A8
		private static void smethod_9(Class58 class58_0)
		{
			try
			{
				long elapsedMilliseconds = frmLogin.stopwatch_0.ElapsedMilliseconds;
				while (class58_0.thread_0 != null)
				{
					class58_0.class59_0.bool_16 = false;
					Thread.Sleep(20);
					if (class58_0.class75_0.bool_15)
					{
						break;
					}
					Thread.Sleep(10);
					if (frmLogin.stopwatch_0.ElapsedMilliseconds - elapsedMilliseconds >= 200L)
					{
						break;
					}
				}
				if (class58_0.thread_0 != null)
				{
					class58_0.thread_0.Abort();
					class58_0.thread_0 = null;
				}
			}
			catch (Exception ex)
			{
				Class83.smethod_66(frmMain.String_200 + ex.Message, class58_0, new object[0]);
			}
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0006A550 File Offset: 0x00068750
		private static void smethod_10(Class58 class58_0)
		{
			if (class58_0.class59_0.intptr_42 != IntPtr.Zero || class58_0.class59_0.intptr_43 != IntPtr.Zero)
			{
				long elapsedMilliseconds = frmLogin.stopwatch_0.ElapsedMilliseconds;
				int num = 0;
				while (class58_0.class59_0.bool_1)
				{
					class58_0.method_159(false);
					num++;
					Thread.Sleep(10);
					if (frmLogin.stopwatch_0.ElapsedMilliseconds - elapsedMilliseconds >= 500L || num >= 5)
					{
						break;
					}
				}
			}
			Class101.smethod_74(class58_0, 1000);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0006A5E0 File Offset: 0x000687E0
		private static void smethod_11(Class58 class58_0)
		{
			try
			{
				long elapsedMilliseconds = frmLogin.stopwatch_0.ElapsedMilliseconds;
				while (class58_0.thread_1 != null)
				{
					class58_0.autoSettings_0.AIWhileLoop = false;
					Thread.Sleep(20);
					if (class58_0.class75_0.bool_14)
					{
						break;
					}
					Thread.Sleep(10);
					if (frmLogin.stopwatch_0.ElapsedMilliseconds - elapsedMilliseconds >= 200L)
					{
						break;
					}
				}
				if (class58_0.thread_1 != null)
				{
					class58_0.thread_1.Abort();
					class58_0.thread_1 = null;
				}
			}
			catch (Exception ex)
			{
				Class83.smethod_66(frmMain.String_199 + ex.Message, class58_0, new object[0]);
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0006A688 File Offset: 0x00068888
		internal static void smethod_12(List<Class58> list_0)
		{
			if (list_0 != null && list_0.Count > 0)
			{
				foreach (Class58 @class in list_0)
				{
					if (@class != null)
					{
						if (!Class55.smethod_7(@class.class59_0.int_1))
						{
							frmLogin.class101_0.globalSettings_0.ProcessListIgnored.Add(new Class128
							{
								int_0 = @class.class59_0.int_1,
								int_1 = @class.class59_0.int_2
							});
						}
						Class55.smethod_8(@class, false, true);
					}
				}
				try
				{
					for (int i = frmLogin.class101_0.class210_0.Count - 1; i >= 0; i--)
					{
						if (Class55.smethod_7(frmLogin.class101_0.class210_0[i].class59_0.int_1))
						{
							frmLogin.class101_0.globalSettings_0.ProcessList.Remove(frmLogin.class101_0.class210_0[i].class59_0.int_1);
							frmLogin.class101_0.class210_0.RemoveAt(i);
						}
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0006A7C8 File Offset: 0x000689C8
		internal static void smethod_13(List<Class58> list_0)
		{
			if (list_0 != null && list_0.Count > 0)
			{
				foreach (Class58 @class in list_0)
				{
					if (@class != null)
					{
						@class.method_117(@class.class59_0.intptr_10, 98);
						@class.class114_0.bool_20 = true;
						@class.class114_0.bool_130 = true;
					}
				}
			}
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0006A84C File Offset: 0x00068A4C
		internal static void smethod_14(Class58 class58_0, int int_0 = 0)
		{
			if (class58_0 != null)
			{
				if (int_0 != 0)
				{
					if (int_0 != 10)
					{
						if (int_0 != 1 && int_0 != 20)
						{
							return;
						}
						if (class58_0.class114_0.bool_130)
						{
							class58_0.class114_0.long_90 = frmLogin.stopwatch_0.ElapsedMilliseconds;
							if (int_0 == 1)
							{
								class58_0.method_119(class58_0.class59_0.intptr_10, 1);
							}
							else
							{
								class58_0.method_119(class58_0.class59_0.intptr_10, 20);
							}
							class58_0.class114_0.bool_130 = false;
							class58_0.class114_0.long_91 = frmLogin.stopwatch_0.ElapsedMilliseconds;
							class58_0.class114_0.bool_151 = false;
							return;
						}
						if (int_0 == 20)
						{
							class58_0.method_119(class58_0.class59_0.intptr_10, 20);
							class58_0.class114_0.bool_130 = false;
							class58_0.class114_0.long_91 = frmLogin.stopwatch_0.ElapsedMilliseconds;
							class58_0.class114_0.bool_151 = false;
							return;
						}
						return;
					}
				}
				if (class58_0.class114_0.bool_20)
				{
					if (int_0 == 0)
					{
						class58_0.method_119(class58_0.class59_0.intptr_10, 0);
					}
					else
					{
						class58_0.method_119(class58_0.class59_0.intptr_10, 10);
					}
					class58_0.class114_0.bool_20 = false;
					return;
				}
			}
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0006A984 File Offset: 0x00068B84
		internal static void smethod_15(List<Class58> list_0)
		{
			if (list_0 != null && list_0.Count > 0)
			{
				string s = Interaction.InputBox(string.Concat(new string[]
				{
					"Nhập số nhóm ID (",
					frmMain.frmMain_0.numGroupID.Minimum.ToString("0"),
					" đến ",
					frmMain.frmMain_0.numGroupID.Maximum.ToString("0"),
					")"
				}), "Set nhóm ID", "1", -1, -1);
				int num = 1;
				int.TryParse(s, out num);
				if (num < frmMain.frmMain_0.numGroupID.Minimum)
				{
					num = (int)frmMain.frmMain_0.numGroupID.Minimum;
				}
				try
				{
					foreach (Class58 @class in list_0)
					{
						@class.autoSettings_0.numGroupID = num;
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00004080 File Offset: 0x00002280
		internal static void smethod_16(Class58 class58_0)
		{
			frmMain.frmMain_0.method_107(class58_0);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0006AAA8 File Offset: 0x00068CA8
		internal static void smethod_17(Class58 class58_0)
		{
			if (frmLogin.class101_0.class210_0.Count > 1)
			{
				int millisecondsTimeout = 4500;
				if (class58_0.class59_0.int_2 == 3 || class58_0.class59_0.int_2 == 4)
				{
					millisecondsTimeout = 300;
				}
				try
				{
					for (int i = frmLogin.class101_0.class210_0.Count - 1; i >= 0; i--)
					{
						Class58 @class = frmLogin.class101_0.class210_0[i];
						if (@class.class114_0.string_3 != class58_0.class114_0.string_3 && @class.autoSettings_0.numGroupID == class58_0.autoSettings_0.numGroupID && @class.class126_0.int_1 <= 0)
						{
							class58_0.method_151(@class.class114_0.string_3);
							Thread.Sleep(millisecondsTimeout);
						}
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0006AB90 File Offset: 0x00068D90
		internal static void smethod_18(Class58 class58_0)
		{
			if (class58_0.IsAIEnabled)
			{
				class58_0.IsAIEnabled = false;
				class58_0.class114_0.Status = Class57.Enum13.const_0;
				class58_0.class114_0.bool_5 = false;
				class58_0.class114_0.bool_4 = false;
				class58_0.class114_0.bool_12 = false;
				class58_0.class114_0.bool_154 = false;
				if (class58_0.autoSettings_0.AIMode == Class57.AIModes.THUONGNHAN)
				{
					class58_0.autoSettings_0.AIMode = Class57.AIModes.DANHTUDO;
				}
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0006AC04 File Offset: 0x00068E04
		internal static void smethod_19(Class58 class58_0)
		{
			if (!class58_0.IsAIEnabled)
			{
				class58_0.IsAIEnabled = true;
				class58_0.class114_0.Status = Class57.Enum13.const_0;
				class58_0.class114_0.enum13_1 = Class57.Enum13.const_0;
				class58_0.class114_0.bool_9 = false;
				class58_0.autoSettings_0.TraderMode = Class57.Enum15.const_4;
				class58_0.autoSettings_0.TraderStatus = Class57.Enum13.const_0;
				class58_0.class114_0.enum13_2 = Class57.Enum13.const_0;
				class58_0.class114_0.enum13_3 = Class57.Enum13.const_0;
				class58_0.class114_0.bool_14 = false;
				class58_0.class114_0.bool_5 = false;
				class58_0.class114_0.bool_4 = false;
				class58_0.class114_0.bool_12 = false;
				class58_0.class114_0.bool_154 = false;
				class58_0.class114_0.list_7 = new List<Class47>();
				class58_0.class90_0.class89_1 = null;
				class58_0.class90_0.int_1 = 0;
				class58_0.class90_0.bool_0 = false;
				class58_0.class90_0.int_0 = 0;
				class58_0.class114_0.bool_38 = false;
				if (class58_0.autoSettings_0.AIMode == Class57.AIModes.DANHQUANHDIEM || class58_0.autoSettings_0.AIMode == Class57.AIModes.DANHTUDO)
				{
					class58_0.class114_0.int_53 = class58_0.class114_0.int_25;
					class58_0.class114_0.dateTime_0 = DateTime.Now;
				}
				class58_0.class114_0.stopwatch_4.Reset();
				class58_0.class114_0.stopwatch_4.Start();
				class58_0.class114_0.bool_44 = false;
				class58_0.class114_0.int_91 = 0;
				class58_0.class114_0.int_92 = 0;
				class58_0.class114_0.float_11 = 0f;
				class58_0.class114_0.float_14 = 0f;
				class58_0.class114_0.int_29 = -1;
				class58_0.class114_0.Status = Class57.Enum13.const_0;
				class58_0.class114_0.bool_32 = false;
				if (class58_0.class114_0.int_39 <= 20)
				{
					class58_0.autoSettings_0.cboxTuNhatVatPham = false;
					class58_0.autoSettings_0.cboxTuUpLevel = true;
					frmLogin.class101_0.globalSettings_0.cboxNoKS = true;
					class58_0.autoSettings_0.cboxChoHoiSinh = true;
					class58_0.autoSettings_0.numChoHoiSinh = 5;
				}
				if (class58_0.class114_0.int_39 <= 14)
				{
					class58_0.autoSettings_0.cboxNMBuff = false;
				}
				if (class58_0.class114_0.int_39 <= 30 && class58_0.class59_0.int_2 == 2)
				{
					class58_0.autoSettings_0.cboxCaptchaReset = false;
					class58_0.autoSettings_0.cboxTNAlert = false;
					frmLogin.class101_0.globalSettings_0.cboxNoKS = true;
				}
			}
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0006AE78 File Offset: 0x00069078
		internal static void smethod_20(List<Class58> list_0, int int_0)
		{
			if (list_0 != null && list_0.Count > 0)
			{
				foreach (Class58 @class in list_0)
				{
					if (@class != null)
					{
						@class.class75_0.int_55 = int_0;
					}
				}
			}
		}

		// Token: 0x02000046 RID: 70
		[CompilerGenerated]
		private sealed class Class56
		{
			// Token: 0x0600035F RID: 863 RVA: 0x0000408D File Offset: 0x0000228D
			internal void method_0()
			{
				Class55.smethod_17(this.class58_0);
			}

			// Token: 0x0400012E RID: 302
			public Class58 class58_0;
		}
	}
}
