namespace ns0
{
	// Token: 0x020000E3 RID: 227
	internal sealed partial class frmAbout : global::System.Windows.Forms.Form
	{
		// Token: 0x06000875 RID: 2165 RVA: 0x000098DC File Offset: 0x00007ADC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x0009E6F4 File Offset: 0x0009C8F4
		private void InitializeComponent()
		{
			this.tableLayoutPanel = new global::System.Windows.Forms.TableLayoutPanel();
			this.logoPictureBox = new global::System.Windows.Forms.PictureBox();
			this.labelProductName = new global::System.Windows.Forms.Label();
			this.labelVersion = new global::System.Windows.Forms.Label();
			this.labelCopyright = new global::System.Windows.Forms.Label();
			this.labelCompanyName = new global::System.Windows.Forms.Label();
			this.textBoxDescription = new global::System.Windows.Forms.TextBox();
			this.okButton = new global::System.Windows.Forms.Button();
			this.tableLayoutPanel.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.logoPictureBox).BeginInit();
			base.SuspendLayout();
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 33f));
			this.tableLayoutPanel.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 67f));
			this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.labelVersion, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.labelCopyright, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.labelCompanyName, 1, 3);
			this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 1, 4);
			this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
			this.tableLayoutPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new global::System.Drawing.Point(9, 9);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 6;
			this.tableLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10f));
			this.tableLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10f));
			this.tableLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10f));
			this.tableLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10f));
			this.tableLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10f));
			this.tableLayoutPanel.Size = new global::System.Drawing.Size(437, 271);
			this.tableLayoutPanel.TabIndex = 0;
			this.logoPictureBox.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.logoPictureBox.Image = global::ns0.Class212.AboutBox;
			this.logoPictureBox.Location = new global::System.Drawing.Point(3, 3);
			this.logoPictureBox.Name = "logoPictureBox";
			this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
			this.logoPictureBox.Size = new global::System.Drawing.Size(138, 265);
			this.logoPictureBox.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.logoPictureBox.TabIndex = 12;
			this.logoPictureBox.TabStop = false;
			this.labelProductName.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.labelProductName.Location = new global::System.Drawing.Point(150, 0);
			this.labelProductName.Margin = new global::System.Windows.Forms.Padding(6, 0, 3, 0);
			this.labelProductName.MaximumSize = new global::System.Drawing.Size(0, 17);
			this.labelProductName.Name = "labelProductName";
			this.labelProductName.Size = new global::System.Drawing.Size(284, 17);
			this.labelProductName.TabIndex = 19;
			this.labelProductName.Text = "Product Name";
			this.labelProductName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelVersion.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.labelVersion.Location = new global::System.Drawing.Point(150, 27);
			this.labelVersion.Margin = new global::System.Windows.Forms.Padding(6, 0, 3, 0);
			this.labelVersion.MaximumSize = new global::System.Drawing.Size(0, 17);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new global::System.Drawing.Size(284, 17);
			this.labelVersion.TabIndex = 0;
			this.labelVersion.Text = "Version";
			this.labelVersion.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelCopyright.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.labelCopyright.Location = new global::System.Drawing.Point(150, 54);
			this.labelCopyright.Margin = new global::System.Windows.Forms.Padding(6, 0, 3, 0);
			this.labelCopyright.MaximumSize = new global::System.Drawing.Size(0, 17);
			this.labelCopyright.Name = "labelCopyright";
			this.labelCopyright.Size = new global::System.Drawing.Size(284, 17);
			this.labelCopyright.TabIndex = 21;
			this.labelCopyright.Text = "Copyright";
			this.labelCopyright.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelCompanyName.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.labelCompanyName.Location = new global::System.Drawing.Point(150, 81);
			this.labelCompanyName.Margin = new global::System.Windows.Forms.Padding(6, 0, 3, 0);
			this.labelCompanyName.MaximumSize = new global::System.Drawing.Size(0, 17);
			this.labelCompanyName.Name = "labelCompanyName";
			this.labelCompanyName.Size = new global::System.Drawing.Size(284, 17);
			this.labelCompanyName.TabIndex = 22;
			this.labelCompanyName.Text = "Company Name";
			this.labelCompanyName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.textBoxDescription.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.textBoxDescription.Location = new global::System.Drawing.Point(150, 111);
			this.textBoxDescription.Margin = new global::System.Windows.Forms.Padding(6, 3, 3, 3);
			this.textBoxDescription.Multiline = true;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.ReadOnly = true;
			this.textBoxDescription.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.textBoxDescription.Size = new global::System.Drawing.Size(284, 129);
			this.textBoxDescription.TabIndex = 23;
			this.textBoxDescription.TabStop = false;
			this.textBoxDescription.Text = "Description";
			this.okButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.okButton.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.okButton.Location = new global::System.Drawing.Point(359, 246);
			this.okButton.Name = "okButton";
			this.okButton.Size = new global::System.Drawing.Size(75, 22);
			this.okButton.TabIndex = 24;
			this.okButton.Text = "&OK";
			this.okButton.Click += new global::System.EventHandler(this.okButton_Click);
			base.AcceptButton = this.okButton;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(455, 289);
			base.Controls.Add(this.tableLayoutPanel);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmAbout";
			base.Padding = new global::System.Windows.Forms.Padding(9);
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmAbout";
			base.Load += new global::System.EventHandler(this.frmAbout_Load);
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.logoPictureBox).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000B0E RID: 2830
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000B0F RID: 2831
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel;

		// Token: 0x04000B10 RID: 2832
		private global::System.Windows.Forms.PictureBox logoPictureBox;

		// Token: 0x04000B11 RID: 2833
		private global::System.Windows.Forms.Label labelProductName;

		// Token: 0x04000B12 RID: 2834
		private global::System.Windows.Forms.Label labelVersion;

		// Token: 0x04000B13 RID: 2835
		private global::System.Windows.Forms.Label labelCopyright;

		// Token: 0x04000B14 RID: 2836
		private global::System.Windows.Forms.Label labelCompanyName;

		// Token: 0x04000B15 RID: 2837
		private global::System.Windows.Forms.TextBox textBoxDescription;

		// Token: 0x04000B16 RID: 2838
		private global::System.Windows.Forms.Button okButton;
	}
}
