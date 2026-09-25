namespace ns0
{
	// Token: 0x020000E6 RID: 230
	internal sealed partial class frmGGConfirm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600089D RID: 2205 RVA: 0x00009A46 File Offset: 0x00007C46
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x000A07B4 File Offset: 0x0009E9B4
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmGGConfirm));
			this.lblContent = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.tboxConfirm = new global::System.Windows.Forms.TextBox();
			this.btnConfirm = new global::System.Windows.Forms.Button();
			this.btnExit = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			componentResourceManager.ApplyResources(this.lblContent, "lblContent");
			this.lblContent.ForeColor = global::System.Drawing.Color.Red;
			this.lblContent.Name = "lblContent";
			componentResourceManager.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			componentResourceManager.ApplyResources(this.tboxConfirm, "tboxConfirm");
			this.tboxConfirm.BackColor = global::System.Drawing.Color.LightGreen;
			this.tboxConfirm.Name = "tboxConfirm";
			this.tboxConfirm.TextChanged += new global::System.EventHandler(this.tboxConfirm_TextChanged);
			componentResourceManager.ApplyResources(this.btnConfirm, "btnConfirm");
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.UseVisualStyleBackColor = true;
			this.btnConfirm.Click += new global::System.EventHandler(this.btnConfirm_Click);
			componentResourceManager.ApplyResources(this.btnExit, "btnExit");
			this.btnExit.Name = "btnExit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new global::System.EventHandler(this.btnExit_Click);
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.btnExit);
			base.Controls.Add(this.btnConfirm);
			base.Controls.Add(this.tboxConfirm);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.lblContent);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "frmGGConfirm";
			base.ShowIcon = false;
			base.Load += new global::System.EventHandler(this.frmGGConfirm_Load);
			base.Shown += new global::System.EventHandler(this.frmGGConfirm_Shown);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000B3B RID: 2875
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000B3C RID: 2876
		private global::System.Windows.Forms.Label lblContent;

		// Token: 0x04000B3D RID: 2877
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000B3E RID: 2878
		private global::System.Windows.Forms.TextBox tboxConfirm;

		// Token: 0x04000B3F RID: 2879
		private global::System.Windows.Forms.Button btnConfirm;

		// Token: 0x04000B40 RID: 2880
		private global::System.Windows.Forms.Button btnExit;
	}
}
