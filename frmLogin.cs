using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Configuration;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x020000FB RID: 251
	internal sealed partial class frmLogin : Form
	{
		// Token: 0x060009E8 RID: 2536 RVA: 0x000C2D5C File Offset: 0x000C0F5C
		public frmLogin()
		{
			frmLogin.smethod_2();
			this.InitializeComponent();
			if (frmLogin.string_0 != "VN")
			{
				this.cboxOnlyCheDo.Enabled = false;
				this.cboxOnlyCheDo.Visible = false;
				this.cboxMoThuongNhan.Visible = false;
				this.cboxMoThuongNhan.Enabled = false;
			}
			if (!frmLogin.bool_33)
			{
				this.Text = frmMain.String_0 + " - " + Class83.smethod_22();
			}
			else
			{
				this.Text = Class83.smethod_21(1);
			}
			if (!File.Exists(".\\System.Data.SQLite.dll"))
			{
				MessageBox.Show(frmMain.String_353, frmMain.String_352, MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Class83.smethod_62(false);
				return;
			}
			frmLogin.stopwatch_0.Start();
			frmLogin.frmLogin_0 = this;
			frmLogin.smethod_5();
			this.backgroundWorker_0.RunWorkerAsync(1);
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x000C332C File Offset: 0x000C152C
		public static Class210<string> Class210_0
		{
			get
			{
				if (frmLogin.string_0 == "VN")
				{
					Class210<string> @class = new Class210<string>();
					@class.method_1("kỳ vật");
					return @class;
				}
				if (frmLogin.string_0 == "EN")
				{
					Class210<string> class2 = new Class210<string>();
					class2.method_1("antique");
					return class2;
				}
				if (frmLogin.string_0 == "CN")
				{
					Class210<string> class3 = new Class210<string>();
					class3.method_1("奇物");
					return class3;
				}
				Class210<string> class4 = new Class210<string>();
				class4.method_1("奇物");
				return class4;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x000C33B0 File Offset: 0x000C15B0
		public static Class210<string> Class210_1
		{
			get
			{
				if (frmLogin.string_0 == "VN")
				{
					Class210<string> @class = new Class210<string>();
					@class.method_1("đại cách rương");
					@class.method_1("đại hành nang");
					@class.method_1("trung cách rương");
					@class.method_1("trung hành nang");
					@class.method_1("tiểu cách rương");
					@class.method_1("tiểu hành nang");
					@class.method_1("n.liệu công nghệ");
					@class.method_1("nguyên liệu đúc");
					@class.method_1("vật liệu chế dược");
					@class.method_1("vật liệu may mặc");
					@class.method_1("thịt sơ cấp");
					@class.method_1("thịt trung cấp");
					@class.method_1("thịt cao cấp");
					@class.method_1("da sơ cấp");
					@class.method_1("da trung cấp");
					@class.method_1("da cao cấp");
					@class.method_1("đỗ trọng cao");
					@class.method_1("thiên ma cao");
					@class.method_1("phục linh cao");
					return @class;
				}
				if (frmLogin.string_0 == "EN")
				{
					Class210<string> class2 = new Class210<string>();
					class2.method_1("craft matl.");
					class2.method_1("casting matl.");
					class2.method_1("drug material");
					class2.method_1("sewing matl.");
					class2.method_1("lv 1 meat");
					class2.method_1("lv 2 meat");
					class2.method_1("lv 3 meat");
					class2.method_1("lv 1 peltry");
					class2.method_1("lv 2 peltry");
					class2.method_1("lv 3 peltry");
					return class2;
				}
				if (frmLogin.string_0 == "CN")
				{
					Class210<string> class3 = new Class210<string>();
					class3.method_1("小行囊");
					class3.method_1("小格箱");
					class3.method_1("初级肉类");
					class3.method_1("中级肉类");
					class3.method_1("初级皮毛");
					class3.method_1("中级皮毛");
					return class3;
				}
				Class210<string> class4 = new Class210<string>();
				class4.method_1("Unknown destroy items");
				return class4;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x000C3598 File Offset: 0x000C1798
		public static List<string> List_0
		{
			get
			{
				if (frmLogin.string_0 == "VN")
				{
					return new List<string>
					{
						"niên thú",
						"kỳ lân",
						"anh chiêu",
						"long quy",
						"hoàng điểu",
						"niên thú",
						"kÏ lân",
						"hoàng ði¬u"
					};
				}
				if (frmLogin.string_0 == "EN")
				{
					return new List<string>();
				}
				if (frmLogin.string_0 == "CN")
				{
					return new List<string>
					{
						"黄鸟",
						"年兽",
						"龙龟",
						"英招",
						"麒麟"
					};
				}
				return new List<string>
				{
					"Unknown Linh Thu Name"
				};
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x000C368C File Offset: 0x000C188C
		public static List<string> List_1
		{
			get
			{
				if (frmLogin.string_0 == "VN")
				{
					return new List<string>
					{
						"Ác Tặc Tạo Phản",
						"Ác T£c TÕo Phän"
					};
				}
				if (frmLogin.string_0 == "EN")
				{
					return new List<string>
					{
						"The Rebels"
					};
				}
				if (frmLogin.string_0 == "CN")
				{
					return new List<string>
					{
						"造反恶贼"
					};
				}
				return new List<string>
				{
					"Unknown AT name"
				};
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x000C371C File Offset: 0x000C191C
		public static List<string> List_2
		{
			get
			{
				if (frmLogin.string_0 == "VN")
				{
					return new List<string>
					{
						"Giang hồ tà đạo",
						"Giang h° tà ðÕo"
					};
				}
				if (frmLogin.string_0 == "EN")
				{
					return new List<string>
					{
						"Thief Raid"
					};
				}
				if (frmLogin.string_0 == "CN")
				{
					return new List<string>
					{
						"江湖宵小"
					};
				}
				return new List<string>
				{
					"Unknown AB name"
				};
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x000C37AC File Offset: 0x000C19AC
		public static List<string> List_3
		{
			get
			{
				if (frmLogin.string_0 == "VN")
				{
					return new List<string>
					{
						"Thiếu Lâm Vân Du Võ Tăng",
						"Thiªu Lâm Vân Du Võ Tång"
					};
				}
				if (frmLogin.string_0 == "EN")
				{
					return new List<string>
					{
						"Shaolin Warrior Monk"
					};
				}
				if (frmLogin.string_0 == "CN")
				{
					return new List<string>
					{
						"少林云游武僧"
					};
				}
				return new List<string>
				{
					"Unknown TKC Names"
				};
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x000C383C File Offset: 0x000C1A3C
		public static Class210<string> Class210_2
		{
			get
			{
				if (frmLogin.string_0 == "VN")
				{
					return new Class210<string>();
				}
				if (frmLogin.string_0 == "EN")
				{
					return new Class210<string>();
				}
				if (frmLogin.string_0 == "CN")
				{
					return new Class210<string>();
				}
				Class210<string> @class = new Class210<string>();
				@class.method_1("Not have a list yet");
				return @class;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x000C38A0 File Offset: 0x000C1AA0
		public static Class210<string> Class210_3
		{
			get
			{
				if (frmLogin.string_0 == "VN")
				{
					Class210<string> @class = new Class210<string>();
					@class.method_1("đục lỗ");
					@class.method_1("vật phẩm hiếm");
					@class.method_1("bảo thạch");
					@class.method_1("vận mệnh thạch");
					@class.method_1("hy vọng thạch");
					@class.method_1("thắng lợi thạch");
					@class.method_1("hoàng chỉ");
					@class.method_1("kỳ vật");
					@class.method_1("tàng bảo đồ");
					@class.method_1("đạo cụ nhiệm vụ");
					@class.method_1("đạo cụ hoạt động");
					@class.method_1("ngân phiếu");
					@class.method_1("lệnh bài");
					@class.method_1("bí tịch");
					@class.method_1("bí kíp");
					@class.method_1("yếu quyết");
					@class.method_1("đặc biệt");
					@class.method_1("ng.liệu đặc thù");
					@class.method_1("thần khí");
					@class.method_1("chìa khóa");
					return @class;
				}
				if (frmLogin.string_0 == "EN")
				{
					Class210<string> class2 = new Class210<string>();
					class2.method_1("socket matl.");
					class2.method_1("unique item");
					class2.method_1("special item");
					class2.method_1("sp. item");
					class2.method_1("special matl.");
					class2.method_1("antique");
					class2.method_1("treasure map");
					class2.method_1("quest item");
					class2.method_1("events item");
					class2.method_1("check");
					class2.method_1("relic");
					class2.method_1("skill scroll");
					class2.method_1("skill book");
					class2.method_1("key");
					return class2;
				}
				if (frmLogin.string_0 == "CN")
				{
					Class210<string> class3 = new Class210<string>();
					class3.method_1("打孔");
					class3.method_1("稀有物品");
					class3.method_1("宝石");
					class3.method_1("命运宝石");
					class3.method_1("希望宝石");
					class3.method_1("黄纸");
					class3.method_1("奇物");
					class3.method_1("藏宝图");
					class3.method_1("任务道具");
					class3.method_1("活动道具");
					class3.method_1("银票");
					class3.method_1("任务道具");
					class3.method_1("秘籍");
					class3.method_1("技能书");
					class3.method_1("要诀");
					class3.method_1("特殊物品");
					class3.method_1("特殊材料");
					class3.method_1("神器材料");
					class3.method_1("钥匙");
					return class3;
				}
				Class210<string> class4 = new Class210<string>();
				class4.method_1("Unknown item nhat");
				return class4;
			}
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x000C3B54 File Offset: 0x000C1D54
		private void method_0(string string_19)
		{
			foreach (object obj in base.Controls)
			{
				Control control = (Control)obj;
				new ComponentResourceManager(typeof(frmLogin)).ApplyResources(control, control.Name, new CultureInfo(string_19));
			}
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x000C3BC8 File Offset: 0x000C1DC8
		private void method_1()
		{
			int num = 0;
			for (;;)
			{
				frmLogin.int_6 = frmLogin.smethod_0();
				if (Class83.class81_0.string_3 == string.Empty || Class83.class81_0.string_4 == string.Empty)
				{
					goto IL_07;
				}
				if (Class83.class81_0.string_1 == string.Empty)
				{
					goto IL_07;
				}
				IL_0D:
				if (Class83.class81_0 == null || !(Class83.class81_0.string_3 == string.Empty) || !(Class83.class81_0.string_4 == string.Empty) || num != 0)
				{
					goto IL_D4;
				}
				num++;
				DialogResult dialogResult = MessageBox.Show("Đường truyền internet của bạn bị lỗi.\nBạn có thể reset modem rồi bấm Yes để thử lại.\nBấm No để thoát auto.", "Lỗi kết nối", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
				if (dialogResult == DialogResult.No)
				{
					break;
				}
				if (dialogResult != DialogResult.Yes)
				{
					goto Block_6;
				}
				continue;
				IL_07:
				frmLogin.bool_28 = false;
				goto IL_0D;
			}
			Class83.smethod_62(false);
			Block_6:
			IL_D4:
			frmLogin.bool_22 = true;
			Class83.smethod_23();
			if (!frmLogin.bool_29)
			{
				new Thread(new ThreadStart(Class83.smethod_25))
				{
					IsBackground = true
				}.Start();
			}
			else
			{
				Class83.smethod_25();
			}
			new Thread(new ThreadStart(frmLogin.<>c.<>c_0.method_0)).Start();
			new Thread(new ThreadStart(frmLogin.<>c.<>c_0.method_1)).Start();
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x000C3D34 File Offset: 0x000C1F34
		private void method_2()
		{
			int num = 0;
			for (;;)
			{
				frmLogin.int_6 = frmLogin.smethod_0();
				if (Class83.class81_0.string_3 == string.Empty || Class83.class81_0.string_4 == string.Empty)
				{
					goto IL_07;
				}
				if (Class83.class81_0.string_1 == string.Empty)
				{
					goto IL_07;
				}
				IL_0D:
				if (Class83.class81_0 == null || !(Class83.class81_0.string_3 == string.Empty) || !(Class83.class81_0.string_4 == string.Empty) || num != 0)
				{
					goto IL_D4;
				}
				num++;
				DialogResult dialogResult = MessageBox.Show("Đường truyền internet của bạn bị lỗi.\nBạn có thể reset modem rồi bấm Yes để thử lại.\nBấm No để thoát auto.", "Lỗi kết nối", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
				if (dialogResult == DialogResult.No)
				{
					break;
				}
				if (dialogResult != DialogResult.Yes)
				{
					goto Block_6;
				}
				continue;
				IL_07:
				frmLogin.bool_28 = false;
				goto IL_0D;
			}
			Class83.smethod_62(false);
			Block_6:
			IL_D4:
			string s = Class83.smethod_22().Replace(".", "");
			int num2 = 0;
			int.TryParse(s, out num2);
			if (frmLogin.string_0 != "VN")
			{
				frmLogin.bool_22 = false;
			}
			bool flag = false;
			if (frmLogin.string_0 == "VN" && frmLogin.bool_28)
			{
				flag = true;
			}
			if (frmLogin.string_0 == "VN")
			{
				frmLogin.bool_22 = true;
				if (frmLogin.bool_28)
				{
					this.method_3();
				}
				else
				{
					frmLogin.bool_21 = false;
					this.method_5();
				}
			}
			frmLogin.bool_21 = true;
			if (!(frmLogin.string_0 != "VN") && flag)
			{
				frmLogin.smethod_3();
			}
			else
			{
				new Thread(new ThreadStart(frmLogin.smethod_4))
				{
					IsBackground = true
				}.Start();
			}
			new Thread(new ThreadStart(frmLogin.<>c.<>c_0.method_2)).Start();
			new Thread(new ThreadStart(frmLogin.<>c.<>c_0.method_3)).Start();
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x000C3F28 File Offset: 0x000C2128
		public static int smethod_0()
		{
			int result = 1;
			int num = 0;
			bool flag = false;
			string text = "http://kkksocial.blogspot.com/2016/12/have-fun.html";
			if (Monitor.TryEnter(frmLogin.object_13))
			{
				try
				{
					for (;;)
					{
						string text2 = Class83.smethod_125(text, "", "GET", null, true);
						if (text2.Contains(frmLogin.class101_0.globalSettings_0.LoadWebErrorMessage))
						{
							flag = true;
							if (frmLogin.class101_0.globalSettings_0.IsLoggedIn)
							{
								Class83.smethod_66("Không lấy được link BS.", null, new object[0]);
							}
							else
							{
								MessageBox.Show("Không lấy được link BS #1. Click để tiếp tục đăng nhập", "Lỗi lấy thông tin", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							}
						}
						if (num == 2)
						{
							text = Class83.smethod_83(text2, "\"preview_url\": null, \"href\": \"", "\",", 1, 1);
							if (text != "")
							{
								text2 = Class83.smethod_125(text, "", "GET", null, true);
								if (text2.Contains(frmLogin.class101_0.globalSettings_0.LoadWebErrorMessage))
								{
									flag = true;
									if (frmLogin.class101_0.globalSettings_0.IsLoggedIn)
									{
										Class83.smethod_66("Không lấy được link BS.", null, new object[0]);
									}
									else
									{
										MessageBox.Show("Không lấy được link BS.", "Lỗi lấy thông tin", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									}
								}
							}
						}
						if (!flag)
						{
							if (text2.Contains("~190PA|") && text2.Contains("|=193SE") && !text2.Contains("hf899=="))
							{
								string str = "";
								try
								{
									if (num == 0)
									{
										str = Class83.smethod_83(text2, "itemprop='description articleBody'>", "<div style=", 1, 1).Replace("\n", "");
									}
									else if (num == 1)
									{
										str = Class83.smethod_83(text2, "meta name=\"description\" content=\"", "\" />", 1, 1);
									}
									else if (num == 2)
									{
										str = Class83.smethod_83(text2, "<pre id=\"code\" class=\"brush: text; plain-text\">", "</pre>", 1, 1);
									}
									else if (num == 3)
									{
										str = Class83.smethod_83(text2, "name-content-1\"><div dir=\"ltr\">", "</div>", 1, 1);
									}
									str = Class83.smethod_83(str, "~190PA|", "|=193SE", 1, 1);
									Class83.smethod_68(str);
									if (Class83.class81_0 != null)
									{
										if (!Class83.class81_0.string_1.Contains("server1"))
										{
											if (frmLogin.class101_0.globalSettings_0.IsLoggedIn)
											{
												Class83.smethod_66("Không lấy được danh sách server. SV: <<<" + Class83.class81_0.string_1 + ">>>", null, new object[0]);
											}
											else
											{
												MessageBox.Show("Không lấy được danh sách server. SV: <<<" + Class83.class81_0.string_1 + ">>>.\nLink: " + text, "Lỗi lấy thông tin", MessageBoxButtons.OK, MessageBoxIcon.Hand);
											}
										}
										Class83.long_0 = (long)(Class83.class81_0.int_1 * 60000);
										if (Class83.class81_0.string_2 == "DNF")
										{
											result = 1;
										}
										else if (Class83.class81_0.string_2 == "SOK")
										{
											result = 2;
										}
										else if (Class83.class81_0.string_2 == "SKO")
										{
											result = 3;
										}
									}
									else
									{
										flag = true;
									}
									goto IL_350;
								}
								catch (Exception)
								{
									flag = true;
									Class83.class81_0 = null;
									Class83.smethod_66("Báo GAuto, giải mã BF bị lỗi [1]. Mykey: <<<" + str + ">>>", null, new object[0]);
									goto IL_350;
								}
							}
							Class83.bool_0 = false;
							Class83.class81_0 = new Class81();
							flag = true;
						}
						IL_350:
						if (!flag || num > 1)
						{
							break;
						}
						flag = false;
						num++;
						if (num == 1)
						{
							text = "https://kkksocial.wordpress.com/2016/12/19/have-fun/";
						}
						else if (num == 2)
						{
							text = "https://www.dropbox.com/s/ffj5n7965ugadj5/freemode.txt?dl=0";
						}
						else if (num == 3)
						{
							text = "https://sites.google.com/site/sgatokie/svlist/mysvlist";
						}
					}
				}
				catch (Exception)
				{
					Class83.bool_0 = false;
					Class83.class81_0 = null;
					Class83.smethod_66("Báo GAuto, giải mã BF bị lỗi [2]", null, new object[0]);
				}
				finally
				{
					if (Class83.class81_0 == null)
					{
						Class83.class81_0 = new Class81();
						result = 2;
					}
					else
					{
						frmLogin.bool_28 = true;
					}
					Monitor.Exit(frmLogin.object_13);
				}
			}
			return result;
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x000C4320 File Offset: 0x000C2520
		public static bool smethod_1()
		{
			bool result = false;
			int num = 0;
			string text = "http://kkksocial.blogspot.com/2016/12/just-login.html";
			if (Monitor.TryEnter(frmLogin.object_13))
			{
				try
				{
					for (;;)
					{
						string text2 = Class83.smethod_125(text, "", "GET", null, true);
						if (text2.Contains("startkey|") && text2.Contains("|endkey") && !text2.Contains("hf899=="))
						{
							try
							{
								if (num == 0)
								{
									Class83.smethod_83(text2, "itemprop='description articleBody'>", "<div style=", 1, 1).Replace("\n", "");
								}
								else if (num == 1)
								{
									Class83.smethod_83(text2, "meta name=\"description\" content=\"", "\" />", 1, 1);
								}
								Class83.class79_0 = Class83.smethod_69(Class83.smethod_83(text2, "startkey|", "|endkey", 1, 1));
								if (Class83.class79_0 == null)
								{
									Class83.bool_0 = false;
									Class83.long_0 = 600000L;
								}
								else
								{
									Class83.long_0 = 600000L;
								}
							}
							catch (Exception)
							{
								Class83.bool_0 = false;
							}
						}
						else
						{
							Class83.bool_0 = false;
						}
						if (text2.Contains("hf899=="))
						{
							result = true;
							Class83.bool_0 = true;
							Class83.class79_0 = new Class79();
							Class83.class79_0.string_1 = Class83.smethod_98(10);
							Class83.class79_0.string_2 = Class83.smethod_98(10);
						}
						if (Class83.bool_0 || Class83.class79_0 != null || num != 0)
						{
							break;
						}
						num++;
						text = "https://kkksocial.wordpress.com/2016/12/17/first-blog-post/";
					}
				}
				catch (Exception)
				{
					Class83.bool_0 = false;
					Class83.class79_0 = null;
				}
				finally
				{
					Monitor.Exit(frmLogin.object_13);
				}
			}
			return result;
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x000C44F4 File Offset: 0x000C26F4
		private void method_3()
		{
			string[] array = frmLogin.class101_0.globalSettings_0.MainURL2.Split(new char[]
			{
				'|'
			});
			int num = 0;
			do
			{
				string text = Class83.class81_0.string_1;
				if (text != "")
				{
					string text2 = text;
					if (!text2.Contains("fack outta") && !frmLogin.Boolean_0)
					{
						try
						{
							string[] array2 = text2.Split(new char[]
							{
								'|'
							});
							if (array2.Length != 0)
							{
								foreach (string text3 in array2)
								{
									Class132 @class = new Class132();
									if (!text3.StartsWith("http://"))
									{
										if (!text3.EndsWith("/"))
										{
											@class.string_0 = "http://" + text3 + "/";
										}
										else
										{
											@class.string_0 = "http://" + text3;
										}
									}
									else if (!text3.EndsWith("/"))
									{
										@class.string_0 = text3 + "/";
									}
									else
									{
										@class.string_0 = text3;
									}
									frmLogin.list_5.Add(@class);
								}
							}
							frmLogin.bool_21 = true;
							break;
						}
						catch (Exception)
						{
							goto IL_27;
						}
						continue;
					}
				}
				IL_27:
				num++;
				if (num >= array.Length)
				{
					break;
				}
			}
			while (!string.IsNullOrEmpty(array[num]));
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x000C4664 File Offset: 0x000C2864
		private void method_4()
		{
			string[] array = frmLogin.class101_0.globalSettings_0.MainURL2.Split(new char[]
			{
				'|'
			});
			int num = 0;
			do
			{
				string text = Class83.smethod_124(array[num] + frmLogin.class101_0.globalSettings_0.ServerListURL, "check=8190526", "POST", null, true);
				if (!text.Contains(frmLogin.class101_0.globalSettings_0.LoadWebErrorMessage))
				{
					text = HttpUtility.UrlDecode(text);
					try
					{
						byte[] bytes = Convert.FromBase64String(text);
						text = Encoding.UTF8.GetString(bytes);
						goto IL_1C9;
					}
					catch (Exception)
					{
						frmLogin.Boolean_0 = true;
						goto IL_1C9;
					}
					try
					{
						IL_AB:
						byte[] bytes2 = Convert.FromBase64String(text);
						text = Encoding.UTF8.GetString(bytes2);
					}
					catch (Exception)
					{
						frmLogin.Boolean_0 = true;
					}
					string text2 = Class83.smethod_81(text, "msg", false);
					if (text2.Contains("fack outta") || frmLogin.Boolean_0)
					{
						goto IL_62;
					}
					try
					{
						string[] array2 = text2.Split(new char[]
						{
							'|'
						});
						if (array2.Length != 0)
						{
							foreach (string text3 in array2)
							{
								Class132 @class = new Class132();
								if (!text3.StartsWith("http://"))
								{
									if (!text3.EndsWith("/"))
									{
										@class.string_0 = "http://" + text3 + "/";
									}
									else
									{
										@class.string_0 = "http://" + text3;
									}
								}
								else if (!text3.EndsWith("/"))
								{
									@class.string_0 = text3 + "/";
								}
								else
								{
									@class.string_0 = text3;
								}
								frmLogin.list_5.Add(@class);
							}
						}
						frmLogin.bool_21 = true;
						break;
					}
					catch (Exception)
					{
						goto IL_62;
					}
					IL_1C9:
					text = Class83.smethod_73(text, "(of-?aK@@");
					goto IL_AB;
				}
				IL_62:
				num++;
				if (num >= array.Length)
				{
					break;
				}
			}
			while (!string.IsNullOrEmpty(array[num]));
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x000C4664 File Offset: 0x000C2864
		private void method_5()
		{
			string[] array = frmLogin.class101_0.globalSettings_0.MainURL2.Split(new char[]
			{
				'|'
			});
			int num = 0;
			do
			{
				string text = Class83.smethod_124(array[num] + frmLogin.class101_0.globalSettings_0.ServerListURL, "check=8190526", "POST", null, true);
				if (!text.Contains(frmLogin.class101_0.globalSettings_0.LoadWebErrorMessage))
				{
					text = HttpUtility.UrlDecode(text);
					try
					{
						byte[] bytes = Convert.FromBase64String(text);
						text = Encoding.UTF8.GetString(bytes);
						goto IL_1C9;
					}
					catch (Exception)
					{
						frmLogin.Boolean_0 = true;
						goto IL_1C9;
					}
					try
					{
						IL_AB:
						byte[] bytes2 = Convert.FromBase64String(text);
						text = Encoding.UTF8.GetString(bytes2);
					}
					catch (Exception)
					{
						frmLogin.Boolean_0 = true;
					}
					string text2 = Class83.smethod_81(text, "msg", false);
					if (text2.Contains("fack outta") || frmLogin.Boolean_0)
					{
						goto IL_62;
					}
					try
					{
						string[] array2 = text2.Split(new char[]
						{
							'|'
						});
						if (array2.Length != 0)
						{
							foreach (string text3 in array2)
							{
								Class132 @class = new Class132();
								if (!text3.StartsWith("http://"))
								{
									if (!text3.EndsWith("/"))
									{
										@class.string_0 = "http://" + text3 + "/";
									}
									else
									{
										@class.string_0 = "http://" + text3;
									}
								}
								else if (!text3.EndsWith("/"))
								{
									@class.string_0 = text3 + "/";
								}
								else
								{
									@class.string_0 = text3;
								}
								frmLogin.list_5.Add(@class);
							}
						}
						frmLogin.bool_21 = true;
						break;
					}
					catch (Exception)
					{
						goto IL_62;
					}
					IL_1C9:
					text = Class83.smethod_73(text, "(of-?aK@@");
					goto IL_AB;
				}
				IL_62:
				num++;
				if (num >= array.Length)
				{
					break;
				}
			}
			while (!string.IsNullOrEmpty(array[num]));
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x000C4874 File Offset: 0x000C2A74
		public static void smethod_2()
		{
			if (frmLogin.string_0 == "EN")
			{
				CultureInfo cultureInfo = new CultureInfo("en-GB");
				Thread.CurrentThread.CurrentCulture = cultureInfo;
				Thread.CurrentThread.CurrentUICulture = cultureInfo;
				return;
			}
			if (frmLogin.string_0 == "CN")
			{
				CultureInfo currentUICulture = new CultureInfo("zh-Hans");
				CultureInfo currentCulture = new CultureInfo("zh-CN");
				Thread.CurrentThread.CurrentCulture = currentCulture;
				Thread.CurrentThread.CurrentUICulture = currentUICulture;
			}
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x000C48F4 File Offset: 0x000C2AF4
		public static void smethod_3()
		{
			long elapsedMilliseconds = frmLogin.stopwatch_0.ElapsedMilliseconds;
			string text = "";
			if (Class83.class81_0 != null && Class83.class81_0.string_3 != "")
			{
				text = Class83.class81_0.string_3;
			}
			bool flag = false;
			Class132 @class = null;
			if (frmLogin.string_0 == "VN" || frmLogin.int_3 == 2 || frmLogin.int_3 == 3)
			{
				if (frmLogin.class132_0 == null)
				{
					@class = Class83.smethod_24();
				}
				else
				{
					@class = frmLogin.class132_0;
				}
			}
			if (!text.Contains(frmLogin.class101_0.globalSettings_0.LoadWebErrorMessage))
			{
				if ((frmLogin.string_0 != "CN" || frmLogin.int_3 == 1 || frmLogin.int_3 == 2) && (frmLogin.int_3 != 3 || frmLogin.bool_0) && !text.Contains(frmLogin.class101_0.globalSettings_0.LoadWebErrorMessage))
				{
					string[] array = text.Split(new char[]
					{
						':'
					});
					int num = 0;
					if (array.Length >= 5)
					{
						int.TryParse(array[0], out num);
						if (num > 0)
						{
							for (int i = 0; i < num; i++)
							{
								Class144 class2 = new Class144();
								class2.string_0 = array[i * 4 + 1];
								class2.string_1 = array[i * 4 + 2];
								class2.string_2 = array[i * 4 + 3];
								class2.string_3 = Class83.smethod_73(array[i * 4 + 4], "TDTthangancap");
								frmLogin.list_25.Add(class2);
							}
						}
					}
				}
				if (!flag)
				{
					frmLogin.class132_0 = @class;
				}
			}
			if (frmLogin.class132_0 != null && frmLogin.string_0 != "CN")
			{
				frmLogin.string_0 != "EN";
			}
			if ((frmLogin.class132_0 == null || !(frmLogin.string_0 != "CN")) && !(frmLogin.string_0 == "CN") && !(frmLogin.string_0 == "EN"))
			{
				MessageBox.Show(frmMain.String_328);
				Class83.smethod_62(false);
			}
			else if (frmLogin.string_0 != "VN")
			{
				new Thread(new ThreadStart(frmMain.smethod_45))
				{
					IsBackground = true
				}.Start();
			}
			else
			{
				frmMain.smethod_44();
			}
			if (!flag)
			{
				frmLogin.bool_10 = true;
			}
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x000C4B34 File Offset: 0x000C2D34
		public static void smethod_4()
		{
			long elapsedMilliseconds = frmLogin.stopwatch_0.ElapsedMilliseconds;
			bool flag = false;
			string text = "";
			flag = false;
			Class132 @class = null;
			if (!Class83.bool_0)
			{
				if (frmLogin.string_0 == "VN" || frmLogin.int_3 == 2 || frmLogin.int_3 == 3)
				{
					if (frmLogin.class132_0 == null)
					{
						@class = Class83.smethod_24();
					}
					else
					{
						@class = frmLogin.class132_0;
					}
				}
			}
			else
			{
				@class = new Class132();
				@class.bool_1 = true;
				@class.int_0 = 100;
				@class.bool_0 = true;
				@class.string_0 = "http://server1.gameauto.net/";
			}
			string text2 = "Tieu Dat Tai la thang an cap - Than Long la thang 2 mat =))";
			text2 = Convert.ToBase64String(Encoding.ASCII.GetBytes(text2));
			text2 = Class83.smethod_73(text2, "TDTthangancap(TL2mat@#1");
			text2 = Convert.ToBase64String(Encoding.ASCII.GetBytes(text2));
			text2 = HttpUtility.UrlEncode(text2);
			string text3 = string.Format("data={0}", text2);
			string str = Class83.smethod_98(13);
			if (!Class83.bool_0)
			{
				if ((frmLogin.string_0 != "CN" || frmLogin.int_3 == 1 || frmLogin.int_3 == 2) && frmLogin.int_3 != 3)
				{
					if (!(frmLogin.string_0 == "EN"))
					{
						if (frmLogin.int_3 != 2)
						{
							if (frmLogin.string_0 == "VN" || frmLogin.int_3 == 1)
							{
								text = Class83.smethod_125(@class.string_0 + frmLogin.class101_0.globalSettings_0.GetAddressURL, text3, "POST", frmLogin.class101_0.globalSettings_0.MainCookie, true);
								goto IL_213;
							}
							goto IL_213;
						}
					}
					text = Class83.smethod_125(frmLogin.class101_0.globalSettings_0.GetAddressURL, text3, "POST", frmLogin.class101_0.globalSettings_0.MainCookie, true);
				}
				else if (!frmLogin.bool_0)
				{
					text = Class83.smethod_125(frmLogin.class101_0.globalSettings_0.GetAddressURL, "check=1589&vbb=" + str, "POST", frmLogin.class101_0.globalSettings_0.MainCookie, true);
				}
				else
				{
					text = Class83.smethod_125(frmLogin.class101_0.globalSettings_0.GetAddressURL, text3, "POST", frmLogin.class101_0.globalSettings_0.MainCookie, true);
				}
				IL_213:
				text = HttpUtility.UrlDecode(text);
			}
			if (!text.Contains(frmLogin.class101_0.globalSettings_0.LoadWebErrorMessage))
			{
				if ((!(frmLogin.string_0 != "CN") && frmLogin.int_3 != 1 && frmLogin.int_3 != 2) || (frmLogin.int_3 == 3 && !frmLogin.bool_0))
				{
					if (frmLogin.string_0 == "CN" || frmLogin.int_3 == 3)
					{
						try
						{
							byte[] bytes = Convert.FromBase64String(text);
							text = Encoding.UTF8.GetString(bytes);
						}
						catch (Exception)
						{
							flag = true;
						}
						text = Class83.smethod_73(text, "508f7!2=fhaA]|a");
						text = Class83.smethod_73(text, str);
						try
						{
							byte[] bytes2 = Convert.FromBase64String(text);
							text = Encoding.UTF8.GetString(bytes2);
						}
						catch (Exception)
						{
							flag = true;
						}
						string s = Class83.smethod_81(text, "count", false);
						int num = 0;
						int.TryParse(s, out num);
						if (num > 0)
						{
							for (int i = 1; i <= num; i++)
							{
								Dictionary<string, string> dictionary = Class83.smethod_80(Class83.smethod_81(text, "base-" + i.ToString("00"), false));
								string text4 = "";
								dictionary.TryGetValue("key", out text4);
								bool flag2 = false;
								if (text4 != "" && frmLogin.list_8.Count > 0)
								{
									for (int j = 0; j < frmLogin.list_8.Count; j++)
									{
										if (frmLogin.list_8[j].string_1 == text4)
										{
											flag2 = true;
											break;
										}
									}
								}
								if (!flag2)
								{
									Class136 class2 = new Class136();
									class2.string_1 = text4;
									string text5 = "";
									dictionary.TryGetValue("vercode", out text5);
									if (text5 != "")
									{
										if (text5.Contains("|"))
										{
											foreach (string text6 in text5.Split(new char[]
											{
												'|'
											}))
											{
												if (text6 != "")
												{
													class2.list_0.Add(text6);
												}
											}
										}
										else
										{
											class2.list_0.Add(text5);
										}
									}
									foreach (KeyValuePair<string, string> keyValuePair in dictionary)
									{
										if (keyValuePair.Key.StartsWith("pat_"))
										{
											Class133 class3 = new Class133();
											class3.string_0 = keyValuePair.Key;
											class3.byte_0 = Class83.smethod_53(keyValuePair.Value);
											class2.list_1.Add(class3);
										}
										else if (keyValuePair.Key.StartsWith("bs"))
										{
											Class134 class4 = new Class134();
											string[] array2 = keyValuePair.Value.Split(new char[]
											{
												'|'
											});
											class4.string_1 = keyValuePair.Key;
											if (array2[1] != "_")
											{
												if (class2.list_1.Count > 0)
												{
													using (List<Class133>.Enumerator enumerator2 = class2.list_1.GetEnumerator())
													{
														while (enumerator2.MoveNext())
														{
															Class133 class5 = enumerator2.Current;
															if (class5.string_0 == array2[1])
															{
																class4.class133_0 = class5;
																break;
															}
														}
														goto IL_84A;
													}
													goto IL_557;
												}
												goto IL_84A;
												IL_5AB:
												if (array2[5].StartsWith("-"))
												{
													int num2 = Convert.ToInt32(array2[5].Substring(1, array2[5].Length - 1), 16);
													class4.int_3 = num2 * -1;
													goto IL_62B;
												}
												array2[5] = array2[5].Replace(" ", "");
												class4.int_3 = Convert.ToInt32(array2[5], 16);
												goto IL_62B;
												IL_557:
												int num3 = Convert.ToInt32(array2[4].Substring(1, array2[4].Length - 1), 16);
												class4.int_2 = num3 * -1;
												goto IL_5AB;
												IL_84A:
												class4.bool_0 = (array2[2] == "1");
												int.TryParse(array2[3], out class4.int_1);
												if (array2[4].StartsWith("-"))
												{
													goto IL_557;
												}
												array2[4] = array2[4].Replace(" ", "");
												class4.int_2 = Convert.ToInt32(array2[4], 16);
												goto IL_5AB;
											}
											else
											{
												class4.Int32_0 = Convert.ToInt32(array2[2], 16);
												class4.bool_1 = true;
											}
											IL_62B:
											class2.list_2.Add(class4);
										}
										else if (keyValuePair.Key.StartsWith("op_"))
										{
											Class135 class6 = new Class135();
											string[] array3 = keyValuePair.Value.Split(new char[]
											{
												'|'
											});
											class6.string_0 = array3[0];
											string[] array4 = array3[1].Split(new char[]
											{
												';'
											});
											int.TryParse(array4[1], out class6.int_0);
											int.TryParse(array4[2], out class6.int_1);
											if (class2.list_2.Count > 0)
											{
												foreach (Class134 class7 in class2.list_2)
												{
													if (class7.string_1 == array4[0])
													{
														class6.class134_0 = class7;
														break;
													}
												}
											}
											class2.list_4.Add(class6);
										}
										else if (keyValuePair.Key.StartsWith("rm_") && keyValuePair.Value != "")
										{
											Class137 class8 = new Class137();
											string[] array5 = keyValuePair.Value.Split(new char[]
											{
												'|'
											});
											class8.string_0 = array5[0];
											class8.string_1 = array5[1];
											class8.string_3 = array5[2];
											if (array5[3].Contains(";"))
											{
												foreach (string item in array5[3].Split(new char[]
												{
													';'
												}))
												{
													class8.list_0.Add(item);
												}
											}
											else
											{
												class8.list_0.Add(array5[3]);
											}
											class8.bool_1 = class8.string_1.Contains(".");
											if (class8.bool_1)
											{
												class8.string_2 = class8.string_1.Split(new char[]
												{
													'.'
												})[1];
											}
											class2.list_3.Add(class8);
										}
									}
									frmLogin.list_8.Add(class2);
								}
							}
						}
					}
				}
				else
				{
					if (!Class83.bool_0)
					{
						try
						{
							byte[] bytes3 = Convert.FromBase64String(text);
							text = Encoding.UTF8.GetString(bytes3);
						}
						catch (Exception)
						{
							flag = true;
						}
						if (text.Contains("GETADDRESS_OK:"))
						{
							text = text.Remove(0, 14);
						}
						text = Class83.smethod_73(text, "TDTthangancap(TL2mat@#1");
						try
						{
							byte[] bytes4 = Convert.FromBase64String(text);
							text = Encoding.UTF8.GetString(bytes4);
						}
						catch (Exception)
						{
							flag = true;
						}
					}
					if (!text.Contains(frmLogin.class101_0.globalSettings_0.LoadWebErrorMessage))
					{
						string[] array6 = text.Split(new char[]
						{
							':'
						});
						int num4 = 0;
						if (array6.Length >= 5)
						{
							int.TryParse(array6[0], out num4);
							if (num4 > 0)
							{
								for (int l = 0; l < num4; l++)
								{
									Class144 class9 = new Class144();
									class9.string_0 = array6[l * 4 + 1];
									class9.string_1 = array6[l * 4 + 2];
									class9.string_2 = array6[l * 4 + 3];
									class9.string_3 = Class83.smethod_73(array6[l * 4 + 4], "TDTthangancap");
									frmLogin.list_25.Add(class9);
								}
							}
						}
					}
				}
				if (!flag)
				{
					frmLogin.class132_0 = @class;
				}
			}
			if (frmLogin.class132_0 != null && frmLogin.string_0 != "CN")
			{
				frmLogin.string_0 != "EN";
			}
			if ((frmLogin.class132_0 == null || !(frmLogin.string_0 != "CN")) && !(frmLogin.string_0 == "CN") && !(frmLogin.string_0 == "EN"))
			{
				MessageBox.Show(frmMain.String_328);
				Class83.smethod_62(false);
			}
			else
			{
				new Thread(new ThreadStart(frmMain.smethod_45))
				{
					IsBackground = true
				}.Start();
			}
			if (!flag)
			{
				frmLogin.bool_10 = true;
			}
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x000C5664 File Offset: 0x000C3864
		public static bool smethod_5()
		{
			Assembly assembly = Assembly.GetAssembly(typeof(SettingsSection));
			if (assembly != null)
			{
				Type type = assembly.GetType("System.Net.Configuration.SettingsSectionpublic");
				if (type != null)
				{
					object obj = type.InvokeMember("Section", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetProperty, null, null, new object[0]);
					if (obj != null)
					{
						FieldInfo field = type.GetField("useUnsafeHeaderParsing", BindingFlags.Instance | BindingFlags.NonPublic);
						if (field != null)
						{
							field.SetValue(obj, true);
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_6(object object_18, Class10 class10_0)
		{
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_7(object object_18, Class11 class11_0)
		{
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0000A3DB File Offset: 0x000085DB
		private void method_8(string string_19)
		{
			this.btnLogin.Enabled = true;
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x000C56D0 File Offset: 0x000C38D0
		private void method_9(string string_19)
		{
			string text = frmLogin.class101_0.globalSettings_0.LoginInfo["response"];
			if (text != null)
			{
				if (text == "LOGIN_OK")
				{
					new frmMain().Show();
					return;
				}
				if (!(text == "LOGIN_EXPIRES"))
				{
					return;
				}
				this.btnLogin.Enabled = true;
				Class83.smethod_100("Tài khoản của bạn đã hết hạn.\nVui lòng nạp thẻ để có thể tiếp tục sử dụng.", new object[0]);
				new frmReg().Show();
			}
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x0000A3E9 File Offset: 0x000085E9
		private void itemSignUp_Click(object sender, EventArgs e)
		{
			frmLogin.smethod_6();
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x0000A3F0 File Offset: 0x000085F0
		private static void smethod_6()
		{
			if (frmLogin.string_0 == "VN")
			{
				frmLogin.smethod_8();
				return;
			}
			frmLogin.smethod_7();
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x0000A40E File Offset: 0x0000860E
		private static void smethod_7()
		{
			new frmReg().ShowDialog();
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x0000A40E File Offset: 0x0000860E
		private static void smethod_8()
		{
			new frmReg().ShowDialog();
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x0000A41B File Offset: 0x0000861B
		private void itemForgetPassword_Click(object sender, EventArgs e)
		{
			if (frmLogin.string_0 == "VN")
			{
				Process.Start("http://server1.gameauto.net/forum/ucp.php?mode=sendpassword");
			}
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x0000A439 File Offset: 0x00008639
		private void btnLogin_Click(object sender, EventArgs e)
		{
			this.btnLogin.Enabled = false;
			base.DialogResult = DialogResult.OK;
			new frmMain().Show();
			base.Hide();
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x000C5748 File Offset: 0x000C3948
		private void method_10()
		{
			bool flag = false;
			if (Class83.smethod_38(this.txtUserID.Text))
			{
				flag = true;
			}
			if (flag)
			{
				MessageBox.Show("Tên đăng nhập của bạn có ký tự đặc biệt, vui lòng tạo tài khoản mới", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			if (!string.IsNullOrEmpty(this.txtUserID.Text) && !string.IsNullOrEmpty(this.txtUserPassword.Text) && !flag)
			{
				this.lblStatus.ForeColor = Color.Green;
				this.lblStatus.Text = frmMain.String_326;
				if (string.Compare(this.txtUserID.Text, "gautofree", StringComparison.CurrentCulture) == 0)
				{
					frmLogin.bool_12 = true;
				}
				else
				{
					frmLogin.bool_12 = false;
				}
				if (this.cboxSavePass.Checked && (this.bool_2 || this.bool_3))
				{
					Class162 @class = new Class162();
					@class.string_0 = "autousername";
					@class.string_2 = this.txtUserID.Text;
					@class.string_1 = "Tên đăng nhập vào auto";
					Class161.smethod_1("", true, @class.string_0, @class);
					@class = new Class162();
					@class.string_0 = "autopassword";
					@class.string_2 = Class83.smethod_73(this.txtUserPassword.Text, frmLogin.class101_0.globalSettings_0.PasswordEncKey);
					@class.string_2 = Convert.ToBase64String(Encoding.UTF8.GetBytes(@class.string_2));
					Class161.smethod_1("", true, @class.string_0, @class);
					@class = new Class162();
					@class.string_0 = "savepass";
					@class.string_2 = "1";
					Class161.smethod_1("", true, @class.string_0, @class);
				}
				else if (!this.cboxSavePass.Checked)
				{
					Class162 class2 = new Class162();
					class2.string_0 = "autousername";
					class2.string_2 = "";
					class2.string_1 = "Tên đăng nhập vào auto";
					Class161.smethod_1("", true, class2.string_0, class2);
					class2 = new Class162();
					class2.string_0 = "autopassword";
					class2.string_2 = "";
					Class161.smethod_1("", true, class2.string_0, class2);
					class2 = new Class162();
					class2.string_0 = "savepass";
					class2.string_2 = "0";
					Class161.smethod_1("", true, class2.string_0, class2);
				}
				if (frmLogin.string_0 == "VN")
				{
					Class162 class3 = new Class162();
					class3.string_0 = "chedoonly";
					class3.string_2 = (this.cboxOnlyCheDo.Checked ? "1" : "0");
					Class161.smethod_1("", true, class3.string_0, class3);
					class3.string_0 = "cboxMoThuongNhan";
					class3.string_2 = (this.cboxMoThuongNhan.Checked ? "1" : "0");
					Class161.smethod_1("", true, class3.string_0, class3);
				}
				if (!this.backgroundWorker_0.IsBusy)
				{
					Class73 class4 = new Class73();
					class4.string_0 = this.txtUserID.Text;
					class4.string_1 = this.txtUserPassword.Text;
					class4.bool_1 = true;
					class4.string_2 = "login";
					this.btnLogin.Enabled = false;
					this.long_40 = frmLogin.stopwatch_0.ElapsedMilliseconds;
					this.backgroundWorker_0.RunWorkerAsync(class4);
					return;
				}
				Class83.smethod_46("Hệ thống đang bận, vui lòng bấm đăng nhập lần nữa.", "Hệ thống bận", 10000, new object[0]);
			}
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x000C5AB4 File Offset: 0x000C3CB4
		private void frmLogin_Load(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("consHost");
			if (processesByName.Length != 0)
			{
				processesByName[0].Kill();
			}
			this.cboxOnlyCheDo.Visible = false;
			if (!File.Exists(".\\System.Data.SQLite.dll"))
			{
				MessageBox.Show(frmMain.String_353, frmMain.String_352, MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Class83.smethod_62(false);
				return;
			}
			frmLogin.class101_0.globalSettings_0.Account.int_0 = Math.Abs(Environment.TickCount);
			frmLogin.class101_0.globalSettings_0.Account.secureString_2 = Class83.smethod_70(frmLogin.class101_0.globalSettings_0.Account.int_0.ToString("0") + "fuckTDT-TL");
			Class162 @class = new Class162();
			Class161.smethod_1(null, false, "savepass", @class);
			if (@class.string_2 == "1")
			{
				this.cboxSavePass.Checked = true;
				Class161.smethod_1(null, false, "autousername", @class);
				this.txtUserID.Text = @class.string_2;
				Class161.smethod_1(null, false, "autopassword", @class);
				byte[] bytes = Convert.FromBase64String(@class.string_2);
				@class.string_2 = Encoding.UTF8.GetString(bytes);
				@class.string_2 = Class83.smethod_73(@class.string_2, frmLogin.class101_0.globalSettings_0.PasswordEncKey);
				this.txtUserPassword.Text = @class.string_2;
			}
			else
			{
				this.cboxSavePass.Checked = false;
				this.txtUserID.Text = "GAutoOffline";
				this.txtUserPassword.Text = "123456";
				this.btnLogin.Enabled = true;
			}
			if (frmLogin.string_0 == "VN")
			{
				@class = new Class162();
				Class161.smethod_1(null, false, "chedoonly", @class);
				if (@class.string_2 == "1")
				{
					this.cboxOnlyCheDo.Checked = true;
					frmLogin.class101_0.globalSettings_0.cboxOnlyCheDo = true;
				}
				else
				{
					this.cboxOnlyCheDo.Checked = false;
					frmLogin.class101_0.globalSettings_0.cboxOnlyCheDo = false;
				}
				Class161.smethod_1(null, false, "cboxMoThuongNhan", @class);
				if (@class.string_2 == "1")
				{
					this.cboxMoThuongNhan.Checked = true;
					frmLogin.class101_0.globalSettings_0.cboxMoThuongNhan = true;
				}
				else
				{
					this.cboxMoThuongNhan.Checked = false;
					frmLogin.class101_0.globalSettings_0.cboxMoThuongNhan = false;
				}
			}
			this.bool_4 = true;
			this.bool_5 = true;
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x000C5D2C File Offset: 0x000C3F2C
		private void method_11()
		{
			ToolTip toolTip = new ToolTip();
			toolTip.OwnerDraw = true;
			toolTip.BackColor = Color.Yellow;
			toolTip.AutoPopDelay = 20000;
			toolTip.InitialDelay = 500;
			toolTip.ReshowDelay = 500;
			toolTip.ShowAlways = true;
			toolTip.IsBalloon = true;
			toolTip.SetToolTip(this.cboxSavePass, frmMain.String_324);
			toolTip.SetToolTip(this.txtUserID, frmMain.String_323);
			toolTip.SetToolTip(this.txtUserPassword, frmMain.String_322);
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x000C5DB4 File Offset: 0x000C3FB4
		public static void smethod_9(object object_18, string string_19)
		{
			string str = "";
			foreach (GClass2 gclass in (object_18 as Class210<GClass2>))
			{
				if (string_19 == "ListLoginProfile")
				{
					string text = Class83.smethod_73(Class83.smethod_71(gclass.secureString_0), "%6fhru4?");
					text = Convert.ToBase64String(Encoding.UTF8.GetBytes(text));
					str += string.Format("{0};{1};{2};{3};{4};{5};{6};{7}|", new object[]
					{
						gclass.Username,
						text,
						gclass.String_0,
						gclass.Server,
						gclass.MinorServer,
						gclass.CharName,
						gclass.GamePath,
						gclass.DatabaseID
					});
				}
			}
			frmLogin.class101_0.globalSettings_0.method_0(string_19, str, "", new string[0]);
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x000C5EC4 File Offset: 0x000C40C4
		private void method_12(object object_18, string string_19)
		{
			string str = "";
			foreach (string str2 in (object_18 as Class210<string>))
			{
				str = str + str2 + "|";
			}
			frmLogin.class101_0.globalSettings_0.method_0(string_19, str, "Danh sách các món đồ cần nhặt", new string[0]);
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x0000A45E File Offset: 0x0000865E
		public void method_13(object sender, EventArgs e)
		{
			this.method_12(sender, "ItemBanList");
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x0000A46C File Offset: 0x0000866C
		public void method_14(object sender, EventArgs e)
		{
			frmLogin.smethod_9(sender, "ListLoginProfile");
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x000024E9 File Offset: 0x000006E9
		public void method_15(object sender, EventArgs e)
		{
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x0000A45E File Offset: 0x0000865E
		public void method_16(object sender, EventArgs e)
		{
			this.method_12(sender, "ItemBanList");
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x0000A479 File Offset: 0x00008679
		public void method_17(object sender, EventArgs e)
		{
			this.method_12(sender, "ListBuffPetID");
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x0000A479 File Offset: 0x00008679
		public void method_18(object sender, EventArgs e)
		{
			this.method_12(sender, "ListBuffPetID");
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x0000A487 File Offset: 0x00008687
		public void method_19(object sender, EventArgs e)
		{
			this.method_12(sender, "BuffNameList");
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x0000A487 File Offset: 0x00008687
		public void method_20(object sender, EventArgs e)
		{
			this.method_12(sender, "BuffNameList");
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x0000A495 File Offset: 0x00008695
		public void method_21(object sender, EventArgs e)
		{
			this.method_12(sender, "ItemTuHuyList");
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x0000A495 File Offset: 0x00008695
		public void method_22(object sender, EventArgs e)
		{
			this.method_12(sender, "ItemTuHuyList");
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x0000A4A3 File Offset: 0x000086A3
		public void method_23(object sender, EventArgs e)
		{
			this.method_12(sender, "ListItemNhat");
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x0000A4A3 File Offset: 0x000086A3
		public void method_24(object sender, EventArgs e)
		{
			this.method_12(sender, "ListItemNhat");
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_25()
		{
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x0000A4B1 File Offset: 0x000086B1
		private void toolStripMenuItem_3_Click(object sender, EventArgs e)
		{
			Class83.smethod_95();
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x0000A4B8 File Offset: 0x000086B8
		private void toolStripMenuItem_0_Click(object sender, EventArgs e)
		{
			Class83.smethod_93();
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x000C5F40 File Offset: 0x000C4140
		private string method_26()
		{
			string text = "{}";
			string result = "server1.gamauto.net|server2.gamauto.net";
			try
			{
				result = JsonConvert.DeserializeObject<Class80>(Class83.smethod_41(text, 1)).string_1;
			}
			catch (Exception)
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x0000A4BF File Offset: 0x000086BF
		private void toolStripMenuItem_2_Click(object sender, EventArgs e)
		{
			Class83.smethod_89();
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x0000A4C6 File Offset: 0x000086C6
		private void toolStripMenuItem_1_Click(object sender, EventArgs e)
		{
			Class83.smethod_84();
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x0000A4CD File Offset: 0x000086CD
		private void toolStripMenuItem_4_Click(object sender, EventArgs e)
		{
			Class83.smethod_87();
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x0000A4D4 File Offset: 0x000086D4
		private void btnNewAccount_Click(object sender, EventArgs e)
		{
			if (Class101.int_4 != 2)
			{
				frmLogin.smethod_6();
				return;
			}
			MessageBox.Show("Auto đang miễn phí, bạn dùng tài khoản: \"gauto\" password: \"gautofree\" để đăng nhập.");
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x0000A4EF File Offset: 0x000086EF
		private void updateGAutoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmLogin.smethod_10(false);
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x000C5F88 File Offset: 0x000C4188
		public static void smethod_10(bool bool_40 = false)
		{
			if (frmLogin.string_3 == Class83.smethod_22())
			{
				frmLogin.bool_1 = false;
				bool_40 = false;
			}
			if (bool_40)
			{
				frmLogin.string_4 = "anything.zip";
			}
			if (frmLogin.bool_1 || bool_40)
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.FileName = frmLogin.class101_0.globalSettings_0.UpdaterEXE;
				string text = Class83.smethod_22().Replace(".", "");
				processStartInfo.Arguments = string.Format("{3} {0} {1} {2}", new object[]
				{
					frmLogin.string_4,
					AppDomain.CurrentDomain.FriendlyName,
					text,
					frmLogin.class101_0.globalSettings_0.GameID
				});
				processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
				Process.Start(processStartInfo);
				if (bool_40)
				{
					frmLogin.bool_7 = true;
					return;
				}
				Class83.smethod_62(false);
			}
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x000C605C File Offset: 0x000C425C
		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (!frmLogin.bool_23)
			{
				if (!(frmLogin.string_0 == "VN") && frmLogin.int_3 != 1)
				{
					if (frmLogin.int_3 != 2)
					{
						this.btnLogin.Enabled = true;
						this.btnNapThe.Enabled = true;
						this.lblForgotPassword.Enabled = true;
						this.linkChangePass.Enabled = true;
						this.btnNewAccount.Enabled = true;
						frmLogin.bool_23 = true;
						goto IL_C1;
					}
				}
				if (frmLogin.class132_0 != null && frmLogin.bool_10)
				{
					this.btnLogin.Enabled = true;
					this.btnNapThe.Enabled = true;
					this.lblForgotPassword.Enabled = true;
					this.linkChangePass.Enabled = true;
					this.btnNewAccount.Enabled = true;
					frmLogin.bool_23 = true;
				}
			}
			IL_C1:
			if (base.Visible && this.long_40 > 0L)
			{
				this.btnLogin.Text = frmMain.String_325 + string.Format(" ({0})s", Math.Round((double)(frmLogin.stopwatch_0.ElapsedMilliseconds - this.long_40) / 1000.0));
			}
			if (frmLogin.long_39 > 0L && frmLogin.stopwatch_0.ElapsedMilliseconds > frmLogin.long_39)
			{
				Class83.smethod_62(false);
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x0000A4F7 File Offset: 0x000086F7
		// (set) Token: 0x06000A25 RID: 2597 RVA: 0x000C61A4 File Offset: 0x000C43A4
		public string String_0
		{
			get
			{
				return this.string_5;
			}
			set
			{
				this.string_5 = value;
				Class162 @class = new Class162();
				FieldInfo field = base.GetType().GetField("Name");
				@class.string_0 = field.Name;
				@class.string_2 = value;
				@class.string_1 = "Chuyến cuối đi TN là hướng nào";
			}
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x000024E9 File Offset: 0x000006E9
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_27(object sender, EventArgs e)
		{
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x0000A4B8 File Offset: 0x000086B8
		private void method_28(object sender, EventArgs e)
		{
			Class83.smethod_93();
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x0000A4FF File Offset: 0x000086FF
		private void txtUserPassword_TextChanged(object sender, EventArgs e)
		{
			if (this.bool_4)
			{
				this.bool_2 = true;
			}
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x000024E9 File Offset: 0x000006E9
		private void cboxSavePass_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x000C61EC File Offset: 0x000C43EC
		public static void smethod_11(string string_19 = "")
		{
			frmNapThe frmNapThe = new frmNapThe();
			frmNapThe.class101_0 = frmLogin.class101_0;
			if (!string.IsNullOrEmpty(string_19))
			{
				frmNapThe.string_1 = string_19;
			}
			frmNapThe.ShowDialog();
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x0000A392 File Offset: 0x00008592
		private void toolStripMenuItem_5_Click(object sender, EventArgs e)
		{
			frmMain.smethod_18();
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x0000A510 File Offset: 0x00008710
		private void txtUserID_TextChanged(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				this.bool_3 = true;
			}
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x0000A392 File Offset: 0x00008592
		private void btnNapThe_Click(object sender, EventArgs e)
		{
			frmMain.smethod_18();
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x000C6220 File Offset: 0x000C4420
		private static bool smethod_12(string string_19, IntPtr intptr_3)
		{
			IList<string> list = GCHandle.FromIntPtr(intptr_3).Target as List<string>;
			if (list == null)
			{
				return false;
			}
			list.Add(string_19);
			return true;
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0000A399 File Offset: 0x00008599
		private void btnFacebook_Click(object sender, EventArgs e)
		{
			Class83.smethod_91();
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x0000A521 File Offset: 0x00008721
		private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
		{
			frmLogin.bool_19 = true;
			Class83.smethod_62(false);
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x0000A52F File Offset: 0x0000872F
		private void method_29(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			if ((sender as WebBrowser).Url == e.Url)
			{
				Application.ExitThread();
			}
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_30(object sender, EventArgs e)
		{
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x000C6250 File Offset: 0x000C4450
		private void lblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (!(frmLogin.string_0 == "VN") && !(frmLogin.string_0 == "EN"))
			{
				this.pnelPassword.BringToFront();
				if (this.txtUserID.Text != "")
				{
					this.txtPassAccount.Text = this.txtUserID.Text;
				}
				this.method_33(true);
				this.method_32(false);
				this.method_31(false);
				return;
			}
			this.pnelPassword.BringToFront();
			if (this.txtUserID.Text != "")
			{
				this.txtPassAccount.Text = this.txtUserID.Text;
			}
			this.method_33(true);
			this.method_32(false);
			this.method_31(false);
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x000C631C File Offset: 0x000C451C
		private void method_31(bool bool_40)
		{
			this.txtUserID.Enabled = bool_40;
			this.txtUserPassword.Enabled = bool_40;
			this.btnNapThe.Enabled = bool_40;
			this.btnNewAccount.Enabled = bool_40;
			this.btnLogin.Enabled = bool_40;
			this.cboxSavePass.Enabled = bool_40;
			this.lblForgotPassword.Enabled = bool_40;
			this.btnFacebook.Enabled = bool_40;
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x0000A54E File Offset: 0x0000874E
		// (set) Token: 0x06000A37 RID: 2615 RVA: 0x0000A555 File Offset: 0x00008755
		public static bool Boolean_0
		{
			get
			{
				return frmLogin.bool_15;
			}
			set
			{
				if (value)
				{
					Class83.smethod_66("Error loading auto information. Please notify GAuto team.", null, new object[0]);
				}
				frmLogin.bool_15 = value;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000A38 RID: 2616 RVA: 0x0000A571 File Offset: 0x00008771
		public static string String_1
		{
			get
			{
				if (frmLogin.string_0 == "VN")
				{
					return "GG";
				}
				if (frmLogin.string_0 == "EN")
				{
					return "TK";
				}
				return "GG";
			}
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x0000A5A6 File Offset: 0x000087A6
		private void btnPassQuayVe_Click(object sender, EventArgs e)
		{
			this.staMain.BringToFront();
			this.method_31(true);
			this.pnelLogin.BringToFront();
			this.pnelPassword.SendToBack();
			this.method_33(false);
			this.method_32(false);
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x000C638C File Offset: 0x000C458C
		private void method_32(bool bool_40)
		{
			this.txtCP_NewPass.Enabled = bool_40;
			this.txtCP_NewPass2.Enabled = bool_40;
			this.txtCP_OldPass.Enabled = bool_40;
			this.txtCP_Username.Enabled = bool_40;
			this.btnCP_Change.Enabled = bool_40;
			this.btnCP_Return.Enabled = bool_40;
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x0000A5DE File Offset: 0x000087DE
		private void method_33(bool bool_40)
		{
			this.txtPassAccount.Enabled = bool_40;
			this.btnPassEmail.Enabled = bool_40;
			this.btnPassQuayVe.Enabled = bool_40;
			this.btnPassEmail.Enabled = bool_40;
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x000C63E4 File Offset: 0x000C45E4
		private void btnPassEmail_Click(object sender, EventArgs e)
		{
			if (frmLogin.string_0 == "CN" || frmLogin.string_0 == "VN")
			{
				int num = 0;
				if (!this.txtPassEmail.Text.Contains("@") || !this.txtPassEmail.Text.Contains("."))
				{
					MessageBox.Show(frmMain.String_760, frmMain.String_761, MessageBoxButtons.OK, MessageBoxIcon.Hand);
					num++;
				}
				if (num == 0)
				{
					string text = string.Format("username={0}&email={1}", this.txtPassAccount.Text, this.txtPassEmail.Text.ToLower());
					string text2;
					if (frmLogin.class101_0.globalSettings_0.ForgotPassURL.StartsWith("http"))
					{
						text2 = Class83.smethod_125(frmLogin.class101_0.globalSettings_0.ForgotPassURL, text, "POST", frmLogin.class101_0.globalSettings_0.MainCookie, true);
					}
					else
					{
						text2 = Class83.smethod_125("http://server1.gameauto.net/" + frmLogin.class101_0.globalSettings_0.ForgotPassURL, text, "POST", frmLogin.class101_0.globalSettings_0.MainCookie, true);
					}
					if (text2.Contains(frmMain.String_762))
					{
						if (frmLogin.string_0 == "VN")
						{
							MessageBox.Show("Link phục hồi mật khẩu đã được gửi về email " + this.txtPassEmail.Text.ToLower() + "\nKiểm tra hộp thư rác nếu không tìm thấy trong inbox", "Đã gửi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
						else if (frmLogin.string_0 == "CN")
						{
							MessageBox.Show("密码恢复链接被发送至电子邮箱：" + this.txtPassEmail.Text.ToLower() + "\n检查垃圾邮件，如果在收件箱中未发现", "帖子", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
						this.btnPassQuayVe_Click(null, null);
						return;
					}
					MessageBox.Show(text2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x000C65B4 File Offset: 0x000C47B4
		private void cboxOnlyCheDo_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;
			bool flag = true;
			if (checkBox.Checked && checkBox.Focused)
			{
				DialogResult dialogResult = MessageBox.Show("Bạn bật tùy chọn đăng nhập chế đồ?\nBạn sẽ tiêu phí 5GG khi đăng nhập và được cấp 24h chế đồ 1 tài khoản \nKhi đăng nhập chế đồ sẽ không thể bật auto đánh quái\nBạn có đồng ý tiếp tục không?", "Chế độ chế đồ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dialogResult == DialogResult.No || dialogResult == DialogResult.None)
				{
					flag = false;
				}
			}
			if (flag)
			{
				frmLogin.class101_0.globalSettings_0.cboxOnlyCheDo = checkBox.Checked;
				return;
			}
			checkBox.Checked = !checkBox.Checked;
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x000C6620 File Offset: 0x000C4820
		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
			if (e.Argument != null && e.Argument.GetType() == typeof(int) && (int)e.Argument == 1)
			{
				this.method_1();
				e.Result = 1;
			}
			if (e.Argument != null && e.Argument.GetType() == typeof(int) && (int)e.Argument == 2)
			{
				this.method_10();
				e.Result = 2;
			}
			if (e.Argument != null && e.Argument.GetType() == typeof(Class73))
			{
				e.Result = Class83.smethod_29((Class73)e.Argument, null);
			}
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x000C66E4 File Offset: 0x000C48E4
		private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Result != null && e.Result.GetType() == typeof(int) && (int)e.Result == 1 && frmLogin.string_0 == "VN")
			{
				try
				{
					if (frmLogin.list_5.Count > 0)
					{
						this.cboServerlist.BeginUpdate();
						foreach (Class132 @class in frmLogin.list_5)
						{
							this.cboServerlist.Items.Add(@class.String_0);
						}
						this.cboServerlist.EndUpdate();
						if (frmLogin.class132_0 != null)
						{
							this.cboServerlist.Text = frmLogin.class132_0.String_0;
						}
						else
						{
							this.cboServerlist.SelectedIndex = 0;
						}
					}
				}
				catch (Exception)
				{
				}
			}
			if (e.Result != null && e.Result.GetType() == typeof(int) && (int)e.Result == 2)
			{
				this.btnLogin.Enabled = true;
			}
			if (e.Result != null && e.Result.GetType() == typeof(Class72))
			{
				this.long_40 = 0L;
				this.btnLogin.Enabled = true;
				this.btnLogin.Text = frmMain.String_325;
				Class72 class2 = (Class72)e.Result;
				if (class2.int_0 == 1)
				{
					frmLogin.smethod_13();
					return;
				}
				if (class2.int_0 == 200)
				{
					frmPickSession frmPickSession = new frmPickSession();
					frmPickSession.method_0((Dictionary<string, object>[])class2.object_0);
					frmPickSession.ShowDialog();
					return;
				}
				if (class2.int_0 != 300 && class2.int_0 != 301)
				{
					string text = "Đăng nhập gặp sự cố, vui lòng liên hệ admin.";
					if (class2.object_0 != null && class2.object_0.ToString() != "")
					{
						text = class2.object_0.ToString();
					}
					else if (class2.string_0 != "")
					{
						text = class2.string_0;
					}
					Class83.smethod_46(text, "Login", 60000, new object[0]);
				}
			}
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x000C6938 File Offset: 0x000C4B38
		public static void smethod_13()
		{
			if (frmLogin.class101_0.globalSettings_0.AppMode == Class57.Enum8.const_0 && frmLogin.class101_0.globalSettings_0.Account.TotalBalance <= 0.0)
			{
				new frmLiteVersion().ShowDialog();
			}
			if (!frmLiteVersion.bool_0)
			{
				frmLogin.class101_0.globalSettings_0.IsLoggedIn = true;
				Class83.smethod_82();
				return;
			}
			Class83.smethod_62(false);
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x000C69A4 File Offset: 0x000C4BA4
		private void cboxMoThuongNhan_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;
			bool flag = true;
			if (checkBox.Checked && checkBox.Focused)
			{
				DialogResult dialogResult = MessageBox.Show("Bạn bật tùy chọn mở chức năng Thương Nhân?\nKhi vào game sẽ có thêm Tab Thương Nhân\nBạn có đồng ý tiếp tục không?", "Mở chức năng Thương Nhân", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dialogResult == DialogResult.No || dialogResult == DialogResult.None)
				{
					flag = false;
				}
			}
			if (flag)
			{
				frmLogin.class101_0.globalSettings_0.cboxMoThuongNhan = checkBox.Checked;
				return;
			}
			checkBox.Checked = !checkBox.Checked;
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x000C6A10 File Offset: 0x000C4C10
		private void cboServerlist_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cboServerlist.Focused)
			{
				string text = this.cboServerlist.SelectedItem.ToString();
				if (text != "" && frmLogin.list_5.Count > 0)
				{
					for (int i = frmLogin.list_5.Count - 1; i >= 0; i--)
					{
						if (frmLogin.list_5[i].String_0 == text)
						{
							frmLogin.class132_0 = frmLogin.list_5[i];
							return;
						}
					}
				}
			}
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x000024E9 File Offset: 0x000006E9
		private void label6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x000C6A98 File Offset: 0x000C4C98
		private void toolStripMenuItem_6_Click(object sender, EventArgs e)
		{
			string text = Interaction.InputBox("Điền vào thông tin proxy serverIP:port", "Proxy settings", "", -1, -1);
			if (text != "" && text.Contains(":"))
			{
				string[] array = text.Split(new char[]
				{
					':'
				});
				if (array.Length >= 2)
				{
					int port = 0;
					int.TryParse(array[1], out port);
					frmLogin.webProxy_0 = new WebProxy(array[0], port);
					return;
				}
			}
			else
			{
				MessageBox.Show("Proxy phải có format dạng địa-chỉ-IP:cổng", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0000A399 File Offset: 0x00008599
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Class83.smethod_91();
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x0000A610 File Offset: 0x00008810
		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Class83.smethod_16();
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x000C6B20 File Offset: 0x000C4D20
		private void linkChangePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (frmLogin.string_0 == "VN")
			{
				this.pnelChangePassword.BringToFront();
				if (this.txtUserID.Text != "")
				{
					this.txtCP_Username.Text = this.txtUserID.Text;
				}
				this.method_32(true);
				this.method_33(false);
				this.method_31(false);
				return;
			}
			this.pnelChangePassword.BringToFront();
			if (this.txtUserID.Text != "")
			{
				this.txtCP_Username.Text = this.txtUserID.Text;
			}
			this.method_32(true);
			this.method_33(false);
			this.method_31(false);
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x0000A617 File Offset: 0x00008817
		private void btnCP_Return_Click(object sender, EventArgs e)
		{
			this.staMain.BringToFront();
			this.method_31(true);
			this.pnelLogin.BringToFront();
			this.pnelChangePassword.SendToBack();
			this.method_33(false);
			this.method_32(false);
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x000C6BDC File Offset: 0x000C4DDC
		private void btnCP_Change_Click(object sender, EventArgs e)
		{
			bool flag = false;
			if (this.txtCP_NewPass.Text == this.txtCP_OldPass.Text)
			{
				flag = true;
				MessageBox.Show("Mật khẩu mới phải khác với mật khẩu cũ", "Không có gì thay đổi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			if ((!flag && this.txtCP_NewPass.Text.Length < 6) || this.txtCP_NewPass.Text.Length > 50)
			{
				MessageBox.Show("Mật khẩu mới phải dài hơn 6 ký tự và ít hơn 50 ký tự", "Mật khẩu mới không đạt tiêu chuẩn", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				flag = true;
			}
			if (!flag && this.txtCP_NewPass.Text != this.txtCP_NewPass2.Text)
			{
				MessageBox.Show("Mật khẩu mới phải được nhập vào 2 lần giống nhau", "Mật khẩu mới không khớp", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				flag = true;
			}
			if (!flag && this.txtCP_Username.Text == string.Empty)
			{
				MessageBox.Show("Tên sử dụng không được để trống", "Tên sử dụng không đúng", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				this.txtCP_Username.Focus();
				flag = true;
			}
			if (!flag && this.txtCP_OldPass.Text == string.Empty)
			{
				MessageBox.Show("Mật khẩu hiện tại không được để trống", "Mật khẩu không đúng", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				this.txtCP_OldPass.Focus();
				flag = true;
			}
			if (!flag)
			{
				string text = string.Format("username={0}&password={1}&newpass={2}&newpass2={2}", this.txtCP_Username.Text, this.txtCP_OldPass.Text, this.txtCP_NewPass.Text);
				string text2;
				if (frmLogin.class101_0.globalSettings_0.ChangePasswordURL.StartsWith("http"))
				{
					text2 = Class83.smethod_125(frmLogin.class101_0.globalSettings_0.ChangePasswordURL, text, "POST", frmLogin.class101_0.globalSettings_0.MainCookie, true);
				}
				else
				{
					text2 = Class83.smethod_125(frmLogin.class132_0.string_0 + frmLogin.class101_0.globalSettings_0.ChangePasswordURL, text, "POST", frmLogin.class101_0.globalSettings_0.MainCookie, true);
				}
				if (text2.Contains("Mật khẩu đã được đổi thành công."))
				{
					MessageBox.Show(text2, "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					this.txtUserID.Text = this.txtCP_Username.Text;
					this.txtPassAccount.Text = this.txtCP_NewPass.Text;
					this.btnCP_Return_Click(null, null);
				}
				else
				{
					MessageBox.Show(text2, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

		// Token: 0x04000D89 RID: 3465
		public static List<string> list_0 = new List<string>();

		// Token: 0x04000D8A RID: 3466
		public static List<string> list_1 = new List<string>();

		// Token: 0x04000D8B RID: 3467
		public static List<string> list_2 = new List<string>
		{
			"HOMEPC-PC",
			"BABYKUTE",
			"SUPERVIP"
		};

		// Token: 0x04000D8C RID: 3468
		public static Class130 class130_0 = new Class130();

		// Token: 0x04000D8D RID: 3469
		public static WebProxy webProxy_0 = null;

		// Token: 0x04000D8E RID: 3470
		public static List<int> list_3 = new List<int>();

		// Token: 0x04000D8F RID: 3471
		public static DateTime dateTime_0 = DateTime.MinValue;

		// Token: 0x04000D90 RID: 3472
		public static object object_0 = new object();

		// Token: 0x04000D91 RID: 3473
		public static frmLiteBuy frmLiteBuy_0 = null;

		// Token: 0x04000D92 RID: 3474
		public static Class81 class81_0 = new Class81();

		// Token: 0x04000D93 RID: 3475
		public static object object_1 = new object();

		// Token: 0x04000D94 RID: 3476
		public static object object_2 = new object();

		// Token: 0x04000D95 RID: 3477
		public static List<int> list_4 = new List<int>();

		// Token: 0x04000D96 RID: 3478
		public static List<Class132> list_5 = new List<Class132>();

		// Token: 0x04000D97 RID: 3479
		public static bool bool_0 = false;

		// Token: 0x04000D98 RID: 3480
		public static Random random_0 = new Random();

		// Token: 0x04000D99 RID: 3481
		public static List<int> list_6 = new List<int>();

		// Token: 0x04000D9A RID: 3482
		public static List<string> list_7 = new List<string>
		{
			"bs2",
			"bs4",
			"bs11",
			"bs14",
			"bs28",
			"bs29"
		};

		// Token: 0x04000D9B RID: 3483
		public static object object_3 = new object();

		// Token: 0x04000D9C RID: 3484
		public static object object_4 = new object();

		// Token: 0x04000D9D RID: 3485
		public static List<Class136> list_8 = new List<Class136>();

		// Token: 0x04000D9E RID: 3486
		public static List<Class136> list_9 = new List<Class136>();

		// Token: 0x04000D9F RID: 3487
		public static string string_0 = "VN";

		// Token: 0x04000DA0 RID: 3488
		public static List<string> list_10 = new List<string>();

		// Token: 0x04000DA1 RID: 3489
		public static List<string> list_11 = new List<string>();

		// Token: 0x04000DA2 RID: 3490
		public static List<string> list_12 = new List<string>();

		// Token: 0x04000DA3 RID: 3491
		public static List<string> list_13 = new List<string>();

		// Token: 0x04000DA4 RID: 3492
		public static List<string> list_14 = new List<string>();

		// Token: 0x04000DA5 RID: 3493
		public static List<string> list_15 = new List<string>();

		// Token: 0x04000DA6 RID: 3494
		public static List<string> list_16 = new List<string>();

		// Token: 0x04000DA7 RID: 3495
		public static List<string> list_17 = new List<string>();

		// Token: 0x04000DA8 RID: 3496
		public static List<string> list_18 = new List<string>();

		// Token: 0x04000DA9 RID: 3497
		public static string string_1 = "";

		// Token: 0x04000DAA RID: 3498
		public static List<string> list_19 = new List<string>
		{
			"Song Kiếm"
		};

		// Token: 0x04000DAB RID: 3499
		public static List<Class140> list_20 = new List<Class140>();

		// Token: 0x04000DAC RID: 3500
		public static List<int> list_21 = new List<int>();

		// Token: 0x04000DAD RID: 3501
		public static object object_5 = new object();

		// Token: 0x04000DAE RID: 3502
		public static List<Class63> list_22 = new List<Class63>();

		// Token: 0x04000DAF RID: 3503
		public static object object_6 = new object();

		// Token: 0x04000DB0 RID: 3504
		public static object object_7 = new object();

		// Token: 0x04000DB1 RID: 3505
		public static string string_2 = new Class83.Class85().String_0;

		// Token: 0x04000DB2 RID: 3506
		private Thread thread_0;

		// Token: 0x04000DB3 RID: 3507
		public static bool bool_1 = false;

		// Token: 0x04000DB4 RID: 3508
		private GClass0 gclass0_0 = new GClass0();

		// Token: 0x04000DB5 RID: 3509
		public static object object_8 = new object();

		// Token: 0x04000DB6 RID: 3510
		public static object object_9 = new object();

		// Token: 0x04000DB7 RID: 3511
		public static object object_10 = new object();

		// Token: 0x04000DB8 RID: 3512
		public static object object_11 = new object();

		// Token: 0x04000DB9 RID: 3513
		public static object object_12 = new object();

		// Token: 0x04000DBA RID: 3514
		public static List<string> list_23 = new List<string>();

		// Token: 0x04000DBB RID: 3515
		public static List<string> list_24 = new List<string>();

		// Token: 0x04000DBC RID: 3516
		public static List<Class144> list_25 = new List<Class144>();

		// Token: 0x04000DBD RID: 3517
		public static Class101 class101_0 = new Class101();

		// Token: 0x04000DBE RID: 3518
		public static frmLogin frmLogin_0;

		// Token: 0x04000DBF RID: 3519
		public static string string_3 = "";

		// Token: 0x04000DC0 RID: 3520
		public static string string_4;

		// Token: 0x04000DC1 RID: 3521
		private bool bool_2;

		// Token: 0x04000DC2 RID: 3522
		private bool bool_3;

		// Token: 0x04000DC3 RID: 3523
		private bool bool_4;

		// Token: 0x04000DC4 RID: 3524
		private bool bool_5;

		// Token: 0x04000DC5 RID: 3525
		public static object object_13 = new object();

		// Token: 0x04000DC6 RID: 3526
		private string string_5 = "";

		// Token: 0x04000DC7 RID: 3527
		public static long long_0;

		// Token: 0x04000DC8 RID: 3528
		public static long long_1;

		// Token: 0x04000DC9 RID: 3529
		public static Stopwatch stopwatch_0 = new Stopwatch();

		// Token: 0x04000DCA RID: 3530
		public static long long_2 = 0L;

		// Token: 0x04000DCB RID: 3531
		public static bool bool_6;

		// Token: 0x04000DCC RID: 3532
		public static bool bool_7;

		// Token: 0x04000DCD RID: 3533
		public static string string_6 = Class83.smethod_22().ToString();

		// Token: 0x04000DCE RID: 3534
		public static long long_3 = 0L;

		// Token: 0x04000DCF RID: 3535
		public static bool bool_8;

		// Token: 0x04000DD0 RID: 3536
		public static long long_4;

		// Token: 0x04000DD1 RID: 3537
		public static bool bool_9 = false;

		// Token: 0x04000DD2 RID: 3538
		public static long long_5;

		// Token: 0x04000DD3 RID: 3539
		public static TimeSpan timeSpan_0;

		// Token: 0x04000DD4 RID: 3540
		public static long long_6;

		// Token: 0x04000DD5 RID: 3541
		public static frmHotKeys frmHotKeys_0 = null;

		// Token: 0x04000DD6 RID: 3542
		public static frmCheDo frmCheDo_0 = null;

		// Token: 0x04000DD7 RID: 3543
		public static long long_7;

		// Token: 0x04000DD8 RID: 3544
		public static long long_8;

		// Token: 0x04000DD9 RID: 3545
		public static bool bool_10;

		// Token: 0x04000DDA RID: 3546
		public static long long_9;

		// Token: 0x04000DDB RID: 3547
		public static long long_10;

		// Token: 0x04000DDC RID: 3548
		public static long long_11;

		// Token: 0x04000DDD RID: 3549
		public static IntPtr intptr_0 = IntPtr.Zero;

		// Token: 0x04000DDE RID: 3550
		public static long long_12;

		// Token: 0x04000DDF RID: 3551
		public static frmGLogin frmGLogin_0;

		// Token: 0x04000DE0 RID: 3552
		public static int int_0 = 0;

		// Token: 0x04000DE1 RID: 3553
		public static long long_13 = 0L;

		// Token: 0x04000DE2 RID: 3554
		public static bool bool_11;

		// Token: 0x04000DE3 RID: 3555
		public static long long_14;

		// Token: 0x04000DE4 RID: 3556
		public static frmAutoPK frmAutoPK_0 = null;

		// Token: 0x04000DE5 RID: 3557
		public static IntPtr intptr_1 = IntPtr.Zero;

		// Token: 0x04000DE6 RID: 3558
		public static IntPtr intptr_2 = IntPtr.Zero;

		// Token: 0x04000DE7 RID: 3559
		public static Delegate7 delegate7_0;

		// Token: 0x04000DE8 RID: 3560
		public static object object_14 = new object();

		// Token: 0x04000DE9 RID: 3561
		public static long long_15;

		// Token: 0x04000DEA RID: 3562
		public static frmScheduler frmScheduler_0 = null;

		// Token: 0x04000DEB RID: 3563
		public static long long_16;

		// Token: 0x04000DEC RID: 3564
		public static frmMuaBlock frmMuaBlock_0 = null;

		// Token: 0x04000DED RID: 3565
		public static long long_17 = 0L;

		// Token: 0x04000DEE RID: 3566
		public static long long_18 = 0L;

		// Token: 0x04000DEF RID: 3567
		public static long long_19 = 0L;

		// Token: 0x04000DF0 RID: 3568
		public static long long_20 = 0L;

		// Token: 0x04000DF1 RID: 3569
		public static long long_21 = 0L;

		// Token: 0x04000DF2 RID: 3570
		public static bool bool_12 = false;

		// Token: 0x04000DF3 RID: 3571
		public static long long_22;

		// Token: 0x04000DF4 RID: 3572
		public static bool bool_13;

		// Token: 0x04000DF5 RID: 3573
		public static bool bool_14;

		// Token: 0x04000DF6 RID: 3574
		public static long long_23;

		// Token: 0x04000DF7 RID: 3575
		private static bool bool_15 = false;

		// Token: 0x04000DF8 RID: 3576
		public static bool bool_16;

		// Token: 0x04000DF9 RID: 3577
		public static long long_24;

		// Token: 0x04000DFA RID: 3578
		public static frmNVTanThu frmNVTanThu_0;

		// Token: 0x04000DFB RID: 3579
		public static long long_25 = 0L;

		// Token: 0x04000DFC RID: 3580
		public static string string_7;

		// Token: 0x04000DFD RID: 3581
		public static long long_26;

		// Token: 0x04000DFE RID: 3582
		public static long long_27 = 1800000L;

		// Token: 0x04000DFF RID: 3583
		public static List<string> list_26 = new List<string>();

		// Token: 0x04000E00 RID: 3584
		public static List<string> list_27 = new List<string>();

		// Token: 0x04000E01 RID: 3585
		public static List<string> list_28 = new List<string>();

		// Token: 0x04000E02 RID: 3586
		public static List<string> list_29 = new List<string>();

		// Token: 0x04000E03 RID: 3587
		public static List<string> list_30 = new List<string>();

		// Token: 0x04000E04 RID: 3588
		public static bool bool_17 = true;

		// Token: 0x04000E05 RID: 3589
		public static long long_28 = 0L;

		// Token: 0x04000E06 RID: 3590
		public static int int_1;

		// Token: 0x04000E07 RID: 3591
		public static long long_29;

		// Token: 0x04000E08 RID: 3592
		public static long long_30;

		// Token: 0x04000E09 RID: 3593
		public static bool bool_18 = false;

		// Token: 0x04000E0A RID: 3594
		public static string string_8 = "HAOPC3-PC";

		// Token: 0x04000E0B RID: 3595
		public static long long_31;

		// Token: 0x04000E0C RID: 3596
		public static long long_32;

		// Token: 0x04000E0D RID: 3597
		public static int int_2;

		// Token: 0x04000E0E RID: 3598
		public static long long_33;

		// Token: 0x04000E0F RID: 3599
		public static long long_34;

		// Token: 0x04000E10 RID: 3600
		public static long long_35 = 30000L;

		// Token: 0x04000E11 RID: 3601
		public static int int_3 = 0;

		// Token: 0x04000E12 RID: 3602
		public static long long_36;

		// Token: 0x04000E13 RID: 3603
		public static string string_9 = "";

		// Token: 0x04000E14 RID: 3604
		public static string string_10 = "";

		// Token: 0x04000E15 RID: 3605
		public static bool bool_19;

		// Token: 0x04000E16 RID: 3606
		public static List<int> list_31 = new List<int>();

		// Token: 0x04000E17 RID: 3607
		public static int int_4 = 1;

		// Token: 0x04000E18 RID: 3608
		public static bool bool_20 = false;

		// Token: 0x04000E19 RID: 3609
		public static bool bool_21 = false;

		// Token: 0x04000E1A RID: 3610
		private static bool bool_22 = true;

		// Token: 0x04000E1B RID: 3611
		public static Class132 class132_0 = null;

		// Token: 0x04000E1C RID: 3612
		private static bool bool_23;

		// Token: 0x04000E1D RID: 3613
		public static long long_37;

		// Token: 0x04000E1E RID: 3614
		public static int int_5;

		// Token: 0x04000E1F RID: 3615
		public static bool bool_24;

		// Token: 0x04000E20 RID: 3616
		public static bool bool_25;

		// Token: 0x04000E21 RID: 3617
		public static bool bool_26;

		// Token: 0x04000E22 RID: 3618
		private static bool bool_27 = true;

		// Token: 0x04000E23 RID: 3619
		public static object object_15 = new object();

		// Token: 0x04000E24 RID: 3620
		public static int int_6 = 3;

		// Token: 0x04000E25 RID: 3621
		public static bool bool_28 = true;

		// Token: 0x04000E26 RID: 3622
		public static bool bool_29 = false;

		// Token: 0x04000E27 RID: 3623
		public static object object_16 = new object();

		// Token: 0x04000E28 RID: 3624
		public static long long_38 = 0L;

		// Token: 0x04000E29 RID: 3625
		public static long long_39 = 0L;

		// Token: 0x04000E2A RID: 3626
		public static object object_17 = new object();

		// Token: 0x04000E2B RID: 3627
		public static List<string> list_32 = new List<string>();

		// Token: 0x04000E2C RID: 3628
		private long long_40;

		// Token: 0x04000E2D RID: 3629
		public static long long_41 = 0L;

		// Token: 0x04000E2E RID: 3630
		public static double double_0 = 1000.0;

		// Token: 0x04000E2F RID: 3631
		public static bool bool_30 = true;

		// Token: 0x04000E30 RID: 3632
		public static int int_7 = 0;

		// Token: 0x04000E31 RID: 3633
		public static bool bool_31 = false;

		// Token: 0x04000E32 RID: 3634
		public static bool bool_32 = false;

		// Token: 0x04000E33 RID: 3635
		public static string string_11 = "N8GtbjwvhUXG";

		// Token: 0x04000E34 RID: 3636
		public static long long_42 = 0L;

		// Token: 0x04000E35 RID: 3637
		public static bool bool_33 = false;

		// Token: 0x04000E36 RID: 3638
		public static string string_12 = Application.ProductVersion;

		// Token: 0x04000E37 RID: 3639
		public static bool bool_34 = false;

		// Token: 0x04000E38 RID: 3640
		public static string string_13 = "http://up.game4you.us/launcher/serverinfo1.txt";

		// Token: 0x04000E39 RID: 3641
		public static string string_14 = "8888";

		// Token: 0x04000E3A RID: 3642
		public static List<string> list_33 = new List<string>();

		// Token: 0x04000E3B RID: 3643
		public static bool bool_35 = false;

		// Token: 0x04000E3C RID: 3644
		public static bool bool_36 = false;

		// Token: 0x04000E3D RID: 3645
		public static string string_15 = "GAuto_TinhKiem";

		// Token: 0x04000E3E RID: 3646
		public static string string_16;

		// Token: 0x04000E3F RID: 3647
		public static bool bool_37 = false;

		// Token: 0x04000E40 RID: 3648
		public static bool bool_38 = false;

		// Token: 0x04000E41 RID: 3649
		public static string string_17 = Environment.MachineName;

		// Token: 0x04000E42 RID: 3650
		public static bool bool_39 = true;

		// Token: 0x04000E43 RID: 3651
		public static string string_18 = "\\settings";
	}
}
