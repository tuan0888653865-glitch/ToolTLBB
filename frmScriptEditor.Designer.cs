namespace ns0
{
	// Token: 0x02000108 RID: 264
	internal sealed partial class frmScriptEditor : global::System.Windows.Forms.Form
	{
		// Token: 0x06000ACF RID: 2767 RVA: 0x0000ABBA File Offset: 0x00008DBA
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x000D172C File Offset: 0x000CF92C
		private void InitializeComponent()
		{
			this.btnGetCurrentPos = new global::System.Windows.Forms.Button();
			this.menuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.scriptsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_0 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_3 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.scriptManagerToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader_2 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_3 = new global::System.Windows.Forms.ColumnHeader();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.statusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.splitter1 = new global::System.Windows.Forms.Splitter();
			this.listView2 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
			this.label1 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			base.SuspendLayout();
			this.btnGetCurrentPos.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnGetCurrentPos.Location = new global::System.Drawing.Point(9, 622);
			this.btnGetCurrentPos.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnGetCurrentPos.Name = "btnGetCurrentPos";
			this.btnGetCurrentPos.Size = new global::System.Drawing.Size(69, 23);
			this.btnGetCurrentPos.TabIndex = 6;
			this.btnGetCurrentPos.Text = "Lấy tọa độ";
			this.btnGetCurrentPos.UseVisualStyleBackColor = true;
			this.menuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.scriptsToolStripMenuItem,
				this.toolStripMenuItem_3
			});
			this.menuStrip1.Location = new global::System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new global::System.Drawing.Size(571, 24);
			this.menuStrip1.TabIndex = 8;
			this.menuStrip1.Text = "menuStrip1";
			this.scriptsToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_0,
				this.toolStripMenuItem_1,
				this.toolStripMenuItem_2
			});
			this.scriptsToolStripMenuItem.Name = "scriptsToolStripMenuItem";
			this.scriptsToolStripMenuItem.Size = new global::System.Drawing.Size(72, 20);
			this.scriptsToolStripMenuItem.Text = "Soạn thảo";
			this.toolStripMenuItem_0.Name = "mởScriptCóSẵnToolStripMenuItem";
			this.toolStripMenuItem_0.Size = new global::System.Drawing.Size(168, 22);
			this.toolStripMenuItem_0.Text = "Mở script có sẵn";
			this.toolStripMenuItem_1.Name = "lưuScriptHiệnTạiToolStripMenuItem";
			this.toolStripMenuItem_1.Size = new global::System.Drawing.Size(168, 22);
			this.toolStripMenuItem_1.Text = "Lưu script hiện tại";
			this.toolStripMenuItem_2.Name = "thoátToolStripMenuItem";
			this.toolStripMenuItem_2.Size = new global::System.Drawing.Size(168, 22);
			this.toolStripMenuItem_2.Text = "Thoát";
			this.toolStripMenuItem_3.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.scriptManagerToolStripMenuItem
			});
			this.toolStripMenuItem_3.Name = "quảnLýScriptToolStripMenuItem";
			this.toolStripMenuItem_3.Size = new global::System.Drawing.Size(93, 20);
			this.toolStripMenuItem_3.Text = "Quản lý Script";
			this.scriptManagerToolStripMenuItem.Name = "scriptManagerToolStripMenuItem";
			this.scriptManagerToolStripMenuItem.Size = new global::System.Drawing.Size(154, 22);
			this.scriptManagerToolStripMenuItem.Text = "Script Manager";
			this.splitContainer1.Location = new global::System.Drawing.Point(9, 48);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
			this.splitContainer1.Panel2.Controls.Add(this.button2);
			this.splitContainer1.Panel2.Controls.Add(this.button1);
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Panel2.Controls.Add(this.listView2);
			this.splitContainer1.Panel2.Controls.Add(this.splitter1);
			this.splitContainer1.Panel2.Controls.Add(this.listView1);
			this.splitContainer1.Panel2.Paint += new global::System.Windows.Forms.PaintEventHandler(this.method_0);
			this.splitContainer1.Size = new global::System.Drawing.Size(549, 567);
			this.splitContainer1.SplitterDistance = 372;
			this.splitContainer1.TabIndex = 12;
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_2,
				this.columnHeader_3
			});
			this.listView1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.listView1.Location = new global::System.Drawing.Point(0, 0);
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(173, 257);
			this.listView1.TabIndex = 11;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.columnHeader_2.Text = "Từ khóa";
			this.columnHeader_3.Text = "Chức năng";
			this.richTextBox1.BackColor = global::System.Drawing.Color.OldLace;
			this.richTextBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.richTextBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.richTextBox1.Location = new global::System.Drawing.Point(0, 0);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(372, 609);
			this.richTextBox1.TabIndex = 8;
			this.richTextBox1.Text = "# Script sử dụng đi ác tặc\n# Tạo bởi QATeam\n# Cập nhật  ngày 28/07/2026\n\n# Script header\n\n\n# Script loop";
			this.statusStrip1.Location = new global::System.Drawing.Point(0, 650);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new global::System.Drawing.Size(571, 22);
			this.statusStrip1.TabIndex = 13;
			this.statusStrip1.Text = "statusStrip1";
			this.splitter1.Cursor = global::System.Windows.Forms.Cursors.HSplit;
			this.splitter1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.splitter1.Location = new global::System.Drawing.Point(0, 257);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new global::System.Drawing.Size(173, 10);
			this.splitter1.TabIndex = 12;
			this.splitter1.TabStop = false;
			this.listView2.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0,
				this.columnHeader_1
			});
			this.listView2.Location = new global::System.Drawing.Point(0, 290);
			this.listView2.Name = "listView2";
			this.listView2.Size = new global::System.Drawing.Size(173, 244);
			this.listView2.TabIndex = 14;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.View = global::System.Windows.Forms.View.Details;
			this.columnHeader_0.Text = "Từ khóa";
			this.columnHeader_1.Text = "Chức năng";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(4, 274);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(79, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "Script Manager";
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new global::System.Drawing.Point(7, 537);
			this.button1.Margin = new global::System.Windows.Forms.Padding(0);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(69, 23);
			this.button1.TabIndex = 16;
			this.button1.Text = "Xóa";
			this.button1.UseVisualStyleBackColor = true;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new global::System.Drawing.Point(78, 538);
			this.button2.Margin = new global::System.Windows.Forms.Padding(0);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(69, 23);
			this.button2.TabIndex = 17;
			this.button2.Text = "Mở";
			this.button2.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(571, 672);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.splitContainer1);
			base.Controls.Add(this.btnGetCurrentPos);
			base.Controls.Add(this.menuStrip1);
			base.MainMenuStrip = this.menuStrip1;
			base.Name = "frmScriptEditor";
			this.Text = "frmScriptEditor";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			this.splitContainer1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000F3B RID: 3899
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000F3C RID: 3900
		private global::System.Windows.Forms.Button btnGetCurrentPos;

		// Token: 0x04000F3D RID: 3901
		private global::System.Windows.Forms.MenuStrip menuStrip1;

		// Token: 0x04000F3E RID: 3902
		private global::System.Windows.Forms.ToolStripMenuItem scriptsToolStripMenuItem;

		// Token: 0x04000F3F RID: 3903
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x04000F40 RID: 3904
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_1;

		// Token: 0x04000F41 RID: 3905
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_2;

		// Token: 0x04000F42 RID: 3906
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_3;

		// Token: 0x04000F43 RID: 3907
		private global::System.Windows.Forms.ToolStripMenuItem scriptManagerToolStripMenuItem;

		// Token: 0x04000F44 RID: 3908
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x04000F45 RID: 3909
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x04000F46 RID: 3910
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000F47 RID: 3911
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000F48 RID: 3912
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000F49 RID: 3913
		private global::System.Windows.Forms.ListView listView2;

		// Token: 0x04000F4A RID: 3914
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x04000F4B RID: 3915
		private global::System.Windows.Forms.ColumnHeader columnHeader_1;

		// Token: 0x04000F4C RID: 3916
		private global::System.Windows.Forms.Splitter splitter1;

		// Token: 0x04000F4D RID: 3917
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x04000F4E RID: 3918
		private global::System.Windows.Forms.ColumnHeader columnHeader_2;

		// Token: 0x04000F4F RID: 3919
		private global::System.Windows.Forms.ColumnHeader columnHeader_3;

		// Token: 0x04000F50 RID: 3920
		private global::System.Windows.Forms.StatusStrip statusStrip1;
	}
}
