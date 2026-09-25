namespace ns0
{
	// Token: 0x0200010C RID: 268
	internal sealed partial class frmUpdateNewVersion : global::System.Windows.Forms.Form
	{
		// Token: 0x06000AE4 RID: 2788 RVA: 0x0000ACBC File Offset: 0x00008EBC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x000D2654 File Offset: 0x000D0854
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmUpdateNewVersion));
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnGetCurrentPos = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			componentResourceManager.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			componentResourceManager.ApplyResources(this.btnGetCurrentPos, "btnGetCurrentPos");
			this.btnGetCurrentPos.Name = "btnGetCurrentPos";
			this.btnGetCurrentPos.UseVisualStyleBackColor = true;
			this.btnGetCurrentPos.Click += new global::System.EventHandler(this.btnGetCurrentPos_Click);
			componentResourceManager.ApplyResources(this.button1, "button1");
			this.button1.BackColor = global::System.Drawing.Color.PaleGreen;
			this.button1.Name = "button1";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			componentResourceManager.ApplyResources(this.button2, "button2");
			this.button2.Name = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			componentResourceManager.ApplyResources(this.pictureBox1, "pictureBox1");
			this.pictureBox1.ErrorImage = global::ns0.Class212.info1;
			this.pictureBox1.Image = global::ns0.Class212.info1;
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabStop = false;
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.btnGetCurrentPos);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "frmUpdateNewVersion";
			base.ShowIcon = false;
			base.Load += new global::System.EventHandler(this.frmUpdateNewVersion_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000F65 RID: 3941
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000F66 RID: 3942
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000F67 RID: 3943
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000F68 RID: 3944
		private global::System.Windows.Forms.Button btnGetCurrentPos;

		// Token: 0x04000F69 RID: 3945
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000F6A RID: 3946
		private global::System.Windows.Forms.Button button2;
	}
}
