using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000109 RID: 265
	internal sealed partial class frmSupport : Form
	{
		// Token: 0x06000AD1 RID: 2769 RVA: 0x0000ABD9 File Offset: 0x00008DD9
		internal frmSupport()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x000024E9 File Offset: 0x000006E9
		private void frmSupport_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x000D2140 File Offset: 0x000D0340
		private void btnOKPassword_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(this.txtSupportPassword.Text) && this.txtSupportPassword.Text == "messner")
			{
				frmLogin.class101_0.globalSettings_0.ShowSupportLog = true;
			}
			base.Dispose();
		}
	}
}
