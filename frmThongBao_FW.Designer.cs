namespace ns0
{
	// Token: 0x0200010B RID: 267
	internal sealed partial class frmThongBao_FW : global::System.Windows.Forms.Form
	{
		// Token: 0x06000ADC RID: 2780 RVA: 0x0000AC74 File Offset: 0x00008E74
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x000D2330 File Offset: 0x000D0530
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			this.lblContent = new global::System.Windows.Forms.Label();
			this.btnYes = new global::System.Windows.Forms.Button();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.label2 = new global::System.Windows.Forms.Label();
			this.lblSeconds = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.lblContent.Location = new global::System.Drawing.Point(12, 10);
			this.lblContent.Name = "lblContent";
			this.lblContent.Size = new global::System.Drawing.Size(315, 138);
			this.lblContent.TabIndex = 0;
			this.lblContent.Text = "Nội dung thông báo";
			this.btnYes.Location = new global::System.Drawing.Point(254, 151);
			this.btnYes.Name = "btnYes";
			this.btnYes.Size = new global::System.Drawing.Size(75, 23);
			this.btnYes.TabIndex = 1;
			this.btnYes.Text = "Đóng";
			this.btnYes.UseVisualStyleBackColor = true;
			this.btnYes.Click += new global::System.EventHandler(this.btnYes_Click);
			this.timer_0.Interval = 400;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(13, 151);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(92, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Bảng tự đóng sau";
			this.lblSeconds.AutoSize = true;
			this.lblSeconds.Location = new global::System.Drawing.Point(37, 169);
			this.lblSeconds.Name = "lblSeconds";
			this.lblSeconds.Size = new global::System.Drawing.Size(35, 13);
			this.lblSeconds.TabIndex = 3;
			this.lblSeconds.Text = "label3";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(339, 182);
			base.Controls.Add(this.lblSeconds);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.btnYes);
			base.Controls.Add(this.lblContent);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(355, 220);
			this.MinimumSize = new global::System.Drawing.Size(355, 220);
			base.Name = "frmThongBao_FW";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thông báo";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.frmThongBao_FW_FormClosed);
			base.Load += new global::System.EventHandler(this.frmThongBao_FW_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000F5E RID: 3934
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000F5F RID: 3935
		private global::System.Windows.Forms.Button btnYes;

		// Token: 0x04000F60 RID: 3936
		internal global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000F61 RID: 3937
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000F62 RID: 3938
		internal global::System.Windows.Forms.Label lblSeconds;

		// Token: 0x04000F63 RID: 3939
		internal global::System.Windows.Forms.Label lblContent;
	}
}
