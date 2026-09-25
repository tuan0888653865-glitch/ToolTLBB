namespace ns0
{
	// Token: 0x020000FB RID: 251
	internal sealed partial class frmLogin : global::System.Windows.Forms.Form
	{
		// Token: 0x06000A4A RID: 2634 RVA: 0x0000A64F File Offset: 0x0000884F
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x000C6E24 File Offset: 0x000C5024
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmLogin));
			this.mnuMain = new global::System.Windows.Forms.MenuStrip();
			this.itemSystem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.itemSignUp = new global::System.Windows.Forms.ToolStripMenuItem();
			this.itemForgetPassword = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_5 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.itemSysSep2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.itemExit = new global::System.Windows.Forms.ToolStripMenuItem();
			this.itemHelp = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_0 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_4 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.updateGAutoToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_6 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_3 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.staMain = new global::System.Windows.Forms.StatusStrip();
			this.lblStatus = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.btnLogin = new global::System.Windows.Forms.Button();
			this.txtUserPassword = new global::System.Windows.Forms.TextBox();
			this.txtUserID = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnNewAccount = new global::System.Windows.Forms.Button();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.cboxSavePass = new global::System.Windows.Forms.CheckBox();
			this.btnNapThe = new global::System.Windows.Forms.Button();
			this.lblForgotPassword = new global::System.Windows.Forms.LinkLabel();
			this.pnelLogin = new global::System.Windows.Forms.Panel();
			this.linkChangePass = new global::System.Windows.Forms.LinkLabel();
			this.linkLabel2 = new global::System.Windows.Forms.LinkLabel();
			this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
			this.lblHotLine = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.cboServerlist = new global::System.Windows.Forms.ComboBox();
			this.cboxMoThuongNhan = new global::System.Windows.Forms.CheckBox();
			this.cboxOnlyCheDo = new global::System.Windows.Forms.CheckBox();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.btnFacebook = new global::System.Windows.Forms.Button();
			this.pnelPassword = new global::System.Windows.Forms.Panel();
			this.txtPassEmail = new global::System.Windows.Forms.TextBox();
			this.btnPassQuayVe = new global::System.Windows.Forms.Button();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.btnPassEmail = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.txtPassAccount = new global::System.Windows.Forms.TextBox();
			this.backgroundWorker_0 = new global::System.ComponentModel.BackgroundWorker();
			this.pnelChangePassword = new global::System.Windows.Forms.Panel();
			this.txtCP_NewPass2 = new global::System.Windows.Forms.TextBox();
			this.label45 = new global::System.Windows.Forms.Label();
			this.txtCP_NewPass = new global::System.Windows.Forms.TextBox();
			this.label44 = new global::System.Windows.Forms.Label();
			this.label38 = new global::System.Windows.Forms.Label();
			this.label39 = new global::System.Windows.Forms.Label();
			this.btnCP_Return = new global::System.Windows.Forms.Button();
			this.txtCP_OldPass = new global::System.Windows.Forms.TextBox();
			this.label40 = new global::System.Windows.Forms.Label();
			this.label41 = new global::System.Windows.Forms.Label();
			this.btnCP_Change = new global::System.Windows.Forms.Button();
			this.label42 = new global::System.Windows.Forms.Label();
			this.txtCP_Username = new global::System.Windows.Forms.TextBox();
			this.label43 = new global::System.Windows.Forms.Label();
			this.mnuMain.SuspendLayout();
			this.staMain.SuspendLayout();
			this.pnelLogin.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.pnelPassword.SuspendLayout();
			this.pnelChangePassword.SuspendLayout();
			base.SuspendLayout();
			this.mnuMain.BackColor = global::System.Drawing.SystemColors.Control;
			this.mnuMain.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.itemSystem,
				this.itemHelp
			});
			componentResourceManager.ApplyResources(this.mnuMain, "mnuMain");
			this.mnuMain.Name = "mnuMain";
			this.itemSystem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.itemSignUp,
				this.itemForgetPassword,
				this.toolStripMenuItem2,
				this.toolStripMenuItem_5,
				this.itemSysSep2,
				this.itemExit
			});
			this.itemSystem.Name = "itemSystem";
			componentResourceManager.ApplyResources(this.itemSystem, "itemSystem");
			this.itemSignUp.Name = "itemSignUp";
			componentResourceManager.ApplyResources(this.itemSignUp, "itemSignUp");
			this.itemSignUp.Click += new global::System.EventHandler(this.itemSignUp_Click);
			this.itemForgetPassword.Name = "itemForgetPassword";
			componentResourceManager.ApplyResources(this.itemForgetPassword, "itemForgetPassword");
			this.itemForgetPassword.Click += new global::System.EventHandler(this.itemForgetPassword_Click);
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			componentResourceManager.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
			this.toolStripMenuItem_5.Name = "nạpThẻToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_5, "nạpThẻToolStripMenuItem");
			this.toolStripMenuItem_5.Click += new global::System.EventHandler(this.toolStripMenuItem_5_Click);
			this.itemSysSep2.Name = "itemSysSep2";
			componentResourceManager.ApplyResources(this.itemSysSep2, "itemSysSep2");
			this.itemExit.Name = "itemExit";
			componentResourceManager.ApplyResources(this.itemExit, "itemExit");
			this.itemHelp.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_0,
				this.toolStripMenuItem_4,
				this.toolStripMenuItem1,
				this.updateGAutoToolStripMenuItem,
				this.toolStripMenuItem_6,
				this.toolStripSeparator4,
				this.toolStripMenuItem_1,
				this.toolStripMenuItem_2,
				this.toolStripSeparator3,
				this.toolStripMenuItem_3
			});
			this.itemHelp.Name = "itemHelp";
			componentResourceManager.ApplyResources(this.itemHelp, "itemHelp");
			this.toolStripMenuItem_0.Name = "trangChủToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_0, "trangChủToolStripMenuItem");
			this.toolStripMenuItem_0.Click += new global::System.EventHandler(this.toolStripMenuItem_0_Click);
			this.toolStripMenuItem_4.Name = "diễnĐànGAutoToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_4, "diễnĐànGAutoToolStripMenuItem");
			this.toolStripMenuItem_4.Click += new global::System.EventHandler(this.toolStripMenuItem_4_Click);
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			componentResourceManager.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
			this.updateGAutoToolStripMenuItem.Name = "updateGAutoToolStripMenuItem";
			componentResourceManager.ApplyResources(this.updateGAutoToolStripMenuItem, "updateGAutoToolStripMenuItem");
			this.updateGAutoToolStripMenuItem.Click += new global::System.EventHandler(this.updateGAutoToolStripMenuItem_Click);
			this.toolStripMenuItem_6.Name = "dùngProxyToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_6, "dùngProxyToolStripMenuItem");
			this.toolStripMenuItem_6.Click += new global::System.EventHandler(this.toolStripMenuItem_6_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			componentResourceManager.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
			this.toolStripMenuItem_1.Name = "hướngDẫnSửDụngToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_1, "hướngDẫnSửDụngToolStripMenuItem");
			this.toolStripMenuItem_1.Click += new global::System.EventHandler(this.toolStripMenuItem_1_Click);
			this.toolStripMenuItem_2.Name = "hướngDẫnĐăngKýToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_2, "hướngDẫnĐăngKýToolStripMenuItem");
			this.toolStripMenuItem_2.Click += new global::System.EventHandler(this.toolStripMenuItem_2_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			componentResourceManager.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
			this.toolStripMenuItem_3.Name = "vềChươngTrìnhToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_3, "vềChươngTrìnhToolStripMenuItem");
			this.toolStripMenuItem_3.Click += new global::System.EventHandler(this.toolStripMenuItem_3_Click);
			this.staMain.BackColor = global::System.Drawing.SystemColors.Control;
			this.staMain.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.lblStatus
			});
			componentResourceManager.ApplyResources(this.staMain, "staMain");
			this.staMain.Name = "staMain";
			this.lblStatus.ActiveLinkColor = global::System.Drawing.Color.Green;
			this.lblStatus.ForeColor = global::System.Drawing.Color.Green;
			this.lblStatus.Name = "lblStatus";
			componentResourceManager.ApplyResources(this.lblStatus, "lblStatus");
			this.lblStatus.Spring = true;
			this.btnLogin.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			componentResourceManager.ApplyResources(this.btnLogin, "btnLogin");
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new global::System.EventHandler(this.btnLogin_Click);
			this.txtUserPassword.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtUserPassword, "txtUserPassword");
			this.txtUserPassword.Name = "txtUserPassword";
			this.txtUserPassword.UseSystemPasswordChar = true;
			this.txtUserPassword.TextChanged += new global::System.EventHandler(this.txtUserPassword_TextChanged);
			this.txtUserID.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtUserID, "txtUserID");
			this.txtUserID.Name = "txtUserID";
			this.txtUserID.TextChanged += new global::System.EventHandler(this.txtUserID_TextChanged);
			componentResourceManager.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			this.label1.Click += new global::System.EventHandler(this.label1_Click);
			this.btnNewAccount.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			componentResourceManager.ApplyResources(this.btnNewAccount, "btnNewAccount");
			this.btnNewAccount.Name = "btnNewAccount";
			this.btnNewAccount.UseVisualStyleBackColor = false;
			this.btnNewAccount.Click += new global::System.EventHandler(this.btnNewAccount_Click);
			this.timer_0.Enabled = true;
			this.timer_0.Interval = 200;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			componentResourceManager.ApplyResources(this.cboxSavePass, "cboxSavePass");
			this.cboxSavePass.Name = "cboxSavePass";
			this.cboxSavePass.UseVisualStyleBackColor = true;
			this.cboxSavePass.CheckedChanged += new global::System.EventHandler(this.cboxSavePass_CheckedChanged);
			this.btnNapThe.BackColor = global::System.Drawing.Color.FromArgb(247, 207, 142);
			componentResourceManager.ApplyResources(this.btnNapThe, "btnNapThe");
			this.btnNapThe.ForeColor = global::System.Drawing.Color.Black;
			this.btnNapThe.Name = "btnNapThe";
			this.btnNapThe.UseVisualStyleBackColor = false;
			this.btnNapThe.Click += new global::System.EventHandler(this.btnNapThe_Click);
			componentResourceManager.ApplyResources(this.lblForgotPassword, "lblForgotPassword");
			this.lblForgotPassword.Name = "lblForgotPassword";
			this.lblForgotPassword.TabStop = true;
			this.lblForgotPassword.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblForgotPassword_LinkClicked);
			this.pnelLogin.Controls.Add(this.linkChangePass);
			this.pnelLogin.Controls.Add(this.linkLabel2);
			this.pnelLogin.Controls.Add(this.linkLabel1);
			this.pnelLogin.Controls.Add(this.lblHotLine);
			this.pnelLogin.Controls.Add(this.label6);
			this.pnelLogin.Controls.Add(this.cboServerlist);
			this.pnelLogin.Controls.Add(this.cboxMoThuongNhan);
			this.pnelLogin.Controls.Add(this.cboxOnlyCheDo);
			this.pnelLogin.Controls.Add(this.lblForgotPassword);
			this.pnelLogin.Controls.Add(this.pictureBox1);
			this.pnelLogin.Controls.Add(this.btnFacebook);
			this.pnelLogin.Controls.Add(this.btnNapThe);
			this.pnelLogin.Controls.Add(this.cboxSavePass);
			this.pnelLogin.Controls.Add(this.btnNewAccount);
			this.pnelLogin.Controls.Add(this.label1);
			this.pnelLogin.Controls.Add(this.txtUserPassword);
			this.pnelLogin.Controls.Add(this.txtUserID);
			this.pnelLogin.Controls.Add(this.btnLogin);
			this.pnelLogin.Controls.Add(this.staMain);
			componentResourceManager.ApplyResources(this.pnelLogin, "pnelLogin");
			this.pnelLogin.Name = "pnelLogin";
			componentResourceManager.ApplyResources(this.linkChangePass, "linkChangePass");
			this.linkChangePass.Name = "linkChangePass";
			this.linkChangePass.TabStop = true;
			this.linkChangePass.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChangePass_LinkClicked);
			componentResourceManager.ApplyResources(this.linkLabel2, "linkLabel2");
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.TabStop = true;
			this.linkLabel2.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			componentResourceManager.ApplyResources(this.linkLabel1, "linkLabel1");
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.TabStop = true;
			this.linkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			componentResourceManager.ApplyResources(this.lblHotLine, "lblHotLine");
			this.lblHotLine.ForeColor = global::System.Drawing.Color.Navy;
			this.lblHotLine.Name = "lblHotLine";
			componentResourceManager.ApplyResources(this.label6, "label6");
			this.label6.Name = "label6";
			this.label6.Click += new global::System.EventHandler(this.label6_Click);
			this.cboServerlist.FormattingEnabled = true;
			componentResourceManager.ApplyResources(this.cboServerlist, "cboServerlist");
			this.cboServerlist.Name = "cboServerlist";
			this.cboServerlist.SelectedIndexChanged += new global::System.EventHandler(this.cboServerlist_SelectedIndexChanged);
			componentResourceManager.ApplyResources(this.cboxMoThuongNhan, "cboxMoThuongNhan");
			this.cboxMoThuongNhan.Name = "cboxMoThuongNhan";
			this.cboxMoThuongNhan.UseVisualStyleBackColor = true;
			this.cboxMoThuongNhan.CheckedChanged += new global::System.EventHandler(this.cboxMoThuongNhan_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxOnlyCheDo, "cboxOnlyCheDo");
			this.cboxOnlyCheDo.Name = "cboxOnlyCheDo";
			this.cboxOnlyCheDo.UseVisualStyleBackColor = true;
			this.cboxOnlyCheDo.CheckedChanged += new global::System.EventHandler(this.cboxOnlyCheDo_CheckedChanged);
			this.pictureBox1.Image = global::ns0.Class212.cooltext143093550107300__2_;
			componentResourceManager.ApplyResources(this.pictureBox1, "pictureBox1");
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabStop = false;
			this.btnFacebook.BackColor = global::System.Drawing.Color.Transparent;
			componentResourceManager.ApplyResources(this.btnFacebook, "btnFacebook");
			this.btnFacebook.ForeColor = global::System.Drawing.Color.Transparent;
			this.btnFacebook.Image = global::ns0.Class212.facebook;
			this.btnFacebook.Name = "btnFacebook";
			this.btnFacebook.UseVisualStyleBackColor = false;
			this.btnFacebook.Click += new global::System.EventHandler(this.btnFacebook_Click);
			this.pnelPassword.Controls.Add(this.txtPassEmail);
			this.pnelPassword.Controls.Add(this.btnPassQuayVe);
			this.pnelPassword.Controls.Add(this.label5);
			this.pnelPassword.Controls.Add(this.label4);
			this.pnelPassword.Controls.Add(this.label3);
			this.pnelPassword.Controls.Add(this.btnPassEmail);
			this.pnelPassword.Controls.Add(this.label2);
			this.pnelPassword.Controls.Add(this.txtPassAccount);
			componentResourceManager.ApplyResources(this.pnelPassword, "pnelPassword");
			this.pnelPassword.Name = "pnelPassword";
			this.txtPassEmail.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtPassEmail, "txtPassEmail");
			this.txtPassEmail.Name = "txtPassEmail";
			this.btnPassQuayVe.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			componentResourceManager.ApplyResources(this.btnPassQuayVe, "btnPassQuayVe");
			this.btnPassQuayVe.Name = "btnPassQuayVe";
			this.btnPassQuayVe.UseVisualStyleBackColor = false;
			this.btnPassQuayVe.Click += new global::System.EventHandler(this.btnPassQuayVe_Click);
			componentResourceManager.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
			componentResourceManager.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			componentResourceManager.ApplyResources(this.label3, "label3");
			this.label3.ForeColor = global::System.Drawing.Color.Chocolate;
			this.label3.Name = "label3";
			this.btnPassEmail.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			componentResourceManager.ApplyResources(this.btnPassEmail, "btnPassEmail");
			this.btnPassEmail.Name = "btnPassEmail";
			this.btnPassEmail.UseVisualStyleBackColor = false;
			this.btnPassEmail.Click += new global::System.EventHandler(this.btnPassEmail_Click);
			componentResourceManager.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			this.txtPassAccount.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtPassAccount, "txtPassAccount");
			this.txtPassAccount.Name = "txtPassAccount";
			this.backgroundWorker_0.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_0_DoWork);
			this.backgroundWorker_0.RunWorkerCompleted += new global::System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_0_RunWorkerCompleted);
			this.pnelChangePassword.Controls.Add(this.txtCP_NewPass2);
			this.pnelChangePassword.Controls.Add(this.label45);
			this.pnelChangePassword.Controls.Add(this.txtCP_NewPass);
			this.pnelChangePassword.Controls.Add(this.label44);
			this.pnelChangePassword.Controls.Add(this.label38);
			this.pnelChangePassword.Controls.Add(this.label39);
			this.pnelChangePassword.Controls.Add(this.btnCP_Return);
			this.pnelChangePassword.Controls.Add(this.txtCP_OldPass);
			this.pnelChangePassword.Controls.Add(this.label40);
			this.pnelChangePassword.Controls.Add(this.label41);
			this.pnelChangePassword.Controls.Add(this.btnCP_Change);
			this.pnelChangePassword.Controls.Add(this.label42);
			this.pnelChangePassword.Controls.Add(this.txtCP_Username);
			this.pnelChangePassword.Controls.Add(this.label43);
			componentResourceManager.ApplyResources(this.pnelChangePassword, "pnelChangePassword");
			this.pnelChangePassword.Name = "pnelChangePassword";
			this.txtCP_NewPass2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtCP_NewPass2, "txtCP_NewPass2");
			this.txtCP_NewPass2.Name = "txtCP_NewPass2";
			componentResourceManager.ApplyResources(this.label45, "label45");
			this.label45.Name = "label45";
			this.txtCP_NewPass.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtCP_NewPass, "txtCP_NewPass");
			this.txtCP_NewPass.Name = "txtCP_NewPass";
			componentResourceManager.ApplyResources(this.label44, "label44");
			this.label44.Name = "label44";
			componentResourceManager.ApplyResources(this.label38, "label38");
			this.label38.Name = "label38";
			componentResourceManager.ApplyResources(this.label39, "label39");
			this.label39.ForeColor = global::System.Drawing.Color.Peru;
			this.label39.Name = "label39";
			this.btnCP_Return.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			componentResourceManager.ApplyResources(this.btnCP_Return, "btnCP_Return");
			this.btnCP_Return.Name = "btnCP_Return";
			this.btnCP_Return.UseVisualStyleBackColor = false;
			this.btnCP_Return.Click += new global::System.EventHandler(this.btnCP_Return_Click);
			this.txtCP_OldPass.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtCP_OldPass, "txtCP_OldPass");
			this.txtCP_OldPass.Name = "txtCP_OldPass";
			componentResourceManager.ApplyResources(this.label40, "label40");
			this.label40.Name = "label40";
			componentResourceManager.ApplyResources(this.label41, "label41");
			this.label41.Name = "label41";
			this.btnCP_Change.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			componentResourceManager.ApplyResources(this.btnCP_Change, "btnCP_Change");
			this.btnCP_Change.Name = "btnCP_Change";
			this.btnCP_Change.UseVisualStyleBackColor = false;
			this.btnCP_Change.Click += new global::System.EventHandler(this.btnCP_Change_Click);
			componentResourceManager.ApplyResources(this.label42, "label42");
			this.label42.Name = "label42";
			this.txtCP_Username.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtCP_Username, "txtCP_Username");
			this.txtCP_Username.Name = "txtCP_Username";
			componentResourceManager.ApplyResources(this.label43, "label43");
			this.label43.ForeColor = global::System.Drawing.Color.Chocolate;
			this.label43.Name = "label43";
			base.AcceptButton = this.btnLogin;
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.WhiteSmoke;
			base.Controls.Add(this.mnuMain);
			base.Controls.Add(this.pnelLogin);
			base.Controls.Add(this.pnelChangePassword);
			base.Controls.Add(this.pnelPassword);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MainMenuStrip = this.mnuMain;
			base.MaximizeBox = false;
			base.Name = "frmLogin";
			base.ShowIcon = false;
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
			base.Load += new global::System.EventHandler(this.frmLogin_Load);
			this.mnuMain.ResumeLayout(false);
			this.mnuMain.PerformLayout();
			this.staMain.ResumeLayout(false);
			this.staMain.PerformLayout();
			this.pnelLogin.ResumeLayout(false);
			this.pnelLogin.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.pnelPassword.ResumeLayout(false);
			this.pnelPassword.PerformLayout();
			this.pnelChangePassword.ResumeLayout(false);
			this.pnelChangePassword.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000E44 RID: 3652
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000E45 RID: 3653
		private global::System.Windows.Forms.MenuStrip mnuMain;

		// Token: 0x04000E46 RID: 3654
		private global::System.Windows.Forms.StatusStrip staMain;

		// Token: 0x04000E47 RID: 3655
		private global::System.Windows.Forms.ToolStripMenuItem itemSystem;

		// Token: 0x04000E48 RID: 3656
		private global::System.Windows.Forms.ToolStripMenuItem itemHelp;

		// Token: 0x04000E49 RID: 3657
		private global::System.Windows.Forms.ToolStripMenuItem itemExit;

		// Token: 0x04000E4A RID: 3658
		private global::System.Windows.Forms.Button btnLogin;

		// Token: 0x04000E4B RID: 3659
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000E4C RID: 3660
		private global::System.Windows.Forms.ToolStripMenuItem itemForgetPassword;

		// Token: 0x04000E4D RID: 3661
		private global::System.Windows.Forms.ToolStripSeparator itemSysSep2;

		// Token: 0x04000E4E RID: 3662
		private global::System.Windows.Forms.ToolStripMenuItem itemSignUp;

		// Token: 0x04000E4F RID: 3663
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x04000E50 RID: 3664
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		// Token: 0x04000E51 RID: 3665
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_1;

		// Token: 0x04000E52 RID: 3666
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_2;

		// Token: 0x04000E53 RID: 3667
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		// Token: 0x04000E54 RID: 3668
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_3;

		// Token: 0x04000E55 RID: 3669
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_4;

		// Token: 0x04000E56 RID: 3670
		private global::System.Windows.Forms.Button btnNewAccount;

		// Token: 0x04000E57 RID: 3671
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;

		// Token: 0x04000E58 RID: 3672
		private global::System.Windows.Forms.ToolStripMenuItem updateGAutoToolStripMenuItem;

		// Token: 0x04000E59 RID: 3673
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000E5A RID: 3674
		private global::System.Windows.Forms.CheckBox cboxSavePass;

		// Token: 0x04000E5B RID: 3675
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;

		// Token: 0x04000E5C RID: 3676
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_5;

		// Token: 0x04000E5D RID: 3677
		private global::System.Windows.Forms.Button btnNapThe;

		// Token: 0x04000E5E RID: 3678
		private global::System.Windows.Forms.Button btnFacebook;

		// Token: 0x04000E5F RID: 3679
		internal global::System.Windows.Forms.ToolStripStatusLabel lblStatus;

		// Token: 0x04000E60 RID: 3680
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000E61 RID: 3681
		private global::System.Windows.Forms.LinkLabel lblForgotPassword;

		// Token: 0x04000E62 RID: 3682
		private global::System.Windows.Forms.Panel pnelLogin;

		// Token: 0x04000E63 RID: 3683
		private global::System.Windows.Forms.Panel pnelPassword;

		// Token: 0x04000E64 RID: 3684
		private global::System.Windows.Forms.Button btnPassQuayVe;

		// Token: 0x04000E65 RID: 3685
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000E66 RID: 3686
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000E67 RID: 3687
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000E68 RID: 3688
		private global::System.Windows.Forms.Button btnPassEmail;

		// Token: 0x04000E69 RID: 3689
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000E6A RID: 3690
		private global::System.Windows.Forms.TextBox txtPassAccount;

		// Token: 0x04000E6B RID: 3691
		private global::System.Windows.Forms.TextBox txtPassEmail;

		// Token: 0x04000E6C RID: 3692
		internal global::System.Windows.Forms.TextBox txtUserID;

		// Token: 0x04000E6D RID: 3693
		internal global::System.Windows.Forms.TextBox txtUserPassword;

		// Token: 0x04000E6E RID: 3694
		private global::System.Windows.Forms.CheckBox cboxOnlyCheDo;

		// Token: 0x04000E6F RID: 3695
		private global::System.ComponentModel.BackgroundWorker backgroundWorker_0;

		// Token: 0x04000E70 RID: 3696
		private global::System.Windows.Forms.CheckBox cboxMoThuongNhan;

		// Token: 0x04000E71 RID: 3697
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000E72 RID: 3698
		private global::System.Windows.Forms.ComboBox cboServerlist;

		// Token: 0x04000E73 RID: 3699
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_6;

		// Token: 0x04000E74 RID: 3700
		private global::System.Windows.Forms.Label lblHotLine;

		// Token: 0x04000E75 RID: 3701
		private global::System.Windows.Forms.LinkLabel linkLabel2;

		// Token: 0x04000E76 RID: 3702
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x04000E77 RID: 3703
		private global::System.Windows.Forms.LinkLabel linkChangePass;

		// Token: 0x04000E78 RID: 3704
		private global::System.Windows.Forms.Panel pnelChangePassword;

		// Token: 0x04000E79 RID: 3705
		private global::System.Windows.Forms.TextBox txtCP_NewPass2;

		// Token: 0x04000E7A RID: 3706
		private global::System.Windows.Forms.Label label45;

		// Token: 0x04000E7B RID: 3707
		private global::System.Windows.Forms.TextBox txtCP_NewPass;

		// Token: 0x04000E7C RID: 3708
		private global::System.Windows.Forms.Label label44;

		// Token: 0x04000E7D RID: 3709
		private global::System.Windows.Forms.Label label38;

		// Token: 0x04000E7E RID: 3710
		private global::System.Windows.Forms.Label label39;

		// Token: 0x04000E7F RID: 3711
		private global::System.Windows.Forms.Button btnCP_Return;

		// Token: 0x04000E80 RID: 3712
		private global::System.Windows.Forms.TextBox txtCP_OldPass;

		// Token: 0x04000E81 RID: 3713
		private global::System.Windows.Forms.Label label40;

		// Token: 0x04000E82 RID: 3714
		private global::System.Windows.Forms.Label label41;

		// Token: 0x04000E83 RID: 3715
		private global::System.Windows.Forms.Button btnCP_Change;

		// Token: 0x04000E84 RID: 3716
		private global::System.Windows.Forms.Label label42;

		// Token: 0x04000E85 RID: 3717
		private global::System.Windows.Forms.TextBox txtCP_Username;

		// Token: 0x04000E86 RID: 3718
		private global::System.Windows.Forms.Label label43;
	}
}
