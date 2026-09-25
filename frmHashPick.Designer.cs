namespace ns0
{
	// Token: 0x020000EB RID: 235
	internal sealed partial class frmHashPick : global::System.Windows.Forms.Form
	{
		// Token: 0x06000918 RID: 2328 RVA: 0x00009D60 File Offset: 0x00007F60
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x000A6914 File Offset: 0x000A4B14
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmHashPick));
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.cboNPH = new global::System.Windows.Forms.ComboBox();
			this.btnHashChon = new global::System.Windows.Forms.Button();
			this.btnHashHuy = new global::System.Windows.Forms.Button();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.lblTimer = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			componentResourceManager.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			componentResourceManager.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			componentResourceManager.ApplyResources(this.cboNPH, "cboNPH");
			this.cboNPH.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.cboNPH.FormattingEnabled = true;
			this.cboNPH.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("cboNPH.Items"),
				componentResourceManager.GetString("cboNPH.Items1"),
				componentResourceManager.GetString("cboNPH.Items2"),
				componentResourceManager.GetString("cboNPH.Items3")
			});
			this.cboNPH.Name = "cboNPH";
			this.cboNPH.SelectedIndexChanged += new global::System.EventHandler(this.cboNPH_SelectedIndexChanged);
			componentResourceManager.ApplyResources(this.btnHashChon, "btnHashChon");
			this.btnHashChon.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnHashChon.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.btnHashChon.Name = "btnHashChon";
			this.btnHashChon.UseVisualStyleBackColor = false;
			this.btnHashChon.Click += new global::System.EventHandler(this.btnHashChon_Click);
			componentResourceManager.ApplyResources(this.btnHashHuy, "btnHashHuy");
			this.btnHashHuy.BackColor = global::System.Drawing.Color.FromArgb(247, 207, 142);
			this.btnHashHuy.ForeColor = global::System.Drawing.Color.Black;
			this.btnHashHuy.Name = "btnHashHuy";
			this.btnHashHuy.UseVisualStyleBackColor = false;
			this.btnHashHuy.Click += new global::System.EventHandler(this.btnHashHuy_Click);
			this.timer_0.Interval = 500;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			componentResourceManager.ApplyResources(this.lblTimer, "lblTimer");
			this.lblTimer.Name = "lblTimer";
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.lblTimer);
			base.Controls.Add(this.btnHashChon);
			base.Controls.Add(this.btnHashHuy);
			base.Controls.Add(this.cboNPH);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "frmHashPick";
			base.ShowIcon = false;
			base.Load += new global::System.EventHandler(this.frmHashPick_Load);
			base.Shown += new global::System.EventHandler(this.frmHashPick_Shown);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000BC9 RID: 3017
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000BCA RID: 3018
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000BCB RID: 3019
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000BCC RID: 3020
		private global::System.Windows.Forms.ComboBox cboNPH;

		// Token: 0x04000BCD RID: 3021
		private global::System.Windows.Forms.Button btnHashChon;

		// Token: 0x04000BCE RID: 3022
		private global::System.Windows.Forms.Button btnHashHuy;

		// Token: 0x04000BCF RID: 3023
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000BD0 RID: 3024
		private global::System.Windows.Forms.Label lblTimer;
	}
}
