namespace ns0
{
	// Token: 0x020000E7 RID: 231
	internal sealed partial class frmGiftCode : global::System.Windows.Forms.Form
	{
		// Token: 0x060008A9 RID: 2217 RVA: 0x00009AE1 File Offset: 0x00007CE1
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x000A0F98 File Offset: 0x0009F198
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmGiftCode));
			this.label1 = new global::System.Windows.Forms.Label();
			this.rdioGGold = new global::System.Windows.Forms.RadioButton();
			this.rdioTien = new global::System.Windows.Forms.RadioButton();
			this.lblLoaiTK = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.txtGiftCode = new global::System.Windows.Forms.TextBox();
			this.lblCaptcha3 = new global::System.Windows.Forms.Label();
			this.lblStatus = new global::System.Windows.Forms.Label();
			this.btnNapThe = new global::System.Windows.Forms.Button();
			this.btnHuy = new global::System.Windows.Forms.Button();
			this.lblCaptcha = new global::System.Windows.Forms.Label();
			this.txtCaptcha = new global::System.Windows.Forms.TextBox();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.btnCaptcha = new global::System.Windows.Forms.Button();
			this.picCaptcha = new global::System.Windows.Forms.PictureBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.txtUsername = new global::System.Windows.Forms.TextBox();
			((global::System.ComponentModel.ISupportInitialize)this.picCaptcha).BeginInit();
			base.SuspendLayout();
			componentResourceManager.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			componentResourceManager.ApplyResources(this.rdioGGold, "rdioGGold");
			this.rdioGGold.ForeColor = global::System.Drawing.Color.Black;
			this.rdioGGold.Name = "rdioGGold";
			this.rdioGGold.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.rdioTien, "rdioTien");
			this.rdioTien.ForeColor = global::System.Drawing.Color.Black;
			this.rdioTien.Name = "rdioTien";
			this.rdioTien.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.lblLoaiTK, "lblLoaiTK");
			this.lblLoaiTK.Name = "lblLoaiTK";
			componentResourceManager.ApplyResources(this.label6, "label6");
			this.label6.Name = "label6";
			componentResourceManager.ApplyResources(this.txtGiftCode, "txtGiftCode");
			this.txtGiftCode.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtGiftCode.Name = "txtGiftCode";
			this.txtGiftCode.TextChanged += new global::System.EventHandler(this.txtGiftCode_TextChanged);
			componentResourceManager.ApplyResources(this.lblCaptcha3, "lblCaptcha3");
			this.lblCaptcha3.BackColor = global::System.Drawing.Color.Transparent;
			this.lblCaptcha3.ForeColor = global::System.Drawing.Color.SteelBlue;
			this.lblCaptcha3.Name = "lblCaptcha3";
			componentResourceManager.ApplyResources(this.lblStatus, "lblStatus");
			this.lblStatus.Name = "lblStatus";
			componentResourceManager.ApplyResources(this.btnNapThe, "btnNapThe");
			this.btnNapThe.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnNapThe.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.btnNapThe.Name = "btnNapThe";
			this.btnNapThe.UseVisualStyleBackColor = false;
			this.btnNapThe.Click += new global::System.EventHandler(this.btnNapThe_Click);
			componentResourceManager.ApplyResources(this.btnHuy, "btnHuy");
			this.btnHuy.BackColor = global::System.Drawing.Color.FromArgb(247, 207, 142);
			this.btnHuy.ForeColor = global::System.Drawing.Color.SaddleBrown;
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.UseVisualStyleBackColor = false;
			this.btnHuy.Click += new global::System.EventHandler(this.btnHuy_Click);
			componentResourceManager.ApplyResources(this.lblCaptcha, "lblCaptcha");
			this.lblCaptcha.BackColor = global::System.Drawing.Color.Transparent;
			this.lblCaptcha.Name = "lblCaptcha";
			componentResourceManager.ApplyResources(this.txtCaptcha, "txtCaptcha");
			this.txtCaptcha.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCaptcha.Name = "txtCaptcha";
			this.timer_0.Enabled = true;
			this.timer_0.Interval = 300;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			componentResourceManager.ApplyResources(this.btnCaptcha, "btnCaptcha");
			this.btnCaptcha.ForeColor = global::System.Drawing.Color.DodgerBlue;
			this.btnCaptcha.Image = global::ns0.Class212.Refresh_icon;
			this.btnCaptcha.Name = "btnCaptcha";
			this.btnCaptcha.UseVisualStyleBackColor = true;
			this.btnCaptcha.Click += new global::System.EventHandler(this.btnCaptcha_Click);
			componentResourceManager.ApplyResources(this.picCaptcha, "picCaptcha");
			this.picCaptcha.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.picCaptcha.Name = "picCaptcha";
			this.picCaptcha.TabStop = false;
			componentResourceManager.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			componentResourceManager.ApplyResources(this.txtUsername, "txtUsername");
			this.txtUsername.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUsername.Name = "txtUsername";
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.label2);
			base.Controls.Add(this.txtUsername);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.rdioGGold);
			base.Controls.Add(this.rdioTien);
			base.Controls.Add(this.lblLoaiTK);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.txtGiftCode);
			base.Controls.Add(this.lblCaptcha3);
			base.Controls.Add(this.lblStatus);
			base.Controls.Add(this.btnNapThe);
			base.Controls.Add(this.btnHuy);
			base.Controls.Add(this.btnCaptcha);
			base.Controls.Add(this.lblCaptcha);
			base.Controls.Add(this.txtCaptcha);
			base.Controls.Add(this.picCaptcha);
			base.Name = "frmGiftCode";
			base.Load += new global::System.EventHandler(this.frmGiftCode_Load);
			base.Shown += new global::System.EventHandler(this.frmGiftCode_Shown);
			((global::System.ComponentModel.ISupportInitialize)this.picCaptcha).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000B43 RID: 2883
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000B44 RID: 2884
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000B45 RID: 2885
		private global::System.Windows.Forms.RadioButton rdioGGold;

		// Token: 0x04000B46 RID: 2886
		private global::System.Windows.Forms.RadioButton rdioTien;

		// Token: 0x04000B47 RID: 2887
		private global::System.Windows.Forms.Label lblLoaiTK;

		// Token: 0x04000B48 RID: 2888
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000B49 RID: 2889
		private global::System.Windows.Forms.TextBox txtGiftCode;

		// Token: 0x04000B4A RID: 2890
		private global::System.Windows.Forms.Label lblCaptcha3;

		// Token: 0x04000B4B RID: 2891
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04000B4C RID: 2892
		private global::System.Windows.Forms.Button btnNapThe;

		// Token: 0x04000B4D RID: 2893
		private global::System.Windows.Forms.Button btnHuy;

		// Token: 0x04000B4E RID: 2894
		private global::System.Windows.Forms.Button btnCaptcha;

		// Token: 0x04000B4F RID: 2895
		private global::System.Windows.Forms.Label lblCaptcha;

		// Token: 0x04000B50 RID: 2896
		private global::System.Windows.Forms.TextBox txtCaptcha;

		// Token: 0x04000B51 RID: 2897
		private global::System.Windows.Forms.PictureBox picCaptcha;

		// Token: 0x04000B52 RID: 2898
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000B53 RID: 2899
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000B54 RID: 2900
		private global::System.Windows.Forms.TextBox txtUsername;
	}
}
