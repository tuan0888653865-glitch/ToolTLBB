using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Web;
using System.Windows.Forms;
using Newtonsoft.Json;
using SmartBot;

namespace ns0
{
	// Token: 0x02000100 RID: 256
	internal sealed partial class frmNapThe : Form
	{
		// Token: 0x06000A77 RID: 2679 RVA: 0x000CA964 File Offset: 0x000C8B64
		internal frmNapThe()
		{
			this.InitializeComponent();
			this.int_1 = this.lblCoupon.Location.Y;
			this.int_0 = base.Width;
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x000CA9D0 File Offset: 0x000C8BD0
		private void method_0()
		{
			string text = Class83.smethod_125(frmLogin.class132_0.string_0 + frmLogin.class101_0.globalSettings_0.KhuyenMaiURL, "", "GET", frmLogin.class101_0.globalSettings_0.MainCookie, true);
			this.string_0 = text;
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x0000A933 File Offset: 0x00008B33
		private void linkPrice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(frmLogin.class101_0.globalSettings_0.ProLicenseURL);
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x0000A94A File Offset: 0x00008B4A
		private void txtCardType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.txtCardType.SelectedItem.ToString().Contains("GAU"))
			{
				this.txtCardSerial.Enabled = false;
				return;
			}
			this.txtCardSerial.Enabled = true;
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x000098D4 File Offset: 0x00007AD4
		private void btnHuy_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x000CAA24 File Offset: 0x000C8C24
		private void btnNapThe_Click(object sender, EventArgs e)
		{
			try
			{
				if (!this.backgroundWorker_0.IsBusy)
				{
					this.btnNapThe.Enabled = false;
					this.btnHuy.Enabled = false;
					this.btnCoupon.Enabled = false;
					this.backgroundWorker_0.RunWorkerAsync(2);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x000CAA88 File Offset: 0x000C8C88
		private void method_1()
		{
			bool flag = false;
			if (Class83.smethod_38(this.txtCardCode.Text) || Class83.smethod_38(this.txtCardSerial.Text) || Class83.smethod_38(this.txtTenTaiKhoan.Text) || Class83.smethod_38(this.txtCoupon.Text))
			{
				flag = true;
			}
			if (!this.rdioTien.Checked && this.rdioGGold.Checked)
			{
				bool flag2 = false;
				if (this.picCaptcha.Visible)
				{
					string a = Class83.smethod_71(this.secureString_0).ToLower();
					string b = this.txtCaptcha.Text.ToLower();
					if (a == b)
					{
						flag2 = true;
					}
					frmLogin.frmLogin_0.txtUserPassword.Invoke(new MethodInvoker(this.method_7));
					GC.Collect();
				}
				else if (frmLogin.class101_0.globalSettings_0.FailedCaptcha < 3)
				{
					flag2 = true;
				}
				if (flag2)
				{
					frmNapThe.Class176 @class = new frmNapThe.Class176();
					@class.frmNapThe_0 = this;
					@class.string_0 = "GAU";
					string text = this.txtCardCode.Text.Trim();
					string text2 = this.txtCardSerial.Text.Trim();
					string gameID = frmLogin.class101_0.globalSettings_0.GameID;
					string text3 = this.txtCoupon.Text;
					text3 = text3.Replace("%", "");
					text3 = text3.Replace("'", "");
					text3 = text3.Replace("\"", "");
					@class.string_1 = "";
					string text4 = this.txtTenTaiKhoan.Text;
					frmLogin.frmLogin_0.txtUserPassword.Invoke(new MethodInvoker(@class.method_0));
					bool flag3 = true;
					if (!this.method_2(text, text2, @class.string_0))
					{
						MessageBox.Show("Sai định dạng thẻ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						return;
					}
					if (@class.string_0 == "GAU")
					{
						text2 = "None";
						if (string.IsNullOrEmpty(text))
						{
							flag3 = false;
						}
					}
					if (!GlobalSettings.bool_0 && flag3)
					{
						if (MessageBox.Show("Bạn kiểm tra lại lần nữa mệnh giá thẻ xem đúng chưa.\nNếu chọn sai mệnh giá thẻ sẽ bị nhà phát hành nuốt mất. GAuto không thể làm gì được vì thẻ chưa vào hệ thống của chúng tôi.\n\nNhấn YES nếu mệnh giá thẻ đúng. Nhấn NO để quay lại đổi mệnh giá thẻ.", "Kiểm tra mệnh giá", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
						{
							flag3 = false;
						}
						else
						{
							GlobalSettings.bool_0 = true;
						}
					}
					if (!string.IsNullOrEmpty(text4) && !string.IsNullOrEmpty(text) && flag3 && !flag)
					{
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
						dictionary2.Add("salt", Class83.smethod_98(5));
						dictionary2.Add("action", "napthe");
						dictionary2.Add("telcoid", @class.string_0);
						dictionary2.Add("code", text);
						dictionary2.Add("seri", text2);
						dictionary2.Add("gameid", gameID);
						dictionary2.Add("uid", text4);
						dictionary2.Add("coupon", text3);
						dictionary2.Add("price", @class.string_1);
						if (frmMain.frmMain_0 != null && frmLogin.class101_0.globalSettings_0.Account.string_9 != "-1")
						{
							dictionary2.Add("gautoid", frmLogin.class101_0.globalSettings_0.Account.string_9);
						}
						string text5 = JsonConvert.SerializeObject(dictionary2);
						text5 = HttpUtility.UrlEncode(Class83.smethod_39(text5, 1));
						string string_ = frmLogin.class132_0.string_0 + frmLogin.class101_0.globalSettings_0.HouseKeeperURL;
						string string_2 = "POST";
						dictionary = Class83.smethod_27(string_, string_2, text5);
						if (dictionary != null)
						{
							frmNapThe.Class177 class2 = new frmNapThe.Class177();
							class2.class176_0 = @class;
							object obj = null;
							string a2 = "";
							class2.string_0 = "";
							class2.string_1 = "";
							dictionary.TryGetValue("status", out obj);
							if (obj != null)
							{
								a2 = obj.ToString();
							}
							dictionary.TryGetValue("message", out obj);
							if (obj != null)
							{
								class2.string_0 = obj.ToString();
							}
							dictionary.TryGetValue("statuscode", out obj);
							if (obj != null)
							{
								class2.string_1 = obj.ToString();
							}
							if (a2 == "ERROR")
							{
								frmLogin.frmLogin_0.txtUserPassword.Invoke(new MethodInvoker(class2.method_0));
							}
							else if (a2 == "NAPTHEOK")
							{
								if (class2.string_0 != "")
								{
									frmLogin.frmLogin_0.txtUserPassword.Invoke(new MethodInvoker(class2.method_1));
								}
								string text6 = "0";
								string text7 = "0";
								string text8 = "";
								string text9 = "";
								dictionary.TryGetValue("realamount", out obj);
								if (obj != null)
								{
									text6 = obj.ToString();
								}
								dictionary.TryGetValue("promoamount", out obj);
								if (obj != null)
								{
									text7 = obj.ToString();
								}
								dictionary.TryGetValue("cardSerial", out obj);
								if (obj != null)
								{
									text8 = obj.ToString();
								}
								dictionary.TryGetValue("cardPin", out obj);
								if (obj != null)
								{
									text9 = obj.ToString();
								}
								double num = 0.0;
								double.TryParse(text6, out num);
								double num2 = 0.0;
								double.TryParse(text7, out num2);
								num += num2;
								num /= frmLogin.double_0;
								if (text6 != "" && text6 != "0")
								{
									if (class2.class176_0.string_0 != "GAU")
									{
										string string_3 = string.Format("Nạp thành công thẻ {0}/{1} được {2}.\nBạn đã nạp thêm {3}{4} vào tải khoản {5}", new object[]
										{
											text8,
											text9,
											text6,
											num.ToString("0.0").Replace(".0", ""),
											frmLogin.String_1,
											text4
										});
										if (num2 > 0.0)
										{
											string_3 = string.Format("Nạp thành công thẻ {0}/{1} được {2}, khuyến mãi {5}.\nBạn đã nạp thêm {3}{4} vào tài khoản {6}", new object[]
											{
												text8,
												text9,
												text6,
												num.ToString("0.0").Replace(".0", ""),
												frmLogin.String_1,
												text7,
												text4
											});
										}
										Class83.smethod_46(string_3, "Nạp thẻ thành công", 120000, new object[0]);
									}
									else
									{
										Class83.smethod_46(string.Format("Nạp mã thưởng {0} thành công.\nThông báo: {1}", text9, class2.string_0), "Mã thưởng", 120000, new object[0]);
									}
									if (frmLogin.class101_0.globalSettings_0.IsLoggedIn && frmLogin.class101_0.globalSettings_0.Account != null)
									{
										Class83.smethod_29(new Class73
										{
											string_0 = frmLogin.class101_0.globalSettings_0.Account.Username,
											string_1 = frmLogin.class101_0.globalSettings_0.Account.string_1,
											bool_1 = false
										}, null);
									}
									frmLogin.class101_0.globalSettings_0.FailedCaptcha = 0;
								}
							}
							else
							{
								if (a2 == "PENDING")
								{
									Class83.smethod_46(dictionary["message"].ToString(), "Đã ghi nhận thẻ, vui lòng chờ", 120000, new object[0]);
									try
									{
										frmLogin.long_2 = frmLogin.stopwatch_0.ElapsedMilliseconds + 10000L;
										goto IL_784;
									}
									catch (Exception)
									{
										goto IL_784;
									}
								}
								Class83.smethod_46("Nạp thẻ bị lỗi", "Lỗi", 60000, new object[0]);
							}
						}
						else
						{
							frmLogin.frmLogin_0.txtUserPassword.Invoke(new MethodInvoker(this.method_8));
						}
					}
				}
				else
				{
					MessageBox.Show("Vui lòng nhập câu hỏi chống bot đúng.", "Captcha", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				IL_784:
				if (frmLogin.class101_0.globalSettings_0.FailedCaptcha >= 3 || flag)
				{
					frmLogin.frmLogin_0.txtUserPassword.Invoke(new MethodInvoker(this.method_9));
				}
			}
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x000CB25C File Offset: 0x000C945C
		private bool method_2(string string_2, string string_3, string string_4)
		{
			if (string_4 == "VMS")
			{
				if (string_2.Length != 12 || string_3.Length != 15)
				{
					return false;
				}
			}
			else if (string_4 == "VTT")
			{
				if (string_2.Length == 13 && string_3.Length != 11)
				{
					return false;
				}
				if (string_2.Length == 15 && string_3.Length != 14)
				{
					return false;
				}
			}
			else if (string_4 == "VNP")
			{
				if (string_3.Length != 12 && string_3.Length != 14)
				{
					return false;
				}
			}
			else if (string_4 == "FPT" && (string_2.Length != 10 || string_3.Length != 10))
			{
				return false;
			}
			return true;
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x000CB310 File Offset: 0x000C9510
		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(this.string_0) && this.string_0 != this.lblCoupon.Text)
			{
				this.lblCoupon.Text = this.string_0;
			}
			if (!string.IsNullOrEmpty(this.lblCoupon.Text))
			{
				if (this.int_0 <= this.lblCoupon.Width * -1)
				{
					this.lblCoupon.Location = new Point(base.Width, this.int_1);
					this.int_0 = base.Width;
					return;
				}
				this.lblCoupon.Location = new Point(this.int_0, this.int_1);
				this.int_0 -= 2;
			}
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x000CB3D0 File Offset: 0x000C95D0
		private void method_3(bool bool_0)
		{
			int num = -108;
			bool visible = false;
			if (bool_0)
			{
				num = 108;
				visible = true;
			}
			bool flag = false;
			if (!this.picCaptcha.Visible && bool_0)
			{
				flag = true;
			}
			else if (this.picCaptcha.Visible && !bool_0)
			{
				flag = true;
			}
			if (flag)
			{
				base.Height += num;
				this.lblStatus.Top += num;
				this.linkPrice.Top += num;
				this.lblCoupon.Top += num;
				this.btnHuy.Top += num;
				this.btnNapThe.Top += num;
				this.int_1 = this.lblCoupon.Location.Y;
				this.btnCaptcha.Visible = visible;
				this.picCaptcha.Visible = visible;
				this.lblCaptcha.Visible = visible;
				this.txtCaptcha.Visible = visible;
				this.lblCaptcha3.Visible = visible;
				this.lblCaptcha2.Visible = visible;
			}
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x000CB4E8 File Offset: 0x000C96E8
		private void frmNapThe_Load(object sender, EventArgs e)
		{
			if (frmLogin.class101_0.globalSettings_0.FailedCaptcha < 3)
			{
				this.method_3(false);
			}
			else
			{
				this.method_3(true);
				this.method_4();
			}
			if (!string.IsNullOrEmpty(this.string_1))
			{
				this.txtTenTaiKhoan.Text = this.string_1;
			}
			this.txtCardType.SelectedIndex = 0;
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x000CB548 File Offset: 0x000C9748
		private void frmNapThe_Shown(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.OwnerDraw = true;
			toolTip.BackColor = Color.Yellow;
			toolTip.AutoPopDelay = 20000;
			toolTip.InitialDelay = 500;
			toolTip.ReshowDelay = 500;
			toolTip.ShowAlways = true;
			toolTip.IsBalloon = true;
			toolTip.SetToolTip(this.rdioTien, "Tiền nạp vào dạng thuê bao, giá rẻ, trừ theo thời gian.");
			toolTip.SetToolTip(this.rdioGGold, "GAuto Gold (G-Gold), Dùng GG để mua thời gian chơi.\nGG có thể sử dụng để mua giờ chế đồ, Q12, YTO.");
			this.timer_0.Enabled = true;
			this.rdioGGold.Checked = true;
			this.rdioTien.Visible = false;
			this.lbNaptien.Text = "Thẻ nạp sẽ vào GG tài khoản. Bạn sử dụng \ntính năng 'Mua giờ' để mua giờ chơi và tính năng.";
			this.lbNaptien.ForeColor = Color.RosyBrown;
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x0000A981 File Offset: 0x00008B81
		private void btnCaptcha_Click(object sender, EventArgs e)
		{
			this.method_4();
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x000CB600 File Offset: 0x000C9800
		private void method_4()
		{
			string string_ = Class83.smethod_98(6);
			this.secureString_0 = Class83.smethod_70(string_);
			GC.Collect();
			this.picCaptcha.Image = Class83.smethod_50(this.secureString_0);
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x000CB640 File Offset: 0x000C9840
		private void txtCardCode_TextChanged(object sender, EventArgs e)
		{
			if (this.txtCardType.SelectedItem != null && this.txtCardType.SelectedItem.ToString() == "GameAuto.net Code")
			{
				if (!string.IsNullOrEmpty(this.txtCardCode.Text))
				{
					if (this.txtCardCode.Text.Contains("-PRO-"))
					{
						this.rdioGGold.Enabled = true;
						return;
					}
					this.rdioGGold.Enabled = false;
					this.rdioTien.Checked = true;
					return;
				}
				else
				{
					this.rdioGGold.Enabled = false;
					this.rdioTien.Checked = true;
				}
			}
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x000024E9 File Offset: 0x000006E9
		private void rdioTien_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x000024E9 File Offset: 0x000006E9
		private void rdioGGold_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x0000A989 File Offset: 0x00008B89
		private void rdioTien_Click(object sender, EventArgs e)
		{
			this.rdioTien.ForeColor = Color.Black;
			this.rdioGGold.ForeColor = Color.Black;
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x0000A9AB File Offset: 0x00008BAB
		private void btnCoupon_Click(object sender, EventArgs e)
		{
			if (!this.backgroundWorker_0.IsBusy)
			{
				this.btnCoupon.Enabled = false;
				this.backgroundWorker_0.RunWorkerAsync(1);
			}
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x000CB6E0 File Offset: 0x000C98E0
		private void method_5()
		{
			frmNapThe.Class178 @class = new frmNapThe.Class178();
			@class.frmNapThe_0 = this;
			if (this.txtCoupon.Text != "")
			{
				string text = this.txtCoupon.Text.Replace("%", "");
				text = this.txtCoupon.Text.Replace("'", "");
				text = this.txtCoupon.Text.Replace("\"", "");
				if (text != "")
				{
					Dictionary<string, object> dictionary = frmNapThe.smethod_0(text, 0);
					if (dictionary.Count > 0)
					{
						object obj = null;
						@class.string_0 = "";
						dictionary.TryGetValue("cpmsg", out obj);
						if (obj != null)
						{
							@class.string_0 = obj.ToString();
						}
						frmLogin.frmLogin_0.txtUserPassword.Invoke(new MethodInvoker(@class.method_0));
					}
				}
			}
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x000CB7CC File Offset: 0x000C99CC
		internal static Dictionary<string, object> smethod_0(string string_2, int int_3 = 0)
		{
			new Dictionary<string, object>();
			string text = JsonConvert.SerializeObject(new Dictionary<string, object>
			{
				{
					"salt",
					Class83.smethod_98(5)
				},
				{
					"action",
					"coupon"
				},
				{
					"fortime",
					int_3
				},
				{
					"coupon",
					string_2
				}
			});
			text = HttpUtility.UrlEncode(Class83.smethod_39(text, 1));
			string string_3 = frmLogin.class132_0.string_0 + frmLogin.class101_0.globalSettings_0.HouseKeeperURL;
			string string_4 = "POST";
			return Class83.smethod_27(string_3, string_4, text);
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x000CB860 File Offset: 0x000C9A60
		private void method_6()
		{
			if (this.txtCoupon.Text != "")
			{
				string text = this.txtCoupon.Text.Replace("%", "");
				text = this.txtCoupon.Text.Replace("'", "");
				text = this.txtCoupon.Text.Replace("\"", "");
				if (text != "")
				{
					string text2 = Class83.smethod_124(frmLogin.class132_0.string_0 + frmLogin.class101_0.globalSettings_0.CouponURL, "coupon=" + text, "POST", null, true);
					if (text2 != "" && text2 != frmLogin.class101_0.globalSettings_0.LoadWebErrorMessage)
					{
						string text3 = Class83.smethod_81(text2, "cpmsg", false);
						text3 = HttpUtility.UrlDecode(text3);
						try
						{
							byte[] bytes = Convert.FromBase64String(text3);
							text3 = Encoding.UTF8.GetString(bytes);
						}
						catch (Exception)
						{
						}
						if (text3.Contains("không hợp lệ"))
						{
							this.lblMaKMResult.ForeColor = Color.Red;
						}
						else
						{
							this.lblMaKMResult.ForeColor = Color.Blue;
						}
						this.lblMaKMResult.Text = text3;
					}
				}
			}
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x000CB9BC File Offset: 0x000C9BBC
		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
			if (e.Argument != null && e.Argument.GetType() == typeof(int) && (int)e.Argument == 1)
			{
				this.method_5();
				e.Result = 1;
				return;
			}
			if (e.Argument != null && e.Argument.GetType() == typeof(int) && (int)e.Argument == 2)
			{
				this.method_1();
				e.Result = 2;
			}
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x000CBA48 File Offset: 0x000C9C48
		private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Result != null && e.Result.GetType() == typeof(int) && (int)e.Result == 1)
			{
				this.btnCoupon.Enabled = true;
				return;
			}
			if (e.Result != null && e.Result.GetType() == typeof(int) && (int)e.Result == 2)
			{
				this.btnCoupon.Enabled = true;
				this.btnNapThe.Enabled = true;
				this.btnHuy.Enabled = true;
			}
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x0000A9D7 File Offset: 0x00008BD7
		private void btnTheNoiDia_Click(object sender, EventArgs e)
		{
			Process.Start("http://pay.gameauto.net/payment/auto_bank.php");
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x0000AA03 File Offset: 0x00008C03
		[CompilerGenerated]
		private void method_7()
		{
			this.txtCaptcha.Text = "";
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x0000AA15 File Offset: 0x00008C15
		[CompilerGenerated]
		private void method_8()
		{
			this.lblStatus.Text = "Lỗi khi nạp thẻ, báo admin";
			this.lblStatus.ForeColor = Color.Red;
			frmLogin.class101_0.globalSettings_0.FailedCaptcha++;
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x0000AA4E File Offset: 0x00008C4E
		[CompilerGenerated]
		private void method_9()
		{
			if (!this.picCaptcha.Visible)
			{
				this.method_3(true);
			}
			this.method_4();
		}

		// Token: 0x04000EB1 RID: 3761
		private int int_0;

		// Token: 0x04000EB2 RID: 3762
		private int int_1;

		// Token: 0x04000EB3 RID: 3763
		private string string_0 = "Tặng 10% khi chuyển khoản ngân hàng 100K+";

		// Token: 0x04000EB4 RID: 3764
		private SecureString secureString_0 = new SecureString();

		// Token: 0x04000EB5 RID: 3765
		internal string string_1 = "";

		// Token: 0x04000EB6 RID: 3766
		internal Bitmap bitmap_0;

		// Token: 0x04000EB7 RID: 3767
		internal Class101 class101_0;

		// Token: 0x04000EB8 RID: 3768
		private int int_2;

		// Token: 0x04000EB9 RID: 3769
		private object object_0 = new object();

		// Token: 0x02000101 RID: 257
		[CompilerGenerated]
		private sealed class Class176
		{
			// Token: 0x06000A96 RID: 2710 RVA: 0x000CCA64 File Offset: 0x000CAC64
			internal void method_0()
			{
				this.string_0 = this.frmNapThe_0.txtCardType.SelectedItem.ToString().Split(new char[]
				{
					'|'
				})[1].Trim();
				if (this.frmNapThe_0.cboMenhGia.Text != "")
				{
					this.string_1 = this.frmNapThe_0.cboMenhGia.Text.Replace(",", "");
				}
			}

			// Token: 0x04000EE5 RID: 3813
			public string string_0;

			// Token: 0x04000EE6 RID: 3814
			public string string_1;

			// Token: 0x04000EE7 RID: 3815
			public frmNapThe frmNapThe_0;
		}

		// Token: 0x02000102 RID: 258
		[CompilerGenerated]
		private sealed class Class177
		{
			// Token: 0x06000A98 RID: 2712 RVA: 0x000CCAE4 File Offset: 0x000CACE4
			internal void method_0()
			{
				if (this.string_0 != "")
				{
					this.class176_0.frmNapThe_0.lblStatus.Text = string.Format("Lỗi: {0} ({1})", this.string_0, this.string_1);
				}
				else
				{
					this.class176_0.frmNapThe_0.lblStatus.Text = string.Format("Lỗi: {0}", this.string_1);
				}
				this.class176_0.frmNapThe_0.lblStatus.ForeColor = Color.Red;
				frmLogin.class101_0.globalSettings_0.FailedCaptcha++;
			}

			// Token: 0x06000A99 RID: 2713 RVA: 0x0000AA6A File Offset: 0x00008C6A
			internal void method_1()
			{
				this.class176_0.frmNapThe_0.lblStatus.ForeColor = Color.DarkGreen;
				this.class176_0.frmNapThe_0.lblStatus.Text = this.string_0;
			}

			// Token: 0x04000EE8 RID: 3816
			public string string_0;

			// Token: 0x04000EE9 RID: 3817
			public string string_1;

			// Token: 0x04000EEA RID: 3818
			public frmNapThe.Class176 class176_0;
		}

		// Token: 0x02000103 RID: 259
		[CompilerGenerated]
		private sealed class Class178
		{
			// Token: 0x06000A9B RID: 2715 RVA: 0x000CCB88 File Offset: 0x000CAD88
			internal void method_0()
			{
				if (!this.string_0.Contains("không hợp lệ") && !this.string_0.Contains("không đúng") && !(this.string_0 == ""))
				{
					this.frmNapThe_0.lblMaKMResult.ForeColor = Color.Blue;
				}
				else
				{
					this.frmNapThe_0.lblMaKMResult.ForeColor = Color.Red;
				}
				if (this.string_0 != "")
				{
					this.frmNapThe_0.lblMaKMResult.Text = this.string_0;
					return;
				}
				this.frmNapThe_0.lblMaKMResult.Text = "Lỗi xử lý mã khuyến mãi";
			}

			// Token: 0x04000EEB RID: 3819
			public frmNapThe frmNapThe_0;

			// Token: 0x04000EEC RID: 3820
			public string string_0;
		}
	}
}
