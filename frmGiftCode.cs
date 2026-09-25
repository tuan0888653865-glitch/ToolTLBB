using System;
using System.ComponentModel;
using System.Drawing;
using System.Security;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x020000E7 RID: 231
	internal sealed partial class frmGiftCode : Form
	{
		// Token: 0x0600089F RID: 2207 RVA: 0x00009A65 File Offset: 0x00007C65
		internal frmGiftCode()
		{
			this.InitializeComponent();
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x000098D4 File Offset: 0x00007AD4
		private void btnHuy_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x000024E9 File Offset: 0x000006E9
		private void timer_0_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x000A09E0 File Offset: 0x0009EBE0
		private void btnNapThe_Click(object sender, EventArgs e)
		{
			if (this.rdioTien.Checked || this.rdioGGold.Checked)
			{
				bool flag = false;
				if (this.picCaptcha.Visible)
				{
					string a = Class83.smethod_71(this.secureString_0).ToLower();
					string b = this.txtCaptcha.Text.ToLower();
					if (a == b)
					{
						flag = true;
					}
					this.txtCaptcha.Text = "";
					GC.Collect();
				}
				else if (frmLogin.class101_0.globalSettings_0.GiftCodeCaptchas < 3)
				{
					flag = true;
				}
				if (flag)
				{
					if (!string.IsNullOrEmpty(this.txtGiftCode.Text) && !string.IsNullOrEmpty(this.txtUsername.Text))
					{
						string string_ = string.Format("giftcode={0}&giftuser={1}&giftid={2}&giftmode={3}", new object[]
						{
							HttpUtility.UrlEncode(this.txtGiftCode.Text),
							HttpUtility.UrlEncode(this.txtUsername.Text),
							HttpUtility.UrlEncode(frmLogin.class101_0.globalSettings_0.Account.string_9),
							HttpUtility.UrlEncode(this.rdioTien.Checked ? "ss" : "gg")
						});
						string text = "";
						if (frmLogin.string_0 == "VN")
						{
							text = Class83.smethod_125(frmLogin.class132_0.string_0 + frmLogin.class101_0.globalSettings_0.GiftCodeURL, string_, "POST", frmLogin.class101_0.globalSettings_0.MainCookie, true);
						}
						else
						{
							text = Class83.smethod_125(frmLogin.class101_0.globalSettings_0.GiftCodeURL, string_, "POST", frmLogin.class101_0.globalSettings_0.MainCookie, true);
						}
						if (text != frmLogin.class101_0.globalSettings_0.LoadWebErrorMessage)
						{
							text = HttpUtility.UrlDecode(text);
							try
							{
								byte[] bytes = Convert.FromBase64String(text);
								text = Encoding.UTF8.GetString(bytes);
							}
							catch (Exception)
							{
								this.lblStatus.Text = string.Format("Error decrypting data.", new object[0]);
								this.lblStatus.ForeColor = Color.Red;
							}
							string text2 = Class83.smethod_81(text, "gmessage", false);
							if (text2.Contains("%2"))
							{
								text2 = HttpUtility.UrlDecode(text2);
							}
							if (text2.EndsWith("=") || !text2.Contains(" "))
							{
								try
								{
									byte[] bytes2 = Convert.FromBase64String(text2);
									text2 = Encoding.UTF8.GetString(bytes2);
								}
								catch (Exception)
								{
									this.lblStatus.Text = string.Format("Error decrypting data.", new object[0]);
									this.lblStatus.ForeColor = Color.Red;
								}
							}
							if (text2.Contains("someone else") || text2.Contains("đã sử dụng"))
							{
								frmLogin.class101_0.globalSettings_0.GiftCodeCaptchas++;
							}
							if (text2.Contains("Great!") || text2.Contains("Đã cộng") || text2.Contains("Added "))
							{
								frmLogin.class101_0.globalSettings_0.GiftCodeCaptchas = 0;
								string text3 = "";
								string text4 = "";
								Class83.smethod_77(out text3, out text4, true, false);
							}
							this.lblStatus.Text = frmMain.String_449 + ": " + string.Format(text2, new object[0]);
							this.lblStatus.ForeColor = Color.Blue;
						}
						else
						{
							this.lblStatus.Text = string.Format("Error connecting to the auto server.", new object[0]);
							this.lblStatus.ForeColor = Color.Red;
						}
					}
				}
				else
				{
					MessageBox.Show(frmMain.String_450, "Captcha", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				if (frmLogin.class101_0.globalSettings_0.GiftCodeCaptchas >= 3)
				{
					if (!this.picCaptcha.Visible)
					{
						this.method_0(true);
					}
					this.method_1();
				}
			}
			if (!this.rdioTien.Checked && !this.rdioGGold.Checked)
			{
				this.rdioTien.ForeColor = Color.Red;
				this.rdioGGold.ForeColor = Color.Red;
				MessageBox.Show(frmMain.String_714, frmMain.String_712, MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x000A0E18 File Offset: 0x0009F018
		private void method_0(bool bool_0)
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
				this.btnHuy.Top += num;
				this.btnNapThe.Top += num;
				this.btnCaptcha.Visible = visible;
				this.picCaptcha.Visible = visible;
				this.lblCaptcha.Visible = visible;
				this.txtCaptcha.Visible = visible;
				this.lblCaptcha3.Visible = visible;
			}
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x000A0EE4 File Offset: 0x0009F0E4
		private void method_1()
		{
			string string_ = Class83.smethod_98(6);
			this.secureString_0 = Class83.smethod_70(string_);
			GC.Collect();
			this.picCaptcha.Image = Class83.smethod_50(this.secureString_0);
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00009A7E File Offset: 0x00007C7E
		private void frmGiftCode_Load(object sender, EventArgs e)
		{
			if (frmLogin.class101_0.globalSettings_0.GiftCodeCaptchas < 3)
			{
				this.method_0(false);
				return;
			}
			this.method_0(true);
			this.method_1();
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00009AA7 File Offset: 0x00007CA7
		private void btnCaptcha_Click(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x000A0F24 File Offset: 0x0009F124
		private void txtGiftCode_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.txtGiftCode.Text))
			{
				this.rdioGGold.Enabled = false;
				this.rdioTien.Checked = true;
				return;
			}
			if (this.txtGiftCode.Text.Contains("-PRO-"))
			{
				this.rdioGGold.Enabled = true;
				return;
			}
			this.rdioGGold.Enabled = false;
			this.rdioTien.Checked = true;
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00009AAF File Offset: 0x00007CAF
		private void frmGiftCode_Shown(object sender, EventArgs e)
		{
			if (frmLogin.class101_0.globalSettings_0.Account != null)
			{
				this.txtUsername.Text = frmLogin.class101_0.globalSettings_0.Account.Username;
			}
		}

		// Token: 0x04000B41 RID: 2881
		internal Class58 class58_0;

		// Token: 0x04000B42 RID: 2882
		private SecureString secureString_0 = new SecureString();
	}
}
