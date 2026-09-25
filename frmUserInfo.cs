using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000129 RID: 297
	internal sealed partial class frmUserInfo : Form
	{
		// Token: 0x06001231 RID: 4657 RVA: 0x00016501 File Offset: 0x00014701
		internal frmUserInfo()
		{
			this.InitializeComponent();
			this.method_0();
			this.method_1();
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x00115A38 File Offset: 0x00113C38
		private void method_0()
		{
			this.userID.Text = frmLogin.class101_0.globalSettings_0.Account.Username;
			bool flag = false;
			bool flag2 = false;
			if (frmLogin.class101_0.globalSettings_0.Account.double_0 <= 0.0)
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					this.remainCash.Text = "Hết hạn sử dụng.";
				}
				else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					this.remainCash.Text = "Subscription expired.";
				}
				else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
				{
					this.remainCash.Text = "订阅过期.";
				}
			}
			else
			{
				double num = frmLogin.class101_0.globalSettings_0.Account.RemainMSeconds * 10.0 / 518400.0;
				num = frmLogin.class101_0.globalSettings_0.Account.double_0;
				if (!frmLogin.class101_0.globalSettings_0.Account.bool_1)
				{
					flag = true;
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
					{
						this.remainCash.Text = "(Đang dùng) " + num.ToString("0.00") + " VNĐ";
					}
					else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
					{
						this.remainCash.Text = "(In use) " + num.ToString("0.00") + " USD";
					}
					else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
					{
						this.remainCash.Text = "(正在使用) " + num.ToString("0.00") + " " + frmLogin.class101_0.globalSettings_0.CompilingCurrency;
					}
				}
				else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					this.remainCash.Text = num.ToString("0.00") + " VNĐ";
					this.label4.Text = "Dùng thêm G-Gold:";
				}
				else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					this.remainCash.Text = num.ToString("0.00") + " USD";
					this.label4.Text = "Use more G-Gold:";
				}
				else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
				{
					this.remainCash.Text = num.ToString("0.00") + " " + frmLogin.class101_0.globalSettings_0.CompilingCurrency;
					this.label4.Text = "使用 G-Gold:";
				}
			}
			if (frmLogin.class101_0.globalSettings_0.Account.RemainGGoldBalance <= 0.0 && frmLogin.class101_0.globalSettings_0.Account.RemainGGoldPromo <= 0.0)
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					this.remainGGold.Text = "Đã cạn";
				}
				else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					this.remainGGold.Text = "Empty";
				}
				else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
				{
					this.remainGGold.Text = "出的GG";
				}
			}
			else
			{
				int num2 = 1000;
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage != "VN")
				{
					num2 = 1;
				}
				this.remainGGold.Text = (frmLogin.class101_0.globalSettings_0.Account.RemainGGoldBalance / (double)num2).ToString("0.0") + " GG";
				this.remainCash.Text = (frmLogin.class101_0.globalSettings_0.Account.RemainGGoldPromo / (double)num2).ToString("0.0") + " GG+";
				flag2 = true;
			}
			if (!flag2 && !flag)
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					this.Text = "Thông tin tài khoản - Lite version";
				}
				else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					this.Text = "Account information - Lite version";
				}
				else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
				{
					this.Text = "账户信息 - 免费版";
				}
			}
			else if (!frmLogin.class101_0.globalSettings_0.Account.bool_1)
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					this.Text = "Tài khoản - Pro version";
				}
				else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					this.Text = "Account information - Pro version";
				}
				else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
				{
					this.Text = "账户信息 - PRO版";
				}
			}
			else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
			{
				this.Text = "Tài khoản Pro (G-Gold)";
			}
			else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
			{
				this.Text = "Account - Pro (G-Gold)";
			}
			else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
			{
				this.Text = "账户信息 - Pro版 (G-Gold)";
			}
			if (frmLogin.class101_0.globalSettings_0.Account.RemainMSeconds <= 0.0)
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					this.remainTime.Text = "Hết hạn";
				}
				else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					this.remainTime.Text = "Expired";
				}
				else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
				{
					this.remainTime.Text = "过期";
				}
				this.userExpDate.Text = DateTime.MinValue.ToShortDateString();
			}
			else
			{
				TimeSpan timeSpan = TimeSpan.FromMilliseconds(frmLogin.class101_0.globalSettings_0.Account.RemainMSeconds);
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					this.remainTime.Text = string.Format("{0} ngày, {1} giờ {2} phút", timeSpan.Days.ToString(), timeSpan.Hours.ToString(), timeSpan.Minutes.ToString());
				}
				else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					this.remainTime.Text = string.Format("{0} day, {1} hour {2} minute", timeSpan.Days.ToString(), timeSpan.Hours.ToString(), timeSpan.Minutes.ToString());
				}
				else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
				{
					this.remainTime.Text = string.Format("{0} 天, {1} 小时 {2} 分钟", timeSpan.Days.ToString(), timeSpan.Hours.ToString(), timeSpan.Minutes.ToString());
				}
				this.userExpDate.Text = DateTime.Now.AddMilliseconds(frmLogin.class101_0.globalSettings_0.Account.RemainMSeconds).ToString();
			}
			int num3;
			if (frmLogin.string_0 == "VN")
			{
				num3 = (frmLogin.class101_0.globalSettings_0.CheDoCounts ^ 2013) / 152;
			}
			else
			{
				num3 = frmLogin.class101_0.globalSettings_0.Account.class210_0.Count;
			}
			double num4 = (double)((frmLogin.class101_0.globalSettings_0.CheDoDuration ^ 2013) / 152);
			TimeSpan timeSpan2 = TimeSpan.FromSeconds((double)frmLogin.class101_0.globalSettings_0.Account.int_9);
			TimeSpan timeSpan3 = TimeSpan.FromSeconds((double)frmLogin.class101_0.globalSettings_0.Account.int_11);
			TimeSpan timeSpan4 = TimeSpan.FromSeconds(num4 - (double)1);
			if (num3 > 0)
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					this.txtCheDo.Text = string.Format("{0} nhân vật. Còn {1} giờ {2} phút", num3, timeSpan4.Hours.ToString("00"), timeSpan4.Minutes.ToString("00"));
				}
				else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					string arg = timeSpan2.TotalHours.ToString("00") + " h";
					if (timeSpan2.TotalHours <= 0.0)
					{
						arg = timeSpan2.TotalMinutes.ToString("00") + " m";
					}
					string arg2 = timeSpan3.TotalHours.ToString("00") + " h";
					if (timeSpan3.TotalHours <= 0.0)
					{
						arg2 = timeSpan3.TotalMinutes.ToString("00") + " m";
					}
					this.txtCheDo.Text = string.Format("{0} char. Rem: {1} -> {2}", num3, arg, arg2);
				}
				else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
				{
					this.txtCheDo.Text = string.Format("{0} 人物. 休息 {1} 小时 {2} 分钟", num3, timeSpan4.Hours.ToString("00"), timeSpan4.Minutes.ToString("00"));
				}
			}
			else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
			{
				this.txtCheDo.Text = "Chưa mở chế đồ";
			}
			else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
			{
				this.txtCheDo.Text = "Not activated crafting";
			}
			else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
			{
				this.txtCheDo.Text = "家具制造-未启用";
			}
			num3 = (frmLogin.class101_0.globalSettings_0.TraderCounts ^ 2714) / 153;
			if (num3 < frmLogin.class101_0.globalSettings_0.DefaultFreeTN && frmLogin.class101_0.globalSettings_0.Account.RemainMSeconds > 0.0)
			{
				num3 = frmLogin.class101_0.globalSettings_0.DefaultFreeTN;
			}
			timeSpan2 = TimeSpan.FromSeconds((double)frmLogin.class101_0.globalSettings_0.Account.int_10);
			timeSpan3 = TimeSpan.FromSeconds((double)frmLogin.class101_0.globalSettings_0.Account.int_12);
			if (num3 > 0)
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					string arg3 = timeSpan2.TotalHours.ToString("00") + " h";
					if (timeSpan2.TotalHours <= 0.0)
					{
						arg3 = timeSpan2.TotalMinutes.ToString("00") + " m";
					}
					string arg4 = timeSpan3.TotalHours.ToString("00") + " h";
					if (timeSpan3.TotalHours <= 0.0)
					{
						arg4 = timeSpan3.TotalMinutes.ToString("00") + " m";
					}
					this.txtTrading.Text = string.Format("{0} char. Rem: {1} -> {2}", num3, arg3, arg4);
				}
			}
			else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
			{
				this.txtTrading.Text = "Chưa mở thương nhân";
			}
			else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
			{
				this.txtTrading.Text = "Not activated trading";
			}
			else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
			{
				this.txtTrading.Text = "未激活的交易功能";
			}
			num3 = (frmLogin.class101_0.globalSettings_0.Q12TCCounts ^ 1786) / 849;
			timeSpan4 = TimeSpan.FromSeconds((double)((frmLogin.class101_0.globalSettings_0.Q12TCDuration ^ 1786) / 849 - 1));
			if (num3 > 0)
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					this.txtQ1TC.Text = string.Format("{0} party. Còn {1} giờ {2} phút", num3, timeSpan4.Hours.ToString("00"), timeSpan4.Minutes.ToString("00"));
				}
				else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					this.txtQ1TC.Text = string.Format("{0} team. Left {1} h {2} min", num3, timeSpan4.Hours.ToString("00"), timeSpan4.Minutes.ToString("00"));
				}
				else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
				{
					this.txtQ1TC.Text = string.Format("{0}团队.剩{1}小时{2}分钟", num3, timeSpan4.Hours.ToString("00"), timeSpan4.Minutes.ToString("00"));
				}
			}
			else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
			{
				this.txtQ1TC.Text = "Chưa mở Q12 TC";
			}
			else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
			{
				this.txtQ1TC.Text = "Not activated Q12 SZ";
			}
			else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
			{
				this.txtQ1TC.Text = "从未激活Q12苏州";
			}
			num3 = (frmLogin.class101_0.globalSettings_0.YTOCounts ^ 2716) / 147;
			timeSpan4 = TimeSpan.FromSeconds((double)((frmLogin.class101_0.globalSettings_0.YTODuration ^ 2716) / 147 - 1));
			if (num3 > 0)
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					this.txtYTO.Text = string.Format("{0} party. Còn {1} giờ {2} phút", num3, timeSpan4.Hours.ToString("00"), timeSpan4.Minutes.ToString("00"));
					return;
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					this.txtYTO.Text = string.Format("{0} team. Left {1} h {2} min", num3, timeSpan4.Hours.ToString("00"), timeSpan4.Minutes.ToString("00"));
					return;
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
				{
					this.txtYTO.Text = string.Format("{0}团队.剩{1}小时{2}分钟", num3, timeSpan4.Hours.ToString("00"), timeSpan4.Minutes.ToString("00"));
					return;
				}
			}
			else
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					this.txtYTO.Text = "Chưa mở YTO";
					return;
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					this.txtYTO.Text = "Not activated SD";
					return;
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
				{
					this.txtYTO.Text = "从未激活日元涂驱动器";
				}
			}
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x000024E9 File Offset: 0x000006E9
		private void frmUserInfo_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x0000A392 File Offset: 0x00008592
		private void btnNapThe_Click(object sender, EventArgs e)
		{
			frmMain.smethod_18();
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x000024E9 File Offset: 0x000006E9
		private void btnThem24h_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x000024E9 File Offset: 0x000006E9
		private void frmUserInfo_Shown(object sender, EventArgs e)
		{
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x00116B94 File Offset: 0x00114D94
		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (frmLogin.class101_0.bool_1)
			{
				this.method_0();
				this.method_1();
				try
				{
					frmLogin.class101_0.bool_1 = false;
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x00016547 File Offset: 0x00014747
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x00116BDC File Offset: 0x00114DDC
		private void method_1()
		{
			if (!Class83.bool_0 && Class83.class79_0 == null && frmLogin.class101_0.globalSettings_0.Account.Username != "" && frmLogin.class132_0 != null)
			{
				string string_ = string.Format("userid={0}&isauto=auto", frmLogin.class101_0.globalSettings_0.Account.Username);
				string text = Class83.smethod_124(frmLogin.class132_0.string_0 + frmLogin.class101_0.globalSettings_0.UsageURL, string_, "POST", null, true);
				this.list_0.Clear();
				this.list_1.Clear();
				if (!string.IsNullOrEmpty(text) && text != frmLogin.class101_0.globalSettings_0.LoadWebErrorMessage)
				{
					DateTime.MinValue.ToString();
					Class83.smethod_83(text, "{\"handung\":\"", "\",\"", 1, 1) == "valid";
					Class83.smethod_83(text, "\"subexpdate\":\"", "\",\"", 1, 1);
					Class83.smethod_83(text, "remaingg\":", ",\"sothenap", 1, 1);
					if (text.Contains("napthe") && text.Contains("actioncount"))
					{
						string[] array = Class83.smethod_83(text, "\"napthe\":[", "],\"actioncount", 1, 1).Split(new char[]
						{
							'}'
						});
						if (array.Length != 0)
						{
							foreach (string text2 in array)
							{
								if (!string.IsNullOrEmpty(text2))
								{
									Class142 @class = new Class142();
									@class.string_0 = Class83.smethod_83(text2, "thetime\":\"", "\",\"", 1, 1);
									@class.string_1 = Class83.smethod_83(text2, "telco\":\"", "\",\"", 1, 1);
									@class.string_2 = Class83.smethod_83(text2, "serial\":\"", "\",\"", 1, 1);
									@class.string_3 = Class83.smethod_83(text2, "loaitk\":\"", "\"", 1, 3);
									@class.string_4 = Class83.smethod_83(text2, "amount\":\"", "\",\"", 1, 1);
									if (@class.string_2.Length > 4)
									{
										char[] array3 = @class.string_2.ToCharArray();
										for (int j = 0; j < array3.Length - 4; j++)
										{
											array3[j] = '*';
										}
										@class.string_2 = new string(array3);
									}
									this.list_0.Add(@class);
								}
							}
							this.lvTheDaNap.BeginUpdate();
							this.lvTheDaNap.Items.Clear();
							if (this.list_0.Count > 0)
							{
								foreach (Class142 class2 in this.list_0)
								{
									ListViewItem listViewItem = new ListViewItem();
									listViewItem.Text = class2.string_0;
									listViewItem.SubItems.Add(class2.string_4);
									listViewItem.SubItems.Add(class2.string_3);
									listViewItem.SubItems.Add(class2.string_1 + "-" + class2.string_2);
									this.lvTheDaNap.Items.Add(listViewItem);
								}
							}
							this.lvTheDaNap.EndUpdate();
						}
					}
					if (text.Contains("actionlog") && text.Contains("actioncount"))
					{
						string[] array4 = Class83.smethod_83(text, "\"actionlog\":[", "]}", 1, 1).Split(new char[]
						{
							'}'
						});
						if (array4.Length != 0)
						{
							foreach (string text3 in array4)
							{
								if (!string.IsNullOrEmpty(text3))
								{
									Class143 class3 = new Class143();
									Class143 class4 = null;
									if (this.list_1.Count > 1)
									{
										class4 = this.list_1[this.list_1.Count - 1];
									}
									class3.string_0 = Class83.smethod_81(text3, "actiontime", false);
									class3.string_1 = Class83.smethod_81(text3, "actiontype", false);
									class3.string_3 = Class83.smethod_81(text3, "actionremain", false);
									bool flag = false;
									if (class4 != null)
									{
										int num = 0;
										int.TryParse(class4.string_3, out num);
										int num2 = 0;
										int.TryParse(class3.string_3, out num2);
										if (num > num2)
										{
											class3.string_2 = (num - num2).ToString();
											if (class3.string_2 == "3")
											{
												class3.string_1 = "LOGIN";
											}
										}
										else if (num == num2)
										{
											flag = true;
										}
									}
									else
									{
										class3.string_2 = Class83.smethod_81(text3, "actioncost", false);
									}
									if (!flag)
									{
										this.list_1.Add(class3);
									}
								}
							}
							if (this.list_1.Count > 0)
							{
								bool flag2 = false;
								for (int k = this.list_1.Count - 1; k >= 0; k--)
								{
									bool flag3 = false;
									if (k < this.list_1.Count - 1 && this.list_1[k].string_0 == this.list_1[k + 1].string_0 && this.list_1[k].string_3 == this.list_1[k + 1].string_3 && this.list_1[k].string_1 != this.list_1[k + 1].string_1)
									{
										flag3 = true;
									}
									bool flag4 = false;
									if (k > 0 && this.list_1[k].string_0 == this.list_1[k - 1].string_0 && this.list_1[k].string_3 == this.list_1[k - 1].string_3 && this.list_1[k].string_1 != this.list_1[k - 1].string_1)
									{
										flag4 = true;
									}
									if (flag3 || flag4)
									{
										this.list_1[k].bool_0 = true;
										flag2 = true;
									}
								}
								if (flag2)
								{
									for (int l = this.list_1.Count - 1; l >= 0; l--)
									{
										if (this.list_1[l].bool_0 && this.list_1[l].string_1.Contains("CD-"))
										{
											this.list_1.RemoveAt(l);
											l++;
										}
									}
								}
								this.lvHoatDong.BeginUpdate();
								this.lvHoatDong.Items.Clear();
								foreach (Class143 class5 in this.list_1)
								{
									if (class5.string_2 != "")
									{
										ListViewItem listViewItem2 = new ListViewItem();
										listViewItem2.Text = class5.string_0;
										if (!class5.string_1.Contains("Q12-") && !class5.string_1.Contains("YTO-"))
										{
											if (class5.string_1.Contains("CD-"))
											{
												string[] array5 = class5.string_1.Split(new char[]
												{
													'-'
												});
												class5.string_1 = "Chế đồ lượt " + array5[1];
											}
											else if (class5.string_1.Contains("CDRN-"))
											{
												string[] array6 = class5.string_1.Split(new char[]
												{
													'-'
												});
												class5.string_1 = "Chế renew " + array6[1] + " acc";
											}
										}
										else
										{
											Class143 class6 = class5;
											class6.string_1 += " giờ";
										}
										if (!class5.bool_0)
										{
											listViewItem2.SubItems.Add(class5.string_1);
										}
										else
										{
											listViewItem2.SubItems.Add(class5.string_1 + " *");
										}
										listViewItem2.SubItems.Add(class5.string_2 + " GG");
										listViewItem2.SubItems.Add(class5.string_3 + " GG");
										this.lvHoatDong.Items.Add(listViewItem2);
									}
								}
								this.lvHoatDong.EndUpdate();
							}
						}
					}
				}
			}
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x000024E9 File Offset: 0x000006E9
		private void txtTrading_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x001174C0 File Offset: 0x001156C0
		private void btnRefreshInfo_Click(object sender, EventArgs e)
		{
			if (frmLogin.stopwatch_0.ElapsedMilliseconds - frmLogin.long_21 >= 3000L)
			{
				frmLogin.long_21 = frmLogin.stopwatch_0.ElapsedMilliseconds;
				string text = "";
				string text2 = "";
				Class83.smethod_77(out text, out text2, true, false);
			}
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x000024E9 File Offset: 0x000006E9
		private void groupBox1_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x0400132A RID: 4906
		internal static Dictionary<string, string> dictionary_0 = frmLogin.class101_0.globalSettings_0.LoginInfo;

		// Token: 0x0400132B RID: 4907
		private List<Class142> list_0 = new List<Class142>();

		// Token: 0x0400132C RID: 4908
		private List<Class143> list_1 = new List<Class143>();
	}
}
