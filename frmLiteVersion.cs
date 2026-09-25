using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x020000FA RID: 250
	internal sealed partial class frmLiteVersion : Form
	{
		// Token: 0x060009DD RID: 2525 RVA: 0x0000A384 File Offset: 0x00008584
		internal frmLiteVersion()
		{
			this.InitializeComponent();
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x000024E9 File Offset: 0x000006E9
		private void frmLiteVersion_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x0000A392 File Offset: 0x00008592
		private void btnNapThe_Click(object sender, EventArgs e)
		{
			frmMain.smethod_18();
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x000098D4 File Offset: 0x00007AD4
		private void btnDongY_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x0000A399 File Offset: 0x00008599
		private void btnFacebook_Click(object sender, EventArgs e)
		{
			Class83.smethod_91();
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x0000A3A0 File Offset: 0x000085A0
		private void btnExit_Click(object sender, EventArgs e)
		{
			frmLiteVersion.bool_0 = true;
			Class83.smethod_62(false);
			base.Close();
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x000C2060 File Offset: 0x000C0260
		internal void method_0()
		{
			try
			{
				if (frmLogin.string_0 == "EN" || frmLogin.string_0 == "CN")
				{
					this.lblAccountName.Text = string.Format(frmMain.String_1, frmLogin.class101_0.globalSettings_0.Account.Username);
					this.lblGGBalance.Text = string.Format(frmMain.String_2, frmLogin.class101_0.globalSettings_0.Account.RemainGGoldBalance.ToString("0"), frmLogin.class101_0.globalSettings_0.Account.RemainGGoldPromo.ToString("0"));
					string arg = "ngày";
					if (frmLogin.string_0 == "EN")
					{
						arg = "days";
					}
					else if (frmLogin.string_0 == "CN")
					{
						arg = "天";
					}
					this.rdio_1_day.Text = string.Format("1 {0} - {1} GG", arg, frmLogin.class101_0.globalSettings_0.BangGia["price_1"]);
					if (frmLogin.string_0 == "EN")
					{
						arg = "days";
					}
					this.rdio_6_day.Text = string.Format("6 {0} - {1} GG", arg, frmLogin.class101_0.globalSettings_0.BangGia["price_6"]);
					this.rdio_30_day.Text = string.Format("30 {0} - {1} GG", arg, frmLogin.class101_0.globalSettings_0.BangGia["price_30"]);
					this.rdio_90_day.Text = string.Format("90 {0} - {1} GG", arg, frmLogin.class101_0.globalSettings_0.BangGia["price_90"]);
					this.rdio_180_day.Text = string.Format("180 {0} - {1} GG", arg, frmLogin.class101_0.globalSettings_0.BangGia["price_180"]);
					this.rdio_360_day.Text = string.Format("360 {0} - {1} GG", arg, frmLogin.class101_0.globalSettings_0.BangGia["price_360"]);
					this.rdio_9999_day.Text = string.Format("Lifetime - {0} GG", frmLogin.class101_0.globalSettings_0.BangGia["price_9999"]);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0000A3B4 File Offset: 0x000085B4
		private void frmLiteVersion_Shown(object sender, EventArgs e)
		{
			this.method_0();
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x000C22EC File Offset: 0x000C04EC
		private void btnMuaBlock_Click(object sender, EventArgs e)
		{
			if (frmLogin.string_0 == "EN" || frmLogin.string_0 == "CN")
			{
				int num = 1;
				int num2 = 30;
				if (this.rdio_1_day.Checked)
				{
					num = 1;
					num2 = frmLogin.class101_0.globalSettings_0.BangGia["price_1"];
				}
				else if (this.rdio_6_day.Checked)
				{
					num = 6;
					num2 = frmLogin.class101_0.globalSettings_0.BangGia["price_6"];
				}
				else if (this.rdio_30_day.Checked)
				{
					num = 30;
					num2 = frmLogin.class101_0.globalSettings_0.BangGia["price_30"];
				}
				else if (this.rdio_90_day.Checked)
				{
					num = 90;
					num2 = frmLogin.class101_0.globalSettings_0.BangGia["price_90"];
				}
				else if (this.rdio_180_day.Checked)
				{
					num = 180;
					num2 = frmLogin.class101_0.globalSettings_0.BangGia["price_180"];
				}
				else if (this.rdio_360_day.Checked)
				{
					num = 360;
					num2 = frmLogin.class101_0.globalSettings_0.BangGia["price_360"];
				}
				else if (this.rdio_9999_day.Checked)
				{
					num = 9999;
					num2 = frmLogin.class101_0.globalSettings_0.BangGia["price_9999"];
				}
				if (MessageBox.Show(string.Format(frmMain.String_705, num.ToString(), num2.ToString()), frmMain.String_706, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					frmLogin.class101_0.globalSettings_0.Account.object_0 = num;
					string text = "";
					string text2 = "";
					Class83.smethod_77(out text, out text2, true, false);
					this.method_0();
					MessageBox.Show(text2, frmMain.String_708, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					if (text2.Contains("successfully.") || text2.Contains("thành công."))
					{
						base.Close();
					}
				}
			}
		}

		// Token: 0x04000D70 RID: 3440
		internal static bool bool_0;
	}
}
