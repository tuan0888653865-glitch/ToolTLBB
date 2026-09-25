namespace ns0
{
	// Token: 0x0200010D RID: 269
	internal sealed partial class frmAutoPK : global::System.Windows.Forms.Form
	{
		// Token: 0x06000AFF RID: 2815 RVA: 0x0000AD58 File Offset: 0x00008F58
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x000D3CF8 File Offset: 0x000D1EF8
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmAutoPK));
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.PKEnable = new global::System.Windows.Forms.CheckBox();
			this.PKBangList = new global::System.Windows.Forms.CheckBox();
			this.PKPlayerList = new global::System.Windows.Forms.CheckBox();
			this.PKAnyOne = new global::System.Windows.Forms.CheckBox();
			this.PKNgaMyFirst = new global::System.Windows.Forms.CheckBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.groupIDBang = new global::System.Windows.Forms.GroupBox();
			this.lvIDBang = new global::System.Windows.Forms.ListView();
			this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
			this.txtIDBang = new global::System.Windows.Forms.TextBox();
			this.btnBangExpand = new global::System.Windows.Forms.Button();
			this.btnIDBangAdd = new global::System.Windows.Forms.Button();
			this.groupPlayers = new global::System.Windows.Forms.GroupBox();
			this.btnAddPlayerList = new global::System.Windows.Forms.Button();
			this.txtPlayerName = new global::System.Windows.Forms.TextBox();
			this.btnGroupPlayerExpand = new global::System.Windows.Forms.Button();
			this.lvPlayers = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.btnAddPlayer = new global::System.Windows.Forms.Button();
			this.btnPKHotKey = new global::System.Windows.Forms.Button();
			this.groupBlackList = new global::System.Windows.Forms.GroupBox();
			this.btnBlacklist = new global::System.Windows.Forms.Button();
			this.txtBlacklistName = new global::System.Windows.Forms.TextBox();
			this.btnGroupBlacklistExpand = new global::System.Windows.Forms.Button();
			this.lvBlacklist = new global::System.Windows.Forms.ListView();
			this.columnHeader_2 = new global::System.Windows.Forms.ColumnHeader();
			this.btnBlacklistAdd = new global::System.Windows.Forms.Button();
			this.cboxBlacklist = new global::System.Windows.Forms.CheckBox();
			this.PKThieuLamLast = new global::System.Windows.Forms.CheckBox();
			this.groupIDBang.SuspendLayout();
			this.groupPlayers.SuspendLayout();
			this.groupBlackList.SuspendLayout();
			base.SuspendLayout();
			this.timer_0.Enabled = true;
			this.timer_0.Interval = 250;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			componentResourceManager.ApplyResources(this.PKEnable, "PKEnable");
			this.PKEnable.Name = "PKEnable";
			this.PKEnable.UseVisualStyleBackColor = true;
			this.PKEnable.CheckedChanged += new global::System.EventHandler(this.PKEnable_CheckedChanged);
			componentResourceManager.ApplyResources(this.PKBangList, "PKBangList");
			this.PKBangList.Name = "PKBangList";
			this.PKBangList.UseVisualStyleBackColor = true;
			this.PKBangList.CheckedChanged += new global::System.EventHandler(this.PKBangList_CheckedChanged);
			componentResourceManager.ApplyResources(this.PKPlayerList, "PKPlayerList");
			this.PKPlayerList.Name = "PKPlayerList";
			this.PKPlayerList.UseVisualStyleBackColor = true;
			this.PKPlayerList.CheckedChanged += new global::System.EventHandler(this.PKPlayerList_CheckedChanged);
			componentResourceManager.ApplyResources(this.PKAnyOne, "PKAnyOne");
			this.PKAnyOne.Name = "PKAnyOne";
			this.PKAnyOne.UseVisualStyleBackColor = true;
			this.PKAnyOne.CheckedChanged += new global::System.EventHandler(this.PKAnyOne_CheckedChanged);
			componentResourceManager.ApplyResources(this.PKNgaMyFirst, "PKNgaMyFirst");
			this.PKNgaMyFirst.Name = "PKNgaMyFirst";
			this.PKNgaMyFirst.UseVisualStyleBackColor = true;
			this.PKNgaMyFirst.CheckedChanged += new global::System.EventHandler(this.PKNgaMyFirst_CheckedChanged);
			componentResourceManager.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
			componentResourceManager.ApplyResources(this.groupIDBang, "groupIDBang");
			this.groupIDBang.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.groupIDBang.Controls.Add(this.lvIDBang);
			this.groupIDBang.Controls.Add(this.txtIDBang);
			this.groupIDBang.Controls.Add(this.btnBangExpand);
			this.groupIDBang.Controls.Add(this.btnIDBangAdd);
			this.groupIDBang.Name = "groupIDBang";
			this.groupIDBang.TabStop = false;
			componentResourceManager.ApplyResources(this.lvIDBang, "lvIDBang");
			this.lvIDBang.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvIDBang.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_1
			});
			this.lvIDBang.FullRowSelect = true;
			this.lvIDBang.GridLines = true;
			this.lvIDBang.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvIDBang.Name = "lvIDBang";
			this.lvIDBang.UseCompatibleStateImageBehavior = false;
			this.lvIDBang.View = global::System.Windows.Forms.View.Details;
			this.lvIDBang.DoubleClick += new global::System.EventHandler(this.lvIDBang_DoubleClick);
			componentResourceManager.ApplyResources(this.columnHeader_1, "columnHeader2");
			componentResourceManager.ApplyResources(this.txtIDBang, "txtIDBang");
			this.txtIDBang.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.txtIDBang.Name = "txtIDBang";
			componentResourceManager.ApplyResources(this.btnBangExpand, "btnBangExpand");
			this.btnBangExpand.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnBangExpand.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnBangExpand.Name = "btnBangExpand";
			this.btnBangExpand.UseVisualStyleBackColor = false;
			this.btnBangExpand.Click += new global::System.EventHandler(this.btnBangExpand_Click);
			componentResourceManager.ApplyResources(this.btnIDBangAdd, "btnIDBangAdd");
			this.btnIDBangAdd.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnIDBangAdd.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.btnIDBangAdd.Name = "btnIDBangAdd";
			this.btnIDBangAdd.UseVisualStyleBackColor = false;
			this.btnIDBangAdd.Click += new global::System.EventHandler(this.btnIDBangAdd_Click);
			componentResourceManager.ApplyResources(this.groupPlayers, "groupPlayers");
			this.groupPlayers.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.groupPlayers.Controls.Add(this.btnAddPlayerList);
			this.groupPlayers.Controls.Add(this.txtPlayerName);
			this.groupPlayers.Controls.Add(this.btnGroupPlayerExpand);
			this.groupPlayers.Controls.Add(this.lvPlayers);
			this.groupPlayers.Controls.Add(this.btnAddPlayer);
			this.groupPlayers.Name = "groupPlayers";
			this.groupPlayers.TabStop = false;
			componentResourceManager.ApplyResources(this.btnAddPlayerList, "btnAddPlayerList");
			this.btnAddPlayerList.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnAddPlayerList.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnAddPlayerList.Name = "btnAddPlayerList";
			this.btnAddPlayerList.UseVisualStyleBackColor = false;
			this.btnAddPlayerList.Click += new global::System.EventHandler(this.btnAddPlayerList_Click);
			componentResourceManager.ApplyResources(this.txtPlayerName, "txtPlayerName");
			this.txtPlayerName.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.txtPlayerName.Name = "txtPlayerName";
			componentResourceManager.ApplyResources(this.btnGroupPlayerExpand, "btnGroupPlayerExpand");
			this.btnGroupPlayerExpand.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnGroupPlayerExpand.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnGroupPlayerExpand.Name = "btnGroupPlayerExpand";
			this.btnGroupPlayerExpand.UseVisualStyleBackColor = false;
			this.btnGroupPlayerExpand.Click += new global::System.EventHandler(this.btnGroupPlayerExpand_Click);
			componentResourceManager.ApplyResources(this.lvPlayers, "lvPlayers");
			this.lvPlayers.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvPlayers.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0
			});
			this.lvPlayers.FullRowSelect = true;
			this.lvPlayers.GridLines = true;
			this.lvPlayers.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvPlayers.Name = "lvPlayers";
			this.lvPlayers.UseCompatibleStateImageBehavior = false;
			this.lvPlayers.View = global::System.Windows.Forms.View.Details;
			this.lvPlayers.DoubleClick += new global::System.EventHandler(this.lvPlayers_DoubleClick);
			componentResourceManager.ApplyResources(this.columnHeader_0, "columnHeader1");
			componentResourceManager.ApplyResources(this.btnAddPlayer, "btnAddPlayer");
			this.btnAddPlayer.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnAddPlayer.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.btnAddPlayer.Name = "btnAddPlayer";
			this.btnAddPlayer.UseVisualStyleBackColor = false;
			this.btnAddPlayer.Click += new global::System.EventHandler(this.btnAddPlayer_Click);
			componentResourceManager.ApplyResources(this.btnPKHotKey, "btnPKHotKey");
			this.btnPKHotKey.BackColor = global::System.Drawing.Color.FromArgb(247, 207, 142);
			this.btnPKHotKey.ForeColor = global::System.Drawing.Color.Black;
			this.btnPKHotKey.Name = "btnPKHotKey";
			this.btnPKHotKey.UseVisualStyleBackColor = false;
			this.btnPKHotKey.Click += new global::System.EventHandler(this.btnPKHotKey_Click);
			componentResourceManager.ApplyResources(this.groupBlackList, "groupBlackList");
			this.groupBlackList.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.groupBlackList.Controls.Add(this.btnBlacklist);
			this.groupBlackList.Controls.Add(this.txtBlacklistName);
			this.groupBlackList.Controls.Add(this.btnGroupBlacklistExpand);
			this.groupBlackList.Controls.Add(this.lvBlacklist);
			this.groupBlackList.Controls.Add(this.btnBlacklistAdd);
			this.groupBlackList.Name = "groupBlackList";
			this.groupBlackList.TabStop = false;
			componentResourceManager.ApplyResources(this.btnBlacklist, "btnBlacklist");
			this.btnBlacklist.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnBlacklist.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnBlacklist.Name = "btnBlacklist";
			this.btnBlacklist.UseVisualStyleBackColor = false;
			this.btnBlacklist.Click += new global::System.EventHandler(this.btnBlacklist_Click);
			componentResourceManager.ApplyResources(this.txtBlacklistName, "txtBlacklistName");
			this.txtBlacklistName.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.txtBlacklistName.Name = "txtBlacklistName";
			componentResourceManager.ApplyResources(this.btnGroupBlacklistExpand, "btnGroupBlacklistExpand");
			this.btnGroupBlacklistExpand.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnGroupBlacklistExpand.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnGroupBlacklistExpand.Name = "btnGroupBlacklistExpand";
			this.btnGroupBlacklistExpand.UseVisualStyleBackColor = false;
			this.btnGroupBlacklistExpand.Click += new global::System.EventHandler(this.btnGroupBlacklistExpand_Click);
			componentResourceManager.ApplyResources(this.lvBlacklist, "lvBlacklist");
			this.lvBlacklist.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvBlacklist.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_2
			});
			this.lvBlacklist.FullRowSelect = true;
			this.lvBlacklist.GridLines = true;
			this.lvBlacklist.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvBlacklist.Name = "lvBlacklist";
			this.lvBlacklist.UseCompatibleStateImageBehavior = false;
			this.lvBlacklist.View = global::System.Windows.Forms.View.Details;
			this.lvBlacklist.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.lvBlacklist_MouseDoubleClick);
			componentResourceManager.ApplyResources(this.columnHeader_2, "columnHeader3");
			componentResourceManager.ApplyResources(this.btnBlacklistAdd, "btnBlacklistAdd");
			this.btnBlacklistAdd.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnBlacklistAdd.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.btnBlacklistAdd.Name = "btnBlacklistAdd";
			this.btnBlacklistAdd.UseVisualStyleBackColor = false;
			this.btnBlacklistAdd.Click += new global::System.EventHandler(this.btnBlacklistAdd_Click);
			componentResourceManager.ApplyResources(this.cboxBlacklist, "cboxBlacklist");
			this.cboxBlacklist.Name = "cboxBlacklist";
			this.cboxBlacklist.UseVisualStyleBackColor = true;
			this.cboxBlacklist.CheckedChanged += new global::System.EventHandler(this.cboxBlacklist_CheckedChanged);
			componentResourceManager.ApplyResources(this.PKThieuLamLast, "PKThieuLamLast");
			this.PKThieuLamLast.Name = "PKThieuLamLast";
			this.PKThieuLamLast.UseVisualStyleBackColor = true;
			this.PKThieuLamLast.CheckedChanged += new global::System.EventHandler(this.PKThieuLamLast_CheckedChanged);
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.PKThieuLamLast);
			base.Controls.Add(this.cboxBlacklist);
			base.Controls.Add(this.btnPKHotKey);
			base.Controls.Add(this.groupIDBang);
			base.Controls.Add(this.groupPlayers);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.PKNgaMyFirst);
			base.Controls.Add(this.PKAnyOne);
			base.Controls.Add(this.PKPlayerList);
			base.Controls.Add(this.PKBangList);
			base.Controls.Add(this.PKEnable);
			base.Controls.Add(this.groupBlackList);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.Name = "frmAutoPK";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmAutoPK_FormClosing);
			base.Load += new global::System.EventHandler(this.frmAutoPK_Load);
			base.Shown += new global::System.EventHandler(this.frmAutoPK_Shown);
			this.groupIDBang.ResumeLayout(false);
			this.groupIDBang.PerformLayout();
			this.groupPlayers.ResumeLayout(false);
			this.groupPlayers.PerformLayout();
			this.groupBlackList.ResumeLayout(false);
			this.groupBlackList.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000F6C RID: 3948
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000F6D RID: 3949
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000F6E RID: 3950
		private global::System.Windows.Forms.CheckBox PKEnable;

		// Token: 0x04000F6F RID: 3951
		private global::System.Windows.Forms.CheckBox PKBangList;

		// Token: 0x04000F70 RID: 3952
		private global::System.Windows.Forms.CheckBox PKPlayerList;

		// Token: 0x04000F71 RID: 3953
		private global::System.Windows.Forms.CheckBox PKAnyOne;

		// Token: 0x04000F72 RID: 3954
		private global::System.Windows.Forms.CheckBox PKNgaMyFirst;

		// Token: 0x04000F73 RID: 3955
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000F74 RID: 3956
		private global::System.Windows.Forms.GroupBox groupIDBang;

		// Token: 0x04000F75 RID: 3957
		private global::System.Windows.Forms.Button btnBangExpand;

		// Token: 0x04000F76 RID: 3958
		private global::System.Windows.Forms.Button btnIDBangAdd;

		// Token: 0x04000F77 RID: 3959
		private global::System.Windows.Forms.GroupBox groupPlayers;

		// Token: 0x04000F78 RID: 3960
		private global::System.Windows.Forms.Button btnGroupPlayerExpand;

		// Token: 0x04000F79 RID: 3961
		private global::System.Windows.Forms.ListView lvPlayers;

		// Token: 0x04000F7A RID: 3962
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x04000F7B RID: 3963
		private global::System.Windows.Forms.Button btnAddPlayer;

		// Token: 0x04000F7C RID: 3964
		private global::System.Windows.Forms.TextBox txtPlayerName;

		// Token: 0x04000F7D RID: 3965
		private global::System.Windows.Forms.Button btnAddPlayerList;

		// Token: 0x04000F7E RID: 3966
		private global::System.Windows.Forms.ListView lvIDBang;

		// Token: 0x04000F7F RID: 3967
		private global::System.Windows.Forms.ColumnHeader columnHeader_1;

		// Token: 0x04000F80 RID: 3968
		private global::System.Windows.Forms.TextBox txtIDBang;

		// Token: 0x04000F81 RID: 3969
		private global::System.Windows.Forms.Button btnPKHotKey;

		// Token: 0x04000F82 RID: 3970
		private global::System.Windows.Forms.GroupBox groupBlackList;

		// Token: 0x04000F83 RID: 3971
		private global::System.Windows.Forms.Button btnBlacklist;

		// Token: 0x04000F84 RID: 3972
		private global::System.Windows.Forms.TextBox txtBlacklistName;

		// Token: 0x04000F85 RID: 3973
		private global::System.Windows.Forms.Button btnGroupBlacklistExpand;

		// Token: 0x04000F86 RID: 3974
		private global::System.Windows.Forms.ListView lvBlacklist;

		// Token: 0x04000F87 RID: 3975
		private global::System.Windows.Forms.ColumnHeader columnHeader_2;

		// Token: 0x04000F88 RID: 3976
		private global::System.Windows.Forms.Button btnBlacklistAdd;

		// Token: 0x04000F89 RID: 3977
		private global::System.Windows.Forms.CheckBox cboxBlacklist;

		// Token: 0x04000F8A RID: 3978
		private global::System.Windows.Forms.CheckBox PKThieuLamLast;
	}
}
