namespace ns0
{
	// Token: 0x020000EC RID: 236
	internal sealed partial class frmItemList : global::System.Windows.Forms.Form
	{
		// Token: 0x06000933 RID: 2355 RVA: 0x00009E11 File Offset: 0x00008011
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x000A7E04 File Offset: 0x000A6004
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmItemList));
			this.btnAddName = new global::System.Windows.Forms.Button();
			this.txtBuffName = new global::System.Windows.Forms.TextBox();
			this.lblTop = new global::System.Windows.Forms.Label();
			this.btnClose = new global::System.Windows.Forms.Button();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.label12 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.btnRefresh = new global::System.Windows.Forms.Button();
			this.cboxTuRefresh = new global::System.Windows.Forms.CheckBox();
			this.btnSaveList = new global::System.Windows.Forms.Button();
			this.btnRemove = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.btnDanhSachBuff = new global::System.Windows.Forms.Button();
			this.cboItemName = new global::System.Windows.Forms.ComboBox();
			this.listLeft = new global::BrightIdeasSoftware.ObjectListView();
			this.olvcolumn_0 = new global::BrightIdeasSoftware.OLVColumn();
			this.listRight = new global::BrightIdeasSoftware.ObjectListView();
			this.olvcolumn_1 = new global::BrightIdeasSoftware.OLVColumn();
			this.olvcolumn_2 = new global::BrightIdeasSoftware.OLVColumn();
			((global::System.ComponentModel.ISupportInitialize)this.listLeft).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.listRight).BeginInit();
			base.SuspendLayout();
			this.btnAddName.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			componentResourceManager.ApplyResources(this.btnAddName, "btnAddName");
			this.btnAddName.Name = "btnAddName";
			this.btnAddName.UseVisualStyleBackColor = false;
			this.btnAddName.Click += new global::System.EventHandler(this.btnAddName_Click);
			this.txtBuffName.BackColor = global::System.Drawing.Color.WhiteSmoke;
			componentResourceManager.ApplyResources(this.txtBuffName, "txtBuffName");
			this.txtBuffName.Name = "txtBuffName";
			componentResourceManager.ApplyResources(this.lblTop, "lblTop");
			this.lblTop.Name = "lblTop";
			this.btnClose.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			componentResourceManager.ApplyResources(this.btnClose, "btnClose");
			this.btnClose.Name = "btnClose";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new global::System.EventHandler(this.btnClose_Click);
			this.timer_0.Enabled = true;
			this.timer_0.Interval = 1500;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			componentResourceManager.ApplyResources(this.label12, "label12");
			this.label12.ForeColor = global::System.Drawing.Color.DodgerBlue;
			this.label12.Name = "label12";
			componentResourceManager.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			this.label1.Click += new global::System.EventHandler(this.label1_Click);
			componentResourceManager.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			componentResourceManager.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			this.label3.Click += new global::System.EventHandler(this.label3_Click);
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
			this.cboItemName.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.cboItemName_KeyPress);
			this.listLeft.AllColumns.Add(this.olvcolumn_0);
			this.listLeft.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			this.listLeft.CellEditActivation = global::BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
			this.listLeft.CellEditEnterChangesRows = true;
			this.listLeft.CellEditTabChangesRows = true;
			this.listLeft.CellEditUseWholeCell = false;
			this.listLeft.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.olvcolumn_0
			});
			this.listLeft.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.listLeft.ForeColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.listLeft.FullRowSelect = true;
			this.listLeft.HideSelection = false;
			this.listLeft.IsSimpleDragSource = true;
			this.listLeft.IsSimpleDropSink = true;
			componentResourceManager.ApplyResources(this.listLeft, "listLeft");
			this.listLeft.Name = "listLeft";
			this.listLeft.UseCompatibleStateImageBehavior = false;
			this.listLeft.UseHotControls = false;
			this.listLeft.UseOverlays = false;
			this.listLeft.View = global::System.Windows.Forms.View.Details;
			this.listLeft.CellClick += new global::System.EventHandler<global::BrightIdeasSoftware.CellClickEventArgs>(this.method_5);
			this.listLeft.SelectionChanged += new global::System.EventHandler(this.listLeft_SelectionChanged);
			this.listLeft.SelectedIndexChanged += new global::System.EventHandler(this.listLeft_SelectedIndexChanged);
			this.olvcolumn_0.FillsFreeSpace = true;
			this.olvcolumn_0.Sortable = false;
			componentResourceManager.ApplyResources(this.olvcolumn_0, "colLeft_1");
			this.listRight.AllColumns.Add(this.olvcolumn_1);
			this.listRight.AllColumns.Add(this.olvcolumn_2);
			this.listRight.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			this.listRight.CellEditActivation = global::BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
			this.listRight.CellEditEnterChangesRows = true;
			this.listRight.CellEditTabChangesRows = true;
			this.listRight.CellEditUseWholeCell = false;
			this.listRight.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.olvcolumn_1,
				this.olvcolumn_2
			});
			this.listRight.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.listRight.ForeColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.listRight.FullRowSelect = true;
			this.listRight.HideSelection = false;
			this.listRight.IsSimpleDragSource = true;
			this.listRight.IsSimpleDropSink = true;
			componentResourceManager.ApplyResources(this.listRight, "listRight");
			this.listRight.Name = "listRight";
			this.listRight.UseCompatibleStateImageBehavior = false;
			this.listRight.UseHotControls = false;
			this.listRight.UseOverlays = false;
			this.listRight.View = global::System.Windows.Forms.View.Details;
			this.listRight.CellClick += new global::System.EventHandler<global::BrightIdeasSoftware.CellClickEventArgs>(this.method_6);
			this.olvcolumn_1.AspectName = "Name";
			this.olvcolumn_1.FillsFreeSpace = true;
			this.olvcolumn_1.Sortable = false;
			componentResourceManager.ApplyResources(this.olvcolumn_1, "colRight_1");
			this.olvcolumn_2.AspectName = "Level";
			componentResourceManager.ApplyResources(this.olvcolumn_2, "colRight_2");
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.listRight);
			base.Controls.Add(this.listLeft);
			base.Controls.Add(this.cboItemName);
			base.Controls.Add(this.cboxTuRefresh);
			base.Controls.Add(this.btnRefresh);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.btnSaveList);
			base.Controls.Add(this.btnRemove);
			base.Controls.Add(this.btnAdd);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.label12);
			base.Controls.Add(this.btnClose);
			base.Controls.Add(this.lblTop);
			base.Controls.Add(this.btnDanhSachBuff);
			base.Controls.Add(this.btnAddName);
			base.Controls.Add(this.txtBuffName);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.MaximizeBox = false;
			base.Name = "frmItemList";
			base.Load += new global::System.EventHandler(this.frmItemList_Load);
			base.Shown += new global::System.EventHandler(this.frmItemList_Shown);
			((global::System.ComponentModel.ISupportInitialize)this.listLeft).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.listRight).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000BDB RID: 3035
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000BDC RID: 3036
		private global::System.Windows.Forms.Button btnDanhSachBuff;

		// Token: 0x04000BDD RID: 3037
		private global::System.Windows.Forms.Button btnAddName;

		// Token: 0x04000BDE RID: 3038
		private global::System.Windows.Forms.TextBox txtBuffName;

		// Token: 0x04000BDF RID: 3039
		private global::System.Windows.Forms.Label lblTop;

		// Token: 0x04000BE0 RID: 3040
		private global::System.Windows.Forms.Button btnClose;

		// Token: 0x04000BE1 RID: 3041
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000BE2 RID: 3042
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04000BE3 RID: 3043
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000BE4 RID: 3044
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000BE5 RID: 3045
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000BE6 RID: 3046
		private global::System.Windows.Forms.Button btnRemove;

		// Token: 0x04000BE7 RID: 3047
		private global::System.Windows.Forms.Button btnSaveList;

		// Token: 0x04000BE8 RID: 3048
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000BE9 RID: 3049
		private global::System.Windows.Forms.Button btnRefresh;

		// Token: 0x04000BEA RID: 3050
		private global::System.Windows.Forms.CheckBox cboxTuRefresh;

		// Token: 0x04000BEB RID: 3051
		private global::System.Windows.Forms.ComboBox cboItemName;

		// Token: 0x04000BEC RID: 3052
		internal global::BrightIdeasSoftware.ObjectListView listLeft;

		// Token: 0x04000BED RID: 3053
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_0;

		// Token: 0x04000BEE RID: 3054
		internal global::BrightIdeasSoftware.ObjectListView listRight;

		// Token: 0x04000BEF RID: 3055
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_1;

		// Token: 0x04000BF0 RID: 3056
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_2;
	}
}
