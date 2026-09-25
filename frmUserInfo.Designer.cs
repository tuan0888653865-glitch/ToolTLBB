namespace ns0
{
	// Token: 0x02000129 RID: 297
	internal sealed partial class frmUserInfo : global::System.Windows.Forms.Form
	{
		// Token: 0x0600123E RID: 4670 RVA: 0x0001654F File Offset: 0x0001474F
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x0011750C File Offset: 0x0011570C
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmUserInfo));
			this.grpUser = new global::System.Windows.Forms.GroupBox();
			this.txtYTO = new global::System.Windows.Forms.TextBox();
			this.label9 = new global::System.Windows.Forms.Label();
			this.btnRefreshInfo = new global::System.Windows.Forms.Button();
			this.lblTrading = new global::System.Windows.Forms.Label();
			this.txtTrading = new global::System.Windows.Forms.TextBox();
			this.btnNapThe = new global::System.Windows.Forms.Button();
			this.btnThem24h = new global::System.Windows.Forms.Button();
			this.txtQ1TC = new global::System.Windows.Forms.TextBox();
			this.label8 = new global::System.Windows.Forms.Label();
			this.txtCheDo = new global::System.Windows.Forms.TextBox();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.remainGGold = new global::System.Windows.Forms.TextBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.userExpDate = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.remainTime = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.remainCash = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.userID = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.btnRefresh = new global::System.Windows.Forms.Button();
			this.label12 = new global::System.Windows.Forms.Label();
			this.lvHoatDong = new global::System.Windows.Forms.ListView();
			this.columnHeader_4 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_5 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_6 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_7 = new global::System.Windows.Forms.ColumnHeader();
			this.label10 = new global::System.Windows.Forms.Label();
			this.lvTheDaNap = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_2 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_3 = new global::System.Windows.Forms.ColumnHeader();
			this.grpUser.SuspendLayout();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.grpUser.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.grpUser.Controls.Add(this.txtYTO);
			this.grpUser.Controls.Add(this.label9);
			this.grpUser.Controls.Add(this.btnRefreshInfo);
			this.grpUser.Controls.Add(this.lblTrading);
			this.grpUser.Controls.Add(this.txtTrading);
			this.grpUser.Controls.Add(this.btnNapThe);
			this.grpUser.Controls.Add(this.btnThem24h);
			this.grpUser.Controls.Add(this.txtQ1TC);
			this.grpUser.Controls.Add(this.label8);
			this.grpUser.Controls.Add(this.txtCheDo);
			this.grpUser.Controls.Add(this.label11);
			this.grpUser.Controls.Add(this.label7);
			this.grpUser.Controls.Add(this.remainGGold);
			this.grpUser.Controls.Add(this.label6);
			this.grpUser.Controls.Add(this.label5);
			this.grpUser.Controls.Add(this.userExpDate);
			this.grpUser.Controls.Add(this.label4);
			this.grpUser.Controls.Add(this.remainTime);
			this.grpUser.Controls.Add(this.label3);
			this.grpUser.Controls.Add(this.remainCash);
			this.grpUser.Controls.Add(this.label2);
			this.grpUser.Controls.Add(this.userID);
			this.grpUser.Controls.Add(this.label1);
			componentResourceManager.ApplyResources(this.grpUser, "grpUser");
			this.grpUser.Name = "grpUser";
			this.grpUser.TabStop = false;
			this.txtYTO.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.txtYTO.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtYTO.ForeColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			componentResourceManager.ApplyResources(this.txtYTO, "txtYTO");
			this.txtYTO.Name = "txtYTO";
			this.txtYTO.ReadOnly = true;
			this.txtYTO.TabStop = false;
			componentResourceManager.ApplyResources(this.label9, "label9");
			this.label9.Name = "label9";
			this.btnRefreshInfo.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnRefreshInfo.ForeColor = global::System.Drawing.Color.DarkGreen;
			componentResourceManager.ApplyResources(this.btnRefreshInfo, "btnRefreshInfo");
			this.btnRefreshInfo.Name = "btnRefreshInfo";
			this.btnRefreshInfo.UseVisualStyleBackColor = false;
			this.btnRefreshInfo.Click += new global::System.EventHandler(this.btnRefreshInfo_Click);
			componentResourceManager.ApplyResources(this.lblTrading, "lblTrading");
			this.lblTrading.Name = "lblTrading";
			this.txtTrading.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.txtTrading.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTrading.ForeColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			componentResourceManager.ApplyResources(this.txtTrading, "txtTrading");
			this.txtTrading.Name = "txtTrading";
			this.txtTrading.ReadOnly = true;
			this.txtTrading.TabStop = false;
			this.txtTrading.TextChanged += new global::System.EventHandler(this.txtTrading_TextChanged);
			this.btnNapThe.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnNapThe.ForeColor = global::System.Drawing.Color.DarkGreen;
			componentResourceManager.ApplyResources(this.btnNapThe, "btnNapThe");
			this.btnNapThe.Name = "btnNapThe";
			this.btnNapThe.UseVisualStyleBackColor = false;
			this.btnNapThe.Click += new global::System.EventHandler(this.btnNapThe_Click);
			this.btnThem24h.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnThem24h.ForeColor = global::System.Drawing.Color.DarkGreen;
			componentResourceManager.ApplyResources(this.btnThem24h, "btnThem24h");
			this.btnThem24h.Name = "btnThem24h";
			this.btnThem24h.UseVisualStyleBackColor = false;
			this.btnThem24h.Click += new global::System.EventHandler(this.btnThem24h_Click);
			this.txtQ1TC.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.txtQ1TC.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtQ1TC.ForeColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			componentResourceManager.ApplyResources(this.txtQ1TC, "txtQ1TC");
			this.txtQ1TC.Name = "txtQ1TC";
			this.txtQ1TC.ReadOnly = true;
			this.txtQ1TC.TabStop = false;
			componentResourceManager.ApplyResources(this.label8, "label8");
			this.label8.Name = "label8";
			this.txtCheDo.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.txtCheDo.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCheDo.ForeColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			componentResourceManager.ApplyResources(this.txtCheDo, "txtCheDo");
			this.txtCheDo.Name = "txtCheDo";
			this.txtCheDo.ReadOnly = true;
			this.txtCheDo.TabStop = false;
			componentResourceManager.ApplyResources(this.label11, "label11");
			this.label11.Name = "label11";
			componentResourceManager.ApplyResources(this.label7, "label7");
			this.label7.Name = "label7";
			this.remainGGold.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.remainGGold.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.remainGGold.ForeColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			componentResourceManager.ApplyResources(this.remainGGold, "remainGGold");
			this.remainGGold.Name = "remainGGold";
			this.remainGGold.ReadOnly = true;
			this.remainGGold.TabStop = false;
			componentResourceManager.ApplyResources(this.label6, "label6");
			this.label6.Name = "label6";
			this.label5.ForeColor = global::System.Drawing.Color.DarkRed;
			componentResourceManager.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
			this.userExpDate.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.userExpDate.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.userExpDate.ForeColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			componentResourceManager.ApplyResources(this.userExpDate, "userExpDate");
			this.userExpDate.Name = "userExpDate";
			this.userExpDate.ReadOnly = true;
			this.userExpDate.TabStop = false;
			componentResourceManager.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			this.remainTime.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.remainTime.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.remainTime.ForeColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			componentResourceManager.ApplyResources(this.remainTime, "remainTime");
			this.remainTime.Name = "remainTime";
			this.remainTime.ReadOnly = true;
			this.remainTime.TabStop = false;
			componentResourceManager.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			this.remainCash.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.remainCash.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.remainCash.ForeColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			componentResourceManager.ApplyResources(this.remainCash, "remainCash");
			this.remainCash.Name = "remainCash";
			this.remainCash.ReadOnly = true;
			this.remainCash.TabStop = false;
			componentResourceManager.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			this.userID.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.userID.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.userID.ForeColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			componentResourceManager.ApplyResources(this.userID, "userID");
			this.userID.Name = "userID";
			this.userID.ReadOnly = true;
			this.userID.TabStop = false;
			componentResourceManager.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			this.timer_0.Enabled = true;
			this.timer_0.Interval = 500;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.groupBox1.Controls.Add(this.btnRefresh);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.lvHoatDong);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.lvTheDaNap);
			componentResourceManager.ApplyResources(this.groupBox1, "groupBox1");
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new global::System.EventHandler(this.groupBox1_Enter);
			this.btnRefresh.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnRefresh.ForeColor = global::System.Drawing.Color.DarkGreen;
			componentResourceManager.ApplyResources(this.btnRefresh, "btnRefresh");
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.btnRefresh.Click += new global::System.EventHandler(this.btnRefresh_Click);
			componentResourceManager.ApplyResources(this.label12, "label12");
			this.label12.Name = "label12";
			this.lvHoatDong.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_4,
				this.columnHeader_5,
				this.columnHeader_6,
				this.columnHeader_7
			});
			this.lvHoatDong.FullRowSelect = true;
			this.lvHoatDong.GridLines = true;
			componentResourceManager.ApplyResources(this.lvHoatDong, "lvHoatDong");
			this.lvHoatDong.Name = "lvHoatDong";
			this.lvHoatDong.UseCompatibleStateImageBehavior = false;
			this.lvHoatDong.View = global::System.Windows.Forms.View.Details;
			componentResourceManager.ApplyResources(this.columnHeader_4, "columnHeader5");
			componentResourceManager.ApplyResources(this.columnHeader_5, "columnHeader6");
			componentResourceManager.ApplyResources(this.columnHeader_6, "columnHeader7");
			componentResourceManager.ApplyResources(this.columnHeader_7, "columnHeader8");
			componentResourceManager.ApplyResources(this.label10, "label10");
			this.label10.Name = "label10";
			this.lvTheDaNap.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0,
				this.columnHeader_1,
				this.columnHeader_2,
				this.columnHeader_3
			});
			this.lvTheDaNap.FullRowSelect = true;
			this.lvTheDaNap.GridLines = true;
			componentResourceManager.ApplyResources(this.lvTheDaNap, "lvTheDaNap");
			this.lvTheDaNap.Name = "lvTheDaNap";
			this.lvTheDaNap.UseCompatibleStateImageBehavior = false;
			this.lvTheDaNap.View = global::System.Windows.Forms.View.Details;
			componentResourceManager.ApplyResources(this.columnHeader_0, "columnHeader1");
			componentResourceManager.ApplyResources(this.columnHeader_1, "columnHeader2");
			componentResourceManager.ApplyResources(this.columnHeader_2, "columnHeader3");
			componentResourceManager.ApplyResources(this.columnHeader_3, "columnHeader4");
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.grpUser);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmUserInfo";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this.frmUserInfo_Load);
			base.Shown += new global::System.EventHandler(this.frmUserInfo_Shown);
			this.grpUser.ResumeLayout(false);
			this.grpUser.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400132D RID: 4909
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x0400132E RID: 4910
		private global::System.Windows.Forms.GroupBox grpUser;

		// Token: 0x0400132F RID: 4911
		private global::System.Windows.Forms.TextBox userExpDate;

		// Token: 0x04001330 RID: 4912
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04001331 RID: 4913
		private global::System.Windows.Forms.TextBox remainTime;

		// Token: 0x04001332 RID: 4914
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04001333 RID: 4915
		private global::System.Windows.Forms.TextBox remainCash;

		// Token: 0x04001334 RID: 4916
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04001335 RID: 4917
		private global::System.Windows.Forms.TextBox userID;

		// Token: 0x04001336 RID: 4918
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04001337 RID: 4919
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04001338 RID: 4920
		private global::System.Windows.Forms.TextBox remainGGold;

		// Token: 0x04001339 RID: 4921
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400133A RID: 4922
		private global::System.Windows.Forms.TextBox txtQ1TC;

		// Token: 0x0400133B RID: 4923
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400133C RID: 4924
		private global::System.Windows.Forms.TextBox txtCheDo;

		// Token: 0x0400133D RID: 4925
		private global::System.Windows.Forms.Label label11;

		// Token: 0x0400133E RID: 4926
		private global::System.Windows.Forms.Label label7;

		// Token: 0x0400133F RID: 4927
		private global::System.Windows.Forms.TextBox txtYTO;

		// Token: 0x04001340 RID: 4928
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04001341 RID: 4929
		private global::System.Windows.Forms.Button btnNapThe;

		// Token: 0x04001342 RID: 4930
		private global::System.Windows.Forms.Button btnThem24h;

		// Token: 0x04001343 RID: 4931
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04001344 RID: 4932
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04001345 RID: 4933
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04001346 RID: 4934
		private global::System.Windows.Forms.ListView lvTheDaNap;

		// Token: 0x04001347 RID: 4935
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x04001348 RID: 4936
		private global::System.Windows.Forms.ColumnHeader columnHeader_1;

		// Token: 0x04001349 RID: 4937
		private global::System.Windows.Forms.ColumnHeader columnHeader_2;

		// Token: 0x0400134A RID: 4938
		private global::System.Windows.Forms.ColumnHeader columnHeader_3;

		// Token: 0x0400134B RID: 4939
		private global::System.Windows.Forms.Label label12;

		// Token: 0x0400134C RID: 4940
		private global::System.Windows.Forms.ListView lvHoatDong;

		// Token: 0x0400134D RID: 4941
		private global::System.Windows.Forms.ColumnHeader columnHeader_4;

		// Token: 0x0400134E RID: 4942
		private global::System.Windows.Forms.ColumnHeader columnHeader_5;

		// Token: 0x0400134F RID: 4943
		private global::System.Windows.Forms.ColumnHeader columnHeader_6;

		// Token: 0x04001350 RID: 4944
		private global::System.Windows.Forms.ColumnHeader columnHeader_7;

		// Token: 0x04001351 RID: 4945
		private global::System.Windows.Forms.Button btnRefresh;

		// Token: 0x04001352 RID: 4946
		private global::System.Windows.Forms.TextBox txtTrading;

		// Token: 0x04001353 RID: 4947
		private global::System.Windows.Forms.Label lblTrading;

		// Token: 0x04001354 RID: 4948
		private global::System.Windows.Forms.Button btnRefreshInfo;
	}
}
