namespace ns0
{
	// Token: 0x02000100 RID: 256
	internal sealed partial class frmNapThe : global::System.Windows.Forms.Form
	{
		// Token: 0x06000A90 RID: 2704 RVA: 0x0000A9E4 File Offset: 0x00008BE4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x000CBAE0 File Offset: 0x000C9CE0
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmNapThe));
			this.grpCardAdd = new global::System.Windows.Forms.GroupBox();
			this.cboMenhGia = new global::System.Windows.Forms.ComboBox();
			this.label64 = new global::System.Windows.Forms.Label();
			this.btnCoupon = new global::System.Windows.Forms.Button();
			this.lblMaKMResult = new global::System.Windows.Forms.Label();
			this.label13 = new global::System.Windows.Forms.Label();
			this.txtCoupon = new global::System.Windows.Forms.TextBox();
			this.lbNaptien = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.rdioGGold = new global::System.Windows.Forms.RadioButton();
			this.rdioTien = new global::System.Windows.Forms.RadioButton();
			this.lblLoaiTK = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.txtTenTaiKhoan = new global::System.Windows.Forms.TextBox();
			this.txtCardType = new global::System.Windows.Forms.ComboBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.txtCardSerial = new global::System.Windows.Forms.TextBox();
			this.txtCardCode = new global::System.Windows.Forms.TextBox();
			this.btnHuy = new global::System.Windows.Forms.Button();
			this.btnNapThe = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.lblCoupon = new global::System.Windows.Forms.Label();
			this.linkPrice = new global::System.Windows.Forms.LinkLabel();
			this.lblStatus = new global::System.Windows.Forms.Label();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.lblCaptcha = new global::System.Windows.Forms.Label();
			this.txtCaptcha = new global::System.Windows.Forms.TextBox();
			this.lblCaptcha2 = new global::System.Windows.Forms.Label();
			this.lblCaptcha3 = new global::System.Windows.Forms.Label();
			this.btnCaptcha = new global::System.Windows.Forms.Button();
			this.picCaptcha = new global::System.Windows.Forms.PictureBox();
			this.label12 = new global::System.Windows.Forms.Label();
			this.backgroundWorker_0 = new global::System.ComponentModel.BackgroundWorker();
			this.btnTheNoiDia = new global::System.Windows.Forms.Button();
			this.label63 = new global::System.Windows.Forms.Label();
			this.label62 = new global::System.Windows.Forms.Label();
			this.grpCardAdd.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.picCaptcha).BeginInit();
			base.SuspendLayout();
			this.grpCardAdd.Controls.Add(this.cboMenhGia);
			this.grpCardAdd.Controls.Add(this.label64);
			this.grpCardAdd.Controls.Add(this.btnCoupon);
			this.grpCardAdd.Controls.Add(this.lblMaKMResult);
			this.grpCardAdd.Controls.Add(this.label13);
			this.grpCardAdd.Controls.Add(this.txtCoupon);
			this.grpCardAdd.Controls.Add(this.lbNaptien);
			this.grpCardAdd.Controls.Add(this.label3);
			this.grpCardAdd.Controls.Add(this.rdioGGold);
			this.grpCardAdd.Controls.Add(this.rdioTien);
			this.grpCardAdd.Controls.Add(this.lblLoaiTK);
			this.grpCardAdd.Controls.Add(this.label11);
			this.grpCardAdd.Controls.Add(this.label10);
			this.grpCardAdd.Controls.Add(this.label9);
			this.grpCardAdd.Controls.Add(this.label8);
			this.grpCardAdd.Controls.Add(this.label2);
			this.grpCardAdd.Controls.Add(this.txtTenTaiKhoan);
			this.grpCardAdd.Controls.Add(this.txtCardType);
			this.grpCardAdd.Controls.Add(this.label7);
			this.grpCardAdd.Controls.Add(this.label6);
			this.grpCardAdd.Controls.Add(this.label5);
			this.grpCardAdd.Controls.Add(this.txtCardSerial);
			this.grpCardAdd.Controls.Add(this.txtCardCode);
			componentResourceManager.ApplyResources(this.grpCardAdd, "grpCardAdd");
			this.grpCardAdd.Name = "grpCardAdd";
			this.grpCardAdd.TabStop = false;
			componentResourceManager.ApplyResources(this.cboMenhGia, "cboMenhGia");
			this.cboMenhGia.FormattingEnabled = true;
			this.cboMenhGia.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("cboMenhGia.Items"),
				componentResourceManager.GetString("cboMenhGia.Items1"),
				componentResourceManager.GetString("cboMenhGia.Items2"),
				componentResourceManager.GetString("cboMenhGia.Items3")
			});
			this.cboMenhGia.Name = "cboMenhGia";
			componentResourceManager.ApplyResources(this.label64, "label64");
			this.label64.Name = "label64";
			this.btnCoupon.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnCoupon.ForeColor = global::System.Drawing.Color.DarkGreen;
			componentResourceManager.ApplyResources(this.btnCoupon, "btnCoupon");
			this.btnCoupon.Name = "btnCoupon";
			this.btnCoupon.UseVisualStyleBackColor = false;
			this.btnCoupon.Click += new global::System.EventHandler(this.btnCoupon_Click);
			componentResourceManager.ApplyResources(this.lblMaKMResult, "lblMaKMResult");
			this.lblMaKMResult.ForeColor = global::System.Drawing.Color.MediumBlue;
			this.lblMaKMResult.Name = "lblMaKMResult";
			componentResourceManager.ApplyResources(this.label13, "label13");
			this.label13.Name = "label13";
			this.txtCoupon.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtCoupon, "txtCoupon");
			this.txtCoupon.Name = "txtCoupon";
			componentResourceManager.ApplyResources(this.lbNaptien, "lbNaptien");
			this.lbNaptien.Name = "lbNaptien";
			componentResourceManager.ApplyResources(this.label3, "label3");
			this.label3.ForeColor = global::System.Drawing.Color.Red;
			this.label3.Name = "label3";
			componentResourceManager.ApplyResources(this.rdioGGold, "rdioGGold");
			this.rdioGGold.ForeColor = global::System.Drawing.Color.Black;
			this.rdioGGold.Name = "rdioGGold";
			this.rdioGGold.UseVisualStyleBackColor = true;
			this.rdioGGold.CheckedChanged += new global::System.EventHandler(this.rdioGGold_CheckedChanged);
			componentResourceManager.ApplyResources(this.rdioTien, "rdioTien");
			this.rdioTien.ForeColor = global::System.Drawing.Color.Black;
			this.rdioTien.Name = "rdioTien";
			this.rdioTien.UseVisualStyleBackColor = true;
			this.rdioTien.CheckedChanged += new global::System.EventHandler(this.rdioTien_CheckedChanged);
			this.rdioTien.Click += new global::System.EventHandler(this.rdioTien_Click);
			componentResourceManager.ApplyResources(this.lblLoaiTK, "lblLoaiTK");
			this.lblLoaiTK.Name = "lblLoaiTK";
			componentResourceManager.ApplyResources(this.label11, "label11");
			this.label11.ForeColor = global::System.Drawing.Color.Red;
			this.label11.Name = "label11";
			componentResourceManager.ApplyResources(this.label10, "label10");
			this.label10.ForeColor = global::System.Drawing.Color.Red;
			this.label10.Name = "label10";
			componentResourceManager.ApplyResources(this.label9, "label9");
			this.label9.ForeColor = global::System.Drawing.Color.Red;
			this.label9.Name = "label9";
			componentResourceManager.ApplyResources(this.label8, "label8");
			this.label8.ForeColor = global::System.Drawing.Color.Red;
			this.label8.Name = "label8";
			componentResourceManager.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			this.txtTenTaiKhoan.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtTenTaiKhoan, "txtTenTaiKhoan");
			this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
			componentResourceManager.ApplyResources(this.txtCardType, "txtCardType");
			this.txtCardType.FormattingEnabled = true;
			this.txtCardType.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("txtCardType.Items"),
				componentResourceManager.GetString("txtCardType.Items1"),
				componentResourceManager.GetString("txtCardType.Items2"),
				componentResourceManager.GetString("txtCardType.Items3")
			});
			this.txtCardType.Name = "txtCardType";
			this.txtCardType.SelectedIndexChanged += new global::System.EventHandler(this.txtCardType_SelectedIndexChanged);
			componentResourceManager.ApplyResources(this.label7, "label7");
			this.label7.Name = "label7";
			componentResourceManager.ApplyResources(this.label6, "label6");
			this.label6.Name = "label6";
			componentResourceManager.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
			this.txtCardSerial.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtCardSerial, "txtCardSerial");
			this.txtCardSerial.Name = "txtCardSerial";
			this.txtCardCode.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtCardCode, "txtCardCode");
			this.txtCardCode.Name = "txtCardCode";
			this.txtCardCode.TextChanged += new global::System.EventHandler(this.txtCardCode_TextChanged);
			this.btnHuy.BackColor = global::System.Drawing.Color.FromArgb(247, 207, 142);
			this.btnHuy.ForeColor = global::System.Drawing.Color.SaddleBrown;
			componentResourceManager.ApplyResources(this.btnHuy, "btnHuy");
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.UseVisualStyleBackColor = false;
			this.btnHuy.Click += new global::System.EventHandler(this.btnHuy_Click);
			this.btnNapThe.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnNapThe.ForeColor = global::System.Drawing.Color.DarkGreen;
			componentResourceManager.ApplyResources(this.btnNapThe, "btnNapThe");
			this.btnNapThe.Name = "btnNapThe";
			this.btnNapThe.UseVisualStyleBackColor = false;
			this.btnNapThe.Click += new global::System.EventHandler(this.btnNapThe_Click);
			componentResourceManager.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			componentResourceManager.ApplyResources(this.lblCoupon, "lblCoupon");
			this.lblCoupon.BackColor = global::System.Drawing.Color.Transparent;
			this.lblCoupon.ForeColor = global::System.Drawing.Color.Maroon;
			this.lblCoupon.Name = "lblCoupon";
			componentResourceManager.ApplyResources(this.linkPrice, "linkPrice");
			this.linkPrice.Name = "linkPrice";
			this.linkPrice.TabStop = true;
			this.linkPrice.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPrice_LinkClicked);
			componentResourceManager.ApplyResources(this.lblStatus, "lblStatus");
			this.lblStatus.Name = "lblStatus";
			this.timer_0.Interval = 20;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.lblCaptcha.BackColor = global::System.Drawing.Color.Transparent;
			componentResourceManager.ApplyResources(this.lblCaptcha, "lblCaptcha");
			this.lblCaptcha.Name = "lblCaptcha";
			this.txtCaptcha.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtCaptcha, "txtCaptcha");
			this.txtCaptcha.Name = "txtCaptcha";
			componentResourceManager.ApplyResources(this.lblCaptcha2, "lblCaptcha2");
			this.lblCaptcha2.ForeColor = global::System.Drawing.Color.Red;
			this.lblCaptcha2.Name = "lblCaptcha2";
			this.lblCaptcha3.BackColor = global::System.Drawing.Color.Transparent;
			componentResourceManager.ApplyResources(this.lblCaptcha3, "lblCaptcha3");
			this.lblCaptcha3.ForeColor = global::System.Drawing.Color.SteelBlue;
			this.lblCaptcha3.Name = "lblCaptcha3";
			componentResourceManager.ApplyResources(this.btnCaptcha, "btnCaptcha");
			this.btnCaptcha.ForeColor = global::System.Drawing.Color.DodgerBlue;
			this.btnCaptcha.Image = global::ns0.Class212.Refresh_icon;
			this.btnCaptcha.Name = "btnCaptcha";
			this.btnCaptcha.UseVisualStyleBackColor = true;
			this.btnCaptcha.Click += new global::System.EventHandler(this.btnCaptcha_Click);
			this.picCaptcha.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.picCaptcha, "picCaptcha");
			this.picCaptcha.Name = "picCaptcha";
			this.picCaptcha.TabStop = false;
			componentResourceManager.ApplyResources(this.label12, "label12");
			this.label12.Name = "label12";
			this.backgroundWorker_0.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_0_DoWork);
			this.backgroundWorker_0.RunWorkerCompleted += new global::System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_0_RunWorkerCompleted);
			this.btnTheNoiDia.BackColor = global::System.Drawing.Color.FromArgb(192, 240, 192);
			componentResourceManager.ApplyResources(this.btnTheNoiDia, "btnTheNoiDia");
			this.btnTheNoiDia.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.btnTheNoiDia.Name = "btnTheNoiDia";
			this.btnTheNoiDia.UseVisualStyleBackColor = false;
			this.btnTheNoiDia.Click += new global::System.EventHandler(this.btnTheNoiDia_Click);
			componentResourceManager.ApplyResources(this.label63, "label63");
			this.label63.ForeColor = global::System.Drawing.Color.Maroon;
			this.label63.Name = "label63";
			componentResourceManager.ApplyResources(this.label62, "label62");
			this.label62.ForeColor = global::System.Drawing.Color.DodgerBlue;
			this.label62.Name = "label62";
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.WhiteSmoke;
			base.Controls.Add(this.btnTheNoiDia);
			base.Controls.Add(this.label63);
			base.Controls.Add(this.label62);
			base.Controls.Add(this.label12);
			base.Controls.Add(this.lblCaptcha3);
			base.Controls.Add(this.lblCoupon);
			base.Controls.Add(this.lblStatus);
			base.Controls.Add(this.linkPrice);
			base.Controls.Add(this.btnNapThe);
			base.Controls.Add(this.btnHuy);
			base.Controls.Add(this.btnCaptcha);
			base.Controls.Add(this.lblCaptcha2);
			base.Controls.Add(this.lblCaptcha);
			base.Controls.Add(this.txtCaptcha);
			base.Controls.Add(this.picCaptcha);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.grpCardAdd);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "frmNapThe";
			base.ShowIcon = false;
			base.Load += new global::System.EventHandler(this.frmNapThe_Load);
			base.Shown += new global::System.EventHandler(this.frmNapThe_Shown);
			this.grpCardAdd.ResumeLayout(false);
			this.grpCardAdd.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.picCaptcha).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000EBA RID: 3770
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000EBB RID: 3771
		private global::System.Windows.Forms.GroupBox grpCardAdd;

		// Token: 0x04000EBC RID: 3772
		private global::System.Windows.Forms.ComboBox txtCardType;

		// Token: 0x04000EBD RID: 3773
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000EBE RID: 3774
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000EBF RID: 3775
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000EC0 RID: 3776
		private global::System.Windows.Forms.TextBox txtCardSerial;

		// Token: 0x04000EC1 RID: 3777
		private global::System.Windows.Forms.TextBox txtCardCode;

		// Token: 0x04000EC2 RID: 3778
		private global::System.Windows.Forms.Button btnHuy;

		// Token: 0x04000EC3 RID: 3779
		private global::System.Windows.Forms.Button btnNapThe;

		// Token: 0x04000EC4 RID: 3780
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000EC5 RID: 3781
		private global::System.Windows.Forms.LinkLabel linkPrice;

		// Token: 0x04000EC6 RID: 3782
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04000EC7 RID: 3783
		private global::System.Windows.Forms.Label lblCoupon;

		// Token: 0x04000EC8 RID: 3784
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000EC9 RID: 3785
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000ECA RID: 3786
		private global::System.Windows.Forms.TextBox txtTenTaiKhoan;

		// Token: 0x04000ECB RID: 3787
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000ECC RID: 3788
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000ECD RID: 3789
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000ECE RID: 3790
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000ECF RID: 3791
		private global::System.Windows.Forms.PictureBox picCaptcha;

		// Token: 0x04000ED0 RID: 3792
		private global::System.Windows.Forms.Label lblCaptcha;

		// Token: 0x04000ED1 RID: 3793
		private global::System.Windows.Forms.TextBox txtCaptcha;

		// Token: 0x04000ED2 RID: 3794
		private global::System.Windows.Forms.Label lblCaptcha2;

		// Token: 0x04000ED3 RID: 3795
		private global::System.Windows.Forms.Button btnCaptcha;

		// Token: 0x04000ED4 RID: 3796
		private global::System.Windows.Forms.Label lblCaptcha3;

		// Token: 0x04000ED5 RID: 3797
		private global::System.Windows.Forms.Label lblLoaiTK;

		// Token: 0x04000ED6 RID: 3798
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000ED7 RID: 3799
		private global::System.Windows.Forms.RadioButton rdioGGold;

		// Token: 0x04000ED8 RID: 3800
		private global::System.Windows.Forms.RadioButton rdioTien;

		// Token: 0x04000ED9 RID: 3801
		private global::System.Windows.Forms.Label lbNaptien;

		// Token: 0x04000EDA RID: 3802
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04000EDB RID: 3803
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000EDC RID: 3804
		private global::System.Windows.Forms.TextBox txtCoupon;

		// Token: 0x04000EDD RID: 3805
		private global::System.Windows.Forms.Button btnCoupon;

		// Token: 0x04000EDE RID: 3806
		private global::System.Windows.Forms.Label lblMaKMResult;

		// Token: 0x04000EDF RID: 3807
		private global::System.ComponentModel.BackgroundWorker backgroundWorker_0;

		// Token: 0x04000EE0 RID: 3808
		private global::System.Windows.Forms.Button btnTheNoiDia;

		// Token: 0x04000EE1 RID: 3809
		private global::System.Windows.Forms.Label label63;

		// Token: 0x04000EE2 RID: 3810
		private global::System.Windows.Forms.Label label62;

		// Token: 0x04000EE3 RID: 3811
		private global::System.Windows.Forms.ComboBox cboMenhGia;

		// Token: 0x04000EE4 RID: 3812
		private global::System.Windows.Forms.Label label64;
	}
}
