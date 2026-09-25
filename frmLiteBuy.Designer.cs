namespace ns0
{
	// Token: 0x020000EE RID: 238
	internal sealed partial class frmLiteBuy : global::System.Windows.Forms.Form
	{
		// Token: 0x06000959 RID: 2393 RVA: 0x00009EFA File Offset: 0x000080FA
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x000AAA68 File Offset: 0x000A8C68
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmLiteBuy));
			this.pnelTitle = new global::System.Windows.Forms.Panel();
			this.btnClose = new global::System.Windows.Forms.Button();
			this.lbTitle = new global::System.Windows.Forms.Label();
			this.statusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.stripStatus = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel1 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.stripTotal = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.label1 = new global::System.Windows.Forms.Label();
			this.lbUsername = new global::System.Windows.Forms.Label();
			this.lbGG = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.lbGGPromo = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.pnelBalance = new global::System.Windows.Forms.Panel();
			this.lbHanDung = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.pnelUsage = new global::System.Windows.Forms.Panel();
			this.btnRefresh = new global::System.Windows.Forms.Button();
			this.lvHistory = new global::BrightIdeasSoftware.ObjectListView();
			this.olvcolumn_4 = new global::BrightIdeasSoftware.OLVColumn();
			this.olvcolumn_5 = new global::BrightIdeasSoftware.OLVColumn();
			this.olvcolumn_6 = new global::BrightIdeasSoftware.OLVColumn();
			this.olvcolumn_7 = new global::BrightIdeasSoftware.OLVColumn();
			this.olvcolumn_8 = new global::BrightIdeasSoftware.OLVColumn();
			this.label2 = new global::System.Windows.Forms.Label();
			this.pnelTinhNang = new global::System.Windows.Forms.Panel();
			this.lvTinhnang = new global::BrightIdeasSoftware.ObjectListView();
			this.olvcolumn_0 = new global::BrightIdeasSoftware.OLVColumn();
			this.olvcolumn_1 = new global::BrightIdeasSoftware.OLVColumn();
			this.olvcolumn_2 = new global::BrightIdeasSoftware.OLVColumn();
			this.olvcolumn_9 = new global::BrightIdeasSoftware.OLVColumn();
			this.olvcolumn_3 = new global::BrightIdeasSoftware.OLVColumn();
			this.label8 = new global::System.Windows.Forms.Label();
			this.pnelMuaGio = new global::System.Windows.Forms.Panel();
			this.groupLicenses = new global::System.Windows.Forms.GroupBox();
			this.pnelButtons = new global::System.Windows.Forms.Panel();
			this.lbCoupon = new global::System.Windows.Forms.Label();
			this.btnCoupon = new global::System.Windows.Forms.Button();
			this.label13 = new global::System.Windows.Forms.Label();
			this.txtCoupon = new global::System.Windows.Forms.TextBox();
			this.btnBuyHour = new global::System.Windows.Forms.Button();
			this.btnPackageExpand = new global::System.Windows.Forms.Button();
			this.backgroundWorker_0 = new global::System.ComponentModel.BackgroundWorker();
			this.pnelMuaGioTitle = new global::System.Windows.Forms.Panel();
			this.label6 = new global::System.Windows.Forms.Label();
			this.pnelTitle.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.pnelBalance.SuspendLayout();
			this.pnelUsage.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lvHistory).BeginInit();
			this.pnelTinhNang.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lvTinhnang).BeginInit();
			this.pnelMuaGio.SuspendLayout();
			this.pnelButtons.SuspendLayout();
			this.pnelMuaGioTitle.SuspendLayout();
			base.SuspendLayout();
			this.pnelTitle.Controls.Add(this.btnClose);
			this.pnelTitle.Controls.Add(this.lbTitle);
			this.pnelTitle.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.pnelTitle.Location = new global::System.Drawing.Point(0, 0);
			this.pnelTitle.Name = "pnelTitle";
			this.pnelTitle.Size = new global::System.Drawing.Size(314, 48);
			this.pnelTitle.TabIndex = 0;
			this.btnClose.BackColor = global::System.Drawing.Color.FromArgb(247, 207, 142);
			this.btnClose.ForeColor = global::System.Drawing.Color.Black;
			this.btnClose.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.btnClose.Location = new global::System.Drawing.Point(239, 5);
			this.btnClose.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new global::System.Drawing.Size(69, 23);
			this.btnClose.TabIndex = 16;
			this.btnClose.Text = "Đóng";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new global::System.EventHandler(this.btnClose_Click);
			this.lbTitle.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.lbTitle.Location = new global::System.Drawing.Point(0, 0);
			this.lbTitle.Margin = new global::System.Windows.Forms.Padding(5, 5, 3, 0);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Padding = new global::System.Windows.Forms.Padding(5, 3, 5, 3);
			this.lbTitle.Size = new global::System.Drawing.Size(314, 50);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "- Chọn gói Thuê bao\r\n- Chọn gói Tính năng (Chế đồ, auto Q)\r\n- Bấm \"Xác nhận mua\"";
			this.statusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.stripStatus,
				this.toolStripStatusLabel1,
				this.stripTotal
			});
			this.statusStrip1.Location = new global::System.Drawing.Point(0, 655);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new global::System.Drawing.Size(314, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			this.stripStatus.Name = "stripStatus";
			this.stripStatus.Size = new global::System.Drawing.Size(83, 17);
			this.stripStatus.Text = "Trạng thái: OK";
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new global::System.Drawing.Size(145, 17);
			this.toolStripStatusLabel1.Spring = true;
			this.stripTotal.Name = "stripTotal";
			this.stripTotal.Size = new global::System.Drawing.Size(71, 17);
			this.stripTotal.Text = "Sẽ tốn: 0 GG";
			this.timer_0.Enabled = true;
			this.timer_0.Interval = 400;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(11, 5);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(76, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Tên tài khoản:";
			this.lbUsername.AutoSize = true;
			this.lbUsername.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lbUsername.ForeColor = global::System.Drawing.Color.Blue;
			this.lbUsername.Location = new global::System.Drawing.Point(93, 5);
			this.lbUsername.Name = "lbUsername";
			this.lbUsername.Size = new global::System.Drawing.Size(25, 13);
			this.lbUsername.TabIndex = 3;
			this.lbUsername.Text = "___";
			this.lbGG.AutoSize = true;
			this.lbGG.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lbGG.ForeColor = global::System.Drawing.Color.Blue;
			this.lbGG.Location = new global::System.Drawing.Point(93, 22);
			this.lbGG.Name = "lbGG";
			this.lbGG.Size = new global::System.Drawing.Size(25, 13);
			this.lbGG.TabIndex = 5;
			this.lbGG.Text = "___";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(11, 22);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(47, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "GG còn:";
			this.lbGGPromo.AutoSize = true;
			this.lbGGPromo.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lbGGPromo.ForeColor = global::System.Drawing.Color.Blue;
			this.lbGGPromo.Location = new global::System.Drawing.Point(224, 22);
			this.lbGGPromo.Name = "lbGGPromo";
			this.lbGGPromo.Size = new global::System.Drawing.Size(25, 13);
			this.lbGGPromo.TabIndex = 7;
			this.lbGGPromo.Text = "___";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(168, 22);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(54, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "GG k.mãi:";
			this.pnelBalance.Controls.Add(this.lbHanDung);
			this.pnelBalance.Controls.Add(this.label4);
			this.pnelBalance.Controls.Add(this.label1);
			this.pnelBalance.Controls.Add(this.lbGGPromo);
			this.pnelBalance.Controls.Add(this.lbUsername);
			this.pnelBalance.Controls.Add(this.label5);
			this.pnelBalance.Controls.Add(this.label3);
			this.pnelBalance.Controls.Add(this.lbGG);
			this.pnelBalance.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.pnelBalance.Location = new global::System.Drawing.Point(0, 48);
			this.pnelBalance.Name = "pnelBalance";
			this.pnelBalance.Size = new global::System.Drawing.Size(314, 42);
			this.pnelBalance.TabIndex = 8;
			this.lbHanDung.AutoSize = true;
			this.lbHanDung.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lbHanDung.ForeColor = global::System.Drawing.Color.Blue;
			this.lbHanDung.Location = new global::System.Drawing.Point(224, 5);
			this.lbHanDung.Name = "lbHanDung";
			this.lbHanDung.Size = new global::System.Drawing.Size(25, 13);
			this.lbHanDung.TabIndex = 9;
			this.lbHanDung.Text = "___";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(168, 5);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(57, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Hạn dùng:";
			this.pnelUsage.Controls.Add(this.btnRefresh);
			this.pnelUsage.Controls.Add(this.lvHistory);
			this.pnelUsage.Controls.Add(this.label2);
			this.pnelUsage.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.pnelUsage.Location = new global::System.Drawing.Point(0, 515);
			this.pnelUsage.Name = "pnelUsage";
			this.pnelUsage.Size = new global::System.Drawing.Size(314, 140);
			this.pnelUsage.TabIndex = 10;
			this.btnRefresh.BackColor = global::System.Drawing.SystemColors.Control;
			this.btnRefresh.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnRefresh.ForeColor = global::System.Drawing.SystemColors.Control;
			this.btnRefresh.Image = global::ns0.Class212.refresh;
			this.btnRefresh.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.btnRefresh.Location = new global::System.Drawing.Point(158, 5);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new global::System.Drawing.Size(24, 20);
			this.btnRefresh.TabIndex = 74;
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.btnRefresh.Click += new global::System.EventHandler(this.btnRefresh_Click);
			this.lvHistory.AllColumns.Add(this.olvcolumn_4);
			this.lvHistory.AllColumns.Add(this.olvcolumn_5);
			this.lvHistory.AllColumns.Add(this.olvcolumn_6);
			this.lvHistory.AllColumns.Add(this.olvcolumn_7);
			this.lvHistory.AllColumns.Add(this.olvcolumn_8);
			this.lvHistory.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			this.lvHistory.CellEditUseWholeCell = false;
			this.lvHistory.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.olvcolumn_4,
				this.olvcolumn_5,
				this.olvcolumn_6,
				this.olvcolumn_7,
				this.olvcolumn_8
			});
			this.lvHistory.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.lvHistory.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lvHistory.ForeColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.lvHistory.FullRowSelect = true;
			this.lvHistory.Location = new global::System.Drawing.Point(0, 26);
			this.lvHistory.Margin = new global::System.Windows.Forms.Padding(2);
			this.lvHistory.Name = "lvHistory";
			this.lvHistory.Size = new global::System.Drawing.Size(314, 114);
			this.lvHistory.TabIndex = 73;
			this.lvHistory.UseCompatibleStateImageBehavior = false;
			this.lvHistory.View = global::System.Windows.Forms.View.Details;
			this.olvcolumn_4.AspectName = "Index";
			this.olvcolumn_4.Groupable = false;
			this.olvcolumn_4.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_4.Hideable = false;
			this.olvcolumn_4.IsEditable = false;
			this.olvcolumn_4.Sortable = false;
			this.olvcolumn_4.Text = "#";
			this.olvcolumn_4.Width = 25;
			this.olvcolumn_5.AspectName = "ActDate";
			this.olvcolumn_5.Groupable = false;
			this.olvcolumn_5.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_5.Hideable = false;
			this.olvcolumn_5.IsEditable = false;
			this.olvcolumn_5.Sortable = false;
			this.olvcolumn_5.Text = "Thời gian";
			this.olvcolumn_5.Width = 110;
			this.olvcolumn_6.AspectName = "Comment";
			this.olvcolumn_6.FillsFreeSpace = true;
			this.olvcolumn_6.Groupable = false;
			this.olvcolumn_6.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_6.Hideable = false;
			this.olvcolumn_6.IsEditable = false;
			this.olvcolumn_6.Sortable = false;
			this.olvcolumn_6.Text = "Hoạt động";
			this.olvcolumn_6.Width = 90;
			this.olvcolumn_7.AspectName = "Cost";
			this.olvcolumn_7.Groupable = false;
			this.olvcolumn_7.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_7.Hideable = false;
			this.olvcolumn_7.IsEditable = false;
			this.olvcolumn_7.Sortable = false;
			this.olvcolumn_7.Text = "Giá";
			this.olvcolumn_7.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.olvcolumn_7.Width = 32;
			this.olvcolumn_8.AspectName = "Balance";
			this.olvcolumn_8.Groupable = false;
			this.olvcolumn_8.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_8.Hideable = false;
			this.olvcolumn_8.IsEditable = false;
			this.olvcolumn_8.Sortable = false;
			this.olvcolumn_8.Text = "Còn (GG)";
			this.olvcolumn_8.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.olvcolumn_8.Width = 57;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(5, 9);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(155, 13);
			this.label2.TabIndex = 72;
			this.label2.Text = "Lịch sử hoạt động 10 ngày qua";
			this.pnelTinhNang.Controls.Add(this.lvTinhnang);
			this.pnelTinhNang.Controls.Add(this.label8);
			this.pnelTinhNang.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.pnelTinhNang.Location = new global::System.Drawing.Point(0, 90);
			this.pnelTinhNang.Name = "pnelTinhNang";
			this.pnelTinhNang.Size = new global::System.Drawing.Size(314, 97);
			this.pnelTinhNang.TabIndex = 11;
			this.lvTinhnang.AllColumns.Add(this.olvcolumn_0);
			this.lvTinhnang.AllColumns.Add(this.olvcolumn_1);
			this.lvTinhnang.AllColumns.Add(this.olvcolumn_2);
			this.lvTinhnang.AllColumns.Add(this.olvcolumn_9);
			this.lvTinhnang.AllColumns.Add(this.olvcolumn_3);
			this.lvTinhnang.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			this.lvTinhnang.CellEditActivation = global::BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
			this.lvTinhnang.CellEditUseWholeCell = false;
			this.lvTinhnang.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.olvcolumn_0,
				this.olvcolumn_1,
				this.olvcolumn_2,
				this.olvcolumn_9,
				this.olvcolumn_3
			});
			this.lvTinhnang.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.lvTinhnang.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lvTinhnang.ForeColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.lvTinhnang.FullRowSelect = true;
			this.lvTinhnang.Location = new global::System.Drawing.Point(0, 17);
			this.lvTinhnang.Margin = new global::System.Windows.Forms.Padding(2);
			this.lvTinhnang.Name = "lvTinhnang";
			this.lvTinhnang.Size = new global::System.Drawing.Size(314, 80);
			this.lvTinhnang.TabIndex = 9;
			this.lvTinhnang.UseCompatibleStateImageBehavior = false;
			this.lvTinhnang.View = global::System.Windows.Forms.View.Details;
			this.lvTinhnang.CellEditFinished += new global::BrightIdeasSoftware.CellEditEventHandler(this.lvTinhnang_CellEditFinished);
			this.lvTinhnang.CellEditStarting += new global::BrightIdeasSoftware.CellEditEventHandler(this.lvTinhnang_CellEditStarting);
			this.lvTinhnang.CellClick += new global::System.EventHandler<global::BrightIdeasSoftware.CellClickEventArgs>(this.method_8);
			this.lvTinhnang.ItemChecked += new global::System.Windows.Forms.ItemCheckedEventHandler(this.lvTinhnang_ItemChecked);
			this.olvcolumn_0.AspectName = "Tinhnang";
			this.olvcolumn_0.Groupable = false;
			this.olvcolumn_0.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_0.Hideable = false;
			this.olvcolumn_0.IsEditable = false;
			this.olvcolumn_0.Sortable = false;
			this.olvcolumn_0.Text = "Tính năng";
			this.olvcolumn_1.AspectName = "Remain";
			this.olvcolumn_1.Groupable = false;
			this.olvcolumn_1.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_1.Hideable = false;
			this.olvcolumn_1.IsEditable = false;
			this.olvcolumn_1.Sortable = false;
			this.olvcolumn_1.Text = "Còn lại";
			this.olvcolumn_1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.olvcolumn_1.ToolTipText = "Thời gian còn lại";
			this.olvcolumn_1.Width = 50;
			this.olvcolumn_2.AspectName = "Comment";
			this.olvcolumn_2.FillsFreeSpace = true;
			this.olvcolumn_2.Groupable = false;
			this.olvcolumn_2.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_2.Hideable = false;
			this.olvcolumn_2.IsEditable = false;
			this.olvcolumn_2.Sortable = false;
			this.olvcolumn_2.Text = "Gói đã mua";
			this.olvcolumn_2.Width = 105;
			this.olvcolumn_9.AspectName = "GiaHanTime";
			this.olvcolumn_9.ButtonSizing = global::BrightIdeasSoftware.OLVColumn.ButtonSizingMode.CellBounds;
			this.olvcolumn_9.Groupable = false;
			this.olvcolumn_9.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_9.Hideable = false;
			this.olvcolumn_9.Searchable = false;
			this.olvcolumn_9.Sortable = false;
			this.olvcolumn_9.Text = "Thêm";
			this.olvcolumn_9.UseFiltering = false;
			this.olvcolumn_9.Width = 45;
			this.olvcolumn_3.AspectName = "";
			this.olvcolumn_3.Groupable = false;
			this.olvcolumn_3.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_3.Hideable = false;
			this.olvcolumn_3.IsButton = true;
			this.olvcolumn_3.IsEditable = false;
			this.olvcolumn_3.Sortable = false;
			this.olvcolumn_3.Text = "Gia hạn";
			this.olvcolumn_3.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.olvcolumn_3.ToolTipText = "Gia hạn thêm giờ";
			this.olvcolumn_3.Width = 47;
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(5, 2);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(217, 13);
			this.label8.TabIndex = 2;
			this.label8.Text = "Tính năng đang có (nhấn dấu + để gia hạn)";
			this.pnelMuaGio.Controls.Add(this.groupLicenses);
			this.pnelMuaGio.Controls.Add(this.pnelButtons);
			this.pnelMuaGio.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.pnelMuaGio.Location = new global::System.Drawing.Point(0, 206);
			this.pnelMuaGio.Name = "pnelMuaGio";
			this.pnelMuaGio.Size = new global::System.Drawing.Size(314, 313);
			this.pnelMuaGio.TabIndex = 13;
			this.groupLicenses.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.groupLicenses.Location = new global::System.Drawing.Point(0, 0);
			this.groupLicenses.Margin = new global::System.Windows.Forms.Padding(5);
			this.groupLicenses.Name = "groupLicenses";
			this.groupLicenses.Size = new global::System.Drawing.Size(314, 258);
			this.groupLicenses.TabIndex = 3;
			this.groupLicenses.TabStop = false;
			this.groupLicenses.Text = "Gói Thuê bao";
			this.pnelButtons.Controls.Add(this.lbCoupon);
			this.pnelButtons.Controls.Add(this.btnCoupon);
			this.pnelButtons.Controls.Add(this.label13);
			this.pnelButtons.Controls.Add(this.txtCoupon);
			this.pnelButtons.Controls.Add(this.btnBuyHour);
			this.pnelButtons.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.pnelButtons.Location = new global::System.Drawing.Point(0, 258);
			this.pnelButtons.Name = "pnelButtons";
			this.pnelButtons.Size = new global::System.Drawing.Size(314, 55);
			this.pnelButtons.TabIndex = 13;
			this.pnelButtons.Paint += new global::System.Windows.Forms.PaintEventHandler(this.pnelButtons_Paint);
			this.lbCoupon.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.lbCoupon.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.lbCoupon.Location = new global::System.Drawing.Point(8, 35);
			this.lbCoupon.Name = "lbCoupon";
			this.lbCoupon.Size = new global::System.Drawing.Size(300, 13);
			this.lbCoupon.TabIndex = 76;
			this.lbCoupon.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCoupon.BackColor = global::System.Drawing.SystemColors.Control;
			this.btnCoupon.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCoupon.ForeColor = global::System.Drawing.SystemColors.Control;
			this.btnCoupon.Image = global::ns0.Class212.refresh;
			this.btnCoupon.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.btnCoupon.Location = new global::System.Drawing.Point(178, 7);
			this.btnCoupon.Name = "btnCoupon";
			this.btnCoupon.Size = new global::System.Drawing.Size(24, 20);
			this.btnCoupon.TabIndex = 75;
			this.btnCoupon.UseVisualStyleBackColor = false;
			this.btnCoupon.Click += new global::System.EventHandler(this.btnCoupon_Click);
			this.label13.AutoSize = true;
			this.label13.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label13.Location = new global::System.Drawing.Point(5, 11);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(83, 13);
			this.label13.TabIndex = 25;
			this.label13.Text = "Mã KM (nếu có)";
			this.label13.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.txtCoupon.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCoupon.Location = new global::System.Drawing.Point(94, 7);
			this.txtCoupon.Name = "txtCoupon";
			this.txtCoupon.Size = new global::System.Drawing.Size(81, 20);
			this.txtCoupon.TabIndex = 26;
			this.btnBuyHour.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnBuyHour.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.btnBuyHour.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.btnBuyHour.Location = new global::System.Drawing.Point(221, 5);
			this.btnBuyHour.Name = "btnBuyHour";
			this.btnBuyHour.Size = new global::System.Drawing.Size(88, 23);
			this.btnBuyHour.TabIndex = 15;
			this.btnBuyHour.Text = "Xác nhận mua";
			this.btnBuyHour.UseVisualStyleBackColor = false;
			this.btnBuyHour.Click += new global::System.EventHandler(this.btnBuyHour_Click);
			this.btnPackageExpand.BackColor = global::System.Drawing.Color.FromArgb(225, 225, 225);
			this.btnPackageExpand.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnPackageExpand.ForeColor = global::System.Drawing.Color.FromArgb(225, 225, 225);
			this.btnPackageExpand.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btnPackageExpand.Image");
			this.btnPackageExpand.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.btnPackageExpand.Location = new global::System.Drawing.Point(0, 0);
			this.btnPackageExpand.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnPackageExpand.Name = "btnPackageExpand";
			this.btnPackageExpand.Size = new global::System.Drawing.Size(19, 19);
			this.btnPackageExpand.TabIndex = 31;
			this.btnPackageExpand.UseVisualStyleBackColor = false;
			this.btnPackageExpand.Click += new global::System.EventHandler(this.btnPackageExpand_Click);
			this.backgroundWorker_0.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_0_DoWork);
			this.backgroundWorker_0.RunWorkerCompleted += new global::System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_0_RunWorkerCompleted);
			this.pnelMuaGioTitle.Controls.Add(this.btnPackageExpand);
			this.pnelMuaGioTitle.Controls.Add(this.label6);
			this.pnelMuaGioTitle.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.pnelMuaGioTitle.Location = new global::System.Drawing.Point(0, 187);
			this.pnelMuaGioTitle.Name = "pnelMuaGioTitle";
			this.pnelMuaGioTitle.Size = new global::System.Drawing.Size(314, 19);
			this.pnelMuaGioTitle.TabIndex = 14;
			this.label6.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.ForeColor = global::System.Drawing.Color.Firebrick;
			this.label6.Location = new global::System.Drawing.Point(0, 0);
			this.label6.Name = "label6";
			this.label6.Padding = new global::System.Windows.Forms.Padding(5, 3, 0, 0);
			this.label6.Size = new global::System.Drawing.Size(314, 20);
			this.label6.TabIndex = 16;
			this.label6.Text = "     Mua gói Thuê Bao và Tính năng (bấm để mở)";
			this.label6.Click += new global::System.EventHandler(this.label6_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(314, 677);
			base.Controls.Add(this.pnelMuaGio);
			base.Controls.Add(this.pnelMuaGioTitle);
			base.Controls.Add(this.pnelUsage);
			base.Controls.Add(this.pnelTinhNang);
			base.Controls.Add(this.pnelBalance);
			base.Controls.Add(this.pnelTitle);
			base.Controls.Add(this.statusStrip1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(330, 999);
			this.MinimumSize = new global::System.Drawing.Size(330, 468);
			base.Name = "frmLiteBuy";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			base.Tag = "XC";
			this.Text = "Mua giờ chơi";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmLiteBuy_FormClosing);
			base.Load += new global::System.EventHandler(this.frmLiteBuy_Load);
			base.Shown += new global::System.EventHandler(this.frmLiteBuy_Shown);
			this.pnelTitle.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.pnelBalance.ResumeLayout(false);
			this.pnelBalance.PerformLayout();
			this.pnelUsage.ResumeLayout(false);
			this.pnelUsage.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lvHistory).EndInit();
			this.pnelTinhNang.ResumeLayout(false);
			this.pnelTinhNang.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lvTinhnang).EndInit();
			this.pnelMuaGio.ResumeLayout(false);
			this.pnelButtons.ResumeLayout(false);
			this.pnelButtons.PerformLayout();
			this.pnelMuaGioTitle.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000C06 RID: 3078
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000C07 RID: 3079
		private global::System.Windows.Forms.Panel pnelTitle;

		// Token: 0x04000C08 RID: 3080
		private global::System.Windows.Forms.Label lbTitle;

		// Token: 0x04000C09 RID: 3081
		private global::System.Windows.Forms.StatusStrip statusStrip1;

		// Token: 0x04000C0A RID: 3082
		private global::System.Windows.Forms.ToolStripStatusLabel stripStatus;

		// Token: 0x04000C0B RID: 3083
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000C0C RID: 3084
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

		// Token: 0x04000C0D RID: 3085
		private global::System.Windows.Forms.ToolStripStatusLabel stripTotal;

		// Token: 0x04000C0E RID: 3086
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000C0F RID: 3087
		private global::System.Windows.Forms.Label lbUsername;

		// Token: 0x04000C10 RID: 3088
		private global::System.Windows.Forms.Label lbGG;

		// Token: 0x04000C11 RID: 3089
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000C12 RID: 3090
		private global::System.Windows.Forms.Label lbGGPromo;

		// Token: 0x04000C13 RID: 3091
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000C14 RID: 3092
		private global::System.Windows.Forms.Panel pnelBalance;

		// Token: 0x04000C15 RID: 3093
		private global::System.Windows.Forms.Panel pnelUsage;

		// Token: 0x04000C16 RID: 3094
		private global::System.Windows.Forms.Label lbHanDung;

		// Token: 0x04000C17 RID: 3095
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000C18 RID: 3096
		private global::System.Windows.Forms.Panel pnelTinhNang;

		// Token: 0x04000C19 RID: 3097
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000C1A RID: 3098
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_0;

		// Token: 0x04000C1B RID: 3099
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_1;

		// Token: 0x04000C1C RID: 3100
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_2;

		// Token: 0x04000C1D RID: 3101
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_3;

		// Token: 0x04000C1E RID: 3102
		private global::System.Windows.Forms.Button btnRefresh;

		// Token: 0x04000C1F RID: 3103
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_4;

		// Token: 0x04000C20 RID: 3104
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_5;

		// Token: 0x04000C21 RID: 3105
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_6;

		// Token: 0x04000C22 RID: 3106
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_7;

		// Token: 0x04000C23 RID: 3107
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_8;

		// Token: 0x04000C24 RID: 3108
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000C25 RID: 3109
		private global::System.Windows.Forms.Panel pnelMuaGio;

		// Token: 0x04000C26 RID: 3110
		private global::System.Windows.Forms.GroupBox groupLicenses;

		// Token: 0x04000C27 RID: 3111
		internal global::BrightIdeasSoftware.ObjectListView lvTinhnang;

		// Token: 0x04000C28 RID: 3112
		internal global::BrightIdeasSoftware.ObjectListView lvHistory;

		// Token: 0x04000C29 RID: 3113
		private global::System.ComponentModel.BackgroundWorker backgroundWorker_0;

		// Token: 0x04000C2A RID: 3114
		private global::System.Windows.Forms.Button btnPackageExpand;

		// Token: 0x04000C2B RID: 3115
		private global::System.Windows.Forms.Panel pnelButtons;

		// Token: 0x04000C2C RID: 3116
		private global::System.Windows.Forms.Button btnClose;

		// Token: 0x04000C2D RID: 3117
		internal global::System.Windows.Forms.Button btnBuyHour;

		// Token: 0x04000C2E RID: 3118
		private global::System.Windows.Forms.Panel pnelMuaGioTitle;

		// Token: 0x04000C2F RID: 3119
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000C30 RID: 3120
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_9;

		// Token: 0x04000C31 RID: 3121
		private global::System.Windows.Forms.Button btnCoupon;

		// Token: 0x04000C32 RID: 3122
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000C33 RID: 3123
		private global::System.Windows.Forms.TextBox txtCoupon;

		// Token: 0x04000C34 RID: 3124
		private global::System.Windows.Forms.Label lbCoupon;
	}
}
