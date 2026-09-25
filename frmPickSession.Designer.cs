namespace ns0
{
	// Token: 0x020000F5 RID: 245
	internal sealed partial class frmPickSession : global::System.Windows.Forms.Form
	{
		// Token: 0x0600099D RID: 2461 RVA: 0x0000A0D6 File Offset: 0x000082D6
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x000B0D04 File Offset: 0x000AEF04
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmPickSession));
			this.pnelTop = new global::System.Windows.Forms.Panel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.pnelMid = new global::System.Windows.Forms.Panel();
			this.lvSessions = new global::BrightIdeasSoftware.ObjectListView();
			this.olvcolumn_0 = new global::BrightIdeasSoftware.OLVColumn();
			this.olvcolumn_1 = new global::BrightIdeasSoftware.OLVColumn();
			this.olvcolumn_2 = new global::BrightIdeasSoftware.OLVColumn();
			this.olvcolumn_3 = new global::BrightIdeasSoftware.OLVColumn();
			this.olvcolumn_4 = new global::BrightIdeasSoftware.OLVColumn();
			this.pnelBottom = new global::System.Windows.Forms.Panel();
			this.lbTotalGG = new global::System.Windows.Forms.Label();
			this.lbUsername = new global::System.Windows.Forms.Label();
			this.cboPrice = new global::System.Windows.Forms.ComboBox();
			this.lbHWID = new global::System.Windows.Forms.Label();
			this.btnNewSession = new global::System.Windows.Forms.Button();
			this.btnThoatAuto = new global::System.Windows.Forms.Button();
			this.btnChonPhien = new global::System.Windows.Forms.Button();
			this.backgroundWorker_0 = new global::System.ComponentModel.BackgroundWorker();
			this.pnelTop.SuspendLayout();
			this.pnelMid.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lvSessions).BeginInit();
			this.pnelBottom.SuspendLayout();
			base.SuspendLayout();
			this.pnelTop.Controls.Add(this.label1);
			this.pnelTop.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.pnelTop.Location = new global::System.Drawing.Point(0, 0);
			this.pnelTop.Margin = new global::System.Windows.Forms.Padding(2);
			this.pnelTop.Name = "pnelTop";
			this.pnelTop.Size = new global::System.Drawing.Size(580, 52);
			this.pnelTop.TabIndex = 13;
			this.label1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new global::System.Drawing.Point(0, 0);
			this.label1.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Padding = new global::System.Windows.Forms.Padding(2, 3, 0, 0);
			this.label1.Size = new global::System.Drawing.Size(580, 42);
			this.label1.TabIndex = 2;
			this.label1.Text = componentResourceManager.GetString("label1.Text");
			this.pnelMid.Controls.Add(this.lvSessions);
			this.pnelMid.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pnelMid.Location = new global::System.Drawing.Point(0, 52);
			this.pnelMid.Margin = new global::System.Windows.Forms.Padding(2);
			this.pnelMid.Name = "pnelMid";
			this.pnelMid.Size = new global::System.Drawing.Size(580, 109);
			this.pnelMid.TabIndex = 14;
			this.lvSessions.AllColumns.Add(this.olvcolumn_0);
			this.lvSessions.AllColumns.Add(this.olvcolumn_1);
			this.lvSessions.AllColumns.Add(this.olvcolumn_2);
			this.lvSessions.AllColumns.Add(this.olvcolumn_3);
			this.lvSessions.AllColumns.Add(this.olvcolumn_4);
			this.lvSessions.AlternateRowBackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.lvSessions.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			this.lvSessions.CellEditUseWholeCell = false;
			this.lvSessions.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.olvcolumn_0,
				this.olvcolumn_1,
				this.olvcolumn_2,
				this.olvcolumn_3,
				this.olvcolumn_4
			});
			this.lvSessions.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.lvSessions.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lvSessions.ForeColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.lvSessions.FullRowSelect = true;
			this.lvSessions.GridLines = true;
			this.lvSessions.Location = new global::System.Drawing.Point(0, 0);
			this.lvSessions.Margin = new global::System.Windows.Forms.Padding(5, 2, 5, 2);
			this.lvSessions.Name = "lvSessions";
			this.lvSessions.Size = new global::System.Drawing.Size(580, 109);
			this.lvSessions.TabIndex = 1;
			this.lvSessions.UseCompatibleStateImageBehavior = false;
			this.lvSessions.View = global::System.Windows.Forms.View.Details;
			this.lvSessions.CellClick += new global::System.EventHandler<global::BrightIdeasSoftware.CellClickEventArgs>(this.method_5);
			this.lvSessions.ItemActivate += new global::System.EventHandler(this.lvSessions_ItemActivate);
			this.lvSessions.DoubleClick += new global::System.EventHandler(this.lvSessions_DoubleClick);
			this.olvcolumn_0.AspectName = "col_ID";
			this.olvcolumn_0.Groupable = false;
			this.olvcolumn_0.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_0.Hideable = false;
			this.olvcolumn_0.IsEditable = false;
			this.olvcolumn_0.Searchable = false;
			this.olvcolumn_0.Sortable = false;
			this.olvcolumn_0.Text = "#";
			this.olvcolumn_0.Width = 25;
			this.olvcolumn_1.AspectName = "col_HWID";
			this.olvcolumn_1.Groupable = false;
			this.olvcolumn_1.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_1.Hideable = false;
			this.olvcolumn_1.IsEditable = false;
			this.olvcolumn_1.Searchable = false;
			this.olvcolumn_1.Sortable = false;
			this.olvcolumn_1.Text = "Mã máy";
			this.olvcolumn_2.AspectName = "col_LastSeen";
			this.olvcolumn_2.Groupable = false;
			this.olvcolumn_2.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_2.Hideable = false;
			this.olvcolumn_2.IsEditable = false;
			this.olvcolumn_2.Searchable = false;
			this.olvcolumn_2.Sortable = false;
			this.olvcolumn_2.Text = "Đăng nhập cuối";
			this.olvcolumn_2.Width = 135;
			this.olvcolumn_3.AspectName = "col_Exp";
			this.olvcolumn_3.Groupable = false;
			this.olvcolumn_3.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_3.Hideable = false;
			this.olvcolumn_3.IsEditable = false;
			this.olvcolumn_3.Searchable = false;
			this.olvcolumn_3.Sortable = false;
			this.olvcolumn_3.Text = "Ngày hết hạn";
			this.olvcolumn_3.Width = 110;
			this.olvcolumn_4.AspectName = "col_Tinhnang";
			this.olvcolumn_4.FillsFreeSpace = true;
			this.olvcolumn_4.Groupable = false;
			this.olvcolumn_4.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_4.Hideable = false;
			this.olvcolumn_4.IsEditable = false;
			this.olvcolumn_4.Searchable = false;
			this.olvcolumn_4.Sortable = false;
			this.olvcolumn_4.Text = "Tính năng";
			this.olvcolumn_4.Width = 90;
			this.pnelBottom.Controls.Add(this.lbTotalGG);
			this.pnelBottom.Controls.Add(this.lbUsername);
			this.pnelBottom.Controls.Add(this.cboPrice);
			this.pnelBottom.Controls.Add(this.lbHWID);
			this.pnelBottom.Controls.Add(this.btnNewSession);
			this.pnelBottom.Controls.Add(this.btnThoatAuto);
			this.pnelBottom.Controls.Add(this.btnChonPhien);
			this.pnelBottom.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.pnelBottom.Location = new global::System.Drawing.Point(0, 161);
			this.pnelBottom.Margin = new global::System.Windows.Forms.Padding(2);
			this.pnelBottom.Name = "pnelBottom";
			this.pnelBottom.Size = new global::System.Drawing.Size(580, 54);
			this.pnelBottom.TabIndex = 15;
			this.lbTotalGG.AutoSize = true;
			this.lbTotalGG.Location = new global::System.Drawing.Point(300, 33);
			this.lbTotalGG.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbTotalGG.Name = "lbTotalGG";
			this.lbTotalGG.Size = new global::System.Drawing.Size(47, 13);
			this.lbTotalGG.TabIndex = 19;
			this.lbTotalGG.Text = "GG còn:";
			this.lbUsername.AutoSize = true;
			this.lbUsername.Location = new global::System.Drawing.Point(146, 33);
			this.lbUsername.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbUsername.Name = "lbUsername";
			this.lbUsername.Size = new global::System.Drawing.Size(55, 13);
			this.lbUsername.TabIndex = 18;
			this.lbUsername.Text = "Tài khoản";
			this.lbUsername.Click += new global::System.EventHandler(this.lbUsername_Click);
			this.cboPrice.FormattingEnabled = true;
			this.cboPrice.Location = new global::System.Drawing.Point(431, 6);
			this.cboPrice.Margin = new global::System.Windows.Forms.Padding(2);
			this.cboPrice.Name = "cboPrice";
			this.cboPrice.Size = new global::System.Drawing.Size(145, 21);
			this.cboPrice.TabIndex = 17;
			this.cboPrice.SelectedIndexChanged += new global::System.EventHandler(this.cboPrice_SelectedIndexChanged);
			this.lbHWID.AutoSize = true;
			this.lbHWID.Location = new global::System.Drawing.Point(6, 33);
			this.lbHWID.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbHWID.Name = "lbHWID";
			this.lbHWID.Size = new global::System.Drawing.Size(47, 13);
			this.lbHWID.TabIndex = 16;
			this.lbHWID.Text = "Mã máy:";
			this.btnNewSession.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnNewSession.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.btnNewSession.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.btnNewSession.Location = new global::System.Drawing.Point(338, 5);
			this.btnNewSession.Name = "btnNewSession";
			this.btnNewSession.Size = new global::System.Drawing.Size(88, 23);
			this.btnNewSession.TabIndex = 15;
			this.btnNewSession.Text = "Tạo phiên mới";
			this.btnNewSession.UseVisualStyleBackColor = false;
			this.btnNewSession.Click += new global::System.EventHandler(this.btnNewSession_Click);
			this.btnThoatAuto.BackColor = global::System.Drawing.Color.FromArgb(247, 207, 142);
			this.btnThoatAuto.ForeColor = global::System.Drawing.Color.Black;
			this.btnThoatAuto.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.btnThoatAuto.Location = new global::System.Drawing.Point(4, 5);
			this.btnThoatAuto.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnThoatAuto.Name = "btnThoatAuto";
			this.btnThoatAuto.Size = new global::System.Drawing.Size(69, 23);
			this.btnThoatAuto.TabIndex = 14;
			this.btnThoatAuto.Text = "Thoát Auto";
			this.btnThoatAuto.UseVisualStyleBackColor = false;
			this.btnThoatAuto.Click += new global::System.EventHandler(this.btnThoatAuto_Click);
			this.btnChonPhien.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnChonPhien.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.btnChonPhien.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.btnChonPhien.Location = new global::System.Drawing.Point(262, 5);
			this.btnChonPhien.Name = "btnChonPhien";
			this.btnChonPhien.Size = new global::System.Drawing.Size(70, 23);
			this.btnChonPhien.TabIndex = 13;
			this.btnChonPhien.Text = "Chọn phiên";
			this.btnChonPhien.UseVisualStyleBackColor = false;
			this.btnChonPhien.Click += new global::System.EventHandler(this.btnChonPhien_Click);
			this.backgroundWorker_0.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_0_DoWork);
			this.backgroundWorker_0.RunWorkerCompleted += new global::System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_0_RunWorkerCompleted);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(580, 215);
			base.Controls.Add(this.pnelMid);
			base.Controls.Add(this.pnelTop);
			base.Controls.Add(this.pnelBottom);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Margin = new global::System.Windows.Forms.Padding(2);
			base.MaximizeBox = false;
			base.Name = "frmPickSession";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chọn phiên làm việc auto";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmPickSession_FormClosing);
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.frmPickSession_FormClosed);
			base.Load += new global::System.EventHandler(this.frmPickSession_Load);
			base.Shown += new global::System.EventHandler(this.frmPickSession_Shown);
			this.pnelTop.ResumeLayout(false);
			this.pnelMid.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.lvSessions).EndInit();
			this.pnelBottom.ResumeLayout(false);
			this.pnelBottom.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000C88 RID: 3208
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000C89 RID: 3209
		private global::System.Windows.Forms.Panel pnelTop;

		// Token: 0x04000C8A RID: 3210
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000C8B RID: 3211
		private global::System.Windows.Forms.Panel pnelMid;

		// Token: 0x04000C8C RID: 3212
		private global::BrightIdeasSoftware.ObjectListView lvSessions;

		// Token: 0x04000C8D RID: 3213
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_0;

		// Token: 0x04000C8E RID: 3214
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_1;

		// Token: 0x04000C8F RID: 3215
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_2;

		// Token: 0x04000C90 RID: 3216
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_3;

		// Token: 0x04000C91 RID: 3217
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_4;

		// Token: 0x04000C92 RID: 3218
		private global::System.Windows.Forms.Panel pnelBottom;

		// Token: 0x04000C93 RID: 3219
		private global::System.Windows.Forms.Button btnNewSession;

		// Token: 0x04000C94 RID: 3220
		private global::System.Windows.Forms.Button btnThoatAuto;

		// Token: 0x04000C95 RID: 3221
		private global::System.Windows.Forms.Button btnChonPhien;

		// Token: 0x04000C96 RID: 3222
		private global::System.Windows.Forms.Label lbHWID;

		// Token: 0x04000C97 RID: 3223
		private global::System.ComponentModel.BackgroundWorker backgroundWorker_0;

		// Token: 0x04000C98 RID: 3224
		private global::System.Windows.Forms.ComboBox cboPrice;

		// Token: 0x04000C99 RID: 3225
		private global::System.Windows.Forms.Label lbUsername;

		// Token: 0x04000C9A RID: 3226
		private global::System.Windows.Forms.Label lbTotalGG;
	}
}
