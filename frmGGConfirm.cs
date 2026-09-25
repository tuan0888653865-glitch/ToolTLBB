using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x020000E6 RID: 230
	internal sealed partial class frmGGConfirm : Form
	{
		// Token: 0x06000897 RID: 2199 RVA: 0x000099D0 File Offset: 0x00007BD0
		internal frmGGConfirm()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x000099E9 File Offset: 0x00007BE9
		private void btnExit_Click(object sender, EventArgs e)
		{
			frmLogin.class101_0.dialogResult_0 = DialogResult.No;
			base.Close();
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x000099FC File Offset: 0x00007BFC
		private void tboxConfirm_TextChanged(object sender, EventArgs e)
		{
			if (this.tboxConfirm.Text.ToLower() == "ok")
			{
				this.btnConfirm.Enabled = true;
				return;
			}
			this.btnConfirm.Enabled = false;
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x000A0764 File Offset: 0x0009E964
		private void btnConfirm_Click(object sender, EventArgs e)
		{
			if (this.tboxConfirm.Text.ToLower() != "ok")
			{
				MessageBox.Show(frmMain.String_316, frmMain.String_315, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			frmLogin.class101_0.dialogResult_0 = DialogResult.Yes;
			base.Close();
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00009A33 File Offset: 0x00007C33
		private void frmGGConfirm_Shown(object sender, EventArgs e)
		{
			this.lblContent.Text = this.string_0;
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x000024E9 File Offset: 0x000006E9
		private void frmGGConfirm_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04000B3A RID: 2874
		internal string string_0 = frmMain.String_314;
	}
}
