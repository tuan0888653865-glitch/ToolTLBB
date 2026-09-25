using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using ns0;

namespace SmartBot
{
	// Token: 0x02000095 RID: 149
	[Serializable]
	internal sealed class GlobalSettings
	{
		// Token: 0x060006CC RID: 1740 RVA: 0x00095DEC File Offset: 0x00093FEC
		public GlobalSettings()
		{
			Class209 @class = new Class209();
			@class.secureString_0 = Class83.smethod_70("SmFaTlFAXTltWUt5QnhEcEphWk5RQF05bVlLeUJ4RHA=");
			@class.secureString_1 = Class83.smethod_70("end+bjRCRU5eWlhjWyxfa3p3fm40QkVOXlpYY1ssX2s=");
			@class.secureString_2 = Class83.smethod_70("7amWVWjM2yyB2xbN");
			this.AESKeysets.Add(@class);
			@class = new Class209();
			@class.secureString_0 = Class83.smethod_70("VipxMn1nKCksbiImY0IqL3lwaFBEeFJmVEJrSFI2aHA=");
			@class.secureString_1 = Class83.smethod_70("IUBHcXddY2VyJUZTMTVHfXJYOChMJGoiRStKYyRgTW4=");
			@class.secureString_2 = Class83.smethod_70("xjAJS7aenHB5J380");
			this.AESKeysets.Add(@class);
			this.SkillTranslator.Add(new Class65
			{
				int_0 = 1850,
				string_0 = "Huyền Quy Kỳ Huyết Thú Sức-Pri",
				string_1 = "Càn Khôn Dẫn"
			});
			this.SkillTranslator.Add(new Class65
			{
				int_0 = 1851,
				string_0 = "Lục Hợp Kiếm-Khí Tông-Pri",
				string_1 = "Thái Thượng Vong Tình"
			});
			this.SkillTranslator.Add(new Class65
			{
				int_0 = 1852,
				string_0 = "Linh Phong Kiếm-Khí Tông-Pri",
				string_1 = "Tạo Hóa Tam Sinh"
			});
			this.SkillTranslator.Add(new Class65
			{
				int_0 = 1853,
				string_0 = "Vân Thuỷ Kiếm-Khí Tông-Pri",
				string_1 = "Nhất Khí Tam Sinh"
			});
			this.SkillTranslator.Add(new Class65
			{
				int_0 = 1854,
				string_0 = "Phi Hồng Kiến Nhật-Nho Tông-Pri",
				string_1 = "Phù Diêu Thực Trượng"
			});
			this.SkillTranslator.Add(new Class65
			{
				int_0 = 1855,
				string_0 = "Thái Vân Song Phi-Nho Tông-Pri",
				string_1 = "Đào Nhiên Nhất Túy"
			});
			this.SkillTranslator.Add(new Class65
			{
				int_0 = 1856,
				string_0 = "Thần Du Lăng Vân-Nho Tông-Pri",
				string_1 = "Bảo Nguyên Thủ Nhất"
			});
			this.SkillTranslator.Add(new Class65
			{
				int_0 = 1857,
				string_0 = "Mạnh Tiên Chỉ Lộ-Kiếm Tông-Pri",
				string_1 = "Mê Hoặc Thủ Tâm"
			});
			this.SkillTranslator.Add(new Class65
			{
				int_0 = 1858,
				string_0 = "Hắc Bạch Đoạt Phách-Kiếm Tông-Pri",
				string_1 = "Tu Tinh Trận - Trường Sinh"
			});
			this.SkillTranslator.Add(new Class65
			{
				int_0 = 1859,
				string_0 = "Mệnh Quy Minh Tiên-Kiếm Tông-Pri",
				string_1 = "Tuyệt Tình Trận - Phá Quân"
			});
			this.SkillTranslator.Add(new Class65
			{
				int_0 = 1861,
				string_0 = "Tử Kinh Trạch Lộ-Ma Tông-Pri",
				string_1 = "Vi Lão Tiên Suy"
			});
			this.SkillTranslator.Add(new Class65
			{
				int_0 = 1862,
				string_0 = "Đỗ Nhược Lưu Phương-Ma Tông-Pri",
				string_1 = "Tiêu Dao Du"
			});
			this.SkillTranslator.Add(new Class65
			{
				int_0 = 1863,
				string_0 = "Phật Vân Chưởng-Phật Tông-Pri",
				string_1 = "Ngũ Khí Triệu Nguyên"
			});
			this.SkillTranslator.Add(new Class65
			{
				int_0 = 1865,
				string_0 = "Từ Bi Thiên Diệp Thủ-Phật Tông-Pri",
				string_1 = "Phong Vân Phản Phúc"
			});
			this.SkillTranslator.Add(new Class65
			{
				int_0 = 1866,
				string_0 = "Hàn Băng Quyết-Khí Tông-Pri",
				string_1 = "Ý Tung Hoành"
			});
			this.SkillTranslator.Add(new Class65
			{
				int_0 = 1867,
				string_0 = "Ngự Khí Quyết-Khí Tông-Pri",
				string_1 = "Tu Tinh Trận - Âm Dương"
			});
			this.SkillTranslator.Add(new Class65
			{
				int_0 = 1868,
				string_0 = "Hàn Tụ Phật Huyệt-Khí Tông-Pri",
				string_1 = "Thanh Khê Trường Ca"
			});
			this.SkillTranslator.Add(new Class65
			{
				int_0 = 1869,
				string_0 = "Quảng Lăng Tán- Nho Tông-Pri",
				string_1 = "Thiên Nhân Hợp Nhất"
			});
			this.SkillTranslator.Add(new Class65
			{
				int_0 = 1870,
				string_0 = "Huyền Thiên Hắc Bạch Chỉ-Nho Tông-Pri",
				string_1 = "Trích Tiên Mộng Ảnh"
			});
			this.SkillTranslator.Add(new Class65
			{
				int_0 = 1871,
				string_0 = "Thạch Thượng Thanh Lộ-Nho Tông-Pri",
				string_1 = "Tuyệt Tình Trận - Thất Sát"
			});
			this.SkillTranslator.Add(new Class65
			{
				int_0 = 1872,
				string_0 = "Thương Tùng Bát Vân-Kiếm Tông-Pri",
				string_1 = "Súc Địa Thành Thân"
			});
			this.SkillTranslator.Add(new Class65
			{
				int_0 = 1873,
				string_0 = "Tuỳ Vụ Phiêu Linh-Kiếm Tông-Pri",
				string_1 = "Tuyệt Tình Trận - Tham Lang"
			});
			this.SkillTranslator.Add(new Class65
			{
				int_0 = 1874,
				string_0 = "Hành Vân Lưu Thuỷ-Kiếm Tông-Pri",
				string_1 = "Vạn Phúc Thần Quan"
			});
			this.SkillTranslator.Add(new Class65
			{
				int_0 = 1875,
				string_0 = "Ngũ Độc Thất Hồn Dẫn-Ma Tông-Pri",
				string_1 = "Bộ Cương Đạp Đấu"
			});
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x0000824E File Offset: 0x0000644E
		public static string AutoName
		{
			get
			{
				if (frmLogin.string_0 == "VN")
				{
					return "GAuto";
				}
				if (frmLogin.string_0 == "EN")
				{
					return "AutoTL";
				}
				return "TLBB";
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x00008283 File Offset: 0x00006483
		public static string AutoHomeURL
		{
			get
			{
				if (frmLogin.string_0 == "VN")
				{
					return "www.gameauto.net";
				}
				if (frmLogin.string_0 == "EN")
				{
					return "www.tianlongauto.net";
				}
				return "TLBB";
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x000082B8 File Offset: 0x000064B8
		public static string GameName
		{
			get
			{
				if (frmLogin.string_0 == "VN")
				{
					return "Thiên Long Bát Bộ";
				}
				if (frmLogin.string_0 == "EN")
				{
					return "Dragon Oath";
				}
				return "TLBB";
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x000082ED File Offset: 0x000064ED
		public bool IsPro1
		{
			get
			{
				return this.AppMode == Class57.Enum8.const_1;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x000082FC File Offset: 0x000064FC
		// (set) Token: 0x060006D3 RID: 1747 RVA: 0x00008304 File Offset: 0x00006504
		public Class210<string> ListItemNhat
		{
			get
			{
				return this._ListItemNhat;
			}
			set
			{
				this._ListItemNhat = value;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x0000830D File Offset: 0x0000650D
		// (set) Token: 0x060006D5 RID: 1749 RVA: 0x00008315 File Offset: 0x00006515
		public Class210<string> ListBuffPetID
		{
			get
			{
				return this._ListBuffPetID;
			}
			set
			{
				this._ListBuffPetID = value;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x0000831E File Offset: 0x0000651E
		// (set) Token: 0x060006D7 RID: 1751 RVA: 0x00008326 File Offset: 0x00006526
		public Class210<GClass2> ListLoginProfile
		{
			get
			{
				return this._ListLoginProfile;
			}
			set
			{
				this._ListLoginProfile = value;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x0000832F File Offset: 0x0000652F
		// (set) Token: 0x060006D9 RID: 1753 RVA: 0x00008337 File Offset: 0x00006537
		public Class210<string> ItemBanList
		{
			get
			{
				return this._ItemBanList;
			}
			set
			{
				this._ItemBanList = value;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x00008340 File Offset: 0x00006540
		// (set) Token: 0x060006DB RID: 1755 RVA: 0x00008348 File Offset: 0x00006548
		public Class210<string> BuffNameList
		{
			get
			{
				return this._BuffNameList;
			}
			set
			{
				this._BuffNameList = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x00008351 File Offset: 0x00006551
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x00008359 File Offset: 0x00006559
		public Class210<string> ItemTuHuyList
		{
			get
			{
				return this._ItemTuHuyList;
			}
			set
			{
				this._ItemTuHuyList = value;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x00008362 File Offset: 0x00006562
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x0009730C File Offset: 0x0009550C
		public int numDelay
		{
			get
			{
				this.numDelayTrue = this._numDelay * 100;
				return this._numDelay;
			}
			set
			{
				if (this.AllInformationLoaded && this._numDelay != value)
				{
					this.method_0("numDelay", value.ToString(), "Delay của threads", new string[0]);
				}
				this.numDelayTrue = value * 100;
				if (this.numDelayTrue == 0)
				{
					this.numDelayTrue = 50;
				}
				this._numDelay = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x00008379 File Offset: 0x00006579
		// (set) Token: 0x060006E1 RID: 1761 RVA: 0x00008381 File Offset: 0x00006581
		public string MyTest
		{
			get
			{
				return this._MyTest;
			}
			set
			{
				if (this.AllInformationLoaded && this._MyTest != value)
				{
					this.method_0("MyTest", value, "TN chuyến cuối hướng nào", new string[0]);
				}
				this._MyTest = value;
			}
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x000083B7 File Offset: 0x000065B7
		public void method_0(string string_1, string string_2, string string_3 = "", params string[] string_4)
		{
			Class161.smethod_4("gauto", string_1, string_2, string_3, string_4);
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x000083C8 File Offset: 0x000065C8
		public bool IsPro2
		{
			get
			{
				return this.AppMode2 == Class57.Enum8.const_1;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x000083D7 File Offset: 0x000065D7
		// (set) Token: 0x060006E5 RID: 1765 RVA: 0x000083DF File Offset: 0x000065DF
		public Class57.Enum8 AppMode
		{
			get
			{
				return this._appMode;
			}
			set
			{
				this._appMode = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x000083E8 File Offset: 0x000065E8
		// (set) Token: 0x060006E7 RID: 1767 RVA: 0x000083F0 File Offset: 0x000065F0
		public Class57.Enum8 AppMode2
		{
			get
			{
				return this._appMode2;
			}
			set
			{
				this._appMode2 = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x00097368 File Offset: 0x00095568
		public string NoPetName
		{
			get
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					return "Không có";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					return "No need";
				}
				return "没有";
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x000973BC File Offset: 0x000955BC
		public string GameID
		{
			get
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					return "tlbbvng";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					return "tlenglish";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
				{
					return "tlenglish";
				}
				return "tlchinese";
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x000083F9 File Offset: 0x000065F9
		public string ProxyURL
		{
			get
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					return "prx.gameauto.net";
				}
				return "";
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060006EB RID: 1771 RVA: 0x00097434 File Offset: 0x00095634
		public string FacebookURL
		{
			get
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					return "http://facebook.com/gameautopro";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					return "http://facebook.com/tianlongauto";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
				{
					return "http://facebook.com/1139173952767898";
				}
				return "tlchinese";
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x000974AC File Offset: 0x000956AC
		public string PayPalURL
		{
			get
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					return "http://www.tianlongauto.net/autotl/auto_buy.php";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
				{
					return "http://www.123bot.net/payment/auto_buy.php";
				}
				return "tlchinese";
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x00097500 File Offset: 0x00095700
		public string WhatsNewURL
		{
			get
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					return "http://server1.gameauto.net/tan-thien-long-3d-vng/cap-nhat-thong-tin-fix-loi-cac-phien-ban";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					return "http://www.tianlongauto.net";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
				{
					return "http://www.123bot.net";
				}
				return "tlchinese";
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x00008421 File Offset: 0x00006621
		public string CheckUserURL
		{
			get
			{
				if (frmLogin.string_0 == "VN")
				{
					return "payment/auto_checkuser.php";
				}
				return "tlenglish";
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x0000843F File Offset: 0x0000663F
		public string CouponURL
		{
			get
			{
				if (frmLogin.string_0 == "VN")
				{
					return "forum/auto_coupon.php";
				}
				return "tlenglish";
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x0000845D File Offset: 0x0000665D
		public string NapTheURL
		{
			get
			{
				if (frmLogin.string_0 == "VN")
				{
					return "forum/auto_chargev2_2.php";
				}
				return "tlenglish";
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x00097578 File Offset: 0x00095778
		public string GiftCodeURL
		{
			get
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					return "forum/auto_gift.php";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					return "http://www.tianlongauto.net/autotl/auto_gift.php";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
				{
					return "http://www.123bot.net/payment/auto_gift.php";
				}
				return "tlenglish";
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x0000847B File Offset: 0x0000667B
		public string ServerListURL
		{
			get
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					return "payment/auto_balance.php";
				}
				return "error";
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x000975F0 File Offset: 0x000957F0
		public string AutoInfoURL
		{
			get
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					return "payment/auto_info.php";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					return "http://www.tianlongauto.net/autotl/auto_info.php";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
				{
					return "http://www.123bot.net/payment/auto_info.php";
				}
				return "tlenglish";
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x00097668 File Offset: 0x00095868
		public string RegURL
		{
			get
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					return "http://server1.gameauto.net";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					return "http://www.tianlongauto.net/autotl/models/captcha.php";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN" && !frmLogin.bool_12)
				{
					return "http://www.123bot.net/payment/models/captcha.php";
				}
				return "tlenglish";
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x000976E4 File Offset: 0x000958E4
		public string CaptchaURL
		{
			get
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					return "payment/models/captcha.php";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					return "http://www.tianlongauto.net/autotl/auto_login_003.php";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN" && !frmLogin.bool_12)
				{
					return "http://www.123bot.net/payment/auto_login.php";
				}
				return "tlenglish";
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x00097760 File Offset: 0x00095960
		public string ChangePasswordURL
		{
			get
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					return "payment/auto_changepwd.php";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					return "http://www.tianlongauto.net/autotl/auto_login_003.php";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN" && !frmLogin.bool_12)
				{
					return "http://www.123bot.net/payment/auto_login.php";
				}
				return "tlenglish";
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x000977DC File Offset: 0x000959DC
		public string LoginNewURL
		{
			get
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					return "payment/auto_login.php";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					return "http://www.tianlongauto.net/autotl/auto_login_003.php";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN" && !frmLogin.bool_12)
				{
					return "http://www.123bot.net/payment/auto_login.php";
				}
				return "tlenglish";
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x000084A3 File Offset: 0x000066A3
		public string BlockReportURL
		{
			get
			{
				return "payment/auto_getinfo.php";
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x00097858 File Offset: 0x00095A58
		public string LoginURL
		{
			get
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					return "forum/auto_loginv2_42.php";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					return "http://www.tianlongauto.net/autotl/auto_login_003.php";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN" && !frmLogin.bool_12)
				{
					return "http://www.123bot.net/payment/auto_login.php";
				}
				return "tlenglish";
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x000978D4 File Offset: 0x00095AD4
		public string VersionsURL
		{
			get
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					return "http://update.gameauto.net/downloads/";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					return "http://server1.gameauto.net/payment/";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
				{
					return "http://update.gameauto.net/downloads/";
				}
				return "tlenglish";
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x0009794C File Offset: 0x00095B4C
		public string UsageURL
		{
			get
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					return "mod/myusagedev.php";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					return "http://www.tianlongauto.net/autotl/myusage.php";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
				{
					return "http://www.123bot.net/payment/myusage.php";
				}
				return "tlenglish";
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x000979C4 File Offset: 0x00095BC4
		public string HouseKeeperURL
		{
			get
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN" && frmLogin.int_3 <= 1)
				{
					return "payment/auto_askme.php";
				}
				if (!(frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN"))
				{
					if (frmLogin.int_3 != 2)
					{
						if (!(frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN"))
						{
							if (frmLogin.int_3 != 3)
							{
								return "tlenglish";
							}
						}
						if (!frmLogin.bool_0)
						{
							return "http://www.123bot.net/payment/auto_get001.php";
						}
						return "http://www.123bot.net/autotl/auto_getaddressv2_15.php";
					}
				}
				return "http://www.tianlongauto.net/autotl/auto_getaddressv2_15.php";
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x00097A64 File Offset: 0x00095C64
		public string GetDataURL
		{
			get
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN" && frmLogin.int_3 <= 1)
				{
					return "payment/auto_data_4.php";
				}
				if (!(frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN"))
				{
					if (frmLogin.int_3 != 2)
					{
						if (!(frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN"))
						{
							if (frmLogin.int_3 != 3)
							{
								return "tlenglish";
							}
						}
						if (!frmLogin.bool_0)
						{
							return "http://www.123bot.net/payment/auto_get001.php";
						}
						return "http://www.123bot.net/autotl/auto_getaddressv2_15.php";
					}
				}
				return "http://www.tianlongauto.net/autotl/auto_getaddressv2_15.php";
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x00097B04 File Offset: 0x00095D04
		public string GetAddressURL
		{
			get
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN" && frmLogin.int_3 <= 1)
				{
					return "forum/auto_getaddressv2_23.php";
				}
				if (!(frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN"))
				{
					if (frmLogin.int_3 != 2)
					{
						if (!(frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN"))
						{
							if (frmLogin.int_3 != 3)
							{
								return "tlenglish";
							}
						}
						if (!frmLogin.bool_0)
						{
							return "http://www.123bot.net/payment/auto_get001.php";
						}
						return "http://www.123bot.net/autotl/auto_getaddressv2_15.php";
					}
				}
				return "http://www.tianlongauto.net/autotl/auto_getaddressv2_15.php";
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x00097BA4 File Offset: 0x00095DA4
		public string MainURL2
		{
			get
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					return "http://server1.gameauto.net/|http://server2.gameauto.net/|http://gautovn.gameauto.net/|http://server3.gameauto.net/";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage != "VN")
				{
					return "http://server1.gameauto.net/|http://server2.gameauto.net/|http://server3.plaintutorials.com/";
				}
				return "error";
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x00097BF8 File Offset: 0x00095DF8
		public string MainURL
		{
			get
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					if (frmLogin.bool_12)
					{
						return "http://51.254.128.197/";
					}
					if (frmLogin.int_4 == 1)
					{
						return "http://server1.gameauto.net/";
					}
					if (frmLogin.int_4 == 2)
					{
						return "http://server2.gameauto.net/";
					}
					if (frmLogin.int_4 == 3)
					{
						return "http://www2.plaintutorials.com/";
					}
				}
				else
				{
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
					{
						return "http://www.tianlongauto.net/";
					}
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
					{
						return "http://www.123bot.net/";
					}
				}
				return "tlenglish";
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x00097CA0 File Offset: 0x00095EA0
		public string UserGuideURL
		{
			get
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					if (frmLogin.bool_12)
					{
						return "http://51.254.128.197/tan-thien-long-3d-vng/huong-dan-su-dung-gauto-tlbb-auto-thien-long-bat-bo/";
					}
					return "http://server1.gameauto.net/tan-thien-long-3d-vng/huong-dan-su-dung-gauto-tlbb-auto-thien-long-bat-bo/";
				}
				else
				{
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
					{
						return "http://www.tianlongauto.net/how-to-use";
					}
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
					{
						return "http://www.123bot.net/how-to-use";
					}
					return "tnchinese";
				}
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x00097D24 File Offset: 0x00095F24
		public string RegistrationGuideURL
		{
			get
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					if (frmLogin.bool_12)
					{
						return "http://51.254.128.197/?p=36";
					}
					return "http://server1.gameauto.net/?p=36";
				}
				else
				{
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
					{
						return "http://www.tianlongauto.net/howto-register";
					}
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
					{
						return "http://www.123bot.net/howto-register";
					}
					return "tnchinese";
				}
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x00097DA8 File Offset: 0x00095FA8
		public string ForumURL
		{
			get
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					return "http://server1.gameauto.net/forum/index.php";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					return "http://www.tianlongauto.net";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					return "http://www.123bot.net/forum";
				}
				return "tnchinese";
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x00097E20 File Offset: 0x00096020
		public string ForgotPassURL
		{
			get
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					return "payment/quenmk.php";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					return "http://www.tianlongauto.net/autotl/forgot-password.php";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
				{
					return "http://www.123bot.net/payment/auto_forgot.php";
				}
				return "tlchinese";
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x00097E98 File Offset: 0x00096098
		public string RegisterAccountURL
		{
			get
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					return "forum/ucp.php?mode=register";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					return "http://www.tianlongauto.net/autotl/register.php";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
				{
					return "http://www.123bot.net/payment/auto_reg.php";
				}
				return "tlchinese";
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x00097F10 File Offset: 0x00096110
		public string TermsURL
		{
			get
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					return "http://gameauto.net/dieu-khoan-su-dung-gauto-tlbb/";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					return "http://tianlongauto.net/term-of-service/";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
				{
					return "http://123bot.net/term-of-service/";
				}
				return "tlenglish";
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x00097F88 File Offset: 0x00096188
		public string MainDB
		{
			get
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					return "TLBB.db";
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					return "TLBBUS.db";
				}
				frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN";
				return "TLBBCN.db";
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x000084AA File Offset: 0x000066AA
		// (set) Token: 0x06000709 RID: 1801 RVA: 0x000084B2 File Offset: 0x000066B2
		public bool DanhHieuOnOff
		{
			get
			{
				return this._DanhHieuOnOff;
			}
			set
			{
				if (this.AllInformationLoaded && this._DanhHieuOnOff != value)
				{
					this.method_0("DanhHieuOnOff", value.ToString(), "Bật tắt tên và danh hiệu", new string[0]);
				}
				this._DanhHieuOnOff = value;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x000084E9 File Offset: 0x000066E9
		// (set) Token: 0x0600070B RID: 1803 RVA: 0x000084F1 File Offset: 0x000066F1
		public string ExeFilePath
		{
			get
			{
				return this._ExeFilePath;
			}
			set
			{
				if (this.AllInformationLoaded && this._ExeFilePath != value)
				{
					this.method_0("ExeFilePath", value.ToString(), "File game exe", new string[0]);
				}
				this._ExeFilePath = value;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x0000852C File Offset: 0x0000672C
		// (set) Token: 0x0600070D RID: 1805 RVA: 0x00008534 File Offset: 0x00006734
		public bool cboxNoKS
		{
			get
			{
				return this._cboxNoKS;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxNoKS != value)
				{
					this.method_0("cboxNoKS", value.ToString(), "Chống KS quái", new string[0]);
				}
				this._cboxNoKS = value;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x0000856B File Offset: 0x0000676B
		// (set) Token: 0x0600070F RID: 1807 RVA: 0x00008573 File Offset: 0x00006773
		public bool optKinhMachNghichHanh
		{
			get
			{
				return this._optKinhMachNghichHanh;
			}
			set
			{
				if (this.AllInformationLoaded && this._optKinhMachNghichHanh != value)
				{
					this.method_0("optKinhMachNghichHanh", value.ToString(), "Dùng KMNH hay không", new string[0]);
				}
				this._optKinhMachNghichHanh = value;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x000085AA File Offset: 0x000067AA
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x000085B2 File Offset: 0x000067B2
		public bool optPhuBanKeoDoi
		{
			get
			{
				return this._optPhuBanKeoDoi;
			}
			set
			{
				if (this.AllInformationLoaded && this._optPhuBanKeoDoi != value)
				{
					this.method_0("optPhuBanKeoDoi", value.ToString(), "Kéo đội phụ bản", new string[0]);
				}
				this._optPhuBanKeoDoi = value;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x000085E9 File Offset: 0x000067E9
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x000085F1 File Offset: 0x000067F1
		public bool optSuDungF1
		{
			get
			{
				return this._optSuDungF1;
			}
			set
			{
				if (this.AllInformationLoaded && this._optSuDungF1 != value)
				{
					this.method_0("optSuDungF1", value.ToString(), "Kéo đội phụ bản", new string[0]);
				}
				this._optSuDungF1 = value;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x00008628 File Offset: 0x00006828
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x00008630 File Offset: 0x00006830
		public bool optArrangeSkillByName
		{
			get
			{
				return this._optArrangeSkillByName;
			}
			set
			{
				if (this.AllInformationLoaded && this._optArrangeSkillByName != value)
				{
					this.method_0("optArrangeSkillByName", value.ToString(), "Xếp skill theo tên skill", new string[0]);
				}
				this._optArrangeSkillByName = value;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x00008667 File Offset: 0x00006867
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x0000866F File Offset: 0x0000686F
		public bool cboxAgreement
		{
			get
			{
				return this._cboxAgreement;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxAgreement != value)
				{
					this.method_0("cboxAgreement", value.ToString(), "Agreement cho phần profile", new string[0]);
				}
				this._cboxAgreement = value;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x000086A6 File Offset: 0x000068A6
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x000086AE File Offset: 0x000068AE
		public int optLoginCungLuc
		{
			get
			{
				return this._optLoginCungLuc;
			}
			set
			{
				if (this.AllInformationLoaded && this._optLoginCungLuc != value)
				{
					this.method_0("optLoginCungLuc", value.ToString(), "Login cùng lúc", new string[0]);
				}
				this._optLoginCungLuc = value;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x000086E5 File Offset: 0x000068E5
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x000086ED File Offset: 0x000068ED
		public bool optStartNewGame
		{
			get
			{
				return this._optStartNewGame;
			}
			set
			{
				if (this.AllInformationLoaded && this._optStartNewGame != value)
				{
					this.method_0("optStartNewGame", value.ToString(), "Nhìn gì...", new string[0]);
				}
				this._optStartNewGame = value;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x00008724 File Offset: 0x00006924
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x0000872C File Offset: 0x0000692C
		public bool optNoSkillLag
		{
			get
			{
				return this._optNoSkillLag;
			}
			set
			{
				if (this.AllInformationLoaded && this._optNoSkillLag != value)
				{
					this.method_0("optNoSkillLag", value.ToString(), "Nhìn gì...", new string[0]);
				}
				this._optNoSkillLag = value;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00008763 File Offset: 0x00006963
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x0000876B File Offset: 0x0000696B
		public bool optGomQuai2
		{
			get
			{
				return this._optGomQuai2;
			}
			set
			{
				if (this.AllInformationLoaded && this._optGomQuai2 != value)
				{
					this.method_0("optGomQuai2", value.ToString(), "Nhìn gì...", new string[0]);
				}
				this._optGomQuai2 = value;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x000087A2 File Offset: 0x000069A2
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x000087AA File Offset: 0x000069AA
		public long TimeGiaiDoHoa
		{
			get
			{
				return this._TimeGiaiDoHoa;
			}
			set
			{
				if (this.AllInformationLoaded && this._TimeGiaiDoHoa != value)
				{
					this.method_0("TimeGiaiDoHoa", value.ToString(), "Nhìn gì...", new string[0]);
				}
				this._TimeGiaiDoHoa = value;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x000087E1 File Offset: 0x000069E1
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x000087E9 File Offset: 0x000069E9
		public bool optChangeTargetFast
		{
			get
			{
				return this._optChangeTargetFast;
			}
			set
			{
				if (this.AllInformationLoaded && this._optChangeTargetFast != value)
				{
					this.method_0("optChangeTargetFast", value.ToString(), "Nhìn gì...", new string[0]);
				}
				this._optChangeTargetFast = value;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x00008820 File Offset: 0x00006A20
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x00008828 File Offset: 0x00006A28
		public int soVongQHoa
		{
			get
			{
				return this._soVongQHoa;
			}
			set
			{
				if (this.AllInformationLoaded && this._soVongQHoa != value)
				{
					this.method_0("soVongQHoa", value.ToString(), "Nhìn gì...", new string[0]);
				}
				this._soVongQHoa = value;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x0000885F File Offset: 0x00006A5F
		// (set) Token: 0x06000727 RID: 1831 RVA: 0x00008867 File Offset: 0x00006A67
		public int soHangTrongHoa
		{
			get
			{
				return this._soHangTrongHoa;
			}
			set
			{
				if (this.AllInformationLoaded && this._soHangTrongHoa != value)
				{
					this.method_0("soHangTrongHoa", value.ToString(), "Nhìn gì...", new string[0]);
				}
				this._soHangTrongHoa = value;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x0000889E File Offset: 0x00006A9E
		// (set) Token: 0x06000729 RID: 1833 RVA: 0x000088A6 File Offset: 0x00006AA6
		public int soVongQSM
		{
			get
			{
				return this._soVongQSM;
			}
			set
			{
				if (this.AllInformationLoaded && this._soVongQSM != value)
				{
					this.method_0("soVongQSM", value.ToString(), "Nhìn gì...", new string[0]);
				}
				this._soVongQSM = value;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x000088DD File Offset: 0x00006ADD
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x000088E5 File Offset: 0x00006AE5
		public bool cboxATRunPP
		{
			get
			{
				return this._cboxATRunPP;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxATRunPP != value)
				{
					this.method_0("cboxATRunPP", value.ToString(), "Nhìn gì...", new string[0]);
				}
				this._cboxATRunPP = value;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x0000891C File Offset: 0x00006B1C
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x00008924 File Offset: 0x00006B24
		public bool TipHuongDan
		{
			get
			{
				return this._TipHuongDan;
			}
			set
			{
				if (this.AllInformationLoaded && this._TipHuongDan != value)
				{
					this.method_0("TipHuongDan", value.ToString(), "Nhìn gì...", new string[0]);
				}
				this._TipHuongDan = value;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x0000895B File Offset: 0x00006B5B
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x00008963 File Offset: 0x00006B63
		public bool cboxNMBuffSelectTarget
		{
			get
			{
				return this._cboxNMBuffSelectTarget;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxNMBuffSelectTarget != value)
				{
					this.method_0("cboxNMBuffSelectTarget", value.ToString(), "Nhìn gì...", new string[0]);
				}
				this._cboxNMBuffSelectTarget = value;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x0000899A File Offset: 0x00006B9A
		// (set) Token: 0x06000731 RID: 1841 RVA: 0x000089A2 File Offset: 0x00006BA2
		public bool LamNheAuto
		{
			get
			{
				return this._LamNheAuto;
			}
			set
			{
				if (this.AllInformationLoaded && this._LamNheAuto != value)
				{
					this.method_0("LamNheAuto", value.ToString(), "Nhìn gì...", new string[0]);
				}
				this._LamNheAuto = value;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x000089D9 File Offset: 0x00006BD9
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x000089E1 File Offset: 0x00006BE1
		public bool DongYPhuDoi
		{
			get
			{
				return this._DongYPhuDoi;
			}
			set
			{
				if (this.AllInformationLoaded && this._DongYPhuDoi != value)
				{
					this.method_0("DongYPhuDoi", value.ToString(), "", new string[0]);
				}
				this._DongYPhuDoi = value;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x00008A18 File Offset: 0x00006C18
		// (set) Token: 0x06000735 RID: 1845 RVA: 0x00008A20 File Offset: 0x00006C20
		public bool TuKetNoiLai
		{
			get
			{
				return this._TuKetNoiLai;
			}
			set
			{
				if (this.AllInformationLoaded && this._TuKetNoiLai != value)
				{
					this.method_0("TuKetNoiLai", value.ToString(), "", new string[0]);
				}
				this._TuKetNoiLai = value;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x00008A57 File Offset: 0x00006C57
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x00008A5F File Offset: 0x00006C5F
		public bool TuMuaCKH
		{
			get
			{
				return this._TuMuaCKH;
			}
			set
			{
				if (this.AllInformationLoaded && this._TuMuaCKH != value)
				{
					this.method_0("TuMuaCKH", value.ToString(), "", new string[0]);
				}
				this._TuMuaCKH = value;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x00008A96 File Offset: 0x00006C96
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x00008A9E File Offset: 0x00006C9E
		public bool TuThoatGameDis
		{
			get
			{
				return this._TuThoatGameDis;
			}
			set
			{
				if (this.AllInformationLoaded && this._TuThoatGameDis != value)
				{
					this.method_0("TuThoatGameDis", value.ToString(), "", new string[0]);
				}
				this._TuThoatGameDis = value;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x00008AD5 File Offset: 0x00006CD5
		// (set) Token: 0x0600073B RID: 1851 RVA: 0x00008ADD File Offset: 0x00006CDD
		public bool TuDongYChuyenCanh
		{
			get
			{
				return this._TuDongYChuyenCanh;
			}
			set
			{
				if (this.AllInformationLoaded && this._TuDongYChuyenCanh != value)
				{
					this.method_0("TuDongYChuyenCanh", value.ToString(), "", new string[0]);
				}
				this._TuDongYChuyenCanh = value;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x00008B14 File Offset: 0x00006D14
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x00008B1C File Offset: 0x00006D1C
		public string cboCDExtend
		{
			get
			{
				return this._cboCDExtend;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboCDExtend != value)
				{
					this.method_0("cboCDExtend", value.ToString(), "", new string[0]);
				}
				this._cboCDExtend = value;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x00008B57 File Offset: 0x00006D57
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x00008B5F File Offset: 0x00006D5F
		public bool cboxNoLoginGame
		{
			get
			{
				return this._cboxNoLoginGame;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxNoLoginGame != value)
				{
					this.method_0("cboxNoLoginGame", value.ToString(), "", new string[0]);
				}
				this._cboxNoLoginGame = value;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x00008B96 File Offset: 0x00006D96
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x00008B9E File Offset: 0x00006D9E
		public bool MonPhaiTLC
		{
			get
			{
				return this._MonPhaiTLC;
			}
			set
			{
				if (this.AllInformationLoaded && this._MonPhaiTLC != value)
				{
					this.method_0("MonPhaiTLC", value.ToString(), "Nhìn gì...", new string[0]);
				}
				this._MonPhaiTLC = value;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x00008BD5 File Offset: 0x00006DD5
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x00008BDD File Offset: 0x00006DDD
		public bool cboxResetOutGame
		{
			get
			{
				return this._cboxResetOutGame;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxResetOutGame != value)
				{
					this.method_0("cboxResetOutGame", value.ToString(), "", new string[0]);
				}
				this._cboxResetOutGame = value;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x00008C14 File Offset: 0x00006E14
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x00008C1C File Offset: 0x00006E1C
		public int tbDelayLogin
		{
			get
			{
				return this._tbDelayLogin;
			}
			set
			{
				if (this.AllInformationLoaded && this._tbDelayLogin != value)
				{
					this.method_0("tbDelayLogin", value.ToString(), "Nhìn gì...", new string[0]);
				}
				this._tbDelayLogin = value;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00008C53 File Offset: 0x00006E53
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x00008C5B File Offset: 0x00006E5B
		public int tbDelayOutGame
		{
			get
			{
				return this._tbDelayOutGame;
			}
			set
			{
				if (this.AllInformationLoaded && this._tbDelayOutGame != value)
				{
					this.method_0("tbDelayOutGame", value.ToString(), "Nhìn gì...", new string[0]);
				}
				this._tbDelayOutGame = value;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x00008C92 File Offset: 0x00006E92
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x00008C9A File Offset: 0x00006E9A
		public int tbDelayNhanGameSom
		{
			get
			{
				return this._tbDelayNhanGameSom;
			}
			set
			{
				if (this.AllInformationLoaded && this._tbDelayNhanGameSom != value)
				{
					this.method_0("tbDelayNhanGameSom", value.ToString(), "Nhìn gì...", new string[0]);
				}
				this._tbDelayNhanGameSom = value;
			}
		}

		// Token: 0x040004A4 RID: 1188
		public static string string_0 = "versions.txt";

		// Token: 0x040004A5 RID: 1189
		public List<Class65> SkillTranslator = new List<Class65>();

		// Token: 0x040004A6 RID: 1190
		public List<Class209> AESKeysets = new List<Class209>();

		// Token: 0x040004A7 RID: 1191
		public string CompilingLanguage = frmLogin.string_0;

		// Token: 0x040004A8 RID: 1192
		public string CompilingCurrency = "USD";

		// Token: 0x040004A9 RID: 1193
		public Dictionary<string, int> BangGia = new Dictionary<string, int>();

		// Token: 0x040004AA RID: 1194
		private Class210<string> _ListItemNhat = frmLogin.Class210_3;

		// Token: 0x040004AB RID: 1195
		private Class210<string> _ListBuffPetID = new Class210<string>();

		// Token: 0x040004AC RID: 1196
		private Class210<GClass2> _ListLoginProfile = new Class210<GClass2>();

		// Token: 0x040004AD RID: 1197
		public List<int> AOEPetSkills = new List<int>
		{
			742,
			743,
			744,
			745,
			747,
			672,
			673,
			674,
			675,
			676,
			677,
			678,
			679,
			680,
			681
		};

		// Token: 0x040004AE RID: 1198
		public List<int> AOEBuffSkills = new List<int>
		{
			696,
			697,
			686,
			687
		};

		// Token: 0x040004AF RID: 1199
		private Class210<string> _ItemBanList = frmLogin.Class210_0;

		// Token: 0x040004B0 RID: 1200
		private Class210<string> _BuffNameList = new Class210<string>();

		// Token: 0x040004B1 RID: 1201
		private Class210<string> _ItemTuHuyList = frmLogin.Class210_1;

		// Token: 0x040004B2 RID: 1202
		private int _numDelay = 2;

		// Token: 0x040004B3 RID: 1203
		public int numDelayTrue;

		// Token: 0x040004B4 RID: 1204
		private string _MyTest = "";

		// Token: 0x040004B5 RID: 1205
		public bool AllInformationLoaded;

		// Token: 0x040004B6 RID: 1206
		public List<int> QXDCTMapID = new List<int>
		{
			36,
			37,
			38,
			39,
			40,
			41,
			42,
			43,
			44,
			45,
			46,
			47,
			48,
			49
		};

		// Token: 0x040004B7 RID: 1207
		public List<Class62> SavedAIStatus = new List<Class62>();

		// Token: 0x040004B8 RID: 1208
		public List<int> ItemNotRemove = new List<int>
		{
			30008002,
			30008117,
			30008130,
			38000654,
			30008127,
			30008028,
			30008003,
			30008015,
			30008016,
			30504784,
			30504785,
			30504786,
			30504787,
			30008082,
			30008083,
			30008084,
			30008085,
			30008086,
			10155002
		};

		// Token: 0x040004B9 RID: 1209
		private Class57.Enum8 _appMode = Class57.Enum8.const_0;

		// Token: 0x040004BA RID: 1210
		public List<Class100> SampleScript = new List<Class100>();

		// Token: 0x040004BB RID: 1211
		public List<int> ProcessList = new List<int>();

		// Token: 0x040004BC RID: 1212
		public List<Class128> ProcessListIgnored = new List<Class128>();

		// Token: 0x040004BD RID: 1213
		public List<Class99> CharInfoBriefBases = new List<Class99>();

		// Token: 0x040004BE RID: 1214
		public List<Class99> AutoVersions = new List<Class99>();

		// Token: 0x040004BF RID: 1215
		public List<Class99> MultiAccPatches = new List<Class99>();

		// Token: 0x040004C0 RID: 1216
		private Class57.Enum8 _appMode2 = Class57.Enum8.const_0;

		// Token: 0x040004C1 RID: 1217
		public List<int> MenpaiBasicSkills = new List<int>
		{
			0,
			281,
			311,
			341,
			371,
			401,
			431,
			461,
			491,
			521,
			760,
			2900
		};

		// Token: 0x040004C2 RID: 1218
		public List<Class106> ListItemToBuy = new List<Class106>();

		// Token: 0x040004C3 RID: 1219
		public string BaseDllName = "tinydll.dll";

		// Token: 0x040004C4 RID: 1220
		public string TempPath = Path.GetTempPath();

		// Token: 0x040004C5 RID: 1221
		public int ActionDelay = 1000;

		// Token: 0x040004C6 RID: 1222
		public int ReadInfoDelay = 300;

		// Token: 0x040004C7 RID: 1223
		public int EnumProcessDelay = 500;

		// Token: 0x040004C8 RID: 1224
		public int EnumListViewDelay = 500;

		// Token: 0x040004C9 RID: 1225
		public long EnumListViewTimeStamp;

		// Token: 0x040004CA RID: 1226
		public long ModeCheckTimeStamp;

		// Token: 0x040004CB RID: 1227
		public int ModeCheckDelay = 1800000;

		// Token: 0x040004CC RID: 1228
		public List<byte> CheDoPrices = new List<byte>
		{
			5,
			7,
			9,
			5,
			7,
			9,
			5,
			7,
			9,
			5,
			7,
			9
		};

		// Token: 0x040004CD RID: 1229
		public long EnumProcessTimeStamp;

		// Token: 0x040004CE RID: 1230
		public string LogFilePath = AppDomain.CurrentDomain.BaseDirectory + "log\\support.log";

		// Token: 0x040004CF RID: 1231
		public int LogFileMaxSize = 5;

		// Token: 0x040004D0 RID: 1232
		public Dictionary<string, string> LoginInfo = new Dictionary<string, string>();

		// Token: 0x040004D1 RID: 1233
		public string NoSkillName = "Tên skill";

		// Token: 0x040004D2 RID: 1234
		public string TabKyNangName = "tabKyNang";

		// Token: 0x040004D3 RID: 1235
		public string TabPhucHoiPetName = "tabPhucHoiPet";

		// Token: 0x040004D4 RID: 1236
		public string TabTienIchName = "tabTienIch";

		// Token: 0x040004D5 RID: 1237
		public string TabVatPhamName = "tabVatPham";

		// Token: 0x040004D6 RID: 1238
		public string tabCoBanName = "tabCoBan";

		// Token: 0x040004D7 RID: 1239
		public string tabDebugName = "tabDebug";

		// Token: 0x040004D8 RID: 1240
		public string tabDebugBocName = "tabDebugBoc";

		// Token: 0x040004D9 RID: 1241
		public string TabChatName = "tabChatName";

		// Token: 0x040004DA RID: 1242
		public byte releaseHPPercent;

		// Token: 0x040004DB RID: 1243
		public int HookCount;

		// Token: 0x040004DC RID: 1244
		public uint WM_SELECTTARGET = Class159.RegisterWindowMessage("WM_SELECTTARGET");

		// Token: 0x040004DD RID: 1245
		public uint WM_PSEUDOCODE = Class159.RegisterWindowMessage("WM_PSEUDOCODE");

		// Token: 0x040004DE RID: 1246
		public uint WM_TITLECHANGE = Class159.RegisterWindowMessage("WM_TITLECHANGE");

		// Token: 0x040004DF RID: 1247
		public uint WM_TESTMEM = Class159.RegisterWindowMessage("WM_TESTMEM");

		// Token: 0x040004E0 RID: 1248
		public uint WM_REMOVEDLL = Class159.RegisterWindowMessage("WM_REMOVEDLL");

		// Token: 0x040004E1 RID: 1249
		public uint WM_DUAHAUCONFIRM = Class159.RegisterWindowMessage("WM_DUAHAUCONFIRM");

		// Token: 0x040004E2 RID: 1250
		public uint WM_SEQUENCE = Class159.RegisterWindowMessage("WM_SEQUENCE");

		// Token: 0x040004E3 RID: 1251
		public uint WM_HOISINH = Class159.RegisterWindowMessage("WM_HOISINH");

		// Token: 0x040004E4 RID: 1252
		public uint WM_THOATXAC = Class159.RegisterWindowMessage("WM_THOATXAC");

		// Token: 0x040004E5 RID: 1253
		public uint WM_OKPARTYFOLLOW = Class159.RegisterWindowMessage("WM_OKPARTYFOLLOW");

		// Token: 0x040004E6 RID: 1254
		public uint WM_ASKPARTYFOLLOW = Class159.RegisterWindowMessage("WM_ASKPARTYFOLLOW");

		// Token: 0x040004E7 RID: 1255
		public uint WM_ACCEPTPTINVITE = Class159.RegisterWindowMessage("WM_ACCEPTPTINVITE");

		// Token: 0x040004E8 RID: 1256
		public uint WM_CLOSECONFIRMBOX = Class159.RegisterWindowMessage("WM_CLOSECONFIRMBOX");

		// Token: 0x040004E9 RID: 1257
		public uint WM_CLOSECONFIRMBOX_1 = Class159.RegisterWindowMessage("WM_CLOSECONFIRMBOX_1");

		// Token: 0x040004EA RID: 1258
		public uint WM_SELECTTARGETOF = Class159.RegisterWindowMessage("WM_SELECTTARGETOF");

		// Token: 0x040004EB RID: 1259
		public uint WM_TUYENCHIEN = Class159.RegisterWindowMessage("WM_TUYENCHIEN");

		// Token: 0x040004EC RID: 1260
		public uint WM_REMOVEPARTYFOLLOW = Class159.RegisterWindowMessage("WM_REMOVEPARTYFOLLOW");

		// Token: 0x040004ED RID: 1261
		public uint WM_DENYPTINVITE = Class159.RegisterWindowMessage("WM_DENYPTINVITE");

		// Token: 0x040004EE RID: 1262
		public uint WM_REMOVEINVITE = Class159.RegisterWindowMessage("WM_REMOVEINVITE");

		// Token: 0x040004EF RID: 1263
		public uint WM_INVITEPARTY = Class159.RegisterWindowMessage("WM_INVITEPARTY");

		// Token: 0x040004F0 RID: 1264
		public uint WM_OUTGAME = Class159.RegisterWindowMessage("WM_OUTGAME");

		// Token: 0x040004F1 RID: 1265
		public uint WM_CONSOLE = Class159.RegisterWindowMessage("WM_CONSOLE");

		// Token: 0x040004F2 RID: 1266
		public uint WM_STARTTHREAD = Class159.RegisterWindowMessage("WM_STARTTHREAD");

		// Token: 0x040004F3 RID: 1267
		public uint WM_READMEMORY = Class159.RegisterWindowMessage("WM_READMEMORY");

		// Token: 0x040004F4 RID: 1268
		public uint WM_CALLFUNCTION = Class159.RegisterWindowMessage("WM_CALLFUNCTION");

		// Token: 0x040004F5 RID: 1269
		public uint WM_ENTERRECONNECT = Class159.RegisterWindowMessage("WM_ENTERRECONNECT");

		// Token: 0x040004F6 RID: 1270
		public uint WM_DISCONNECT = Class159.RegisterWindowMessage("WM_DISCONNECT");

		// Token: 0x040004F7 RID: 1271
		public uint WM_CALLMOVETO = Class159.RegisterWindowMessage("WM_CALLMOVETO");

		// Token: 0x040004F8 RID: 1272
		public uint WM_ATTACKTARGET = Class159.RegisterWindowMessage("WM_ATTACKTARGET");

		// Token: 0x040004F9 RID: 1273
		public uint WM_INVENTORYDETAIL = Class159.RegisterWindowMessage("WM_INVENTORYDETAIL");

		// Token: 0x040004FA RID: 1274
		public uint WM_REMOVEINVENTORYITEM = Class159.RegisterWindowMessage("WM_REMOVEINVENTORYITEM");

		// Token: 0x040004FB RID: 1275
		public uint WM_REMOVEINVENTORYITEM_1 = Class159.RegisterWindowMessage("WM_REMOVEINVENTORYITEM_1");

		// Token: 0x040004FC RID: 1276
		public uint WM_NPCSELLITEM = Class159.RegisterWindowMessage("WM_NPCSELLITEM");

		// Token: 0x040004FD RID: 1277
		public uint WM_PETXUATCHIEN = Class159.RegisterWindowMessage("WM_PETXUATCHIEN");

		// Token: 0x040004FE RID: 1278
		public uint WM_ATTACKTARGETPACKET = Class159.RegisterWindowMessage("WM_ATTACKTARGETPACKET");

		// Token: 0x040004FF RID: 1279
		public uint WM_ATTACKTARGETPACKET_1 = Class159.RegisterWindowMessage("WM_ATTACKTARGETPACKET_1");

		// Token: 0x04000500 RID: 1280
		public uint WM_ATTACKTARGETPACKET_2 = Class159.RegisterWindowMessage("WM_ATTACKTARGETPACKET_2");

		// Token: 0x04000501 RID: 1281
		public uint WM_TALKNPC = Class159.RegisterWindowMessage("WM_TALKNPC");

		// Token: 0x04000502 RID: 1282
		public uint WM_TALKNPC_1 = Class159.RegisterWindowMessage("WM_TALKNPC_1");

		// Token: 0x04000503 RID: 1283
		public uint WM_BUYITEM = Class159.RegisterWindowMessage("WM_BUYITEM");

		// Token: 0x04000504 RID: 1284
		public uint WM_BUYITEM_1 = Class159.RegisterWindowMessage("WM_BUYITEM_1");

		// Token: 0x04000505 RID: 1285
		public uint WM_REMOVELOCK = Class159.RegisterWindowMessage("WM_REMOVELOCK");

		// Token: 0x04000506 RID: 1286
		public uint WM_SETLOCK = Class159.RegisterWindowMessage("WM_SETLOCK");

		// Token: 0x04000507 RID: 1287
		public uint WM_AUTOMOVE = Class159.RegisterWindowMessage("WM_AUTOMOVE");

		// Token: 0x04000508 RID: 1288
		public uint WM_AUTOMOVE_1 = Class159.RegisterWindowMessage("WM_AUTOMOVE_1");

		// Token: 0x04000509 RID: 1289
		public uint WM_STARTAUTOMOVE = Class159.RegisterWindowMessage("WM_STARTAUTOMOVE");

		// Token: 0x0400050A RID: 1290
		public uint WM_STARTPOTALMOVE = Class159.RegisterWindowMessage("WM_STARTPOTALMOVE");

		// Token: 0x0400050B RID: 1291
		public uint WM_UPLEVEL = Class159.RegisterWindowMessage("WM_UPLEVEL");

		// Token: 0x0400050C RID: 1292
		public uint WM_USEITEM = Class159.RegisterWindowMessage("WM_USEITEM");

		// Token: 0x0400050D RID: 1293
		public uint WM_USEITEM_1 = Class159.RegisterWindowMessage("WM_USEITEM_1");

		// Token: 0x0400050E RID: 1294
		public uint WM_USEITEM_2 = Class159.RegisterWindowMessage("WM_USEITEM_2");

		// Token: 0x0400050F RID: 1295
		public uint WM_USEITEM_3 = Class159.RegisterWindowMessage("WM_USEITEM_3");

		// Token: 0x04000510 RID: 1296
		public uint WM_USEITEM_4 = Class159.RegisterWindowMessage("WM_USEITEM_4");

		// Token: 0x04000511 RID: 1297
		public uint WM_THOCBOC = Class159.RegisterWindowMessage("WM_THOCBOC");

		// Token: 0x04000512 RID: 1298
		public uint WM_PICKITEM = Class159.RegisterWindowMessage("WM_PICKITEM");

		// Token: 0x04000513 RID: 1299
		public uint WM_PICKITEM_1 = Class159.RegisterWindowMessage("WM_PICKITEM_1");

		// Token: 0x04000514 RID: 1300
		public uint WM_UNLOAD = Class159.RegisterWindowMessage("WM_UNLOAD");

		// Token: 0x04000515 RID: 1301
		public uint WM_CLEARBOC = Class159.RegisterWindowMessage("WM_CLEARBOC");

		// Token: 0x04000516 RID: 1302
		public uint WM_RESETQUAI = Class159.RegisterWindowMessage("WM_RESETQUAI");

		// Token: 0x04000517 RID: 1303
		public uint WM_ATTACKTARGET_1 = Class159.RegisterWindowMessage("WM_ATTACKTARGET_1");

		// Token: 0x04000518 RID: 1304
		public uint WM_ATTACKTARGET_2 = Class159.RegisterWindowMessage("WM_ATTACKTARGET_2");

		// Token: 0x04000519 RID: 1305
		public uint WM_NPCSELLITEM_1 = Class159.RegisterWindowMessage("WM_NPCSELLITEM_1");

		// Token: 0x0400051A RID: 1306
		public uint WM_NPCSELLITEM_2 = Class159.RegisterWindowMessage("WM_NPCSELLITEM_2");

		// Token: 0x0400051B RID: 1307
		public uint WM_CONTROLMSG = Class159.RegisterWindowMessage("WM_CONTROLMSG");

		// Token: 0x0400051C RID: 1308
		public uint WM_SIGNALMSG = Class159.RegisterWindowMessage("WM_SIGNALMSG");

		// Token: 0x0400051D RID: 1309
		public uint WM_HIDEGAME = Class159.RegisterWindowMessage("WM_HIDEGAME");

		// Token: 0x0400051E RID: 1310
		public uint WM_SAVEHANDLE = Class159.RegisterWindowMessage("WM_SAVEHANDLE");

		// Token: 0x0400051F RID: 1311
		public uint WM_SENDCHAT = Class159.RegisterWindowMessage("WM_SENDCHAT");

		// Token: 0x04000520 RID: 1312
		public uint WM_SENDCHATID = Class159.RegisterWindowMessage("WM_SENDCHATID");

		// Token: 0x04000521 RID: 1313
		public uint WM_PORTALCONFIRM_1 = Class159.RegisterWindowMessage("WM_PORTALCONFIRM_1");

		// Token: 0x04000522 RID: 1314
		public uint WM_TNSELLITEM = Class159.RegisterWindowMessage("WM_TNSELLITEM");

		// Token: 0x04000523 RID: 1315
		public uint WM_TNBUYITEM = Class159.RegisterWindowMessage("WM_TNBUYITEM");

		// Token: 0x04000524 RID: 1316
		public uint WM_PICKALLITEMS = Class159.RegisterWindowMessage("WM_PICKALLITEMS");

		// Token: 0x04000525 RID: 1317
		public uint WM_CALLMOVEFLASHPOS = Class159.RegisterWindowMessage("WM_CALLMOVEFLASHPOS");

		// Token: 0x04000526 RID: 1318
		public uint WM_PETCARE = Class159.RegisterWindowMessage("WM_PETCARE");

		// Token: 0x04000527 RID: 1319
		public uint WM_PICKKSCOLOR = Class159.RegisterWindowMessage("WM_PICKKSCOLOR");

		// Token: 0x04000528 RID: 1320
		public uint WM_PHATTEST = Class159.RegisterWindowMessage("WM_PHATTEST");

		// Token: 0x04000529 RID: 1321
		public uint WM_PHATTEST2 = Class159.RegisterWindowMessage("WM_PHATTEST2");

		// Token: 0x0400052A RID: 1322
		public uint WM_PHATTEST3 = Class159.RegisterWindowMessage("WM_PHATTEST3");

		// Token: 0x0400052B RID: 1323
		public uint WM_GETQUAIID = Class159.RegisterWindowMessage("WM_GETQUAIID");

		// Token: 0x0400052C RID: 1324
		public uint WM_PASSCAP2 = Class159.RegisterWindowMessage("WM_PASSCAP2");

		// Token: 0x0400052D RID: 1325
		public uint WM_BRINGMEUP = Class159.RegisterWindowMessage("WM_BRINGMEUP");

		// Token: 0x0400052E RID: 1326
		public uint WM_SETATTACKERID = Class159.RegisterWindowMessage("WM_SETATTACKERID");

		// Token: 0x0400052F RID: 1327
		public uint WM_TRUNGAC = Class159.RegisterWindowMessage("WM_TRUNGAC");

		// Token: 0x04000530 RID: 1328
		public uint WM_RESETNHIEMVU = Class159.RegisterWindowMessage("WM_RESETNHIEMVU");

		// Token: 0x04000531 RID: 1329
		public uint WM_SETKNB = Class159.RegisterWindowMessage("WM_SETKNB");

		// Token: 0x04000532 RID: 1330
		public uint WM_TOGGLEMISSION = Class159.RegisterWindowMessage("WM_TOGGLEMISSION");

		// Token: 0x04000533 RID: 1331
		public uint WM_ALLOWPTJOIN = Class159.RegisterWindowMessage("WM_ALLOWPTJOIN");

		// Token: 0x04000534 RID: 1332
		public uint WM_SETDELAY = Class159.RegisterWindowMessage("WM_SETDELAY");

		// Token: 0x04000535 RID: 1333
		public uint WM_THOCBOCPACKET = Class159.RegisterWindowMessage("WM_THOCBOCPACKET");

		// Token: 0x04000536 RID: 1334
		public uint WM_TITLEONOFF = Class159.RegisterWindowMessage("WM_TITLEONOFF");

		// Token: 0x04000537 RID: 1335
		public uint WM_THUPET = Class159.RegisterWindowMessage("WM_THUPET");

		// Token: 0x04000538 RID: 1336
		public uint WM_UPDATEHOTKEY = Class159.RegisterWindowMessage("WM_UPDATEHOTKEY");

		// Token: 0x04000539 RID: 1337
		public uint WM_RESETRING = Class159.RegisterWindowMessage("WM_RESETRING");

		// Token: 0x0400053A RID: 1338
		public uint WM_SPLITITEM = Class159.RegisterWindowMessage("WM_SPLITITEM");

		// Token: 0x0400053B RID: 1339
		public uint WM_JOINITEM = Class159.RegisterWindowMessage("WM_JOINITEM");

		// Token: 0x0400053C RID: 1340
		public uint WM_TALKNPCPET_1 = Class159.RegisterWindowMessage("WM_TALKNPCPET_1");

		// Token: 0x0400053D RID: 1341
		public uint WM_TALKNPCPET_2 = Class159.RegisterWindowMessage("WM_TALKNPCPET_2");

		// Token: 0x0400053E RID: 1342
		public uint WM_TALKNPCPET = Class159.RegisterWindowMessage("WM_TALKNPCPET");

		// Token: 0x0400053F RID: 1343
		public uint WM_HUYNHIEMVU = Class159.RegisterWindowMessage("WM_HUYNHIEMVU");

		// Token: 0x04000540 RID: 1344
		public uint WM_OPENSHOPKNB = Class159.RegisterWindowMessage("WM_OPENSHOPKNB");

		// Token: 0x04000541 RID: 1345
		public uint WM_BUYITEMKNB = Class159.RegisterWindowMessage("WM_BUYITEMKNB");

		// Token: 0x04000542 RID: 1346
		public uint WM_SIFLAG = Class159.RegisterWindowMessage("WM_SIFLAG");

		// Token: 0x04000543 RID: 1347
		public uint WM_ALLOWPTJOINTK = Class159.RegisterWindowMessage("WM_ALLOWPTJOINTK");

		// Token: 0x04000544 RID: 1348
		public uint WM_JUSTWARPED = Class159.RegisterWindowMessage("WM_JUSTWARPED");

		// Token: 0x04000545 RID: 1349
		public uint WM_PTLEAVE = Class159.RegisterWindowMessage("WM_PTLEAVE");

		// Token: 0x04000546 RID: 1350
		public uint WM_PTTRANSFER = Class159.RegisterWindowMessage("WM_PTTRANSFER");

		// Token: 0x04000547 RID: 1351
		public uint WM_PTTRANSFER_1 = Class159.RegisterWindowMessage("WM_PTTRANSFER_1");

		// Token: 0x04000548 RID: 1352
		public uint WM_XINVAOPARTY = Class159.RegisterWindowMessage("WM_XINVAOPARTY");

		// Token: 0x04000549 RID: 1353
		public uint WM_RECORDCHAT = Class159.RegisterWindowMessage("WM_RECORDCHAT");

		// Token: 0x0400054A RID: 1354
		public uint WM_SENDSAVEDCHAT = Class159.RegisterWindowMessage("WM_SENDSAVEDCHAT");

		// Token: 0x0400054B RID: 1355
		public uint WM_ISINGAME = Class159.RegisterWindowMessage("WM_ISINGAME");

		// Token: 0x0400054C RID: 1356
		public uint WM_KHINHCONGPACKET = Class159.RegisterWindowMessage("WM_KHINHCONGPACKET");

		// Token: 0x0400054D RID: 1357
		public uint WM_KHINHCONGPACKET_1 = Class159.RegisterWindowMessage("WM_KHINHCONGPACKET_1");

		// Token: 0x0400054E RID: 1358
		public uint WM_MEMALLOC = Class159.RegisterWindowMessage("WM_MEMALLOC");

		// Token: 0x0400054F RID: 1359
		public uint WM_CALLHVD = Class159.RegisterWindowMessage("WM_CALLHVD");

		// Token: 0x04000550 RID: 1360
		public uint WM_CRITDLL = Class159.RegisterWindowMessage("WM_CRITDLL");

		// Token: 0x04000551 RID: 1361
		public uint WM_PORTALCONFIRM = Class159.RegisterWindowMessage("WM_PORTALCONFIRM");

		// Token: 0x04000552 RID: 1362
		public uint WM_ADDPETPOINT_1 = Class159.RegisterWindowMessage("WM_ADDPETPOINT_1");

		// Token: 0x04000553 RID: 1363
		public uint WM_ADDPETPOINT_2 = Class159.RegisterWindowMessage("WM_ADDPETPOINT_2");

		// Token: 0x04000554 RID: 1364
		public uint WM_QUESTITEMCHOICE = Class159.RegisterWindowMessage("WM_QUESTITEMCHOICE");

		// Token: 0x04000555 RID: 1365
		public uint WM_BLOCKCHAT = Class159.RegisterWindowMessage("WM_TAHCKLB");

		// Token: 0x04000556 RID: 1366
		public uint WM_DUMPPACKET = Class159.RegisterWindowMessage("WM_DUMPPACKET");

		// Token: 0x04000557 RID: 1367
		public uint WM_HUYITEMNHIEMVU = Class159.RegisterWindowMessage("WM_HUYITEMNHIEMVU");

		// Token: 0x04000558 RID: 1368
		public uint WM_DOSOMETHING = Class159.RegisterWindowMessage("WM_DOSOMETHING");

		// Token: 0x04000559 RID: 1369
		public uint WM_DOSOMETHING_STRING = Class159.RegisterWindowMessage("WM_DOSOMETHING_STRING");

		// Token: 0x0400055A RID: 1370
		public uint WM_TKSERVERS = Class159.RegisterWindowMessage("WM_TKSERVERS");

		// Token: 0x0400055B RID: 1371
		public uint HAOTESTMSG = Class159.RegisterWindowMessage("HAOTESTMSG");

		// Token: 0x0400055C RID: 1372
		public CookieContainer MainCookie = new CookieContainer();

		// Token: 0x0400055D RID: 1373
		public string KhuyenMaiURL = "forum/auto_khuyenmai.php";

		// Token: 0x0400055E RID: 1374
		public string ProLicenseURL = "http://server1.gameauto.net/tan-thien-long-3d-vng/huong-dan-su-dung-gauto-tlbb-auto-thien-long-bat-bo/";

		// Token: 0x0400055F RID: 1375
		public string LoadWebErrorMessage = "Error reading web";

		// Token: 0x04000560 RID: 1376
		public int LoginFailedCount;

		// Token: 0x04000561 RID: 1377
		public int MaxLoginError = 5;

		// Token: 0x04000562 RID: 1378
		public string ServerStatusText = "";

		// Token: 0x04000563 RID: 1379
		public Class35 Account = new Class35();

		// Token: 0x04000564 RID: 1380
		public long LicenseCheckTimeStamp;

		// Token: 0x04000565 RID: 1381
		public int LicenseCheckDelay = 900000;

		// Token: 0x04000566 RID: 1382
		public List<Class141> QuangCaoContent = new List<Class141>();

		// Token: 0x04000567 RID: 1383
		public int ChatQuangCaoDelay = 1800000;

		// Token: 0x04000568 RID: 1384
		public string tabThuongNhanName = "tabThuongNhan";

		// Token: 0x04000569 RID: 1385
		public float TNNPC_X = 149f;

		// Token: 0x0400056A RID: 1386
		public float TNNPC_Y = 56f;

		// Token: 0x0400056B RID: 1387
		public string SettingDB = "settings.dat";

		// Token: 0x0400056C RID: 1388
		public string SettingTable = "gauto";

		// Token: 0x0400056D RID: 1389
		public string PasswordEncKey = "mariaOzawa1";

		// Token: 0x0400056E RID: 1390
		public uint WM_ENABLETHREAD;

		// Token: 0x0400056F RID: 1391
		public string TNTable = "tnprices2";

		// Token: 0x04000570 RID: 1392
		public string UserLogFile = "glog.txt";

		// Token: 0x04000571 RID: 1393
		public string AdminKhoangFile = "khoang.csv";

		// Token: 0x04000572 RID: 1394
		public string AdminNPCFile = "atabnpc.csv";

		// Token: 0x04000573 RID: 1395
		public bool IsSupportMode;

		// Token: 0x04000574 RID: 1396
		public bool ShowSupportLog;

		// Token: 0x04000575 RID: 1397
		public bool AllowReadMem = true;

		// Token: 0x04000576 RID: 1398
		public bool cboxTatMay;

		// Token: 0x04000577 RID: 1399
		public long TatMayStamp;

		// Token: 0x04000578 RID: 1400
		public string TabToDoiName = "tabToDoi";

		// Token: 0x04000579 RID: 1401
		public string TabPKName = "tabPKName";

		// Token: 0x0400057A RID: 1402
		public string tabNhiemVuName = "tabNhiemVu";

		// Token: 0x0400057B RID: 1403
		public bool optTrainSpeed = true;

		// Token: 0x0400057C RID: 1404
		public int AliveFailedCounts;

		// Token: 0x0400057D RID: 1405
		public int FailedCaptcha;

		// Token: 0x0400057E RID: 1406
		public int GiftCodeCaptchas;

		// Token: 0x0400057F RID: 1407
		public int TrungAcItemID = 40004000;

		// Token: 0x04000580 RID: 1408
		public long NVActionDelay = 2000L;

		// Token: 0x04000581 RID: 1409
		public List<string> LinhThuNames = frmLogin.List_0;

		// Token: 0x04000582 RID: 1410
		public List<string> AcTacNames = frmLogin.List_1;

		// Token: 0x04000583 RID: 1411
		public List<string> TestNPCNames = new List<string>
		{
			"Thiên Toàn Tử"
		};

		// Token: 0x04000584 RID: 1412
		public List<string> AcBaNames = frmLogin.List_2;

		// Token: 0x04000585 RID: 1413
		public List<string> TKCNames = frmLogin.List_3;

		// Token: 0x04000586 RID: 1414
		public double MaxDistance = 49.0;

		// Token: 0x04000587 RID: 1415
		public bool cboxCanNhatBoc = true;

		// Token: 0x04000588 RID: 1416
		private bool _DanhHieuOnOff;

		// Token: 0x04000589 RID: 1417
		public int RingQuaiSize = 800;

		// Token: 0x0400058A RID: 1418
		public int RingNguoiSize = 800;

		// Token: 0x0400058B RID: 1419
		public int RingBocSize = 50;

		// Token: 0x0400058C RID: 1420
		public int RingMsgSize = 50;

		// Token: 0x0400058D RID: 1421
		public int RingHKSize = 20;

		// Token: 0x0400058E RID: 1422
		public int HTPetPercent = 95;

		// Token: 0x0400058F RID: 1423
		public long ShutdownStamp;

		// Token: 0x04000590 RID: 1424
		public int numShutdownH = 2;

		// Token: 0x04000591 RID: 1425
		public int numShutdownM;

		// Token: 0x04000592 RID: 1426
		public long ShutdownTotalMS;

		// Token: 0x04000593 RID: 1427
		public long TriedShutdownStamp;

		// Token: 0x04000594 RID: 1428
		public bool flagNotification = true;

		// Token: 0x04000595 RID: 1429
		public bool flagHideAuto;

		// Token: 0x04000596 RID: 1430
		public bool flagEnableAuto;

		// Token: 0x04000597 RID: 1431
		public bool flagPetOn;

		// Token: 0x04000598 RID: 1432
		public bool flagNhatBoc;

		// Token: 0x04000599 RID: 1433
		public bool flagDanhQuai;

		// Token: 0x0400059A RID: 1434
		public bool flagNMBuff;

		// Token: 0x0400059B RID: 1435
		public bool flagAnAllGame;

		// Token: 0x0400059C RID: 1436
		public string PathPointFile = ".\\pathpoints.txt";

		// Token: 0x0400059D RID: 1437
		public bool WasPro;

		// Token: 0x0400059E RID: 1438
		private string _ExeFilePath = "";

		// Token: 0x0400059F RID: 1439
		private bool _cboxNoKS = true;

		// Token: 0x040005A0 RID: 1440
		private bool _optKinhMachNghichHanh = true;

		// Token: 0x040005A1 RID: 1441
		private bool _optPhuBanKeoDoi;

		// Token: 0x040005A2 RID: 1442
		private bool _optSuDungF1;

		// Token: 0x040005A3 RID: 1443
		public bool optAcceptNewGame = true;

		// Token: 0x040005A4 RID: 1444
		public int CheDoRequest;

		// Token: 0x040005A5 RID: 1445
		public int TraderRequest;

		// Token: 0x040005A6 RID: 1446
		public int Q12TCRequest;

		// Token: 0x040005A7 RID: 1447
		public int YTORequest;

		// Token: 0x040005A8 RID: 1448
		public int YTOExtend;

		// Token: 0x040005A9 RID: 1449
		public int Q12TCExtend;

		// Token: 0x040005AA RID: 1450
		public int BonHoaRequest;

		// Token: 0x040005AB RID: 1451
		public int TrongHoaRequest;

		// Token: 0x040005AC RID: 1452
		public int ThuHoachRequest;

		// Token: 0x040005AD RID: 1453
		public int TrongHoaStatus;

		// Token: 0x040005AE RID: 1454
		public int TrongHoaDuration;

		// Token: 0x040005AF RID: 1455
		public int ThuHoachStatus;

		// Token: 0x040005B0 RID: 1456
		public int ThuHoachDuration;

		// Token: 0x040005B1 RID: 1457
		public int TrongHoaCounts;

		// Token: 0x040005B2 RID: 1458
		public int ThuHoachCounts;

		// Token: 0x040005B3 RID: 1459
		private int _CheDoCounts;

		// Token: 0x040005B4 RID: 1460
		public int TraderCounts;

		// Token: 0x040005B5 RID: 1461
		public int CheDoCounts;

		// Token: 0x040005B6 RID: 1462
		public int CheDoDuration;

		// Token: 0x040005B7 RID: 1463
		public int Q12TCDuration;

		// Token: 0x040005B8 RID: 1464
		public int BonHoaDuration;

		// Token: 0x040005B9 RID: 1465
		public int CheDoStatus;

		// Token: 0x040005BA RID: 1466
		public int Q12TCStatus;

		// Token: 0x040005BB RID: 1467
		public int YTOStatus;

		// Token: 0x040005BC RID: 1468
		public int BonHoaStatus;

		// Token: 0x040005BD RID: 1469
		private int _Q1TCCounts;

		// Token: 0x040005BE RID: 1470
		public int Q12TCCounts;

		// Token: 0x040005BF RID: 1471
		private int _BonHoaCounts;

		// Token: 0x040005C0 RID: 1472
		public int BonHoaCounts;

		// Token: 0x040005C1 RID: 1473
		private bool _optArrangeSkillByName;

		// Token: 0x040005C2 RID: 1474
		public bool HadQ123Pro;

		// Token: 0x040005C3 RID: 1475
		public bool HadYTOPro;

		// Token: 0x040005C4 RID: 1476
		public bool cboxQ12AutoExtend;

		// Token: 0x040005C5 RID: 1477
		public bool optKhongDungNgua;

		// Token: 0x040005C6 RID: 1478
		private bool _cboxAgreement;

		// Token: 0x040005C7 RID: 1479
		private int _optLoginCungLuc = 2;

		// Token: 0x040005C8 RID: 1480
		public bool optStopGlogin;

		// Token: 0x040005C9 RID: 1481
		private bool _optStartNewGame = true;

		// Token: 0x040005CA RID: 1482
		public string UpdaterEXE = "update.exe";

		// Token: 0x040005CB RID: 1483
		public int YTOCounts;

		// Token: 0x040005CC RID: 1484
		public int YTODuration;

		// Token: 0x040005CD RID: 1485
		private bool _optNoSkillLag;

		// Token: 0x040005CE RID: 1486
		public bool cboxYTOGiaHan;

		// Token: 0x040005CF RID: 1487
		public string ExpireString = "(***LƯU Ý: Hạn dùng lượt GG sắp hết nên thời gian tính năng bạn mua sẽ không đủ. Kiểm tra hạn dùng menu 'Hệ thống'->'Thông tin tài khoản'. Bạn nên mua gói nhỏ hơn hoặc chờ lượt dùng mới)";

		// Token: 0x040005D0 RID: 1488
		private bool _optGomQuai2;

		// Token: 0x040005D1 RID: 1489
		public int ChatLimit = 50;

		// Token: 0x040005D2 RID: 1490
		public int DefaultFreeTN;

		// Token: 0x040005D3 RID: 1491
		public bool optGCafe;

		// Token: 0x040005D4 RID: 1492
		private long _TimeGiaiDoHoa = 180000L;

		// Token: 0x040005D5 RID: 1493
		private bool _optChangeTargetFast;

		// Token: 0x040005D6 RID: 1494
		public int EnableAT;

		// Token: 0x040005D7 RID: 1495
		public int EnableAB;

		// Token: 0x040005D8 RID: 1496
		public int EnableQ12;

		// Token: 0x040005D9 RID: 1497
		public int EnableYTO;

		// Token: 0x040005DA RID: 1498
		public int EnableCheDo;

		// Token: 0x040005DB RID: 1499
		public int EnableKyCuoc = 1;

		// Token: 0x040005DC RID: 1500
		public int RefreshGameCount;

		// Token: 0x040005DD RID: 1501
		private int _soVongQHoa = 100;

		// Token: 0x040005DE RID: 1502
		private int _soHangTrongHoa = 4;

		// Token: 0x040005DF RID: 1503
		private int _soVongQSM = 40;

		// Token: 0x040005E0 RID: 1504
		public bool BlockChat = true;

		// Token: 0x040005E1 RID: 1505
		private bool _cboxATRunPP;

		// Token: 0x040005E2 RID: 1506
		private bool _TipHuongDan = true;

		// Token: 0x040005E3 RID: 1507
		public List<int> DuaHauBangMapIDArray = new List<int>();

		// Token: 0x040005E4 RID: 1508
		public int preBocID;

		// Token: 0x040005E5 RID: 1509
		public int MaxBaseError = 5;

		// Token: 0x040005E6 RID: 1510
		public bool HadCDPro;

		// Token: 0x040005E7 RID: 1511
		public int TotalPKLimit = 319;

		// Token: 0x040005E8 RID: 1512
		public int TotalPKLimit_TinhKiem = 319;

		// Token: 0x040005E9 RID: 1513
		public long WriteLogStamp;

		// Token: 0x040005EA RID: 1514
		private bool _cboxNMBuffSelectTarget;

		// Token: 0x040005EB RID: 1515
		private bool _LamNheAuto;

		// Token: 0x040005EC RID: 1516
		public string DLLHash = "";

		// Token: 0x040005ED RID: 1517
		public bool cboxOnlyCheDo;

		// Token: 0x040005EE RID: 1518
		public bool cboxMoThuongNhan;

		// Token: 0x040005EF RID: 1519
		private bool _DongYPhuDoi;

		// Token: 0x040005F0 RID: 1520
		public bool IsLoggedIn;

		// Token: 0x040005F1 RID: 1521
		public bool ThangCheDo;

		// Token: 0x040005F2 RID: 1522
		public int ThangCheDo2AccPrice;

		// Token: 0x040005F3 RID: 1523
		public int ThangCheDo5AccPrice;

		// Token: 0x040005F4 RID: 1524
		public int ThangCheDo50AccPrice;

		// Token: 0x040005F5 RID: 1525
		public bool BuyCheDo;

		// Token: 0x040005F6 RID: 1526
		public int BuyCheDoCount;

		// Token: 0x040005F7 RID: 1527
		private bool _TuKetNoiLai = true;

		// Token: 0x040005F8 RID: 1528
		private bool _TuMuaCKH = true;

		// Token: 0x040005F9 RID: 1529
		private bool _TuThoatGameDis;

		// Token: 0x040005FA RID: 1530
		private bool _TuDongYChuyenCanh = true;

		// Token: 0x040005FB RID: 1531
		public long PlayCaptchaSoundStamp;

		// Token: 0x040005FC RID: 1532
		public int Q12_1hPrice = 2;

		// Token: 0x040005FD RID: 1533
		public int Q12_3hPrice = 5;

		// Token: 0x040005FE RID: 1534
		public int httpRetries = 5;

		// Token: 0x040005FF RID: 1535
		public int httpRetriesDelay = 2000;

		// Token: 0x04000600 RID: 1536
		public long httpRetriesMax = 30000L;

		// Token: 0x04000601 RID: 1537
		public string ZingMeURL = "http://me.zing.vn/u/gameautovip#wall";

		// Token: 0x04000602 RID: 1538
		public long YTOStamp;

		// Token: 0x04000603 RID: 1539
		public bool GLoginHideGame;

		// Token: 0x04000604 RID: 1540
		public bool cboxCDExtend = true;

		// Token: 0x04000605 RID: 1541
		public int TNFreeAcc;

		// Token: 0x04000606 RID: 1542
		public string _cboCDExtend = "2 nhân vật";

		// Token: 0x04000607 RID: 1543
		public static bool bool_0 = false;

		// Token: 0x04000608 RID: 1544
		private bool _cboxNoLoginGame;

		// Token: 0x04000609 RID: 1545
		internal bool sortLevel;

		// Token: 0x0400060A RID: 1546
		internal bool sortMenpai;

		// Token: 0x0400060B RID: 1547
		internal bool sortGroup;

		// Token: 0x0400060C RID: 1548
		private bool _MonPhaiTLC;

		// Token: 0x0400060D RID: 1549
		internal bool renamePath;

		// Token: 0x0400060E RID: 1550
		private bool _cboxResetOutGame = true;

		// Token: 0x0400060F RID: 1551
		private int _tbDelayLogin = 4;

		// Token: 0x04000610 RID: 1552
		private int _tbDelayOutGame = 120;

		// Token: 0x04000611 RID: 1553
		private int _tbDelayNhanGameSom = 30;

		// Token: 0x04000612 RID: 1554
		internal DateTime mapWriteTime;
	}
}
