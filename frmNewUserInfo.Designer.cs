namespace ns0
{
	// Token: 0x020000F3 RID: 243
	internal sealed partial class frmNewUserInfo : global::System.Windows.Forms.Form
	{
		// Token: 0x0600097C RID: 2428 RVA: 0x00009FBE File Offset: 0x000081BE
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x000ADDCC File Offset: 0x000ABFCC
		private void InitializeComponent()
		{
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.btnMua24h = new global::System.Windows.Forms.Button();
			this.btnNapThe = new global::System.Windows.Forms.Button();
			this.label5 = new global::System.Windows.Forms.Label();
			this.lvTinhnang = new global::BrightIdeasSoftware.ObjectListView();
			this.olvcolumn_0 = new global::BrightIdeasSoftware.OLVColumn();
			this.olvcolumn_1 = new global::BrightIdeasSoftware.OLVColumn();
			this.olvcolumn_2 = new global::BrightIdeasSoftware.OLVColumn();
			this.olvcolumn_3 = new global::BrightIdeasSoftware.OLVColumn();
			this.olvcolumn_4 = new global::BrightIdeasSoftware.OLVColumn();
			this.lbGGKM = new global::System.Windows.Forms.Label();
			this.lbGGNap = new global::System.Windows.Forms.Label();
			this.lbHandung = new global::System.Windows.Forms.Label();
			this.lbUsername = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.lblTotalPrice = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.btnMuaNgay = new global::System.Windows.Forms.Button();
			this.lvBuyLic = new global::BrightIdeasSoftware.ObjectListView();
			this.olvcolumn_5 = new global::BrightIdeasSoftware.OLVColumn();
			this.olvcolumn_6 = new global::BrightIdeasSoftware.OLVColumn();
			this.olvcolumn_7 = new global::BrightIdeasSoftware.OLVColumn();
			this.olvcolumn_8 = new global::BrightIdeasSoftware.OLVColumn();
			this.olvcolumn_15 = new global::BrightIdeasSoftware.OLVColumn();
			this.olvcolumn_9 = new global::BrightIdeasSoftware.OLVColumn();
			this.cboBuyTrader = new global::System.Windows.Forms.ComboBox();
			this.label8 = new global::System.Windows.Forms.Label();
			this.cboBuyYTO = new global::System.Windows.Forms.ComboBox();
			this.label9 = new global::System.Windows.Forms.Label();
			this.cboBuyChedo = new global::System.Windows.Forms.ComboBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.cboBuyTime = new global::System.Windows.Forms.ComboBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.btnRefresh = new global::System.Windows.Forms.Button();
			this.lvHistory = new global::BrightIdeasSoftware.ObjectListView();
			this.olvcolumn_10 = new global::BrightIdeasSoftware.OLVColumn();
			this.olvcolumn_11 = new global::BrightIdeasSoftware.OLVColumn();
			this.olvcolumn_12 = new global::BrightIdeasSoftware.OLVColumn();
			this.olvcolumn_13 = new global::BrightIdeasSoftware.OLVColumn();
			this.olvcolumn_14 = new global::BrightIdeasSoftware.OLVColumn();
			this.statusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.status1 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.backgroundWorker_0 = new global::System.ComponentModel.BackgroundWorker();
			this.groupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lvTinhnang).BeginInit();
			this.groupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lvBuyLic).BeginInit();
			this.groupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lvHistory).BeginInit();
			this.statusStrip1.SuspendLayout();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.btnMua24h);
			this.groupBox1.Controls.Add(this.btnNapThe);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.lvTinhnang);
			this.groupBox1.Controls.Add(this.lbGGKM);
			this.groupBox1.Controls.Add(this.lbGGNap);
			this.groupBox1.Controls.Add(this.lbHandung);
			this.groupBox1.Controls.Add(this.lbUsername);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.groupBox1.Margin = new global::System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new global::System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new global::System.Drawing.Size(353, 186);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tài khoản + tính năng";
			this.groupBox1.Enter += new global::System.EventHandler(this.groupBox1_Enter);
			this.btnMua24h.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnMua24h.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.btnMua24h.Location = new global::System.Drawing.Point(212, 60);
			this.btnMua24h.Name = "btnMua24h";
			this.btnMua24h.Size = new global::System.Drawing.Size(63, 20);
			this.btnMua24h.TabIndex = 80;
			this.btnMua24h.Text = "&Mua 24h";
			this.btnMua24h.UseVisualStyleBackColor = false;
			this.btnNapThe.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnNapThe.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.btnNapThe.Location = new global::System.Drawing.Point(280, 60);
			this.btnNapThe.Name = "btnNapThe";
			this.btnNapThe.Size = new global::System.Drawing.Size(63, 20);
			this.btnNapThe.TabIndex = 79;
			this.btnNapThe.Text = "&Nạp thẻ";
			this.btnNapThe.UseVisualStyleBackColor = false;
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(6, 63);
			this.label5.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(100, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Tính năng đang có";
			this.lvTinhnang.AllColumns.Add(this.olvcolumn_0);
			this.lvTinhnang.AllColumns.Add(this.olvcolumn_1);
			this.lvTinhnang.AllColumns.Add(this.olvcolumn_2);
			this.lvTinhnang.AllColumns.Add(this.olvcolumn_3);
			this.lvTinhnang.AllColumns.Add(this.olvcolumn_4);
			this.lvTinhnang.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			this.lvTinhnang.CellEditUseWholeCell = false;
			this.lvTinhnang.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.olvcolumn_0,
				this.olvcolumn_1,
				this.olvcolumn_2,
				this.olvcolumn_3,
				this.olvcolumn_4
			});
			this.lvTinhnang.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.lvTinhnang.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lvTinhnang.ForeColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.lvTinhnang.FullRowSelect = true;
			this.lvTinhnang.Location = new global::System.Drawing.Point(2, 80);
			this.lvTinhnang.Margin = new global::System.Windows.Forms.Padding(2);
			this.lvTinhnang.Name = "lvTinhnang";
			this.lvTinhnang.Size = new global::System.Drawing.Size(349, 104);
			this.lvTinhnang.TabIndex = 8;
			this.lvTinhnang.UseCompatibleStateImageBehavior = false;
			this.lvTinhnang.View = global::System.Windows.Forms.View.Details;
			this.olvcolumn_0.AspectName = "Index";
			this.olvcolumn_0.Groupable = false;
			this.olvcolumn_0.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_0.Hideable = false;
			this.olvcolumn_0.IsEditable = false;
			this.olvcolumn_0.Sortable = false;
			this.olvcolumn_0.Text = "#";
			this.olvcolumn_0.Width = 25;
			this.olvcolumn_1.AspectName = "Tinhnang";
			this.olvcolumn_1.Groupable = false;
			this.olvcolumn_1.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_1.Hideable = false;
			this.olvcolumn_1.IsEditable = false;
			this.olvcolumn_1.Sortable = false;
			this.olvcolumn_1.Text = "Tính năng";
			this.olvcolumn_1.Width = 65;
			this.olvcolumn_2.AspectName = "Remain";
			this.olvcolumn_2.Groupable = false;
			this.olvcolumn_2.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_2.Hideable = false;
			this.olvcolumn_2.IsEditable = false;
			this.olvcolumn_2.Sortable = false;
			this.olvcolumn_2.Text = "Sử dụng";
			this.olvcolumn_3.AspectName = "Comment";
			this.olvcolumn_3.FillsFreeSpace = true;
			this.olvcolumn_3.Groupable = false;
			this.olvcolumn_3.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_3.Hideable = false;
			this.olvcolumn_3.IsEditable = false;
			this.olvcolumn_3.Sortable = false;
			this.olvcolumn_3.Text = "Ghi chú";
			this.olvcolumn_3.Width = 120;
			this.olvcolumn_4.Groupable = false;
			this.olvcolumn_4.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_4.Hideable = false;
			this.olvcolumn_4.IsEditable = false;
			this.olvcolumn_4.Sortable = false;
			this.olvcolumn_4.Text = "";
			this.olvcolumn_4.Width = 40;
			this.lbGGKM.AutoSize = true;
			this.lbGGKM.Location = new global::System.Drawing.Point(240, 40);
			this.lbGGKM.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbGGKM.Name = "lbGGKM";
			this.lbGGKM.Size = new global::System.Drawing.Size(25, 13);
			this.lbGGKM.TabIndex = 7;
			this.lbGGKM.Text = "___";
			this.lbGGNap.AutoSize = true;
			this.lbGGNap.Location = new global::System.Drawing.Point(59, 40);
			this.lbGGNap.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbGGNap.Name = "lbGGNap";
			this.lbGGNap.Size = new global::System.Drawing.Size(25, 13);
			this.lbGGNap.TabIndex = 6;
			this.lbGGNap.Text = "___";
			this.lbHandung.AutoSize = true;
			this.lbHandung.Location = new global::System.Drawing.Point(215, 20);
			this.lbHandung.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbHandung.Name = "lbHandung";
			this.lbHandung.Size = new global::System.Drawing.Size(25, 13);
			this.lbHandung.TabIndex = 5;
			this.lbHandung.Text = "___";
			this.lbUsername.AutoSize = true;
			this.lbUsername.Location = new global::System.Drawing.Point(59, 20);
			this.lbUsername.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbUsername.Name = "lbUsername";
			this.lbUsername.Size = new global::System.Drawing.Size(25, 13);
			this.lbUsername.TabIndex = 4;
			this.lbUsername.Text = "___";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(162, 40);
			this.label4.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(80, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "GG khuyến mãi";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(6, 40);
			this.label3.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(44, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "GG nạp";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(162, 20);
			this.label2.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(54, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Hạn dùng";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(6, 20);
			this.label1.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(55, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tài khoản";
			this.groupBox2.Controls.Add(this.lblTotalPrice);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.btnMuaNgay);
			this.groupBox2.Controls.Add(this.lvBuyLic);
			this.groupBox2.Controls.Add(this.cboBuyTrader);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.cboBuyYTO);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.cboBuyChedo);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.cboBuyTime);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.groupBox2.Location = new global::System.Drawing.Point(0, 186);
			this.groupBox2.Margin = new global::System.Windows.Forms.Padding(2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new global::System.Windows.Forms.Padding(2);
			this.groupBox2.Size = new global::System.Drawing.Size(353, 205);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Mua giờ + tính năng";
			this.groupBox2.Enter += new global::System.EventHandler(this.groupBox2_Enter);
			this.lblTotalPrice.AutoSize = true;
			this.lblTotalPrice.Location = new global::System.Drawing.Point(59, 73);
			this.lblTotalPrice.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTotalPrice.Name = "lblTotalPrice";
			this.lblTotalPrice.Size = new global::System.Drawing.Size(25, 13);
			this.lblTotalPrice.TabIndex = 76;
			this.lblTotalPrice.Text = "___";
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(6, 73);
			this.label10.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(52, 13);
			this.label10.TabIndex = 75;
			this.label10.Text = "Tổng giá:";
			this.btnMuaNgay.BackColor = global::System.Drawing.Color.FromArgb(255, 224, 192);
			this.btnMuaNgay.ForeColor = global::System.Drawing.Color.Black;
			this.btnMuaNgay.Location = new global::System.Drawing.Point(220, 69);
			this.btnMuaNgay.Name = "btnMuaNgay";
			this.btnMuaNgay.Size = new global::System.Drawing.Size(120, 20);
			this.btnMuaNgay.TabIndex = 74;
			this.btnMuaNgay.Text = "&Thanh toán đơn hàng";
			this.btnMuaNgay.UseVisualStyleBackColor = false;
			this.lvBuyLic.AllColumns.Add(this.olvcolumn_5);
			this.lvBuyLic.AllColumns.Add(this.olvcolumn_6);
			this.lvBuyLic.AllColumns.Add(this.olvcolumn_7);
			this.lvBuyLic.AllColumns.Add(this.olvcolumn_8);
			this.lvBuyLic.AllColumns.Add(this.olvcolumn_15);
			this.lvBuyLic.AllColumns.Add(this.olvcolumn_9);
			this.lvBuyLic.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			this.lvBuyLic.CellEditUseWholeCell = false;
			this.lvBuyLic.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.olvcolumn_5,
				this.olvcolumn_6,
				this.olvcolumn_7,
				this.olvcolumn_8,
				this.olvcolumn_15,
				this.olvcolumn_9
			});
			this.lvBuyLic.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.lvBuyLic.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lvBuyLic.ForeColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.lvBuyLic.FullRowSelect = true;
			this.lvBuyLic.Location = new global::System.Drawing.Point(2, 92);
			this.lvBuyLic.Margin = new global::System.Windows.Forms.Padding(2);
			this.lvBuyLic.Name = "lvBuyLic";
			this.lvBuyLic.Size = new global::System.Drawing.Size(349, 111);
			this.lvBuyLic.TabIndex = 9;
			this.lvBuyLic.UseCompatibleStateImageBehavior = false;
			this.lvBuyLic.View = global::System.Windows.Forms.View.Details;
			this.olvcolumn_5.AspectName = "Index";
			this.olvcolumn_5.Groupable = false;
			this.olvcolumn_5.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_5.Hideable = false;
			this.olvcolumn_5.IsEditable = false;
			this.olvcolumn_5.Sortable = false;
			this.olvcolumn_5.Text = "#";
			this.olvcolumn_5.Width = 25;
			this.olvcolumn_6.AspectName = "Desc";
			this.olvcolumn_6.Groupable = false;
			this.olvcolumn_6.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_6.Hideable = false;
			this.olvcolumn_6.IsEditable = false;
			this.olvcolumn_6.Sortable = false;
			this.olvcolumn_6.Text = "Món hàng";
			this.olvcolumn_6.Width = 100;
			this.olvcolumn_7.AspectName = "Comment";
			this.olvcolumn_7.FillsFreeSpace = true;
			this.olvcolumn_7.Groupable = false;
			this.olvcolumn_7.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_7.Hideable = false;
			this.olvcolumn_7.IsEditable = false;
			this.olvcolumn_7.Sortable = false;
			this.olvcolumn_7.Text = "Ghi chú";
			this.olvcolumn_8.AspectName = "Price";
			this.olvcolumn_8.Groupable = false;
			this.olvcolumn_8.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_8.Hideable = false;
			this.olvcolumn_8.IsEditable = false;
			this.olvcolumn_8.Sortable = false;
			this.olvcolumn_8.Text = "Giá";
			this.olvcolumn_8.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.olvcolumn_8.Width = 40;
			this.olvcolumn_15.AspectName = "SlotID";
			this.olvcolumn_15.Text = "Slot ID";
			this.olvcolumn_9.AspectName = "";
			this.olvcolumn_9.Groupable = false;
			this.olvcolumn_9.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_9.Hideable = false;
			this.olvcolumn_9.IsEditable = false;
			this.olvcolumn_9.Sortable = false;
			this.olvcolumn_9.Text = "X";
			this.olvcolumn_9.Width = 24;
			this.cboBuyTrader.DropDownWidth = 250;
			this.cboBuyTrader.FormattingEnabled = true;
			this.cboBuyTrader.Location = new global::System.Drawing.Point(233, 46);
			this.cboBuyTrader.Margin = new global::System.Windows.Forms.Padding(2);
			this.cboBuyTrader.Name = "cboBuyTrader";
			this.cboBuyTrader.Size = new global::System.Drawing.Size(109, 21);
			this.cboBuyTrader.TabIndex = 8;
			this.cboBuyTrader.SelectedIndexChanged += new global::System.EventHandler(this.cboBuyTrader_SelectedIndexChanged);
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(164, 48);
			this.label8.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(71, 13);
			this.label8.TabIndex = 7;
			this.label8.Text = "Thương nhân";
			this.cboBuyYTO.DropDownWidth = 250;
			this.cboBuyYTO.FormattingEnabled = true;
			this.cboBuyYTO.Location = new global::System.Drawing.Point(52, 46);
			this.cboBuyYTO.Margin = new global::System.Windows.Forms.Padding(2);
			this.cboBuyYTO.Name = "cboBuyYTO";
			this.cboBuyYTO.Size = new global::System.Drawing.Size(109, 21);
			this.cboBuyYTO.TabIndex = 6;
			this.cboBuyYTO.DropDown += new global::System.EventHandler(this.cboBuyYTO_DropDown);
			this.cboBuyYTO.SelectedIndexChanged += new global::System.EventHandler(this.cboBuyYTO_SelectedIndexChanged);
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(6, 48);
			this.label9.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(29, 13);
			this.label9.TabIndex = 5;
			this.label9.Text = "YTO";
			this.cboBuyChedo.DropDownWidth = 250;
			this.cboBuyChedo.FormattingEnabled = true;
			this.cboBuyChedo.Location = new global::System.Drawing.Point(233, 26);
			this.cboBuyChedo.Margin = new global::System.Windows.Forms.Padding(2);
			this.cboBuyChedo.Name = "cboBuyChedo";
			this.cboBuyChedo.Size = new global::System.Drawing.Size(109, 21);
			this.cboBuyChedo.TabIndex = 4;
			this.cboBuyChedo.DropDown += new global::System.EventHandler(this.cboBuyChedo_DropDown);
			this.cboBuyChedo.SelectedIndexChanged += new global::System.EventHandler(this.cboBuyChedo_SelectedIndexChanged);
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(164, 27);
			this.label7.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(42, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "Chế đồ";
			this.label7.Click += new global::System.EventHandler(this.label7_Click);
			this.cboBuyTime.DropDownWidth = 250;
			this.cboBuyTime.FormattingEnabled = true;
			this.cboBuyTime.Location = new global::System.Drawing.Point(52, 26);
			this.cboBuyTime.Margin = new global::System.Windows.Forms.Padding(2);
			this.cboBuyTime.Name = "cboBuyTime";
			this.cboBuyTime.Size = new global::System.Drawing.Size(109, 21);
			this.cboBuyTime.TabIndex = 2;
			this.cboBuyTime.DropDown += new global::System.EventHandler(this.cboBuyTime_DropDown);
			this.cboBuyTime.SelectedIndexChanged += new global::System.EventHandler(this.cboBuyTime_SelectedIndexChanged);
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(6, 27);
			this.label6.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(46, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "Giờ chơi";
			this.label6.Click += new global::System.EventHandler(this.label6_Click);
			this.groupBox3.Controls.Add(this.btnRefresh);
			this.groupBox3.Controls.Add(this.lvHistory);
			this.groupBox3.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new global::System.Drawing.Point(0, 391);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new global::System.Windows.Forms.Padding(2);
			this.groupBox3.Size = new global::System.Drawing.Size(353, 130);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Lịch sử hoạt động 10 ngày";
			this.btnRefresh.BackColor = global::System.Drawing.Color.White;
			this.btnRefresh.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnRefresh.ForeColor = global::System.Drawing.Color.White;
			this.btnRefresh.Image = global::ns0.Class212.refresh;
			this.btnRefresh.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.btnRefresh.Location = new global::System.Drawing.Point(312, -1);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new global::System.Drawing.Size(24, 20);
			this.btnRefresh.TabIndex = 70;
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.btnRefresh.Click += new global::System.EventHandler(this.btnRefresh_Click);
			this.lvHistory.AllColumns.Add(this.olvcolumn_10);
			this.lvHistory.AllColumns.Add(this.olvcolumn_11);
			this.lvHistory.AllColumns.Add(this.olvcolumn_12);
			this.lvHistory.AllColumns.Add(this.olvcolumn_13);
			this.lvHistory.AllColumns.Add(this.olvcolumn_14);
			this.lvHistory.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			this.lvHistory.CellEditUseWholeCell = false;
			this.lvHistory.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.olvcolumn_10,
				this.olvcolumn_11,
				this.olvcolumn_12,
				this.olvcolumn_13,
				this.olvcolumn_14
			});
			this.lvHistory.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.lvHistory.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lvHistory.ForeColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.lvHistory.FullRowSelect = true;
			this.lvHistory.Location = new global::System.Drawing.Point(2, 33);
			this.lvHistory.Margin = new global::System.Windows.Forms.Padding(2);
			this.lvHistory.Name = "lvHistory";
			this.lvHistory.Size = new global::System.Drawing.Size(349, 95);
			this.lvHistory.TabIndex = 10;
			this.lvHistory.UseCompatibleStateImageBehavior = false;
			this.lvHistory.View = global::System.Windows.Forms.View.Details;
			this.olvcolumn_10.AspectName = "Index";
			this.olvcolumn_10.Groupable = false;
			this.olvcolumn_10.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_10.Hideable = false;
			this.olvcolumn_10.IsEditable = false;
			this.olvcolumn_10.Sortable = false;
			this.olvcolumn_10.Text = "#";
			this.olvcolumn_10.Width = 25;
			this.olvcolumn_11.AspectName = "ActDate";
			this.olvcolumn_11.Groupable = false;
			this.olvcolumn_11.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_11.Hideable = false;
			this.olvcolumn_11.IsEditable = false;
			this.olvcolumn_11.Sortable = false;
			this.olvcolumn_11.Text = "Thời gian";
			this.olvcolumn_11.Width = 110;
			this.olvcolumn_12.AspectName = "Comment";
			this.olvcolumn_12.FillsFreeSpace = true;
			this.olvcolumn_12.Groupable = false;
			this.olvcolumn_12.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_12.Hideable = false;
			this.olvcolumn_12.IsEditable = false;
			this.olvcolumn_12.Sortable = false;
			this.olvcolumn_12.Text = "Hoạt động";
			this.olvcolumn_12.Width = 90;
			this.olvcolumn_13.AspectName = "Cost";
			this.olvcolumn_13.Groupable = false;
			this.olvcolumn_13.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_13.Hideable = false;
			this.olvcolumn_13.IsEditable = false;
			this.olvcolumn_13.Sortable = false;
			this.olvcolumn_13.Text = "Tốn";
			this.olvcolumn_13.Width = 40;
			this.olvcolumn_14.AspectName = "Balance";
			this.olvcolumn_14.Groupable = false;
			this.olvcolumn_14.HeaderCheckBoxUpdatesRowCheckBoxes = false;
			this.olvcolumn_14.Hideable = false;
			this.olvcolumn_14.IsEditable = false;
			this.olvcolumn_14.Sortable = false;
			this.olvcolumn_14.Text = "Còn";
			this.statusStrip1.ImageScalingSize = new global::System.Drawing.Size(32, 32);
			this.statusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.status1
			});
			this.statusStrip1.Location = new global::System.Drawing.Point(0, 521);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new global::System.Windows.Forms.Padding(0, 0, 7, 0);
			this.statusStrip1.Size = new global::System.Drawing.Size(353, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			this.status1.Name = "status1";
			this.status1.Size = new global::System.Drawing.Size(61, 17);
			this.status1.Text = "Trạng thái";
			this.backgroundWorker_0.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_0_DoWork);
			this.backgroundWorker_0.RunWorkerCompleted += new global::System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_0_RunWorkerCompleted);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(96f, 96f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Dpi;
			base.ClientSize = new global::System.Drawing.Size(353, 543);
			base.Controls.Add(this.groupBox3);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.groupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Margin = new global::System.Windows.Forms.Padding(2);
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(359, 567);
			this.MinimumSize = new global::System.Drawing.Size(359, 567);
			base.Name = "frmNewUserInfo";
			this.Text = "Thông tin tài khoản";
			base.Load += new global::System.EventHandler(this.frmNewUserInfo_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lvTinhnang).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lvBuyLic).EndInit();
			this.groupBox3.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.lvHistory).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000C4E RID: 3150
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000C4F RID: 3151
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000C50 RID: 3152
		private global::System.Windows.Forms.Label lbGGKM;

		// Token: 0x04000C51 RID: 3153
		private global::System.Windows.Forms.Label lbGGNap;

		// Token: 0x04000C52 RID: 3154
		private global::System.Windows.Forms.Label lbHandung;

		// Token: 0x04000C53 RID: 3155
		private global::System.Windows.Forms.Label lbUsername;

		// Token: 0x04000C54 RID: 3156
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000C55 RID: 3157
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000C56 RID: 3158
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000C57 RID: 3159
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000C58 RID: 3160
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000C59 RID: 3161
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x04000C5A RID: 3162
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000C5B RID: 3163
		private global::BrightIdeasSoftware.ObjectListView lvTinhnang;

		// Token: 0x04000C5C RID: 3164
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_0;

		// Token: 0x04000C5D RID: 3165
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_1;

		// Token: 0x04000C5E RID: 3166
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_2;

		// Token: 0x04000C5F RID: 3167
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_3;

		// Token: 0x04000C60 RID: 3168
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_4;

		// Token: 0x04000C61 RID: 3169
		private global::System.Windows.Forms.ComboBox cboBuyChedo;

		// Token: 0x04000C62 RID: 3170
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000C63 RID: 3171
		private global::System.Windows.Forms.ComboBox cboBuyTime;

		// Token: 0x04000C64 RID: 3172
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000C65 RID: 3173
		private global::System.Windows.Forms.Button btnNapThe;

		// Token: 0x04000C66 RID: 3174
		private global::System.Windows.Forms.Button btnMua24h;

		// Token: 0x04000C67 RID: 3175
		private global::System.Windows.Forms.ComboBox cboBuyTrader;

		// Token: 0x04000C68 RID: 3176
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000C69 RID: 3177
		private global::System.Windows.Forms.ComboBox cboBuyYTO;

		// Token: 0x04000C6A RID: 3178
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000C6B RID: 3179
		private global::BrightIdeasSoftware.ObjectListView lvBuyLic;

		// Token: 0x04000C6C RID: 3180
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_5;

		// Token: 0x04000C6D RID: 3181
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_6;

		// Token: 0x04000C6E RID: 3182
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_7;

		// Token: 0x04000C6F RID: 3183
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_8;

		// Token: 0x04000C70 RID: 3184
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_9;

		// Token: 0x04000C71 RID: 3185
		private global::System.Windows.Forms.StatusStrip statusStrip1;

		// Token: 0x04000C72 RID: 3186
		private global::System.Windows.Forms.ToolStripStatusLabel status1;

		// Token: 0x04000C73 RID: 3187
		private global::BrightIdeasSoftware.ObjectListView lvHistory;

		// Token: 0x04000C74 RID: 3188
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_10;

		// Token: 0x04000C75 RID: 3189
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_11;

		// Token: 0x04000C76 RID: 3190
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_12;

		// Token: 0x04000C77 RID: 3191
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_13;

		// Token: 0x04000C78 RID: 3192
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_14;

		// Token: 0x04000C79 RID: 3193
		private global::System.Windows.Forms.Button btnMuaNgay;

		// Token: 0x04000C7A RID: 3194
		private global::System.Windows.Forms.Button btnRefresh;

		// Token: 0x04000C7B RID: 3195
		private global::System.ComponentModel.BackgroundWorker backgroundWorker_0;

		// Token: 0x04000C7C RID: 3196
		private global::System.Windows.Forms.Label lblTotalPrice;

		// Token: 0x04000C7D RID: 3197
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000C7E RID: 3198
		private global::BrightIdeasSoftware.OLVColumn olvcolumn_15;
	}
}
