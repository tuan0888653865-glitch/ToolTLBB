namespace ns0
{
	// Token: 0x020000F8 RID: 248
	internal sealed partial class frmBuffList : global::System.Windows.Forms.Form
	{
		// Token: 0x060009CD RID: 2509 RVA: 0x0000A335 File Offset: 0x00008535
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x000B39B8 File Offset: 0x000B1BB8
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmBuffList));
			this.btnAddName = new global::System.Windows.Forms.Button();
			this.txtBuffName = new global::System.Windows.Forms.TextBox();
			this.lvBuffList = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.lblTop = new global::System.Windows.Forms.Label();
			this.btnClose = new global::System.Windows.Forms.Button();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.label12 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.lvPlayers = new global::System.Windows.Forms.ListView();
			this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_2 = new global::System.Windows.Forms.ColumnHeader();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.btnRefresh = new global::System.Windows.Forms.Button();
			this.cboxTuRefresh = new global::System.Windows.Forms.CheckBox();
			this.btnSaveList = new global::System.Windows.Forms.Button();
			this.btnRemove = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.btnDanhSachBuff = new global::System.Windows.Forms.Button();
			this.cboItemName = new global::System.Windows.Forms.ComboBox();
			base.SuspendLayout();
			this.btnAddName.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			componentResourceManager.ApplyResources(this.btnAddName, "btnAddName");
			this.btnAddName.Name = "btnAddName";
			this.btnAddName.UseVisualStyleBackColor = false;
			this.btnAddName.Click += new global::System.EventHandler(this.btnAddName_Click);
			this.txtBuffName.BackColor = global::System.Drawing.Color.WhiteSmoke;
			componentResourceManager.ApplyResources(this.txtBuffName, "txtBuffName");
			this.txtBuffName.Name = "txtBuffName";
			this.lvBuffList.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.lvBuffList.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0
			});
			this.lvBuffList.ForeColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.lvBuffList.FullRowSelect = true;
			this.lvBuffList.GridLines = true;
			this.lvBuffList.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			componentResourceManager.ApplyResources(this.lvBuffList, "lvBuffList");
			this.lvBuffList.Name = "lvBuffList";
			this.lvBuffList.UseCompatibleStateImageBehavior = false;
			this.lvBuffList.View = global::System.Windows.Forms.View.Details;
			this.lvBuffList.SelectedIndexChanged += new global::System.EventHandler(this.lvBuffList_SelectedIndexChanged);
			this.lvBuffList.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.lvBuffList_MouseDoubleClick);
			componentResourceManager.ApplyResources(this.columnHeader_0, "columnHeader16");
			componentResourceManager.ApplyResources(this.lblTop, "lblTop");
			this.lblTop.Name = "lblTop";
			this.btnClose.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			componentResourceManager.ApplyResources(this.btnClose, "btnClose");
			this.btnClose.Name = "btnClose";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new global::System.EventHandler(this.btnClose_Click);
			this.timer_0.Enabled = true;
			this.timer_0.Interval = 500;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			componentResourceManager.ApplyResources(this.label12, "label12");
			this.label12.ForeColor = global::System.Drawing.Color.DodgerBlue;
			this.label12.Name = "label12";
			componentResourceManager.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			this.lvPlayers.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.lvPlayers.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_1,
				this.columnHeader_2
			});
			this.lvPlayers.ForeColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.lvPlayers.FullRowSelect = true;
			this.lvPlayers.GridLines = true;
			this.lvPlayers.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			componentResourceManager.ApplyResources(this.lvPlayers, "lvPlayers");
			this.lvPlayers.Name = "lvPlayers";
			this.lvPlayers.UseCompatibleStateImageBehavior = false;
			this.lvPlayers.View = global::System.Windows.Forms.View.Details;
			this.lvPlayers.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.lvPlayers_MouseDoubleClick);
			componentResourceManager.ApplyResources(this.columnHeader_1, "columnHeader1");
			componentResourceManager.ApplyResources(this.columnHeader_2, "columnHeader2");
			componentResourceManager.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			componentResourceManager.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			this.btnRefresh.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			componentResourceManager.ApplyResources(this.btnRefresh, "btnRefresh");
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.btnRefresh.Click += new global::System.EventHandler(this.btnRefresh_Click);
			componentResourceManager.ApplyResources(this.cboxTuRefresh, "cboxTuRefresh");
			this.cboxTuRefresh.BackColor = global::System.Drawing.Color.Transparent;
			this.cboxTuRefresh.Checked = true;
			this.cboxTuRefresh.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.cboxTuRefresh.Name = "cboxTuRefresh";
			this.cboxTuRefresh.UseVisualStyleBackColor = false;
			this.cboxTuRefresh.CheckedChanged += new global::System.EventHandler(this.cboxTuRefresh_CheckedChanged);
			this.btnSaveList.BackColor = global::System.Drawing.Color.Transparent;
			componentResourceManager.ApplyResources(this.btnSaveList, "btnSaveList");
			this.btnSaveList.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.btnSaveList.Image = global::ns0.Class212.save;
			this.btnSaveList.Name = "btnSaveList";
			this.btnSaveList.UseVisualStyleBackColor = false;
			this.btnSaveList.Click += new global::System.EventHandler(this.btnSaveList_Click);
			this.btnRemove.BackColor = global::System.Drawing.SystemColors.Control;
			componentResourceManager.ApplyResources(this.btnRemove, "btnRemove");
			this.btnRemove.ForeColor = global::System.Drawing.SystemColors.Control;
			this.btnRemove.Image = global::ns0.Class212.right;
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.UseVisualStyleBackColor = false;
			this.btnRemove.Click += new global::System.EventHandler(this.btnRemove_Click);
			this.btnAdd.BackColor = global::System.Drawing.SystemColors.Control;
			componentResourceManager.ApplyResources(this.btnAdd, "btnAdd");
			this.btnAdd.ForeColor = global::System.Drawing.SystemColors.Control;
			this.btnAdd.Image = global::ns0.Class212.left;
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new global::System.EventHandler(this.btnAdd_Click);
			this.btnDanhSachBuff.BackColor = global::System.Drawing.Color.Transparent;
			componentResourceManager.ApplyResources(this.btnDanhSachBuff, "btnDanhSachBuff");
			this.btnDanhSachBuff.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.btnDanhSachBuff.Image = global::ns0.Class212.folderopen;
			this.btnDanhSachBuff.Name = "btnDanhSachBuff";
			this.btnDanhSachBuff.UseVisualStyleBackColor = false;
			this.btnDanhSachBuff.Click += new global::System.EventHandler(this.btnDanhSachBuff_Click);
			this.cboItemName.DropDownWidth = 170;
			this.cboItemName.FormattingEnabled = true;
			componentResourceManager.ApplyResources(this.cboItemName, "cboItemName");
			this.cboItemName.Name = "cboItemName";
			this.cboItemName.DropDown += new global::System.EventHandler(this.cboItemName_DropDown);
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.cboItemName);
			base.Controls.Add(this.cboxTuRefresh);
			base.Controls.Add(this.btnRefresh);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.btnSaveList);
			base.Controls.Add(this.btnRemove);
			base.Controls.Add(this.btnAdd);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.lvPlayers);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.label12);
			base.Controls.Add(this.btnClose);
			base.Controls.Add(this.lblTop);
			base.Controls.Add(this.btnDanhSachBuff);
			base.Controls.Add(this.btnAddName);
			base.Controls.Add(this.txtBuffName);
			base.Controls.Add(this.lvBuffList);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.MaximizeBox = false;
			base.Name = "frmBuffList";
			base.Load += new global::System.EventHandler(this.frmBuffList_Load);
			base.Shown += new global::System.EventHandler(this.frmBuffList_Shown);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000CB4 RID: 3252
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000CB5 RID: 3253
		private global::System.Windows.Forms.Button btnDanhSachBuff;

		// Token: 0x04000CB6 RID: 3254
		private global::System.Windows.Forms.Button btnAddName;

		// Token: 0x04000CB7 RID: 3255
		private global::System.Windows.Forms.TextBox txtBuffName;

		// Token: 0x04000CB8 RID: 3256
		private global::System.Windows.Forms.ListView lvBuffList;

		// Token: 0x04000CB9 RID: 3257
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x04000CBA RID: 3258
		private global::System.Windows.Forms.Label lblTop;

		// Token: 0x04000CBB RID: 3259
		private global::System.Windows.Forms.Button btnClose;

		// Token: 0x04000CBC RID: 3260
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000CBD RID: 3261
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04000CBE RID: 3262
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000CBF RID: 3263
		private global::System.Windows.Forms.ListView lvPlayers;

		// Token: 0x04000CC0 RID: 3264
		private global::System.Windows.Forms.ColumnHeader columnHeader_1;

		// Token: 0x04000CC1 RID: 3265
		private global::System.Windows.Forms.ColumnHeader columnHeader_2;

		// Token: 0x04000CC2 RID: 3266
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000CC3 RID: 3267
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000CC4 RID: 3268
		private global::System.Windows.Forms.Button btnRemove;

		// Token: 0x04000CC5 RID: 3269
		private global::System.Windows.Forms.Button btnSaveList;

		// Token: 0x04000CC6 RID: 3270
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000CC7 RID: 3271
		private global::System.Windows.Forms.Button btnRefresh;

		// Token: 0x04000CC8 RID: 3272
		private global::System.Windows.Forms.CheckBox cboxTuRefresh;

		// Token: 0x04000CC9 RID: 3273
		private global::System.Windows.Forms.ComboBox cboItemName;
	}
}
