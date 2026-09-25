using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SmartBot;

namespace ns0
{
	// Token: 0x0200010F RID: 271
	internal sealed partial class frmVersions_FW : Form
	{
		// Token: 0x06000B03 RID: 2819 RVA: 0x000D4A98 File Offset: 0x000D2C98
		internal frmVersions_FW(bool bool_2)
		{
			this.InitializeComponent();
			this.bool_0 = bool_2;
			if (!bool_2)
			{
				this.btnLater.Enabled = false;
				this.btnLater.Visible = false;
			}
			this.Text = GlobalSettings.GameName;
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x000D4AF0 File Offset: 0x000D2CF0
		private void frmVersions_FW_Load(object sender, EventArgs e)
		{
			string text = Class83.smethod_17(this.string_0);
			this.richVersion.Text = text;
			if (this.bool_1)
			{
				this.lbUpdateText.Text = "Có phiên bản auto mới, bạn cần phải cập nhật.\n\n(Auto tự lưu lại bản hiện tại vào thư mục auto. Nếu phiên bản mới hoạt động không ổn định bạn có thể dùng lại bản cũ và báo lỗi cho Admin)\n\nBấm 'Cập nhật' để tải phiên bản mới.";
			}
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0000AD9F File Offset: 0x00008F9F
		private void btnLater_Click(object sender, EventArgs e)
		{
			frmLogin.int_7 = 2;
			base.Close();
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0000ADAD File Offset: 0x00008FAD
		private void frmVersions_FW_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (!this.bool_0)
			{
				frmLogin.int_7 = 1;
				return;
			}
			if (frmLogin.int_7 == 0)
			{
				frmLogin.int_7 = 2;
			}
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x0000ADCB File Offset: 0x00008FCB
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			frmLogin.int_7 = 1;
			base.Close();
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0000AC1F File Offset: 0x00008E1F
		private void frmVersions_FW_Shown(object sender, EventArgs e)
		{
			base.TopMost = true;
		}

		// Token: 0x04000F8D RID: 3981
		internal string string_0 = "";

		// Token: 0x04000F8E RID: 3982
		internal bool bool_0 = true;

		// Token: 0x04000F8F RID: 3983
		internal bool bool_1;
	}
}
