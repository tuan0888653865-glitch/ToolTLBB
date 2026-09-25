using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x020000F4 RID: 244
	internal sealed partial class frmNVTanThu : Form
	{
		// Token: 0x0600097E RID: 2430 RVA: 0x00009FDD File Offset: 0x000081DD
		internal frmNVTanThu()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x000024E9 File Offset: 0x000006E9
		private void frmNVTanThu_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00009FEB File Offset: 0x000081EB
		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (this.class58_0 != null)
			{
				this.cboxTanThu.Checked = this.class58_0.class114_0.bool_171;
			}
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x000AFD90 File Offset: 0x000ADF90
		private void cboxTanThu_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;
			if (this.class58_0 != null && checkBox.Focused)
			{
				this.class58_0.class114_0.bool_171 = checkBox.Checked;
			}
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0000997A File Offset: 0x00007B7A
		private void frmNVTanThu_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			base.Hide();
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x000AFDCC File Offset: 0x000ADFCC
		private void btnDanhCo_Click(object sender, EventArgs e)
		{
			frmLogin.class101_0.CurrentAuto.class114_0.int_108 = 20;
			frmLogin.class101_0.CurrentAuto.class75_0.int_22 = 0;
			if (!frmLogin.class101_0.CurrentAuto.class114_0.bool_171)
			{
				frmLogin.class101_0.CurrentAuto.class75_0.bool_17 = true;
				frmMain.frmMain_0.method_248(frmLogin.class101_0.CurrentAuto);
			}
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x000AFE44 File Offset: 0x000AE044
		private void btnAcTac_Click(object sender, EventArgs e)
		{
			frmLogin.class101_0.CurrentAuto.class114_0.int_108 = 22;
			frmLogin.class101_0.CurrentAuto.class75_0.int_22 = 0;
			if (!frmLogin.class101_0.CurrentAuto.class114_0.bool_171)
			{
				frmLogin.class101_0.CurrentAuto.class75_0.bool_17 = true;
				frmMain.frmMain_0.method_248(frmLogin.class101_0.CurrentAuto);
			}
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x000AFEBC File Offset: 0x000AE0BC
		private void btnAcBa_Click(object sender, EventArgs e)
		{
			frmLogin.class101_0.CurrentAuto.class114_0.int_108 = 24;
			frmLogin.class101_0.CurrentAuto.class75_0.int_22 = 0;
			if (!frmLogin.class101_0.CurrentAuto.class114_0.bool_171)
			{
				frmLogin.class101_0.CurrentAuto.class75_0.bool_17 = true;
				frmMain.frmMain_0.method_248(frmLogin.class101_0.CurrentAuto);
			}
		}

		// Token: 0x04000C7F RID: 3199
		internal Class58 class58_0;
	}
}
