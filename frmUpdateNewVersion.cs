using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x0200010C RID: 268
	internal sealed partial class frmUpdateNewVersion : Form
	{
		// Token: 0x06000ADE RID: 2782 RVA: 0x0000AC93 File Offset: 0x00008E93
		internal frmUpdateNewVersion()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x0000ACA1 File Offset: 0x00008EA1
		private void btnGetCurrentPos_Click(object sender, EventArgs e)
		{
			Class83.smethod_85();
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x000098D4 File Offset: 0x00007AD4
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x0000ACA8 File Offset: 0x00008EA8
		private void button1_Click(object sender, EventArgs e)
		{
			frmUpdateNewVersion.bool_0 = true;
			Class83.smethod_62(false);
			base.Close();
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_0(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x000024E9 File Offset: 0x000006E9
		private void frmUpdateNewVersion_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04000F64 RID: 3940
		internal static bool bool_0;
	}
}
