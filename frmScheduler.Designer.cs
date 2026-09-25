namespace ns0
{
	// Token: 0x02000106 RID: 262
	internal sealed partial class frmScheduler : global::System.Windows.Forms.Form
	{
		// Token: 0x06000AC9 RID: 2761 RVA: 0x0000AB65 File Offset: 0x00008D65
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x000D09B0 File Offset: 0x000CEBB0
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmScheduler));
			this.cboxScheduler = new global::System.Windows.Forms.CheckBox();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.label2 = new global::System.Windows.Forms.Label();
			this.cboHour = new global::System.Windows.Forms.ComboBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.cboMinute = new global::System.Windows.Forms.ComboBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.cboEventName = new global::System.Windows.Forms.ComboBox();
			this.btnClose = new global::System.Windows.Forms.Button();
			this.btnAddEvent = new global::System.Windows.Forms.Button();
			this.btnDelEvent = new global::System.Windows.Forms.Button();
			this.btnEditEvent = new global::System.Windows.Forms.Button();
			this.label5 = new global::System.Windows.Forms.Label();
			this.lvAllEvents = new global::ns0.GClass3();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
			base.SuspendLayout();
			componentResourceManager.ApplyResources(this.cboxScheduler, "cboxScheduler");
			this.cboxScheduler.Name = "cboxScheduler";
			this.cboxScheduler.UseVisualStyleBackColor = true;
			this.cboxScheduler.CheckedChanged += new global::System.EventHandler(this.cboxScheduler_CheckedChanged);
			this.timer_0.Enabled = true;
			this.timer_0.Interval = 400;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			componentResourceManager.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			this.cboHour.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.cboHour, "cboHour");
			this.cboHour.FormattingEnabled = true;
			this.cboHour.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("cboHour.Items"),
				componentResourceManager.GetString("cboHour.Items1"),
				componentResourceManager.GetString("cboHour.Items2"),
				componentResourceManager.GetString("cboHour.Items3"),
				componentResourceManager.GetString("cboHour.Items4"),
				componentResourceManager.GetString("cboHour.Items5"),
				componentResourceManager.GetString("cboHour.Items6"),
				componentResourceManager.GetString("cboHour.Items7"),
				componentResourceManager.GetString("cboHour.Items8"),
				componentResourceManager.GetString("cboHour.Items9"),
				componentResourceManager.GetString("cboHour.Items10"),
				componentResourceManager.GetString("cboHour.Items11"),
				componentResourceManager.GetString("cboHour.Items12"),
				componentResourceManager.GetString("cboHour.Items13"),
				componentResourceManager.GetString("cboHour.Items14"),
				componentResourceManager.GetString("cboHour.Items15"),
				componentResourceManager.GetString("cboHour.Items16"),
				componentResourceManager.GetString("cboHour.Items17"),
				componentResourceManager.GetString("cboHour.Items18"),
				componentResourceManager.GetString("cboHour.Items19"),
				componentResourceManager.GetString("cboHour.Items20"),
				componentResourceManager.GetString("cboHour.Items21"),
				componentResourceManager.GetString("cboHour.Items22"),
				componentResourceManager.GetString("cboHour.Items23")
			});
			this.cboHour.Name = "cboHour";
			componentResourceManager.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			componentResourceManager.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			this.cboMinute.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.cboMinute, "cboMinute");
			this.cboMinute.FormattingEnabled = true;
			this.cboMinute.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("cboMinute.Items"),
				componentResourceManager.GetString("cboMinute.Items1"),
				componentResourceManager.GetString("cboMinute.Items2"),
				componentResourceManager.GetString("cboMinute.Items3"),
				componentResourceManager.GetString("cboMinute.Items4"),
				componentResourceManager.GetString("cboMinute.Items5"),
				componentResourceManager.GetString("cboMinute.Items6"),
				componentResourceManager.GetString("cboMinute.Items7"),
				componentResourceManager.GetString("cboMinute.Items8"),
				componentResourceManager.GetString("cboMinute.Items9"),
				componentResourceManager.GetString("cboMinute.Items10"),
				componentResourceManager.GetString("cboMinute.Items11"),
				componentResourceManager.GetString("cboMinute.Items12"),
				componentResourceManager.GetString("cboMinute.Items13"),
				componentResourceManager.GetString("cboMinute.Items14"),
				componentResourceManager.GetString("cboMinute.Items15"),
				componentResourceManager.GetString("cboMinute.Items16"),
				componentResourceManager.GetString("cboMinute.Items17"),
				componentResourceManager.GetString("cboMinute.Items18"),
				componentResourceManager.GetString("cboMinute.Items19"),
				componentResourceManager.GetString("cboMinute.Items20"),
				componentResourceManager.GetString("cboMinute.Items21"),
				componentResourceManager.GetString("cboMinute.Items22"),
				componentResourceManager.GetString("cboMinute.Items23"),
				componentResourceManager.GetString("cboMinute.Items24"),
				componentResourceManager.GetString("cboMinute.Items25"),
				componentResourceManager.GetString("cboMinute.Items26"),
				componentResourceManager.GetString("cboMinute.Items27"),
				componentResourceManager.GetString("cboMinute.Items28"),
				componentResourceManager.GetString("cboMinute.Items29"),
				componentResourceManager.GetString("cboMinute.Items30"),
				componentResourceManager.GetString("cboMinute.Items31"),
				componentResourceManager.GetString("cboMinute.Items32"),
				componentResourceManager.GetString("cboMinute.Items33"),
				componentResourceManager.GetString("cboMinute.Items34"),
				componentResourceManager.GetString("cboMinute.Items35"),
				componentResourceManager.GetString("cboMinute.Items36"),
				componentResourceManager.GetString("cboMinute.Items37"),
				componentResourceManager.GetString("cboMinute.Items38"),
				componentResourceManager.GetString("cboMinute.Items39"),
				componentResourceManager.GetString("cboMinute.Items40"),
				componentResourceManager.GetString("cboMinute.Items41"),
				componentResourceManager.GetString("cboMinute.Items42"),
				componentResourceManager.GetString("cboMinute.Items43"),
				componentResourceManager.GetString("cboMinute.Items44"),
				componentResourceManager.GetString("cboMinute.Items45"),
				componentResourceManager.GetString("cboMinute.Items46"),
				componentResourceManager.GetString("cboMinute.Items47"),
				componentResourceManager.GetString("cboMinute.Items48"),
				componentResourceManager.GetString("cboMinute.Items49"),
				componentResourceManager.GetString("cboMinute.Items50"),
				componentResourceManager.GetString("cboMinute.Items51"),
				componentResourceManager.GetString("cboMinute.Items52"),
				componentResourceManager.GetString("cboMinute.Items53"),
				componentResourceManager.GetString("cboMinute.Items54"),
				componentResourceManager.GetString("cboMinute.Items55"),
				componentResourceManager.GetString("cboMinute.Items56"),
				componentResourceManager.GetString("cboMinute.Items57"),
				componentResourceManager.GetString("cboMinute.Items58"),
				componentResourceManager.GetString("cboMinute.Items59")
			});
			this.cboMinute.Name = "cboMinute";
			componentResourceManager.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			this.cboEventName.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.cboEventName.DropDownWidth = 150;
			componentResourceManager.ApplyResources(this.cboEventName, "cboEventName");
			this.cboEventName.FormattingEnabled = true;
			this.cboEventName.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("cboEventName.Items"),
				componentResourceManager.GetString("cboEventName.Items1"),
				componentResourceManager.GetString("cboEventName.Items2"),
				componentResourceManager.GetString("cboEventName.Items3"),
				componentResourceManager.GetString("cboEventName.Items4"),
				componentResourceManager.GetString("cboEventName.Items5"),
				componentResourceManager.GetString("cboEventName.Items6"),
				componentResourceManager.GetString("cboEventName.Items7"),
				componentResourceManager.GetString("cboEventName.Items8"),
				componentResourceManager.GetString("cboEventName.Items9"),
				componentResourceManager.GetString("cboEventName.Items10"),
				componentResourceManager.GetString("cboEventName.Items11"),
				componentResourceManager.GetString("cboEventName.Items12"),
				componentResourceManager.GetString("cboEventName.Items13"),
				componentResourceManager.GetString("cboEventName.Items14"),
				componentResourceManager.GetString("cboEventName.Items15"),
				componentResourceManager.GetString("cboEventName.Items16"),
				componentResourceManager.GetString("cboEventName.Items17"),
				componentResourceManager.GetString("cboEventName.Items18"),
				componentResourceManager.GetString("cboEventName.Items19"),
				componentResourceManager.GetString("cboEventName.Items20"),
				componentResourceManager.GetString("cboEventName.Items21"),
				componentResourceManager.GetString("cboEventName.Items22"),
				componentResourceManager.GetString("cboEventName.Items23"),
				componentResourceManager.GetString("cboEventName.Items24"),
				componentResourceManager.GetString("cboEventName.Items25")
			});
			this.cboEventName.Name = "cboEventName";
			this.btnClose.BackColor = global::System.Drawing.Color.FromArgb(247, 207, 142);
			this.btnClose.ForeColor = global::System.Drawing.Color.Black;
			componentResourceManager.ApplyResources(this.btnClose, "btnClose");
			this.btnClose.Name = "btnClose";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new global::System.EventHandler(this.btnClose_Click);
			this.btnAddEvent.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnAddEvent.ForeColor = global::System.Drawing.Color.DarkGreen;
			componentResourceManager.ApplyResources(this.btnAddEvent, "btnAddEvent");
			this.btnAddEvent.Name = "btnAddEvent";
			this.btnAddEvent.UseVisualStyleBackColor = false;
			this.btnAddEvent.Click += new global::System.EventHandler(this.btnAddEvent_Click);
			this.btnDelEvent.BackColor = global::System.Drawing.Color.FromArgb(247, 207, 142);
			this.btnDelEvent.ForeColor = global::System.Drawing.Color.Black;
			componentResourceManager.ApplyResources(this.btnDelEvent, "btnDelEvent");
			this.btnDelEvent.Name = "btnDelEvent";
			this.btnDelEvent.UseVisualStyleBackColor = false;
			this.btnDelEvent.Click += new global::System.EventHandler(this.btnDelEvent_Click);
			this.btnEditEvent.BackColor = global::System.Drawing.Color.FromArgb(247, 207, 142);
			componentResourceManager.ApplyResources(this.btnEditEvent, "btnEditEvent");
			this.btnEditEvent.ForeColor = global::System.Drawing.Color.Black;
			this.btnEditEvent.Name = "btnEditEvent";
			this.btnEditEvent.UseVisualStyleBackColor = false;
			this.btnEditEvent.Click += new global::System.EventHandler(this.btnEditEvent_Click);
			componentResourceManager.ApplyResources(this.label5, "label5");
			this.label5.ForeColor = global::System.Drawing.Color.Red;
			this.label5.Name = "label5";
			this.lvAllEvents.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0,
				this.columnHeader_1
			});
			this.lvAllEvents.FullRowSelect = true;
			this.lvAllEvents.GridLines = true;
			this.lvAllEvents.Int32_1 = -1;
			this.lvAllEvents.Int32_0 = -1;
			componentResourceManager.ApplyResources(this.lvAllEvents, "lvAllEvents");
			this.lvAllEvents.Name = "lvAllEvents";
			this.lvAllEvents.UseCompatibleStateImageBehavior = false;
			this.lvAllEvents.View = global::System.Windows.Forms.View.Details;
			componentResourceManager.ApplyResources(this.columnHeader_0, "columnHeader1");
			componentResourceManager.ApplyResources(this.columnHeader_1, "columnHeader2");
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.label5);
			base.Controls.Add(this.btnEditEvent);
			base.Controls.Add(this.btnDelEvent);
			base.Controls.Add(this.lvAllEvents);
			base.Controls.Add(this.btnAddEvent);
			base.Controls.Add(this.btnClose);
			base.Controls.Add(this.cboEventName);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.cboMinute);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.cboHour);
			base.Controls.Add(this.cboxScheduler);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.Name = "frmScheduler";
			base.ShowIcon = false;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmScheduler_FormClosing);
			base.Load += new global::System.EventHandler(this.frmScheduler_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000F27 RID: 3879
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000F28 RID: 3880
		private global::System.Windows.Forms.CheckBox cboxScheduler;

		// Token: 0x04000F29 RID: 3881
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000F2A RID: 3882
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000F2B RID: 3883
		private global::System.Windows.Forms.ComboBox cboHour;

		// Token: 0x04000F2C RID: 3884
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000F2D RID: 3885
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000F2E RID: 3886
		private global::System.Windows.Forms.ComboBox cboMinute;

		// Token: 0x04000F2F RID: 3887
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000F30 RID: 3888
		private global::System.Windows.Forms.ComboBox cboEventName;

		// Token: 0x04000F31 RID: 3889
		private global::System.Windows.Forms.Button btnClose;

		// Token: 0x04000F32 RID: 3890
		private global::System.Windows.Forms.Button btnAddEvent;

		// Token: 0x04000F33 RID: 3891
		private global::ns0.GClass3 lvAllEvents;

		// Token: 0x04000F34 RID: 3892
		private global::System.Windows.Forms.Button btnDelEvent;

		// Token: 0x04000F35 RID: 3893
		private global::System.Windows.Forms.Button btnEditEvent;

		// Token: 0x04000F36 RID: 3894
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x04000F37 RID: 3895
		private global::System.Windows.Forms.ColumnHeader columnHeader_1;

		// Token: 0x04000F38 RID: 3896
		private global::System.Windows.Forms.Label label5;
	}
}
