namespace ns0
{
	// Token: 0x02000104 RID: 260
	internal sealed partial class frmProfileManager : global::System.Windows.Forms.Form
	{
		// Token: 0x06000ABC RID: 2748 RVA: 0x0000AB07 File Offset: 0x00008D07
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x000CF0B8 File Offset: 0x000CD2B8
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmProfileManager));
			this.tboxUsername = new global::System.Windows.Forms.TextBox();
			this.cboNPH = new global::System.Windows.Forms.ComboBox();
			this.btnThemProfile = new global::System.Windows.Forms.Button();
			this.btnEditProfile = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.lblAgreement = new global::System.Windows.Forms.Label();
			this.lblAgreementTitle = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.tboxPassword = new global::System.Windows.Forms.TextBox();
			this.cboxAgreement = new global::System.Windows.Forms.CheckBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.cboServer = new global::System.Windows.Forms.ComboBox();
			this.btnDelProfile = new global::System.Windows.Forms.Button();
			this.cboHopKiem = new global::System.Windows.Forms.ComboBox();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.label1 = new global::System.Windows.Forms.Label();
			this.tboxName = new global::System.Windows.Forms.TextBox();
			this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_2 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_3 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_4 = new global::System.Windows.Forms.ColumnHeader();
			this.label3 = new global::System.Windows.Forms.Label();
			this.tboxGameFile = new global::System.Windows.Forms.TextBox();
			this.btnBrowseVNG = new global::System.Windows.Forms.Button();
			this.dataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.colUsername = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNPH = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colServer = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colHopKiem = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTenNV = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCaptcha = new global::System.Windows.Forms.DataGridViewImageColumn();
			this.NewCaptcha = new global::System.Windows.Forms.DataGridViewButtonColumn();
			this.colCaptcha2 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLoginCbox = new global::System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colButtonLogin = new global::System.Windows.Forms.DataGridViewButtonColumn();
			this.dataGridViewImageColumn1 = new global::System.Windows.Forms.DataGridViewImageColumn();
			this.btnMoveDown = new global::System.Windows.Forms.Button();
			this.btnMoveUp = new global::System.Windows.Forms.Button();
			this.GLoginContextMenu = new global::System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_0 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.lvAllProfiles = new global::ns0.GClass3();
			this.columnHeader_5 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_6 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_7 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_8 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_9 = new global::System.Windows.Forms.ColumnHeader();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
			this.GLoginContextMenu.SuspendLayout();
			base.SuspendLayout();
			this.tboxUsername.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.tboxUsername.ForeColor = global::System.Drawing.Color.Maroon;
			componentResourceManager.ApplyResources(this.tboxUsername, "tboxUsername");
			this.tboxUsername.Name = "tboxUsername";
			this.cboNPH.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.cboNPH.DropDownWidth = 186;
			componentResourceManager.ApplyResources(this.cboNPH, "cboNPH");
			this.cboNPH.FormattingEnabled = true;
			this.cboNPH.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("cboNPH.Items"),
				componentResourceManager.GetString("cboNPH.Items1"),
				componentResourceManager.GetString("cboNPH.Items2")
			});
			this.cboNPH.Name = "cboNPH";
			this.cboNPH.SelectedIndexChanged += new global::System.EventHandler(this.cboNPH_SelectedIndexChanged);
			this.btnThemProfile.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnThemProfile.ForeColor = global::System.Drawing.Color.DarkGreen;
			componentResourceManager.ApplyResources(this.btnThemProfile, "btnThemProfile");
			this.btnThemProfile.Name = "btnThemProfile";
			this.btnThemProfile.UseVisualStyleBackColor = false;
			this.btnThemProfile.Click += new global::System.EventHandler(this.btnThemProfile_Click);
			componentResourceManager.ApplyResources(this.btnEditProfile, "btnEditProfile");
			this.btnEditProfile.BackColor = global::System.Drawing.Color.FromArgb(247, 207, 142);
			this.btnEditProfile.ForeColor = global::System.Drawing.Color.Black;
			this.btnEditProfile.Name = "btnEditProfile";
			this.btnEditProfile.UseVisualStyleBackColor = false;
			this.btnEditProfile.Click += new global::System.EventHandler(this.btnEditProfile_Click);
			componentResourceManager.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			componentResourceManager.ApplyResources(this.label9, "label9");
			this.label9.Name = "label9";
			componentResourceManager.ApplyResources(this.lblAgreement, "lblAgreement");
			this.lblAgreement.ForeColor = global::System.Drawing.Color.DarkRed;
			this.lblAgreement.Name = "lblAgreement";
			componentResourceManager.ApplyResources(this.lblAgreementTitle, "lblAgreementTitle");
			this.lblAgreementTitle.ForeColor = global::System.Drawing.Color.Red;
			this.lblAgreementTitle.Name = "lblAgreementTitle";
			componentResourceManager.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			this.tboxPassword.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.tboxPassword.ForeColor = global::System.Drawing.Color.Maroon;
			componentResourceManager.ApplyResources(this.tboxPassword, "tboxPassword");
			this.tboxPassword.Name = "tboxPassword";
			componentResourceManager.ApplyResources(this.cboxAgreement, "cboxAgreement");
			this.cboxAgreement.BackColor = global::System.Drawing.Color.Transparent;
			this.cboxAgreement.ForeColor = global::System.Drawing.Color.Black;
			this.cboxAgreement.Name = "cboxAgreement";
			this.cboxAgreement.UseVisualStyleBackColor = false;
			this.cboxAgreement.CheckedChanged += new global::System.EventHandler(this.cboxAgreement_CheckedChanged);
			componentResourceManager.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
			componentResourceManager.ApplyResources(this.label6, "label6");
			this.label6.Name = "label6";
			this.cboServer.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.cboServer.DropDownWidth = 186;
			componentResourceManager.ApplyResources(this.cboServer, "cboServer");
			this.cboServer.FormattingEnabled = true;
			this.cboServer.Name = "cboServer";
			this.cboServer.DropDown += new global::System.EventHandler(this.cboServer_DropDown);
			this.cboServer.SelectedIndexChanged += new global::System.EventHandler(this.cboServer_SelectedIndexChanged);
			componentResourceManager.ApplyResources(this.btnDelProfile, "btnDelProfile");
			this.btnDelProfile.BackColor = global::System.Drawing.Color.FromArgb(247, 207, 142);
			this.btnDelProfile.ForeColor = global::System.Drawing.Color.Black;
			this.btnDelProfile.Name = "btnDelProfile";
			this.btnDelProfile.UseVisualStyleBackColor = false;
			this.btnDelProfile.Click += new global::System.EventHandler(this.btnDelProfile_Click);
			this.cboHopKiem.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.cboHopKiem.DropDownWidth = 186;
			componentResourceManager.ApplyResources(this.cboHopKiem, "cboHopKiem");
			this.cboHopKiem.FormattingEnabled = true;
			this.cboHopKiem.Name = "cboHopKiem";
			this.cboHopKiem.DropDown += new global::System.EventHandler(this.cboHopKiem_DropDown);
			this.cboHopKiem.SelectedIndexChanged += new global::System.EventHandler(this.cboHopKiem_SelectedIndexChanged);
			this.timer_0.Interval = 400;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			componentResourceManager.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			this.tboxName.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.tboxName.ForeColor = global::System.Drawing.Color.Maroon;
			componentResourceManager.ApplyResources(this.tboxName, "tboxName");
			this.tboxName.Name = "tboxName";
			componentResourceManager.ApplyResources(this.columnHeader_1, "columnHeader1");
			componentResourceManager.ApplyResources(this.columnHeader_0, "columnHeader2");
			componentResourceManager.ApplyResources(this.columnHeader_2, "columnHeader3");
			componentResourceManager.ApplyResources(this.columnHeader_3, "columnHeader4");
			componentResourceManager.ApplyResources(this.columnHeader_4, "columnHeader5");
			componentResourceManager.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			this.tboxGameFile.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.tboxGameFile.ForeColor = global::System.Drawing.Color.Maroon;
			componentResourceManager.ApplyResources(this.tboxGameFile, "tboxGameFile");
			this.tboxGameFile.Name = "tboxGameFile";
			componentResourceManager.ApplyResources(this.btnBrowseVNG, "btnBrowseVNG");
			this.btnBrowseVNG.Name = "btnBrowseVNG";
			this.btnBrowseVNG.UseVisualStyleBackColor = true;
			this.btnBrowseVNG.Click += new global::System.EventHandler(this.btnBrowseVNG_Click);
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			componentResourceManager.ApplyResources(this.dataGridView1, "dataGridView1");
			this.dataGridView1.BackgroundColor = global::System.Drawing.Color.WhiteSmoke;
			this.dataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.colUsername,
				this.colNPH,
				this.colServer,
				this.colHopKiem,
				this.colTenNV,
				this.colCaptcha,
				this.NewCaptcha,
				this.colCaptcha2,
				this.colLoginCbox,
				this.colButtonLogin
			});
			this.dataGridView1.GridColor = global::System.Drawing.SystemColors.ControlLight;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.Height = 36;
			this.dataGridView1.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.CellContentClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.CellContentDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
			this.dataGridView1.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			this.dataGridView1.SelectionChanged += new global::System.EventHandler(this.dataGridView1_SelectionChanged);
			this.dataGridView1.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
			this.dataGridView1.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
			componentResourceManager.ApplyResources(this.colUsername, "colUsername");
			this.colUsername.Name = "colUsername";
			this.colUsername.ReadOnly = true;
			componentResourceManager.ApplyResources(this.colNPH, "colNPH");
			this.colNPH.Name = "colNPH";
			this.colNPH.ReadOnly = true;
			componentResourceManager.ApplyResources(this.colServer, "colServer");
			this.colServer.Name = "colServer";
			this.colServer.ReadOnly = true;
			componentResourceManager.ApplyResources(this.colHopKiem, "colHopKiem");
			this.colHopKiem.Name = "colHopKiem";
			this.colHopKiem.ReadOnly = true;
			componentResourceManager.ApplyResources(this.colTenNV, "colTenNV");
			this.colTenNV.Name = "colTenNV";
			this.colTenNV.ReadOnly = true;
			componentResourceManager.ApplyResources(this.colCaptcha, "colCaptcha");
			this.colCaptcha.Image = global::ns0.Class212.captchaplace;
			this.colCaptcha.Name = "colCaptcha";
			this.colCaptcha.ReadOnly = true;
			componentResourceManager.ApplyResources(this.NewCaptcha, "NewCaptcha");
			this.NewCaptcha.Name = "NewCaptcha";
			this.NewCaptcha.Text = "Mã mới";
			this.NewCaptcha.UseColumnTextForButtonValue = true;
			componentResourceManager.ApplyResources(this.colCaptcha2, "colCaptcha2");
			this.colCaptcha2.Name = "colCaptcha2";
			componentResourceManager.ApplyResources(this.colLoginCbox, "colLoginCbox");
			this.colLoginCbox.Name = "colLoginCbox";
			componentResourceManager.ApplyResources(this.colButtonLogin, "colButtonLogin");
			this.colButtonLogin.Name = "colButtonLogin";
			this.colButtonLogin.Text = "Mở/Vào Game";
			this.colButtonLogin.UseColumnTextForButtonValue = true;
			componentResourceManager.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
			this.dataGridViewImageColumn1.Image = global::ns0.Class212.captchaplace;
			this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
			this.dataGridViewImageColumn1.ReadOnly = true;
			componentResourceManager.ApplyResources(this.btnMoveDown, "btnMoveDown");
			this.btnMoveDown.BackColor = global::System.Drawing.Color.Transparent;
			this.btnMoveDown.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.btnMoveDown.Image = global::ns0.Class212.download;
			this.btnMoveDown.Name = "btnMoveDown";
			this.btnMoveDown.UseVisualStyleBackColor = false;
			this.btnMoveDown.Click += new global::System.EventHandler(this.btnMoveDown_Click);
			componentResourceManager.ApplyResources(this.btnMoveUp, "btnMoveUp");
			this.btnMoveUp.BackColor = global::System.Drawing.Color.Transparent;
			this.btnMoveUp.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.btnMoveUp.Image = global::ns0.Class212.uparrow;
			this.btnMoveUp.Name = "btnMoveUp";
			this.btnMoveUp.UseVisualStyleBackColor = false;
			this.btnMoveUp.Click += new global::System.EventHandler(this.btnMoveUp_Click);
			this.GLoginContextMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_0,
				this.toolStripMenuItem_1
			});
			this.GLoginContextMenu.Name = "GLoginContextMenu";
			componentResourceManager.ApplyResources(this.GLoginContextMenu, "GLoginContextMenu");
			this.GLoginContextMenu.Opening += new global::System.ComponentModel.CancelEventHandler(this.GLoginContextMenu_Opening);
			this.toolStripMenuItem_0.Name = "mởGameTấtCảCácProfileNàyToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_0, "mởGameTấtCảCácProfileNàyToolStripMenuItem");
			this.toolStripMenuItem_0.Click += new global::System.EventHandler(this.toolStripMenuItem_0_Click);
			this.toolStripMenuItem_1.Name = "gửiMãCaptchaChoCácProfileNàyToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_1, "gửiMãCaptchaChoCácProfileNàyToolStripMenuItem");
			this.toolStripMenuItem_1.Click += new global::System.EventHandler(this.toolStripMenuItem_1_Click);
			componentResourceManager.ApplyResources(this.lvAllProfiles, "lvAllProfiles");
			this.lvAllProfiles.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_5,
				this.columnHeader_6,
				this.columnHeader_7,
				this.columnHeader_8,
				this.columnHeader_9
			});
			this.lvAllProfiles.FullRowSelect = true;
			this.lvAllProfiles.GridLines = true;
			this.lvAllProfiles.HideSelection = false;
			this.lvAllProfiles.Int32_1 = -1;
			this.lvAllProfiles.Int32_0 = -1;
			this.lvAllProfiles.Name = "lvAllProfiles";
			this.lvAllProfiles.UseCompatibleStateImageBehavior = false;
			this.lvAllProfiles.View = global::System.Windows.Forms.View.Details;
			this.lvAllProfiles.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.lvAllProfiles_MouseDoubleClick);
			componentResourceManager.ApplyResources(this.columnHeader_5, "columnHeader6");
			componentResourceManager.ApplyResources(this.columnHeader_6, "columnHeader7");
			componentResourceManager.ApplyResources(this.columnHeader_7, "columnHeader8");
			componentResourceManager.ApplyResources(this.columnHeader_8, "columnHeader9");
			componentResourceManager.ApplyResources(this.columnHeader_9, "columnHeader10");
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.WhiteSmoke;
			base.Controls.Add(this.dataGridView1);
			base.Controls.Add(this.btnBrowseVNG);
			base.Controls.Add(this.tboxGameFile);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.lvAllProfiles);
			base.Controls.Add(this.btnMoveDown);
			base.Controls.Add(this.btnMoveUp);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.tboxName);
			base.Controls.Add(this.cboHopKiem);
			base.Controls.Add(this.btnDelProfile);
			base.Controls.Add(this.cboServer);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.cboxAgreement);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.tboxPassword);
			base.Controls.Add(this.lblAgreementTitle);
			base.Controls.Add(this.lblAgreement);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.tboxUsername);
			base.Controls.Add(this.cboNPH);
			base.Controls.Add(this.btnThemProfile);
			base.Controls.Add(this.btnEditProfile);
			base.Controls.Add(this.label2);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.HelpButton = true;
			base.Name = "frmProfileManager";
			base.Load += new global::System.EventHandler(this.frmProfileManager_Load);
			base.Shown += new global::System.EventHandler(this.frmProfileManager_Shown);
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
			this.GLoginContextMenu.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000EF1 RID: 3825
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000EF2 RID: 3826
		private global::System.Windows.Forms.TextBox tboxUsername;

		// Token: 0x04000EF3 RID: 3827
		private global::System.Windows.Forms.ComboBox cboNPH;

		// Token: 0x04000EF4 RID: 3828
		private global::System.Windows.Forms.Button btnThemProfile;

		// Token: 0x04000EF5 RID: 3829
		private global::System.Windows.Forms.Button btnEditProfile;

		// Token: 0x04000EF6 RID: 3830
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000EF7 RID: 3831
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000EF8 RID: 3832
		private global::System.Windows.Forms.Label lblAgreement;

		// Token: 0x04000EF9 RID: 3833
		private global::System.Windows.Forms.Label lblAgreementTitle;

		// Token: 0x04000EFA RID: 3834
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000EFB RID: 3835
		private global::System.Windows.Forms.TextBox tboxPassword;

		// Token: 0x04000EFC RID: 3836
		private global::System.Windows.Forms.CheckBox cboxAgreement;

		// Token: 0x04000EFD RID: 3837
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000EFE RID: 3838
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000EFF RID: 3839
		private global::System.Windows.Forms.ComboBox cboServer;

		// Token: 0x04000F00 RID: 3840
		private global::System.Windows.Forms.Button btnDelProfile;

		// Token: 0x04000F01 RID: 3841
		private global::System.Windows.Forms.ComboBox cboHopKiem;

		// Token: 0x04000F02 RID: 3842
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000F03 RID: 3843
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x04000F04 RID: 3844
		private global::System.Windows.Forms.ColumnHeader columnHeader_1;

		// Token: 0x04000F05 RID: 3845
		private global::System.Windows.Forms.ColumnHeader columnHeader_2;

		// Token: 0x04000F06 RID: 3846
		private global::System.Windows.Forms.ColumnHeader columnHeader_3;

		// Token: 0x04000F07 RID: 3847
		private global::System.Windows.Forms.ColumnHeader columnHeader_4;

		// Token: 0x04000F08 RID: 3848
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000F09 RID: 3849
		private global::System.Windows.Forms.TextBox tboxName;

		// Token: 0x04000F0A RID: 3850
		private global::ns0.GClass3 lvAllProfiles;

		// Token: 0x04000F0B RID: 3851
		private global::System.Windows.Forms.Button btnMoveUp;

		// Token: 0x04000F0C RID: 3852
		private global::System.Windows.Forms.Button btnMoveDown;

		// Token: 0x04000F0D RID: 3853
		private global::System.Windows.Forms.ColumnHeader columnHeader_5;

		// Token: 0x04000F0E RID: 3854
		private global::System.Windows.Forms.ColumnHeader columnHeader_6;

		// Token: 0x04000F0F RID: 3855
		private global::System.Windows.Forms.ColumnHeader columnHeader_7;

		// Token: 0x04000F10 RID: 3856
		private global::System.Windows.Forms.ColumnHeader columnHeader_8;

		// Token: 0x04000F11 RID: 3857
		private global::System.Windows.Forms.ColumnHeader columnHeader_9;

		// Token: 0x04000F12 RID: 3858
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000F13 RID: 3859
		private global::System.Windows.Forms.TextBox tboxGameFile;

		// Token: 0x04000F14 RID: 3860
		private global::System.Windows.Forms.Button btnBrowseVNG;

		// Token: 0x04000F15 RID: 3861
		private global::System.Windows.Forms.DataGridView dataGridView1;

		// Token: 0x04000F16 RID: 3862
		private global::System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;

		// Token: 0x04000F17 RID: 3863
		private global::System.Windows.Forms.ContextMenuStrip GLoginContextMenu;

		// Token: 0x04000F18 RID: 3864
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x04000F19 RID: 3865
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_1;

		// Token: 0x04000F1A RID: 3866
		private global::System.Windows.Forms.DataGridViewTextBoxColumn colUsername;

		// Token: 0x04000F1B RID: 3867
		private global::System.Windows.Forms.DataGridViewTextBoxColumn colNPH;

		// Token: 0x04000F1C RID: 3868
		private global::System.Windows.Forms.DataGridViewTextBoxColumn colServer;

		// Token: 0x04000F1D RID: 3869
		private global::System.Windows.Forms.DataGridViewTextBoxColumn colHopKiem;

		// Token: 0x04000F1E RID: 3870
		private global::System.Windows.Forms.DataGridViewTextBoxColumn colTenNV;

		// Token: 0x04000F1F RID: 3871
		private global::System.Windows.Forms.DataGridViewImageColumn colCaptcha;

		// Token: 0x04000F20 RID: 3872
		private global::System.Windows.Forms.DataGridViewButtonColumn NewCaptcha;

		// Token: 0x04000F21 RID: 3873
		private global::System.Windows.Forms.DataGridViewTextBoxColumn colCaptcha2;

		// Token: 0x04000F22 RID: 3874
		private global::System.Windows.Forms.DataGridViewCheckBoxColumn colLoginCbox;

		// Token: 0x04000F23 RID: 3875
		private global::System.Windows.Forms.DataGridViewButtonColumn colButtonLogin;
	}
}
