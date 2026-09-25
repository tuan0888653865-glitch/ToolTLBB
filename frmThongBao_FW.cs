using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x0200010B RID: 267
	internal sealed partial class frmThongBao_FW : Form
	{
		// Token: 0x06000AD6 RID: 2774 RVA: 0x0000AC06 File Offset: 0x00008E06
		internal frmThongBao_FW()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x0000AC1F File Offset: 0x00008E1F
		private void frmThongBao_FW_Load(object sender, EventArgs e)
		{
			base.TopMost = true;
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x000D22A8 File Offset: 0x000D04A8
		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (frmLogin.stopwatch_0.ElapsedMilliseconds > frmThongBao_FW.long_0)
			{
				this.method_0();
				return;
			}
			this.long_1 = Math.Abs(frmLogin.stopwatch_0.ElapsedMilliseconds - frmThongBao_FW.long_0) / 1000L;
			if (this.long_1 <= 5L)
			{
				this.lblSeconds.ForeColor = Color.Red;
			}
			this.lblSeconds.Text = this.long_1.ToString("00") + " giây";
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x0000AC28 File Offset: 0x00008E28
		private void method_0()
		{
			base.Close();
			frmThongBao_FW.frmThongBao_FW_0 = null;
			frmThongBao_FW.long_0 = 0L;
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x0000AC3D File Offset: 0x00008E3D
		private void btnYes_Click(object sender, EventArgs e)
		{
			this.method_0();
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x0000AC45 File Offset: 0x00008E45
		private void frmThongBao_FW_FormClosed(object sender, FormClosedEventArgs e)
		{
			frmThongBao_FW.frmThongBao_FW_0 = null;
			frmThongBao_FW.long_0 = 0L;
			if (frmThongBao_FW.int_0 == 1)
			{
				Class101.smethod_66();
			}
			if (frmThongBao_FW.int_0 == 2)
			{
				frmLogin.bool_31 = true;
				Class101.smethod_66();
			}
		}

		// Token: 0x04000F58 RID: 3928
		internal static int int_0;

		// Token: 0x04000F59 RID: 3929
		internal static frmThongBao_FW frmThongBao_FW_0;

		// Token: 0x04000F5A RID: 3930
		internal static long long_0;

		// Token: 0x04000F5B RID: 3931
		internal long long_1;

		// Token: 0x04000F5C RID: 3932
		internal int int_1 = 5000;

		// Token: 0x04000F5D RID: 3933
		internal Enum22 enum22_0;
	}
}
