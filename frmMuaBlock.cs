using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x020000F2 RID: 242
	internal sealed partial class frmMuaBlock : Form
	{
		// Token: 0x06000962 RID: 2402 RVA: 0x00009F25 File Offset: 0x00008125
		internal frmMuaBlock()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x000024E9 File Offset: 0x000006E9
		private void frmMuaBlock_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00009F33 File Offset: 0x00008133
		private void frmMuaBlock_Shown(object sender, EventArgs e)
		{
			this.method_0();
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x000AC940 File Offset: 0x000AAB40
		internal void method_0()
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

		// Token: 0x06000966 RID: 2406 RVA: 0x000ACB88 File Offset: 0x000AAD88
		private void btnMuaBlock_Click(object sender, EventArgs e)
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
				if (text2.Contains("successfully.") || text2.Contains("thành công.") || text2.Contains("购买成功"))
				{
					base.Close();
				}
			}
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x0000997A File Offset: 0x00007B7A
		private void frmMuaBlock_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			base.Hide();
		}
	}
}
