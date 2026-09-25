namespace ns0
{
	// Token: 0x020000FA RID: 250
	internal sealed partial class frmLiteVersion : global::System.Windows.Forms.Form
	{
		// Token: 0x060009E6 RID: 2534 RVA: 0x0000A3BC File Offset: 0x000085BC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x000C24F8 File Offset: 0x000C06F8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmLiteVersion));
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.btnNapThe = new global::System.Windows.Forms.Button();
			this.btnDongY = new global::System.Windows.Forms.Button();
			this.btnExit = new global::System.Windows.Forms.Button();
			this.btnFacebook = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.rdio_9999_day = new global::System.Windows.Forms.RadioButton();
			this.rdio_360_day = new global::System.Windows.Forms.RadioButton();
			this.rdio_180_day = new global::System.Windows.Forms.RadioButton();
			this.rdio_90_day = new global::System.Windows.Forms.RadioButton();
			this.rdio_30_day = new global::System.Windows.Forms.RadioButton();
			this.rdio_6_day = new global::System.Windows.Forms.RadioButton();
			this.rdio_1_day = new global::System.Windows.Forms.RadioButton();
			this.label6 = new global::System.Windows.Forms.Label();
			this.btnMuaBlock = new global::System.Windows.Forms.Button();
			this.lblGGBalance = new global::System.Windows.Forms.Label();
			this.lblAccountName = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			componentResourceManager.ApplyResources(this.label1, "label1");
			this.label1.ForeColor = global::System.Drawing.Color.DodgerBlue;
			this.label1.Name = "label1";
			componentResourceManager.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			componentResourceManager.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			componentResourceManager.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			componentResourceManager.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
			this.btnNapThe.BackColor = global::System.Drawing.Color.PaleGreen;
			componentResourceManager.ApplyResources(this.btnNapThe, "btnNapThe");
			this.btnNapThe.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.btnNapThe.Name = "btnNapThe";
			this.btnNapThe.UseVisualStyleBackColor = false;
			this.btnNapThe.Click += new global::System.EventHandler(this.btnNapThe_Click);
			componentResourceManager.ApplyResources(this.btnDongY, "btnDongY");
			this.btnDongY.Name = "btnDongY";
			this.btnDongY.UseVisualStyleBackColor = true;
			this.btnDongY.Click += new global::System.EventHandler(this.btnDongY_Click);
			componentResourceManager.ApplyResources(this.btnExit, "btnExit");
			this.btnExit.Name = "btnExit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new global::System.EventHandler(this.btnExit_Click);
			this.btnFacebook.BackColor = global::System.Drawing.Color.Transparent;
			componentResourceManager.ApplyResources(this.btnFacebook, "btnFacebook");
			this.btnFacebook.ForeColor = global::System.Drawing.Color.Transparent;
			this.btnFacebook.Image = global::ns0.Class212.facebook;
			this.btnFacebook.Name = "btnFacebook";
			this.btnFacebook.UseVisualStyleBackColor = false;
			this.btnFacebook.Click += new global::System.EventHandler(this.btnFacebook_Click);
			this.pictureBox1.Image = global::ns0.Class212.money;
			componentResourceManager.ApplyResources(this.pictureBox1, "pictureBox1");
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabStop = false;
			this.groupBox1.Controls.Add(this.rdio_9999_day);
			this.groupBox1.Controls.Add(this.rdio_360_day);
			this.groupBox1.Controls.Add(this.rdio_180_day);
			this.groupBox1.Controls.Add(this.rdio_90_day);
			this.groupBox1.Controls.Add(this.rdio_30_day);
			this.groupBox1.Controls.Add(this.rdio_6_day);
			this.groupBox1.Controls.Add(this.rdio_1_day);
			componentResourceManager.ApplyResources(this.groupBox1, "groupBox1");
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabStop = false;
			componentResourceManager.ApplyResources(this.rdio_9999_day, "rdio_9999_day");
			this.rdio_9999_day.Name = "rdio_9999_day";
			this.rdio_9999_day.TabStop = true;
			this.rdio_9999_day.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.rdio_360_day, "rdio_360_day");
			this.rdio_360_day.Name = "rdio_360_day";
			this.rdio_360_day.TabStop = true;
			this.rdio_360_day.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.rdio_180_day, "rdio_180_day");
			this.rdio_180_day.Name = "rdio_180_day";
			this.rdio_180_day.TabStop = true;
			this.rdio_180_day.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.rdio_90_day, "rdio_90_day");
			this.rdio_90_day.Name = "rdio_90_day";
			this.rdio_90_day.TabStop = true;
			this.rdio_90_day.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.rdio_30_day, "rdio_30_day");
			this.rdio_30_day.Name = "rdio_30_day";
			this.rdio_30_day.TabStop = true;
			this.rdio_30_day.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.rdio_6_day, "rdio_6_day");
			this.rdio_6_day.Name = "rdio_6_day";
			this.rdio_6_day.TabStop = true;
			this.rdio_6_day.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.rdio_1_day, "rdio_1_day");
			this.rdio_1_day.Name = "rdio_1_day";
			this.rdio_1_day.TabStop = true;
			this.rdio_1_day.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.label6, "label6");
			this.label6.Name = "label6";
			this.btnMuaBlock.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnMuaBlock.ForeColor = global::System.Drawing.Color.DarkGreen;
			componentResourceManager.ApplyResources(this.btnMuaBlock, "btnMuaBlock");
			this.btnMuaBlock.Name = "btnMuaBlock";
			this.btnMuaBlock.UseVisualStyleBackColor = false;
			this.btnMuaBlock.Click += new global::System.EventHandler(this.btnMuaBlock_Click);
			componentResourceManager.ApplyResources(this.lblGGBalance, "lblGGBalance");
			this.lblGGBalance.Name = "lblGGBalance";
			componentResourceManager.ApplyResources(this.lblAccountName, "lblAccountName");
			this.lblAccountName.Name = "lblAccountName";
			componentResourceManager.ApplyResources(this.label7, "label7");
			this.label7.Name = "label7";
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.WhiteSmoke;
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.btnMuaBlock);
			base.Controls.Add(this.lblGGBalance);
			base.Controls.Add(this.lblAccountName);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.btnExit);
			base.Controls.Add(this.btnFacebook);
			base.Controls.Add(this.btnNapThe);
			base.Controls.Add(this.btnDongY);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "frmLiteVersion";
			base.ShowIcon = false;
			base.Load += new global::System.EventHandler(this.frmLiteVersion_Load);
			base.Shown += new global::System.EventHandler(this.frmLiteVersion_Shown);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.groupBox1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000D71 RID: 3441
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000D72 RID: 3442
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000D73 RID: 3443
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000D74 RID: 3444
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000D75 RID: 3445
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000D76 RID: 3446
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000D77 RID: 3447
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000D78 RID: 3448
		private global::System.Windows.Forms.Button btnNapThe;

		// Token: 0x04000D79 RID: 3449
		private global::System.Windows.Forms.Button btnDongY;

		// Token: 0x04000D7A RID: 3450
		private global::System.Windows.Forms.Button btnFacebook;

		// Token: 0x04000D7B RID: 3451
		private global::System.Windows.Forms.Button btnExit;

		// Token: 0x04000D7C RID: 3452
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000D7D RID: 3453
		private global::System.Windows.Forms.RadioButton rdio_9999_day;

		// Token: 0x04000D7E RID: 3454
		private global::System.Windows.Forms.RadioButton rdio_360_day;

		// Token: 0x04000D7F RID: 3455
		private global::System.Windows.Forms.RadioButton rdio_180_day;

		// Token: 0x04000D80 RID: 3456
		private global::System.Windows.Forms.RadioButton rdio_90_day;

		// Token: 0x04000D81 RID: 3457
		private global::System.Windows.Forms.RadioButton rdio_30_day;

		// Token: 0x04000D82 RID: 3458
		private global::System.Windows.Forms.RadioButton rdio_6_day;

		// Token: 0x04000D83 RID: 3459
		private global::System.Windows.Forms.RadioButton rdio_1_day;

		// Token: 0x04000D84 RID: 3460
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000D85 RID: 3461
		private global::System.Windows.Forms.Button btnMuaBlock;

		// Token: 0x04000D86 RID: 3462
		private global::System.Windows.Forms.Label lblGGBalance;

		// Token: 0x04000D87 RID: 3463
		private global::System.Windows.Forms.Label lblAccountName;

		// Token: 0x04000D88 RID: 3464
		private global::System.Windows.Forms.Label label7;
	}
}
