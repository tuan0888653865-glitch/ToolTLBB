using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Media;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using SmartBot;

namespace ns0
{
	// Token: 0x02000088 RID: 136
	internal sealed class Class101
	{
		// Token: 0x0600047B RID: 1147 RVA: 0x0007D4BC File Offset: 0x0007B6BC
		internal Class101()
		{
			this.class210_0.Event_0 += this.method_1;
			this.class210_0.Event_1 += this.method_0;
			this.thread_0 = new Thread(new ThreadStart(this.method_2));
			this.thread_0.IsBackground = true;
			this.thread_0.Start();
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x0000495C File Offset: 0x00002B5C
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x00004964 File Offset: 0x00002B64
		internal bool Boolean_0
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
			}
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0007D658 File Offset: 0x0007B858
		internal static void smethod_0(Class58 class58_1)
		{
			if (class58_1 != null)
			{
				for (long num = class58_1.class59_0.long_0 - class58_1.class59_0.long_1; num >= 1L; num = class58_1.class59_0.long_0 - class58_1.class59_0.long_1)
				{
					bool flag = class58_1.class59_0.long_1 >= class58_1.class59_0.long_0 && class58_1.class59_0.long_1 == 0L;
					num = class58_1.class59_0.long_0 - class58_1.class59_0.long_1;
					int num2 = (int)((class58_1.class59_0.long_1 + 1L) % (long)class58_1.class59_0.int_7);
					if (!flag && num >= 1L)
					{
						switch (class58_1.class59_0.class158_0[num2].int_0)
						{
						case 2000:
							Class101.smethod_49(class58_1, false);
							break;
						case 2001:
							Class101.smethod_51(class58_1, class58_1.class59_0.class158_0[num2].int_1);
							break;
						case 2003:
							Class101.smethod_48(class58_1, class58_1.class59_0.class158_0[num2]);
							break;
						case 2004:
							Class101.smethod_47(class58_1, class58_1.class59_0.class158_0[num2]);
							break;
						case 2005:
							Class101.smethod_43(class58_1, class58_1.class59_0.class158_0[num2]);
							break;
						case 2006:
							Class101.smethod_45(class58_1);
							break;
						case 2007:
							if (class58_1.class114_0 != null)
							{
								class58_1.class114_0.string_12 = "";
							}
							break;
						case 2008:
							if (class58_1.class114_0 != null)
							{
								class58_1.class114_0.string_8 = "";
							}
							break;
						case 2009:
							if (class58_1.class108_0 != null && class58_1.class108_0.list_4.Count > 0)
							{
								for (int i = class58_1.class108_0.list_4.Count - 1; i >= 0; i--)
								{
									if (class58_1.class108_0.list_4[i].int_1 == class58_1.class59_0.class158_0[num2].int_1)
									{
										Class101.smethod_24(class58_1, i);
										break;
									}
								}
							}
							break;
						case 2010:
							if (class58_1.class114_0 != null)
							{
								class58_1.class114_0.bool_126 = false;
								class58_1.class114_0.long_82 = 0L;
							}
							break;
						case 2011:
							Class101.smethod_44(class58_1, class58_1.class59_0.class158_0[num2]);
							break;
						case 2012:
							class58_1.class114_0.float_13 = 0f;
							class58_1.class114_0.float_16 = 0f;
							break;
						case 2014:
							try
							{
								if (class58_1.class59_0.bool_1 && Class159.UnhookWindowsHookEx(class58_1.class59_0.intptr_42))
								{
									class58_1.class59_0.bool_1 = false;
								}
								break;
							}
							catch (Exception ex)
							{
								string message = ex.Message;
								class58_1.class59_0.bool_1 = false;
								break;
							}
							goto IL_2D8;
						}
						class58_1.class59_0.long_1 += 1L;
					}
					IL_2D8:;
				}
			}
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0007D980 File Offset: 0x0007BB80
		internal static void smethod_1(Class58 class58_1)
		{
			if (class58_1 != null && class58_1.class114_0 != null)
			{
				for (long num = class58_1.class114_0.QuaiWriteIndex - class58_1.class114_0.long_64; num >= 1L; num = class58_1.class114_0.QuaiWriteIndex - class58_1.class114_0.long_64)
				{
					bool flag = class58_1.class114_0.long_64 >= class58_1.class114_0.QuaiWriteIndex && class58_1.class114_0.long_64 == 0L;
					num = class58_1.class114_0.QuaiWriteIndex - class58_1.class114_0.long_64;
					int num2 = (int)((class58_1.class114_0.long_64 + 1L) % (long)frmLogin.class101_0.globalSettings_0.RingQuaiSize);
					if (!flag && num >= 1L)
					{
						if (class58_1.class114_0 != null && class58_1.class114_0.MapID != -1)
						{
							Class158 @class = class58_1.class98_0[num2];
							if (@class.int_0 == 100)
							{
								Class101.smethod_58(class58_1, @class);
							}
						}
						class58_1.class114_0.long_64 += 1L;
					}
				}
			}
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0007DA94 File Offset: 0x0007BC94
		internal static void smethod_2(Class58 class58_1)
		{
			if (class58_1 != null && class58_1.class114_0 != null)
			{
				for (long num = class58_1.class114_0.NguoiWriteIndex - class58_1.class114_0.long_65; num >= 1L; num = class58_1.class114_0.NguoiWriteIndex - class58_1.class114_0.long_65)
				{
					bool flag = class58_1.class114_0.long_65 >= class58_1.class114_0.NguoiWriteIndex && class58_1.class114_0.long_65 == 0L;
					num = class58_1.class114_0.NguoiWriteIndex - class58_1.class114_0.long_65;
					int num2 = (int)((class58_1.class114_0.long_65 + 1L) % (long)frmLogin.class101_0.globalSettings_0.RingNguoiSize);
					if (!flag && num >= 1L)
					{
						Class158 @class = class58_1.class97_0[num2];
						if (@class.int_0 == 105)
						{
							Class101.smethod_57(class58_1, @class);
						}
						class58_1.class114_0.long_65 += 1L;
					}
				}
			}
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0007DB90 File Offset: 0x0007BD90
		internal static void smethod_3(Class58 class58_1)
		{
			if (class58_1 != null && class58_1.class114_0 != null)
			{
				for (long num = class58_1.class114_0.BocWriteIndex - class58_1.class114_0.long_66; num >= 1L; num = class58_1.class114_0.BocWriteIndex - class58_1.class114_0.long_66)
				{
					bool flag = class58_1.class114_0.long_66 >= class58_1.class114_0.BocWriteIndex && class58_1.class114_0.long_66 == 0L;
					num = class58_1.class114_0.BocWriteIndex - class58_1.class114_0.long_66;
					int num2 = (int)((class58_1.class114_0.long_66 + 1L) % (long)frmLogin.class101_0.globalSettings_0.RingBocSize);
					if (!flag && num >= 1L)
					{
						if (class58_1.class94_0[num2].int_0 == 103)
						{
							Class101.smethod_52(class58_1, class58_1.class94_0[num2]);
						}
						class58_1.class114_0.long_66 += 1L;
					}
				}
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0007DC94 File Offset: 0x0007BE94
		internal static void smethod_4(Class58 class58_1)
		{
			if (class58_1 != null && class58_1.class114_0 != null)
			{
				for (long num = class58_1.class114_0.MsgWriteIndex - class58_1.class114_0.long_67; num >= 1L; num = class58_1.class114_0.MsgWriteIndex - class58_1.class114_0.long_67)
				{
					bool flag = class58_1.class114_0.long_67 >= class58_1.class114_0.MsgWriteIndex && class58_1.class114_0.long_67 == 0L;
					num = class58_1.class114_0.MsgWriteIndex - class58_1.class114_0.long_67;
					int num2 = (int)((class58_1.class114_0.long_67 + 1L) % (long)frmLogin.class101_0.globalSettings_0.RingMsgSize);
					if (!flag && num >= 1L)
					{
						int num3 = class58_1.class96_0[num2].int_0;
						switch (num3)
						{
						case 101:
							goto IL_1C20;
						case 102:
							Class101.smethod_54(class58_1, class58_1.class96_0[num2]);
							break;
						case 103:
						case 105:
							break;
						case 104:
							Class101.smethod_50(class58_1, class58_1.class96_0[num2]);
							break;
						case 106:
							Class101.smethod_56(class58_1, class58_1.class96_0[num2]);
							break;
						default:
							switch (num3)
							{
							case 5000:
								Class101.smethod_5(class58_1, class58_1.class96_0[num2]);
								goto IL_1C8D;
							case 5001:
								if (class58_1.class114_0 == null)
								{
									goto IL_1C8D;
								}
								class58_1.class114_0.string_13 = class58_1.class114_0.string_1;
								class58_1.class114_0.string_1 = class58_1.class96_0[num2].string_0;
								class58_1.class114_0.string_2 = class58_1.class96_0[num2].string_2;
								if (class58_1.class114_0.bool_76)
								{
									if (class58_1.class114_0.string_1.Contains("#{SDHDRW_091109") && class58_1.class114_0.string_1.Contains("#{_INFOAIM"))
									{
										int int_ = 0;
										int int_2 = 0;
										int int_3 = -1;
										try
										{
											string text = Class83.smethod_83(class58_1.class114_0.string_1, "#{_INFOAIM", ", ", 1, 1);
											if (text == string.Empty)
											{
												text = Class83.smethod_83(class58_1.class114_0.string_1, "#{_INFOAIM", "}", 1, 1);
											}
											if (text.Contains(","))
											{
												string[] array = text.Split(new char[]
												{
													','
												});
												if (array.Length >= 3)
												{
													int.TryParse(array[0], out int_);
													int.TryParse(array[1], out int_2);
													int.TryParse(array[2], out int_3);
												}
											}
										}
										catch (Exception ex)
										{
											Class83.smethod_66(frmMain.String_483, class58_1, new object[0]);
											if (!class58_1.class59_0.bool_9)
											{
												Class83.smethod_66(frmMain.String_481 + ex.Message + " Stack: " + ex.StackTrace.ToString(), class58_1, new object[0]);
											}
											class58_1.class59_0.bool_9 = true;
										}
										finally
										{
											class58_1.class114_0.int_79 = int_3;
											class58_1.class114_0.int_65 = int_;
											class58_1.class114_0.int_75 = int_2;
											if ((class58_1.class114_0.MapID >= 139 && class58_1.class114_0.MapID <= 147) || class58_1.class114_0.MapID == 522 || class58_1.class114_0.MapID == 200)
											{
												class58_1.class114_0.int_79 = class58_1.class114_0.MapID;
												if (class58_1.class114_0.string_1.Contains("iệt Yê"))
												{
													class58_1.class114_0.int_65 = 65;
													class58_1.class114_0.int_75 = 124;
												}
												else if (class58_1.class114_0.string_1.Contains("ru Tiê"))
												{
													class58_1.class114_0.int_65 = 96;
													class58_1.class114_0.int_75 = 90;
												}
												else if (class58_1.class114_0.string_1.Contains("hí Thầ"))
												{
													class58_1.class114_0.int_65 = 140;
													class58_1.class114_0.int_75 = 58;
												}
												else if (class58_1.class114_0.string_1.Contains("ủ Thể"))
												{
													class58_1.class114_0.int_65 = 52;
													class58_1.class114_0.int_75 = 72;
												}
												else if (class58_1.class114_0.string_1.Contains("ực Tâ"))
												{
													class58_1.class114_0.int_65 = 120;
													class58_1.class114_0.int_75 = 140;
												}
												else if (class58_1.class114_0.string_1.Contains("óa Ph"))
												{
													class58_1.class114_0.int_65 = 146;
													class58_1.class114_0.int_75 = 158;
												}
												else if (class58_1.class114_0.string_1.Contains("êu Dị"))
												{
													class58_1.class114_0.int_65 = 86;
													class58_1.class114_0.int_75 = 170;
												}
												else if (class58_1.class114_0.string_1.Contains("há Sâ"))
												{
													class58_1.class114_0.int_65 = 76;
													class58_1.class114_0.int_75 = 130;
												}
												else if (class58_1.class114_0.string_1.Contains("át Dụ"))
												{
													class58_1.class114_0.int_65 = 46;
													class58_1.class114_0.int_75 = 58;
												}
												else if (class58_1.class114_0.string_1.Contains("ểu Tuy"))
												{
													class58_1.class114_0.int_65 = 94;
													class58_1.class114_0.int_75 = 100;
												}
												else if (class58_1.class114_0.string_1.Contains("n Đại"))
												{
													class58_1.class114_0.int_65 = 45;
													class58_1.class114_0.int_75 = 76;
												}
												else if (class58_1.class114_0.string_1.Contains("ái Vươ"))
												{
													class58_1.class114_0.int_65 = 96;
													class58_1.class114_0.int_75 = 50;
												}
												else if (class58_1.class114_0.string_1.Contains("ạch M"))
												{
													class58_1.class114_0.int_65 = 143;
													class58_1.class114_0.int_75 = 107;
												}
												else if (class58_1.class114_0.string_1.Contains("ợi Trả"))
												{
													class58_1.class114_0.int_65 = 94;
													class58_1.class114_0.int_75 = 65;
												}
												else if (class58_1.class114_0.string_1.Contains("ung Nh"))
												{
													class58_1.class114_0.int_65 = 54;
													class58_1.class114_0.int_75 = 140;
												}
												else if (class58_1.class114_0.string_1.Contains("ộc Vươ"))
												{
													class58_1.class114_0.int_65 = 130;
													class58_1.class114_0.int_75 = 149;
												}
												else if (class58_1.class114_0.string_1.Contains("hủy Vư"))
												{
													class58_1.class114_0.int_65 = 140;
													class58_1.class114_0.int_75 = 97;
												}
												else if (class58_1.class114_0.string_1.Contains("ỏa Vươ"))
												{
													class58_1.class114_0.int_65 = 96;
													class58_1.class114_0.int_75 = 91;
												}
												else if (class58_1.class114_0.string_1.Contains("ộc Vươ"))
												{
													class58_1.class114_0.int_65 = 130;
													class58_1.class114_0.int_75 = 149;
												}
												else if (class58_1.class114_0.string_1.Contains("hủy Vư"))
												{
													class58_1.class114_0.int_65 = 140;
													class58_1.class114_0.int_75 = 97;
												}
												else if (class58_1.class114_0.string_1.Contains("ỏa Vươ"))
												{
													class58_1.class114_0.int_65 = 96;
													class58_1.class114_0.int_75 = 91;
												}
												else if (class58_1.class114_0.string_1.Contains("âu La"))
												{
													class58_1.class114_0.int_65 = 126;
													class58_1.class114_0.int_75 = 106;
												}
												else if (class58_1.class114_0.string_1.Contains("ân Tinh An"))
												{
													class58_1.class114_0.int_65 = 69;
													class58_1.class114_0.int_75 = 68;
												}
												else if (class58_1.class114_0.string_1.Contains("ân võ s"))
												{
													class58_1.class114_0.int_65 = 40;
													class58_1.class114_0.int_75 = 98;
												}
												else if (class58_1.class114_0.string_1.Contains("hám Ti"))
												{
													class58_1.class114_0.int_65 = 96;
													class58_1.class114_0.int_75 = 110;
												}
												else if (class58_1.class114_0.string_1.Contains("hanh K"))
												{
													class58_1.class114_0.int_65 = 150;
													class58_1.class114_0.int_75 = 118;
												}
												else if (class58_1.class114_0.string_1.Contains("am Kỳ Th"))
												{
													class58_1.class114_0.int_65 = 95;
													class58_1.class114_0.int_75 = 76;
												}
											}
										}
									}
									if (class58_1.class114_0.int_108 != 1)
									{
										string text2 = Class83.smethod_137(class58_1.class114_0.string_1, 1);
										if (!class58_1.class114_0.string_1.Contains("Đã gặp:") && !text2.Contains("Ðã g£p:"))
										{
											if (!class58_1.class114_0.string_1.Contains("được Bát Kê") && !text2.Contains("ðßþc Bát Kê") && !class58_1.class114_0.string_1.Contains("SDHDRW_091109_44"))
											{
												if (!class58_1.class114_0.string_1.Contains("Đã thu thập") && !text2.Contains("Ðã thu th§p") && !class58_1.class114_0.string_1.Contains("SDHDRW_091109_41"))
												{
													if (!class58_1.class114_0.string_1.Contains("Đã tìm được") && !text2.Contains("Ðã tìm ðßþc"))
													{
														if (class58_1.class114_0.string_1.Contains("Thu thập bình") || text2.Contains("Thu th§p bình"))
														{
															class58_1.class114_0.int_58 = 5;
														}
													}
													else
													{
														class58_1.class114_0.int_58 = 4;
													}
												}
												else
												{
													class58_1.class114_0.int_58 = 3;
													if (!class58_1.class114_0.bool_49 && class58_1.class114_0.int_108 < 2)
													{
														class58_1.class114_0.int_108 = 2;
													}
												}
											}
											else
											{
												class58_1.class114_0.int_58 = 2;
											}
										}
										else
										{
											class58_1.class114_0.int_58 = 1;
										}
									}
								}
								else if (class58_1.class114_0.bool_69)
								{
									if (class58_1.class114_0.string_1.Contains("#{SMRW_") || class58_1.class114_0.string_1.Contains("#{yuenan") || class58_1.class114_0.string_1.Contains("ụ Sư Mô") || class58_1.class114_0.string_1.Contains("ã lâu không g"))
									{
										if (class58_1.class114_0.string_1.Contains("#{_INFOAIM"))
										{
											int int_4 = 0;
											int int_5 = 0;
											int int_6 = -1;
											try
											{
												string text3 = Class83.smethod_83(class58_1.class114_0.string_1, "#{_INFOAIM", "}", 1, 1);
												if (text3.Contains(","))
												{
													string[] array2 = text3.Split(new char[]
													{
														','
													});
													if (array2.Length >= 3)
													{
														int.TryParse(array2[0], out int_4);
														int.TryParse(array2[1], out int_5);
														int.TryParse(array2[2], out int_6);
													}
												}
											}
											catch (Exception ex2)
											{
												Class83.smethod_66(frmMain.String_480, class58_1, new object[0]);
												if (!class58_1.class59_0.bool_9)
												{
													Class83.smethod_66(frmMain.String_479 + ex2.Message + " Stack: " + ex2.StackTrace.ToString(), class58_1, new object[0]);
												}
												class58_1.class59_0.bool_9 = true;
											}
											finally
											{
												if (!class58_1.class114_0.string_1.Contains("SMFB_120214_") && !class58_1.class114_0.string_1.Contains("TMSM_130808_"))
												{
													class58_1.class114_0.int_79 = int_6;
													if (class58_1.class114_0.int_79 == 112)
													{
														class58_1.class114_0.int_79 = 39;
													}
													else if (class58_1.class114_0.int_79 == 201)
													{
														class58_1.class114_0.int_79 = 158;
													}
													else if (class58_1.class114_0.int_79 == 615)
													{
														class58_1.class114_0.int_79 = 521;
													}
													else if (class58_1.class114_0.int_79 == 284)
													{
														class58_1.class114_0.int_79 = 195;
													}
													class58_1.class114_0.int_65 = int_4;
													class58_1.class114_0.int_75 = int_5;
												}
											}
										}
										if (class58_1.class114_0.string_1.Contains("ủa ta sao khôn"))
										{
											class58_1.class114_0.int_58 = 1;
										}
										else if (class58_1.class114_0.string_1.Contains("a bắt 1"))
										{
											class58_1.class114_0.int_58 = 2;
											class58_1.class114_0.string_6 = Class83.smethod_83(class58_1.class114_0.string_1, "#G#R", "#W(", 1, 1);
											class58_1.class114_0.string_6 = class58_1.class114_0.string_6.Trim();
										}
										else if (class58_1.class114_0.string_1.Contains("{yuenan"))
										{
											class58_1.class114_0.int_58 = 3;
											if (class58_1.class114_0.int_65 == 99 && class58_1.class114_0.int_75 == 45)
											{
												class58_1.class114_0.int_65 = 101;
											}
										}
										else if (class58_1.class114_0.string_1.Contains("âu không gặ"))
										{
											class58_1.class114_0.int_58 = 4;
											class58_1.class114_0.string_6 = Class83.smethod_83(class58_1.class114_0.string_1, "#R", "#W", 2, 1);
											class58_1.class114_0.string_6 = class58_1.class114_0.string_6.Trim();
											if (class58_1.class114_0.int_65 == 209 && class58_1.class114_0.int_75 == 180 && class58_1.class114_0.int_79 == 1)
											{
												class58_1.class114_0.int_75 = 179;
											}
										}
										else if (!class58_1.class114_0.string_1.Contains("hấp phả") && !class58_1.class114_0.string_1.Contains("dùng #Y"))
										{
											if (!class58_1.class114_0.string_1.Contains("hỏ góc trê") && !class58_1.class114_0.string_1.Contains("ản đồ nhỏ"))
											{
												if (class58_1.class114_0.string_1.Contains("SMFB_120214_") || class58_1.class114_0.string_1.Contains("TMSM_130808_"))
												{
													class58_1.class114_0.int_58 = 7;
												}
											}
											else
											{
												class58_1.class114_0.int_58 = 6;
												class58_1.class114_0.string_6 = Class83.smethod_83(class58_1.class114_0.string_1, "#G", "#W", 1, 1);
												class58_1.class114_0.string_6 = class58_1.class114_0.string_6.Trim();
											}
										}
										else
										{
											class58_1.class114_0.int_58 = 5;
											class58_1.class114_0.string_6 = Class83.smethod_83(class58_1.class114_0.string_1, "dùng #Y", "#W", 1, 1);
											class58_1.class114_0.string_6 = class58_1.class114_0.string_6.Trim();
											if (class58_1.class114_0.string_6 == string.Empty)
											{
												class58_1.class114_0.string_6 = Class83.smethod_83(class58_1.class114_0.string_1, "#Y", "#W", 1, 1);
												class58_1.class114_0.string_6 = class58_1.class114_0.string_6.Trim();
											}
											if (class58_1.class114_0.string_1.Contains("gười đồn"))
											{
												class58_1.class114_0.int_65 = 85;
												class58_1.class114_0.int_75 = 85;
											}
											else if (class58_1.class114_0.string_1.ToLower().Contains("ơng minh v"))
											{
												class58_1.class114_0.int_65 = 103;
												class58_1.class114_0.int_75 = 82;
											}
											else if (class58_1.class114_0.string_1.ToLower().Contains("ái âm ph"))
											{
												class58_1.class114_0.int_65 = 62;
												class58_1.class114_0.int_75 = 92;
											}
											else if (class58_1.class114_0.string_1.ToLower().Contains("ái âm t"))
											{
												class58_1.class114_0.int_65 = 127;
												class58_1.class114_0.int_75 = 92;
											}
											else if (class58_1.class114_0.string_1.Contains("ết Độ"))
											{
												class58_1.class114_0.int_65 = 87;
												class58_1.class114_0.int_75 = 98;
											}
											else if (class58_1.class114_0.string_1.Contains("ện Độ"))
											{
												class58_1.class114_0.int_65 = 105;
												class58_1.class114_0.int_75 = 98;
											}
											else if (class58_1.class114_0.string_1.Contains("ạp Độ"))
											{
												class58_1.class114_0.int_65 = 127;
												class58_1.class114_0.int_75 = 72;
											}
											else if (class58_1.class114_0.string_1.Contains("óc Độ"))
											{
												class58_1.class114_0.int_65 = 95;
												class58_1.class114_0.int_75 = 56;
											}
											else if (class58_1.class114_0.string_1.Contains("hanh Họa"))
											{
												class58_1.class114_0.int_65 = 144;
												class58_1.class114_0.int_75 = 57;
											}
											else if (class58_1.class114_0.string_1.ToLower().Contains("ạn kha k"))
											{
												class58_1.class114_0.int_65 = 150;
												class58_1.class114_0.int_75 = 149;
											}
											else if (class58_1.class114_0.string_1.ToLower().Contains("ánh hiề"))
											{
												class58_1.class114_0.int_65 = 55;
												class58_1.class114_0.int_75 = 64;
											}
											else if (class58_1.class114_0.string_1.ToLower().Contains("ng hoàng c"))
											{
												class58_1.class114_0.int_65 = 51;
												class58_1.class114_0.int_75 = 149;
											}
											else if (class58_1.class114_0.string_1.Contains("oái Bă"))
											{
												class58_1.class114_0.int_65 = 123;
												class58_1.class114_0.int_75 = 90;
											}
											else if (class58_1.class114_0.string_1.Contains("ham Băn"))
											{
												class58_1.class114_0.int_65 = 128;
												class58_1.class114_0.int_75 = 50;
											}
											else if (class58_1.class114_0.string_1.Contains("yền Bă"))
											{
												class58_1.class114_0.int_65 = 61;
												class58_1.class114_0.int_75 = 38;
											}
											else if (class58_1.class114_0.string_1.Contains("àn Băn"))
											{
												class58_1.class114_0.int_65 = 74;
												class58_1.class114_0.int_75 = 63;
											}
											else if (class58_1.class114_0.string_1.ToLower().Contains("ơn môn"))
											{
												class58_1.class114_0.int_65 = 96;
												class58_1.class114_0.int_75 = 121;
											}
											else if (class58_1.class114_0.string_1.ToLower().Contains("ại hùn"))
											{
												class58_1.class114_0.int_65 = 95;
												class58_1.class114_0.int_75 = 83;
											}
											else if (class58_1.class114_0.string_1.ToLower().Contains("hung lâ"))
											{
												class58_1.class114_0.int_65 = 70;
												class58_1.class114_0.int_75 = 66;
											}
											else if (class58_1.class114_0.string_1.ToLower().Contains("àng kinh c"))
											{
												class58_1.class114_0.int_65 = 134;
												class58_1.class114_0.int_75 = 135;
											}
											else if (class58_1.class114_0.string_1.ToLower().Contains("ồi long đ"))
											{
												class58_1.class114_0.int_65 = 77;
												class58_1.class114_0.int_75 = 130;
											}
											else if (class58_1.class114_0.string_1.ToLower().Contains("iên giớ"))
											{
												class58_1.class114_0.int_65 = 45;
												class58_1.class114_0.int_75 = 84;
											}
											else if (class58_1.class114_0.string_1.ToLower().Contains("kim điệ"))
											{
												class58_1.class114_0.int_65 = 74;
												class58_1.class114_0.int_75 = 58;
											}
											else if (class58_1.class114_0.string_1.ToLower().Contains("ải kiếm t"))
											{
												class58_1.class114_0.int_65 = 46;
												class58_1.class114_0.int_75 = 171;
											}
											else if (class58_1.class114_0.string_1.ToLower().Contains("ạch kim k"))
											{
												class58_1.class114_0.int_65 = 49;
												class58_1.class114_0.int_75 = 152;
											}
											else if (class58_1.class114_0.string_1.ToLower().Contains("nh mộc k"))
											{
												class58_1.class114_0.int_65 = 138;
												class58_1.class114_0.int_75 = 146;
											}
											else if (class58_1.class114_0.string_1.ToLower().Contains("ắc thủy"))
											{
												class58_1.class114_0.int_65 = 137;
												class58_1.class114_0.int_75 = 35;
											}
											else if (class58_1.class114_0.string_1.ToLower().Contains("àng thổ "))
											{
												class58_1.class114_0.int_65 = 54;
												class58_1.class114_0.int_75 = 36;
											}
											else if (class58_1.class114_0.string_1.ToLower().Contains("ờng sinh đi"))
											{
												class58_1.class114_0.int_65 = 150;
												class58_1.class114_0.int_75 = 152;
											}
											else if (class58_1.class114_0.string_1.ToLower().Contains("ạch thủ"))
											{
												class58_1.class114_0.int_65 = 142;
												class58_1.class114_0.int_75 = 52;
											}
											else if (class58_1.class114_0.string_1.ToLower().Contains("uân hiể"))
											{
												class58_1.class114_0.int_65 = 43;
												class58_1.class114_0.int_75 = 43;
											}
											else if (class58_1.class114_0.string_1.ToLower().Contains("ư ngữ đ"))
											{
												class58_1.class114_0.int_65 = 39;
												class58_1.class114_0.int_75 = 147;
											}
											else if (class58_1.class114_0.string_1.ToLower().Contains("ễn binh đà"))
											{
												class58_1.class114_0.int_65 = 44;
												class58_1.class114_0.int_75 = 36;
											}
											else if (class58_1.class114_0.string_1.ToLower().Contains("ỗ khang từ"))
											{
												class58_1.class114_0.int_65 = 128;
												class58_1.class114_0.int_75 = 111;
											}
											else if (class58_1.class114_0.string_1.ToLower().Contains("ương phò"))
											{
												class58_1.class114_0.int_65 = 56;
												class58_1.class114_0.int_75 = 89;
											}
											else if (class58_1.class114_0.string_1.ToLower().Contains("đào viê"))
											{
												class58_1.class114_0.int_65 = 42;
												class58_1.class114_0.int_75 = 146;
											}
										}
									}
								}
								else if (class58_1.class114_0.bool_71)
								{
									if (class58_1.class114_0.string_1.Contains("SQXY_09061_11"))
									{
										class58_1.class114_0.string_12 = "CNVCNR";
									}
								}
								else if (class58_1.class114_0.bool_195 && (class58_1.class114_0.string_1.Contains("MZPVE_150812_64}") || class58_1.class114_0.string_1.Contains("MZPVE_150812_1562}") || class58_1.class114_0.string_1.Contains("MZPVE_150812_816}") || class58_1.class114_0.string_1.Contains("MZPVE_150812_1188}") || class58_1.class114_0.string_1.Contains("MZPVE_150812_1935}")))
								{
									class58_1.class114_0.string_8 = "VCTB";
								}
								if (Class83.smethod_119() && class58_1.autoSettings_0.cboxDebugLog && class58_1.class114_0.string_13 != class58_1.class114_0.string_1)
								{
									Class83.smethod_66("QuestInfo: " + class58_1.class114_0.string_1, class58_1, new object[0]);
									goto IL_1C8D;
								}
								goto IL_1C8D;
							case 5002:
								if (class58_1.class114_0 != null)
								{
									class58_1.class114_0.bool_132 = class58_1.class96_0[num2].bool_0;
									goto IL_1C8D;
								}
								goto IL_1C8D;
							case 5003:
								if (class58_1.class59_0.int_2 != class58_1.class96_0[num2].int_2 || class58_1.class59_0.int_2 == 0)
								{
									goto IL_1C8D;
								}
								class58_1.class59_0.int_11 = class58_1.class96_0[num2].int_1;
								if (class58_1.class96_0[num2].int_3 == -1)
								{
									goto IL_1C8D;
								}
								try
								{
									class58_1.class59_0.int_14 = class58_1.class96_0[num2].int_3;
									goto IL_1C8D;
								}
								catch (Exception)
								{
									goto IL_1C8D;
								}
								break;
							case 5004:
								break;
							case 5005:
								frmLogin.int_0 = class58_1.class96_0[num2].int_1;
								goto IL_1C8D;
							case 5006:
								class58_1.class75_0.int_17 = class58_1.class96_0[num2].int_1;
								class58_1.class75_0.int_19 = class58_1.class96_0[num2].int_2;
								class58_1.class75_0.int_18 = class58_1.class96_0[num2].int_3;
								goto IL_1C8D;
							case 5007:
								class58_1.class75_0.bool_16 = true;
								class58_1.method_118();
								goto IL_1C8D;
							case 5008:
								class58_1.method_118();
								goto IL_1C8D;
							case 5009:
								try
								{
									class58_1.class59_0.long_9 = frmLogin.stopwatch_0.ElapsedMilliseconds;
									goto IL_1C8D;
								}
								catch (Exception)
								{
									goto IL_1C8D;
								}
								goto IL_1BC6;
							case 5010:
								goto IL_1BC6;
							case 5011:
								goto IL_1BE7;
							case 5012:
								goto IL_1C00;
							default:
								goto IL_1C8D;
							}
							if (class58_1.class114_0 == null)
							{
								break;
							}
							if (class58_1.class96_0[num2].string_0 != "")
							{
								class58_1.class114_0.string_14 = class58_1.class96_0[num2].string_0;
								class58_1.class75_0.bool_10 = true;
								break;
							}
							class58_1.class75_0.bool_10 = false;
							class58_1.class114_0.string_14 = "";
							break;
							IL_1BC6:
							try
							{
								class58_1.class59_0.long_10 = frmLogin.stopwatch_0.ElapsedMilliseconds;
								break;
							}
							catch (Exception)
							{
								break;
							}
							IL_1BE7:
							try
							{
								class58_1.class114_0.long_4 = 0L;
								break;
							}
							catch (Exception)
							{
								break;
							}
							IL_1C00:
							try
							{
								if (class58_1.class114_0 != null)
								{
									string text4 = class58_1.class96_0[num2].string_0;
								}
								break;
							}
							catch (Exception)
							{
								break;
							}
							goto IL_1C20;
						}
						IL_1C8D:
						class58_1.class114_0.long_67 += 1L;
						goto IL_1C70;
						IL_1C20:
						Class101.smethod_55(class58_1, class58_1.class96_0[num2]);
						goto IL_1C8D;
					}
					IL_1C70:;
				}
			}
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0007FA20 File Offset: 0x0007DC20
		internal static void smethod_5(Class58 class58_1, Class158 class158_0)
		{
			if (class58_1.class114_0 != null)
			{
				string text = class158_0.string_0;
				string text2 = Class83.smethod_137(text, 1);
				text.Contains("Combat_Miss");
				if (Class83.smethod_119() && class58_1.autoSettings_0.cboxDebugLog && !text.Contains("Combat_Miss"))
				{
					text = text.Replace("{", "{{");
					text = text.Replace("}", "}}");
					Class83.smethod_66("ErrorString: " + text, class58_1, new object[0]);
				}
				if (((text.Contains("roduce_login_I") && text.Contains("fo_Connecting_Serv")) || (text.Contains("roduce_login_I") && text.Contains("o_Checking_Passw")) || (text.Contains("CRetLoginHand") && text.Contains("nfo_SafeSig"))) && class58_1.class75_0.Boolean_0)
				{
					class58_1.class75_0.Boolean_0 = false;
					object obj = class58_1.class75_0.object_1;
					lock (obj)
					{
						class58_1.class75_0.bool_29 = false;
					}
					Class101.Class102 @class = new Class101.Class102();
					@class.int_0 = frmLogin.class101_0.class210_0.Count - 1;
					while (@class.int_0 >= 0)
					{
						if (frmLogin.class101_0.class210_0[@class.int_0].class59_0.int_1 == class58_1.class59_0.int_1)
						{
							if (class58_1.class59_0.int_12 == 0)
							{
								class58_1.class59_0.int_12 = 4;
								new Thread(new ThreadStart(@class.method_0)).Start();
								break;
							}
							break;
						}
						else
						{
							int num = @class.int_0;
							@class.int_0 = num - 1;
						}
					}
				}
				if (!class58_1.class75_0.Boolean_0 && class58_1.class75_0.bool_12)
				{
					if (class58_1.class75_0.int_15 == 0 && text.Contains("Tip_PVP_Moral"))
					{
						class58_1.class75_0.int_15 = 1;
					}
					if ((text.Contains("Tip_PVP_FreeForTeam") || text.Contains("Tip_PVP_Peace") || text.Contains("Action_Pet_Relex")) && class58_1.class75_0.int_15 < 2)
					{
						class58_1.class75_0.int_15 = 2;
						class58_1.class75_0.long_22 = frmLogin.stopwatch_0.ElapsedMilliseconds + 4500L;
					}
					if ((class58_1.class75_0.int_15 == 3 && text.Contains("netManager_Info_Connect_OverTime")) || (class58_1.class59_0.int_2 == 4 && text.Contains("produce_char_sel_Info_Readying_To_Ent")))
					{
						class58_1.class75_0.int_15 = 4;
					}
				}
				if (text.Contains("#{ResultText_167}"))
				{
					class58_1.class114_0.string_8 = "CLXN";
				}
				else if (!text.Contains("netManager_Info_Server_Not_Work") || class58_1.class75_0.bool_13)
				{
					if (!text.Contains("át khỏi độ") && !text2.Contains("át khöi ðµ") && !text.Contains("ped followi"))
					{
						if (!text.Contains("am gia đội n") && !text2.Contains("am gia ðµi n") && !text.Contains("ed the request to fo"))
						{
							if (!text.Contains("ăng này khôn") && !text2.Contains("ång này khôn"))
							{
								if (!text.Contains("#{ResultText_130}"))
								{
									if (text.Contains("#{ResultText_8}"))
									{
										class58_1.method_104(-1);
										class58_1.class118_0.int_2 = -1;
									}
									else if (!text.Contains("#{ResultText_129}"))
									{
										if (text.Contains("ân khí khô"))
										{
											class58_1.class114_0.bool_124 = true;
											class58_1.class114_0.long_81 = frmLogin.stopwatch_0.ElapsedMilliseconds;
										}
										else if (!text.Contains("#{ResultText_45}"))
										{
											if (!text.Contains("UI_NOTICE_BEATTACKED_ENEMYNAME") && !text.Contains("ừ đâu cô"))
											{
												if (!text.Contains("GCDetailExp_Human_NormalAndAdditionalExp") && !text.Contains("GCDetailExp_Human_NormalExp"))
												{
													if (text.Contains("GCPickResultHandler_Info_package_Full"))
													{
														class58_1.class114_0.bool_22 = true;
														class58_1.class114_0.long_74 = frmLogin.stopwatch_0.ElapsedMilliseconds;
													}
													else if (text.Contains("Sử dụng nhân đôi kinh nghiệm trong"))
													{
														if (class58_1.class114_0 != null)
														{
															class58_1.class114_0.long_83 = frmLogin.stopwatch_0.ElapsedMilliseconds;
														}
													}
													else if (text.Contains("#c00FFFF#e010101#{APALJ_110303_8}"))
													{
														if (class58_1.class114_0 != null)
														{
															class58_1.class114_0.long_84 = frmLogin.stopwatch_0.ElapsedMilliseconds;
														}
													}
													else if (!text.Contains("ó đạo cụ đ") && !text2.Contains("ó ðÕo cø ð"))
													{
														if (!text.Contains("ương thực thí") && !text.Contains("pt_Pet_NoFe"))
														{
															if (text.Contains("ông thể t") && text.Contains("iêu nà"))
															{
																if (class58_1.class118_0 != null && class58_1.class118_0.int_2 != -1 && class58_1.class118_0.list_1.Count > 0)
																{
																	class58_1.class118_0.int_4 = 1;
																	class58_1.method_104(-1);
																	for (int i = class58_1.class118_0.list_1.Count - 1; i >= 0; i--)
																	{
																		Class119 class2 = class58_1.class118_0.list_1[i];
																		if (class2.int_0 == class58_1.class118_0.int_2 && !class58_1.class114_0.bool_32 && class58_1.class118_0.list_1[i].byte_0 != 11)
																		{
																			class2.byte_0 = 1;
																			IL_5D8:
																			class58_1.class118_0.list_4.Add(class58_1.class118_0.int_2);
																			goto IL_A56;
																		}
																	}
																	goto IL_5D8;
																}
																goto IL_A56;
															}
															else
															{
																if (text.Contains("GMDP_Struct_Skill_Info_Peace_Mode_Warning"))
																{
																	goto IL_A56;
																}
																if (!text.Contains("010101Các hạ đang tự tìm đườ") && !text.Contains("010101Các hÕ đang tự t́m đườ") && !text2.Contains("010101Các hÕ ðang tñ tìm ðß¶"))
																{
																	if (text.Contains("ILFER_LOC"))
																	{
																		class58_1.class114_0.long_58 = frmLogin.stopwatch_0.ElapsedMilliseconds;
																		goto IL_A56;
																	}
																	if (!text.Contains("ở khóa thấ") && !text2.Contains("· khóa th¤"))
																	{
																		if (text.Contains("{ResultText_71}"))
																		{
																			if (class58_1.class114_0.long_59 == 0L)
																			{
																				class58_1.class114_0.long_59 = frmLogin.stopwatch_0.ElapsedMilliseconds;
																				goto IL_A56;
																			}
																			if (frmLogin.stopwatch_0.ElapsedMilliseconds - class58_1.class114_0.long_59 >= 60000L)
																			{
																				class58_1.class114_0.int_89 = 0;
																				class58_1.class114_0.long_59 = 0L;
																				goto IL_A56;
																			}
																			if (frmLogin.stopwatch_0.ElapsedMilliseconds - class58_1.class114_0.long_59 < 5000L)
																			{
																				goto IL_A56;
																			}
																			class58_1.class114_0.int_89++;
																			if (class58_1.class114_0.int_89 >= 5)
																			{
																				class58_1.class114_0.int_89 = 0;
																				class58_1.class114_0.long_59 = 0L;
																				class58_1.autoSettings_0.cboItemTuHuy = false;
																				class58_1.autoSettings_0.cboxVutDoKhiFull = false;
																				Class83.smethod_66("Chức năng hủy vật phẩm cần nhập pass 2. Auto tạm tắt chức năng này nếu bạn cần dùng thì nhập pass 2 và bật lại sau nhé.", class58_1, new object[0]);
																				goto IL_A56;
																			}
																			goto IL_A56;
																		}
																		else
																		{
																			if (text.Contains("{ResultText_75}"))
																			{
																				class58_1.autoSettings_0.DungNgua = false;
																				goto IL_A56;
																			}
																			if (text.Contains("{ResultText_12}"))
																			{
																				class58_1.method_235(1);
																				goto IL_A56;
																			}
																			goto IL_A56;
																		}
																	}
																	else
																	{
																		class58_1.class114_0.int_90++;
																		if (class58_1.class114_0.int_89 >= 2)
																		{
																			class58_1.class114_0.int_90 = 0;
																			class58_1.autoSettings_0.cboxPassCap2 = false;
																			Class83.smethod_66("Pass 2 bạn nhập sai. Vui lòng nhập pass khác rồi bật lại chức năng để thử lại.", class58_1, new object[0]);
																			goto IL_A56;
																		}
																		goto IL_A56;
																	}
																}
																else
																{
																	object obj = class58_1.class114_0.object_0;
																	lock (obj)
																	{
																		class58_1.class75_0.long_30 = frmLogin.stopwatch_0.ElapsedMilliseconds;
																		goto IL_A56;
																	}
																}
															}
														}
														if (!class58_1.class114_0.bool_21)
														{
															class58_1.class114_0.bool_21 = true;
															class58_1.class114_0.long_71 = frmLogin.stopwatch_0.ElapsedMilliseconds;
														}
													}
													else
													{
														class58_1.class116_0.bool_2 = true;
														class58_1.class116_0.long_0 = frmLogin.stopwatch_0.ElapsedMilliseconds;
													}
												}
												else
												{
													class58_1.class114_0.long_85 = frmLogin.stopwatch_0.ElapsedMilliseconds;
												}
											}
											else if (!class58_1.class114_0.bool_24)
											{
												class58_1.class114_0.bool_24 = true;
												class58_1.class114_0.long_75 = frmLogin.stopwatch_0.ElapsedMilliseconds;
												class58_1.class114_0.long_76 = frmLogin.stopwatch_0.ElapsedMilliseconds;
												class58_1.class114_0.int_23 = 1;
												class58_1.class114_0.int_24 = 1;
											}
										}
									}
								}
							}
							else
							{
								class58_1.class118_0.float_0 = 0f;
								class58_1.class118_0.int_2 = -1;
							}
						}
						else
						{
							string text3 = Class83.smethod_83(text, "#e010101", " ", 1, 1);
							if (!string.IsNullOrEmpty(text3) && class58_1.method_338() && class58_1.class126_0.list_0.Count > 0)
							{
								for (int j = class58_1.class126_0.list_0.Count - 1; j >= 1; j--)
								{
									Class127 class3 = class58_1.class126_0.list_0[j];
									if (class3.string_0 == text3)
									{
										class3.bool_0 = true;
										break;
									}
								}
							}
						}
					}
					else
					{
						string text4 = Class83.smethod_83(text, "#e010101", " ", 1, 1);
						if (!string.IsNullOrEmpty(text4) && class58_1.method_338() && class58_1.class126_0.list_0.Count > 0)
						{
							for (int k = class58_1.class126_0.list_0.Count - 1; k >= 1; k--)
							{
								Class127 class4 = class58_1.class126_0.list_0[k];
								if (class4.string_0 == text4)
								{
									class4.bool_0 = false;
									break;
								}
							}
						}
					}
				}
				IL_A56:
				if (class58_1.class114_0.bool_66)
				{
					if (!text.Contains("ường nh") && !text2.Contains("ß¶ng nh"))
					{
						if (!text.Contains("ng Cho Ng") && !text.Contains("oàn thà") && !text.Contains("ược nhặ") && !text2.Contains("ßþc nh£") && !text.Contains("{BHJS_"))
						{
							if (text.Contains(": 10/10"))
							{
								class58_1.class114_0.string_8 = "XDCTF";
							}
						}
						else
						{
							class58_1.class114_0.string_8 = "XDXQ";
						}
					}
					else
					{
						class58_1.class114_0.string_8 = "XDTT";
					}
				}
				else if (class58_1.class114_0.bool_47)
				{
					if (class58_1.class114_0.MapID == 1)
					{
						if (text.Contains("ận được#{") || text.Contains("ou received") || text.Contains("ận đưềc #{") || text2.Contains("§n ðßþc#{"))
						{
							class58_1.class114_0.string_8 = "TAXQ";
						}
					}
					else if (text.Contains("ã đánh bại ác") || text.Contains("illed villain") || text.Contains("ă đánh bÕi á") || text2.Contains("ã ðánh bÕi ác"))
					{
						class58_1.class114_0.string_8 = "DCTAB";
					}
				}
				else if (class58_1.class114_0.bool_67)
				{
					if (class58_1.class114_0.int_108 == 1)
					{
						if (!text.Contains("SXPY_130826_27") && !text.Contains("SXPY_130826_533") && !text.Contains("SXPY_130826_535") && !text.Contains("SXPY_130826_537") && !text.Contains("SXPY_130826_539") && !text.Contains("SXPY_130826_25") && !text.Contains("SXPY_130826_73") && !text.Contains("SXPY_130826_105") && !text.Contains("SXPY_130826_141") && !text.Contains("SXPY_130826_185"))
						{
							if (text.Contains("101#{SXPY_130826_"))
							{
								class58_1.class114_0.string_8 = "QCNNV";
							}
						}
						else
						{
							class58_1.class114_0.string_8 = "QCMR";
						}
					}
					else if (!text.Contains("SXPY_130826_69") && !text.Contains("SXPY_130826_102") && !text.Contains("SXPY_130826_138") && !text.Contains("SXPY_130826_183") && !text.Contains("SXPY_130826_209"))
					{
						if (!text.Contains("SXPY_130826_48") && !text.Contains("SXPY_130826_127") && !text.Contains("SXPY_130826_160") && !text.Contains("SXPY_130826_198"))
						{
							if (!text.Contains("SXPY_130826_46") && !text.Contains("SXPY_130826_131") && !text.Contains("SXPY_130826_158") && !text.Contains("SXPY_130826_199"))
							{
								if (text.Contains("SXPY_130826_62") || text.Contains("SXPY_130826_89") || text.Contains("SXPY_130826_128") || text.Contains("SXPY_130826_114") || text.Contains("SXPY_130826_174") || text.Contains("SXPY_130826_201") || text.Contains("SXPY_130826_192"))
								{
									class58_1.class114_0.string_8 = "QCXNV";
								}
							}
							else
							{
								class58_1.class114_0.string_8 = "QCTLD";
							}
						}
						else
						{
							class58_1.class114_0.string_8 = "QCTLS";
						}
					}
					else
					{
						class58_1.class114_0.string_8 = "QCTNV";
					}
				}
				else if (class58_1.class114_0.bool_55)
				{
					if (text.Contains("BHRWSC_110331_176") || text.Contains("BHRWSC_110331_41"))
					{
						class58_1.class114_0.string_8 = "LKXQ";
					}
				}
				else if (!class58_1.class114_0.bool_40 && !class58_1.class114_0.bool_41 && !class58_1.class114_0.bool_145)
				{
					if (class58_1.class114_0.bool_87)
					{
						if (text.Contains("}Trái#{"))
						{
							class58_1.class114_0.string_8 = "QRBT";
						}
						else if (text.Contains("}Phải#{") || text2.Contains("}Phäi#{"))
						{
							class58_1.class114_0.string_8 = "QRBP";
						}
						if (text.Contains("}10/10#{") || text.Contains("ông Diệ"))
						{
							class58_1.class114_0.long_53 = frmLogin.stopwatch_0.ElapsedMilliseconds;
						}
					}
					else if (class58_1.class114_0.bool_37)
					{
						if (!text.Contains("ần Há") && !text2.Contains("¥n Há") && !text.Contains("ần Kha") && !text2.Contains("¥n Kha") && !text.Contains("n kỹ nă") && !text2.Contains("n kÛ nå"))
						{
							if (text.Contains("ộ thành t") || text2.Contains("µ thành t"))
							{
								class58_1.class114_0.int_102++;
								Class83.smethod_66("Tăng được {0} độ thành thạo", class58_1, new object[]
								{
									class58_1.class114_0.int_102
								});
							}
						}
						else
						{
							class58_1.class114_0.string_8 = "KDCD";
						}
					}
					else if (class58_1.class114_0.bool_76)
					{
						if (text.Contains("SDHDRW_091109_26"))
						{
							class58_1.class114_0.string_8 = "HHOK";
							if (text.Contains("3/3"))
							{
								class58_1.class114_0.string_8 = "HHXR";
							}
						}
						if (text.Contains("SDHDRW_091109_28"))
						{
							class58_1.class114_0.string_8 = "HHXR";
						}
						else if (text.Contains("SDHDRW_091109_24"))
						{
							class58_1.class114_0.string_8 = "HHOK";
							if (text.Contains("5/5"))
							{
								class58_1.class114_0.string_8 = "HHXR";
							}
						}
						else if (text.Contains("SDHDRW_091109_29"))
						{
							class58_1.class114_0.string_8 = Class83.smethod_83(text, "9_29}", "#{S", 1, 1);
							if (class58_1.class114_0.string_8 != "")
							{
								Class83.smethod_66("Xong vòng {0} nv Hoa", class58_1, new object[]
								{
									class58_1.class114_0.string_8
								});
								int.TryParse(class58_1.class114_0.string_8, out class58_1.class114_0.int_103);
								if (class58_1.class114_0.int_103 >= frmLogin.class101_0.globalSettings_0.soVongQHoa)
								{
									class58_1.class114_0.string_8 = "HVQH";
								}
							}
							if (class58_1.class114_0.string_8 != "HVQH")
							{
								class58_1.class114_0.string_8 = "NVHF";
							}
						}
					}
					else if (class58_1.class114_0.bool_68)
					{
						if (text.Contains("ất bạ"))
						{
							class58_1.class114_0.string_8 = "PCTB";
						}
						else if (text.Contains("hông thể ph"))
						{
							class58_1.class114_0.string_8 = "KTPC";
						}
						else if (text.Contains("úi củ"))
						{
							class58_1.class114_0.int_58 = 1;
						}
						else if (text.Contains("ụng phả"))
						{
							class58_1.class114_0.int_58 = 2;
						}
						else if (text.Contains("ơi đã đạ"))
						{
							class58_1.class114_0.int_58 = 3;
						}
						else if (text.Contains("ào đượ"))
						{
							class58_1.class114_0.int_58 = 4;
						}
						else if (text.Contains("hả bọ"))
						{
							class58_1.class114_0.int_58 = 5;
						}
						else if (text.Contains("ẩn thậ"))
						{
							class58_1.class114_0.int_58 = 6;
						}
						else if (text.Contains("ơi và"))
						{
							class58_1.class114_0.int_58 = 7;
						}
					}
					else if (class58_1.class114_0.bool_70)
					{
						if (text.Contains("TGQF_100111_53"))
						{
							class58_1.class114_0.string_8 = "CPTC";
						}
					}
					else if (class58_1.class114_0.bool_69)
					{
						if ((text.Contains("ã đạt") && text.Contains("ởng Thà")) || text.Contains("ắt thành côn"))
						{
							class58_1.class114_0.string_8 = "BDPR";
						}
						else if (text.Contains("oàn thà") && text.Contains("ư mô"))
						{
							class58_1.class114_0.string_8 = "QSMFN";
							string text5 = Class83.smethod_83(text, "xong", "vò", 1, 1);
							text5 = text5.Trim();
							Class83.smethod_66("Xong vòng {0} nv Sư Môn", class58_1, new object[]
							{
								text5
							});
							int num2 = 0;
							int.TryParse(text5, out num2);
							if (num2 >= frmLogin.class101_0.globalSettings_0.soVongQSM)
							{
								Class83.smethod_66("Đã xong {0} vòng QSM, dừng nhiệm vụ", class58_1, new object[]
								{
									text5
								});
								class58_1.class114_0.bool_69 = false;
								class58_1.IsAIEnabled = false;
							}
						}
						if (class58_1.class114_0.int_58 == 6)
						{
							if (text.Contains("5/5") || text.Contains("ext_43}"))
							{
								class58_1.class114_0.string_8 = "TDXR";
							}
						}
						else if (class58_1.class114_0.int_58 == 5 && text.Contains("ệm vụ đã ho"))
						{
							class58_1.class114_0.string_8 = "SMXQ";
						}
					}
					else if (class58_1.class114_0.bool_152)
					{
						if (text.Contains("ltText_15}"))
						{
							class58_1.class114_0.string_8 = "TDTKG";
						}
						else if (!text.Contains("rget_Bo") && !text.Contains("ương đ"))
						{
							if (!text.Contains("ệu không đ") && !text.Contains("ỗỪừãặắ") && !text.Contains("ient materia"))
							{
								if (text.Contains("ED_SPEC_ST"))
								{
									class58_1.class114_0.string_8 = "HNLR";
								}
							}
							else
							{
								class58_1.class114_0.string_8 = "HDTR";
							}
						}
						else
						{
							class58_1.class114_0.string_8 = "RDDD";
						}
					}
					else if (class58_1.class114_0.bool_155)
					{
						if (text.Contains(frmMain.String_751))
						{
							class58_1.class114_0.string_8 = "DDPL";
						}
						else if (text.Contains(frmMain.String_750))
						{
							class58_1.class114_0.string_8 = "TDDD";
						}
						else if (text.Contains(frmMain.String_748))
						{
							class58_1.class114_0.string_8 = "DDQDT";
						}
						else if (text.Contains(frmMain.String_749))
						{
							class58_1.class114_0.string_8 = "DXNTB";
						}
						else if (text.Contains("ã hoàn thà") || text.Contains("finish"))
						{
							class58_1.class75_0.long_5 = 0L;
						}
					}
					else if (class58_1.class114_0.bool_156)
					{
						if (text.Contains(frmMain.String_754))
						{
							class58_1.class114_0.string_8 = "DDDH";
						}
						else if (text.Contains(frmMain.String_755))
						{
							class58_1.class114_0.string_8 = "DDHV";
						}
						else if (text.Contains("ã hoàn thà") || text.Contains("finish"))
						{
							class58_1.class75_0.long_5 = 0L;
						}
						if (text.Contains("ã Hùng: "))
						{
							string s = Class83.smethod_83(text, "ùng: ", "/80", 1, 1);
							int num3 = -1;
							int.TryParse(s, out num3);
							class58_1.class114_0.int_61 = 80 - num3;
						}
						else if (text.Contains("d Bear: "))
						{
							string s2 = Class83.smethod_83(text, "Bear: ", "/80", 1, 1);
							int num4 = -1;
							int.TryParse(s2, out num4);
							class58_1.class114_0.int_61 = 80 - num4;
						}
						else if (text.Contains("野熊: "))
						{
							string s3 = Class83.smethod_83(text, "野熊", "/80", 1, 1);
							int num5 = -1;
							int.TryParse(s3, out num5);
							class58_1.class114_0.int_61 = 80 - num5;
						}
					}
					else if (class58_1.class114_0.bool_157)
					{
						if (text.Contains("{ResultText_6}"))
						{
							class58_1.class114_0.string_8 = "SCHP";
						}
					}
					else if (class58_1.class114_0.bool_160)
					{
						if (text.Contains("{ResultText_159}"))
						{
							class58_1.class114_0.string_8 = "TTBQC";
						}
						if ((text.Contains("ã bị đánh bạ") && text.Contains("ung Ph")) || (text.Contains("Fu Rong") && text.Contains("defe")))
						{
							class58_1.class114_0.string_8 = "TDMDP";
						}
					}
					else if (class58_1.class114_0.bool_195 && text.Contains("hành côn"))
					{
						class58_1.class114_0.string_8 = "TBTC";
					}
				}
				else
				{
					if (text.Contains(": 30/30") || text.Contains(": 30/31") || text.Contains("}43/43"))
					{
						class58_1.class114_0.string_8 = "ATXQ";
					}
					if (class58_1.method_338())
					{
						if (!text.Contains("Ác Bá: 1/1") && !text.Contains("Thieves: 1/1"))
						{
							if (text.Contains(": 31/31"))
							{
								class58_1.class114_0.string_8 = "ATKT";
								class58_1.class114_0.int_100++;
								Class83.smethod_66(frmMain.String_728, class58_1, new object[]
								{
									class58_1.class114_0.int_100
								});
							}
							else if (text.Contains("FHGC_090706_22"))
							{
								class58_1.class114_0.string_8 = "ATKT";
							}
							else if (text.Contains("ẽ rời k"))
							{
								if (text.Contains("u 10 gi"))
								{
									class58_1.class114_0.string_8 = "PBKT10";
								}
								if (text.Contains("u 5 gi"))
								{
									class58_1.class114_0.string_8 = "PBKT5";
								}
							}
							else if (text.Contains("ill leave her"))
							{
								if (text.Contains("er 10 sec"))
								{
									class58_1.class114_0.string_8 = "PBKT10";
								}
								if (text.Contains("er 5 sec"))
								{
									class58_1.class114_0.string_8 = "PBKT5";
								}
							}
						}
						else if (class58_1.autoSettings_0.cboABMaps != 16 || class58_1.class59_0.int_2 != 3)
						{
							class58_1.class114_0.string_8 = "ATKT";
							class58_1.class114_0.int_100++;
							Class83.smethod_66(frmMain.String_727, class58_1, new object[]
							{
								class58_1.class114_0.int_100
							});
						}
					}
				}
				if (frmLogin.stopwatch_0.ElapsedMilliseconds - class58_1.class75_0.long_20 <= 120000L && frmLogin.stopwatch_0.ElapsedMilliseconds - class58_1.class75_0.long_14 <= 300000L)
				{
					if (text.Contains("ớng li"))
					{
						string b = Class83.smethod_83(text, "u [", "]", 1, 1);
						if (class58_1.class114_0.string_3 == b)
						{
							if (class58_1.class114_0.ActionStatus == 7)
							{
								if (class58_1.class120_0.int_8 > 0)
								{
									class58_1.method_194(-1, class58_1.class120_0.int_8, 0, 0, false, false);
								}
								else
								{
									class58_1.method_194(-1, 34, 0, 0, false, false);
									int num6 = class58_1.method_209();
									class58_1.method_194(-1, num6, 0, 0, false, false);
								}
								Thread.Sleep(300);
							}
							class58_1.autoSettings_0.cboxTheoSau = false;
							class58_1.method_162(46f, 83f);
						}
						else
						{
							class58_1.autoSettings_0.cboxTheoSau = true;
						}
					}
					if ((class58_1.class59_0.int_11 == 12 || class58_1.class59_0.int_2 == 4) && text.Contains("s looking at"))
					{
						string b2 = Class83.smethod_83(text, "at [", "]", 1, 1);
						if (class58_1.class114_0.string_3 == b2)
						{
							if (class58_1.class114_0.ActionStatus == 7)
							{
								if (class58_1.class120_0.int_8 > 0)
								{
									class58_1.method_194(-1, class58_1.class120_0.int_8, 0, 0, false, false);
								}
								else
								{
									class58_1.method_194(-1, 34, 0, 0, false, false);
									int num7 = class58_1.method_209();
									class58_1.method_194(-1, num7, 0, 0, false, false);
								}
								Thread.Sleep(300);
							}
							class58_1.autoSettings_0.cboxTheoSau = false;
							class58_1.method_162(46f, 83f);
						}
						else
						{
							class58_1.autoSettings_0.cboxTheoSau = true;
						}
					}
				}
				if ((frmLogin.stopwatch_0.ElapsedMilliseconds - class58_1.class75_0.long_13 <= 300000L || frmLogin.stopwatch_0.ElapsedMilliseconds - class58_1.class75_0.long_14 <= 300000L) && text.Contains("{ResultText_159}"))
				{
					for (int l = 0; l < 30; l++)
					{
						if (class58_1.class112_0.list_1[l].int_0 == 30103042)
						{
							class58_1.method_189(l, class58_1.class114_0.int_9, 0, 0, 0, 0);
							break;
						}
					}
				}
				if (text.Contains("{ResultText_3}"))
				{
					class58_1.class114_0.string_8 = "KNVH";
				}
				else if (text.Contains("{ResultText_9}"))
				{
					if (class58_1.class75_0.long_15 == 0L)
					{
						class58_1.class75_0.long_15 = frmLogin.stopwatch_0.ElapsedMilliseconds;
					}
					if (frmLogin.stopwatch_0.ElapsedMilliseconds - class58_1.class75_0.long_15 <= 3000L)
					{
						class58_1.class75_0.int_12++;
					}
					if (frmLogin.stopwatch_0.ElapsedMilliseconds - class58_1.class75_0.long_15 > 3000L)
					{
						class58_1.class75_0.long_15 = 0L;
						class58_1.class75_0.int_12 = 0;
					}
				}
				if (text.Contains("TDGZ_100809_21") || text.Contains("ã gia nhập Quâ"))
				{
					class58_1.class75_0.long_55 = Class101.smethod_61() + 3000L;
				}
				if (Class83.smethod_122() && new Random().Next(0, 10000) <= 7000)
				{
					class58_1.class114_0.string_8 = "";
				}
			}
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x000817B8 File Offset: 0x0007F9B8
		internal unsafe static void smethod_6(Class58 class58_1)
		{
			if (class58_1 != null && class58_1.class114_0 != null)
			{
				if (class58_1.class114_0.long_63 > class58_1.class114_0.PacketWriteIndex)
				{
					class58_1.class114_0.long_63 = 0L;
				}
				long num = class58_1.class114_0.PacketWriteIndex - class58_1.class114_0.long_63;
				bool flag = false;
				Class101.smethod_60(class58_1);
				byte[] array = new byte[2];
				byte[] array2 = new byte[2];
				while (!class58_1.class59_0.bool_6 && num >= 6L && !flag)
				{
					Class101.smethod_60(class58_1);
					array[0] = 0;
					array[1] = 0;
					array2[0] = 0;
					array2[1] = 0;
					long long_ = class58_1.class114_0.long_63;
					int num2 = (int)((long_ + 1L) % (long)((uint)class58_1.class59_0.uintptr_9));
					int num3 = (int)Class208.smethod_1(class58_1.class59_0.pByte_8, num2);
					num2 = (int)((long_ + 2L + 1L) % (long)((uint)class58_1.class59_0.uintptr_9));
					int num4 = (int)Class208.smethod_1(class58_1.class59_0.pByte_8, num2);
					int num5 = num4 + 6;
					int num6 = num5;
					num = class58_1.class114_0.PacketWriteIndex - class58_1.class114_0.long_63;
					num2 = (int)((class58_1.class114_0.long_63 + 1L) % (long)((uint)class58_1.class59_0.uintptr_9));
					int int_ = (int)((uint)class58_1.class59_0.uintptr_9 - (uint)num2);
					bool flag2 = false;
					if ((num3 == 456 || num3 == 0 || num5 > 4000 || num > (long)((ulong)class58_1.class59_0.uintptr_9)) && class58_1.class114_0.long_89 == 0L)
					{
						class58_1.class114_0.long_89 = frmLogin.stopwatch_0.ElapsedMilliseconds;
						flag2 = true;
					}
					if (class58_1.class114_0.long_89 != 0L && frmLogin.stopwatch_0.ElapsedMilliseconds - class58_1.class114_0.long_89 >= 7000L)
					{
						if (Class83.smethod_119())
						{
							Class83.smethod_66(frmMain.String_487, class58_1, new object[]
							{
								(int)class58_1.class114_0.float_0,
								(int)class58_1.class114_0.float_5,
								class58_1.class114_0.MapID
							});
						}
						class58_1.class114_0.long_63 = 0L;
						class58_1.method_150();
						class58_1.class114_0.long_89 = 0L;
						return;
					}
					if (!flag2)
					{
						if (!class58_1.class59_0.bool_6 && num >= (long)num6 && num3 != 0 && num6 > 0)
						{
							if (num5 < 4000 && class58_1.class114_0 != null)
							{
								if (!class58_1.class75_0.Boolean_0 && class58_1.class75_0.bool_12)
								{
									if ((num3 == 319 && (class58_1.class59_0.int_2 == 1 || class58_1.class59_0.int_2 == 2 || class58_1.class59_0.int_2 == 4)) || (num3 == 622 && class58_1.class59_0.int_2 == 3))
									{
										if (class58_1.class75_0.int_15 == 3)
										{
											class58_1.class75_0.int_15 = 100;
											class58_1.class75_0.long_22 = frmLogin.stopwatch_0.ElapsedMilliseconds + 4500L;
										}
									}
									else if (num3 == 223 && (class58_1.class59_0.int_2 == 1 || class58_1.class59_0.int_2 == 2 || class58_1.class59_0.int_2 == 4))
									{
										if (class58_1.class75_0.int_15 == 3)
										{
											Class101.smethod_7(class58_1, num5, int_, num2);
											if (class58_1.class59_0.byte_1[56] == 8)
											{
												class58_1.class75_0.long_22 = frmLogin.stopwatch_0.ElapsedMilliseconds + 22000L;
											}
											else if (class58_1.class59_0.byte_1[56] == 1 && class58_1.gclass2_0 != null)
											{
												class58_1.gclass2_0.bool_5 = true;
												class58_1.class75_0.int_15 = 4;
											}
										}
									}
									else if ((num3 == 817 && (class58_1.class59_0.int_2 == 1 || class58_1.class59_0.int_2 == 2 || class58_1.class59_0.int_2 == 4)) || (num3 == 670 && class58_1.class59_0.int_2 == 3))
									{
										Class101.smethod_7(class58_1, num5, int_, num2);
										Class101.smethod_17(class58_1, num4, num5);
									}
								}
								if (class58_1.class114_0.MapID != -1)
								{
									if ((num3 == 1205 && Class83.smethod_61(class58_1.class59_0.int_2) >= 360) || (num3 == 492 && class58_1.class59_0.int_2 == 3) || (num3 == 655 && class58_1.class59_0.int_2 == 4))
									{
										Class101.smethod_7(class58_1, num5, int_, num2);
										Class101.smethod_28(class58_1, num4, num5);
									}
									else if ((num3 == 486 && Class83.smethod_61(class58_1.class59_0.int_2) >= 360) || (num3 == 510 && class58_1.class59_0.int_2 == 3) || (num3 == 251 && class58_1.class59_0.int_2 == 4))
									{
										Class101.smethod_7(class58_1, num5, int_, num2);
										Class101.smethod_27(class58_1, num4, num5);
									}
									else if ((num3 == 1478 && Class83.smethod_61(class58_1.class59_0.int_2) >= 360) || (num3 == 514 && class58_1.class59_0.int_2 == 3) || (num3 == 537 && class58_1.class59_0.int_2 == 4))
									{
										Class101.smethod_7(class58_1, num5, int_, num2);
										Class101.smethod_26(class58_1, num4, num5);
									}
									else if ((num3 == 213 && Class83.smethod_61(class58_1.class59_0.int_2) >= 360) || (num3 == 504 && class58_1.class59_0.int_2 == 3) || (num3 == 673 && class58_1.class59_0.int_2 == 4))
									{
										Class101.smethod_7(class58_1, num5, int_, num2);
										Class101.smethod_16(class58_1, num4, num5);
									}
									else if ((num3 == 799 && Class83.smethod_61(class58_1.class59_0.int_2) >= 360) || (num3 == 447 && class58_1.class59_0.int_2 == 3))
									{
										Class101.smethod_7(class58_1, num5, int_, num2);
										Class101.smethod_15(class58_1, num4, num5);
									}
									else if ((num3 == 1679 && Class83.smethod_61(class58_1.class59_0.int_2) >= 360) || (num3 == 206 && class58_1.class59_0.int_2 == 3) || (num3 == 806 && class58_1.class59_0.int_2 == 4))
									{
										Class101.smethod_7(class58_1, num5, int_, num2);
										Class101.smethod_18(class58_1, num4, num5);
									}
									else if (num3 == 681 && Class83.smethod_61(class58_1.class59_0.int_2) >= 360)
									{
										Class101.smethod_7(class58_1, num5, int_, num2);
										Class101.smethod_19(class58_1, num4, num5);
									}
									else if ((num3 == 474 && Class83.smethod_61(class58_1.class59_0.int_2) >= 360) || (num3 == 606 && class58_1.class59_0.int_2 == 3) || (num3 == 696 && class58_1.class59_0.int_2 == 4))
									{
										Class101.smethod_7(class58_1, num5, int_, num2);
										Class101.smethod_14(class58_1, num4, num5);
									}
									else if ((num3 == 689 && Class83.smethod_61(class58_1.class59_0.int_2) >= 360) || (num3 == 22 && class58_1.class59_0.int_2 == 3 && class58_1.class59_0.int_11 != 4))
									{
										Class101.smethod_7(class58_1, num5, int_, num2);
										Class101.smethod_13(class58_1, num4, num5);
									}
									else if ((num3 == 726 && Class83.smethod_61(class58_1.class59_0.int_2) >= 360) || (num3 == 310 && class58_1.class59_0.int_2 == 3) || (num3 == 752 && class58_1.class59_0.int_2 == 4))
									{
										Class101.smethod_7(class58_1, num5, int_, num2);
										Class101.smethod_9(class58_1, num4, num5);
									}
									else if ((num3 == 2098 && Class83.smethod_61(class58_1.class59_0.int_2) >= 360) || (num3 == 250 && class58_1.class59_0.int_2 == 3) || (num3 == 46 && class58_1.class59_0.int_2 == 4))
									{
										Class101.smethod_7(class58_1, num5, int_, num2);
										Class101.smethod_12(class58_1, num4, num5);
									}
									else if ((num3 == 652 && Class83.smethod_61(class58_1.class59_0.int_2) >= 360) || (num3 == 542 && class58_1.class59_0.int_2 == 3) || (num3 == 130 && class58_1.class59_0.int_2 == 4))
									{
										bool flag3 = false;
										if (class58_1.class59_0.pByte_8[num2 + 6] == 4 && class58_1.class59_0.pByte_8[num2 + 11] == 196 && (class58_1.class59_0.int_2 == 7 || class58_1.class59_0.int_2 == 8))
										{
											flag3 = true;
										}
										if (((class58_1.class59_0.pByte_8[num2 + 8] == 64 || class58_1.class59_0.pByte_8[num2 + 11] == 64) && class58_1.class59_0.pByte_8[num2 + 6] == 4) || (Class83.smethod_119() && flag3))
										{
											Class101.smethod_7(class58_1, num5, int_, num2);
											Class101.smethod_8(class58_1, num4, num5, 0);
										}
										if (class58_1.class59_0.pByte_8[num2 + 6] == 3)
										{
											Class101.smethod_7(class58_1, num5, int_, num2);
											Class101.smethod_8(class58_1, num4, num5, 1);
										}
									}
									else if ((num3 == 380 && Class83.smethod_61(class58_1.class59_0.int_2) >= 360) || (num3 == 295 && class58_1.class59_0.int_2 == 3) || (num3 == 62 && class58_1.class59_0.int_2 == 4))
									{
										Class101.smethod_7(class58_1, num5, int_, num2);
										Class101.smethod_11(class58_1, num4, num5);
									}
									else if ((num3 == 68 && class58_1.class59_0.int_2 == 3) || (num3 == 824 && class58_1.class59_0.int_2 == 4))
									{
										Class101.smethod_7(class58_1, num5, int_, num2);
										Class101.smethod_21(class58_1, num4, num5);
									}
									else if (num3 == 458 && class58_1.class59_0.int_2 == 3)
									{
										Class101.smethod_7(class58_1, num5, int_, num2);
										Class101.smethod_22(class58_1, num4, num5);
									}
									else if (num3 == 1995 && Class83.smethod_61(class58_1.class59_0.int_2) >= 360)
									{
										Class101.smethod_7(class58_1, num5, int_, num2);
										Class101.smethod_23(class58_1, num4, num5);
									}
								}
							}
							class58_1.class114_0.long_63 += (long)num6;
							num = class58_1.class114_0.PacketWriteIndex - class58_1.class114_0.long_63;
						}
						else
						{
							flag = true;
						}
					}
				}
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00082300 File Offset: 0x00080500
		internal unsafe static void smethod_7(Class58 class58_1, int int_6, int int_7, int int_8)
		{
			try
			{
				Array.Clear(class58_1.class59_0.byte_1, 0, class58_1.class59_0.byte_1.Length);
				int num;
				int num2;
				if (int_6 > int_7)
				{
					num = int_7;
					num2 = int_6 - int_7;
				}
				else
				{
					num = int_6;
					num2 = 0;
				}
				if (num > 0)
				{
					for (int i = int_8; i < int_8 + num; i++)
					{
						class58_1.class59_0.byte_1[i - int_8] = class58_1.class59_0.pByte_8[i];
					}
				}
				if (num2 > 0)
				{
					for (int j = 0; j < num2; j++)
					{
						class58_1.class59_0.byte_1[j + num] = class58_1.class59_0.pByte_8[j];
					}
				}
				Class83.smethod_54(class58_1.class59_0.byte_1);
			}
			catch (Exception ex)
			{
				if (!class58_1.class59_0.bool_9)
				{
					Class83.smethod_66("Báo ngay GAuto [2]: " + ex.Message + " Stack: " + ex.StackTrace.ToString(), class58_1, new object[0]);
				}
				class58_1.class59_0.bool_9 = true;
			}
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0008240C File Offset: 0x0008060C
		internal static void smethod_8(Class58 class58_1, int int_6, int int_7, int int_8 = 0)
		{
			string text = Class83.smethod_142(class58_1.class59_0.byte_1, 0, int_7);
			if (class58_1.class59_0.int_2 == 7 || class58_1.class59_0.int_2 == 8 || class58_1.class59_0.int_2 == 5 || class58_1.class59_0.int_2 == 6)
			{
				text = Encoding.GetEncoding("gb2312").GetString(class58_1.class59_0.byte_1);
				if (text.Contains("您已经被禁言") && Class83.smethod_119())
				{
					class58_1.class75_0.bool_23 = true;
					string s = Class83.smethod_83(text, "剩余", "分钟", 1, 1);
					int num = 0;
					int.TryParse(s, out num);
					class58_1.class75_0.int_34 = num + 1;
					class58_1.class75_0.long_39 = frmLogin.stopwatch_0.ElapsedMilliseconds;
					Class83.smethod_66("Blocked chat " + num.ToString() + " minutes", class58_1, new object[0]);
				}
			}
			if (int_8 == 1)
			{
				try
				{
					int num2 = (int)class58_1.class59_0.byte_1[7];
					int num3 = 0;
					if (Class83.smethod_61(class58_1.class59_0.int_2) >= 360)
					{
						num3 = 3;
						num2 = BitConverter.ToInt32(class58_1.class59_0.byte_1, 7);
					}
					int num4 = 8 + num3;
					byte[] array = new byte[260];
					int num5 = 0;
					for (int i = num4; i < num4 + num2; i++)
					{
						array[num5] = class58_1.class59_0.byte_1[i];
						num5++;
					}
					string text2 = Class83.smethod_142(array, 0, num2);
					int num6 = (int)class58_1.class59_0.byte_1[num2 + num4];
					int num7 = num2 + num4 + 1;
					byte[] array2 = new byte[30];
					num5 = 0;
					for (int j = num7; j < num7 + num6; j++)
					{
						array2[num5] = class58_1.class59_0.byte_1[j];
						num5++;
					}
					string str = Class83.smethod_142(array2, 0, num6);
					if (text2 == "#cc66422#18#19#26#25#24#13#75#74#83#97#78#77#29")
					{
						class58_1.method_105(0, "Happy New Year", false, "");
					}
					else
					{
						Class83.smethod_66(str + ": " + text2, class58_1, new object[0]);
					}
				}
				catch (Exception)
				{
					Class83.smethod_66("Lỗi khi xử lý chat", class58_1, new object[0]);
				}
				if (class58_1.autoSettings_0.ChatAlert)
				{
					try
					{
						new SoundPlayer("chat.wav").Play();
					}
					catch (Exception)
					{
					}
				}
			}
			if (text.Contains("@*;SrvMsg") && (text.Contains("ang Hồ Tiể") || text.ToLower().Contains("ang hồ tiể") || text.ToLower().Contains("ief rai") || text.ToLower().Contains("thieves")))
			{
				string text3;
				if (class58_1.class59_0.int_2 == 3)
				{
					text3 = Class83.smethod_83(text, ": Ta #Y", "#P đột", 1, 1);
				}
				else
				{
					text3 = Class83.smethod_83(text, "#P: Phái #Y", "#P ta đang", 1, 1);
				}
				if (class58_1.class59_0.int_11 == 12)
				{
					text3 = Class83.smethod_83(text, ": I'm #Y", "#P sudd", 1, 1);
				}
				if (class58_1.class59_0.int_2 == 4)
				{
					text3 = Class83.smethod_83(text, "#Y", "#P A group", 1, 1);
				}
				if (text3 == "Mộ Dung Thế Gia")
				{
					text3 = "Mộ Dung";
				}
				class58_1.autoSettings_0.AcBaPhai = text3;
				class58_1.autoSettings_0.AcBaPhaiStamp = frmLogin.stopwatch_0.ElapsedMilliseconds;
				if (class58_1.method_340() == 2 || class58_1.method_340() == 0)
				{
					Class83.smethod_66(frmMain.String_428, class58_1, new object[]
					{
						text3
					});
				}
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x000827D0 File Offset: 0x000809D0
		internal static void smethod_9(Class58 class58_1, int int_6, int int_7)
		{
			if (int_6 > 6 && int_6 < class58_1.class59_0.byte_1.Length)
			{
				string text = Class83.smethod_142(class58_1.class59_0.byte_1, 0, int_7);
				int num = -1;
				int num2 = -1;
				int i = 6;
				while (i < 6 + int_6 - 2)
				{
					if (class58_1.class59_0.byte_1[i] == 123 && class58_1.class59_0.byte_1[i - 1] == 35)
					{
						num = i + 1;
						IL_74:
						if (num != -1 && num < 6 + int_6)
						{
							int j = num;
							while (j < 6 + int_6)
							{
								if (class58_1.class59_0.byte_1[j] != 125)
								{
									if (class58_1.class59_0.byte_1[j] != 42)
									{
										j++;
										continue;
									}
								}
								num2 = j - 1;
								break;
							}
						}
						bool flag = false;
						if (num != -1 && num2 != -1 && num < num2 && num2 < int_7)
						{
							Class83.smethod_83(text, "#{", "}", 1, 1);
							flag = true;
						}
						string text2 = Class83.smethod_137(text, 1);
						if (class58_1.class114_0.bool_185 || class58_1.autoSettings_0.cboxDebugLog)
						{
							text = text.Replace("Ầ", "");
							text = text.Replace("Ẵ", "");
							text = text.Replace("Ẳ", "");
							text = text.Replace("Ù", "");
							text = text.Replace("Ố", "");
							text = text.Replace("Ớ", "");
							text = text.Replace("Ữ", "");
							text = text.Replace("Ự", "");
							text = text.Replace("Ẫ", "");
							text = text.Replace("\r", "");
							text = text.Replace("\0", "");
							text = text.Replace("{", "{{");
							text = text.Replace("}", "}}");
						}
						if (Class83.smethod_119() && class58_1.autoSettings_0.cboxDebugLog)
						{
							Class83.smethod_66("packetString: " + text, class58_1, new object[0]);
						}
						bool flag2 = false;
						if (class58_1.class114_0.bool_66)
						{
							if (text.Contains("Nhiệm vụ xây dựng"))
							{
								if (!text.Contains("cướp đi mất,") && !text2.Contains("cß¾p ði m¤t,"))
								{
									if (!text.Contains("không may đánh mất") && !text2.Contains("không may ðánh m¤t"))
									{
										if (!text.Contains("cầm đầu đám giang hồ") && !text2.Contains("c¥m ð¥u ðám giang h"))
										{
											if (text.Contains("iến triển nh") || text2.Contains("iªn tri¬n nh"))
											{
												class58_1.class114_0.string_12 = "XDTQ";
											}
										}
										else
										{
											class58_1.class114_0.string_12 = "XDCT";
										}
									}
									else
									{
										class58_1.class114_0.string_12 = "XDMD";
									}
								}
								else
								{
									class58_1.class114_0.string_12 = "XDDC";
								}
							}
							if (text.Contains("cần các hạ đi đoạt lại") || text2.Contains("c¥n các hÕ ði ðoÕt lÕi"))
							{
								class58_1.class114_0.string_12 = "XDDQ";
							}
						}
						else if (class58_1.class114_0.bool_55)
						{
							if (flag && !flag2)
							{
								if (text.Contains("BHRWSC_110331_22"))
								{
									int num3 = num2 + 5;
									int num4 = 0;
									string text3 = "";
									string text4 = "";
									if (num3 < int_7)
									{
										num4 = (int)class58_1.class59_0.byte_1[num3];
									}
									num3++;
									if (num3 + num4 < int_7 && num4 <= 4)
									{
										for (int k = num3; k < num3 + num4; k++)
										{
											string str = text3;
											char c = (char)class58_1.class59_0.byte_1[k];
											text3 = str + c.ToString();
										}
									}
									num3 = num3 + num4 + 1;
									if (num3 < int_7)
									{
										num4 = (int)class58_1.class59_0.byte_1[num3];
									}
									num3++;
									if (num3 + num4 < int_7 && num4 <= 4)
									{
										for (int l = num3; l < num3 + num4; l++)
										{
											string str2 = text4;
											char c = (char)class58_1.class59_0.byte_1[l];
											text4 = str2 + c.ToString();
										}
									}
									if (text3 != "" && text4 != "")
									{
										int int_8 = 0;
										int int_9 = 0;
										int.TryParse(text3, out int_8);
										int.TryParse(text4, out int_9);
										class58_1.class114_0.int_65 = int_8;
										class58_1.class114_0.int_75 = int_9;
									}
								}
								else if (text.Contains("BHRWSC_110331_75"))
								{
									class58_1.class114_0.string_12 = "LK";
									class58_1.class114_0.int_65 = 66;
									class58_1.class114_0.int_75 = 135;
								}
								else if (text.Contains("BHRWSC_110331_23"))
								{
									class58_1.class114_0.string_12 = "DDXR";
								}
								else if (!text.Contains("BHRWSC_110331_156") && !text.Contains("{LJYH_141105_05"))
								{
									if (!text.Contains("BHRWSC_110331_174") && !text.Contains("BHRWSC_110331_41"))
									{
										if (text.Contains("LJYH_141105_06"))
										{
											class58_1.class114_0.string_12 = "HDLKN";
										}
										else if (text.Contains("DJBHGZ_110511_08"))
										{
											class58_1.class114_0.string_12 = "HDHD";
										}
									}
									else
									{
										class58_1.class114_0.string_12 = "LKXQ";
									}
								}
								else
								{
									class58_1.class114_0.string_12 = "NNVLK";
								}
								if (text.Contains("BHXH_RWLQ"))
								{
									class58_1.class114_0.string_12 = "CTNV";
								}
								if (text.Contains("BHRWSC_110331_157"))
								{
									if (text.Contains("BHRWSC_110331_178"))
									{
										class58_1.class114_0.string_12 = "CNBT";
									}
									else
									{
										class58_1.class114_0.string_12 = "NNVL";
									}
								}
							}
						}
						else if (class58_1.class114_0.bool_86)
						{
							if (text.Contains("BHCJ_140523_89"))
							{
								class58_1.class114_0.string_12 = "PTTC";
							}
							else if (text.Contains("BHCJ_140523_96"))
							{
								class58_1.class114_0.string_12 = "DPTX";
							}
							else if (text.Contains("BHCJ_140523_90"))
							{
								class58_1.class114_0.string_12 = "CNPT";
							}
							else if (text.Contains("BHCJ_140523_84"))
							{
								class58_1.class114_0.string_12 = "CDVB";
							}
							else if (text.Contains("BHCJ_140523_128"))
							{
								class58_1.class114_0.string_12 = "BBKT";
								class58_1.class114_0.bool_49 = true;
							}
							else if (text.Contains("BHCJ_140523_193"))
							{
								class58_1.class114_0.string_12 = "NPTD";
							}
							else if (text.Contains("BHCJ_140523_105"))
							{
								class58_1.class114_0.string_12 = "NPTR";
							}
							else if (text.Contains("BHCJ_140523_103"))
							{
								class58_1.class114_0.string_12 = "CKTBB";
							}
						}
						else if (class58_1.class114_0.bool_67 && class58_1.class114_0.int_108 == 1)
						{
							if (text.Contains("SXPY_130826_"))
							{
								class58_1.method_240(text);
								if (class58_1.autoSettings_0.cboTuDuongCon == 3)
								{
									if (!text.Contains("Toàn Tiểu Nhan") && !text2.Contains("Toàn Ti¬u Nhan"))
									{
										if (!text.Contains("Tào Tiểu Minh") && !text2.Contains("Tào Ti¬u Minh"))
										{
											if (text.Contains("Lục Tiểu Kỳ") || text2.Contains("Løc Ti¬u KÏ"))
											{
												class58_1.class114_0.string_12 = "QCLTK";
											}
										}
										else
										{
											class58_1.class114_0.string_12 = "QCTTM";
										}
									}
									else
									{
										class58_1.class114_0.string_12 = "QCTTN";
									}
								}
							}
						}
						else if (class58_1.class114_0.bool_87)
						{
							if (text.Contains("CJG_090413_26") || text.Contains("hết Mông Diệ"))
							{
								class58_1.class114_0.string_12 = "KTTKC";
							}
						}
						else if (class58_1.class114_0.bool_47)
						{
							if (class58_1.class59_0.int_2 == 4)
							{
								if (text.Contains("Punishment Order can on"))
								{
									int num5 = 0;
									int num6 = 0;
									int num7 = -1;
									string text5 = Class83.smethod_83(text, "[", "]", 1, 1);
									if (text5 != "")
									{
										string[] array = text5.Split(new char[]
										{
											','
										});
										if (array.Length >= 2)
										{
											int.TryParse(array[0], out num5);
											int.TryParse(array[1], out num6);
										}
									}
									text5 = Class83.smethod_83(text, "used at", "[", 1, 1);
									if (text5 != "")
									{
										text5 = text5.Trim(new char[]
										{
											' '
										});
										if (frmLogin.class101_0.list_3.Count > 0)
										{
											foreach (Class147 @class in frmLogin.class101_0.list_3)
											{
												if (@class.string_0 == text5)
												{
													num7 = @class.int_0;
													break;
												}
											}
										}
									}
									if (num5 > 0 && num6 > 0 && num7 > -1 && class58_1.class114_0 != null)
									{
										class58_1.class114_0.int_65 = num5;
										class58_1.class114_0.int_75 = num6;
										class58_1.class114_0.int_79 = num7;
										class58_1.class114_0.string_12 = "TAREADY";
									}
								}
							}
							else if (text.Contains("DTYH_121009_18"))
							{
								string text6 = Class83.smethod_83(text, "*", "}", 3, 1);
								if (text6 != "")
								{
									string[] array2 = text6.Split(new char[]
									{
										'*'
									});
									if (array2.Length >= 3)
									{
										array2[array2.Length - 3] = array2[array2.Length - 3].Substring(1, array2[array2.Length - 3].Length - 1);
										array2[array2.Length - 2] = array2[array2.Length - 2].Substring(1, array2[array2.Length - 2].Length - 1);
										array2[array2.Length - 1] = array2[array2.Length - 1].Substring(1, array2[array2.Length - 1].Length - 1);
										int num8 = 0;
										int num9 = 0;
										int num10 = -1;
										int.TryParse(array2[array2.Length - 3], out num8);
										int.TryParse(array2[array2.Length - 2], out num9);
										int.TryParse(array2[array2.Length - 1], out num10);
										if (num8 > 0 && num9 > 0 && num10 != -1 && class58_1.class114_0 != null)
										{
											class58_1.class114_0.int_65 = num8;
											class58_1.class114_0.int_75 = num9;
											class58_1.class114_0.int_79 = num10;
											class58_1.class114_0.string_12 = "TAREADY";
										}
									}
								}
							}
						}
						else if (class58_1.class114_0.bool_76)
						{
							if (text.Contains("SDHDRW"))
							{
								class58_1.class114_0.string_12 = "NVBHD";
							}
							if (class58_1.class114_0.int_58 == 4 && text.Contains("10/10"))
							{
								class58_1.class114_0.string_12 = "NDDR";
							}
							if (text.Contains("SDHDRW_091109_10"))
							{
								class58_1.class114_0.int_58 = 1;
							}
							else if (text.Contains("SDHDRW_091109_17"))
							{
								class58_1.class114_0.int_58 = 2;
							}
							else if (text.Contains("SDHDRW_091109_09"))
							{
								class58_1.class114_0.int_58 = 3;
							}
							else if (text.Contains("SDHDRW_091109_03"))
							{
								class58_1.class114_0.int_58 = 4;
							}
							else if (text.Contains("SDHDRW_091109_07"))
							{
								class58_1.class114_0.int_58 = 5;
							}
						}
						else if (class58_1.class114_0.bool_69)
						{
							if (text.Contains("ụ Sư Mô"))
							{
								if (text.Contains("ạc đãi n"))
								{
									class58_1.class114_0.int_58 = 1;
								}
								else if (text.Contains("ắt cho t"))
								{
									class58_1.class114_0.int_58 = 2;
									text = text.Replace("  ", " ");
									class58_1.class114_0.string_6 = Class83.smethod_83(text, "con", "về", 1, 1);
									class58_1.class114_0.string_6 = class58_1.class114_0.string_6.Trim();
								}
								else if (text.Contains("Bổ câu đưa thư"))
								{
									class58_1.class114_0.int_58 = 3;
								}
								else if (text.Contains("âu lắm k"))
								{
									class58_1.class114_0.int_58 = 4;
									class58_1.class114_0.string_6 = Class83.smethod_83(text, "gặp", ", ngươi", 1, 1);
									class58_1.class114_0.string_6 = class58_1.class114_0.string_6.Replace("Tô Châu", "");
									class58_1.class114_0.string_6 = class58_1.class114_0.string_6.Replace("Lạc Dương", "");
									class58_1.class114_0.string_6 = class58_1.class114_0.string_6.Replace("Đại Lý", "");
									class58_1.class114_0.string_6 = class58_1.class114_0.string_6.Replace("  ", " ");
									class58_1.class114_0.string_6 = class58_1.class114_0.string_6.Trim();
								}
								else if (text.Contains("ơi hãy ở "))
								{
									class58_1.class114_0.int_58 = 5;
								}
								else if (text.Contains("iúp ta ki"))
								{
									class58_1.class114_0.int_58 = 6;
									text = text.Replace("  ", " ");
									class58_1.class114_0.string_6 = Class83.smethod_83(text, "5", "về", 1, 1);
									class58_1.class114_0.string_6 = class58_1.class114_0.string_6.Trim();
								}
								else if (text.Contains("SMFB_") || text.Contains("TMSM_130808_"))
								{
									class58_1.class114_0.int_58 = 7;
								}
							}
							if (text.Contains("ất cần thi"))
							{
								class58_1.class114_0.string_12 = "SMXQ";
							}
							if (text.Contains("ong 15 ph"))
							{
								class58_1.class114_0.string_12 = "SM15M";
							}
						}
						else if (class58_1.class114_0.bool_70)
						{
							if (text.Contains("TGQF_XML_47"))
							{
								class58_1.class114_0.string_12 = "CPID1";
							}
							else if (text.Contains("TGQF_XML_48"))
							{
								class58_1.class114_0.string_12 = "CPID2";
							}
							else if (text.Contains("TGQF_100111_53"))
							{
								class58_1.class114_0.string_12 = "CPTC";
							}
						}
						else if (class58_1.class114_0.bool_71)
						{
							if (!text.Contains("XML_570") && !text.Contains("BHRW_081124_01") && !text.Contains("SQXY_09061_19"))
							{
								if (text.Contains("YLQ_091229_1}"))
								{
									class58_1.class114_0.string_12 = "KTCN";
								}
								else if (text.Contains("SQXY_09061_21"))
								{
									class58_1.class114_0.string_12 = "CNTQOK";
								}
								else if (text.Contains("SQXY_09061_7"))
								{
									class58_1.class114_0.string_12 = "HLCN";
								}
							}
							else
							{
								class58_1.class114_0.string_12 = "CNNQ";
							}
						}
						else if (class58_1.class114_0.bool_72 && text.Contains("YDBX_151028_09"))
						{
							class58_1.class114_0.string_12 = "DBRW";
						}
						if (class58_1.class114_0.bool_157 || class58_1.class114_0.bool_158)
						{
							if (text.Contains("SDJZH_091106_18"))
							{
								class58_1.class114_0.string_12 = "HCTH";
							}
							if (text.Contains("SDJZH_091106_21"))
							{
								class58_1.class114_0.string_12 = "HDBR";
							}
						}
						if (class58_1.class114_0.bool_159)
						{
							if (text.Contains("SDJZH_091106_08") && text.Contains("SDJZH_091106_09"))
							{
								string str3 = Class83.smethod_83(text, "08}", "#{S", 1, 1);
								class58_1.class114_0.string_12 = "Time:" + str3;
							}
						}
						else if (!class58_1.class114_0.bool_155 && !class58_1.class114_0.bool_156)
						{
							if (class58_1.class114_0.bool_160)
							{
								if ((text.Contains("hủ hạ") && text.Contains("n Diê")) || text.Contains("ruel Tuan defea"))
								{
									class58_1.class114_0.string_12 = "TDDDK";
								}
								else if ((!text.Contains("ao thủ v") || !text.Contains("hản tặ")) && !text.Contains("zhan_yzw_003") && !text.Contains("rotect Captain Chi"))
								{
									if ((text.Contains("bại") && text.Contains("u Ma Tr")) || text.Contains("hiskered was def"))
									{
										class58_1.class114_0.string_12 = "TDCMT";
									}
									else if (!text.Contains("còn lại") && (!text.Contains("tiến đến") || !text.Contains("iện quân")) && !text.Contains("times left"))
									{
										if (text.Contains("zhan_yzw_006"))
										{
											class58_1.class114_0.string_12 = "DCTXR";
										}
										else if ((text.Contains("ộ Dung P") && text.Contains("bại")) || (text.Contains("Fu Rong") && text.Contains("defe")))
										{
											class58_1.class114_0.string_12 = "TDMDP";
										}
									}
									else
									{
										class58_1.class114_0.string_12 = "NCTHVR";
									}
								}
								else
								{
									class58_1.class114_0.string_12 = "XQTTR";
								}
							}
							else if (class58_1.class114_0.bool_147)
							{
								if (text.Contains("200/200"))
								{
									class58_1.class114_0.string_12 = "KCXQ";
								}
								else if (text.Contains("hoàn thành") || text.Contains("finish"))
								{
									class58_1.class114_0.string_12 = "KCKT";
								}
							}
							else if (class58_1.class114_0.bool_193)
							{
								if (text.Contains("200/200"))
								{
									class58_1.class114_0.string_12 = "TBXQ";
								}
								else if (text.Contains("hoàn thành") || text.Contains("finish"))
								{
									class58_1.class114_0.string_12 = "TBKT";
								}
							}
							else if (class58_1.class114_0.bool_172)
							{
								if (text.Contains("MGZL_130117_03"))
								{
									class58_1.class114_0.string_12 = "D5KTT";
								}
								else if (text.Contains("MGZL_130117_02"))
								{
									class58_1.class114_0.string_12 = "CKTT";
								}
								else if (text.Contains("MGZL_130117_05"))
								{
									class58_1.class114_0.string_12 = "KTTTC";
								}
							}
							else if (class58_1.class114_0.bool_173)
							{
								if (text.Contains("YWBOSS_140117_09"))
								{
									class58_1.class114_0.string_12 = "CDMD";
								}
								else if (text.Contains("YWBOSS_140117_15"))
								{
									class58_1.class114_0.string_12 = "CCTCH";
								}
								else if (text.Contains("YWBOSS_140117_19"))
								{
									class58_1.class114_0.string_12 = "DCTTC";
								}
							}
							else if (class58_1.class114_0.bool_174)
							{
								if (text.Contains("m nay") && text.Contains("ham gia"))
								{
									class58_1.class114_0.string_12 = "TTVMR";
								}
								else if (text.Contains("XYLP_20071222_08"))
								{
									class58_1.class114_0.string_12 = "TTPC";
								}
							}
							else if (class58_1.class114_0.bool_175)
							{
								if (text.Contains("QNG_090716_05"))
								{
									class58_1.class114_0.string_12 = "HNHR";
								}
								else if (!text.Contains("QNG_090716_14") && !text.Contains("QNG_090716_09") && !text.Contains("QNG_090716_19"))
								{
									if (text.Contains("M_MUBIAO"))
									{
										class58_1.class114_0.string_12 = "CNNV";
									}
									else if (text.Contains("QNG_090716_02"))
									{
										class58_1.class114_0.string_12 = "NVTTH";
									}
								}
								else
								{
									class58_1.class114_0.string_12 = "CTNV";
								}
							}
							else if (class58_1.class114_0.bool_176)
							{
								if (text.Contains("hận đư") || text.Contains("DRFB_130111_254") || text.Contains("DRFB_130111_254"))
								{
									class58_1.class114_0.string_12 = "DNXR";
								}
							}
							else if (class58_1.class114_0.bool_177)
							{
								if (text.Contains("LHLL_130624_33"))
								{
									class58_1.class114_0.string_12 = "DCXR";
								}
								else if (text.Contains("LHLL_130624_50"))
								{
									class58_1.class114_0.string_12 = "LDTC";
								}
							}
							else if (class58_1.class114_0.bool_178)
							{
								if (text.Contains("LHLL_130624_25"))
								{
									class58_1.class114_0.string_12 = "HDDR";
								}
								else if (text.Contains("LHLL_130624_27"))
								{
									class58_1.class114_0.string_12 = "DKTC";
								}
							}
							else if (class58_1.class114_0.bool_179)
							{
								if (text.Contains("_140521_2"))
								{
									class58_1.class114_0.string_12 = "DLBM";
								}
							}
							else if (class58_1.class114_0.bool_181)
							{
								if (text.Contains("hành côn"))
								{
									class58_1.class114_0.string_12 = "TDTC";
								}
								else if (text.Contains("ng mang "))
								{
									class58_1.class114_0.string_12 = "TDTB";
								}
							}
							else if (class58_1.class114_0.bool_152)
							{
								if (text.Contains("n nguyên liệu ch") || text.Contains("ần ít nhấ"))
								{
									class58_1.class114_0.string_12 = "TDTC";
								}
							}
							else if (class58_1.class114_0.bool_188)
							{
								if (text.Contains("hành côn"))
								{
									class58_1.class114_0.string_12 = "TDTC";
								}
								else if (text.Contains(" không "))
								{
									class58_1.class114_0.string_12 = "TDTB";
								}
							}
							else if (class58_1.class114_0.bool_189)
							{
								if (text.Contains("hành côn"))
								{
									class58_1.class114_0.string_12 = "TDTC";
								}
								else if (text.Contains("hông đ"))
								{
									class58_1.class114_0.string_12 = "TDTB";
								}
							}
							else if (class58_1.class114_0.bool_190)
							{
								if (text.Contains("hành côn"))
								{
									class58_1.class114_0.string_12 = "TDTC";
								}
								else if (text.Contains("hông có"))
								{
									class58_1.class114_0.string_12 = "TDTB";
								}
							}
							else if (class58_1.class114_0.bool_192)
							{
								if (!text.Contains("u sau ") && !text.Contains("chiến đấu"))
								{
									if (text.Contains("XPMCZ_081108_1"))
									{
										class58_1.class114_0.string_12 = "HLSC";
									}
									else if (text.Contains(" Thu Thu"))
									{
										class58_1.class114_0.string_12 = "DLTT";
									}
									else if (text.Contains("kinh nghiệm") && class58_1.class114_0.int_111 >= 12)
									{
										class58_1.class114_0.string_12 = "DXPB";
									}
								}
								else
								{
									class58_1.class114_0.string_12 = "CDBD";
								}
							}
							else if (class58_1.class114_0.bool_194)
							{
								if (text.Contains("hủy trại tì"))
								{
									class58_1.class114_0.string_12 = "CNNV";
								}
								else if (!text.Contains("hận nhiệm v") && !text.Contains("ao chưa"))
								{
									if (text.Contains("10/60"))
									{
										class58_1.class114_0.string_12 = "KTTL";
									}
								}
								else
								{
									class58_1.class114_0.string_12 = "DNTL";
								}
							}
							else if (class58_1.class114_0.bool_195)
							{
								if (!text.Contains("MZPVE_150812_467") && !text.Contains("MZPVE_150812_463") && !text.Contains("MZPVE_150812_2271") && !text.Contains("MZPVE_150812_1036") && !text.Contains("MZPVE_150812_1413") && !text.Contains("MZPVE_150812_2160"))
								{
									if (!text.Contains("MZPVE_150812_1044}"))
									{
										if (!text.Contains("MZPVE_150812_473}") && !text.Contains("MZPVE_150812_255}") && !text.Contains("MZPVE_150812_200}") && !text.Contains("MZPVE_150812_395}") && !text.Contains("MZPVE_150812_1791}") && !text.Contains("MZPVE_150812_1661}") && !text.Contains("MZPVE_150812_1741}") && !text.Contains("MZPVE_150812_1631}") && !text.Contains("MZPVE_150812_912}") && !text.Contains("MZPVE_150812_1041}") && !text.Contains("MZPVE_150812_991}") && !text.Contains("MZPVE_150812_883}") && !text.Contains("MZPVE_150812_1287}") && !text.Contains("MZPVE_150812_1417}") && !text.Contains("MZPVE_150812_1257}") && !text.Contains("MZPVE_150812_1367}") && !text.Contains("MZPVE_150812_2034}") && !text.Contains("MZPVE_150812_2165}") && !text.Contains("MZPVE_150812_2115}") && !text.Contains("MZPVE_150812_2004}"))
										{
											if (!text.Contains("MZPVE_150812_258") && !text.Contains("MZPVE_150812_1664") && !text.Contains("MZPVE_150812_915") && !text.Contains("MZPVE_150812_1290") && !text.Contains("MZPVE_150812_2037"))
											{
												if (!text.Contains("MZPVE_150812_259}") && !text.Contains("MZPVE_150812_1665}") && !text.Contains("MZPVE_150812_916}") && !text.Contains("MZPVE_150812_1291}") && !text.Contains("MZPVE_150812_2038}"))
												{
													if (text.Contains("MZPVE_150812_43}"))
													{
														class58_1.class114_0.string_12 = "HQTB";
													}
													else if (text.Contains("MZPVE_150812_45}"))
													{
														class58_1.class114_0.string_12 = "DNTB";
													}
													else if (text.Contains("MZPVE_150812_381"))
													{
														string text7 = Class83.smethod_83(text, "*", "}", 1, 1);
														if (text7.Contains("ơn Khu"))
														{
															class58_1.class114_0.string_12 = "38001371";
														}
														else if (text7.Contains("ạt Huyề"))
														{
															class58_1.class114_0.string_12 = "38001370";
														}
														else if (text7.Contains("à Nư"))
														{
															class58_1.class114_0.string_12 = "38001369";
														}
														else if (text7.Contains("im Trả"))
														{
															class58_1.class114_0.string_12 = "38001368";
														}
														else if (text7.Contains("ơng B"))
														{
															class58_1.class114_0.string_12 = "38001367";
														}
													}
													else if (text.Contains("MZPVE_150812_1733"))
													{
														string text8 = Class83.smethod_83(text, "*", "}", 1, 1);
														if (text8.Contains("ồng Ngu"))
														{
															class58_1.class114_0.string_12 = "38001421";
														}
														else if (text8.Contains("hiết Ngu"))
														{
															class58_1.class114_0.string_12 = "38001422";
														}
														else if (text8.Contains("im Ngu"))
														{
															class58_1.class114_0.string_12 = "38001423";
														}
														else if (text8.Contains("ích Ngu"))
														{
															class58_1.class114_0.string_12 = "38001424";
														}
														else if (text8.Contains("hái Ngu"))
														{
															class58_1.class114_0.string_12 = "38001425";
														}
													}
													else if (text.Contains("MZPVE_150812_984"))
													{
														string text9 = Class83.smethod_83(text, "*", "}", 1, 1);
														if (text9.Contains("m Cắt C"))
														{
															class58_1.class114_0.string_12 = "38001401";
														}
														else if (text9.Contains("Chổi"))
														{
															class58_1.class114_0.string_12 = "38001402";
														}
														else if (text9.Contains("ến Tế T"))
														{
															class58_1.class114_0.string_12 = "38001403";
														}
														else if (text9.Contains("ch Hợp H"))
														{
															class58_1.class114_0.string_12 = "38001404";
														}
														else if (text9.Contains("iện Th"))
														{
															class58_1.class114_0.string_12 = "38001405";
														}
													}
													else if (text.Contains("MZPVE_150812_1359"))
													{
														string text10 = Class83.smethod_83(text, "*", "}", 1, 1);
														if (text10.Contains("ăng Ng"))
														{
															class58_1.class114_0.string_12 = "38001411";
														}
														else if (text10.Contains("ồng Ng"))
														{
															class58_1.class114_0.string_12 = "38001412";
														}
														else if (text10.Contains("uỷ Ng"))
														{
															class58_1.class114_0.string_12 = "38001413";
														}
														else if (text10.Contains("ồi Câu"))
														{
															class58_1.class114_0.string_12 = "38001414";
														}
														else if (text10.Contains("gư Đườ"))
														{
															class58_1.class114_0.string_12 = "38001415";
														}
													}
													else if (text.Contains("MZPVE_150812_2107"))
													{
														string text11 = Class83.smethod_83(text, "*", "}", 1, 1);
														if (text11.Contains("yết Thi"))
														{
															class58_1.class114_0.string_12 = "38001431";
														}
														else if (text11.Contains("anh Đồ"))
														{
															class58_1.class114_0.string_12 = "38001432";
														}
														else if (text11.Contains("húy Ng"))
														{
															class58_1.class114_0.string_12 = "38001433";
														}
														else if (text11.Contains("àn Thi"))
														{
															class58_1.class114_0.string_12 = "38001434";
														}
														else if (text11.Contains("ồng Đồ"))
														{
															class58_1.class114_0.string_12 = "38001435";
														}
													}
													else if (text.Contains("MZPVE_150812_2319}") || text.Contains("MZPVE_150812_2322}") || text.Contains("MZPVE_150812_2320}") || text.Contains("MZPVE_150812_2321}") || text.Contains("MZPVE_150812_2323}"))
													{
														class58_1.class114_0.string_12 = "DDTV";
													}
												}
												else
												{
													class58_1.class114_0.string_12 = "XHTGR";
												}
											}
											else
											{
												class58_1.method_241(text, 2);
											}
										}
										else
										{
											class58_1.class114_0.string_12 = "XQTB";
										}
									}
								}
								else
								{
									class58_1.method_241(text, 2);
								}
							}
							else if (class58_1.class114_0.bool_186)
							{
								if (text.Contains("SDJZH_20100823_23"))
								{
									class58_1.class114_0.string_12 = "D999DH";
								}
								else if (text.Contains("SDJZH_xml_XX(11)"))
								{
									class58_1.class114_0.string_12 = "CHH";
								}
								else if (text.Contains("SDJZH_091106_10"))
								{
									class58_1.class114_0.string_12 = "DHHTC";
								}
								else if (text.Contains("SDJZH_091106_30"))
								{
									class58_1.class114_0.string_12 = "HHHR";
								}
							}
							else if (class58_1.class114_0.bool_196)
							{
								if (text.Contains("JBLC_150528_36"))
								{
									class58_1.class114_0.string_12 = "KBTC";
								}
							}
							else if (class58_1.class114_0.bool_185 && text.Contains("QCBF_20151119") && text.Contains(class58_1.class114_0.string_3))
							{
								class58_1.class75_0.long_59 = Class101.smethod_61() + 20000L;
								class58_1.class75_0.int_56++;
								if (class58_1.class75_0.int_56 >= 6)
								{
									class58_1.class75_0.int_56 = 0;
								}
							}
						}
						else
						{
							if ((text.Contains("ã hoàn th") || text.Contains("finish")) && class58_1.class114_0.MapID == 1)
							{
								class58_1.class75_0.long_5 = 0L;
								if (class58_1.class114_0.bool_155)
								{
									class58_1.class75_0.int_1++;
									Class83.smethod_66(frmMain.String_486, class58_1, new object[]
									{
										class58_1.class75_0.int_1
									});
								}
								else if (class58_1.class114_0.bool_156)
								{
									class58_1.class75_0.int_2++;
									Class83.smethod_66(frmMain.String_485, class58_1, new object[]
									{
										class58_1.class75_0.int_2
									});
								}
							}
							if (text.Contains("uay lại nhậ"))
							{
								class58_1.class114_0.string_12 = "NVFQ";
							}
							else if (text.Contains("ITEM40004315}"))
							{
								class58_1.class114_0.string_12 = "CDDLB";
							}
							if (class58_1.class114_0.bool_155)
							{
								if (!text.Contains("ng Quân Đô Thống: 1/1") && !text.Contains("ear Knight: 1/1"))
								{
									if (!text.Contains("ng binh: 50/50") && !text.Contains("ong Soldier: 50/50"))
									{
										if (text.Contains("ộc: 1/1") || text.Contains("ider Yu: 1/1"))
										{
											class58_1.class114_0.string_12 = "TDDD";
										}
									}
									else
									{
										class58_1.class114_0.string_12 = "DXNTB";
									}
								}
								else
								{
									class58_1.class114_0.string_12 = "DDQDT";
								}
								if (text.Contains("oại: 10/10") || text.Contains("ng Gangsters: 10/10"))
								{
									class58_1.class114_0.string_12 = "DDPL";
								}
							}
							if (class58_1.class114_0.bool_156)
							{
								if (!text.Contains("ùng: 80/80") && !text.Contains("d Bear: 80/80"))
								{
									if (text.Contains("ơng: 1/1") || text.Contains("ar King: 1/1"))
									{
										class58_1.class114_0.string_12 = "DDHV";
									}
								}
								else
								{
									class58_1.class114_0.string_12 = "DDDH";
								}
							}
						}
						if (class58_1.class114_0.MapID == 1)
						{
							if (Class83.smethod_116((double)class58_1.class114_0.float_0, (double)class58_1.class114_0.float_5, 133.0, 260.0) <= 10.0)
							{
								if (text.Contains("ất ti") && text.Contains("hất b"))
								{
									class58_1.class114_0.string_12 = "NVTB";
								}
								else if (text.Contains("àm thế nà") || text.Contains("ou do this missio"))
								{
									class58_1.class114_0.string_12 = "DGXQ";
								}
							}
							if (Class83.smethod_116((double)class58_1.class114_0.float_0, (double)class58_1.class114_0.float_5, 353.0, 203.0) <= 10.0)
							{
								if ((text.Contains("ất ti") && text.Contains("hất b")) || text.Contains("on was failed"))
								{
									class58_1.class114_0.string_12 = "NVTB";
								}
								else if (text.Contains("àm thế nà") || text.Contains("ou do this missio") || text.Contains("your mission"))
								{
									class58_1.class114_0.string_12 = "DGXQ";
								}
							}
						}
						if (class58_1.class59_0.int_2 == 3 && class58_1.class59_0.int_11 == 4 && Class83.smethod_118(class58_1.class114_0.MapID, null) && text.Contains("- Tô Châu") && text.Contains("- Thiết tường phố"))
						{
							class58_1.class114_0.string_12 = "MNKC";
						}
						if (text.Contains("QZDZ_100715_05") || text.Contains("CLCZ_101207_09"))
						{
							object object_ = class58_1.class114_0.object_0;
							lock (object_)
							{
								class58_1.class114_0.long_94 = frmLogin.stopwatch_0.ElapsedMilliseconds;
								class58_1.class114_0.bool_45 = true;
								class58_1.class114_0.stopwatch_10.Reset();
								class58_1.class114_0.stopwatch_10.Start();
								class58_1.method_365(1);
							}
						}
						if ((text.Contains("ội hữu củ") || text2.Contains("µi hæu cü") || text.Contains("ãy tập t") || text2.Contains("ãy t§p t")) && class58_1.method_338())
						{
							class58_1.method_360();
							Class83.smethod_104(class58_1, true, true);
						}
						if (text.Contains("chọn địa điểm định vị"))
						{
							class58_1.class114_0.string_12 = "TLCCDV";
						}
						if (Class83.smethod_122() && new Random().Next(0, 10000) <= 7000)
						{
							class58_1.class114_0.string_12 = "";
							return;
						}
						return;
					}
					else
					{
						i++;
					}
				}
				goto IL_74;
			}
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00084EA4 File Offset: 0x000830A4
		internal static void smethod_10(Class58 class58_1, int int_6, int int_7)
		{
			byte b = class58_1.class59_0.byte_1[10];
			int num = 16;
			byte b2 = class58_1.class59_0.byte_1[12];
			if (class58_1.class114_0.bool_64 && b > 0)
			{
				for (int i = 0; i < (int)b; i++)
				{
					int num2 = (int)class58_1.class59_0.byte_1[num + 5];
					int num3 = BitConverter.ToInt32(class58_1.class59_0.byte_1, num + 9);
					bool flag = false;
					if (num3 <= class58_1.class114_0.int_113)
					{
						if (num3 <= class58_1.autoSettings_0.txtKNB50 && class58_1.autoSettings_0.txtKNB50 > 0 && num2 == 50)
						{
							flag = true;
						}
						if (!flag && num3 <= class58_1.autoSettings_0.txtKNB200 && class58_1.autoSettings_0.txtKNB200 > 0 && num2 == 200)
						{
							flag = true;
						}
						if (!flag && num3 <= class58_1.autoSettings_0.txtKNB500 && class58_1.autoSettings_0.txtKNB500 > 0 && num2 == 500)
						{
							flag = true;
						}
					}
					if (flag)
					{
						class58_1.class114_0.long_43 = frmLogin.stopwatch_0.ElapsedMilliseconds;
						return;
					}
					num += 17;
				}
			}
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00084FE0 File Offset: 0x000831E0
		internal static void smethod_11(Class58 class58_1, int int_6, int int_7)
		{
			if (class58_1.class114_0 != null && class58_1.class118_0 != null && class58_1.class116_0 != null && (int_6 == 17 || (int_6 == 24 && class58_1.class59_0.int_2 == 3) || (int_6 == 24 && class58_1.class59_0.int_2 == 4)))
			{
				int num = BitConverter.ToInt32(class58_1.class59_0.byte_1, 6);
				int num2 = BitConverter.ToInt32(class58_1.class59_0.byte_1, 16);
				int num3 = (int)BitConverter.ToInt16(class58_1.class59_0.byte_1, 14);
				if (Class83.smethod_61(class58_1.class59_0.int_2) >= 360)
				{
					num3 = BitConverter.ToInt32(class58_1.class59_0.byte_1, 14);
					num2 = BitConverter.ToInt32(class58_1.class59_0.byte_1, 18);
				}
				if (num3 == 1016)
				{
					class58_1.class75_0.long_20 = frmLogin.stopwatch_0.ElapsedMilliseconds;
					class58_1.method_194(-1, 34, 0, 0, false, false);
					int num4 = class58_1.method_209();
					class58_1.method_194(-1, num4, 0, 0, false, false);
					if (frmLogin.stopwatch_0.ElapsedMilliseconds - class58_1.class75_0.long_20 >= 60000L && class58_1.class75_0.long_20 > 0L)
					{
						class58_1.class75_0.long_20 = 0L;
					}
				}
				if (num != 0)
				{
					bool flag = false;
					bool flag2 = false;
					if (class58_1.class114_0.int_9 == num)
					{
						flag = true;
					}
					if (class58_1.class114_0.int_57 == num)
					{
						class58_1.class114_0.int_14 = num2;
						class58_1.class114_0.long_5 = frmLogin.stopwatch_0.ElapsedMilliseconds;
					}
					if (!flag && class58_1.class116_0.Int32_1 == num)
					{
						flag2 = true;
					}
					if ((flag2 || flag) && num2 >= 0 && class58_1.class118_0.list_1.Count > 0)
					{
						for (int i = class58_1.class118_0.list_1.Count - 1; i >= 0; i--)
						{
							if (class58_1.class118_0.list_1[i].int_0 == num2)
							{
								try
								{
									class58_1.class118_0.list_1[i].byte_9 = 1;
									class58_1.class118_0.list_1[i].long_0 = frmLogin.stopwatch_0.ElapsedMilliseconds;
								}
								catch (Exception)
								{
								}
								class58_1.class118_0.list_1[i].long_1 = frmLogin.stopwatch_0.ElapsedMilliseconds;
								return;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00085264 File Offset: 0x00083464
		internal static void smethod_12(Class58 class58_1, int int_6, int int_7)
		{
			int num = BitConverter.ToInt32(class58_1.class59_0.byte_1, 6);
			int num2 = (int)class58_1.class59_0.byte_1[10];
			if (class58_1.class108_0 != null && num != 0)
			{
				class58_1.class108_0.int_2 = num2;
				class58_1.class108_0.int_3 = num;
				class58_1.class108_0.long_0 = frmLogin.stopwatch_0.ElapsedMilliseconds;
				int num3 = 11;
				int num4 = num3 + 57;
				int num5 = BitConverter.ToInt32(class58_1.class59_0.byte_1, 13);
				class58_1.class108_0.list_3.Clear();
				for (int i = 0; i < num2; i++)
				{
					bool flag = false;
					while (!flag)
					{
						if (num4 <= int_7 - 4)
						{
							int num6 = BitConverter.ToInt32(class58_1.class59_0.byte_1, num4);
							if (num6 != num5)
							{
								if (Class83.smethod_61(class58_1.class59_0.int_2) < 360 || num6 != num5 + i + 1)
								{
									num4++;
									continue;
								}
							}
							flag = true;
						}
						else
						{
							num4++;
							flag = true;
						}
					}
					Array.Clear(class58_1.class59_0.byte_2, 0, class58_1.class59_0.byte_2.Length);
					Array.Copy(class58_1.class59_0.byte_1, num3, class58_1.class59_0.byte_2, 0, num4 - num3);
					num3 = num4;
					num4 = num3 + 57;
					int num7 = BitConverter.ToInt32(class58_1.class59_0.byte_2, 2);
					int num8 = BitConverter.ToInt32(class58_1.class59_0.byte_2, 6);
					int num9 = BitConverter.ToInt32(class58_1.class59_0.byte_2, 10);
					if (i > 0)
					{
						num7 = BitConverter.ToInt32(class58_1.class59_0.byte_2, 0);
						num8 = BitConverter.ToInt32(class58_1.class59_0.byte_2, 4);
						num9 = BitConverter.ToInt32(class58_1.class59_0.byte_2, 8);
					}
					class58_1.class108_0.int_2 = num2;
					class58_1.class108_0.int_3 = num;
					Class111 @class = new Class111();
					@class.int_0 = num7;
					@class.int_1 = num8;
					@class.int_2 = num9;
					class58_1.class108_0.long_0 = frmLogin.stopwatch_0.ElapsedMilliseconds;
					class58_1.class108_0.list_3.Add(@class);
				}
			}
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0000496D File Offset: 0x00002B6D
		internal static void smethod_13(Class58 class58_1, int int_6, int int_7)
		{
			if (int_6 == 0 && class58_1.class114_0 != null)
			{
				class58_1.class114_0.byte_0 = 1;
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00085490 File Offset: 0x00083690
		internal static void smethod_14(Class58 class58_1, int int_6, int int_7)
		{
			if (class58_1.class126_0 != null)
			{
				int int_8 = BitConverter.ToInt32(class58_1.class59_0.byte_1, 6);
				int num = 0;
				if (Class83.smethod_61(class58_1.class59_0.int_2) >= 360)
				{
					num = 4;
					class58_1.class126_0.int_12 = BitConverter.ToInt32(class58_1.class59_0.byte_1, 10);
				}
				int int_9;
				if (class58_1.class59_0.int_2 != 3)
				{
					if (class58_1.class59_0.int_2 != 4)
					{
						int_9 = (int)class58_1.class59_0.byte_1[42 + num];
						goto IL_95;
					}
				}
				int_9 = (int)class58_1.class59_0.byte_1[40];
				IL_95:
				int num2 = (int)class58_1.class59_0.byte_1[44 + num];
				if (class58_1.class59_0.int_2 == 3 || class58_1.class59_0.int_2 == 4)
				{
					num2 = (int)class58_1.class59_0.byte_1[42];
				}
				int num3 = 44 + num2 + 7;
				if (class58_1.class59_0.int_2 == 3 || class58_1.class59_0.int_2 == 4)
				{
					num3 = 42 + num2 + 7;
				}
				int int_10 = (int)class58_1.class59_0.byte_1[num3 + num];
				class58_1.class126_0.int_11 = int_8;
				class58_1.class126_0.long_0 = frmLogin.stopwatch_0.ElapsedMilliseconds;
				class58_1.class126_0.int_13 = int_9;
				class58_1.class126_0.int_14 = int_10;
				int num4 = 0;
				byte[] array = new byte[30];
				int num5 = 10 + num;
				int num6 = num5;
				while (num6 < 40 && class58_1.class59_0.byte_1[num6] != 0)
				{
					array[num6 - num5] = class58_1.class59_0.byte_1[num6];
					num4++;
					num6++;
				}
				class58_1.class126_0.string_1 = Class83.smethod_142(array, 0, num4);
			}
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x0008564C File Offset: 0x0008384C
		internal static void smethod_15(Class58 class58_1, int int_6, int int_7)
		{
			if (class58_1.class114_0 != null)
			{
				try
				{
					if (BitConverter.ToInt32(class58_1.class59_0.byte_1, 6) == class58_1.class114_0.int_9)
					{
						float num;
						float num2;
						if (class58_1.class59_0.int_2 == 3)
						{
							num = BitConverter.ToSingle(class58_1.class59_0.byte_1, 10);
							num2 = BitConverter.ToSingle(class58_1.class59_0.byte_1, 14);
						}
						else if (Class83.smethod_61(class58_1.class59_0.int_2) >= 360)
						{
							num = BitConverter.ToSingle(class58_1.class59_0.byte_1, 15);
							num2 = BitConverter.ToSingle(class58_1.class59_0.byte_1, 19);
						}
						else
						{
							num = BitConverter.ToSingle(class58_1.class59_0.byte_1, 12);
							num2 = BitConverter.ToSingle(class58_1.class59_0.byte_1, 16);
						}
						if (class58_1.class114_0.float_19 == num && class58_1.class114_0.float_20 == num2)
						{
							class58_1.class114_0.bool_126 = true;
							class58_1.class114_0.long_82 = frmLogin.stopwatch_0.ElapsedMilliseconds;
							class58_1.class114_0.long_88 = frmLogin.stopwatch_0.ElapsedMilliseconds;
						}
						if (class58_1.class114_0.float_19 != num || class58_1.class114_0.float_20 != num2)
						{
							class58_1.class114_0.float_19 = num;
							class58_1.class114_0.float_20 = num2;
							class58_1.class114_0.long_88 = frmLogin.stopwatch_0.ElapsedMilliseconds;
						}
					}
				}
				catch (Exception ex)
				{
					if (!class58_1.class59_0.bool_9)
					{
						Class83.smethod_66(frmMain.String_484 + ex.Message + " Stack: " + ex.StackTrace.ToString(), class58_1, new object[0]);
					}
					class58_1.class59_0.bool_9 = true;
				}
			}
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00085830 File Offset: 0x00083A30
		internal static void smethod_16(Class58 class58_1, int int_6, int int_7)
		{
			if (class58_1.class118_0 != null)
			{
				int num = -1;
				num = BitConverter.ToInt32(class58_1.class59_0.byte_1, 7);
				if (class58_1.class59_0.int_2 == 3 || class58_1.class59_0.int_2 == 4 || class58_1.class59_0.int_2 == 5 || class58_1.class59_0.int_2 == 6)
				{
					num = BitConverter.ToInt32(class58_1.class59_0.byte_1, 6);
				}
				if (num >= 0)
				{
					if (int_6 >= 84)
					{
						int num2 = -1;
						int num3 = -1;
						int num4 = -1;
						int num5 = -1;
						if (class58_1.class59_0.int_2 == 3 || class58_1.class59_0.int_2 == 4)
						{
							num2 = (int)class58_1.class59_0.byte_1[22];
							int num6 = 22 + num2;
							num3 = 23;
							num4 = (int)class58_1.class59_0.byte_1[num6 + 4];
							num5 = (int)class58_1.class59_0.byte_1[num6 + 49];
						}
						if (Class83.smethod_61(class58_1.class59_0.int_2) >= 360)
						{
							num2 = (int)class58_1.class59_0.byte_1[29];
							int num6 = 29 + num2;
							num3 = 30;
							num4 = (int)class58_1.class59_0.byte_1[num6 + 4];
							num5 = (int)class58_1.class59_0.byte_1[num6 + 49 + 11];
						}
						if (class58_1.class59_0.int_2 == 7 || class58_1.class59_0.int_2 == 8)
						{
							num2 = (int)class58_1.class59_0.byte_1[29];
							num3 = 30;
							int num6 = 29 + num2;
							num4 = (int)class58_1.class59_0.byte_1[num6 + 4 + 3];
							num5 = (int)class58_1.class59_0.byte_1[num6 + 49 + 11 + 3];
						}
						byte[] array = new byte[260];
						int num7 = 0;
						for (int i = num3; i < num3 + num2; i++)
						{
							array[num7] = class58_1.class59_0.byte_1[i];
							num7++;
						}
						string text = Class83.smethod_142(array, 0, num2);
						if (class58_1.class114_0.bool_185)
						{
							if ((text == "Ruy Băng" || text == "Socola" || text == "Gấu Con" || text == "Bóng Màu" || text == "Kẹo" || text == "Táo") && class58_1.class75_0.long_59 > Class101.smethod_61() + 1000L)
							{
								class58_1.class75_0.long_59 = Class101.smethod_61() + 1000L;
							}
							if (text.Contains("Cây Thông"))
							{
								class58_1.class75_0.int_57 = num;
							}
						}
						if (class58_1.method_352(num5))
						{
							if (class58_1.autoSettings_0.cboxDanhQuai && class58_1.IsAIEnabled && !class58_1.class114_0.bool_32 && !Class83.smethod_117(class58_1.class114_0.MapID, class58_1) && class58_1.class114_0.Status != Class57.Enum13.const_8 && class58_1.class114_0.Status != Class57.Enum13.const_11 && class58_1.class114_0.Status != Class57.Enum13.const_9 && (class58_1.autoSettings_0.FightMode == Class57.FightingModes.DANHGOMQUAI || class58_1.class118_0.list_1.Count <= 1) && class58_1.class114_0.ActionStatus != 5 && (class58_1.autoSettings_0.AIMode == Class57.AIModes.DANHQUANHDIEM || class58_1.autoSettings_0.AIMode == Class57.AIModes.DANHTUDO))
							{
								bool flag = true;
								if (class58_1.autoSettings_0.QuaiNoAttackList.Count > 0)
								{
									for (int j = 0; j < class58_1.autoSettings_0.QuaiNoAttackList.Count; j++)
									{
										if (text == class58_1.autoSettings_0.QuaiNoAttackList[j])
										{
											flag = false;
											break;
										}
									}
								}
								if ((class58_1.class59_0.int_2 == 1 || class58_1.class59_0.int_2 == 2) && class58_1.class114_0.int_26 < 20000)
								{
									flag = false;
								}
								if (class58_1.class114_0.long_100 - frmLogin.stopwatch_0.ElapsedMilliseconds > 0L)
								{
									flag = false;
								}
								if (flag)
								{
									if (class58_1.autoSettings_0.cboxOnlyPet && class58_1.method_34())
									{
										class58_1.method_196(class58_1.class114_0.int_9, -1, num, 0, 0, false);
									}
									else
									{
										class58_1.method_194(num, class58_1.class120_0.list_4[0].int_0, 0, 0, false, false);
									}
									class58_1.method_104(num);
								}
							}
							bool flag2 = false;
							if (class58_1.class118_0.list_1.Count > 0)
							{
								for (int k = class58_1.class118_0.list_1.Count - 1; k >= 0; k--)
								{
									if (class58_1.class118_0.list_1[k].int_0 == num)
									{
										class58_1.class118_0.list_1[k].float_4 = (float)num4;
										class58_1.class118_0.list_1[k].bool_0 = false;
										try
										{
											class58_1.class118_0.list_1[k].byte_9 = 0;
										}
										catch (Exception)
										{
										}
										class58_1.class118_0.list_1[k].byte_0 = (byte)num5;
										class58_1.class118_0.list_1[k].string_0 = text;
										flag2 = true;
										break;
									}
								}
							}
							if (!flag2)
							{
								Class119 @class = new Class119();
								@class.int_0 = num;
								@class.float_4 = (float)num4;
								@class.bool_0 = false;
								try
								{
									@class.byte_9 = 0;
								}
								catch (Exception)
								{
								}
								@class.byte_0 = (byte)num5;
								@class.long_1 = frmLogin.stopwatch_0.ElapsedMilliseconds;
								class58_1.class118_0.list_1.Add(@class);
								return;
							}
						}
					}
					else if (!Class83.smethod_118(class58_1.class114_0.MapID, null) && !Class83.smethod_132(class58_1.class114_0.MapID))
					{
						int num8 = (int)class58_1.class59_0.byte_1[15];
						if (class58_1.class59_0.int_2 == 3 || class58_1.class59_0.int_2 == 4)
						{
							num8 = (int)class58_1.class59_0.byte_1[18];
						}
						if (class58_1.class59_0.int_2 == 5 || class58_1.class59_0.int_2 == 6)
						{
							num8 = (int)class58_1.class59_0.byte_1[21];
						}
						if (num >= 0 && num <= 10000 && num8 == 100)
						{
							if (class58_1.autoSettings_0.cboxDanhQuai && class58_1.IsAIEnabled && !class58_1.class114_0.bool_32 && !Class83.smethod_117(class58_1.class114_0.MapID, class58_1) && class58_1.class114_0.Status != Class57.Enum13.const_8 && class58_1.class114_0.Status != Class57.Enum13.const_11 && class58_1.class114_0.Status != Class57.Enum13.const_9 && (class58_1.autoSettings_0.FightMode == Class57.FightingModes.DANHGOMQUAI || (class58_1.class118_0.list_1.Count <= 1 && class58_1.autoSettings_0.QuaiNoAttackList.Count == 0)) && class58_1.class114_0.ActionStatus != 5 && (class58_1.autoSettings_0.AIMode == Class57.AIModes.DANHQUANHDIEM || class58_1.autoSettings_0.AIMode == Class57.AIModes.DANHTUDO))
							{
								if (class58_1.autoSettings_0.cboxOnlyPet && class58_1.method_34())
								{
									class58_1.method_196(class58_1.class114_0.int_9, -1, num, 0, 0, false);
								}
								else
								{
									class58_1.method_194(num, class58_1.class120_0.list_4[0].int_0, 0, 0, false, false);
								}
								class58_1.method_104(num);
							}
							bool flag3 = false;
							if (class58_1.class118_0.list_1.Count > 0)
							{
								for (int l = class58_1.class118_0.list_1.Count - 1; l >= 0; l--)
								{
									if (class58_1.class118_0.list_1[l].int_0 == num)
									{
										flag3 = true;
										break;
									}
								}
							}
							if (!flag3)
							{
								Class119 class2 = new Class119();
								class2.int_0 = num;
								class2.float_4 = (float)num8;
								class2.bool_0 = false;
								try
								{
									class2.byte_9 = 0;
								}
								catch (Exception)
								{
								}
								class2.byte_0 = 29;
								class2.long_1 = frmLogin.stopwatch_0.ElapsedMilliseconds;
								class58_1.class118_0.list_1.Add(class2);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x000860A0 File Offset: 0x000842A0
		internal static void smethod_17(Class58 class58_1, int int_6, int int_7)
		{
			if (int_6 == 578 || (int_6 == 577 && (class58_1.class59_0.int_2 == 3 || class58_1.class59_0.int_2 == 4)))
			{
				byte b = class58_1.class59_0.byte_1[583];
				int num = 7;
				int num2 = 583;
				if (!class58_1.class75_0.Boolean_0 && class58_1.gclass2_0 != null)
				{
					if (class58_1.class59_0.int_2 == 3)
					{
						b = 0;
						num = 7;
						num2 = 583;
					}
					byte[] array = new byte[577];
					for (int i = num; i <= num2; i++)
					{
						array[i - num] = class58_1.class59_0.byte_1[i] - b;
					}
					string string_ = Class83.smethod_36(array);
					PictureBox pictureBox = new PictureBox();
					Class83.smethod_43(string_, pictureBox);
					class58_1.gclass2_0.imgCaptcha = pictureBox.Image;
				}
			}
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00086180 File Offset: 0x00084380
		internal static void smethod_18(Class58 class58_1, int int_6, int int_7)
		{
			if (int_6 == 6)
			{
				int int_8 = BitConverter.ToInt32(class58_1.class59_0.byte_1, 6);
				Class101.smethod_20(class58_1, int_8, 0);
				return;
			}
			if (class58_1.class59_0.int_2 != 7)
			{
				if (class58_1.class59_0.int_2 != 8)
				{
					if (Class83.smethod_61(class58_1.class59_0.int_2) < 360)
					{
						return;
					}
					int num = (int)class58_1.class59_0.byte_1[6];
					if (num >= 1)
					{
						int num2 = 7;
						for (int i = 0; i < num; i++)
						{
							int int_8 = BitConverter.ToInt32(class58_1.class59_0.byte_1, num2 + i * 4);
							Class101.smethod_20(class58_1, int_8, 0);
						}
						return;
					}
					return;
				}
			}
			int num3 = BitConverter.ToInt32(class58_1.class59_0.byte_1, 6);
			if (num3 >= 1)
			{
				int num4 = 10;
				for (int j = 0; j < num3; j++)
				{
					int int_8 = BitConverter.ToInt32(class58_1.class59_0.byte_1, num4 + j * 4);
					Class101.smethod_20(class58_1, int_8, 0);
				}
				return;
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00086274 File Offset: 0x00084474
		internal static void smethod_19(Class58 class58_1, int int_6, int int_7)
		{
			if (int_6 == 6)
			{
				int int_8 = BitConverter.ToInt32(class58_1.class59_0.byte_1, 6);
				Class101.smethod_20(class58_1, int_8, 0);
				return;
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x000862A4 File Offset: 0x000844A4
		private static void smethod_20(Class58 class58_1, int int_6, int int_7 = 0)
		{
			bool flag = true;
			if (class58_1.class108_0 != null && int_7 <= 1 && int_6 != 0)
			{
				int i = class58_1.class108_0.list_4.Count - 1;
				while (i >= 0)
				{
					if (class58_1.class108_0.list_4[i].int_1 == int_6)
					{
						if (!Class83.smethod_119())
						{
						}
						Class101.smethod_24(class58_1, i);
						flag = false;
						IL_5B:
						if (int_6 == class58_1.class108_0.int_3)
						{
							class58_1.class108_0.list_3.Clear();
							class58_1.class108_0.int_3 = 0;
							goto IL_85;
						}
						goto IL_85;
					}
					else
					{
						i--;
					}
				}
				goto IL_5B;
			}
			IL_85:
			if (int_7 == 0 || int_7 == 2)
			{
				if (class58_1.class118_0 != null && flag && class58_1.class118_0.list_1.Count > 0)
				{
					for (int j = class58_1.class118_0.list_1.Count - 1; j >= 0; j--)
					{
						if (class58_1.class118_0.list_1[j].int_0 == int_6)
						{
							class58_1.class118_0.list_1.RemoveAt(j);
							flag = false;
							break;
						}
					}
				}
				if (class58_1.class92_0 != null && flag && class58_1.class92_0.list_0.Count > 0)
				{
					for (int k = class58_1.class92_0.list_0.Count - 1; k >= 0; k--)
					{
						if (class58_1.class92_0.list_0[k].int_0 == int_6)
						{
							class58_1.class92_0.list_0.RemoveAt(k);
							return;
						}
					}
				}
			}
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00086418 File Offset: 0x00084618
		internal static void smethod_21(Class58 class58_1, int int_6, int int_7)
		{
			if (int_6 >= 813)
			{
				bool flag = false;
				int num = 15;
				int num2 = 0;
				for (int i = 0; i < 12; i++)
				{
					class58_1.list_0[i].int_0 = -1;
					class58_1.list_0[i].int_2 = 0;
					class58_1.list_0[i].int_1 = 0;
				}
				while (!flag)
				{
					int num3 = BitConverter.ToInt32(class58_1.class59_0.byte_1, num + 20 * num2);
					int num4 = BitConverter.ToInt32(class58_1.class59_0.byte_1, num + 20 * num2 + 8);
					int num5 = BitConverter.ToInt32(class58_1.class59_0.byte_1, num + 20 * num2 + 16);
					if (num3 == 0)
					{
						flag = true;
					}
					else
					{
						class58_1.list_0[num2].int_0 = num3;
						class58_1.list_0[num2].int_2 = num4;
						class58_1.list_0[num2].int_1 = num5;
						num2++;
						if (num2 >= 12)
						{
							flag = true;
						}
					}
				}
			}
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00086520 File Offset: 0x00084720
		internal static void smethod_22(Class58 class58_1, int int_6, int int_7)
		{
			if (class58_1.class59_0.byte_1[6] == 10 && class58_1.class59_0.byte_1[7] == 8)
			{
				class58_1.class114_0.long_4 = frmLogin.stopwatch_0.ElapsedMilliseconds + 29000L;
				return;
			}
			if (class58_1.class59_0.byte_1[6] == 0 && class58_1.class59_0.byte_1[7] == 4)
			{
				class58_1.class114_0.long_4 = frmLogin.stopwatch_0.ElapsedMilliseconds + 59000L;
				return;
			}
			if (class58_1.class59_0.byte_1[31] == 208 && class58_1.class59_0.byte_1[32] == 181 && class58_1.class59_0.byte_1[33] == 105 && frmLogin.class101_0.globalSettings_0.DongYPhuDoi)
			{
				Thread.Sleep(500);
				class58_1.method_122(31, -1);
			}
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00086608 File Offset: 0x00084808
		internal static void smethod_23(Class58 class58_1, int int_6, int int_7)
		{
			if (class58_1.class114_0.bool_195 && class58_1.IsAIEnabled)
			{
				string text = Class83.smethod_142(class58_1.class59_0.byte_1, 0, int_7);
				string a = Class83.smethod_83(text, "#{", "}", 1, 1);
				if (!(a == "MZPVE_150812_80") && !(a == "MZPVE_150812_1577") && !(a == "MZPVE_150812_831") && !(a == "MZPVE_150812_1203") && !(a == "MZPVE_150812_1950"))
				{
					text.Contains("MZPVE_150812_363");
				}
				else
				{
					string string_ = Class83.smethod_83(text, "*", "\0", 2, 1);
					class58_1.method_241(string_, 1);
				}
				if (Class83.smethod_119() && class58_1.autoSettings_0.cboxDebugLog)
				{
					text = text.Replace("Ầ", "");
					text = text.Replace("Ẵ", "");
					text = text.Replace("Ẳ", "");
					text = text.Replace("Ù", "");
					text = text.Replace("Ố", "");
					text = text.Replace("Ớ", "");
					text = text.Replace("Ữ", "");
					text = text.Replace("Ự", "");
					text = text.Replace("Ẫ", "");
					text = text.Replace("\r", "");
					text = text.Replace("\0", "");
					text = text.Replace("{", "{{");
					text = text.Replace("}", "}}");
					Class83.smethod_66("PacketThongThien: " + text, class58_1, new object[0]);
					return;
				}
			}
			else if (class58_1.class59_0.byte_1[41] == 67 && class58_1.class59_0.byte_1[42] == 97 && class58_1.class59_0.byte_1[43] == 108)
			{
				if (frmLogin.class101_0.globalSettings_0.DongYPhuDoi)
				{
					Thread.Sleep(500);
					class58_1.method_122(31, -1);
					return;
				}
			}
			else if (Class83.smethod_142(class58_1.class59_0.byte_1, 0, int_7).Contains("CallMe") && frmLogin.class101_0.globalSettings_0.DongYPhuDoi)
			{
				Thread.Sleep(500);
				class58_1.method_122(31, -1);
			}
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0008686C File Offset: 0x00084A6C
		internal static void smethod_24(Class58 class58_1, int int_6)
		{
			class58_1.class114_0.bool_22 = false;
			if (class58_1.class108_0 != null && int_6 < class58_1.class108_0.list_4.Count)
			{
				if (class58_1.class108_0.list_4[int_6].int_1 == class58_1.class108_0.int_3)
				{
					class58_1.class108_0.int_3 = 0;
					class58_1.class108_0.long_0 = 0L;
					class58_1.class108_0.float_0 = 0f;
					class58_1.class108_0.float_1 = 0f;
				}
				bool flag = true;
				if (class58_1.class108_0.list_1.Count > 0)
				{
					for (int i = 0; i < class58_1.class108_0.list_1.Count; i++)
					{
						if (class58_1.class108_0.list_1[i].int_1 == class58_1.class108_0.list_4[int_6].int_1)
						{
							class58_1.class108_0.list_1[i].float_0 = class58_1.class108_0.list_4[int_6].float_0;
							class58_1.class108_0.list_1[i].float_1 = class58_1.class108_0.list_4[int_6].float_1;
							class58_1.class108_0.list_1[i].long_0 = class58_1.class108_0.list_4[int_6].long_0;
							flag = false;
							break;
						}
					}
				}
				if (flag)
				{
					int index = 0;
					long maxValue = long.MaxValue;
					if (class58_1.class108_0.list_1.Count >= 50)
					{
						for (int j = 0; j < class58_1.class108_0.list_1.Count; j++)
						{
							if (class58_1.class108_0.list_1[j].long_0 < maxValue)
							{
								maxValue = class58_1.class108_0.list_1[j].long_0;
								index = j;
							}
						}
						class58_1.class108_0.list_1.RemoveAt(index);
					}
					Class109 @class = new Class109();
					@class.int_1 = class58_1.class108_0.list_4[int_6].int_1;
					@class.float_0 = class58_1.class108_0.list_4[int_6].float_0;
					@class.float_1 = class58_1.class108_0.list_4[int_6].float_1;
					@class.long_0 = class58_1.class108_0.list_4[int_6].long_0;
					class58_1.class108_0.list_1.Add(@class);
				}
				class58_1.class108_0.list_4.RemoveAt(int_6);
			}
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00086B1C File Offset: 0x00084D1C
		internal static void smethod_25(Class58 class58_1, int int_6, int int_7)
		{
			if (class58_1 != null && BitConverter.ToInt32(class58_1.class59_0.byte_1, 6) == class58_1.class114_0.int_9)
			{
				float num = BitConverter.ToSingle(class58_1.class59_0.byte_1, 12);
				float num2 = BitConverter.ToSingle(class58_1.class59_0.byte_1, 16);
				if (Math.Abs(num - class58_1.class114_0.float_17) <= 1f && Math.Abs(num2 - class58_1.class114_0.float_18) <= 1f)
				{
					class58_1.class114_0.float_17 = num;
					class58_1.class114_0.float_18 = num2;
					class58_1.class114_0.bool_126 = true;
					class58_1.class114_0.long_82 = frmLogin.stopwatch_0.ElapsedMilliseconds;
				}
			}
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00086BE4 File Offset: 0x00084DE4
		internal static void smethod_26(Class58 class58_1, int int_6, int int_7)
		{
			if (class58_1 != null && class58_1.class126_0 != null)
			{
				int num = 0;
				if (Class83.smethod_61(class58_1.class59_0.int_2) >= 360)
				{
					num = 8;
					class58_1.class126_0.int_4 = BitConverter.ToInt32(class58_1.class59_0.byte_1, 6);
					class58_1.class126_0.int_5 = BitConverter.ToInt32(class58_1.class59_0.byte_1, 10);
					class58_1.class126_0.int_6 = BitConverter.ToInt32(class58_1.class59_0.byte_1, 14);
					class58_1.class126_0.int_7 = BitConverter.ToInt32(class58_1.class59_0.byte_1, 18);
				}
				else
				{
					class58_1.class126_0.int_4 = BitConverter.ToInt32(class58_1.class59_0.byte_1, 6);
					class58_1.class126_0.int_6 = BitConverter.ToInt32(class58_1.class59_0.byte_1, 10);
				}
				int num2 = (int)class58_1.class59_0.byte_1[14 + num];
				int num3 = (int)class58_1.class59_0.byte_1[15 + num];
				int num4 = 16 + num;
				if (num2 <= 30)
				{
					byte[] array = new byte[30];
					for (int i = num4; i < num4 + num2; i++)
					{
						array[i - num4] = class58_1.class59_0.byte_1[i];
					}
					class58_1.class126_0.string_0 = Class83.smethod_142(array, 0, num2);
				}
				num4 += num2;
				class58_1.class126_0.int_8 = BitConverter.ToInt32(class58_1.class59_0.byte_1, num4 + num3);
				num4 += num3 + 4;
				class58_1.class126_0.int_10 = BitConverter.ToInt32(class58_1.class59_0.byte_1, num4);
				class58_1.class126_0.int_9 = BitConverter.ToInt32(class58_1.class59_0.byte_1, int_7 - 4);
			}
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00086DA0 File Offset: 0x00084FA0
		internal static void smethod_27(Class58 class58_1, int int_6, int int_7)
		{
			if (class58_1 != null && class58_1.class126_0 != null)
			{
				int num = 0;
				if (Class83.smethod_61(class58_1.class59_0.int_2) >= 360)
				{
					num = 8;
					class58_1.class126_0.int_6 = BitConverter.ToInt32(class58_1.class59_0.byte_1, 6);
					class58_1.class126_0.int_7 = BitConverter.ToInt32(class58_1.class59_0.byte_1, 10);
					class58_1.class126_0.int_4 = BitConverter.ToInt32(class58_1.class59_0.byte_1, 14);
					class58_1.class126_0.int_5 = BitConverter.ToInt32(class58_1.class59_0.byte_1, 18);
				}
				else
				{
					class58_1.class126_0.int_6 = BitConverter.ToInt32(class58_1.class59_0.byte_1, 6);
					class58_1.class126_0.int_4 = BitConverter.ToInt32(class58_1.class59_0.byte_1, 10);
				}
				int num2 = (int)class58_1.class59_0.byte_1[14 + num];
				int num3 = (int)class58_1.class59_0.byte_1[15 + num];
				int num4 = 16 + num;
				if (num2 <= 30)
				{
					byte[] array = new byte[30];
					for (int i = num4; i < num4 + num2; i++)
					{
						array[i - num4] = class58_1.class59_0.byte_1[i];
					}
					class58_1.class126_0.string_0 = Class83.smethod_142(array, 0, num2);
				}
				num4 += num2;
				class58_1.class126_0.int_10 = BitConverter.ToInt32(class58_1.class59_0.byte_1, num4 + num3);
				num4 += num3 + 6;
				class58_1.class126_0.int_8 = BitConverter.ToInt32(class58_1.class59_0.byte_1, num4);
				class58_1.class126_0.int_9 = BitConverter.ToInt32(class58_1.class59_0.byte_1, int_7 - 4);
			}
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00086F5C File Offset: 0x0008515C
		internal static void smethod_28(Class58 class58_1, int int_6, int int_7)
		{
			if (int_6 >= 100 || (int_6 >= 68 && class58_1.class59_0.int_2 == 3) || (int_6 >= 96 && (class58_1.class59_0.int_2 == 5 || class58_1.class59_0.int_2 == 6)) || (int_6 >= 100 && Class83.smethod_61(class58_1.class59_0.int_2) >= 360))
			{
				int num = BitConverter.ToInt32(class58_1.class59_0.byte_1, 12);
				int num2 = BitConverter.ToInt32(class58_1.class59_0.byte_1, 16);
				int num3 = BitConverter.ToInt32(class58_1.class59_0.byte_1, 20);
				byte b = class58_1.class59_0.byte_1[44];
				byte b2 = class58_1.class59_0.byte_1[24];
				List<int> list = new List<int>();
				if (b2 == 22)
				{
					for (int i = 0; i < (int)b; i++)
					{
						int item = (int)BitConverter.ToInt16(class58_1.class59_0.byte_1, 45 + 2 * i);
						list.Add(item);
					}
				}
				byte byte_ = class58_1.class59_0.byte_1[(int)(45 + (b - 1) * 2 + 29)];
				int j = 0;
				while (j < 30)
				{
					if (class58_1.class112_0.list_1[j].int_0 == num3 && class58_1.class112_0.list_1[j].int_4 == num && class58_1.class112_0.list_1[j].int_5 == num2)
					{
						class58_1.class112_0.list_1[j].byte_1 = b;
						class58_1.class112_0.list_1[j].enum7_0 = (Class57.Enum7)b2;
						class58_1.class112_0.list_1[j].byte_2 = byte_;
						class58_1.class112_0.list_1[j].int_6 = num3;
						if (list.Count > 0)
						{
							for (int k = 0; k < list.Count; k++)
							{
								int item2 = list[k];
								class58_1.class112_0.list_1[j].list_0.Add(item2);
							}
							return;
						}
						break;
					}
					else
					{
						j++;
					}
				}
			}
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00087188 File Offset: 0x00085388
		internal static void smethod_29(Class58 class58_1)
		{
			if (class58_1.class116_0 != null)
			{
				if (class58_1.class116_0.bool_2 && class58_1.class75_0.bool_25 && frmLogin.stopwatch_0.ElapsedMilliseconds - class58_1.class116_0.long_0 >= 15000L)
				{
					class58_1.class116_0.bool_2 = false;
				}
				if (!class58_1.class116_0.bool_3 && class58_1.class116_0.long_1 != 0L && class58_1.class75_0.bool_25 && frmLogin.stopwatch_0.ElapsedMilliseconds - class58_1.class116_0.long_1 >= 300000L)
				{
					try
					{
						class58_1.class116_0.long_1 = 0L;
						class58_1.class116_0.bool_3 = true;
					}
					catch (Exception)
					{
						if (Monitor.TryEnter(frmLogin.object_1, 2000))
						{
							class58_1.class116_0.long_1 = 0L;
							class58_1.class116_0.bool_3 = true;
							Monitor.Exit(frmLogin.object_1);
						}
					}
				}
			}
			if (class58_1.class114_0 != null)
			{
				if (class58_1.class75_0.bool_23 && class58_1.class75_0.int_34 > 0 && frmLogin.stopwatch_0.ElapsedMilliseconds - class58_1.class75_0.long_39 > (long)(class58_1.class75_0.int_34 * 60000) && class58_1.class75_0.long_39 > 0L)
				{
					class58_1.class75_0.bool_23 = false;
				}
				if (class58_1.class75_0.bool_26)
				{
					int int_ = 0;
					if (class58_1.class114_0.int_118 != -1)
					{
						Class101.smethod_35(class58_1, ref int_, class58_1.class114_0.int_118);
						class58_1.class114_0.int_13 = int_;
					}
					else
					{
						class58_1.class114_0.int_13 = 0;
					}
				}
				if (class58_1.class114_0.long_71 > 0L && class58_1.class114_0.bool_21 && class58_1.class75_0.bool_26 && frmLogin.stopwatch_0.ElapsedMilliseconds - class58_1.class114_0.long_71 >= 15000L)
				{
					class58_1.class114_0.long_71 = 0L;
					class58_1.class114_0.bool_21 = false;
				}
				if (class58_1.class114_0.bool_124 && frmLogin.stopwatch_0.ElapsedMilliseconds - class58_1.class114_0.long_81 >= 5000L)
				{
					class58_1.class114_0.bool_124 = false;
				}
				if (class58_1.class114_0.long_75 > 0L && class58_1.class114_0.bool_24 && frmLogin.stopwatch_0.ElapsedMilliseconds - class58_1.class114_0.long_75 >= 2000L)
				{
					class58_1.class114_0.long_75 = 0L;
					class58_1.class114_0.bool_24 = false;
				}
				if (class58_1.class114_0.int_23 == 1 && class58_1.class114_0.long_76 > 0L && frmLogin.stopwatch_0.ElapsedMilliseconds - class58_1.class114_0.long_76 >= 30000L)
				{
					class58_1.class114_0.long_76 = 0L;
					class58_1.class114_0.int_23 = 0;
					class58_1.class114_0.int_24 = 0;
				}
				if (frmLogin.stopwatch_0.ElapsedMilliseconds - class58_1.class114_0.long_77 >= 1200000L)
				{
					class58_1.class114_0.long_77 = frmLogin.stopwatch_0.ElapsedMilliseconds;
					if (class58_1.autoSettings_0.AcBaPhai != frmMain.String_427 && frmLogin.stopwatch_0.ElapsedMilliseconds - class58_1.autoSettings_0.AcBaPhaiStamp >= 3600000L)
					{
						class58_1.autoSettings_0.AcBaPhaiStamp = 0L;
						class58_1.autoSettings_0.AcBaPhai = frmMain.String_427;
					}
				}
				if (class58_1.class114_0.long_88 != 0L && frmLogin.stopwatch_0.ElapsedMilliseconds - class58_1.class114_0.long_88 >= 30000L)
				{
					class58_1.class114_0.long_88 = 0L;
					class58_1.class114_0.float_19 = 0f;
					class58_1.class114_0.float_20 = 0f;
				}
				if (class58_1.class114_0.long_82 != 0L && frmLogin.stopwatch_0.ElapsedMilliseconds - class58_1.class114_0.long_82 > 65000L && class58_1.class114_0.bool_126)
				{
					class58_1.class114_0.long_82 = 0L;
					class58_1.class114_0.bool_126 = false;
				}
			}
			if (class58_1.class108_0 != null && class58_1.class108_0.list_4.Count > 0 && frmLogin.stopwatch_0.ElapsedMilliseconds - class58_1.class114_0.long_70 >= 4000L)
			{
				class58_1.class114_0.long_70 = frmLogin.stopwatch_0.ElapsedMilliseconds;
				for (int i = class58_1.class108_0.list_4.Count - 1; i >= 0; i--)
				{
					Class109 @class = class58_1.class108_0.list_4[i];
					bool flag = false;
					if (@class.int_1 != 0 && @class.long_0 > 0L)
					{
						if (@class.int_2 == 5000 && frmLogin.stopwatch_0.ElapsedMilliseconds - @class.long_0 >= 62000L)
						{
							Class101.smethod_24(class58_1, i);
							flag = true;
						}
						if ((@class.int_2 == 808 || @class.int_2 == 807) && frmLogin.stopwatch_0.ElapsedMilliseconds - @class.long_0 >= 300000L)
						{
							Class101.smethod_24(class58_1, i);
							flag = true;
						}
					}
					if (!flag && Class83.smethod_116((double)@class.float_0, (double)@class.float_1, (double)class58_1.class114_0.float_0, (double)class58_1.class114_0.float_5) > frmLogin.class101_0.globalSettings_0.MaxDistance)
					{
						Class101.smethod_24(class58_1, i);
					}
				}
			}
			if (class58_1.class118_0 != null && class58_1.class114_0 != null)
			{
				if (class58_1.class114_0.enum13_4 != class58_1.class114_0.Status)
				{
					class58_1.class114_0.enum13_4 = class58_1.class114_0.Status;
					if (class58_1.class114_0.Status == Class57.Enum13.const_0)
					{
						class58_1.class114_0.long_92 = frmLogin.stopwatch_0.ElapsedMilliseconds;
					}
					else
					{
						class58_1.class114_0.long_92 = 0L;
					}
				}
				if (class58_1.class114_0.enum13_4 == class58_1.class114_0.Status && class58_1.class114_0.Status == Class57.Enum13.const_0 && frmLogin.stopwatch_0.ElapsedMilliseconds - class58_1.class114_0.long_92 >= 2000L && class58_1.class114_0.long_92 != 0L)
				{
					if (class58_1.class118_0.list_4.Count > 0)
					{
						class58_1.class118_0.list_4.Clear();
					}
					class58_1.class114_0.long_92 = 0L;
				}
				if (class58_1.class118_0.list_4.Count > 0)
				{
					if (class58_1.class75_0.long_38 == 0L)
					{
						class58_1.class75_0.long_38 = frmLogin.stopwatch_0.ElapsedMilliseconds;
					}
					if (frmLogin.stopwatch_0.ElapsedMilliseconds - class58_1.class75_0.long_38 > 3000L)
					{
						class58_1.class118_0.list_4.Clear();
						class58_1.class75_0.long_38 = 0L;
					}
				}
				if (class58_1.class118_0.list_1.Count > 0)
				{
					if (class58_1.autoSettings_0.FightMode == Class57.FightingModes.DANHGOMQUAI && frmLogin.stopwatch_0.ElapsedMilliseconds - class58_1.class114_0.long_69 >= 1500L)
					{
						class58_1.class114_0.long_69 = frmLogin.stopwatch_0.ElapsedMilliseconds;
						for (int j = class58_1.class118_0.list_1.Count - 1; j >= 0; j--)
						{
							Class119 class2 = class58_1.class118_0.list_1[j];
							if (class2.byte_9 == 1 && frmLogin.stopwatch_0.ElapsedMilliseconds - class2.long_0 >= 1000L && class2.float_4 >= 100f)
							{
								try
								{
									class2.byte_9 = 0;
								}
								catch (Exception)
								{
								}
							}
						}
					}
					for (int k = class58_1.class118_0.list_1.Count - 1; k >= 0; k--)
					{
						Class119 class2 = class58_1.class118_0.list_1[k];
						bool flag2 = false;
						if (class2.int_0 != -1 && class2.int_1 > 0 && class2.byte_8 != 4)
						{
							byte[] array = new byte[4];
							int num = 0;
							array[0] = 0;
							array[1] = 0;
							array[2] = 0;
							array[3] = 0;
							Class159.ReadProcessMemory((int)class58_1.class59_0.intptr_3, (IntPtr)class2.int_1, array, 4U, ref num);
							float num2 = BitConverter.ToSingle(array, 0);
							class2.float_4 = num2 * 100f;
							if (num2 <= 0f)
							{
								Class101.smethod_59(class58_1, k);
								flag2 = true;
							}
						}
						else
						{
							class2.float_4 = 0f;
							if (class2.int_1 == 0)
							{
								Class101.smethod_59(class58_1, k);
							}
							flag2 = true;
						}
						if (!flag2 && class2.int_0 != -1 && class58_1.class114_0 != null)
						{
							double num3 = Class83.smethod_116((double)class2.float_0, (double)class2.float_1, (double)class58_1.class114_0.float_0, (double)class58_1.class114_0.float_5);
							bool flag3 = false;
							if (num3 > frmLogin.class101_0.globalSettings_0.MaxDistance)
							{
								flag3 = true;
							}
							bool flag4 = false;
							int num4 = 30000;
							if (class58_1.class59_0.int_2 == 3 || class58_1.class59_0.int_2 == 4)
							{
								num4 = 120000;
							}
							if (frmLogin.stopwatch_0.ElapsedMilliseconds - class2.long_1 >= (long)num4)
							{
								flag4 = true;
							}
							if (flag3 || flag4)
							{
								Class101.smethod_59(class58_1, k);
							}
						}
					}
				}
				if (class58_1.class118_0.list_1.Count <= 0 && class58_1.class118_0.int_2 >= 0 && !class58_1.method_343())
				{
					Class101.smethod_30(class58_1);
				}
				if (!class58_1.class114_0.bool_25 && frmLogin.stopwatch_0.ElapsedMilliseconds - class58_1.class114_0.long_80 >= 1000L && (class58_1.class118_0.int_2 != -1 || class58_1.class118_0.float_0 > 0f) && !frmLogin.class101_0.globalSettings_0.optNoSkillLag)
				{
					Class101.smethod_30(class58_1);
				}
				if ((class58_1.class118_0.int_2 != -1 || class58_1.class118_0.float_0 > 0f) && class58_1.class118_0.int_2 == class58_1.class118_0.int_5 && class58_1.class118_0.int_5 != -1 && frmLogin.stopwatch_0.ElapsedMilliseconds - class58_1.class118_0.long_0 >= 2000L && class58_1.class118_0.long_0 != 0L && class58_1.class118_0.list_1.Count > 0)
				{
					bool flag5 = false;
					int l = class58_1.class118_0.list_1.Count - 1;
					while (l >= 0)
					{
						if (class58_1.class118_0.list_1[l].int_0 != class58_1.class118_0.int_2 || class58_1.class118_0.list_1[l].float_4 <= 0f)
						{
							l--;
						}
						else
						{
							if (Class83.smethod_116((double)class58_1.class114_0.float_0, (double)class58_1.class114_0.float_5, (double)class58_1.class118_0.list_1[l].float_0, (double)class58_1.class118_0.list_1[l].float_1) <= 35.0)
							{
								flag5 = true;
							}
							IL_B3D:
							if (!flag5)
							{
								Class101.smethod_30(class58_1);
								goto IL_B47;
							}
							goto IL_B47;
						}
					}
					goto IL_B3D;
				}
			}
			IL_B47:
			if (class58_1.class126_0 != null && class58_1.class126_0.int_11 != 0 && frmLogin.stopwatch_0.ElapsedMilliseconds - class58_1.class114_0.long_72 >= 4000L && class58_1.class114_0.long_73 > 0L)
			{
				class58_1.class114_0.long_72 = frmLogin.stopwatch_0.ElapsedMilliseconds;
				if (frmLogin.stopwatch_0.ElapsedMilliseconds - class58_1.class114_0.long_73 >= 45000L)
				{
					class58_1.class126_0.int_11 = 0;
					class58_1.class126_0.long_0 = 0L;
					class58_1.class126_0.string_1 = "";
				}
			}
			if (class58_1.class92_0 != null && class58_1.class114_0 != null && class58_1.class75_0.bool_26 && class58_1.class92_0.list_0.Count > 0)
			{
				for (int m = class58_1.class92_0.list_0.Count - 1; m >= 0; m--)
				{
					Class93 class3 = class58_1.class92_0.list_0[m];
					if (class3.int_0 != 0)
					{
						double num5 = Class83.smethod_116((double)class3.float_2, (double)class3.float_3, (double)class58_1.class114_0.float_0, (double)class58_1.class114_0.float_5);
						bool flag6 = false;
						if (num5 > frmLogin.class101_0.globalSettings_0.MaxDistance && frmLogin.stopwatch_0.ElapsedMilliseconds - class3.long_0 >= 3000L)
						{
							flag6 = true;
						}
						if (!flag6)
						{
							int num6 = 30000;
							if (class58_1.class59_0.int_2 == 3 || class58_1.class59_0.int_2 == 4)
							{
								num6 = 180000;
							}
							if (frmLogin.stopwatch_0.ElapsedMilliseconds - class3.long_0 >= (long)num6)
							{
								flag6 = true;
							}
						}
						if (flag6)
						{
							class58_1.class92_0.list_0.RemoveAt(m);
						}
					}
				}
			}
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00004986 File Offset: 0x00002B86
		internal static void smethod_30(Class58 class58_1)
		{
			class58_1.class118_0.int_2 = -1;
			class58_1.class118_0.int_5 = -1;
			class58_1.class118_0.float_0 = 0f;
			class58_1.class118_0.int_4 = 0;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00087EDC File Offset: 0x000860DC
		internal static void smethod_31(byte[] byte_0)
		{
			byte_0[0] = 0;
			byte_0[1] = 0;
			byte_0[2] = 0;
			byte_0[3] = 0;
			byte_0[4] = 0;
			byte_0[5] = 0;
			byte_0[6] = 0;
			byte_0[7] = 0;
			byte_0[8] = 0;
			byte_0[9] = 0;
			byte_0[10] = 0;
			byte_0[11] = 0;
			byte_0[12] = 0;
			byte_0[13] = 0;
			byte_0[14] = 0;
			byte_0[15] = 0;
			byte_0[16] = 0;
			byte_0[17] = 0;
			byte_0[18] = 0;
			byte_0[19] = 0;
			byte_0[20] = 0;
			byte_0[21] = 0;
			byte_0[22] = 0;
			byte_0[23] = 0;
			byte_0[24] = 0;
			byte_0[25] = 0;
			byte_0[26] = 0;
			byte_0[27] = 0;
			byte_0[28] = 0;
			byte_0[29] = 0;
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00087F78 File Offset: 0x00086178
		internal static void smethod_32(Class58 class58_1)
		{
			class58_1.class59_0.byte_0[0] = 0;
			class58_1.class59_0.byte_0[1] = 0;
			class58_1.class59_0.byte_0[2] = 0;
			class58_1.class59_0.byte_0[3] = 0;
			class58_1.class59_0.byte_0[4] = 0;
			class58_1.class59_0.byte_0[5] = 0;
			class58_1.class59_0.byte_0[6] = 0;
			class58_1.class59_0.byte_0[7] = 0;
			class58_1.class59_0.byte_0[8] = 0;
			class58_1.class59_0.byte_0[9] = 0;
			class58_1.class59_0.byte_0[10] = 0;
			class58_1.class59_0.byte_0[11] = 0;
			class58_1.class59_0.byte_0[12] = 0;
			class58_1.class59_0.byte_0[13] = 0;
			class58_1.class59_0.byte_0[14] = 0;
			class58_1.class59_0.byte_0[15] = 0;
			class58_1.class59_0.byte_0[16] = 0;
			class58_1.class59_0.byte_0[17] = 0;
			class58_1.class59_0.byte_0[18] = 0;
			class58_1.class59_0.byte_0[19] = 0;
			class58_1.class59_0.byte_0[20] = 0;
			class58_1.class59_0.byte_0[21] = 0;
			class58_1.class59_0.byte_0[22] = 0;
			class58_1.class59_0.byte_0[23] = 0;
			class58_1.class59_0.byte_0[24] = 0;
			class58_1.class59_0.byte_0[25] = 0;
			class58_1.class59_0.byte_0[26] = 0;
			class58_1.class59_0.byte_0[27] = 0;
			class58_1.class59_0.byte_0[28] = 0;
			class58_1.class59_0.byte_0[29] = 0;
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00088140 File Offset: 0x00086340
		internal static void smethod_33(Class58 class58_1)
		{
			Class101.Class103 @class = new Class101.Class103();
			@class.class58_0 = class58_1;
			if (@class.class58_0.class59_0.int_1 != 0 && @class.class58_0.class59_0.intptr_3 != IntPtr.Zero)
			{
				int num = 0;
				int num2 = 0;
				int num3 = -1;
				string string_ = "";
				int num4 = 0;
				int num5 = 0;
				float num6 = 0f;
				int num7 = (int)@class.class58_0.class59_0.intptr_3;
				for (int i = 0; i < @class.class58_0.class59_0.list_0.Count; i++)
				{
					Class66 class2 = @class.class58_0.class59_0.list_0[i];
					string a = class2.string_1;
					int num8 = @class.class58_0.class59_0.int_2;
					if (!(a == "rm14") && (num8 != 3 || (!(a == "rm17") && !(a == "rm24") && !(a == "rm39"))) && (@class.class58_0.class75_0.bool_28 || !(a == "rm39") || !(@class.class58_0.class114_0.string_0 != "")) && (!(a == "rm9") || (@class.class58_0.class126_0 != null && @class.class58_0.class126_0.int_1 != 0)))
					{
						if (a == "rm24")
						{
							if ((@class.class58_0.class75_0.long_55 == 0L && @class.class58_0.class114_0.int_9 > 0) || @class.class58_0.class114_0.Menpai == Class57.Menpais.NGAMI)
							{
								@class.class58_0.class75_0.long_55 = Class101.smethod_61() + 60000L;
							}
							if (@class.class58_0.class75_0.long_55 < Class101.smethod_61())
							{
								goto IL_6428;
							}
						}
						if ((!(a == "rm23") || @class.class58_0.autoSettings_0.cboxPKTuVe) && (!(a == "rm29") || (@class.class58_0.autoSettings_0.cboxPassCap2 && !(@class.class58_0.autoSettings_0.txtPassCap2 == ""))) && ((@class.class58_0.class114_0.MapID >= 0 && @class.class58_0.class114_0.int_9 > 0) || a == "rm1" || a == "rm2" || a == "rm27" || a == "rm19") && (!(a == "rm31") || !(@class.class58_0.class116_0.String_2 == "") || (!(@class.class58_0.class116_0.String_1 == "") && @class.class58_0.autoSettings_0.cboxCongSinh) || (!(@class.class58_0.class116_0.String_0 == "") && @class.class58_0.autoSettings_0.cboxHuyetTe) || @class.class58_0.class116_0.Int32_1 > 0 || !(@class.class58_0.class116_0.list_0[0].string_0 != "")))
						{
							num3 = -1;
							num2 = 0;
							string_ = "";
							byte b = 0;
							num5 = 0;
							num6 = 0f;
							num = 0;
							int num9 = Class83.smethod_61(num8);
							@class.class58_0.class59_0.int_3 = num9;
							int num10 = @class.class58_0.class59_0.int_4 + class2.int_0[0];
							@class.class58_0.class59_0.byte_0[0] = 0;
							@class.class58_0.class59_0.byte_0[1] = 0;
							@class.class58_0.class59_0.byte_0[2] = 0;
							@class.class58_0.class59_0.byte_0[3] = 0;
							Class159.ReadProcessMemory(num7, (IntPtr)num10, @class.class58_0.class59_0.byte_0, 4U, ref num4);
							int num11 = (int)@class.class58_0.class59_0.byte_0[0] | (int)@class.class58_0.class59_0.byte_0[1] << 8 | (int)@class.class58_0.class59_0.byte_0[2] << 16 | (int)@class.class58_0.class59_0.byte_0[3] << 24;
							if (a == "rm39" && @class.class58_0.class114_0 != null && num10 > 0)
							{
								string_ = "";
								Class101.smethod_39(@class.class58_0, ref string_, num10);
								@class.class58_0.class114_0.string_0 = string_;
							}
							if (num11 >= 0 && num4 > 0)
							{
								for (int j = 1; j < (int)(class2.byte_0 - 1); j++)
								{
									int num12 = class2.int_0[j];
									num4 = 0;
									if (num11 != 0)
									{
										int value = num11 + num12;
										@class.class58_0.class59_0.byte_0[0] = 0;
										@class.class58_0.class59_0.byte_0[1] = 0;
										@class.class58_0.class59_0.byte_0[2] = 0;
										@class.class58_0.class59_0.byte_0[3] = 0;
										Class159.ReadProcessMemory((int)@class.class58_0.class59_0.intptr_3, (IntPtr)value, @class.class58_0.class59_0.byte_0, 4U, ref num4);
										num11 = ((int)@class.class58_0.class59_0.byte_0[0] | (int)@class.class58_0.class59_0.byte_0[1] << 8 | (int)@class.class58_0.class59_0.byte_0[2] << 16 | (int)@class.class58_0.class59_0.byte_0[3] << 24);
									}
									if (num11 == 0)
									{
										break;
									}
								}
								int num13 = (int)(class2.byte_0 - 1);
								num13 = class2.int_0[num13];
								if (num11 != 0)
								{
									num11 += num13;
								}
								a == "rm2";
								if (num11 != 0)
								{
									num4 = 0;
									if (class2.string_0 == "int")
									{
										@class.class58_0.class59_0.byte_0[0] = 0;
										@class.class58_0.class59_0.byte_0[1] = 0;
										@class.class58_0.class59_0.byte_0[2] = 0;
										@class.class58_0.class59_0.byte_0[3] = 0;
										Class159.ReadProcessMemory((int)@class.class58_0.class59_0.intptr_3, (IntPtr)num11, @class.class58_0.class59_0.byte_0, 4U, ref num4);
										num3 = ((int)@class.class58_0.class59_0.byte_0[0] | (int)@class.class58_0.class59_0.byte_0[1] << 8 | (int)@class.class58_0.class59_0.byte_0[2] << 16 | (int)@class.class58_0.class59_0.byte_0[3] << 24);
									}
									else if (class2.string_0 == "float")
									{
										@class.class58_0.class59_0.byte_0[0] = 0;
										@class.class58_0.class59_0.byte_0[1] = 0;
										@class.class58_0.class59_0.byte_0[2] = 0;
										@class.class58_0.class59_0.byte_0[3] = 0;
										Class159.ReadProcessMemory((int)@class.class58_0.class59_0.intptr_3, (IntPtr)num11, @class.class58_0.class59_0.byte_0, 4U, ref num4);
										BitConverter.ToSingle(@class.class58_0.class59_0.byte_0, 0);
									}
									else if (class2.string_0 == "string")
									{
										Class101.smethod_32(@class.class58_0);
										Class159.ReadProcessMemory((int)@class.class58_0.class59_0.intptr_3, (IntPtr)num11, @class.class58_0.class59_0.byte_0, 30U, ref num4);
										string_ = BitConverter.ToString(@class.class58_0.class59_0.byte_0, 0);
									}
									else if (class2.string_0 == "byte")
									{
										@class.class58_0.class59_0.byte_0[0] = 0;
										Class159.ReadProcessMemory((int)@class.class58_0.class59_0.intptr_3, (IntPtr)num11, @class.class58_0.class59_0.byte_0, 1U, ref num4);
										b = @class.class58_0.class59_0.byte_0[0];
									}
								}
							}
							bool flag = false;
							if (a == "rm2")
							{
								if (@class.class58_0.class114_0 != null)
								{
									@class.class58_0.class114_0.int_9 = num3;
								}
							}
							else if (a == "rm27" && @class.class58_0.class114_0 != null)
							{
								if (num3 != 0 && num3 != 1)
								{
									if (@class.class58_0.class75_0.Boolean_0 && @class.class58_0.class114_0.int_9 > 0 && frmLogin.class101_0.globalSettings_0.TipHuongDan && (@class.class58_0.class75_0.long_36 == 0L || @class.class58_0.method_232() - @class.class58_0.class75_0.long_36 > 300000L))
									{
										Class83.smethod_66(frmMain.String_765 + " - code SceneTrans " + num3, @class.class58_0, new object[0]);
										@class.class58_0.class75_0.long_36 = @class.class58_0.method_232();
									}
								}
								else
								{
									@class.class58_0.class114_0.isSceneTrans = num3;
								}
							}
							if (@class.class58_0.class114_0.int_9 <= 0)
							{
								goto IL_A35;
							}
							if (@class.class58_0.class114_0.isSceneTrans == 1)
							{
								goto IL_A35;
							}
							flag = true;
							IL_A46:
							if (!flag)
							{
								goto IL_6428;
							}
							if (a == "rm13")
							{
								if (@class.class58_0.class114_0 != null && num3 != 0)
								{
									num5 = 0;
									if (num9 == 362 || num9 == 366 || num9 == 367)
									{
										goto IL_AED;
									}
									if (num9 == 368)
									{
										goto IL_AED;
									}
									if (num8 == 3)
									{
										num5 = num3 + 68;
									}
									else if (num8 == 4)
									{
										num5 = num3 + 72;
									}
									else
									{
										if (num8 != 7)
										{
											if (num8 != 8)
											{
												if (num8 != 5)
												{
													if (num8 != 6)
													{
														num5 = num3 + 96;
														goto IL_AF4;
													}
												}
												num5 = num3 + 72;
												goto IL_AF4;
											}
										}
										num5 = num3 + 72;
									}
									IL_AF4:
									num6 = 0f;
									Class101.smethod_42(@class.class58_0, ref num6, num5);
									@class.class58_0.class114_0.float_0 = num6;
									if (num9 == 362 || num9 == 366 || num9 == 367)
									{
										goto IL_B91;
									}
									if (num9 == 368)
									{
										goto IL_B91;
									}
									if (num8 == 3)
									{
										num5 = num3 + 76;
									}
									else if (num8 == 4)
									{
										num5 = num3 + 80;
									}
									else
									{
										if (num8 != 7)
										{
											if (num8 != 8)
											{
												if (num8 != 5)
												{
													if (num8 != 6)
													{
														num5 = num3 + 104;
														goto IL_B98;
													}
												}
												num5 = num3 + 80;
												goto IL_B98;
											}
										}
										num5 = num3 + 80;
									}
									IL_B98:
									num6 = 0f;
									Class101.smethod_42(@class.class58_0, ref num6, num5);
									@class.class58_0.class114_0.float_5 = num6;
									goto IL_6428;
									IL_B91:
									num5 = num3 + 76;
									goto IL_B98;
									IL_AED:
									num5 = num3 + 68;
									goto IL_AF4;
								}
								goto IL_6428;
							}
							else if (a == "rm1")
							{
								if (@class.class58_0.class114_0 != null && num3 != 0)
								{
									if (num9 == 360)
									{
										num5 = num3 + 10080;
									}
									else if (num9 == 361)
									{
										num5 = num3 + 10120;
									}
									else if (num9 == 362)
									{
										num5 = num3 + 10204;
									}
									else if (num9 == 366)
									{
										num5 = num3 + 11520;
									}
									else if (num9 == 367)
									{
										num5 = num3 + 17500;
									}
									else if (num9 == 368)
									{
										num5 = num3 + 22680;
									}
									else if (num8 == 3)
									{
										num5 = num3 + 1752;
									}
									else if (num8 == 4)
									{
										num5 = num3 + 2468;
									}
									else
									{
										if (num8 != 5)
										{
											if (num8 != 6)
											{
												if (num8 != 7)
												{
													if (num8 != 8)
													{
														if (num8 == 1 || num8 == 2)
														{
															num5 = num3 + 10032;
															goto IL_CDD;
														}
														goto IL_CDD;
													}
												}
												num5 = num3 + 10080;
												goto IL_CDD;
											}
										}
										num5 = num3 + 9304;
									}
									IL_CDD:
									num = 0;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class114_0.int_17 = num;
									if (num9 == 360)
									{
										num5 = num3 + 10084;
									}
									else if (num9 == 361)
									{
										num5 = num3 + 10124;
									}
									else if (num9 == 362)
									{
										num5 = num3 + 10208;
									}
									else if (num9 == 366)
									{
										num5 = num3 + 11524;
									}
									else if (num9 == 367)
									{
										num5 = num3 + 17504;
									}
									else if (num9 == 368)
									{
										num5 = num3 + 22684;
									}
									else if (num8 == 3)
									{
										num5 = num3 + 1756;
									}
									else if (num8 == 4)
									{
										num5 = num3 + 2472;
									}
									else
									{
										if (num8 != 5)
										{
											if (num8 != 6)
											{
												if (num8 != 7)
												{
													if (num8 != 8)
													{
														if (num8 != 1)
														{
															if (num8 != 2)
															{
																num5 = num3 + 9372;
																goto IL_E00;
															}
														}
														num5 = num3 + 10036;
														goto IL_E00;
													}
												}
												num5 = num3 + 10084;
												goto IL_E00;
											}
										}
										num5 = num3 + 9308;
									}
									IL_E00:
									num = 0;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class114_0.int_19 = num;
									if (@class.class58_0.class75_0.bool_25)
									{
										if (num9 == 360)
										{
											num5 = num3 + 10200;
										}
										else if (num9 == 361)
										{
											num5 = num3 + 10240;
										}
										else if (num9 == 362)
										{
											num5 = num3 + 10324;
										}
										else if (num9 == 366)
										{
											num5 = num3 + 11640;
										}
										else if (num9 == 367)
										{
											num5 = num3 + 17620;
										}
										else if (num9 == 368)
										{
											num5 = num3 + 22804;
										}
										else if (num8 == 3)
										{
											num5 = num3 + 1856;
										}
										else if (num8 == 4)
										{
											num5 = num3 + 2584;
										}
										else
										{
											if (num8 != 5)
											{
												if (num8 != 6)
												{
													if (num8 != 7)
													{
														if (num8 != 8)
														{
															if (num8 != 1)
															{
																if (num8 != 2)
																{
																	num5 = num3 + 9496;
																	goto IL_F38;
																}
															}
															num5 = num3 + 10160;
															goto IL_F38;
														}
													}
													num5 = num3 + 10200;
													goto IL_F38;
												}
											}
											num5 = num3 + 9432;
										}
										IL_F38:
										num = 0;
										Class101.smethod_35(@class.class58_0, ref num, num5);
										@class.class58_0.class114_0.int_18 = num;
										if (num9 == 360)
										{
											num5 = num3 + 10204;
										}
										else if (num9 == 361)
										{
											num5 = num3 + 10244;
										}
										else if (num9 == 362)
										{
											num5 = num3 + 10328;
										}
										else if (num9 == 366)
										{
											num5 = num3 + 11644;
										}
										else if (num9 == 367)
										{
											num5 = num3 + 17624;
										}
										else if (num9 == 368)
										{
											num5 = num3 + 22808;
										}
										else if (num8 == 3)
										{
											num5 = num3 + 1860;
										}
										else if (num8 == 4)
										{
											num5 = num3 + 2588;
										}
										else
										{
											if (num8 != 5)
											{
												if (num8 != 6)
												{
													if (num8 != 7)
													{
														if (num8 != 8)
														{
															if (num8 != 1)
															{
																if (num8 != 2)
																{
																	num5 = num3 + 9500;
																	goto IL_105B;
																}
															}
															num5 = num3 + 10164;
															goto IL_105B;
														}
													}
													num5 = num3 + 10204;
													goto IL_105B;
												}
											}
											num5 = num3 + 9436;
										}
										IL_105B:
										num = 0;
										Class101.smethod_35(@class.class58_0, ref num, num5);
										@class.class58_0.class114_0.int_20 = num;
									}
									if (@class.class58_0.class75_0.bool_26)
									{
										if (num9 == 362)
										{
											num5 = num3 + 116;
										}
										else
										{
											if (num9 != 366 && num9 != 367)
											{
												if (num9 != 368)
												{
													if (num8 == 3)
													{
														num5 = num3 + 96;
														goto IL_1121;
													}
													if (num8 == 4)
													{
														num5 = num3 + 100;
														goto IL_1121;
													}
													if (num8 != 5)
													{
														if (num8 != 6)
														{
															if (num8 != 7)
															{
																if (num8 != 8)
																{
																	if (num8 == 1 || num8 == 2)
																	{
																		num5 = num3 + 112;
																		goto IL_1121;
																	}
																	goto IL_1121;
																}
															}
															num5 = num3 + 112;
															goto IL_1121;
														}
													}
													num5 = num3 + 104;
													goto IL_1121;
												}
											}
											num5 = num3 + 112;
										}
										IL_1121:
										num = 0;
										Class101.smethod_35(@class.class58_0, ref num, num5);
										@class.class58_0.class114_0.int_21 = num;
										if (num9 == 362)
										{
											num5 = num3 + 244;
										}
										else
										{
											if (num9 != 366 && num9 != 367)
											{
												if (num9 != 368)
												{
													if (num8 == 3)
													{
														num5 = num3 + 160;
														goto IL_11EA;
													}
													if (num8 == 4)
													{
														num5 = num3 + 160;
														goto IL_11EA;
													}
													if (num8 != 5)
													{
														if (num8 != 6)
														{
															if (num8 != 7)
															{
																if (num8 != 8)
																{
																	if (num8 == 1 || num8 == 2)
																	{
																		num5 = num3 + 236;
																		goto IL_11EA;
																	}
																	goto IL_11EA;
																}
															}
															num5 = num3 + 240;
															goto IL_11EA;
														}
													}
													num5 = num3 + 232;
													goto IL_11EA;
												}
											}
											num5 = num3 + 248;
										}
										IL_11EA:
										num = 0;
										Class101.smethod_35(@class.class58_0, ref num, num5);
										@class.class58_0.class114_0.int_124 = num;
										if (num9 == 362)
										{
											num5 = num3 + 248;
										}
										else
										{
											if (num9 != 366 && num9 != 367)
											{
												if (num9 != 368)
												{
													if (num8 == 3)
													{
														num5 = num3 + 164;
														goto IL_12B3;
													}
													if (num8 == 4)
													{
														num5 = num3 + 164;
														goto IL_12B3;
													}
													if (num8 != 5)
													{
														if (num8 != 6)
														{
															if (num8 != 7)
															{
																if (num8 != 8)
																{
																	if (num8 == 1 || num8 == 2)
																	{
																		num5 = num3 + 240;
																		goto IL_12B3;
																	}
																	goto IL_12B3;
																}
															}
															num5 = num3 + 244;
															goto IL_12B3;
														}
													}
													num5 = num3 + 236;
													goto IL_12B3;
												}
											}
											num5 = num3 + 252;
										}
										IL_12B3:
										num = 0;
										Class101.smethod_35(@class.class58_0, ref num, num5);
										@class.class58_0.class114_0.int_125 = num;
										if (num9 == 362)
										{
											num5 = num3 + 112;
										}
										else
										{
											if (num9 != 366 && num9 != 367)
											{
												if (num9 != 368)
												{
													if (num8 == 3)
													{
														num5 = num3 + 92;
														goto IL_1364;
													}
													if (num8 == 4)
													{
														num5 = num3 + 96;
														goto IL_1364;
													}
													if (num8 != 7)
													{
														if (num8 != 8)
														{
															if (num8 != 1)
															{
																if (num8 != 2)
																{
																	if (num8 == 5 || num8 == 6)
																	{
																		num5 = num3 + 100;
																		goto IL_1364;
																	}
																	goto IL_1364;
																}
															}
															num5 = num3 + 108;
															goto IL_1364;
														}
													}
													num5 = num3 + 108;
													goto IL_1364;
												}
											}
											num5 = num3 + 108;
										}
										IL_1364:
										num = 0;
										Class101.smethod_35(@class.class58_0, ref num, num5);
										@class.class58_0.class114_0.int_39 = num;
										if (num9 == 360)
										{
											num5 = num3 + 10088;
										}
										else if (num9 == 361)
										{
											num5 = num3 + 10128;
										}
										else if (num9 == 362)
										{
											num5 = num3 + 10212;
										}
										else if (num9 == 366)
										{
											num5 = num3 + 11528;
										}
										else if (num9 == 367)
										{
											num5 = num3 + 17508;
										}
										else if (num9 == 368)
										{
											num5 = num3 + 22688;
										}
										else if (num8 == 3)
										{
											num5 = num3 + 1760;
										}
										else if (num8 == 4)
										{
											num5 = num3 + 2476;
										}
										else
										{
											if (num8 != 7)
											{
												if (num8 != 8)
												{
													if (num8 != 5)
													{
														if (num8 != 6)
														{
															if (num8 == 1 || num8 == 2)
															{
																num5 = num3 + 10040;
																goto IL_1476;
															}
															goto IL_1476;
														}
													}
													num5 = num3 + 9312;
													goto IL_1476;
												}
											}
											num5 = num3 + 10088;
										}
										IL_1476:
										num = 0;
										Class101.smethod_35(@class.class58_0, ref num, num5);
										@class.class58_0.class114_0.int_25 = num;
										if (num9 == 360)
										{
											num5 = num3 + 10092;
										}
										else if (num9 == 361)
										{
											num5 = num3 + 10132;
										}
										else if (num9 == 362)
										{
											num5 = num3 + 10216;
										}
										else if (num9 == 366)
										{
											num5 = num3 + 11532;
										}
										else if (num9 == 367)
										{
											num5 = num3 + 17512;
										}
										else if (num9 == 368)
										{
											num5 = num3 + 22692;
										}
										else if (num8 <= 2)
										{
											num5 = num3 + 10044;
										}
										num = 0;
										Class101.smethod_35(@class.class58_0, ref num, num5);
										@class.class58_0.class114_0.int_113 = num;
									}
									if (num9 == 362 || num9 == 366 || num9 == 367)
									{
										goto IL_15D8;
									}
									if (num9 == 368)
									{
										goto IL_15D8;
									}
									if (num8 == 3)
									{
										num5 = num3 + 148;
									}
									else if (num8 == 4)
									{
										num5 = num3 + 152;
									}
									else
									{
										if (num8 != 7)
										{
											if (num8 != 8)
											{
												if (num8 != 1)
												{
													if (num8 != 2)
													{
														if (num8 == 5 || num8 == 6)
														{
															num5 = num3 + 156;
															goto IL_15E2;
														}
														goto IL_15E2;
													}
												}
												num5 = num3 + 164;
												goto IL_15E2;
											}
										}
										num5 = num3 + 164;
									}
									IL_15E2:
									num = -1;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class114_0.int_38 = num;
									if (@class.class58_0.class75_0.bool_25)
									{
										if (num8 == 3)
										{
											goto IL_166D;
										}
										if (num8 == 4)
										{
											goto IL_166D;
										}
										if (num8 != 7)
										{
											if (num8 != 8)
											{
												if (num8 != 1)
												{
													if (num8 != 2)
													{
														if (num8 != 5)
														{
															if (num8 != 6)
															{
																num5 = num3 + 20;
																goto IL_1674;
															}
														}
														num5 = num3 + 24;
														goto IL_1674;
													}
												}
												num5 = num3 + 24;
												goto IL_1674;
											}
										}
										num5 = num3 + 24;
										IL_1674:
										num = 0;
										Class101.smethod_35(@class.class58_0, ref num, num5);
										@class.class58_0.class114_0.int_11 = num;
										if (num8 == 7 || num8 == 8 || num8 == 1 || num8 == 2)
										{
											num5 = num3 + 20;
											num = 0;
											Class101.smethod_35(@class.class58_0, ref num, num5);
											@class.class58_0.class114_0.int_12 = num;
											goto IL_16D3;
										}
										goto IL_16D3;
										IL_166D:
										num5 = num3 + 16;
										goto IL_1674;
									}
									IL_16D3:
									if (num9 == 362)
									{
										num5 = num3 + 252;
									}
									else if (num9 == 366)
									{
										num5 = num3 + 256;
									}
									else if (num9 == 367)
									{
										num5 = num3 + 632;
									}
									else if (num9 == 368)
									{
										num5 = num3 + 636;
									}
									else if (num9 == 361)
									{
										num5 = num3 + 244;
									}
									else if (num8 == 3)
									{
										num5 = num3 + 168;
									}
									else if (num8 == 4)
									{
										num5 = num3 + 172;
									}
									else
									{
										if (num8 != 7)
										{
											if (num8 != 8)
											{
												if (num8 != 5)
												{
													if (num8 != 6)
													{
														if (num8 == 1 || num8 == 2)
														{
															num5 = num3 + 236;
															goto IL_17AB;
														}
														goto IL_17AB;
													}
												}
												num5 = num3 + 240;
												goto IL_17AB;
											}
										}
										num5 = num3 + 244;
									}
									IL_17AB:
									num = 0;
									@class.class58_0.class114_0.menpais_1 = @class.class58_0.class114_0.Menpai;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class114_0.Menpai = (Class57.Menpais)num;
									@class.class58_0.class75_0.bool_20 = true;
									if (@class.class58_0.class116_0 != null && @class.class58_0.class75_0.bool_26)
									{
										if (num9 == 362)
										{
											num5 = num3 + 10264;
										}
										else if (num9 == 367)
										{
											num5 = num3 + 17560;
										}
										else if (num9 == 368)
										{
											num5 = num3 + 22744;
										}
										else if (num9 == 366)
										{
											num5 = num3 + 11580;
										}
										else if (num9 == 360)
										{
											num5 = num3 + 10140;
										}
										else if (num9 == 361)
										{
											num5 = num3 + 10180;
										}
										else if (num8 == 3)
										{
											num5 = num3 + 1808;
										}
										else if (num8 == 4)
										{
											num5 = num3 + 2528;
										}
										else
										{
											if (num8 != 7)
											{
												if (num8 != 8)
												{
													if (num8 != 5)
													{
														if (num8 != 6)
														{
															if (num8 == 1 || num8 == 2)
															{
																num5 = num3 + 10092;
																goto IL_1913;
															}
															goto IL_1913;
														}
													}
													num5 = num3 + 9364;
													goto IL_1913;
												}
											}
											num5 = num3 + 10140;
										}
										IL_1913:
										num = 0;
										Class101.smethod_35(@class.class58_0, ref num, num5);
										@class.class58_0.class116_0.int_1 = num;
										if (num9 == 362)
										{
											num5 = num3 + 10268;
										}
										else if (num9 == 367)
										{
											num5 = num3 + 17564;
										}
										else if (num9 == 368)
										{
											num5 = num3 + 22748;
										}
										else if (num9 == 366)
										{
											num5 = num3 + 11584;
										}
										else if (num9 == 360)
										{
											num5 = num3 + 10144;
										}
										else if (num9 == 361)
										{
											num5 = num3 + 10184;
										}
										else if (num8 == 3)
										{
											num5 = num3 + 1812;
										}
										else if (num8 == 4)
										{
											num5 = num3 + 2532;
										}
										else
										{
											if (num8 != 7)
											{
												if (num8 != 8)
												{
													if (num8 != 5)
													{
														if (num8 != 6)
														{
															if (num8 != 1)
															{
																if (num8 != 2)
																{
																	num5 = num3 + 9432;
																	goto IL_1A36;
																}
															}
															num5 = num3 + 10096;
															goto IL_1A36;
														}
													}
													num5 = num3 + 9368;
													goto IL_1A36;
												}
											}
											num5 = num3 + 10144;
										}
										IL_1A36:
										num = 0;
										Class101.smethod_35(@class.class58_0, ref num, num5);
										@class.class58_0.class116_0.int_2 = num;
									}
									if (@class.class58_0.class114_0.MapID < 0)
									{
										goto IL_6428;
									}
									if (!@class.class58_0.class75_0.Boolean_0 && @class.class58_0.class75_0.bool_26)
									{
										if ((@class.class58_0.class75_0.int_17 == 0 || @class.class58_0.class75_0.int_18 == 0 || @class.class58_0.class75_0.int_19 == 0) && @class.class58_0.method_232() - @class.class58_0.class75_0.long_23 >= 2000L)
										{
											@class.class58_0.class75_0.long_23 = @class.class58_0.method_232();
											@class.class58_0.method_181();
										}
										if (@class.class58_0.class75_0.int_17 != 0 && @class.class58_0.class75_0.int_18 != 0 && @class.class58_0.class75_0.int_19 != 0)
										{
											object object_ = @class.class58_0.class75_0.object_1;
											lock (object_)
											{
												@class.class58_0.class75_0.bool_29 = true;
											}
										}
										if (Class83.smethod_60(@class.class58_0) && frmLogin.class101_0.globalSettings_0.optGCafe && !@class.class58_0.class75_0.bool_21)
										{
											@class.class58_0.class75_0.bool_21 = true;
										}
										if (Class83.smethod_60(@class.class58_0) && @class.class58_0.class75_0.long_21 == 0L)
										{
											@class.class58_0.class75_0.long_21 = @class.class58_0.method_232();
										}
										if (@class.class58_0.method_232() - @class.class58_0.class75_0.long_21 >= 500L && @class.class58_0.class75_0.long_21 != 0L && @class.class58_0.class75_0.bool_29)
										{
											@class.class58_0.method_192(1);
											@class.class58_0.method_141(1, -1);
											@class.class58_0.class75_0.Boolean_0 = true;
											@class.class58_0.class75_0.bool_12 = false;
											@class.class58_0.class75_0.long_55 = 0L;
										}
									}
									if (!@class.class58_0.class75_0.Boolean_0)
									{
										goto IL_6428;
									}
									if (@class.class58_0.class75_0.bool_26)
									{
										if (num8 == 3)
										{
											goto IL_1D1E;
										}
										if (num8 == 4)
										{
											goto IL_1D1E;
										}
										if (num8 != 7)
										{
											if (num8 != 8)
											{
												if (num9 == 362)
												{
													num5 = num3 + 60;
													goto IL_1D25;
												}
												if (num9 != 366 && num9 != 367)
												{
													if (num9 != 368)
													{
														num5 = num3 + 52;
														goto IL_1D25;
													}
												}
												num5 = num3 + 56;
												goto IL_1D25;
											}
										}
										num5 = num3 + 60;
										IL_1D25:
										string_ = "";
										Class101.smethod_39(@class.class58_0, ref string_, num5);
										@class.class58_0.class114_0.string_5 = @class.class58_0.class114_0.string_3;
										@class.class58_0.class114_0.string_3 = string_;
										if (@class.class58_0.class114_0.string_3 != @class.class58_0.class114_0.string_5 && @class.class58_0.class114_0.string_3 != "")
										{
											try
											{
												@class.class58_0.class75_0.bool_19 = true;
												if (@class.class58_0.gclass2_0 != null)
												{
													Control lbStatus = frmGLogin.frmGLogin_0.lbStatus;
													MethodInvoker method;
													if ((method = @class.methodInvoker_0) == null)
													{
														method = (@class.methodInvoker_0 = new MethodInvoker(@class.method_0));
													}
													lbStatus.Invoke(method);
												}
												if (@class.class58_0.class75_0.int_55 > 0)
												{
													if (@class.class58_0.class75_0.int_55 == 1)
													{
														Control cboxIsBachHoaDuyen = frmMain.frmMain_0.cboxIsBachHoaDuyen;
														MethodInvoker method2;
														if ((method2 = @class.methodInvoker_1) == null)
														{
															method2 = (@class.methodInvoker_1 = new MethodInvoker(@class.method_1));
														}
														cboxIsBachHoaDuyen.Invoke(method2);
													}
													else if (@class.class58_0.class75_0.int_55 == 2)
													{
														for (int k = frmLogin.class101_0.list_17.Count - 1; k >= 0; k--)
														{
															Class58 class3 = frmLogin.class101_0.list_17[k];
															if (class3.class114_0.string_3 == @class.class58_0.class114_0.string_3)
															{
																@class.class58_0.class114_0.bool_162 = class3.class114_0.bool_162;
																@class.class58_0.class75_0.string_1 = class3.class75_0.string_1;
																@class.class58_0.IsAIEnabled = class3.IsAIEnabled;
																if (!class3.class114_0.bool_130)
																{
																	frmMain.frmMain_0.method_86(@class.class58_0, 1);
																}
																else if (!class3.class114_0.bool_20)
																{
																	frmMain.frmMain_0.method_86(@class.class58_0, 0);
																}
																if (frmLogin.class101_0.list_17.Count <= 1)
																{
																	frmLogin.class101_0.list_17.Clear();
																}
																else
																{
																	frmLogin.class101_0.list_17.RemoveAt(k);
																}
															}
														}
													}
													@class.class58_0.class75_0.int_55 = 0;
												}
												goto IL_6433;
											}
											catch (Exception)
											{
												goto IL_6433;
											}
											goto IL_1FB3;
										}
										goto IL_6433;
										IL_1D1E:
										num5 = num3 + 48;
										goto IL_1D25;
									}
									goto IL_6433;
									IL_1FB3:
									if (num8 > 2)
									{
										if (num8 == 3)
										{
											num5 = num3 + 1696;
										}
										else if (num8 == 4)
										{
											num5 = num3 + 2408;
										}
										else
										{
											if (num8 != 7)
											{
												if (num8 != 8)
												{
													if (num8 == 5 || num8 == 6)
													{
														num5 = num3 + 9172;
														goto IL_2009;
													}
													goto IL_2009;
												}
											}
											num5 = num3 + 9888;
										}
										IL_2009:
										string_ = "";
										Class101.smethod_39(@class.class58_0, ref string_, num5);
										@class.class58_0.class114_0.string_0 = string_;
										goto IL_6428;
									}
									goto IL_6428;
									IL_6433:
									if (@class.class58_0.class75_0.bool_25)
									{
										goto IL_1FB3;
									}
									goto IL_6428;
									IL_15D8:
									num5 = num3 + 168;
									goto IL_15E2;
								}
								goto IL_6428;
							}
							else if (a == "rm10")
							{
								if (@class.class58_0.class126_0 == null || num3 < 0 || num3 > 5)
								{
									goto IL_6428;
								}
								if (num3 == 0 && @class.class58_0.class126_0.int_1 > 0)
								{
									@class.class58_0.class75_0.long_55 = Class101.smethod_61() + 10000L;
								}
								if (num3 < @class.class58_0.class126_0.int_2)
								{
									@class.class58_0.class126_0.int_3++;
								}
								else
								{
									@class.class58_0.class126_0.int_1 = num3;
									@class.class58_0.class126_0.int_2 = num3;
									@class.class58_0.class126_0.int_3 = 0;
								}
								if (@class.class58_0.class126_0.int_3 >= 4)
								{
									@class.class58_0.class126_0.int_1 = num3;
									@class.class58_0.class126_0.int_2 = num3;
									@class.class58_0.class126_0.int_3 = 0;
									goto IL_6428;
								}
								goto IL_6428;
							}
							else if (a == "rm17" && @class.class58_0.class75_0.bool_25)
							{
								if (@class.class58_0.class114_0 != null)
								{
									@class.class58_0.class114_0.int_26 = num3;
									goto IL_6428;
								}
								goto IL_6428;
							}
							else if (a == "rm15")
							{
								if (@class.class58_0.class114_0 == null)
								{
									goto IL_6428;
								}
								if (num3 != 0 && num3 != 1)
								{
									if (@class.class58_0.class75_0.Boolean_0 && @class.class58_0.class114_0.isSceneTrans == 0 && @class.class58_0.class114_0.int_9 > 0 && frmLogin.class101_0.globalSettings_0.TipHuongDan && (@class.class58_0.class75_0.long_36 == 0L || @class.class58_0.method_232() - @class.class58_0.class75_0.long_36 > 300000L))
									{
										Class83.smethod_66(frmMain.String_765 + " - code BocShow " + num3, @class.class58_0, new object[0]);
										@class.class58_0.class75_0.long_36 = @class.class58_0.method_232();
									}
								}
								else
								{
									@class.class58_0.class114_0.int_6 = num3;
								}
								if (@class.class58_0.class108_0 != null && @class.class58_0.class114_0.int_6 == 0 && @class.class58_0.class108_0.int_3 != 0)
								{
									@class.class58_0.class108_0.int_3 = 0;
									@class.class58_0.class108_0.list_3.Clear();
									goto IL_6428;
								}
								goto IL_6428;
							}
							else if (a == "rm36" && @class.class58_0.class114_0.bool_152)
							{
								if (@class.class58_0.class114_0 == null || num8 != 3)
								{
									goto IL_6428;
								}
								if (num3 == 0 || num3 == 1)
								{
									@class.class58_0.class114_0.int_7 = num3;
									goto IL_6428;
								}
								if (@class.class58_0.class75_0.Boolean_0 && @class.class58_0.class114_0.isSceneTrans == 0 && @class.class58_0.class114_0.int_9 > 0 && frmLogin.class101_0.globalSettings_0.TipHuongDan && (@class.class58_0.class75_0.long_36 == 0L || @class.class58_0.method_232() - @class.class58_0.class75_0.long_36 > 300000L))
								{
									Class83.smethod_66(frmMain.String_765 + " - code SynthShow " + num3, @class.class58_0, new object[0]);
									@class.class58_0.class75_0.long_36 = @class.class58_0.method_232();
									goto IL_6428;
								}
								goto IL_6428;
							}
							else if (a == "rm37" && (@class.class58_0.class114_0.bool_152 || @class.class58_0.class114_0.bool_180))
							{
								if (@class.class58_0.class114_0 == null || num8 != 3)
								{
									goto IL_6428;
								}
								if (num3 == 0 || num3 == 1)
								{
									@class.class58_0.class114_0.int_8 = num3;
									goto IL_6428;
								}
								if (@class.class58_0.class75_0.Boolean_0 && @class.class58_0.class114_0.isSceneTrans == 0 && @class.class58_0.class114_0.int_9 > 0 && frmLogin.class101_0.globalSettings_0.TipHuongDan && (@class.class58_0.class75_0.long_36 == 0L || @class.class58_0.method_232() - @class.class58_0.class75_0.long_36 > 300000L))
								{
									Class83.smethod_66(frmMain.String_765 + " - code InvenShow " + num3, @class.class58_0, new object[0]);
									@class.class58_0.class75_0.long_36 = @class.class58_0.method_232();
									goto IL_6428;
								}
								goto IL_6428;
							}
							else if (a == "rm32")
							{
								if (@class.class58_0.class114_0 == null || num3 == 0)
								{
									goto IL_6428;
								}
								if (num9 == 362)
								{
									num5 = num3 + 536;
								}
								else
								{
									if (num9 != 366 && num9 != 367)
									{
										if (num9 != 368)
										{
											if (num8 == 3)
											{
												num5 = num3 + 404;
												goto IL_2657;
											}
											if (num8 == 4)
											{
												num5 = num3 + 500;
												goto IL_2657;
											}
											if (num8 != 7)
											{
												if (num8 != 8)
												{
													if (num8 != 5)
													{
														if (num8 != 6)
														{
															if (num8 == 1 || num8 == 2)
															{
																num5 = num3 + 564;
																goto IL_2657;
															}
															goto IL_2657;
														}
													}
													num5 = num3 + 548;
													goto IL_2657;
												}
											}
											num5 = num3 + 564;
											goto IL_2657;
										}
									}
									num5 = num3 + 44;
								}
								IL_2657:
								num6 = 0f;
								Class101.smethod_42(@class.class58_0, ref num6, num5);
								if (@class.class58_0.class114_0.float_12 != num6)
								{
									@class.class58_0.class114_0.float_12 = num6;
									@class.class58_0.class114_0.float_13 = num6;
								}
								if (num9 == 362)
								{
									num5 = num3 + 540;
								}
								else
								{
									if (num9 != 366 && num9 != 367)
									{
										if (num9 != 368)
										{
											if (num8 == 3)
											{
												num5 = num3 + 408;
												goto IL_2749;
											}
											if (num8 == 4)
											{
												num5 = num3 + 504;
												goto IL_2749;
											}
											if (num8 != 7)
											{
												if (num8 != 8)
												{
													if (num8 != 5)
													{
														if (num8 != 6)
														{
															if (num8 == 1 || num8 == 2)
															{
																num5 = num3 + 568;
																goto IL_2749;
															}
															goto IL_2749;
														}
													}
													num5 = num3 + 552;
													goto IL_2749;
												}
											}
											num5 = num3 + 568;
											goto IL_2749;
										}
									}
									num5 = num3 + 52;
								}
								IL_2749:
								num6 = 0f;
								Class101.smethod_42(@class.class58_0, ref num6, num5);
								if (@class.class58_0.class114_0.float_15 != num6)
								{
									@class.class58_0.class114_0.float_15 = num6;
									@class.class58_0.class114_0.float_16 = num6;
									goto IL_6428;
								}
								goto IL_6428;
							}
							else if (a == "rm7")
							{
								if (@class.class58_0.class116_0 != null && num3 != 0)
								{
									num5 = 0;
									if (num8 == 3)
									{
										num = 240;
									}
									else if (num8 == 4)
									{
										num = 316;
									}
									else
									{
										if (num8 != 5)
										{
											if (num8 != 6)
											{
												if (num8 != 7)
												{
													if (num8 != 8)
													{
														if (num8 == 1 || num8 == 2)
														{
															num = 436;
															goto IL_281C;
														}
														goto IL_281C;
													}
												}
												num = 416;
												goto IL_281C;
											}
										}
										num = 360;
									}
									IL_281C:
									for (int l = 0; l < 10; l++)
									{
										num2 = 0;
										bool flag2 = false;
										string a2 = @class.class58_0.class116_0.list_0[l].string_0;
										if (a2 == "")
										{
											flag2 = true;
										}
										if (a2 == @class.class58_0.class116_0.String_2 || a2 == @class.class58_0.class116_0.String_1 || a2 == @class.class58_0.class116_0.String_0 || flag2 || @class.class58_0.class116_0.list_0[l].int_5 == @class.class58_0.class116_0.int_2)
										{
											flag2 = true;
											if (num8 == 3)
											{
												goto IL_28F6;
											}
											if (num8 == 4)
											{
												goto IL_28F6;
											}
											num5 = num3 + l * num + 68;
											IL_2902:
											num2 = 0;
											Class101.smethod_35(@class.class58_0, ref num2, num5);
											@class.class58_0.class116_0.list_0[l].int_0 = num2;
											if (num2 != -1)
											{
												if (num8 == 3)
												{
													goto IL_2956;
												}
												if (num8 == 4)
												{
													goto IL_2956;
												}
												num5 = num3 + l * num + 72;
												IL_2962:
												num2 = 0;
												Class101.smethod_35(@class.class58_0, ref num2, num5);
												@class.class58_0.class116_0.list_0[l].int_1 = num2;
												goto IL_2992;
												IL_2956:
												num5 = num3 + l * num + 64;
												goto IL_2962;
											}
											if (@class.class58_0.class116_0.list_0[l].string_0 != "")
											{
												@class.class58_0.class116_0.list_0[l].string_0 = "";
												break;
											}
											break;
											IL_28F6:
											num5 = num3 + l * num + 60;
											goto IL_2902;
										}
										IL_2992:
										if (@class.class58_0.class75_0.bool_26)
										{
											if (num8 == 3)
											{
												goto IL_29C1;
											}
											if (num8 == 4)
											{
												goto IL_29C1;
											}
											num5 = num3 + l * num + 12;
											IL_29CC:
											num2 = 0;
											Class101.smethod_35(@class.class58_0, ref num2, num5);
											bool flag3 = true;
											if (@class.class58_0.class116_0.list_0[l].int_5 != num2)
											{
												@class.class58_0.class116_0.list_0[l].int_5 = num2;
											}
											else
											{
												flag3 = false;
											}
											if (num2 >= 1)
											{
												if (flag2 && (a2 == @class.class58_0.class116_0.String_2 || a2 == @class.class58_0.class116_0.String_1 || a2 == @class.class58_0.class116_0.String_0 || @class.class58_0.class116_0.list_0[l].int_5 == @class.class58_0.class116_0.int_2))
												{
													if (num8 == 3)
													{
														goto IL_2AC9;
													}
													if (num8 == 4)
													{
														goto IL_2AC9;
													}
													num5 = num3 + l * num + 84;
													IL_2AD5:
													num2 = 0;
													Class101.smethod_35(@class.class58_0, ref num2, num5);
													@class.class58_0.class116_0.list_0[l].int_2 = num2;
													if (num8 == 3)
													{
														goto IL_2B1F;
													}
													if (num8 == 4)
													{
														goto IL_2B1F;
													}
													num5 = num3 + l * num + 16;
													IL_2B2B:
													num2 = 0;
													Class101.smethod_35(@class.class58_0, ref num2, num5);
													@class.class58_0.class116_0.list_0[l].int_3 = num2;
													goto IL_2B5B;
													IL_2B1F:
													num5 = num3 + l * num + 12;
													goto IL_2B2B;
													IL_2AC9:
													num5 = num3 + l * num + 76;
													goto IL_2AD5;
												}
												IL_2B5B:
												if (flag3 || a2 == "")
												{
													if (num8 == 1 || num8 == 2)
													{
														num5 = num3 + l * num + 56;
													}
													num2 = 0;
													Class101.smethod_35(@class.class58_0, ref num2, num5);
													@class.class58_0.class116_0.list_0[l].int_4 = num2;
													if (num8 == 3)
													{
														goto IL_2BD0;
													}
													if (num8 == 4)
													{
														goto IL_2BD0;
													}
													num5 = num3 + l * num + 52;
													IL_2BDC:
													Class101.smethod_35(@class.class58_0, ref num5, num5);
													if (num5 == 31)
													{
														if (num8 == 3)
														{
															goto IL_2C0B;
														}
														if (num8 == 4)
														{
															goto IL_2C0B;
														}
														num5 = num3 + l * num + 32;
														IL_2C17:
														Class101.smethod_35(@class.class58_0, ref num5, num5);
														goto IL_2C4E;
														IL_2C0B:
														num5 = num3 + l * num + 28;
														goto IL_2C17;
													}
													if (num8 != 3)
													{
														if (num8 != 4)
														{
															num5 = num3 + l * num + 32;
															goto IL_2C4E;
														}
													}
													num5 = num3 + l * num + 28;
													IL_2C4E:
													if (@class.class58_0.class114_0 != null && @class.class58_0.class114_0.MapID >= 0)
													{
														Class101.smethod_39(@class.class58_0, ref string_, num5);
														@class.class58_0.class116_0.list_0[l].string_0 = string_;
													}
													if (num8 == 3)
													{
														goto IL_2CB4;
													}
													if (num8 == 4)
													{
														goto IL_2CB4;
													}
													num5 = num3 + l * num + 8;
													IL_2CBF:
													num2 = 0;
													Class101.smethod_35(@class.class58_0, ref num2, num5);
													@class.class58_0.class116_0.list_0[l].int_6 = num2;
													if (@class.class58_0.class75_0.bool_26)
													{
														if (num8 == 3)
														{
															num5 = num3 + l * num + 204;
														}
														else if (num8 == 4)
														{
															num5 = num3 + l * num + 256;
														}
														else
														{
															num5 = num3 + l * num + 304;
														}
														num2 = 0;
														Class101.smethod_35(@class.class58_0, ref num2, num5);
														Class101.smethod_35(@class.class58_0, ref num2, num2);
														Class101.smethod_35(@class.class58_0, ref num2, num2);
														Class101.smethod_35(@class.class58_0, ref num2, num2);
														@class.class58_0.class116_0.list_0[l].int_8 = num2;
														num2 = 0;
														Class101.smethod_35(@class.class58_0, ref num2, num5);
														Class101.smethod_35(@class.class58_0, ref num2, num2 + 4);
														Class101.smethod_35(@class.class58_0, ref num2, num2);
														Class101.smethod_35(@class.class58_0, ref num2, num2);
														@class.class58_0.class116_0.list_0[l].int_9 = num2;
														num2 = 0;
														Class101.smethod_35(@class.class58_0, ref num2, num5);
														Class101.smethod_35(@class.class58_0, ref num2, num2 + 8);
														Class101.smethod_35(@class.class58_0, ref num2, num2);
														Class101.smethod_35(@class.class58_0, ref num2, num2);
														@class.class58_0.class116_0.list_0[l].int_10 = num2;
														num2 = 0;
														Class101.smethod_35(@class.class58_0, ref num2, num5);
														Class101.smethod_35(@class.class58_0, ref num2, num2 + 12);
														Class101.smethod_35(@class.class58_0, ref num2, num2);
														Class101.smethod_35(@class.class58_0, ref num2, num2);
														@class.class58_0.class116_0.list_0[l].int_11 = num2;
														goto IL_2EBA;
													}
													goto IL_2EBA;
													IL_2CB4:
													num5 = num3 + l * num + 4;
													goto IL_2CBF;
													IL_2BD0:
													num5 = num3 + l * num + 48;
													goto IL_2BDC;
												}
												goto IL_2EBA;
											}
											else
											{
												if (@class.class58_0.class116_0.list_0[l].string_0 != "")
												{
													@class.class58_0.class116_0.list_0[l].string_0 = "";
													break;
												}
												break;
											}
											IL_29C1:
											num5 = num3 + l * num + 8;
											goto IL_29CC;
										}
										IL_2EBA:;
									}
									goto IL_6428;
								}
								goto IL_6428;
							}
							else if (a == "rm19")
							{
								if (@class.class58_0.class114_0 != null)
								{
									if (num3 != @class.class58_0.class114_0.MapID)
									{
										if (@class.class58_0.class118_0 != null)
										{
											@class.class58_0.class118_0.list_1.Clear();
											@class.class58_0.class118_0.int_2 = -1;
											@class.class58_0.class118_0.int_5 = -1;
											@class.class58_0.class118_0.float_0 = 0f;
											@class.class58_0.class118_0.int_4 = 0;
										}
										if (@class.class58_0.class118_0.list_4.Count > 0)
										{
											@class.class58_0.class118_0.list_4.Clear();
										}
										if (@class.class58_0.class108_0 != null)
										{
											@class.class58_0.class108_0.list_4.Clear();
											@class.class58_0.class108_0.int_3 = 0;
											@class.class58_0.class108_0.float_0 = 0f;
											@class.class58_0.class108_0.float_1 = 0f;
											@class.class58_0.class108_0.long_0 = 0L;
										}
									}
									@class.class58_0.class114_0.MapID = num3;
									goto IL_6428;
								}
								goto IL_6428;
							}
							else if (a == "rm41")
							{
								if (@class.class58_0.class114_0 != null)
								{
									@class.class58_0.class114_0.mapIDforLUA = num3;
									goto IL_6428;
								}
								goto IL_6428;
							}
							else if (a == "rm23")
							{
								if (@class.class58_0.class114_0 != null)
								{
									for (int m = 0; m < 30; m++)
									{
										if (num9 == 362)
										{
											num5 = 264 + num3 + m * 8;
										}
										else if (num9 == 366)
										{
											num5 = 268 + num3 + m * 8;
										}
										else
										{
											if (num9 != 367)
											{
												if (num9 != 368)
												{
													if (num8 == 3)
													{
														num5 = 180 + num3 + m * 8;
														goto IL_31FB;
													}
													if (num8 == 4)
													{
														num5 = 184 + num3 + m * 8;
														goto IL_31FB;
													}
													if (num8 != 7)
													{
														if (num8 != 8)
														{
															if (num8 != 1)
															{
																if (num8 != 2)
																{
																	num5 = 252 + num3 + m * 8;
																	goto IL_31FB;
																}
															}
															num5 = 260 + num3 + m * 8;
															goto IL_31FB;
														}
													}
													num5 = 252 + num3 + m * 12;
													goto IL_31FB;
												}
											}
											num5 = 288 + num3 + m * 8;
										}
										IL_31FB:
										int value2 = -1;
										Class101.smethod_35(@class.class58_0, ref value2, num5);
										@class.class58_0.class114_0.list_5[m] = value2;
									}
									goto IL_6428;
								}
								goto IL_6428;
							}
							else if (a == "rm9")
							{
								if (@class.class58_0.class126_0 != null && num3 != 0)
								{
									num5 = 0;
									num2 = 0;
									num = 0;
									int n = 0;
									while (n <= @class.class58_0.class126_0.int_1)
									{
										num5 = num3 + n * 4;
										Class101.smethod_35(@class.class58_0, ref num2, num5);
										int num14 = 0;
										if (num8 == 7 || num8 == 8 || num8 == 1 || num8 == 2)
										{
											num14 = 4;
										}
										bool flag4 = true;
										if (num8 == 7 || num8 == 8 || num8 == 1 || num8 == 2)
										{
											num5 = num2;
											num = 0;
											Class101.smethod_35(@class.class58_0, ref num, num5);
											@class.class58_0.class126_0.list_0[n].int_1 = num;
										}
										num5 = num2 + num14;
										num = 0;
										Class101.smethod_35(@class.class58_0, ref num, num5);
										if (@class.class58_0.class126_0.list_0[n].int_0 != num)
										{
											@class.class58_0.class126_0.list_0[n].int_0 = num;
											flag4 = false;
										}
										if (@class.class58_0.class75_0.bool_26)
										{
											num5 = num2 + 4 + num14;
											num = 0;
											Class101.smethod_35(@class.class58_0, ref num, num5);
											@class.class58_0.class126_0.list_0[n].int_2 = num;
											num5 = num2 + 8 + num14;
											Class101.smethod_38(@class.class58_0, ref num, num5);
											@class.class58_0.class126_0.list_0[n].int_3 = num;
										}
										if (num8 == 1 || num8 == 2)
										{
											num14 += 40;
										}
										if (!flag4 || @class.class58_0.class126_0.list_0[n].string_0 == "")
										{
											if (num8 == 3)
											{
												goto IL_341A;
											}
											if (num8 == 4)
											{
												goto IL_341A;
											}
											num5 = num2 + 20 + num14;
											IL_3421:
											if (@class.class58_0.class114_0 != null && @class.class58_0.class114_0.MapID >= 0)
											{
												Class101.smethod_39(@class.class58_0, ref string_, num5);
												@class.class58_0.class126_0.list_0[n].string_0 = string_;
											}
											if (num8 == 3)
											{
												goto IL_3486;
											}
											if (num8 == 4)
											{
												goto IL_3486;
											}
											num5 = num2 + 52 + num14;
											IL_348D:
											num = 0;
											Class101.smethod_35(@class.class58_0, ref num, num5);
											@class.class58_0.class126_0.list_0[n].int_6 = num;
											goto IL_34BB;
											IL_3486:
											num5 = num2 + 48;
											goto IL_348D;
											IL_341A:
											num5 = num2 + 16;
											goto IL_3421;
										}
										IL_34BB:
										if (@class.class58_0.class75_0.bool_25 || !flag4)
										{
											if (num8 == 3)
											{
												goto IL_34E9;
											}
											if (num8 == 4)
											{
												goto IL_34E9;
											}
											num5 = num2 + 60 + num14;
											IL_34F0:
											num = 0;
											Class101.smethod_35(@class.class58_0, ref num, num5);
											@class.class58_0.class126_0.list_0[n].int_7 = num;
											goto IL_351E;
											IL_34E9:
											num5 = num2 + 56;
											goto IL_34F0;
										}
										IL_351E:
										if (num8 == 3)
										{
											goto IL_3536;
										}
										if (num8 == 4)
										{
											goto IL_3536;
										}
										num5 = num2 + 68 + num14;
										IL_353D:
										num6 = 0f;
										Class101.smethod_42(@class.class58_0, ref num6, num5);
										@class.class58_0.class126_0.list_0[n].float_0 = num6;
										if (num8 == 3)
										{
											goto IL_3589;
										}
										if (num8 == 4)
										{
											goto IL_3589;
										}
										num5 = num2 + 72 + num14;
										IL_3590:
										num6 = 0f;
										Class101.smethod_42(@class.class58_0, ref num6, num5);
										@class.class58_0.class126_0.list_0[n].float_1 = num6;
										if (num8 == 3)
										{
											goto IL_35DC;
										}
										if (num8 == 4)
										{
											goto IL_35DC;
										}
										num5 = num2 + 76 + num14;
										IL_35E3:
										num = 0;
										Class101.smethod_35(@class.class58_0, ref num, num5);
										@class.class58_0.class126_0.list_0[n].int_4 = num;
										if (num8 == 3)
										{
											goto IL_3629;
										}
										if (num8 == 4)
										{
											goto IL_3629;
										}
										num5 = num2 + 80 + num14;
										IL_3630:
										num = 0;
										Class101.smethod_35(@class.class58_0, ref num, num5);
										@class.class58_0.class126_0.list_0[n].int_5 = num;
										n++;
										continue;
										IL_3629:
										num5 = num2 + 76;
										goto IL_3630;
										IL_35DC:
										num5 = num2 + 72;
										goto IL_35E3;
										IL_3589:
										num5 = num2 + 68;
										goto IL_3590;
										IL_3536:
										num5 = num2 + 64;
										goto IL_353D;
									}
									goto IL_6428;
								}
								goto IL_6428;
							}
							else if (a == "rm18")
							{
								if (@class.class58_0.class114_0 != null)
								{
									@class.class58_0.class114_0.ActionStatus = b;
									goto IL_6428;
								}
								goto IL_6428;
							}
							else if (a == "rm11")
							{
								if (@class.class58_0.class120_0 == null || !@class.class58_0.class75_0.bool_20)
								{
									goto IL_6428;
								}
								num5 = 0;
								num = 0;
								@class.class58_0.class120_0.int_6 = @class.class58_0.class120_0.list_4[1].int_0;
								for (int num15 = 0; num15 < 10; num15++)
								{
									num5 = num3 + 4 + num15 * 24;
									num = 0;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									num2 = @class.class58_0.class120_0.list_4[num15 + 1].int_0;
									@class.class58_0.class120_0.list_4[num15 + 1].int_0 = num;
									if (num2 != num || !@class.class58_0.class120_0.list_4[num15 + 1].bool_1)
									{
										@class.class58_0.class120_0.list_3.Add(num15 + 1);
										if (@class.class58_0.method_218(num))
										{
											if (num2 == num - 1)
											{
												@class.class58_0.class75_0.int_26 = num;
												@class.class58_0.class75_0.long_33 = @class.class58_0.method_232();
											}
											else
											{
												@class.class58_0.class75_0.int_26 = -1;
											}
										}
									}
								}
								Class83.smethod_146(@class.class58_0);
								if (@class.class58_0.class75_0.bool_26)
								{
									for (int num16 = 10; num16 < 30; num16++)
									{
										num5 = num3 + 724 + (num16 - 10) * 24;
										num = 0;
										Class101.smethod_35(@class.class58_0, ref num, num5);
										num2 = @class.class58_0.class120_0.list_4[num16 + 1].int_0;
										@class.class58_0.class120_0.list_4[num16 + 1].int_0 = num;
										if (num2 != num || !@class.class58_0.class120_0.list_4[num16 + 1].bool_1)
										{
											@class.class58_0.class120_0.list_3.Add(num16 + 1);
											if (@class.class58_0.method_218(num))
											{
												if (num2 == num - 1)
												{
													@class.class58_0.class75_0.int_26 = num;
													@class.class58_0.class75_0.long_33 = @class.class58_0.method_232();
												}
												else
												{
													@class.class58_0.class75_0.int_26 = -1;
												}
											}
										}
									}
									int num17 = 30;
									while (num17 < 40)
									{
										if (num8 == 3)
										{
											goto IL_3977;
										}
										if (num8 == 4)
										{
											goto IL_3977;
										}
										num5 = num3 + 1444 + (num17 - 30) * 24;
										IL_398A:
										num = 0;
										Class101.smethod_35(@class.class58_0, ref num, num5);
										num2 = @class.class58_0.class120_0.list_4[num17 + 1].int_0;
										@class.class58_0.class120_0.list_4[num17 + 1].int_0 = num;
										if (num2 != num || !@class.class58_0.class120_0.list_4[num17 + 1].bool_1)
										{
											@class.class58_0.class120_0.list_3.Add(num17 + 1);
											if (@class.class58_0.method_218(num))
											{
												if (num2 == num - 1)
												{
													@class.class58_0.class75_0.int_26 = num;
													@class.class58_0.class75_0.long_33 = @class.class58_0.method_232();
												}
												else
												{
													@class.class58_0.class75_0.int_26 = -1;
												}
											}
										}
										num17++;
										continue;
										IL_3977:
										num5 = num3 + 484 + (num17 - 30) * 24;
										goto IL_398A;
									}
									int num18 = 40;
									while (num18 < 50)
									{
										if (num8 == 3)
										{
											goto IL_3AA5;
										}
										if (num8 == 4)
										{
											goto IL_3AA5;
										}
										num5 = num3 + 1684 + (num18 - 40) * 24;
										IL_3AB8:
										num = 0;
										Class101.smethod_35(@class.class58_0, ref num, num5);
										num2 = @class.class58_0.class120_0.list_4[num18 + 1].int_0;
										@class.class58_0.class120_0.list_4[num18 + 1].int_0 = num;
										if (num2 != num || !@class.class58_0.class120_0.list_4[num18 + 1].bool_1)
										{
											@class.class58_0.class120_0.list_3.Add(num18 + 1);
											if (@class.class58_0.method_218(num))
											{
												if (num2 == num - 1)
												{
													@class.class58_0.class75_0.int_26 = num;
													@class.class58_0.class75_0.long_33 = @class.class58_0.method_232();
												}
												else
												{
													@class.class58_0.class75_0.int_26 = -1;
												}
											}
										}
										num18++;
										continue;
										IL_3AA5:
										num5 = num3 + 244 + (num18 - 40) * 24;
										goto IL_3AB8;
									}
								}
								if ((!@class.class58_0.class120_0.bool_0 && @class.class58_0.class75_0.bool_20) || (@class.class58_0.class75_0.long_28 != 0L && @class.class58_0.method_232() - @class.class58_0.class75_0.long_28 >= 5000L && @class.class58_0.class75_0.int_20 < 2))
								{
									int num19 = 0;
									IL_3EAF:
									while (num19 < @class.class58_0.class120_0.list_2.Count)
									{
										for (int num20 = 0; num20 < frmLogin.class101_0.list_10.Count; num20++)
										{
											if (@class.class58_0.class120_0.list_2[num19].int_1 == frmLogin.class101_0.list_10[num20].int_0 && @class.class58_0.class120_0.list_2[num19].int_2 == frmLogin.class101_0.list_10[num20].int_1)
											{
												if (@class.class58_0.class114_0.Menpai != frmLogin.class101_0.list_10[num20].menpais_0)
												{
													if (frmLogin.class101_0.list_10[num20].menpais_0 != Class57.Menpais.ALLPHAI)
													{
														goto IL_3CDB;
													}
												}
												@class.class58_0.class120_0.list_2[num19].int_0 = frmLogin.class101_0.list_10[num20].int_2;
												@class.class58_0.class120_0.list_2[num19].int_4 = frmLogin.class101_0.list_10[num20].int_3;
												@class.class58_0.class120_0.list_2[num19].int_5 = frmLogin.class101_0.list_10[num20].int_7;
												@class.class58_0.class120_0.list_2[num19].int_6 = frmLogin.class101_0.list_10[num20].int_8;
												@class.class58_0.class120_0.list_2[num19].int_7 = frmLogin.class101_0.list_10[num20].int_4;
												@class.class58_0.class120_0.list_2[num19].int_8 = frmLogin.class101_0.list_10[num20].int_5;
												@class.class58_0.class120_0.list_2[num19].int_9 = frmLogin.class101_0.list_10[num20].int_9;
												@class.class58_0.class120_0.list_2[num19].int_10 = frmLogin.class101_0.list_10[num20].int_6;
												@class.class58_0.class120_0.list_2[num19].bool_0 = true;
												IL_3EA9:
												num19++;
												goto IL_3EAF;
											}
											IL_3CDB:;
										}
										goto IL_3EA9;
									}
									if (@class.class58_0.class114_0.Menpai != Class57.Menpais.THIEULAM)
									{
										@class.class58_0.class120_0.bool_0 = true;
										@class.class58_0.class75_0.int_20 = 5;
									}
									else
									{
										@class.class58_0.class75_0.int_20++;
										if (@class.class58_0.class75_0.long_28 == 0L)
										{
											@class.class58_0.class75_0.long_28 = @class.class58_0.method_232();
										}
										if (@class.class58_0.class75_0.int_20 >= 2)
										{
											@class.class58_0.class120_0.bool_0 = true;
										}
									}
								}
								if (@class.class58_0.class120_0.list_3.Count > 0 && @class.class58_0.class120_0.bool_0)
								{
									try
									{
										int num21 = 0;
										IL_44EC:
										while (num21 < @class.class58_0.class120_0.list_3.Count)
										{
											for (int num22 = 0; num22 < @class.class58_0.class120_0.list_2.Count; num22++)
											{
												if (@class.class58_0.class120_0.list_2[num22].int_0 == @class.class58_0.class120_0.list_4[@class.class58_0.class120_0.list_3[num21]].int_0)
												{
													@class.class58_0.class120_0.list_4[@class.class58_0.class120_0.list_3[num21]].int_1 = @class.class58_0.class120_0.list_2[num22].int_1;
													@class.class58_0.class120_0.list_4[@class.class58_0.class120_0.list_3[num21]].int_2 = @class.class58_0.class120_0.list_2[num22].int_2;
													@class.class58_0.class120_0.list_4[@class.class58_0.class120_0.list_3[num21]].int_3 = num22;
													@class.class58_0.class120_0.list_4[@class.class58_0.class120_0.list_3[num21]].int_5 = @class.class58_0.class120_0.list_2[num22].int_4;
													@class.class58_0.class120_0.list_4[@class.class58_0.class120_0.list_3[num21]].int_6 = @class.class58_0.class120_0.list_2[num22].int_5;
													@class.class58_0.class120_0.list_4[@class.class58_0.class120_0.list_3[num21]].int_7 = @class.class58_0.class120_0.list_2[num22].int_6;
													@class.class58_0.class120_0.list_4[@class.class58_0.class120_0.list_3[num21]].int_8 = @class.class58_0.class120_0.list_2[num22].int_7;
													@class.class58_0.class120_0.list_4[@class.class58_0.class120_0.list_3[num21]].int_9 = @class.class58_0.class120_0.list_2[num22].int_8;
													@class.class58_0.class120_0.list_4[@class.class58_0.class120_0.list_3[num21]].int_10 = @class.class58_0.class120_0.list_2[num22].int_9;
													@class.class58_0.class120_0.list_4[@class.class58_0.class120_0.list_3[num21]].int_11 = @class.class58_0.class120_0.list_2[num22].int_10;
													@class.class58_0.class120_0.list_4[@class.class58_0.class120_0.list_3[num21]].bool_0 = @class.class58_0.class120_0.list_2[num22].bool_0;
													IL_4351:
													@class.class58_0.class120_0.list_4[@class.class58_0.class120_0.list_3[num21]].bool_1 = true;
													if (@class.class58_0.class114_0.Menpai != Class57.Menpais.QUYCOC)
													{
														@class.class58_0.class120_0.list_4[@class.class58_0.class120_0.list_3[num21]].string_0 = Class83.smethod_51(@class.class58_0.class120_0.list_4[@class.class58_0.class120_0.list_3[num21]].int_0);
													}
													else
													{
														@class.class58_0.class120_0.list_4[@class.class58_0.class120_0.list_3[num21]].string_0 = Class83.smethod_37(Class83.smethod_51(@class.class58_0.class120_0.list_4[@class.class58_0.class120_0.list_3[num21]].int_0));
													}
													@class.class58_0.class120_0.list_4[@class.class58_0.class120_0.list_3[num21]].string_1 = Class83.smethod_52(@class.class58_0.class120_0.list_4[@class.class58_0.class120_0.list_3[num21]].int_0, @class.class58_0);
													Class101.smethod_34(@class.class58_0, num21);
													num21++;
													goto IL_44EC;
												}
											}
											goto IL_4351;
										}
									}
									catch (Exception)
									{
										if (!@class.class58_0.class59_0.bool_12)
										{
											@class.class58_0.class59_0.bool_12 = true;
											Class83.smethod_66(frmMain.String_537, @class.class58_0, new object[0]);
										}
									}
									finally
									{
										@class.class58_0.class120_0.list_3.Clear();
									}
								}
								if (@class.class58_0.class114_0 != null)
								{
									num5 = num3 + 1204;
									num = 0;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class114_0.int_70 = num;
									num5 = num3 + 1228;
									num = 0;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class114_0.int_71 = num;
									num5 = num3 + 1252;
									num = 0;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class114_0.int_72 = num;
									num5 = num3 + 1276;
									num = 0;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class114_0.int_73 = num;
									goto IL_6428;
								}
								goto IL_6428;
							}
							else if (a == "rm31")
							{
								if (@class.class58_0.class116_0 == null || !@class.class58_0.class75_0.bool_26)
								{
									goto IL_6428;
								}
								if (@class.class58_0.class75_0.int_52 >= 0)
								{
									Class101.smethod_62(@class.class58_0, @class.class58_0.class75_0.int_52, num3);
								}
								if (@class.class58_0.class75_0.int_53 >= 0)
								{
									Class101.smethod_62(@class.class58_0, @class.class58_0.class75_0.int_53, num3);
								}
								if (@class.class58_0.class75_0.int_54 >= 0)
								{
									Class101.smethod_62(@class.class58_0, @class.class58_0.class75_0.int_54, num3);
								}
								if (@class.class58_0.method_228(10, 60000))
								{
									num5 = 0;
									@class.class58_0.class75_0.int_52 = -1;
									@class.class58_0.class75_0.int_53 = -1;
									@class.class58_0.class75_0.int_54 = -1;
									for (int num23 = 0; num23 < 10; num23++)
									{
										Class101.smethod_62(@class.class58_0, num23, num3);
										if (@class.class58_0.class116_0.list_0[num23].string_0 == @class.class58_0.class116_0.String_2)
										{
											@class.class58_0.class75_0.int_52 = num23;
										}
										if (@class.class58_0.class116_0.list_0[num23].string_0 == @class.class58_0.class116_0.String_1)
										{
											@class.class58_0.class75_0.int_53 = num23;
										}
										if (@class.class58_0.class116_0.list_0[num23].string_0 == @class.class58_0.class116_0.String_0)
										{
											@class.class58_0.class75_0.int_54 = num23;
										}
									}
									goto IL_6428;
								}
								goto IL_6428;
							}
							else if (a == "rm24")
							{
								if (@class.class58_0.class126_0 == null || num3 == 0)
								{
									goto IL_6428;
								}
								num5 = 0;
								num2 = 0;
								num = 0;
								int num24 = num3;
								bool flag5 = false;
								int num25 = 240;
								for (int num26 = 0; num26 < 5; num26++)
								{
									num3 = num24 + num26 * 4;
									num2 = 0;
									Class101.smethod_35(@class.class58_0, ref num2, num3);
									num3 = num2 + 4;
									num2 = 0;
									Class101.smethod_35(@class.class58_0, ref num2, num3);
									num3 = num2;
									for (int num27 = 0; num27 < 6; num27++)
									{
										num5 = num3 + num27 * 4;
										num2 = 0;
										Class101.smethod_35(@class.class58_0, ref num2, num5);
										Class101.smethod_35(@class.class58_0, ref num2, num5);
										bool flag6 = true;
										num5 = num2 + 4;
										num = 0;
										Class101.smethod_35(@class.class58_0, ref num, num5);
										int index = num26 * 6 + num27;
										if (num < 10000)
										{
											if (@class.class58_0.class91_0.list_0[index].int_0 > 0)
											{
												@class.class58_0.class91_0.list_0[index].int_0 = 0;
												@class.class58_0.class91_0.list_0[index].int_1 = 0;
												@class.class58_0.class91_0.list_0[index].int_2 = 0;
												@class.class58_0.class91_0.list_0[index].string_0 = "";
												@class.class58_0.class91_0.list_0[index].int_3 = -1;
												@class.class58_0.class91_0.list_0[index].int_4 = 0;
											}
										}
										else
										{
											flag5 = true;
											if (@class.class58_0.class91_0.list_0[index].int_0 != num)
											{
												@class.class58_0.class91_0.list_0[index].int_0 = num;
												flag6 = false;
											}
											if (!flag6)
											{
												num5 = num2;
												num = 0;
												Class101.smethod_35(@class.class58_0, ref num, num5);
												@class.class58_0.class91_0.list_0[index].int_1 = num;
											}
											int num28 = 0;
											if (num8 == 7 || num8 == 8 || num8 == 1 || num8 == 2)
											{
												num28 = 4;
											}
											if (@class.class58_0.class75_0.bool_25)
											{
												num5 = num2 + 4 + num28;
												num = 0;
												Class101.smethod_35(@class.class58_0, ref num, num5);
												@class.class58_0.class91_0.list_0[index].int_2 = num;
												num5 = num2 + 8 + num28;
												num = 0;
												Class101.smethod_38(@class.class58_0, ref num, num5);
												@class.class58_0.class91_0.list_0[index].int_3 = num;
											}
											if (!flag6)
											{
												num5 = num2 + 16 + num28;
												if (@class.class58_0.class114_0 != null && @class.class58_0.class114_0.MapID >= 0)
												{
													Class101.smethod_39(@class.class58_0, ref string_, num5);
													@class.class58_0.class91_0.list_0[index].string_0 = string_;
												}
												num5 = num2 + 48 + num28;
												num = 0;
												Class101.smethod_38(@class.class58_0, ref num, num5);
												@class.class58_0.class91_0.list_0[index].int_6 = num;
												num5 = num2 + 56 + num28;
												num = 0;
												Class101.smethod_35(@class.class58_0, ref num, num5);
												@class.class58_0.class91_0.list_0[index].int_7 = num;
											}
											num5 = num2 + 64 + num28;
											Class101.smethod_42(@class.class58_0, ref num6, num5);
											@class.class58_0.class91_0.list_0[index].float_0 = num6;
											num5 = num2 + 68 + num28;
											num6 = 0f;
											Class101.smethod_42(@class.class58_0, ref num6, num5);
											@class.class58_0.class91_0.list_0[index].float_1 = num6;
											num5 = num2 + 72 + num28;
											num = 0;
											Class101.smethod_35(@class.class58_0, ref num, num5);
											@class.class58_0.class91_0.list_0[index].int_4 = num;
											num5 = num2 + 76 + num28;
											num = 0;
											Class101.smethod_35(@class.class58_0, ref num, num5);
											@class.class58_0.class91_0.list_0[index].int_5 = num;
											num25 += 4;
										}
									}
									num25 += 24;
								}
								if (flag5)
								{
									@class.class58_0.class75_0.long_55 = Class101.smethod_61() + 20000L;
									goto IL_6428;
								}
								goto IL_6428;
							}
							else if (a == "rm16" && (@class.class58_0.autoSettings_0.AIMode == Class57.AIModes.NHIEMVU || @class.class58_0.class75_0.bool_26))
							{
								if (@class.class58_0.class112_0 != null && num3 != 0)
								{
									num5 = 0;
									num = 0;
									int num29 = 0;
									while (num29 < 90)
									{
										num5 = num3 + num29 * 4;
										Class101.smethod_35(@class.class58_0, ref num, num5);
										num += 20;
										Class101.smethod_35(@class.class58_0, ref num5, num);
										num2 = num5;
										num5 = num2;
										int num30 = @class.class58_0.class112_0.list_1[num29].int_4;
										Class101.smethod_35(@class.class58_0, ref num, num5);
										if (num8 == 7 || num8 == 8 || num8 == 1)
										{
											goto IL_4DF5;
										}
										if (num8 == 2)
										{
											goto IL_4DF5;
										}
										@class.class58_0.class112_0.list_1[num29].int_4 = num;
										IL_4E12:
										num5 = num2 + 4;
										int num31 = @class.class58_0.class112_0.list_1[num29].int_5;
										Class101.smethod_35(@class.class58_0, ref num, num5);
										if (num8 == 7 || num8 == 8 || num8 == 1)
										{
											goto IL_4E7A;
										}
										if (num8 == 2)
										{
											goto IL_4E7A;
										}
										@class.class58_0.class112_0.list_1[num29].int_5 = num;
										IL_4E97:
										num5 = num2 + 8;
										int num32 = @class.class58_0.class112_0.list_1[num29].int_0;
										num = -1;
										Class101.smethod_35(@class.class58_0, ref num, num5);
										@class.class58_0.class112_0.list_1[num29].int_0 = num;
										if (@class.class58_0.class112_0.list_1[num29].int_0 != num32 && @class.class58_0.class112_0.list_1[num29].int_0 >= 0 && (@class.class58_0.class112_0.list_1[num29].int_5 != num31 || @class.class58_0.class112_0.list_1[num29].int_4 != num30))
										{
											@class.class58_0.class112_0.string_0 = "";
											@class.class58_0.class112_0.string_1 = "";
											Class83.smethod_130(@class.class58_0.class112_0.list_1[num29].int_0, out @class.class58_0.class112_0.string_0, out @class.class58_0.class112_0.string_1);
											@class.class58_0.class112_0.list_1[num29].string_0 = @class.class58_0.class112_0.string_0;
											@class.class58_0.class112_0.list_1[num29].string_1 = @class.class58_0.class112_0.string_1;
											@class.class58_0.class112_0.list_1[num29].byte_2 = 0;
											@class.class58_0.class112_0.list_1[num29].enum7_0 = Class57.Enum7.const_0;
											@class.class58_0.class112_0.list_1[num29].byte_1 = 0;
											@class.class58_0.class112_0.list_1[num29].int_6 = 0;
											@class.class58_0.class112_0.list_1[num29].list_0.Clear();
											@class.class58_0.class112_0.list_1[num29].long_0 = @class.class58_0.method_232();
										}
										int num33 = 0;
										if (num8 == 7 || num8 == 8 || num8 == 1 || num8 == 2)
										{
											num33 = 4;
										}
										if (num8 == 3)
										{
											num5 = num2 + 88;
										}
										else
										{
											num5 = num2 + 60 + num33;
										}
										Class101.smethod_41(@class.class58_0, ref num, num5);
										@class.class58_0.class112_0.list_1[num29].byte_0 = (byte)num;
										if (num8 == 3)
										{
											num5 = num2 + 76;
										}
										else
										{
											num5 = num2 + 48 + num33;
										}
										Class101.smethod_35(@class.class58_0, ref num, num5);
										@class.class58_0.class112_0.list_1[num29].int_1 = num;
										if (num8 == 3)
										{
											num5 = num2 + 80;
										}
										else if (num8 == 4)
										{
											num5 = num2 + 52;
										}
										else
										{
											num5 = num2 + 52 + num33;
										}
										Class101.smethod_35(@class.class58_0, ref num, num5);
										@class.class58_0.class112_0.list_1[num29].int_2 = num;
										Class101.smethod_38(@class.class58_0, ref num, num5);
										num32 = @class.class58_0.class112_0.list_1[num29].int_7;
										@class.class58_0.class112_0.list_1[num29].int_7 = num;
										num5 = num2 + 49 + num33;
										Class101.smethod_38(@class.class58_0, ref num, num5);
										@class.class58_0.class112_0.list_1[num29].int_8 = num;
										if (num8 == 3)
										{
											num5 = num2 + 79;
										}
										else if (num8 == 4)
										{
											num5 = num2 + 51;
										}
										else
										{
											num5 = num2 + 51 + num33;
										}
										num32 = (int)@class.class58_0.class112_0.list_1[num29].byte_3;
										Class101.smethod_41(@class.class58_0, ref num, num5);
										@class.class58_0.class112_0.list_1[num29].byte_3 = (byte)num;
										if (num32 != (int)@class.class58_0.class112_0.list_1[num29].byte_3)
										{
											Class83.smethod_119();
										}
										Class101.smethod_38(@class.class58_0, ref num, num5);
										@class.class58_0.class112_0.list_1[num29].int_9 = num;
										num5 = num2 + 53 + num33;
										Class101.smethod_38(@class.class58_0, ref num, num5);
										@class.class58_0.class112_0.list_1[num29].int_10 = num;
										num29++;
										continue;
										IL_4E7A:
										@class.class58_0.class112_0.list_1[num29].int_4 = num;
										goto IL_4E97;
										IL_4DF5:
										@class.class58_0.class112_0.list_1[num29].int_5 = num;
										goto IL_4E12;
									}
									goto IL_6428;
								}
								goto IL_6428;
							}
							else if (a == "rm22")
							{
								if (@class.class58_0.class114_0 == null)
								{
									goto IL_6428;
								}
								if ((byte)num3 != 0 && (byte)num3 != 1 && (byte)num3 != 255)
								{
									if (@class.class58_0.class75_0.Boolean_0 && @class.class58_0.class114_0.isSceneTrans == 0 && @class.class58_0.class114_0.int_9 > 0 && frmLogin.class101_0.globalSettings_0.TipHuongDan && (@class.class58_0.class75_0.long_36 == 0L || @class.class58_0.method_232() - @class.class58_0.class75_0.long_36 > 1800000L))
									{
										Class83.smethod_66(frmMain.String_765 + " - code PartyFollowed " + (byte)num3, @class.class58_0, new object[0]);
										@class.class58_0.class75_0.long_36 = @class.class58_0.method_232();
										goto IL_6428;
									}
									goto IL_6428;
								}
								else
								{
									@class.class58_0.class114_0.byte_1 = (byte)num3;
									if (@class.class58_0.class114_0.byte_1 == 1)
									{
										@class.class58_0.class114_0.byte_0 = 0;
										goto IL_6428;
									}
									goto IL_6428;
								}
							}
							else if (a == "rm30")
							{
								if (@class.class58_0.class120_0 != null)
								{
									num5 = 0;
									num = 0;
									if (@class.class58_0.class114_0.Menpai == Class57.Menpais.NGAMI)
									{
										num5 = num3 + 696;
										Class101.smethod_35(@class.class58_0, ref num, num5);
										@class.class58_0.class120_0.int_0 = num;
										num5 = num3 + 876;
										Class101.smethod_35(@class.class58_0, ref num, num5);
										@class.class58_0.class120_0.int_1 = num;
										num5 = num3 + 708;
										Class101.smethod_35(@class.class58_0, ref num, num5);
										@class.class58_0.class120_0.int_2 = num;
									}
									num5 = num3 + 660;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.int_3 = num;
									num5 = num3 + 720;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.int_4 = num;
									num5 = num3 + 756;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.int_5 = num;
									if (@class.class58_0.class75_0.bool_25)
									{
										num5 = num3 + 612;
										Class101.smethod_35(@class.class58_0, ref num, num5);
										@class.class58_0.class120_0.int_7 = num;
									}
									num = -2;
									num5 = num3 + 636;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.list_2[0].int_3 = num;
									num5 = num3 + 852;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.list_2[1].int_3 = num;
									num5 = num3 + 648;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.list_2[2].int_3 = num;
									num5 = num3 + 660;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.list_2[3].int_3 = num;
									num5 = num3 + 672;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.list_2[4].int_3 = num;
									num5 = num3 + 684;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.list_2[5].int_3 = num;
									num5 = num3 + 696;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.list_2[6].int_3 = num;
									num5 = num3 + 708;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.list_2[7].int_3 = num;
									num5 = num3 + 720;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.list_2[8].int_3 = num;
									num5 = num3 + 732;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.list_2[9].int_3 = num;
									num5 = num3 + 744;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.list_2[10].int_3 = num;
									num5 = num3 + 756;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.list_2[11].int_3 = num;
									num5 = num3 + 768;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.list_2[12].int_3 = num;
									num5 = num3 + 744;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.list_2[13].int_3 = num;
									num5 = num3 + 792;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.list_2[14].int_3 = num;
									num5 = num3 + 804;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.list_2[15].int_3 = num;
									num5 = num3 + 816;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.list_2[16].int_3 = num;
									num5 = num3 + 828;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.list_2[17].int_3 = num;
									num5 = num3 + 840;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.list_2[18].int_3 = num;
									if (@class.class58_0.class114_0.Menpai == Class57.Menpais.NGAMI)
									{
										num5 = num3 + 876;
									}
									else
									{
										num5 = num3 + 864;
									}
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.list_2[19].int_3 = num;
									if (@class.class58_0.class114_0.Menpai == Class57.Menpais.NGAMI)
									{
										num5 = num3 + 1416;
									}
									else
									{
										num5 = num3 + 876;
									}
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.list_2[20].int_3 = num;
									num5 = num3 + 1596;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.list_2[21].int_3 = num;
									num5 = num3 + 1560;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.list_2[22].int_3 = num;
									num5 = num3 + 1392;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.list_2[23].int_3 = num;
									num5 = num3 + 1284;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.list_2[24].int_3 = num;
									num5 = num3 + 1380;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.list_2[25].int_3 = num;
									num5 = num3 + 1236;
									Class101.smethod_35(@class.class58_0, ref num, num5);
									@class.class58_0.class120_0.list_2[26].int_3 = num;
									goto IL_6428;
								}
								goto IL_6428;
							}
							else if (a == "rm25")
							{
								if (@class.class58_0.class114_0 == null)
								{
									goto IL_6428;
								}
								if (num3 == 0 || num3 == 1)
								{
									@class.class58_0.class114_0.int_44 = num3;
									goto IL_6428;
								}
								if (@class.class58_0.class75_0.Boolean_0 && @class.class58_0.class114_0.isSceneTrans == 0 && @class.class58_0.class114_0.int_9 > 0 && frmLogin.class101_0.globalSettings_0.TipHuongDan && (@class.class58_0.class75_0.long_36 == 0L || @class.class58_0.method_232() - @class.class58_0.class75_0.long_36 > 1800000L))
								{
									Class83.smethod_66(frmMain.String_765 + " - code AcceptBox " + num3, @class.class58_0, new object[0]);
									@class.class58_0.class75_0.long_36 = @class.class58_0.method_232();
									goto IL_6428;
								}
								goto IL_6428;
							}
							else if (a == "rm26")
							{
								if (@class.class58_0.class114_0 == null)
								{
									goto IL_6428;
								}
								if (num3 == 0 || num3 == 1)
								{
									@class.class58_0.class114_0.int_45 = num3;
									goto IL_6428;
								}
								if (@class.class58_0.class75_0.Boolean_0 && @class.class58_0.class114_0.isSceneTrans == 0 && @class.class58_0.class114_0.int_9 > 0 && frmLogin.class101_0.globalSettings_0.TipHuongDan && (@class.class58_0.class75_0.long_36 == 0L || @class.class58_0.method_232() - @class.class58_0.class75_0.long_36 > 1800000L))
								{
									Class83.smethod_66(frmMain.String_765 + " - code MessageBox_Self " + num3, @class.class58_0, new object[0]);
									@class.class58_0.class75_0.long_36 = @class.class58_0.method_232();
									goto IL_6428;
								}
								goto IL_6428;
							}
							else if (a == "rm28")
							{
								if (@class.class58_0.class114_0 == null)
								{
									goto IL_6428;
								}
								if (b == 0 || b == 1)
								{
									@class.class58_0.class114_0.byte_2 = b;
									goto IL_6428;
								}
								if (@class.class58_0.class75_0.Boolean_0 && @class.class58_0.class114_0.isSceneTrans == 0 && @class.class58_0.class114_0.int_9 > 0 && frmLogin.class101_0.globalSettings_0.TipHuongDan && (@class.class58_0.class75_0.long_36 == 0L || @class.class58_0.method_232() - @class.class58_0.class75_0.long_36 > 300000L))
								{
									Class83.smethod_66(frmMain.String_765 + " - code AttackStatus " + b, @class.class58_0, new object[0]);
									@class.class58_0.class75_0.long_36 = @class.class58_0.method_232();
									goto IL_6428;
								}
								goto IL_6428;
							}
							else if (a == "rm29" && @class.class58_0.autoSettings_0.cboxPassCap2 && @class.class58_0.class75_0.bool_26)
							{
								if (@class.class58_0.class114_0 == null)
								{
									goto IL_6428;
								}
								if (num3 == 0 || num3 == 1)
								{
									@class.class58_0.class114_0.int_42 = num3;
									goto IL_6428;
								}
								if (@class.class58_0.class75_0.Boolean_0 && @class.class58_0.class114_0.isSceneTrans == 0 && @class.class58_0.class114_0.int_9 > 0 && frmLogin.class101_0.globalSettings_0.TipHuongDan && (@class.class58_0.class75_0.long_36 == 0L || @class.class58_0.method_232() - @class.class58_0.class75_0.long_36 > 300000L))
								{
									Class83.smethod_66(frmMain.String_765 + " - code Pass2box " + num3, @class.class58_0, new object[0]);
									@class.class58_0.class75_0.long_36 = @class.class58_0.method_232();
									goto IL_6428;
								}
								goto IL_6428;
							}
							else if (a == "rm33")
							{
								if (@class.class58_0.class114_0 == null)
								{
									goto IL_6428;
								}
								if (num3 == 0 || num3 == 1)
								{
									@class.class58_0.class114_0.int_46 = num3;
									goto IL_6428;
								}
								if (@class.class58_0.class75_0.Boolean_0 && @class.class58_0.class114_0.isSceneTrans == 0 && @class.class58_0.class114_0.int_9 > 0 && frmLogin.class101_0.globalSettings_0.TipHuongDan && (@class.class58_0.class75_0.long_36 == 0L || @class.class58_0.method_232() - @class.class58_0.class75_0.long_36 > 300000L))
								{
									Class83.smethod_66(frmMain.String_765 + " - code QuestFrame " + num3, @class.class58_0, new object[0]);
									@class.class58_0.class75_0.long_36 = @class.class58_0.method_232();
									goto IL_6428;
								}
								goto IL_6428;
							}
							else if (a == "rm34")
							{
								if (@class.class58_0.class114_0 != null)
								{
									@class.class58_0.class114_0.int_4 = num3;
									goto IL_6428;
								}
								goto IL_6428;
							}
							else if (a == "rm5")
							{
								if (@class.class58_0.class114_0 == null)
								{
									goto IL_6428;
								}
								if (num3 != 0 && num3 != 1 && num3 != -1)
								{
									if (@class.class58_0.class75_0.Boolean_0 && @class.class58_0.class114_0.isSceneTrans == 0 && @class.class58_0.class114_0.int_9 > 0 && frmLogin.class101_0.globalSettings_0.TipHuongDan && (@class.class58_0.class75_0.long_36 == 0L || @class.class58_0.method_232() - @class.class58_0.class75_0.long_36 > 300000L))
									{
										Class83.smethod_66(frmMain.String_765 + " - code hasTarget " + num3, @class.class58_0, new object[0]);
										@class.class58_0.class75_0.long_36 = @class.class58_0.method_232();
										goto IL_6428;
									}
									goto IL_6428;
								}
								else
								{
									if (num3 == 0)
									{
										if (@class.class58_0.class114_0.bool_25)
										{
											@class.class58_0.class114_0.long_80 = @class.class58_0.method_232();
										}
										@class.class58_0.class114_0.bool_25 = false;
										goto IL_6428;
									}
									@class.class58_0.class114_0.bool_25 = true;
									goto IL_6428;
								}
							}
							else
							{
								if (!(a == "rm40") || !frmLogin.class101_0.globalSettings_0.TuKetNoiLai)
								{
									goto IL_6428;
								}
								if (num3 != 1)
								{
									@class.class58_0.class75_0.long_47 = 0L;
									goto IL_6428;
								}
								if (@class.class58_0.class75_0.long_47 == 0L)
								{
									@class.class58_0.class75_0.long_47 = @class.class58_0.method_232();
									goto IL_6428;
								}
								if (@class.class58_0.method_232() - @class.class58_0.class75_0.long_47 > 5000L)
								{
									@class.class58_0.method_122(30, -1);
									@class.class58_0.class75_0.long_47 = 0L;
									goto IL_6428;
								}
								goto IL_6428;
							}
							IL_A35:
							@class.class58_0.class114_0.int_9 = 0;
							goto IL_A46;
						}
					}
					IL_6428:;
				}
			}
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0008E5FC File Offset: 0x0008C7FC
		private static void smethod_34(Class58 class58_1, int int_6)
		{
			if (class58_1.autoSettings_0.SkillPlayList.Count > 0 && class58_1.class120_0.list_4[class58_1.class120_0.list_3[int_6]].int_6 == 1)
			{
				for (int i = class58_1.autoSettings_0.SkillPlayList.Count - 1; i >= 0; i--)
				{
					bool flag = false;
					if (class58_1.autoSettings_0.SkillPlayList[i].class124_0.string_0 == class58_1.class120_0.list_4[class58_1.class120_0.list_3[int_6]].string_0)
					{
						flag = true;
					}
					if (!flag && class58_1.class114_0.Menpai == Class57.Menpais.QUYCOC && Class83.smethod_37(class58_1.autoSettings_0.SkillPlayList[i].class124_0.string_0) == class58_1.class120_0.list_4[class58_1.class120_0.list_3[int_6]].string_0)
					{
						flag = true;
					}
					if (flag)
					{
						try
						{
							class58_1.autoSettings_0.SkillPlayList[i].class124_0.string_1 = class58_1.class120_0.list_4[class58_1.class120_0.list_3[int_6]].string_1;
						}
						catch (Exception)
						{
						}
						break;
					}
				}
			}
			if (class58_1.autoSettings_0.SkillPKList.Count > 0 && class58_1.class120_0.list_4[class58_1.class120_0.list_3[int_6]].int_6 == 1)
			{
				for (int j = class58_1.autoSettings_0.SkillPKList.Count - 1; j >= 0; j--)
				{
					bool flag2 = false;
					if (class58_1.autoSettings_0.SkillPKList[j].class124_0.string_0 == class58_1.class120_0.list_4[class58_1.class120_0.list_3[int_6]].string_0)
					{
						flag2 = true;
					}
					if (!flag2 && class58_1.class114_0.Menpai == Class57.Menpais.QUYCOC && Class83.smethod_37(class58_1.autoSettings_0.SkillPKList[j].class124_0.string_0) == class58_1.class120_0.list_4[class58_1.class120_0.list_3[int_6]].string_0)
					{
						flag2 = true;
					}
					if (flag2)
					{
						try
						{
							class58_1.autoSettings_0.SkillPKList[j].class124_0.string_1 = class58_1.class120_0.list_4[class58_1.class120_0.list_3[int_6]].string_1;
						}
						catch (Exception)
						{
						}
						break;
					}
				}
			}
			if (class58_1.autoSettings_0.SkillBuffList.Count > 0 && class58_1.class120_0.list_4[class58_1.class120_0.list_3[int_6]].int_7 == 1)
			{
				for (int k = class58_1.autoSettings_0.SkillBuffList.Count - 1; k >= 0; k--)
				{
					bool flag3 = false;
					if (class58_1.autoSettings_0.SkillBuffList[k].class124_0.string_0 == class58_1.class120_0.list_4[class58_1.class120_0.list_3[int_6]].string_0)
					{
						flag3 = true;
					}
					if (!flag3 && class58_1.class114_0.Menpai == Class57.Menpais.QUYCOC && Class83.smethod_37(class58_1.autoSettings_0.SkillBuffList[k].class124_0.string_0) == class58_1.class120_0.list_4[class58_1.class120_0.list_3[int_6]].string_0)
					{
						flag3 = true;
					}
					if (flag3)
					{
						try
						{
							class58_1.autoSettings_0.SkillBuffList[k].class124_0.string_1 = class58_1.class120_0.list_4[class58_1.class120_0.list_3[int_6]].string_1;
						}
						catch (Exception)
						{
						}
						break;
					}
				}
			}
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0008EA54 File Offset: 0x0008CC54
		internal static void smethod_35(Class58 class58_1, ref int int_6, int int_7)
		{
			int num = 0;
			class58_1.class59_0.byte_0[0] = 0;
			class58_1.class59_0.byte_0[1] = 0;
			class58_1.class59_0.byte_0[2] = 0;
			class58_1.class59_0.byte_0[3] = 0;
			Class159.ReadProcessMemory((int)class58_1.class59_0.intptr_3, (IntPtr)int_7, class58_1.class59_0.byte_0, 4U, ref num);
			int_6 = ((int)class58_1.class59_0.byte_0[0] | (int)class58_1.class59_0.byte_0[1] << 8 | (int)class58_1.class59_0.byte_0[2] << 16 | (int)class58_1.class59_0.byte_0[3] << 24);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0008EB08 File Offset: 0x0008CD08
		internal static void smethod_36(Class58 class58_1, byte[] byte_0, ref int int_6, int int_7)
		{
			int num = 0;
			byte_0[0] = 0;
			byte_0[1] = 0;
			byte_0[2] = 0;
			byte_0[3] = 0;
			Class159.ReadProcessMemory((int)class58_1.class59_0.intptr_3, (IntPtr)int_7, byte_0, 4U, ref num);
			int_6 = ((int)byte_0[0] | (int)byte_0[1] << 8 | (int)byte_0[2] << 16 | (int)byte_0[3] << 24);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0008EB60 File Offset: 0x0008CD60
		internal static void smethod_37(Class58 class58_1, ref uint uint_1, int int_6)
		{
			int num = 0;
			class58_1.class59_0.byte_0[0] = 0;
			class58_1.class59_0.byte_0[1] = 0;
			class58_1.class59_0.byte_0[2] = 0;
			class58_1.class59_0.byte_0[3] = 0;
			Class159.ReadProcessMemory((int)class58_1.class59_0.intptr_3, (IntPtr)int_6, class58_1.class59_0.byte_0, 4U, ref num);
			uint_1 = BitConverter.ToUInt32(class58_1.class59_0.byte_0, 0);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0008EBE4 File Offset: 0x0008CDE4
		internal static void smethod_38(Class58 class58_1, ref int int_6, int int_7)
		{
			int num = 0;
			class58_1.class59_0.byte_0[0] = 0;
			class58_1.class59_0.byte_0[1] = 0;
			Class159.ReadProcessMemory((int)class58_1.class59_0.intptr_3, (IntPtr)int_7, class58_1.class59_0.byte_0, 2U, ref num);
			int_6 = (int)BitConverter.ToInt16(class58_1.class59_0.byte_0, 0);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0008EC4C File Offset: 0x0008CE4C
		internal static void smethod_39(Class58 class58_1, ref string string_2, int int_6)
		{
			int num = 0;
			Class101.smethod_32(class58_1);
			Class159.ReadProcessMemory((int)class58_1.class59_0.intptr_3, (IntPtr)int_6, class58_1.class59_0.byte_0, 30U, ref num);
			bool flag = false;
			int num2 = 0;
			while (!flag)
			{
				if (class58_1.class59_0.byte_0[num2] == 0 || num2 >= 29)
				{
					flag = true;
				}
				num2++;
			}
			string @string = Encoding.UTF7.GetString(class58_1.class59_0.byte_0, 0, num2 - 1);
			if (class58_1.class59_0.int_2 != 7 && class58_1.class59_0.int_2 != 8 && class58_1.class59_0.int_2 != 5)
			{
				if (class58_1.class59_0.int_2 != 6)
				{
					string_2 = Class83.smethod_142(class58_1.class59_0.byte_0, 0, num2 - 1);
					return;
				}
			}
			@string = Encoding.GetEncoding("gb2312").GetString(class58_1.class59_0.byte_0, 0, num2 - 1);
			string_2 = @string;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x0008ED3C File Offset: 0x0008CF3C
		internal static void smethod_40(Class58 class58_1, byte[] byte_0, ref string string_2, int int_6)
		{
			int num = 0;
			Class101.smethod_31(byte_0);
			Class159.ReadProcessMemory((int)class58_1.class59_0.intptr_3, (IntPtr)int_6, byte_0, 30U, ref num);
			bool flag = false;
			int num2 = 0;
			while (!flag)
			{
				if (byte_0[num2] == 0 || num2 >= 29)
				{
					flag = true;
				}
				num2++;
			}
			string @string = Encoding.UTF7.GetString(byte_0, 0, num2 - 1);
			if (class58_1.class59_0.int_2 != 7 && class58_1.class59_0.int_2 != 8 && class58_1.class59_0.int_2 != 5)
			{
				if (class58_1.class59_0.int_2 != 6)
				{
					string_2 = Class83.smethod_142(byte_0, 0, num2 - 1);
					return;
				}
			}
			@string = Encoding.GetEncoding("gb2312").GetString(byte_0, 0, num2 - 1);
			string_2 = @string;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0008EDFC File Offset: 0x0008CFFC
		internal static void smethod_41(Class58 class58_1, ref int int_6, int int_7)
		{
			int num = 0;
			class58_1.class59_0.byte_0[0] = 0;
			Class159.ReadProcessMemory((int)class58_1.class59_0.intptr_3, (IntPtr)int_7, class58_1.class59_0.byte_0, 1U, ref num);
			int_6 = (int)class58_1.class59_0.byte_0[0];
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0008EE54 File Offset: 0x0008D054
		internal static void smethod_42(Class58 class58_1, ref float float_0, int int_6)
		{
			int num = 0;
			class58_1.class59_0.byte_0[0] = 0;
			class58_1.class59_0.byte_0[1] = 0;
			class58_1.class59_0.byte_0[2] = 0;
			class58_1.class59_0.byte_0[3] = 0;
			Class159.ReadProcessMemory((int)class58_1.class59_0.intptr_3, (IntPtr)int_6, class58_1.class59_0.byte_0, 4U, ref num);
			float_0 = BitConverter.ToSingle(class58_1.class59_0.byte_0, 0);
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x000049BC File Offset: 0x00002BBC
		internal static void smethod_43(Class58 class58_1, Class158 class158_0)
		{
			Class101.smethod_46(class58_1);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x0008EED8 File Offset: 0x0008D0D8
		internal static void smethod_44(Class58 class58_1, Class158 class158_0)
		{
			if (class58_1.class114_0 != null)
			{
				if (class158_0.int_1 != -1)
				{
					class58_1.class114_0.int_65 = class158_0.int_1;
				}
				if (class158_0.int_2 != -1)
				{
					class58_1.class114_0.int_75 = class158_0.int_2;
				}
				if (class158_0.int_3 != -1)
				{
					class58_1.class114_0.int_79 = class158_0.int_3;
				}
				if (class158_0.int_4 != -1)
				{
					class58_1.class114_0.int_58 = class158_0.int_4;
				}
			}
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x000049C4 File Offset: 0x00002BC4
		internal static void smethod_45(Class58 class58_1)
		{
			if (class58_1.class114_0 != null)
			{
				class58_1.class114_0.string_1 = "";
				class58_1.class114_0.bool_82 = false;
			}
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0008EF58 File Offset: 0x0008D158
		internal static void smethod_46(Class58 class58_1)
		{
			if (class58_1.class114_0 != null)
			{
				class58_1.class114_0.int_79 = -1;
				class58_1.class114_0.int_65 = 0;
				class58_1.class114_0.int_75 = 0;
				class58_1.class114_0.int_58 = 0;
				class58_1.class114_0.int_69 = -1;
				class58_1.class114_0.string_1 = "";
			}
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0008EFBC File Offset: 0x0008D1BC
		internal static void smethod_47(Class58 class58_1, Class158 class158_0)
		{
			if (class58_1.class126_0 != null)
			{
				class58_1.class126_0.int_4 = 0;
				class58_1.class126_0.int_6 = 0;
				class58_1.class126_0.int_9 = 0;
				class58_1.class126_0.string_0 = "";
				class58_1.class126_0.int_8 = 0;
			}
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x000049EA File Offset: 0x00002BEA
		internal static void smethod_48(Class58 class58_1, Class158 class158_0)
		{
			if (class58_1.class126_0 != null)
			{
				class58_1.class126_0.int_11 = 0;
				class58_1.class126_0.long_0 = 0L;
				class58_1.class126_0.string_1 = "";
			}
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0008F014 File Offset: 0x0008D214
		internal static void smethod_49(Class58 class58_1, bool bool_8)
		{
			if (class58_1.class118_0 != null)
			{
				class58_1.class118_0.list_1.Clear();
				Class101.smethod_30(class58_1);
			}
			if (bool_8 && class58_1.class108_0 != null)
			{
				class58_1.class108_0.int_3 = 0;
				class58_1.class108_0.float_0 = 0f;
				class58_1.class108_0.float_1 = 0f;
				class58_1.class108_0.long_0 = 0L;
				class58_1.class108_0.list_4.Clear();
			}
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00004A1D File Offset: 0x00002C1D
		internal static void smethod_50(Class58 class58_1, Class158 class158_0)
		{
			if (class58_1.class114_0 != null)
			{
				class58_1.class114_0.byte_0 = 0;
			}
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0008F094 File Offset: 0x0008D294
		internal static void smethod_51(Class58 class58_1, int int_6)
		{
			if (class58_1.class108_0 != null && class58_1.class108_0.list_4.Count > 0)
			{
				if (int_6 == class58_1.class108_0.int_3)
				{
					class58_1.class108_0.int_3 = 0;
					class58_1.class108_0.float_0 = 0f;
					class58_1.class108_0.float_1 = 0f;
				}
				for (int i = class58_1.class108_0.list_4.Count - 1; i >= 0; i--)
				{
					if (class58_1.class108_0.list_4[i].int_1 == int_6)
					{
						class58_1.class108_0.list_4.RemoveAt(i);
						return;
					}
				}
			}
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0008F148 File Offset: 0x0008D348
		internal static void smethod_52(Class58 class58_1, Class158 class158_0)
		{
			if (class58_1.class108_0 != null)
			{
				bool flag = false;
				if (class58_1.class108_0.list_4.Count > 0)
				{
					for (int i = class58_1.class108_0.list_4.Count - 1; i >= 0; i--)
					{
						Class109 @class = class58_1.class108_0.list_4[i];
						if (class58_1.method_232() - @class.long_0 >= 59000L && @class.int_2 == 5000)
						{
							Class101.smethod_24(class58_1, i);
						}
						else if (@class.int_1 == class158_0.int_1)
						{
							if (class158_0.int_2 != -1 && (class158_0.int_4 == -1 || class158_0.int_4 == 153))
							{
								@class.int_2 = 5000;
							}
							else
							{
								@class.int_2 = class158_0.int_4;
							}
							if (@class.float_0 == class158_0.float_0 && @class.float_1 == class158_0.float_1)
							{
								flag = true;
								break;
							}
							if (!Class101.smethod_53(class58_1, @class))
							{
								@class.long_0 = class58_1.method_232();
							}
							@class.float_0 = class158_0.float_0;
							@class.float_1 = class158_0.float_1;
							@class.int_3 = class158_0.int_2;
							@class.int_4 = class158_0.int_3;
							flag = false;
							break;
						}
						else
						{
							flag = false;
						}
					}
				}
				if (!flag)
				{
					Class109 class2 = new Class109();
					class2.int_1 = class158_0.int_1;
					class2.float_0 = class158_0.float_0;
					class2.float_1 = class158_0.float_1;
					class2.int_3 = class158_0.int_2;
					class2.int_4 = class158_0.int_3;
					if (class158_0.int_2 != -1 && (class158_0.int_4 == -1 || class158_0.int_4 == 153))
					{
						class2.int_2 = 5000;
					}
					else
					{
						class2.int_2 = class158_0.int_4;
					}
					if (!Class101.smethod_53(class58_1, class2))
					{
						class2.long_0 = class58_1.method_232();
					}
					class58_1.class108_0.list_4.Add(class2);
					if (class58_1.class114_0.bool_163 && class2.int_2 == 809 && class58_1.class114_0.ActionStatus != 8)
					{
						double num = Class83.smethod_116((double)class58_1.class114_0.float_0, (double)class58_1.class114_0.float_5, (double)class2.float_0, (double)class2.float_1);
						int num2 = 5;
						if (class58_1.autoSettings_0.cboxNhatTuyetDungIm)
						{
							num2 = 3;
						}
						if (num <= (double)num2)
						{
							class58_1.method_143(class2.int_1);
						}
					}
				}
			}
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0008F3A8 File Offset: 0x0008D5A8
		private static bool smethod_53(Class58 class58_1, Class109 class109_0)
		{
			bool result = false;
			if (class58_1.class108_0.list_1.Count > 0)
			{
				for (int i = class58_1.class108_0.list_1.Count - 1; i >= 0; i--)
				{
					if (class58_1.class108_0.list_1[i].int_1 == class109_0.int_1 && class58_1.class108_0.list_1[i].float_0 == class109_0.float_0 && class58_1.class108_0.list_1[i].float_1 == class109_0.float_1)
					{
						class109_0.long_0 = class58_1.class108_0.list_1[i].long_0;
						result = true;
						break;
					}
					if (class58_1.class108_0.list_1[i].int_1 == class109_0.int_1 && (class58_1.class108_0.list_1[i].float_0 != class109_0.float_0 || class58_1.class108_0.list_1[i].float_1 != class109_0.float_1))
					{
						class58_1.class108_0.list_1.RemoveAt(i);
					}
				}
			}
			return result;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0008F4D8 File Offset: 0x0008D6D8
		internal static void smethod_54(Class58 class58_1, Class158 class158_0)
		{
			if (class58_1.class118_0 != null && class58_1.class114_0 != null)
			{
				class58_1.class114_0.long_16 = class58_1.method_232();
				class58_1.class118_0.int_4 = class158_0.int_1;
				class58_1.class118_0.float_0 = class158_0.float_0 * 100f;
				int num = class158_0.int_2;
				if (class58_1.class118_0.list_1.Count > 0 && class58_1.class118_0.int_2 != class58_1.class114_0.int_9)
				{
					int i = class58_1.class118_0.list_1.Count - 1;
					while (i >= 0)
					{
						Class119 @class = class58_1.class118_0.list_1[i];
						if (@class.int_0 == class58_1.class118_0.int_2 && class58_1.class118_0.int_2 != -1)
						{
							class58_1.class118_0.long_0 = class58_1.method_232();
							@class.int_6 = class158_0.int_5;
							@class.int_7 = class158_0.int_6;
							@class.int_8 = class158_0.int_7;
							@class.int_5 = (int)((byte)class158_0.int_4);
							@class.float_5 = (float)class158_0.int_3;
							if (num == -1)
							{
								@class.byte_6 = 0;
								return;
							}
							if (class58_1.class114_0 == null || class58_1.class126_0 == null)
							{
								break;
							}
							if (class58_1.class114_0.int_11 == num)
							{
								@class.byte_6 = 1;
								return;
							}
							bool flag = false;
							if (class58_1.class126_0.list_0.Count > 0)
							{
								for (int j = 0; j < class58_1.class126_0.list_0.Count; j++)
								{
									if (class58_1.class126_0.list_0[j].int_0 == num)
									{
										flag = true;
										@class.byte_6 = 1;
										break;
									}
								}
							}
							if (!flag)
							{
								@class.byte_6 = byte.MaxValue;
								return;
							}
							break;
						}
						else
						{
							i--;
						}
					}
				}
			}
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0008F6B8 File Offset: 0x0008D8B8
		internal static void smethod_55(Class58 class58_1, Class158 class158_0)
		{
			if (class58_1.class118_0 != null)
			{
				class58_1.class118_0.int_5 = class58_1.class118_0.int_2;
				class58_1.class118_0.int_2 = class158_0.int_1;
				class58_1.class118_0.int_3 = class158_0.int_1;
				class58_1.class118_0.long_0 = class58_1.method_232();
				if (class58_1.class118_0.int_2 == -1)
				{
					class58_1.class118_0.float_0 = 0f;
					class58_1.class118_0.int_4 = 0;
				}
			}
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00004A33 File Offset: 0x00002C33
		internal static void smethod_56(Class58 class58_1, Class158 class158_0)
		{
			if (class58_1.class114_0 != null)
			{
				class58_1.class114_0.int_118 = class158_0.int_1;
			}
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0008F740 File Offset: 0x0008D940
		internal static void smethod_57(Class58 class58_1, Class158 class158_0)
		{
			if (class58_1.class92_0 != null)
			{
				if (class158_0.int_6 < 100 || class158_0.int_1 <= 0)
				{
					return;
				}
				bool flag = false;
				float num = (float)class158_0.int_4;
				float num2 = 0f;
				Class101.smethod_42(class58_1, ref num2, class158_0.int_4);
				num = num2 * 100f;
				if (class58_1.class92_0.list_0.Count > 0)
				{
					for (int i = class58_1.class92_0.list_0.Count - 1; i >= 0; i--)
					{
						if (class58_1.class92_0.list_0[i].int_2 > 0 && class58_1.class92_0.list_0[i].int_2 == class158_0.int_6)
						{
							if (num >= 0f)
							{
								class58_1.class92_0.list_0[i].float_2 = class158_0.float_0;
								class58_1.class92_0.list_0[i].float_3 = class158_0.float_1;
								class58_1.class92_0.list_0[i].int_4 = class58_1.class114_0.MapID;
								class58_1.class92_0.list_0[i].long_0 = class58_1.method_232();
								class58_1.class92_0.list_0[i].float_0 = num;
								class58_1.class92_0.list_0[i].int_5 = class158_0.int_2;
								class58_1.class92_0.list_0[i].int_0 = class158_0.int_1;
							}
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					if (class158_0.byte_0 == 0)
					{
						return;
					}
					string a = "";
					int num3 = class158_0.int_8;
					if (class58_1.class59_0.int_2 == 3 || class58_1.class59_0.int_2 == 4)
					{
						num3 -= 4;
					}
					int num4 = 0;
					Class101.smethod_35(class58_1, ref num4, num3 + 20);
					if (num4 == 31)
					{
						Class101.smethod_35(class58_1, ref num3, num3);
					}
					Class101.smethod_39(class58_1, ref a, num3);
					if (a == "")
					{
						return;
					}
					Class93 @class = new Class93();
					@class.int_2 = class158_0.int_6;
					if (@class.int_2 > 100)
					{
						@class.int_3 = class158_0.int_9;
						@class.int_0 = class158_0.int_1;
						@class.float_2 = class158_0.float_0;
						@class.float_3 = class158_0.float_1;
						@class.int_4 = class58_1.class114_0.MapID;
						@class.long_0 = class58_1.method_232();
						@class.float_0 = num;
						@class.int_1 = class158_0.int_3;
						@class.int_5 = class158_0.int_2;
						@class.int_7 = (int)class158_0.byte_0;
						@class.string_0 = a;
						class58_1.class92_0.list_0.Add(@class);
						flag = true;
					}
				}
				if (flag)
				{
					if (class158_0.int_1 == class58_1.class118_0.int_2)
					{
						class58_1.class118_0.long_0 = class58_1.method_232();
					}
					if (class58_1.class126_0 != null && 0 < class58_1.class126_0.int_1 && class58_1.class126_0.int_1 < 6)
					{
						int j = 0;
						while (j <= class58_1.class126_0.int_1)
						{
							Class127 class2 = class58_1.class126_0.list_0[j];
							if (class2.int_0 == class158_0.int_6)
							{
								class2.float_0 = class158_0.float_0;
								class2.float_1 = class158_0.float_1;
								if (class2.int_5 > 0)
								{
									class2.int_4 = (int)((double)num / 100.0 * (double)class2.int_5);
									break;
								}
								break;
							}
							else
							{
								j++;
							}
						}
					}
					if (class58_1.class75_0.long_55 > Class101.smethod_61() && class58_1.class91_0 != null && class58_1.class59_0.int_2 != 3 && class58_1.class59_0.int_2 != 4)
					{
						for (int k = 0; k < 30; k++)
						{
							Class127 class3 = class58_1.class91_0.list_0[k];
							if (class3.int_0 == class158_0.int_6)
							{
								class3.float_0 = class158_0.float_0;
								class3.float_1 = class158_0.float_1;
								if (class3.int_5 > 0)
								{
									class3.int_4 = (int)((double)num / 100.0 * (double)class3.int_5);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0008FBA4 File Offset: 0x0008DDA4
		internal static void smethod_58(Class58 class58_1, Class158 class158_0)
		{
			if (class58_1.class118_0 != null)
			{
				bool flag = false;
				float num = class158_0.float_2 * 100f;
				int num2 = class158_0.int_3;
				if (class58_1.class118_0.list_1.Count > 0)
				{
					for (int i = class58_1.class118_0.list_1.Count - 1; i >= 0; i--)
					{
						if (class58_1.class118_0.list_1[i].int_0 != -1 && class58_1.class118_0.list_1[i].int_0 == class158_0.int_7)
						{
							if (num > 0f)
							{
								class58_1.class118_0.list_1[i].float_0 = class158_0.float_0;
								class58_1.class118_0.list_1[i].float_1 = class158_0.float_1;
								class58_1.class118_0.list_1[i].float_4 = num;
								class58_1.class118_0.list_1[i].long_1 = class58_1.method_232();
							}
							else if (num <= 0f)
							{
								Class101.smethod_59(class58_1, i);
							}
							flag = true;
							break;
						}
					}
				}
				if (!flag && num > 0f)
				{
					if (class158_0.byte_0 <= 0)
					{
						return;
					}
					string text = "";
					int num3 = class158_0.int_8;
					int num4 = 0;
					Class101.smethod_35(class58_1, ref num4, num3 + 20);
					if (num4 == 31)
					{
						Class101.smethod_35(class58_1, ref num3, num3);
					}
					Class101.smethod_39(class58_1, ref text, num3);
					string text2 = "";
					num3 = class158_0.int_10;
					num4 = 0;
					Class101.smethod_35(class58_1, ref num4, num3 + 20);
					if (num4 == 31)
					{
						Class101.smethod_35(class58_1, ref num3, num3);
					}
					Class101.smethod_39(class58_1, ref text2, num3);
					if (text2.Contains("#"))
					{
						text2 = text2.Split(new char[]
						{
							'#'
						})[0];
					}
					Class119 @class = new Class119();
					@class.int_0 = class158_0.int_7;
					@class.float_0 = class158_0.float_0;
					@class.float_1 = class158_0.float_1;
					@class.int_9 = class58_1.class114_0.MapID;
					@class.long_1 = class58_1.method_232();
					@class.int_1 = num2;
					@class.int_5 = (int)class158_0.byte_0;
					@class.byte_8 = 1;
					@class.byte_0 = (byte)class158_0.int_5;
					@class.int_14 = class158_0.int_6;
					@class.string_0 = text;
					@class.string_1 = text2;
					@class.float_4 = num;
					class58_1.class118_0.list_1.Add(@class);
				}
				if (num > 0f && class158_0.int_7 == class58_1.class118_0.int_2)
				{
					class58_1.class118_0.long_0 = class58_1.method_232();
				}
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x0008FE60 File Offset: 0x0008E060
		internal static void smethod_59(Class58 class58_1, int int_6)
		{
			if (class58_1.class118_0 != null && class58_1.class118_0.list_1.Count > 0 && int_6 < class58_1.class118_0.list_1.Count)
			{
				if (class58_1.class118_0.list_1[int_6].int_0 == class58_1.class118_0.int_2 && class58_1.class118_0.int_2 != -1)
				{
					class58_1.class118_0.int_2 = -1;
					class58_1.class118_0.float_0 = 0f;
					class58_1.class118_0.int_5 = -1;
				}
				if (class58_1.class114_0.int_14 == class58_1.class118_0.list_1[int_6].int_0)
				{
					class58_1.class114_0.int_14 = -1;
				}
				class58_1.class118_0.list_1.RemoveAt(int_6);
			}
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0008FF40 File Offset: 0x0008E140
		private static void smethod_60(Class58 class58_1)
		{
			class58_1.class59_0.bool_6 = false;
			if (class58_1.class114_0.long_63 >= class58_1.class114_0.PacketWriteIndex && class58_1.class114_0.long_63 == 0L)
			{
				class58_1.class59_0.bool_6 = true;
				return;
			}
			class58_1.class59_0.bool_6 = false;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00003C2E File Offset: 0x00001E2E
		internal static long smethod_61()
		{
			return frmLogin.stopwatch_0.ElapsedMilliseconds;
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0008FF98 File Offset: 0x0008E198
		internal static void smethod_62(Class58 class58_1, int int_6, int int_7)
		{
			if (int_6 < class58_1.class116_0.list_0.Count)
			{
				int num = int_6 * 255 + 9;
				num = int_7 + (num * 2 + num) * 4;
				int num2 = 9999;
				Class101.smethod_35(class58_1, ref num2, num);
				class58_1.class116_0.list_0[int_6].int_7 = num2;
				num = int_6 * 255 + 1;
				num = int_7 + (num * 2 + num) * 4;
				num2 = 9999;
				Class101.smethod_35(class58_1, ref num2, num);
				class58_1.class116_0.list_0[int_6].int_12 = num2;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x00004A4E File Offset: 0x00002C4E
		// (set) Token: 0x060004BF RID: 1215 RVA: 0x00004A56 File Offset: 0x00002C56
		internal Class58 CurrentAuto { get; set; }

		// Token: 0x060004C0 RID: 1216 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_0(object sender, EventArgs e)
		{
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00090030 File Offset: 0x0008E230
		private void method_1(object sender, EventArgs e)
		{
			if (frmGLogin.frmGLogin_0 != null)
			{
				try
				{
					frmGLogin.frmGLogin_0.long_7 = frmLogin.stopwatch_0.ElapsedMilliseconds + 5000L;
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00090074 File Offset: 0x0008E274
		internal void method_2()
		{
			for (;;)
			{
				if (!this.bool_3)
				{
					Thread.Sleep(300);
				}
				else
				{
					try
					{
						if (frmLogin.stopwatch_0.ElapsedMilliseconds - frmLogin.long_4 >= 600000L)
						{
							frmLogin.long_4 = frmLogin.stopwatch_0.ElapsedMilliseconds;
							GC.Collect();
						}
						if (frmLogin.stopwatch_0.ElapsedMilliseconds - frmLogin.long_12 >= 5000L)
						{
							frmLogin.long_12 = frmLogin.stopwatch_0.ElapsedMilliseconds;
							if (frmLogin.class130_0.Boolean_0 && !frmLogin.bool_36 && frmLogin.class101_0.class210_0.Count > 0)
							{
								frmLogin.bool_36 = true;
								new Thread(new ThreadStart(Class101.<>c.<>c_0.method_0)).Start();
							}
							if (frmLogin.class101_0.globalSettings_0.TipHuongDan && (frmLogin.long_26 == 0L || (frmLogin.long_26 > 0L && frmLogin.stopwatch_0.ElapsedMilliseconds - frmLogin.long_26 >= frmLogin.long_27)) && frmLogin.list_26.Count > 0 && frmLogin.long_27 > 0L && frmLogin.class101_0.class210_0.Count > 0)
							{
								frmLogin.long_26 = frmLogin.stopwatch_0.ElapsedMilliseconds;
								try
								{
									if (frmLogin.class101_0.class210_0[0].class59_0.int_2 == 3 && frmLogin.class101_0.class210_0[0].class59_0.int_11 != 6 && frmLogin.list_28.Count > 0)
									{
										int index = Class83.random_0.Next(0, frmLogin.list_28.Count);
										Class83.smethod_66(frmLogin.list_28[index], null, new object[0]);
									}
									else if (frmLogin.class101_0.class210_0[0].class59_0.int_2 < 3 && frmLogin.list_27.Count > 0)
									{
										int index2 = Class83.random_0.Next(0, frmLogin.list_27.Count);
										Class83.smethod_66(frmLogin.list_27[index2], null, new object[0]);
									}
									else if (frmLogin.class101_0.class210_0[0].class59_0.int_2 == 3 && frmLogin.class101_0.class210_0[0].class59_0.int_11 == 6 && frmLogin.list_30.Count > 0)
									{
										int index3 = Class83.random_0.Next(0, frmLogin.list_30.Count);
										Class83.smethod_66(frmLogin.list_30[index3], null, new object[0]);
									}
									else if (frmLogin.class101_0.class210_0[0].class59_0.int_2 == 4 && frmLogin.list_29.Count > 0)
									{
										int index4 = Class83.random_0.Next(0, frmLogin.list_29.Count);
										Class83.smethod_66(frmLogin.list_29[index4], null, new object[0]);
									}
								}
								catch (Exception)
								{
									Class83.smethod_66("Please notify GAuto. Error code 12587", null, new object[0]);
								}
							}
							long num = frmLogin.stopwatch_0.ElapsedMilliseconds - frmLogin.class101_0.globalSettings_0.Account.long_2;
							int num2 = (frmLogin.class101_0.globalSettings_0.Q12TCDuration ^ 1786) / 849;
							if ((long)(num2 * 1000) > num)
							{
								num2 = (num2 * 1000 - (int)num) / 1000;
								try
								{
									frmLogin.class101_0.globalSettings_0.Q12TCDuration = (num2 * 849 ^ 1786);
									goto IL_46D;
								}
								catch (Exception)
								{
									goto IL_46D;
								}
							}
							try
							{
								int num3 = 0;
								try
								{
									for (int i = frmLogin.class101_0.class210_0.Count - 1; i >= 0; i--)
									{
										if (frmLogin.class101_0.class210_0[i].class114_0.bool_155 || frmLogin.class101_0.class210_0[i].class114_0.bool_156)
										{
											num3++;
											break;
										}
									}
								}
								catch (Exception)
								{
								}
								if (frmLogin.class101_0.globalSettings_0.Account.int_2 == 0 && frmLogin.class101_0.globalSettings_0.HadQ123Pro && num3 > 0 && frmLogin.class101_0.globalSettings_0.cboxQ12AutoExtend)
								{
									frmLogin.class101_0.globalSettings_0.Q12TCDuration = 1019210;
								}
								else
								{
									frmLogin.class101_0.globalSettings_0.Q12TCDuration = 1786;
								}
								frmLogin.class101_0.globalSettings_0.Account.int_2++;
							}
							catch (Exception)
							{
							}
							IL_46D:
							frmLogin.class101_0.globalSettings_0.Account.long_2 = frmLogin.stopwatch_0.ElapsedMilliseconds;
							num = frmLogin.stopwatch_0.ElapsedMilliseconds - frmLogin.class101_0.globalSettings_0.Account.long_3;
							num2 = (frmLogin.class101_0.globalSettings_0.YTODuration ^ 2716) / 147;
							if ((long)(num2 * 1000) > num)
							{
								num2 = (num2 * 1000 - (int)num) / 1000;
								try
								{
									frmLogin.class101_0.globalSettings_0.YTODuration = (num2 * 147 ^ 2716);
									goto IL_5E0;
								}
								catch (Exception)
								{
									goto IL_5E0;
								}
							}
							try
							{
								int num4 = 0;
								try
								{
									for (int j = frmLogin.class101_0.class210_0.Count - 1; j >= 0; j--)
									{
										if (frmLogin.class101_0.class210_0[j].class114_0.bool_160)
										{
											num4++;
											break;
										}
									}
								}
								catch (Exception)
								{
								}
								if (frmLogin.class101_0.globalSettings_0.Account.int_3 == 0 && frmLogin.class101_0.globalSettings_0.HadYTOPro && num4 > 0 && frmLogin.class101_0.globalSettings_0.cboxYTOGiaHan)
								{
									frmLogin.class101_0.globalSettings_0.YTODuration = 179084;
								}
								else
								{
									frmLogin.class101_0.globalSettings_0.YTODuration = 2716;
								}
								frmLogin.class101_0.globalSettings_0.Account.int_3++;
							}
							catch (Exception)
							{
							}
							IL_5E0:
							frmLogin.class101_0.globalSettings_0.Account.long_3 = frmLogin.stopwatch_0.ElapsedMilliseconds;
							frmLogin.class101_0.globalSettings_0.Account.class70_0.method_5();
							if (!frmLogin.bool_32)
							{
								bool flag = false;
								bool flag2 = false;
								if (frmLogin.int_2 != 0)
								{
									string s = Class83.smethod_22().Replace(".", "");
									int num5 = 0;
									int.TryParse(s, out num5);
									if (frmLogin.int_2 >= num5)
									{
										flag = true;
									}
								}
								if (frmLogin.list_32.Count > 0 && frmLogin.list_32.Contains(Class83.smethod_22().Replace(".", "")))
								{
									flag2 = true;
								}
								if ((flag || flag2) && frmLogin.long_32 == 0L)
								{
									frmLogin.long_32 = frmLogin.stopwatch_0.ElapsedMilliseconds + 120000L;
									Class83.smethod_66("Bạn đang xài phiên bản (" + Class83.smethod_22() + ") cũ không phù hợp. Auto sẽ tự thoát sau 2 phút nữa", null, new object[0]);
									Class83.smethod_46("Bạn đang xài phiên bản (" + Class83.smethod_22() + ") cũ không phù hợp. Auto sẽ tự thoát sau 2 phút nữa. Vui lòng chạy file update.exe để cập nhật phiên bản mới nhất", "Phiên bản cũ", 120000, new object[0]);
								}
								frmLogin.bool_32 = true;
							}
							if (frmLogin.long_32 != 0L && frmLogin.stopwatch_0.ElapsedMilliseconds >= frmLogin.long_32)
							{
								string string_ = "Auto tự thoát. Bạn cần cập nhật phiên bản mới hơn";
								frmThongBao_FW.int_0 = 1;
								Class83.smethod_46(string_, "Phiên bản quá cũ", 60000, new object[0]);
								frmLogin.long_32 = 0L;
							}
							if (frmLogin.string_0 == "VN")
							{
								num = frmLogin.stopwatch_0.ElapsedMilliseconds - frmLogin.class101_0.globalSettings_0.Account.long_4;
								num2 = (frmLogin.class101_0.globalSettings_0.CheDoDuration ^ 2013) / 152;
								if ((long)(num2 * 1000) > num)
								{
									num2 = (num2 * 1000 - (int)num) / 1000;
									try
									{
										frmLogin.class101_0.globalSettings_0.CheDoDuration = (num2 * 152 ^ 2013);
										goto IL_8A6;
									}
									catch (Exception)
									{
										goto IL_8A6;
									}
								}
								try
								{
									int num6 = 0;
									try
									{
										for (int k = frmLogin.class101_0.class210_0.Count - 1; k >= 0; k--)
										{
											if (frmLogin.class101_0.class210_0[k].class114_0.bool_152)
											{
												num6++;
											}
										}
									}
									catch (Exception)
									{
									}
									if (frmLogin.class101_0.globalSettings_0.Account.int_14 == 0 && frmLogin.class101_0.globalSettings_0.HadCDPro && num6 > 0)
									{
										frmLogin.class101_0.globalSettings_0.CheDoDuration = 184157;
									}
									else
									{
										frmLogin.class101_0.globalSettings_0.CheDoDuration = 2013;
										frmLogin.class101_0.globalSettings_0.CheDoCounts = 2013;
									}
									frmLogin.class101_0.globalSettings_0.Account.int_14++;
								}
								catch (Exception)
								{
								}
								IL_8A6:
								frmLogin.class101_0.globalSettings_0.Account.long_4 = frmLogin.stopwatch_0.ElapsedMilliseconds;
							}
							try
							{
								if (frmLogin.class101_0.list_16.Count > 0)
								{
									for (int l = frmLogin.class101_0.list_16.Count - 1; l >= 0; l--)
									{
										if (frmLogin.class101_0.list_16[l].class59_0.int_13 < 10)
										{
											if (!frmLogin.class101_0.list_16[l].class59_0.bool_20)
											{
												Class159.PostMessage(frmLogin.class101_0.list_16[l].class59_0.intptr_10, frmLogin.class101_0.globalSettings_0.WM_PSEUDOCODE, (IntPtr)0, (IntPtr)0);
												frmLogin.class101_0.list_16[l].class59_0.bool_20 = true;
											}
											Class58.smethod_2(frmLogin.class101_0.list_16[l]);
										}
									}
								}
							}
							catch (Exception)
							{
							}
						}
						if (frmLogin.stopwatch_0.ElapsedMilliseconds - frmLogin.long_8 >= 5000L)
						{
							frmLogin.long_8 = frmLogin.stopwatch_0.ElapsedMilliseconds;
							long num7 = frmLogin.stopwatch_0.ElapsedMilliseconds - frmLogin.class101_0.globalSettings_0.Account.long_1;
							if (frmLogin.class101_0.globalSettings_0.Account.RemainMSeconds > (double)num7)
							{
								try
								{
									frmLogin.class101_0.globalSettings_0.Account.RemainMSeconds = frmLogin.class101_0.globalSettings_0.Account.RemainMSeconds - (double)num7;
									goto IL_AD2;
								}
								catch (Exception)
								{
									goto IL_AD2;
								}
							}
							try
							{
								if (frmLogin.class101_0.globalSettings_0.Account.int_1 == 0 && frmLogin.class101_0.globalSettings_0.WasPro)
								{
									frmLogin.class101_0.globalSettings_0.Account.RemainMSeconds = 600000.0;
								}
								else
								{
									frmLogin.class101_0.globalSettings_0.Account.RemainMSeconds = 0.0;
								}
							}
							catch (Exception)
							{
							}
							frmLogin.class101_0.globalSettings_0.Account.int_1++;
							IL_AD2:
							frmLogin.class101_0.globalSettings_0.Account.long_1 = frmLogin.stopwatch_0.ElapsedMilliseconds;
						}
						this.method_4();
						if (frmLogin.stopwatch_0.ElapsedMilliseconds - frmLogin.long_7 >= 60000L && frmLogin.long_7 != 0L)
						{
							frmLogin.long_7 = 0L;
							this.globalSettings_0.EnumProcessDelay = 3000;
						}
						if (frmLogin.stopwatch_0.ElapsedMilliseconds - this.globalSettings_0.EnumProcessTimeStamp >= (long)this.globalSettings_0.EnumProcessDelay || (frmLogin.long_25 > 0L && frmLogin.stopwatch_0.ElapsedMilliseconds - frmLogin.long_25 <= 120000L))
						{
							this.globalSettings_0.EnumProcessTimeStamp = frmLogin.stopwatch_0.ElapsedMilliseconds;
							if (this.class210_0.Count > 0)
							{
								for (int m = this.class210_0.Count - 1; m >= 0; m--)
								{
									if (this.class210_0[m] != null && !this.class210_0[m].IsLicensed)
									{
										this.class210_0[m].IsLicensed = true;
									}
								}
							}
							if (frmLogin.class101_0.globalSettings_0.SavedAIStatus.Count > 0)
							{
								for (int n = frmLogin.class101_0.globalSettings_0.SavedAIStatus.Count - 1; n >= 0; n--)
								{
									Class62 @class = frmLogin.class101_0.globalSettings_0.SavedAIStatus[n];
									try
									{
										for (int num8 = 0; num8 < frmLogin.class101_0.class210_0.Count; num8++)
										{
											Class58 class2 = frmLogin.class101_0.class210_0[num8];
											if (class2.class114_0 != null && @class.int_0 == class2.class114_0.int_11)
											{
												class2.IsAIEnabled = @class.bool_0;
												frmLogin.class101_0.globalSettings_0.SavedAIStatus.RemoveAt(n);
												break;
											}
										}
									}
									catch (Exception)
									{
									}
								}
							}
							if (!Class101.bool_4)
							{
								Process[] processesByName = Process.GetProcessesByName(this.string_0);
								bool flag3 = false;
								if (processesByName != null)
								{
									if (true)
									{
										Process[] array = processesByName;
										for (int num9 = 0; num9 < array.Length; num9++)
										{
											Class101.Class104 class3 = new Class101.Class104();
											class3.class101_0 = this;
											class3.process_0 = array[num9];
											if (class3.process_0.ProcessName.ToLower() == this.string_0)
											{
												bool flag4 = false;
												try
												{
													for (int num10 = frmLogin.class101_0.class210_0.Count - 1; num10 >= 0; num10--)
													{
														if (frmLogin.class101_0.class210_0[num10].class59_0.int_1 == class3.process_0.Id)
														{
															flag4 = true;
															IL_D8D:
															goto IL_1AD0;
														}
													}
													goto IL_D8D;
												}
												catch (Exception)
												{
													goto IL_1AD0;
												}
												goto IL_D98;
												IL_F1C:
												if (!flag4)
												{
													try
													{
														class3.class58_0 = new Class58();
														class3.int_1 = class3.process_0.Id;
														class3.class58_0.class59_0.int_4 = class3.process_0.MainModule.BaseAddress.ToInt32();
														uint num11 = 0U;
														string text = "";
														Class101.intptr_0 = IntPtr.Zero;
														class3.intptr_0 = IntPtr.Zero;
														class3.uint_0 = 0U;
														string text2 = "";
														class3.stringBuilder_0 = new StringBuilder(70);
														if (class3.process_0.MainWindowHandle != IntPtr.Zero)
														{
															class3.intptr_0 = class3.process_0.MainWindowHandle;
															text = class3.process_0.MainWindowTitle;
														}
														else
														{
															Class159.EnumWindows(new Class159.Delegate6(this.method_3), class3.process_0.Id);
															if (Class101.intptr_0 != IntPtr.Zero)
															{
																class3.intptr_0 = Class101.intptr_0;
																Class159.GetWindowText(class3.intptr_0, class3.stringBuilder_0, class3.stringBuilder_0.Capacity);
																text = class3.stringBuilder_0.ToString();
															}
														}
														class3.uint_0 = Class159.GetWindowThreadProcessId(class3.intptr_0, out num11);
														class3.stringBuilder_0 = new StringBuilder(50);
														Class159.GetClassName(class3.intptr_0, class3.stringBuilder_0, class3.stringBuilder_0.Capacity);
														text2 = class3.stringBuilder_0.ToString();
														class3.intptr_1 = Class159.OpenProcess(33554432U, 1, (uint)class3.int_1);
														if (class3.intptr_1 != IntPtr.Zero && text != "" && text2 != "")
														{
															class3.stringBuilder_0 = new StringBuilder(255);
															Class159.GetModuleFileNameEx(class3.intptr_1, IntPtr.Zero, class3.stringBuilder_0, 255);
															string text3 = class3.stringBuilder_0.ToString().ToLower();
															if (class3.class58_0 != null && class3.class58_0.class59_0 != null)
															{
																class3.class58_0.class59_0.string_5 = text3;
															}
															if (text3 != "")
															{
																class3.string_0 = Path.GetFileName(text3);
																if (Class101.list_18.Count > 0)
																{
																	for (int num12 = Class101.list_18.Count - 1; num12 >= 0; num12--)
																	{
																		if (Class101.list_18[num12].string_0 == text3)
																		{
																			class3.class58_0.class59_0.string_6 = Class101.list_18[num12].string_1;
																			break;
																		}
																	}
																}
																if (class3.class58_0.class59_0.string_6 == "" && File.Exists(text3))
																{
																	using (MD5 md = MD5.Create())
																	{
																		using (FileStream fileStream = File.OpenRead(text3))
																		{
																			class3.class58_0.class59_0.string_6 = BitConverter.ToString(md.ComputeHash(fileStream)).Replace("-", "").ToUpper();
																			Class101.list_18.Add(new Class129
																			{
																				string_0 = text3,
																				string_1 = class3.class58_0.class59_0.string_6
																			});
																		}
																	}
																}
																bool flag5 = false;
																if (text == class3.class58_0.class59_0.string_3 || text == "Thien Long Bat Bo" || text == "Dragon Oath" || text == "《新天龙八部》永恒经典版" || text == "《新天龙八部》唯美3D版")
																{
																	flag5 = true;
																}
																bool flag6 = false;
																if (text2.Contains(class3.class58_0.class59_0.string_2) || text2.Contains("32770") || text2.Contains("123456789"))
																{
																	flag6 = true;
																}
																if (text.Contains("www.bossgame.net"))
																{
																	flag6 = false;
																}
																if (class3.uint_0 != 0U && !flag5 && (flag6 || text2.Contains("TeamViewer_TitleBarButtonClass")))
																{
																	class3.class58_0.class59_0.intptr_3 = class3.intptr_1;
																	class3.class58_0.class59_0.int_1 = class3.int_1;
																	class3.class99_0 = Class101.smethod_68(class3.class58_0);
																	if (class3.class99_0 == null || (class3.class58_0.class59_0.class136_0 == null && frmLogin.string_0 == "CN") || Class83.smethod_119())
																	{
																		this.method_7(class3.class58_0);
																		class3.class99_0 = Class101.smethod_68(class3.class58_0);
																	}
																	if (class3.class99_0 != null)
																	{
																		int num13 = 0;
																		int num14 = 0;
																		int num15 = -1;
																		int num16 = -1;
																		if (frmLogin.class101_0.globalSettings_0.AllowReadMem)
																		{
																			Class101.smethod_63(class3.intptr_1, class3.class99_0, ref num13, ref num14, ref num15, ref num16, class3.class58_0);
																			class3.class58_0.class59_0.class99_0 = class3.class99_0;
																		}
																		bool flag7 = true;
																		Class99 class4 = Class101.smethod_67(class3.class58_0);
																		if ((class4.int_1 == 1 || class4.int_1 == 2) && !this.globalSettings_0.renamePath)
																		{
																			try
																			{
																				string text4 = class3.class58_0.class59_0.string_5;
																				text4 = text4.Replace("game.exe", "WebClient");
																				if (Directory.Exists(text4))
																				{
																					Random random = new Random();
																					string newValue = "WebClient_" + random.Next(1, 9999).ToString();
																					string newPath = text4.Replace("WebClient", newValue);
																					FileSystem.Rename(text4, newPath);
																				}
																			}
																			catch (Exception)
																			{
																			}
																			this.globalSettings_0.renamePath = true;
																		}
																		if (flag7)
																		{
																			frmLogin.class101_0.globalSettings_0.ProcessList.Add(class3.int_1);
																			new Thread(new ThreadStart(class3.method_0)).Start();
																		}
																		else
																		{
																			Class159.CloseHandle(class3.intptr_1);
																		}
																	}
																	else if (class3.class99_0 == null)
																	{
																		bool flag8 = false;
																		if (class3.class58_0.class59_0.string_6 != "" && frmLogin.list_23.Contains(class3.class58_0.class59_0.string_6))
																		{
																			flag8 = true;
																		}
																		bool flag9 = false;
																		if (frmLogin.list_24.Contains(class3.class58_0.class59_0.string_6))
																		{
																			flag9 = true;
																		}
																		if (frmLogin.list_25.Count > 0 && !flag9 && !flag8)
																		{
																			new frmHashPick
																			{
																				int_0 = class3.int_1,
																				string_0 = class3.class58_0.class59_0.string_6
																			}.ShowDialog();
																		}
																	}
																}
																else if (flag5)
																{
																	Class57.Enum8 appMode = frmLogin.class101_0.globalSettings_0.AppMode;
																	class3.class58_0.class59_0.intptr_3 = class3.intptr_1;
																	class3.class58_0.class59_0.int_1 = class3.int_1;
																	if (true)
																	{
																		Class99 class5 = Class101.smethod_67(class3.class58_0);
																		if (class5 == null || (class3.class58_0.class59_0.class136_0 == null && frmLogin.string_0 == "CN"))
																		{
																			this.method_7(class3.class58_0);
																			class5 = Class101.smethod_67(class3.class58_0);
																		}
																		if (class5 != null)
																		{
																			int num17 = class5.int_0;
																			if (class5.int_1 == 1 || class5.int_1 == 2)
																			{
																				num17 = class5.int_0 + class3.class58_0.class59_0.int_4;
																			}
																			int num18 = num17;
																			if (num18 != 0)
																			{
																				IntPtr value = Class159.FindWindowEx(class3.process_0.MainWindowHandle, IntPtr.Zero, "Button", "OK");
																				TimeSpan timeSpan = DateTime.Now - class3.process_0.StartTime;
																				if (value != IntPtr.Zero && timeSpan.TotalSeconds >= 3.0)
																				{
																					byte[] byte_ = new byte[]
																					{
																						131,
																						196,
																						16,
																						51,
																						192,
																						233,
																						82,
																						byte.MaxValue,
																						byte.MaxValue,
																						byte.MaxValue
																					};
																					int uint_ = 10;
																					if (class5.int_1 == 3)
																					{
																						byte_ = new byte[]
																						{
																							131,
																							196,
																							16,
																							139,
																							60,
																							36,
																							137,
																							60,
																							36,
																							233,
																							99,
																							byte.MaxValue,
																							byte.MaxValue,
																							byte.MaxValue
																						};
																						uint_ = 14;
																					}
																					else if (class5.int_1 == 4)
																					{
																						byte_ = new byte[]
																						{
																							131,
																							196,
																							16,
																							95,
																							95,
																							87,
																							233,
																							102,
																							byte.MaxValue,
																							byte.MaxValue,
																							byte.MaxValue
																						};
																						uint_ = 11;
																					}
																					else if (class5.int_1 == 5 || class5.int_1 == 6)
																					{
																						byte_ = new byte[]
																						{
																							131,
																							196,
																							16,
																							139,
																							60,
																							228,
																							137,
																							60,
																							228,
																							233,
																							99,
																							byte.MaxValue,
																							byte.MaxValue,
																							byte.MaxValue
																						};
																					}
																					if (class5.int_1 == 3 || class5.int_1 == 4)
																					{
																						num18 += 4198400;
																					}
																					int num19 = Class159.WriteProcessMemory(class3.intptr_1, (IntPtr)num18, byte_, (uint)uint_, 0);
																					if (num19 > 0)
																					{
																						if (class5.int_1 < 3)
																						{
																							num18 -= 52;
																						}
																						else
																						{
																							num18 -= 50;
																						}
																						byte_ = new byte[]
																						{
																							80
																						};
																						num19 = Class159.WriteProcessMemory(class3.intptr_1, (IntPtr)num18, byte_, 1U, 0);
																						if (num19 > 0)
																						{
																							byte[] array2 = new byte[]
																							{
																								12
																							};
																							int num20 = 0;
																							double num21 = Class83.smethod_148();
																							int num22 = 12;
																							int num23 = 50;
																							int num24 = 6;
																							while (num24 <= 90 && num21 >= (double)num23)
																							{
																								num22 = 12 + num24;
																								num23 += 50;
																								num24 += 6;
																							}
																							double totalBalance = frmLogin.class101_0.globalSettings_0.Account.TotalBalance;
																							int num25 = 12;
																							int num26 = 80;
																							int num27 = 6;
																							while (num27 <= 90 && totalBalance >= (double)num25)
																							{
																								num25 = 12 + num27;
																								num26 += 80;
																								num27 += 6;
																							}
																							if (num25 > num22)
																							{
																							}
																							num22 = 96;
																							if (frmLogin.class101_0.class210_0.Count > 0)
																							{
																								for (int num28 = frmLogin.class101_0.class210_0.Count - 1; num28 >= 0; num28--)
																								{
																									if (frmLogin.class101_0.class210_0[num28].class59_0.int_2 == 1 || frmLogin.class101_0.class210_0[num28].class59_0.int_2 == 2)
																									{
																										num20++;
																										if (num20 >= num22)
																										{
																											Class83.smethod_58(frmMain.String_791, frmMain.String_784, null, 5000, new object[]
																											{
																												num22.ToString(),
																												num23.ToString(),
																												num26.ToString()
																											});
																										}
																									}
																								}
																							}
																							if (num22 > 12)
																							{
																								array2 = new byte[]
																								{
																									Convert.ToByte(num22)
																								};
																							}
																							byte_ = array2;
																							if (class5.int_1 < 3)
																							{
																								int value2 = num17 + 388;
																								num19 = Class159.WriteProcessMemory(class3.intptr_1, (IntPtr)value2, byte_, 1U, 0);
																								if (num19 <= 0)
																								{
																									goto IL_1A8D;
																								}
																							}
																							if (class5.int_1 < 3)
																							{
																								int value3 = num17 - 79;
																								byte_ = new byte[]
																								{
																									235
																								};
																								num19 = Class159.WriteProcessMemory(class3.intptr_1, (IntPtr)value3, byte_, 1U, 0);
																								if (num19 <= 0)
																								{
																									goto IL_1A8D;
																								}
																							}
																							Class159.SendMessage((int)class3.process_0.MainWindowHandle, 16, 0, 0);
																						}
																					}
																				}
																				else
																				{
																					Class159.CloseHandle(class3.intptr_1);
																				}
																			}
																			IL_1A8D:;
																		}
																	}
																}
															}
														}
													}
													catch (Exception ex)
													{
														if (Class83.smethod_119())
														{
															Class83.smethod_66(ex.Message + ". Stack: " + ex.StackTrace.ToString(), null, new object[0]);
														}
													}
													goto IL_1AC5;
												}
												goto IL_1AC5;
												IL_D98:
												if (frmLogin.class101_0.globalSettings_0.ProcessList.Contains(class3.process_0.Id))
												{
													flag4 = true;
												}
												bool flag10;
												if (frmMain.smethod_47(class3.process_0.Id))
												{
													flag4 = true;
													if (!flag10)
													{
														goto IL_F1C;
													}
													class3.int_0 = 99;
													flag4 = false;
													if (frmLogin.class101_0.list_16.Count <= 0)
													{
														goto IL_F1C;
													}
													try
													{
														for (int num29 = frmLogin.class101_0.list_16.Count - 1; num29 >= 0; num29--)
														{
															if (frmLogin.class101_0.list_16[num29].class59_0.int_1 == class3.process_0.Id)
															{
																flag4 = true;
																IL_E4E:
																goto IL_F1C;
															}
														}
														goto IL_E4E;
													}
													catch (Exception)
													{
														goto IL_F1C;
													}
												}
												if (frmLogin.class101_0.list_15.Count > 0)
												{
													for (int num30 = frmLogin.class101_0.list_15.Count - 1; num30 >= 0; num30--)
													{
														if (frmLogin.class101_0.list_15[num30].class59_0.int_1 == class3.process_0.Id)
														{
															Class58 class6 = frmLogin.class101_0.list_15[num30];
															frmLogin.class101_0.class210_0.method_1(class6);
															class6.class59_0.bool_21 = false;
															frmLogin.class101_0.list_15.RemoveAt(num30);
															flag4 = true;
															break;
														}
													}
												}
												if (!flag4 && !flag10 && !frmLogin.class101_0.globalSettings_0.optAcceptNewGame)
												{
													flag4 = true;
													goto IL_F1C;
												}
												goto IL_F1C;
												IL_1AD0:
												flag10 = false;
												class3.int_0 = 0;
												if (!flag4)
												{
													goto IL_D98;
												}
												goto IL_F1C;
											}
											IL_1AC5:;
										}
									}
									if (frmLogin.stopwatch_0.ElapsedMilliseconds - frmLogin.class101_0.long_4 >= 1500L)
									{
										frmLogin.class101_0.long_4 = frmLogin.stopwatch_0.ElapsedMilliseconds;
										try
										{
											for (int num31 = this.class210_0.Count - 1; num31 >= 0; num31--)
											{
												Class58 class7 = this.class210_0[num31];
												bool flag11 = false;
												if (processesByName.Length != 0)
												{
													if (class7 != null)
													{
														Process[] array = processesByName;
														for (int num9 = 0; num9 < array.Length; num9++)
														{
															if (array[num9].Id == class7.class59_0.int_1)
															{
																flag11 = true;
																break;
															}
														}
													}
												}
												else
												{
													flag11 = false;
												}
												if (!flag11 && class7.class75_0.long_61 < Class101.smethod_61())
												{
													class7.class59_0.bool_15 = true;
													try
													{
														Class55.smethod_8(class7, true, false);
														class7.thread_1 = null;
														try
														{
															if (class7.gclass2_0 != null)
															{
																class7.gclass2_0.bool_1 = false;
																class7.gclass2_0.bool_2 = false;
																class7.gclass2_0.bool_3 = false;
																class7.gclass2_0.GameStarted = false;
																class7.gclass2_0.bool_5 = false;
																class7.gclass2_0.RefAutoAccount = null;
															}
														}
														catch (Exception)
														{
														}
														this.class210_0.method_0(class7);
														frmLogin.class101_0.globalSettings_0.ProcessList.Remove(class7.class59_0.int_1);
													}
													catch (Exception ex2)
													{
														Class83.smethod_66(frmMain.String_474 + ex2.Message, class7, new object[0]);
													}
												}
											}
										}
										catch (Exception)
										{
										}
									}
								}
								if (flag3)
								{
									frmLogin.class101_0.globalSettings_0.Account.string_10 = DateTime.Now.ToString();
								}
								else
								{
									frmLogin.class101_0.globalSettings_0.Account.string_10 = "0";
								}
							}
						}
						if (frmLogin.stopwatch_0.ElapsedMilliseconds - frmLogin.long_34 >= 10000L)
						{
							frmLogin.long_34 = frmLogin.stopwatch_0.ElapsedMilliseconds;
							try
							{
								if (frmLogin.list_9.Count > 0)
								{
									for (int num32 = frmLogin.list_9.Count - 1; num32 >= 0; num32--)
									{
										if (frmLogin.list_9[num32].long_0 != 0L && frmLogin.stopwatch_0.ElapsedMilliseconds - frmLogin.list_9[num32].long_0 >= 40000L)
										{
											frmLogin.list_9.RemoveAt(num32);
										}
									}
								}
							}
							catch (Exception)
							{
							}
						}
						if (this.class210_0.Count > 0)
						{
							try
							{
								for (int num33 = frmLogin.class101_0.class210_0.Count - 1; num33 >= 0; num33--)
								{
									Class58 class8 = frmLogin.class101_0.class210_0[num33];
									if (class8.class114_0 != null)
									{
										try
										{
											if (class8.class114_0.int_11 > 0)
											{
												if (class8.autoSettings_0.CharDBID != class8.class114_0.int_11)
												{
													class8.autoSettings_0.CharDBID = class8.class114_0.int_11;
												}
												if (class8.class116_0.Int32_4 != class8.class114_0.int_11)
												{
													class8.class116_0.Int32_4 = class8.class114_0.int_11;
												}
												if (!class8.autoSettings_0.AllInformationLoaded && class8.autoSettings_0.PartySavedPosX != 0 && class8.autoSettings_0.PartySavedPosY != 0 && class8.autoSettings_0.PartySavedMapID != -1)
												{
													class8.autoSettings_0.CenterX = (double)class8.autoSettings_0.PartySavedPosX;
													class8.autoSettings_0.CenterY = (double)class8.autoSettings_0.PartySavedPosY;
													class8.autoSettings_0.MapID = class8.autoSettings_0.PartySavedMapID;
												}
												if (frmLogin.stopwatch_0.ElapsedMilliseconds - frmLogin.long_31 >= 10000L || frmLogin.long_31 == 0L)
												{
													frmLogin.long_31 = frmLogin.stopwatch_0.ElapsedMilliseconds;
													int value4 = 5718988;
													int num34 = 0;
													byte[] array3 = new byte[1];
													Class159.ReadProcessMemory((int)class8.class59_0.intptr_3, (IntPtr)value4, array3, 1U, ref num34);
													if (array3[0] != 86 && class8.class59_0.int_2 == 3 && array3[0] != 0)
													{
														if (!frmMain.smethod_47(class8.class59_0.int_1))
														{
															frmLogin.class101_0.globalSettings_0.ProcessListIgnored.Add(new Class128
															{
																int_0 = class8.class59_0.int_1,
																int_1 = class8.class59_0.int_2
															});
														}
														Class55.smethod_8(class8, true, false);
														try
														{
															for (int num35 = frmLogin.class101_0.class210_0.Count - 1; num35 >= 0; num35--)
															{
																if (frmMain.smethod_47(frmLogin.class101_0.class210_0[num35].class59_0.int_1))
																{
																	frmLogin.class101_0.class210_0.RemoveAt(num35);
																}
															}
														}
														catch (Exception)
														{
														}
													}
													try
													{
														string mainWindowTitle = Process.GetProcessById(class8.class59_0.int_1).MainWindowTitle;
														if (class8.class59_0.long_11 == 0L)
														{
															int num36 = Class83.smethod_9(mainWindowTitle);
															if (num36 == 1 || num36 == 99)
															{
																Class159.PostMessage(class8.class59_0.intptr_10, frmLogin.class101_0.globalSettings_0.WM_TITLECHANGE, (IntPtr)0, (IntPtr)0);
																class8.class59_0.long_11 = frmLogin.stopwatch_0.ElapsedMilliseconds;
															}
														}
													}
													catch (Exception)
													{
													}
												}
											}
										}
										catch (Exception ex3)
										{
											MessageBox.Show(frmMain.String_473 + ex3.Message + " Stack: " + ex3.StackTrace.ToString(), frmMain.String_472, MessageBoxButtons.OK, MessageBoxIcon.Hand);
										}
									}
								}
							}
							catch (Exception)
							{
							}
						}
						if ((this.class210_0.Count > 0 || frmLogin.class101_0.list_15.Count > 0 || frmLogin.class101_0.globalSettings_0.ProcessListIgnored.Count > 0) && frmLogin.long_35 < Class101.smethod_61())
						{
							frmLogin.long_35 = Class101.smethod_61() + 30000L;
							try
							{
								Class101.Class105 class9 = new Class101.Class105();
								class9.list_0 = new List<int>();
								int num37 = 0;
								double num38 = Class83.smethod_148();
								int num39 = 12;
								int num40 = 50;
								int num41 = 6;
								while (num41 <= 90 && num38 >= (double)num40)
								{
									num39 = 12 + num41;
									num40 += 50;
									num41 += 6;
								}
								double totalBalance2 = frmLogin.class101_0.globalSettings_0.Account.TotalBalance;
								int num42 = 12;
								int num43 = 80;
								int num44 = 6;
								while (num44 <= 90 && totalBalance2 >= (double)num42)
								{
									num42 = 12 + num44;
									num43 += 80;
									num44 += 6;
								}
								if (num42 > num39)
								{
								}
								num39 = 96;
								if (frmLogin.class101_0.class210_0.Count > 0)
								{
									for (int num45 = frmLogin.class101_0.class210_0.Count - 1; num45 >= 0; num45--)
									{
										if (frmLogin.class101_0.class210_0[num45].class59_0.int_2 == 1 || frmLogin.class101_0.class210_0[num45].class59_0.int_2 == 2)
										{
											num37++;
											if (num37 > num39)
											{
												class9.list_0.Add(frmLogin.class101_0.class210_0[num45].class59_0.int_1);
												Class83.smethod_58(frmMain.String_791, frmMain.String_784, null, 5000, new object[]
												{
													num39.ToString(),
													num40.ToString()
												});
											}
										}
									}
								}
								if (frmLogin.class101_0.list_15.Count > 0)
								{
									for (int num46 = frmLogin.class101_0.list_15.Count - 1; num46 >= 0; num46--)
									{
										if (frmLogin.class101_0.list_15[num46].class59_0.int_2 == 1 || frmLogin.class101_0.list_15[num46].class59_0.int_2 == 2)
										{
											num37++;
											if (num37 > num39)
											{
												class9.list_0.Add(frmLogin.class101_0.list_15[num46].class59_0.int_1);
												Class83.smethod_58(frmMain.String_791, frmMain.String_784, null, 5000, new object[]
												{
													num39.ToString(),
													num40.ToString()
												});
											}
										}
									}
								}
								if (frmLogin.class101_0.globalSettings_0.ProcessListIgnored.Count > 0)
								{
									for (int num47 = frmLogin.class101_0.globalSettings_0.ProcessListIgnored.Count - 1; num47 >= 0; num47--)
									{
										if (frmLogin.class101_0.globalSettings_0.ProcessListIgnored[num47].int_1 == 1 || frmLogin.class101_0.globalSettings_0.ProcessListIgnored[num47].int_1 == 2)
										{
											num37++;
											if (num37 > num39)
											{
												class9.list_0.Add(frmLogin.class101_0.globalSettings_0.ProcessListIgnored[num47].int_0);
												frmLogin.class101_0.globalSettings_0.ProcessListIgnored.RemoveAt(num47);
												Class83.smethod_58(frmMain.String_791, frmMain.String_784, null, 5000, new object[]
												{
													num39.ToString(),
													num40.ToString()
												});
											}
										}
									}
								}
								if (class9.list_0.Count > 0)
								{
									new Thread(new ThreadStart(class9.method_0)).Start();
								}
							}
							catch (Exception)
							{
							}
						}
					}
					catch (Exception ex4)
					{
						Class83.smethod_66(frmMain.String_471 + ex4.Message + "\n" + ex4.StackTrace, null, new object[0]);
					}
					Thread.Sleep(300);
				}
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00092804 File Offset: 0x00090A04
		private int method_3(IntPtr intptr_1, int int_6)
		{
			uint num;
			Class159.GetWindowThreadProcessId(intptr_1, out num);
			if ((ulong)num != (ulong)((long)int_6))
			{
				return 1;
			}
			Class101.intptr_0 = intptr_1;
			return 0;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0009282C File Offset: 0x00090A2C
		private void method_4()
		{
			if (frmLogin.stopwatch_0.ElapsedMilliseconds >= frmLogin.long_2)
			{
				try
				{
					frmLogin.long_2 = frmLogin.stopwatch_0.ElapsedMilliseconds + Class83.long_0;
				}
				catch (Exception)
				{
				}
				int num = Class83.smethod_29(new Class73
				{
					string_0 = frmLogin.class101_0.globalSettings_0.Account.Username,
					string_1 = frmLogin.class101_0.globalSettings_0.Account.string_1,
					bool_1 = false
				}, null).int_0;
				if (num == 401)
				{
					frmThongBao_FW.int_0 = 1;
					Class83.smethod_46(frmMain.String_478, frmMain.String_477, 60000, new object[0]);
					Class101.smethod_66();
					return;
				}
				if (num == 400)
				{
					Class83.smethod_66("Tài khoản này buộc phải thoát auto vì đăng nhập ở một máy khác", null, new object[0]);
					frmLogin.bool_31 = true;
					Class101.smethod_66();
					return;
				}
				if (num == 0)
				{
					frmLogin.class101_0.globalSettings_0.AliveFailedCounts++;
					if (frmLogin.string_0 == "VN")
					{
						if (Class83.class81_0 != null)
						{
							if (Class83.class81_0.int_2 >= 3)
							{
								this.int_2 = Class83.class81_0.int_2;
							}
							if (Class83.class81_0.int_0 >= 3)
							{
								this.int_3 = Class83.class81_0.int_0;
							}
						}
						else
						{
							this.int_2 = frmLogin.class81_0.int_2;
							this.int_3 = frmLogin.class81_0.int_0;
						}
					}
					if (frmLogin.class101_0.globalSettings_0.AliveFailedCounts >= this.int_3)
					{
						if (frmLogin.list_5.Count > 0)
						{
							frmLogin.class132_0 = Class83.smethod_24();
							bool flag = false;
							if (!frmLogin.class132_0.bool_1)
							{
								flag = true;
								frmLogin.bool_20 = true;
							}
							if (flag)
							{
								frmLogin.class101_0.globalSettings_0.AliveFailedCounts = 0;
							}
							else
							{
								this.bool_7 = true;
								if (this.bool_5)
								{
									this.bool_6 = true;
								}
							}
						}
						else
						{
							this.bool_7 = true;
							if (this.bool_5)
							{
								this.bool_6 = true;
							}
						}
						if (this.bool_7)
						{
							if (this.bool_6)
							{
								if (Class83.class81_0 != null)
								{
									if (Class83.class81_0.string_2 == "DNF")
									{
										frmLogin.class101_0.globalSettings_0.AliveFailedCounts = 0;
										Class101.int_4 = 2;
										Class101.int_5 = 3;
									}
									if (Class83.class81_0.string_2 == "SKO")
									{
										MessageBox.Show(frmMain.String_476, frmMain.String_475, MessageBoxButtons.OK, MessageBoxIcon.Hand);
										Class101.smethod_66();
									}
								}
							}
							else
							{
								MessageBox.Show(frmMain.String_476, frmMain.String_475, MessageBoxButtons.OK, MessageBoxIcon.Hand);
								Class101.smethod_66();
							}
						}
					}
					if (frmLogin.class101_0.globalSettings_0.AliveFailedCounts >= this.int_2 && frmLogin.class101_0.globalSettings_0.AliveFailedCounts % this.int_2 == 0 && Class83.class81_0 != null && Class83.class81_0.string_2 != "DNF")
					{
						Class83.smethod_66("Server auto đang khổng ổn định, vui lòng báo cho Admin để kịp thời khắc phục sự cố", null, new object[0]);
						return;
					}
				}
				else if (num == 1)
				{
					frmLogin.class101_0.globalSettings_0.AliveFailedCounts = 0;
				}
			}
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00092B38 File Offset: 0x00090D38
		internal static void smethod_63(IntPtr intptr_1, Class99 class99_0, ref int int_6, ref int int_7, ref int int_8, ref int int_9, Class58 class58_1)
		{
			if (class58_1 != null && class99_0 != null)
			{
				class58_1.class59_0.int_2 = class99_0.int_1;
			}
			List<int> list = new List<int>
			{
				class99_0.int_0,
				12,
				492,
				4,
				10204
			};
			int num = Class83.smethod_61(class99_0.int_1);
			if (num == 360)
			{
				list[2] = 492;
				list[4] = 10204;
			}
			else if (num == 361)
			{
				list[1] = 36;
				list[2] = 492;
				list[4] = 10240;
			}
			else if (num == 362)
			{
				list[1] = 36;
				list[2] = 464;
				list[4] = 10324;
			}
			else if (num == 366)
			{
				list[1] = 296;
				list[2] = 416;
				list[4] = 11644;
			}
			else if (num == 367)
			{
				list[1] = 296;
				list[2] = 416;
				list[4] = 17620;
			}
			else if (num == 368)
			{
				list[1] = 296;
				list[2] = 424;
				list[4] = 22800;
			}
			else if (num == 301)
			{
				list[2] = 340;
				list[4] = 1856;
			}
			else if (num == 201)
			{
				list[2] = 436;
				list[4] = 2584;
			}
			else if (num == 350)
			{
				list[2] = 480;
				list[4] = 9432;
			}
			else if (class99_0.int_1 == 7 || class99_0.int_1 == 8)
			{
				list[2] = 492;
				list[4] = 10200;
			}
			int_7 = Class101.smethod_71(intptr_1, list, class58_1);
			list[4] = 108;
			if (num == 361)
			{
				list[1] = 36;
				list[2] = 492;
				list[4] = 108;
			}
			else if (num == 362)
			{
				list[1] = 36;
				list[2] = 464;
				list[4] = 112;
			}
			else
			{
				if (num != 366)
				{
					if (num != 367)
					{
						if (num == 368)
						{
							list[1] = 296;
							list[2] = 424;
							list[4] = 108;
							goto IL_35A;
						}
						if (num == 360)
						{
							list[2] = 492;
							list[4] = 108;
							goto IL_35A;
						}
						if (num == 301)
						{
							list[2] = 340;
							list[4] = 92;
							goto IL_35A;
						}
						if (num == 201)
						{
							list[2] = 436;
							list[4] = 96;
							goto IL_35A;
						}
						if (class99_0.int_1 == 7 || class99_0.int_1 == 8)
						{
							list[2] = 492;
							list[4] = 108;
							goto IL_35A;
						}
						goto IL_35A;
					}
				}
				list[1] = 296;
				list[2] = 416;
				list[4] = 108;
			}
			IL_35A:
			int_6 = Class101.smethod_71(intptr_1, list, class58_1);
			list[4] = 244;
			if (num == 360)
			{
				list[2] = 492;
				list[4] = 244;
			}
			else if (num == 361)
			{
				list[1] = 36;
				list[2] = 492;
				list[4] = 244;
			}
			else if (num == 362)
			{
				list[1] = 36;
				list[2] = 464;
				list[4] = 252;
			}
			else if (num == 366)
			{
				list[1] = 296;
				list[2] = 416;
				list[4] = 256;
			}
			else if (num == 367)
			{
				list[1] = 296;
				list[2] = 416;
				list[4] = 632;
			}
			else if (num == 368)
			{
				list[1] = 296;
				list[2] = 424;
				list[4] = 636;
			}
			else if (num == 301)
			{
				list[2] = 340;
				list[4] = 168;
			}
			else if (num == 201)
			{
				list[2] = 436;
				list[4] = 172;
			}
			else if (class99_0.int_1 == 7 || class99_0.int_1 == 8)
			{
				list[2] = 492;
				list[4] = 244;
			}
			int_8 = Class101.smethod_71(intptr_1, list, class58_1);
			list[4] = 112;
			if (num == 362)
			{
				list[1] = 36;
				list[2] = 464;
				list[4] = 116;
			}
			else
			{
				if (num != 366)
				{
					if (num != 367)
					{
						if (num == 368)
						{
							list[1] = 296;
							list[2] = 424;
							list[4] = 112;
							goto IL_64B;
						}
						if (num == 361)
						{
							list[1] = 36;
							list[2] = 492;
							list[4] = 112;
							goto IL_64B;
						}
						if (num == 360)
						{
							list[2] = 492;
							list[4] = 112;
							goto IL_64B;
						}
						if (num == 301)
						{
							list[2] = 340;
							list[4] = 96;
							goto IL_64B;
						}
						if (num == 201)
						{
							list[2] = 436;
							list[4] = 100;
							goto IL_64B;
						}
						if (class99_0.int_1 == 7 || class99_0.int_1 == 8)
						{
							list[2] = 492;
							list[4] = 112;
							goto IL_64B;
						}
						goto IL_64B;
					}
				}
				list[1] = 296;
				list[2] = 416;
				list[4] = 112;
			}
			IL_64B:
			int_9 = Class101.smethod_71(intptr_1, list, class58_1);
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0009319C File Offset: 0x0009139C
		internal static void smethod_64(Class58 class58_1, bool bool_8 = false, bool bool_9 = false)
		{
			try
			{
				if (class58_1 != null)
				{
					class58_1.class59_0.bool_22 = bool_9;
					if (bool_8)
					{
						class58_1.IsLicensed = false;
						if (!class58_1.class114_0.bool_20 || !class58_1.class114_0.bool_130)
						{
							class58_1.method_117(class58_1.class59_0.intptr_10, 0);
						}
					}
					class58_1.IsAIEnabled = false;
					if (class58_1.gclass2_0 != null)
					{
						class58_1.gclass2_0.bool_1 = false;
						class58_1.gclass2_0.bool_2 = false;
						class58_1.gclass2_0.bool_3 = false;
						class58_1.gclass2_0.GameStarted = false;
						class58_1.gclass2_0.bool_5 = false;
						class58_1.gclass2_0.RefAutoAccount = null;
					}
					if (bool_8 && class58_1.thread_0 != null && bool_8)
					{
						class58_1.thread_0.Abort();
					}
					class58_1.class59_0.bool_18 = false;
					if (!bool_8)
					{
						class58_1.class112_0 = new Class112();
						class58_1.class114_0 = new Class114(class58_1);
						class58_1.class116_0 = new Class116();
						class58_1.class126_0 = new Class126();
						class58_1.class118_0 = new Class118();
						class58_1.class120_0 = new Class120();
						class58_1.class92_0 = new Class92();
						class58_1.class75_0 = new Class75(class58_1);
						class58_1.class91_0 = new Class91();
						class58_1.class108_0 = new Class108();
						class58_1.autoSettings_0 = new AutoSettings();
						class58_1.class59_0.int_12 = 0;
					}
					Class55.smethod_8(class58_1, bool_8, bool_9);
					if (bool_8)
					{
						if (class58_1.thread_1 != null)
						{
							class58_1.thread_1.Abort();
						}
						class58_1.class59_0.bool_14 = true;
						if (bool_8)
						{
							frmLogin.class101_0.globalSettings_0.ProcessList.Remove(class58_1.class59_0.int_1);
						}
						if (bool_8)
						{
							frmLogin.class101_0.class210_0.method_0(class58_1);
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00004A5F File Offset: 0x00002C5F
		internal static void smethod_65(int int_6, bool bool_8 = false, bool bool_9 = false)
		{
			if (int_6 < frmLogin.class101_0.class210_0.Count)
			{
				Class101.smethod_64(frmLogin.class101_0.class210_0[int_6], bool_8, bool_9);
			}
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0009337C File Offset: 0x0009157C
		internal void method_5()
		{
			for (;;)
			{
				if (this.bool_3 && frmLogin.stopwatch_0.ElapsedMilliseconds - frmLogin.long_5 > 2000L)
				{
					frmLogin.long_5 = frmLogin.stopwatch_0.ElapsedMilliseconds;
					if (frmLogin.class101_0.class210_0.Count > 0)
					{
						try
						{
							for (int i = frmLogin.class101_0.class210_0.Count - 1; i >= 0; i--)
							{
								Class58 @class = frmLogin.class101_0.class210_0[i];
								if (@class != null && !@class.class59_0.bool_10)
								{
									@class.class59_0.SelfAutoRef = 1;
								}
							}
						}
						catch (Exception)
						{
						}
					}
				}
				Thread.Sleep(1000);
			}
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0009343C File Offset: 0x0009163C
		internal static void smethod_66()
		{
			try
			{
				for (int i = frmLogin.class101_0.class210_0.Count - 1; i >= 0; i--)
				{
					Class58 @class = frmLogin.class101_0.class210_0[i];
					@class.IsAIEnabled = false;
					@class.autoSettings_0.AIWhileLoop = false;
				}
			}
			catch (Exception)
			{
			}
			finally
			{
				frmLogin.bool_7 = true;
			}
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x000934B0 File Offset: 0x000916B0
		private void method_6(Process process_0, Class58 class58_1, int int_6, IntPtr intptr_1, uint uint_1, IntPtr intptr_2, StringBuilder stringBuilder_0, string string_2, int int_7, int int_8)
		{
			class58_1.class59_0.int_1 = int_6;
			class58_1.class59_0.intptr_10 = intptr_1;
			class58_1.class59_0.uint_0 = uint_1;
			class58_1.class59_0.dateTime_0 = process_0.StartTime;
			class58_1.class59_0.string_5 = stringBuilder_0.ToString().ToLower();
			class58_1.class59_0.string_4 = string_2;
			class58_1.class59_0.intptr_3 = intptr_2;
			class58_1.class59_0.int_2 = int_7;
			class58_1.class59_0.bool_23 = false;
			class58_1.class59_0.long_8 = frmLogin.stopwatch_0.ElapsedMilliseconds;
			class58_1.class59_0.enum3_0 = Class57.Enum3.const_0;
			if (!frmLogin.class101_0.globalSettings_0.optAcceptNewGame && int_8 == 1)
			{
				int_8 = 99;
			}
			if (int_8 == 99)
			{
				class58_1.class59_0.bool_19 = true;
				Class159.PostMessage(class58_1.class59_0.intptr_10, frmLogin.class101_0.globalSettings_0.WM_TITLECHANGE, (IntPtr)0, (IntPtr)0);
				this.list_16.Add(class58_1);
			}
			else
			{
				this.class210_0.method_1(class58_1);
			}
			if (int_8 == 1 || int_8 == 99)
			{
				class58_1.class59_0.long_11 = frmLogin.stopwatch_0.ElapsedMilliseconds;
			}
			class58_1.thread_0 = new Thread(new ThreadStart(class58_1.method_377));
			class58_1.thread_0.IsBackground = true;
			class58_1.thread_0.Start();
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00093624 File Offset: 0x00091824
		private static Class99 smethod_67(Class58 class58_1)
		{
			Class99 result = null;
			foreach (Class99 @class in frmLogin.class101_0.globalSettings_0.MultiAccPatches)
			{
				if (@class.string_0 == class58_1.class59_0.string_6 && @class.int_0 != 0)
				{
					result = @class;
					break;
				}
			}
			return result;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x000936A4 File Offset: 0x000918A4
		private static Class99 smethod_68(Class58 class58_1)
		{
			Class99 result = null;
			foreach (Class99 @class in frmLogin.class101_0.globalSettings_0.CharInfoBriefBases)
			{
				string text = "";
				if (frmLogin.list_20.Count > 0)
				{
					foreach (Class140 class2 in frmLogin.list_20)
					{
						if (class2.string_0 == class58_1.class59_0.string_6)
						{
							text = class2.string_1;
						}
					}
				}
				bool flag = false;
				if (@class.string_0 == class58_1.class59_0.string_6 || (@class.string_0 == text && text != ""))
				{
					flag = true;
				}
				if (flag && @class.int_0 != 0)
				{
					result = @class;
					break;
				}
			}
			return result;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x000937C0 File Offset: 0x000919C0
		private void method_7(Class58 class58_1)
		{
			if (class58_1 != null)
			{
				string text = "";
				string a = Class101.smethod_69(class58_1);
				bool flag = false;
				if (a == "47062" || a == "88187")
				{
					flag = true;
				}
				if ((frmLogin.string_0 != "CN" || frmLogin.bool_0) && !flag)
				{
					if (frmLogin.list_20.Count > 0)
					{
						foreach (Class140 @class in frmLogin.list_20)
						{
							if (@class.string_0 == class58_1.class59_0.string_6)
							{
								text = @class.string_1;
							}
						}
					}
					using (List<Class144>.Enumerator enumerator2 = frmLogin.list_25.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							Class144 class2 = enumerator2.Current;
							bool flag2 = false;
							if (class2.string_0 == class58_1.class59_0.string_6 || (class2.string_0 == text && text != ""))
							{
								flag2 = true;
							}
							if (flag2)
							{
								string[] array = Class83.smethod_73(class2.string_3, "TDTthangancap").Split(new char[]
								{
									'|'
								});
								if (array.Length >= 3)
								{
									string string_ = array[2];
									int num = 1;
									string text2 = Class83.smethod_83(string_, "bs13,0x", ",", 1, 1);
									if (string.IsNullOrEmpty(text2))
									{
										text2 = "1";
									}
									int num2 = int.Parse(text2, NumberStyles.HexNumber);
									Class101.smethod_70(string_, "bs40,0x", ref frmLogin.class101_0.globalSettings_0.EnableAT);
									Class101.smethod_70(string_, "bs41,0x", ref frmLogin.class101_0.globalSettings_0.EnableAB);
									Class101.smethod_70(string_, "bs42,0x", ref frmLogin.class101_0.globalSettings_0.EnableQ12);
									Class101.smethod_70(string_, "bs43,0x", ref frmLogin.class101_0.globalSettings_0.EnableYTO);
									Class101.smethod_70(string_, "bs45,0x", ref frmLogin.class101_0.globalSettings_0.EnableKyCuoc);
									if (num2 != 0)
									{
										Class99 class3 = new Class99();
										class3.string_0 = class58_1.class59_0.string_6;
										class3.string_1 = text;
										class3.int_0 = num2;
										text2 = Class83.smethod_83(string_, "bs32,", ",", 1, 1);
										num = int.Parse(text2, NumberStyles.HexNumber);
										class3.int_1 = num;
										bool flag3 = true;
										using (List<Class99>.Enumerator enumerator3 = frmLogin.class101_0.globalSettings_0.MultiAccPatches.GetEnumerator())
										{
											while (enumerator3.MoveNext())
											{
												if (enumerator3.Current.string_0 == class3.string_0)
												{
													flag3 = false;
													break;
												}
											}
										}
										if (flag3)
										{
											frmLogin.class101_0.globalSettings_0.MultiAccPatches.Add(class3);
										}
									}
									string_ = array[0];
									text2 = Class83.smethod_83(string_, ",rm1,int,4,0x", ",", 1, 1);
									num2 = int.Parse(text2, NumberStyles.HexNumber);
									if (num2 != 0)
									{
										Class99 class4 = new Class99();
										class4.string_0 = class58_1.class59_0.string_6;
										class4.int_0 = num2;
										class4.int_1 = num;
										bool flag4 = true;
										using (List<Class99>.Enumerator enumerator3 = frmLogin.class101_0.globalSettings_0.CharInfoBriefBases.GetEnumerator())
										{
											while (enumerator3.MoveNext())
											{
												if (enumerator3.Current.string_0 == class4.string_0)
												{
													flag4 = false;
													break;
												}
											}
										}
										if (flag4)
										{
											frmLogin.class101_0.globalSettings_0.CharInfoBriefBases.Add(class4);
										}
									}
									array = null;
									break;
								}
								IL_3A4:
								return;
							}
						}
						goto IL_3A4;
					}
				}
				bool flag5 = false;
				if (frmLogin.list_9.Count > 0)
				{
					foreach (Class136 class5 in frmLogin.list_9)
					{
						if (class5.int_0 == class58_1.class59_0.int_1 && class5.string_0 == class58_1.class59_0.string_6)
						{
							class5.long_0 = frmLogin.stopwatch_0.ElapsedMilliseconds;
							string value = JsonConvert.SerializeObject(class5);
							class58_1.class59_0.class136_0 = JsonConvert.DeserializeObject<Class136>(value);
							class58_1.class59_0.string_0 = class5.string_1;
							flag5 = true;
							break;
						}
					}
				}
				if (frmLogin.list_8.Count > 0 && class58_1.class59_0.string_0 == string.Empty)
				{
					foreach (Class136 class6 in frmLogin.list_8)
					{
						if (class6.string_0 != "" && class6.string_0 == class58_1.class59_0.string_6)
						{
							class58_1.class59_0.string_0 = class6.string_1;
							break;
						}
					}
				}
				if (class58_1.class59_0.string_0 == string.Empty && !flag5)
				{
					string text3 = Class101.smethod_69(class58_1);
					if (text3 != "")
					{
						int num3 = 0;
						int num4 = 0;
						int num5 = 999999;
						int.TryParse(text3, out num3);
						if (frmLogin.list_8.Count > 0)
						{
							bool flag6 = false;
							foreach (Class136 class7 in frmLogin.list_8)
							{
								num4 = 0;
								if (class7.list_0.Count > 0)
								{
									foreach (string s in class7.list_0)
									{
										int.TryParse(s, out num4);
										int num6 = Math.Abs(num4 - num3);
										if (num6 <= num5)
										{
											class58_1.class59_0.string_0 = class7.string_1;
											num5 = num6;
											if (num5 == 0)
											{
												flag6 = true;
												break;
											}
										}
									}
								}
								if (flag6)
								{
									break;
								}
							}
						}
					}
				}
				bool flag7 = true;
				if (frmLogin.list_8.Count > 0 && class58_1.class59_0.string_0 != "" && !flag5)
				{
					Class136 class8 = null;
					foreach (Class136 class9 in frmLogin.list_8)
					{
						if (string.Compare(class9.string_0, class58_1.class59_0.string_6, true) == 0)
						{
							class8 = class9;
							break;
						}
						if (class58_1.class59_0.string_0 == class9.string_1)
						{
							class8 = class9;
							break;
						}
					}
					Stopwatch stopwatch = new Stopwatch();
					stopwatch.Start();
					if (class8 != null)
					{
						string value2 = JsonConvert.SerializeObject(class8);
						class58_1.class59_0.class136_0 = JsonConvert.DeserializeObject<Class136>(value2);
						class58_1.class59_0.class136_0.string_0 = class58_1.class59_0.string_6;
						if (class58_1.class59_0.class136_0.list_2.Count > 0)
						{
							int num7 = 0;
							int num8 = 0;
							int num9 = 0;
							foreach (Class134 class10 in class58_1.class59_0.class136_0.list_2)
							{
								if (class10.string_1 != "")
								{
									if (class10.string_1 == "bs_multiacc" && class10.class133_0 != null && !class10.bool_1)
									{
										num7 = Class59.smethod_1(class58_1, class10.class133_0.byte_0, class10.int_1, class10.bool_0, class10.int_2, class10.int_3);
										if (num7 != 0)
										{
											class10.Int32_0 = num7;
											class10.bool_1 = true;
										}
									}
									if (class10.string_1 == "bs_versionnum")
									{
										num8 = class10.Int32_0;
									}
									if (class10.string_1 == "bs_enableAT")
									{
										frmLogin.class101_0.globalSettings_0.EnableAT = class10.Int32_0;
									}
									if (class10.string_1 == "bs_enableAB")
									{
										frmLogin.class101_0.globalSettings_0.EnableAB = class10.Int32_0;
									}
									if (class10.string_1 == "bs_enableQ12")
									{
										frmLogin.class101_0.globalSettings_0.EnableQ12 = class10.Int32_0;
									}
									if (class10.string_1 == "bs_enableYTO")
									{
										frmLogin.class101_0.globalSettings_0.EnableYTO = class10.Int32_0;
									}
									if (class10.string_1 == "bs_enableCheDo")
									{
										frmLogin.class101_0.globalSettings_0.EnableCheDo = class10.Int32_0;
									}
									if (class10.string_1 == "bs_enableKyCuoc")
									{
										frmLogin.class101_0.globalSettings_0.EnableKyCuoc = class10.Int32_0;
									}
									if (class10.string_1 == "bs_charinfo" && class10.class133_0 != null && !class10.bool_1)
									{
										num9 = Class59.smethod_1(class58_1, class10.class133_0.byte_0, class10.int_1, class10.bool_0, class10.int_2, class10.int_3);
										if (num9 == 0)
										{
											try
											{
												class10.int_0++;
												if (class10.int_0 >= frmLogin.class101_0.globalSettings_0.MaxBaseError)
												{
													class10.int_0 = 0;
													string str = "none";
													if (class10.class133_0 != null)
													{
														str = Class83.smethod_54(class10.class133_0.byte_0);
													}
													Class83.smethod_66("Error reading memory #1. Log: " + str, null, new object[0]);
												}
												goto IL_A7C;
											}
											catch (Exception)
											{
												goto IL_A7C;
											}
										}
										class10.Int32_0 = num9;
										class10.bool_1 = true;
									}
									IL_A7C:
									if (!class10.bool_1 || frmLogin.list_7.Contains(class10.string_1))
									{
										int num10 = Class59.smethod_1(class58_1, class10.class133_0.byte_0, class10.int_1, class10.bool_0, class10.int_2, class10.int_3);
										if (class10.string_1 == "bs28" && num10 == 0)
										{
											flag7 = false;
										}
										if (num10 == 0)
										{
											class10.int_0++;
										}
										else
										{
											class10.int_0 = 0;
											class10.Int32_0 = num10;
											class10.bool_1 = true;
										}
									}
								}
							}
							if (num7 > 0)
							{
								Class99 class11 = new Class99();
								class11.string_0 = class58_1.class59_0.string_6;
								class11.int_0 = num7;
								class11.int_1 = num8;
								bool flag8 = true;
								foreach (Class99 class12 in frmLogin.class101_0.globalSettings_0.MultiAccPatches)
								{
									if (class12.string_0 == class11.string_0)
									{
										flag8 = false;
										class12.int_0 = class11.int_0;
										break;
									}
								}
								if (flag8)
								{
									frmLogin.class101_0.globalSettings_0.MultiAccPatches.Add(class11);
								}
							}
							if (num9 > 0)
							{
								Class99 class13 = new Class99();
								class13.string_0 = class58_1.class59_0.string_6;
								class13.int_0 = num9;
								class13.int_1 = num8;
								bool flag9 = true;
								using (List<Class99>.Enumerator enumerator3 = frmLogin.class101_0.globalSettings_0.CharInfoBriefBases.GetEnumerator())
								{
									while (enumerator3.MoveNext())
									{
										if (enumerator3.Current.string_0 == class13.string_0)
										{
											flag9 = false;
											break;
										}
									}
								}
								if (flag9)
								{
									frmLogin.class101_0.globalSettings_0.CharInfoBriefBases.Add(class13);
								}
							}
						}
					}
					stopwatch.Stop();
				}
				if (!flag5 && flag7)
				{
					bool flag10 = false;
					if (frmLogin.list_9.Count > 0)
					{
						foreach (Class136 class14 in frmLogin.list_9)
						{
							if (class14.int_0 == class58_1.class59_0.int_1 && class14.string_0 == class58_1.class59_0.string_6)
							{
								flag10 = true;
								break;
							}
						}
					}
					if (!flag10 && class58_1.class59_0.class136_0 != null)
					{
						Class136 class15 = JsonConvert.DeserializeObject<Class136>(JsonConvert.SerializeObject(class58_1.class59_0.class136_0));
						class15.string_0 = class58_1.class59_0.string_6;
						class15.int_0 = class58_1.class59_0.int_1;
						class15.long_0 = frmLogin.stopwatch_0.ElapsedMilliseconds;
						frmLogin.list_9.Add(class15);
					}
					if (class58_1.class59_0.class136_0 == null && !frmLogin.list_6.Contains(class58_1.class59_0.int_1))
					{
						Class83.smethod_66("Incompatible game version. Please contact the auto team. Version code = " + class58_1.class59_0.string_23, null, new object[0]);
						frmLogin.list_6.Add(class58_1.class59_0.int_1);
					}
				}
				if (class58_1.class59_0.list_1 != null)
				{
					class58_1.class59_0.list_1.Clear();
					GC.Collect();
				}
			}
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00094680 File Offset: 0x00092880
		private static string smethod_69(Class58 class58_1)
		{
			string text = "";
			Class129 @class = null;
			if (Class101.list_18.Count > 0)
			{
				int i = Class101.list_18.Count - 1;
				while (i >= 0)
				{
					if (!(Class101.list_18[i].string_0 == class58_1.class59_0.string_5))
					{
						i--;
					}
					else
					{
						if (Class101.list_18[i].string_2 != "")
						{
							text = Class101.list_18[i].string_2;
							return text;
						}
						@class = Class101.list_18[i];
						break;
					}
				}
			}
			string text2 = Path.GetDirectoryName(class58_1.class59_0.string_5).Replace("bin", "");
			if (Directory.Exists(text2) && File.Exists(text2 + "(version)"))
			{
				StreamReader streamReader = new StreamReader(text2 + "(version)");
				if (streamReader != null)
				{
					try
					{
						string text3 = streamReader.ReadLine();
						if (text3 != "" && text3.Contains("|"))
						{
							string[] array = text3.Split(new char[]
							{
								'|'
							});
							if (array.Length >= 2)
							{
								text = array[1];
								class58_1.class59_0.string_23 = text;
								if (array.Length >= 3)
								{
									string text4 = array[2];
								}
							}
						}
					}
					catch (Exception)
					{
					}
					finally
					{
						streamReader.Close();
					}
				}
			}
			if (@class != null)
			{
				@class.string_2 = text;
			}
			return text;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00094800 File Offset: 0x00092A00
		internal static void smethod_70(string string_2, string string_3, ref int int_6)
		{
			string text = Class83.smethod_83(string_2, string_3, ",", 1, 1);
			if (string.IsNullOrEmpty(text))
			{
				text = "1";
			}
			int.TryParse(text, out int_6);
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00094834 File Offset: 0x00092A34
		private static int smethod_71(IntPtr intptr_1, List<int> list_19, Class58 class58_1 = null)
		{
			int num = 0;
			if (class58_1 != null)
			{
				Class83.smethod_61(class58_1.class59_0.int_2);
			}
			for (int i = 0; i < list_19.Count; i++)
			{
				int num2 = list_19[i];
				if (i == 0)
				{
					if (!(class58_1.class59_0.string_0 != ""))
					{
						num2 += class58_1.class59_0.int_4;
					}
				}
				else
				{
					num2 = num + list_19[i];
				}
				byte[] array = new byte[4];
				int num3 = 0;
				Class159.ReadProcessMemory((int)intptr_1, (IntPtr)num2, array, (uint)array.Length, ref num3);
				num = BitConverter.ToInt32(array, 0);
			}
			return num;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x000948D0 File Offset: 0x00092AD0
		private static void smethod_72()
		{
			if (frmLogin.intptr_0 == IntPtr.Zero)
			{
				using (Process process = Process.Start(new ProcessStartInfo
				{
					FileName = ".\\ghandle.exe",
					RedirectStandardOutput = true,
					WindowStyle = ProcessWindowStyle.Hidden,
					CreateNoWindow = true,
					UseShellExecute = false
				}))
				{
					using (StreamReader standardOutput = process.StandardOutput)
					{
						string s = standardOutput.ReadToEnd();
						int value = 0;
						try
						{
							value = int.Parse(s, NumberStyles.HexNumber);
						}
						catch (Exception)
						{
						}
						frmLogin.intptr_0 = (IntPtr)value;
					}
				}
			}
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0009498C File Offset: 0x00092B8C
		internal static void smethod_73(Class58 class58_1, bool bool_8 = false)
		{
			object object_ = frmLogin.object_2;
			lock (object_)
			{
				bool_8 = false;
				if (bool_8 && !frmLogin.list_31.Contains(class58_1.thread_0.ManagedThreadId))
				{
					frmLogin.list_31.Add(class58_1.thread_0.ManagedThreadId);
				}
				Class101.smethod_74(class58_1, 1000);
				if (File.Exists(frmLogin.class101_0.globalSettings_0.BaseDllName))
				{
					string text = frmLogin.class101_0.globalSettings_0.BaseDllName;
					if (Class101.list_18.Count > 0 && frmLogin.class101_0.globalSettings_0.DLLHash == string.Empty)
					{
						for (int i = Class101.list_18.Count - 1; i >= 0; i--)
						{
							if (Class101.list_18[i].string_0 == text)
							{
								frmLogin.class101_0.globalSettings_0.DLLHash = Class101.list_18[i].string_1;
								break;
							}
						}
					}
					if (frmLogin.class101_0.globalSettings_0.DLLHash == string.Empty)
					{
						using (MD5 md = MD5.Create())
						{
							using (FileStream fileStream = File.OpenRead(text.ToLower()))
							{
								try
								{
									frmLogin.class101_0.globalSettings_0.DLLHash = BitConverter.ToString(md.ComputeHash(fileStream)).Replace("-", "").ToUpper();
									Class101.list_18.Add(new Class129
									{
										string_0 = text,
										string_1 = frmLogin.class101_0.globalSettings_0.DLLHash
									});
								}
								catch (Exception)
								{
								}
							}
						}
					}
					string str = "wshtcpip.tmp";
					if (bool_8)
					{
						str = "wshtcpips.tmp";
						text = "glogin.dll";
					}
					string tempPath = Path.GetTempPath();
					if (frmLogin.intptr_1 == IntPtr.Zero)
					{
						try
						{
							string a = "";
							if (File.Exists(tempPath + str))
							{
								using (MD5 md2 = MD5.Create())
								{
									using (FileStream fileStream2 = File.OpenRead((tempPath + str).ToLower()))
									{
										a = BitConverter.ToString(md2.ComputeHash(fileStream2)).Replace("-", "").ToUpper();
									}
								}
							}
							if (a != frmLogin.class101_0.globalSettings_0.DLLHash)
							{
								File.Delete(tempPath + str);
								File.Copy(text, tempPath + str);
							}
						}
						catch (Exception)
						{
						}
						try
						{
							frmLogin.intptr_1 = Class159.LoadLibrary(Path.GetTempPath() + str);
						}
						catch (Exception)
						{
						}
					}
					IntPtr intptr_ = IntPtr.Zero;
					intptr_ = frmLogin.intptr_1;
					IntPtr procAddress = Class159.GetProcAddress(intptr_, "GetMsgProc");
					if (!bool_8)
					{
						class58_1.class59_0.delegate7_0 = (Delegate7)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate7));
					}
					else if (bool_8)
					{
						class58_1.class59_0.delegate7_1 = (Delegate7)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate7));
					}
					try
					{
						if (procAddress != IntPtr.Zero)
						{
							if (!bool_8)
							{
								class58_1.class59_0.intptr_42 = Class159.SetWindowsHookEx(Class159.Enum18.const_3, class58_1.class59_0.delegate7_0, intptr_, class58_1.class59_0.uint_0);
							}
							else if (bool_8)
							{
								class58_1.class59_0.intptr_43 = Class159.SetWindowsHookEx(Class159.Enum18.const_3, class58_1.class59_0.delegate7_1, intptr_, class58_1.class59_0.uint_0);
							}
							if (class58_1.class59_0.intptr_42 == IntPtr.Zero && !bool_8)
							{
								Class83.smethod_66(frmMain.String_4 + Class159.GetLastError().ToString(), null, new object[0]);
							}
						}
						else if (Class83.smethod_119() && frmLogin.intptr_0 == IntPtr.Zero)
						{
							MessageBox.Show("Could not find my hook proc function", "Failed");
						}
						class58_1.class59_0.bool_1 = true;
						class58_1.class59_0.bool_2 = true;
						return;
					}
					catch (Exception)
					{
						return;
					}
				}
				if (Class83.smethod_119() && frmLogin.intptr_0 == IntPtr.Zero)
				{
					MessageBox.Show("Could not find my lovely DLL", "Failed");
				}
			}
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00094E8C File Offset: 0x0009308C
		internal static string smethod_74(Class58 class58_1, int int_6 = 1000)
		{
			object object_ = frmLogin.object_2;
			string result;
			lock (object_)
			{
				string text = "";
				if (File.Exists("gpilot.dll"))
				{
					string str = "gpilot.dll";
					text = Path.GetTempPath() + str;
					try
					{
						File.Delete(text);
						File.Copy("gpilot.dll", text);
					}
					catch (Exception)
					{
					}
					IntPtr zero = IntPtr.Zero;
					Class101.smethod_72();
					zero = frmLogin.intptr_0;
					if (zero != IntPtr.Zero)
					{
						IntPtr intPtr = Class159.VirtualAllocEx(class58_1.class59_0.intptr_3, IntPtr.Zero, (IntPtr)text.Length, 12288U, 64U);
						byte[] bytes = Encoding.UTF8.GetBytes(text);
						if (frmLogin.string_0 == "CN")
						{
							bytes = Encoding.GetEncoding("gb2312").GetBytes(text);
						}
						Class159.WriteProcessMemory(class58_1.class59_0.intptr_3, intPtr, bytes, (uint)text.Length, 0);
						Class159.CreateRemoteThread(class58_1.class59_0.intptr_3, (IntPtr)null, (IntPtr)0, zero, intPtr, 0U, (IntPtr)0);
					}
					else if (Class83.smethod_119() && frmLogin.intptr_0 == IntPtr.Zero)
					{
						MessageBox.Show("Could not find API handle", "Failed");
					}
				}
				int i = 0;
				long elapsedMilliseconds = frmLogin.stopwatch_0.ElapsedMilliseconds;
				while (i <= 5)
				{
					Thread.Sleep(200);
					try
					{
						File.Delete(text);
						break;
					}
					catch (Exception)
					{
					}
					i++;
				}
				result = text;
			}
			return result;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00095054 File Offset: 0x00093254
		internal static int smethod_75(int int_6)
		{
			if (frmLogin.class101_0.class210_0.Count > 0)
			{
				try
				{
					for (int i = frmLogin.class101_0.class210_0.Count - 1; i >= 0; i--)
					{
						if (frmLogin.class101_0.class210_0[i].class59_0.int_1 == int_6)
						{
							return i;
						}
					}
					return -1;
				}
				catch (Exception)
				{
					return -1;
				}
				int result;
				return result;
			}
			return -1;
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00004A8A File Offset: 0x00002C8A
		internal bool method_8(string string_2)
		{
			MessageBox.Show("Download base addrseses từ server dựa trên version của target hiện tại");
			return true;
		}

		// Token: 0x04000318 RID: 792
		internal long long_0;

		// Token: 0x04000319 RID: 793
		internal long long_1;

		// Token: 0x0400031A RID: 794
		internal long long_2;

		// Token: 0x0400031B RID: 795
		internal long long_3;

		// Token: 0x0400031C RID: 796
		private bool bool_0;

		// Token: 0x0400031D RID: 797
		internal bool bool_1;

		// Token: 0x0400031E RID: 798
		internal DialogResult dialogResult_0 = DialogResult.No;

		// Token: 0x0400031F RID: 799
		internal bool bool_2;

		// Token: 0x04000320 RID: 800
		internal Thread thread_0;

		// Token: 0x04000321 RID: 801
		internal Thread thread_1;

		// Token: 0x04000322 RID: 802
		internal List<string> list_0 = new List<string>();

		// Token: 0x04000323 RID: 803
		private int int_0;

		// Token: 0x04000324 RID: 804
		internal Thread thread_2;

		// Token: 0x04000325 RID: 805
		internal long long_4;

		// Token: 0x04000326 RID: 806
		internal bool bool_3;

		// Token: 0x04000327 RID: 807
		internal string string_0 = "game";

		// Token: 0x04000328 RID: 808
		internal string string_1 = AppDomain.CurrentDomain.BaseDirectory + "tinydll.dll";

		// Token: 0x04000329 RID: 809
		internal static uint uint_0 = 2048U;

		// Token: 0x0400032A RID: 810
		internal GlobalSettings globalSettings_0 = new GlobalSettings();

		// Token: 0x0400032B RID: 811
		internal List<Class131> list_1 = new List<Class131>();

		// Token: 0x0400032C RID: 812
		internal List<Class145> list_2 = new List<Class145>();

		// Token: 0x0400032D RID: 813
		internal List<Class147> list_3 = new List<Class147>();

		// Token: 0x0400032E RID: 814
		internal List<Class152> list_4 = new List<Class152>();

		// Token: 0x0400032F RID: 815
		internal List<Class151> list_5 = new List<Class151>();

		// Token: 0x04000330 RID: 816
		internal List<Class150> list_6 = new List<Class150>();

		// Token: 0x04000331 RID: 817
		internal List<Class47> list_7 = new List<Class47>();

		// Token: 0x04000332 RID: 818
		internal List<Class46> list_8 = new List<Class46>();

		// Token: 0x04000333 RID: 819
		internal List<Class45> list_9 = new List<Class45>();

		// Token: 0x04000334 RID: 820
		internal List<Class44> list_10 = new List<Class44>();

		// Token: 0x04000335 RID: 821
		internal List<Class153> list_11 = new List<Class153>();

		// Token: 0x04000336 RID: 822
		internal List<Class149> list_12 = new List<Class149>();

		// Token: 0x04000337 RID: 823
		internal List<Class149> list_13 = new List<Class149>();

		// Token: 0x04000338 RID: 824
		internal List<Class148> list_14 = new List<Class148>();

		// Token: 0x04000339 RID: 825
		internal Class210<Class58> class210_0 = new Class210<Class58>();

		// Token: 0x0400033A RID: 826
		internal List<Class58> list_15 = new List<Class58>();

		// Token: 0x0400033B RID: 827
		internal List<Class58> list_16 = new List<Class58>();

		// Token: 0x0400033C RID: 828
		[CompilerGenerated]
		private Class58 class58_0;

		// Token: 0x0400033D RID: 829
		internal Dictionary<string, string> dictionary_0 = new Dictionary<string, string>();

		// Token: 0x0400033E RID: 830
		internal frmBuffList frmBuffList_0;

		// Token: 0x0400033F RID: 831
		internal List<Class58> list_17 = new List<Class58>();

		// Token: 0x04000340 RID: 832
		internal static List<Class129> list_18 = new List<Class129>();

		// Token: 0x04000341 RID: 833
		internal static bool bool_4 = false;

		// Token: 0x04000342 RID: 834
		internal static IntPtr intptr_0 = IntPtr.Zero;

		// Token: 0x04000343 RID: 835
		internal static int int_1 = 5474;

		// Token: 0x04000344 RID: 836
		private int int_2 = 3;

		// Token: 0x04000345 RID: 837
		private int int_3 = 288;

		// Token: 0x04000346 RID: 838
		internal bool bool_5 = true;

		// Token: 0x04000347 RID: 839
		internal bool bool_6;

		// Token: 0x04000348 RID: 840
		private bool bool_7;

		// Token: 0x04000349 RID: 841
		internal static int int_4;

		// Token: 0x0400034A RID: 842
		internal static int int_5;

		// Token: 0x02000089 RID: 137
		[CompilerGenerated]
		private sealed class Class102
		{
			// Token: 0x060004D7 RID: 1239 RVA: 0x00004A98 File Offset: 0x00002C98
			internal void method_0()
			{
				Class101.smethod_65(this.int_0, false, false);
			}

			// Token: 0x0400034B RID: 843
			public int int_0;
		}

		// Token: 0x0200008A RID: 138
		[CompilerGenerated]
		private sealed class Class103
		{
			// Token: 0x060004D9 RID: 1241 RVA: 0x000950CC File Offset: 0x000932CC
			internal void method_0()
			{
				this.class58_0.gclass2_0.CharName = this.class58_0.class114_0.string_3;
				this.class58_0.gclass2_0.DatabaseID = this.class58_0.class114_0.int_11;
			}

			// Token: 0x060004DA RID: 1242 RVA: 0x00004AA7 File Offset: 0x00002CA7
			internal void method_1()
			{
				this.class58_0.class75_0.bool_17 = true;
				frmMain.frmMain_0.method_206(this.class58_0, false);
			}

			// Token: 0x0400034C RID: 844
			public Class58 class58_0;

			// Token: 0x0400034D RID: 845
			public MethodInvoker methodInvoker_0;

			// Token: 0x0400034E RID: 846
			public MethodInvoker methodInvoker_1;
		}

		// Token: 0x0200008B RID: 139
		[CompilerGenerated]
		private sealed class Class104
		{
			// Token: 0x060004DC RID: 1244 RVA: 0x0009511C File Offset: 0x0009331C
			internal void method_0()
			{
				this.class101_0.method_6(this.process_0, this.class58_0, this.int_1, this.intptr_0, this.uint_0, this.intptr_1, this.stringBuilder_0, this.string_0, this.class99_0.int_1, this.int_0);
			}

			// Token: 0x0400034F RID: 847
			public Process process_0;

			// Token: 0x04000350 RID: 848
			public int int_0;

			// Token: 0x04000351 RID: 849
			public Class58 class58_0;

			// Token: 0x04000352 RID: 850
			public int int_1;

			// Token: 0x04000353 RID: 851
			public IntPtr intptr_0;

			// Token: 0x04000354 RID: 852
			public uint uint_0;

			// Token: 0x04000355 RID: 853
			public IntPtr intptr_1;

			// Token: 0x04000356 RID: 854
			public StringBuilder stringBuilder_0;

			// Token: 0x04000357 RID: 855
			public string string_0;

			// Token: 0x04000358 RID: 856
			public Class99 class99_0;

			// Token: 0x04000359 RID: 857
			public Class101 class101_0;
		}

		// Token: 0x0200008C RID: 140
		[CompilerGenerated]
		private sealed class Class105
		{
			// Token: 0x060004DE RID: 1246 RVA: 0x00095178 File Offset: 0x00093378
			internal void method_0()
			{
				foreach (int processId in this.list_0)
				{
					try
					{
						Process processById = Process.GetProcessById(processId);
						if (processById != null)
						{
							processById.Kill();
						}
					}
					catch (Exception)
					{
					}
				}
			}

			// Token: 0x0400035A RID: 858
			public List<int> list_0;
		}
	}
}
