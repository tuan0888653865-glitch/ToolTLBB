namespace ns0
{
	// Token: 0x0200010F RID: 271
	internal sealed partial class frmVersions_FW : global::System.Windows.Forms.Form
	{
		// Token: 0x06000B09 RID: 2825 RVA: 0x0000ADD9 File Offset: 0x00008FD9
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x000D4B30 File Offset: 0x000D2D30
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmVersions_FW));
			this.lbUpdateText = new global::System.Windows.Forms.Label();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.btnLater = new global::System.Windows.Forms.Button();
			this.btnUpdate = new global::System.Windows.Forms.Button();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.richVersion = new global::System.Windows.Forms.RichTextBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.lbUpdateText.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.lbUpdateText.Location = new global::System.Drawing.Point(0, 0);
			this.lbUpdateText.Margin = new global::System.Windows.Forms.Padding(5, 5, 3, 0);
			this.lbUpdateText.Name = "lbUpdateText";
			this.lbUpdateText.Padding = new global::System.Windows.Forms.Padding(5, 10, 0, 0);
			this.lbUpdateText.Size = new global::System.Drawing.Size(517, 110);
			this.lbUpdateText.TabIndex = 0;
			this.lbUpdateText.Text = componentResourceManager.GetString("lbUpdateText.Text");
			this.panel1.Controls.Add(this.btnLater);
			this.panel1.Controls.Add(this.btnUpdate);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new global::System.Drawing.Point(0, 414);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(517, 34);
			this.panel1.TabIndex = 2;
			this.btnLater.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnLater.Location = new global::System.Drawing.Point(369, 6);
			this.btnLater.Name = "btnLater";
			this.btnLater.Size = new global::System.Drawing.Size(69, 21);
			this.btnLater.TabIndex = 74;
			this.btnLater.Text = "&Để sau";
			this.btnLater.UseVisualStyleBackColor = false;
			this.btnLater.Click += new global::System.EventHandler(this.btnLater_Click);
			this.btnUpdate.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnUpdate.Location = new global::System.Drawing.Point(442, 6);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new global::System.Drawing.Size(69, 21);
			this.btnUpdate.TabIndex = 73;
			this.btnUpdate.Text = "&Cập nhật";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new global::System.EventHandler(this.btnUpdate_Click);
			this.panel2.BackColor = global::System.Drawing.SystemColors.Window;
			this.panel2.Controls.Add(this.richVersion);
			this.panel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new global::System.Drawing.Point(0, 110);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new global::System.Windows.Forms.Padding(5);
			this.panel2.Size = new global::System.Drawing.Size(517, 304);
			this.panel2.TabIndex = 3;
			this.richVersion.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richVersion.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.richVersion.Font = new global::System.Drawing.Font("Courier New", 10.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 177);
			this.richVersion.ForeColor = global::System.Drawing.Color.FromArgb(0, 0, 0);
			this.richVersion.Location = new global::System.Drawing.Point(5, 5);
			this.richVersion.Margin = new global::System.Windows.Forms.Padding(5, 3, 3, 3);
			this.richVersion.Name = "richVersion";
			this.richVersion.Size = new global::System.Drawing.Size(507, 294);
			this.richVersion.TabIndex = 2;
			this.richVersion.Text = "Thử nghiệm tiếng Việt\nThis is a test message\nTest line 2\n\nTest line 3\n*** --- ***\n";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(517, 448);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.lbUpdateText);
			this.MaximumSize = new global::System.Drawing.Size(533, 486);
			this.MinimumSize = new global::System.Drawing.Size(533, 486);
			base.Name = "frmVersions_FW";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			base.Tag = "XC";
			this.Text = "Thông Thiên Tây Du";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.frmVersions_FW_FormClosed);
			base.Load += new global::System.EventHandler(this.frmVersions_FW_Load);
			base.Shown += new global::System.EventHandler(this.frmVersions_FW_Shown);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000F90 RID: 3984
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000F91 RID: 3985
		private global::System.Windows.Forms.Label lbUpdateText;

		// Token: 0x04000F92 RID: 3986
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000F93 RID: 3987
		private global::System.Windows.Forms.Button btnLater;

		// Token: 0x04000F94 RID: 3988
		private global::System.Windows.Forms.Button btnUpdate;

		// Token: 0x04000F95 RID: 3989
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000F96 RID: 3990
		private global::System.Windows.Forms.RichTextBox richVersion;
	}
}
