namespace ns0
{
	// Token: 0x0200012A RID: 298
	internal sealed partial class frmReg : global::System.Windows.Forms.Form
	{
		// Token: 0x0600125B RID: 4699 RVA: 0x000165A6 File Offset: 0x000147A6
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x001197F8 File Offset: 0x001179F8
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmReg));
			this.grpInfo = new global::System.Windows.Forms.GroupBox();
			this.lblStatus = new global::System.Windows.Forms.Label();
			this.picCaptcha = new global::System.Windows.Forms.PictureBox();
			this.btnCheckUserName = new global::System.Windows.Forms.Button();
			this.txtRePass = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.txtUserPass = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.txtCode = new global::System.Windows.Forms.TextBox();
			this.txtUserEmail = new global::System.Windows.Forms.TextBox();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.txtUserLogin = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnDoReg = new global::System.Windows.Forms.Button();
			this.cboxTerms = new global::System.Windows.Forms.CheckBox();
			this.lblTermLink = new global::System.Windows.Forms.LinkLabel();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.backgroundWorker_0 = new global::System.ComponentModel.BackgroundWorker();
			this.btnRegCaptcha = new global::System.Windows.Forms.Button();
			this.grpInfo.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.picCaptcha).BeginInit();
			base.SuspendLayout();
			this.grpInfo.Controls.Add(this.btnRegCaptcha);
			this.grpInfo.Controls.Add(this.lblStatus);
			this.grpInfo.Controls.Add(this.picCaptcha);
			this.grpInfo.Controls.Add(this.btnCheckUserName);
			this.grpInfo.Controls.Add(this.txtRePass);
			this.grpInfo.Controls.Add(this.label3);
			this.grpInfo.Controls.Add(this.txtUserPass);
			this.grpInfo.Controls.Add(this.label2);
			this.grpInfo.Controls.Add(this.txtCode);
			this.grpInfo.Controls.Add(this.txtUserEmail);
			this.grpInfo.Controls.Add(this.label8);
			this.grpInfo.Controls.Add(this.label4);
			this.grpInfo.Controls.Add(this.txtUserLogin);
			this.grpInfo.Controls.Add(this.label1);
			componentResourceManager.ApplyResources(this.grpInfo, "grpInfo");
			this.grpInfo.Name = "grpInfo";
			this.grpInfo.TabStop = false;
			componentResourceManager.ApplyResources(this.lblStatus, "lblStatus");
			this.lblStatus.Name = "lblStatus";
			componentResourceManager.ApplyResources(this.picCaptcha, "picCaptcha");
			this.picCaptcha.Name = "picCaptcha";
			this.picCaptcha.TabStop = false;
			componentResourceManager.ApplyResources(this.btnCheckUserName, "btnCheckUserName");
			this.btnCheckUserName.Name = "btnCheckUserName";
			this.btnCheckUserName.TabStop = false;
			this.btnCheckUserName.UseVisualStyleBackColor = true;
			this.btnCheckUserName.Click += new global::System.EventHandler(this.btnCheckUserName_Click);
			this.txtRePass.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtRePass, "txtRePass");
			this.txtRePass.Name = "txtRePass";
			this.txtRePass.UseSystemPasswordChar = true;
			componentResourceManager.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			this.txtUserPass.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtUserPass, "txtUserPass");
			this.txtUserPass.Name = "txtUserPass";
			this.txtUserPass.UseSystemPasswordChar = true;
			componentResourceManager.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			this.txtCode.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtCode, "txtCode");
			this.txtCode.Name = "txtCode";
			this.txtUserEmail.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtUserEmail, "txtUserEmail");
			this.txtUserEmail.Name = "txtUserEmail";
			componentResourceManager.ApplyResources(this.label8, "label8");
			this.label8.Name = "label8";
			componentResourceManager.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			this.txtUserLogin.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtUserLogin, "txtUserLogin");
			this.txtUserLogin.Name = "txtUserLogin";
			this.txtUserLogin.TextChanged += new global::System.EventHandler(this.txtUserLogin_TextChanged);
			componentResourceManager.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			componentResourceManager.ApplyResources(this.btnDoReg, "btnDoReg");
			this.btnDoReg.Name = "btnDoReg";
			this.btnDoReg.UseVisualStyleBackColor = true;
			this.btnDoReg.Click += new global::System.EventHandler(this.btnDoReg_Click);
			componentResourceManager.ApplyResources(this.cboxTerms, "cboxTerms");
			this.cboxTerms.Name = "cboxTerms";
			this.cboxTerms.UseVisualStyleBackColor = true;
			this.cboxTerms.CheckedChanged += new global::System.EventHandler(this.cboxTerms_CheckedChanged);
			componentResourceManager.ApplyResources(this.lblTermLink, "lblTermLink");
			this.lblTermLink.BackColor = global::System.Drawing.Color.FromArgb(238, 241, 243);
			this.lblTermLink.Name = "lblTermLink";
			this.lblTermLink.TabStop = true;
			this.lblTermLink.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblTermLink_LinkClicked);
			this.timer_0.Enabled = true;
			this.timer_0.Interval = 700;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.backgroundWorker_0.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_0_DoWork);
			this.backgroundWorker_0.RunWorkerCompleted += new global::System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_0_RunWorkerCompleted);
			this.btnRegCaptcha.BackColor = global::System.Drawing.Color.WhiteSmoke;
			componentResourceManager.ApplyResources(this.btnRegCaptcha, "btnRegCaptcha");
			this.btnRegCaptcha.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnRegCaptcha.Name = "btnRegCaptcha";
			this.btnRegCaptcha.UseVisualStyleBackColor = false;
			this.btnRegCaptcha.Click += new global::System.EventHandler(this.btnRegCaptcha_Click);
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.lblTermLink);
			base.Controls.Add(this.cboxTerms);
			base.Controls.Add(this.btnDoReg);
			base.Controls.Add(this.grpInfo);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmReg";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.TopMost = true;
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.frmReg_FormClosed);
			base.Load += new global::System.EventHandler(this.frmReg_Load);
			this.grpInfo.ResumeLayout(false);
			this.grpInfo.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.picCaptcha).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04001364 RID: 4964
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04001365 RID: 4965
		private global::System.Windows.Forms.GroupBox grpInfo;

		// Token: 0x04001366 RID: 4966
		private global::System.Windows.Forms.Button btnCheckUserName;

		// Token: 0x04001367 RID: 4967
		private global::System.Windows.Forms.TextBox txtUserLogin;

		// Token: 0x04001368 RID: 4968
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04001369 RID: 4969
		private global::System.Windows.Forms.TextBox txtUserPass;

		// Token: 0x0400136A RID: 4970
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400136B RID: 4971
		private global::System.Windows.Forms.TextBox txtRePass;

		// Token: 0x0400136C RID: 4972
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400136D RID: 4973
		private global::System.Windows.Forms.TextBox txtUserEmail;

		// Token: 0x0400136E RID: 4974
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400136F RID: 4975
		private global::System.Windows.Forms.Button btnDoReg;

		// Token: 0x04001370 RID: 4976
		private global::System.Windows.Forms.TextBox txtCode;

		// Token: 0x04001371 RID: 4977
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04001372 RID: 4978
		private global::System.Windows.Forms.PictureBox picCaptcha;

		// Token: 0x04001373 RID: 4979
		private global::System.Windows.Forms.CheckBox cboxTerms;

		// Token: 0x04001374 RID: 4980
		private global::System.Windows.Forms.LinkLabel lblTermLink;

		// Token: 0x04001375 RID: 4981
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04001376 RID: 4982
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04001377 RID: 4983
		private global::System.ComponentModel.BackgroundWorker backgroundWorker_0;

		// Token: 0x04001378 RID: 4984
		private global::System.Windows.Forms.Button btnRegCaptcha;
	}
}
