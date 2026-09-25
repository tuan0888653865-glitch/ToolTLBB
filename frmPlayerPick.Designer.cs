namespace ns0
{
	// Token: 0x020000F7 RID: 247
	internal sealed partial class frmPlayerPick : global::System.Windows.Forms.Form
	{
		// Token: 0x060009B8 RID: 2488 RVA: 0x0000A258 File Offset: 0x00008458
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x000B2010 File Offset: 0x000B0210
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmPlayerPick));
			this.btnXoaName = new global::System.Windows.Forms.Button();
			this.txtPlayerName = new global::System.Windows.Forms.TextBox();
			this.lvPlayerList = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
			this.lblTop = new global::System.Windows.Forms.Label();
			this.btnClose = new global::System.Windows.Forms.Button();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			base.SuspendLayout();
			this.btnXoaName.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			componentResourceManager.ApplyResources(this.btnXoaName, "btnXoaName");
			this.btnXoaName.Name = "btnXoaName";
			this.btnXoaName.UseVisualStyleBackColor = false;
			this.btnXoaName.Click += new global::System.EventHandler(this.btnXoaName_Click);
			this.txtPlayerName.BackColor = global::System.Drawing.Color.WhiteSmoke;
			componentResourceManager.ApplyResources(this.txtPlayerName, "txtPlayerName");
			this.txtPlayerName.Name = "txtPlayerName";
			this.txtPlayerName.TextChanged += new global::System.EventHandler(this.txtPlayerName_TextChanged);
			this.lvPlayerList.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.lvPlayerList.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0,
				this.columnHeader_1
			});
			this.lvPlayerList.FullRowSelect = true;
			this.lvPlayerList.GridLines = true;
			this.lvPlayerList.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			componentResourceManager.ApplyResources(this.lvPlayerList, "lvPlayerList");
			this.lvPlayerList.Name = "lvPlayerList";
			this.lvPlayerList.UseCompatibleStateImageBehavior = false;
			this.lvPlayerList.View = global::System.Windows.Forms.View.Details;
			this.lvPlayerList.SelectedIndexChanged += new global::System.EventHandler(this.lvPlayerList_SelectedIndexChanged);
			this.lvPlayerList.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.lvPlayerList_MouseDoubleClick);
			componentResourceManager.ApplyResources(this.columnHeader_0, "columnHeader16");
			componentResourceManager.ApplyResources(this.columnHeader_1, "columnHeader1");
			componentResourceManager.ApplyResources(this.lblTop, "lblTop");
			this.lblTop.Name = "lblTop";
			this.btnClose.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			componentResourceManager.ApplyResources(this.btnClose, "btnClose");
			this.btnClose.Name = "btnClose";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new global::System.EventHandler(this.btnClose_Click);
			this.timer_0.Enabled = true;
			this.timer_0.Interval = 1000;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.btnClose);
			base.Controls.Add(this.lblTop);
			base.Controls.Add(this.btnXoaName);
			base.Controls.Add(this.txtPlayerName);
			base.Controls.Add(this.lvPlayerList);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.MaximizeBox = false;
			base.Name = "frmPlayerPick";
			base.Load += new global::System.EventHandler(this.frmPlayerPick_Load);
			base.Shown += new global::System.EventHandler(this.frmPlayerPick_Shown);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000CA6 RID: 3238
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000CA7 RID: 3239
		private global::System.Windows.Forms.Button btnXoaName;

		// Token: 0x04000CA8 RID: 3240
		private global::System.Windows.Forms.TextBox txtPlayerName;

		// Token: 0x04000CA9 RID: 3241
		private global::System.Windows.Forms.ListView lvPlayerList;

		// Token: 0x04000CAA RID: 3242
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x04000CAB RID: 3243
		private global::System.Windows.Forms.Label lblTop;

		// Token: 0x04000CAC RID: 3244
		private global::System.Windows.Forms.Button btnClose;

		// Token: 0x04000CAD RID: 3245
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000CAE RID: 3246
		private global::System.Windows.Forms.ColumnHeader columnHeader_1;
	}
}
