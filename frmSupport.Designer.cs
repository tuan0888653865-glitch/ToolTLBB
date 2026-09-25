namespace ns0
{
	// Token: 0x02000109 RID: 265
	internal sealed partial class frmSupport : global::System.Windows.Forms.Form
	{
		// Token: 0x06000AD4 RID: 2772 RVA: 0x0000ABE7 File Offset: 0x00008DE7
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x000D218C File Offset: 0x000D038C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmSupport));
			this.btnOKPassword = new global::System.Windows.Forms.Button();
			this.txtSupportPassword = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			componentResourceManager.ApplyResources(this.btnOKPassword, "btnOKPassword");
			this.btnOKPassword.Name = "btnOKPassword";
			this.btnOKPassword.UseVisualStyleBackColor = true;
			this.btnOKPassword.Click += new global::System.EventHandler(this.btnOKPassword_Click);
			componentResourceManager.ApplyResources(this.txtSupportPassword, "txtSupportPassword");
			this.txtSupportPassword.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSupportPassword.Name = "txtSupportPassword";
			this.txtSupportPassword.UseSystemPasswordChar = true;
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.btnOKPassword);
			base.Controls.Add(this.txtSupportPassword);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "frmSupport";
			base.Load += new global::System.EventHandler(this.frmSupport_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000F51 RID: 3921
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000F52 RID: 3922
		private global::System.Windows.Forms.Button btnOKPassword;

		// Token: 0x04000F53 RID: 3923
		private global::System.Windows.Forms.TextBox txtSupportPassword;
	}
}
