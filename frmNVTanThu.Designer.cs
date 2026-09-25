namespace ns0
{
	// Token: 0x020000F4 RID: 244
	internal sealed partial class frmNVTanThu : global::System.Windows.Forms.Form
	{
		// Token: 0x06000986 RID: 2438 RVA: 0x0000A010 File Offset: 0x00008210
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x000AFF34 File Offset: 0x000AE134
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmNVTanThu));
			this.cboxTanThu = new global::System.Windows.Forms.CheckBox();
			this.btnDanhCo = new global::System.Windows.Forms.Button();
			this.btnAcTac = new global::System.Windows.Forms.Button();
			this.btnAcBa = new global::System.Windows.Forms.Button();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			base.SuspendLayout();
			componentResourceManager.ApplyResources(this.cboxTanThu, "cboxTanThu");
			this.cboxTanThu.Name = "cboxTanThu";
			this.cboxTanThu.UseVisualStyleBackColor = true;
			this.cboxTanThu.CheckedChanged += new global::System.EventHandler(this.cboxTanThu_CheckedChanged);
			componentResourceManager.ApplyResources(this.btnDanhCo, "btnDanhCo");
			this.btnDanhCo.Name = "btnDanhCo";
			this.btnDanhCo.UseVisualStyleBackColor = true;
			this.btnDanhCo.Click += new global::System.EventHandler(this.btnDanhCo_Click);
			componentResourceManager.ApplyResources(this.btnAcTac, "btnAcTac");
			this.btnAcTac.Name = "btnAcTac";
			this.btnAcTac.UseVisualStyleBackColor = true;
			this.btnAcTac.Click += new global::System.EventHandler(this.btnAcTac_Click);
			componentResourceManager.ApplyResources(this.btnAcBa, "btnAcBa");
			this.btnAcBa.Name = "btnAcBa";
			this.btnAcBa.UseVisualStyleBackColor = true;
			this.btnAcBa.Click += new global::System.EventHandler(this.btnAcBa_Click);
			this.timer_0.Enabled = true;
			this.timer_0.Interval = 300;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.btnAcBa);
			base.Controls.Add(this.btnAcTac);
			base.Controls.Add(this.btnDanhCo);
			base.Controls.Add(this.cboxTanThu);
			base.Name = "frmNVTanThu";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmNVTanThu_FormClosing);
			base.Load += new global::System.EventHandler(this.frmNVTanThu_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000C80 RID: 3200
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000C81 RID: 3201
		private global::System.Windows.Forms.CheckBox cboxTanThu;

		// Token: 0x04000C82 RID: 3202
		private global::System.Windows.Forms.Button btnDanhCo;

		// Token: 0x04000C83 RID: 3203
		private global::System.Windows.Forms.Button btnAcTac;

		// Token: 0x04000C84 RID: 3204
		private global::System.Windows.Forms.Button btnAcBa;

		// Token: 0x04000C85 RID: 3205
		private global::System.Windows.Forms.Timer timer_0;
	}
}
