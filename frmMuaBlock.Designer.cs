namespace ns0
{
	// Token: 0x020000F2 RID: 242
	internal sealed partial class frmMuaBlock : global::System.Windows.Forms.Form
	{
		// Token: 0x06000968 RID: 2408 RVA: 0x00009F3B File Offset: 0x0000813B
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x000ACD7C File Offset: 0x000AAF7C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmMuaBlock));
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.rdio_9999_day = new global::System.Windows.Forms.RadioButton();
			this.rdio_360_day = new global::System.Windows.Forms.RadioButton();
			this.rdio_180_day = new global::System.Windows.Forms.RadioButton();
			this.rdio_90_day = new global::System.Windows.Forms.RadioButton();
			this.rdio_30_day = new global::System.Windows.Forms.RadioButton();
			this.rdio_6_day = new global::System.Windows.Forms.RadioButton();
			this.rdio_1_day = new global::System.Windows.Forms.RadioButton();
			this.label1 = new global::System.Windows.Forms.Label();
			this.lblAccountName = new global::System.Windows.Forms.Label();
			this.lblGGBalance = new global::System.Windows.Forms.Label();
			this.btnMuaBlock = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			componentResourceManager.ApplyResources(this.groupBox1, "groupBox1");
			this.groupBox1.Controls.Add(this.rdio_9999_day);
			this.groupBox1.Controls.Add(this.rdio_360_day);
			this.groupBox1.Controls.Add(this.rdio_180_day);
			this.groupBox1.Controls.Add(this.rdio_90_day);
			this.groupBox1.Controls.Add(this.rdio_30_day);
			this.groupBox1.Controls.Add(this.rdio_6_day);
			this.groupBox1.Controls.Add(this.rdio_1_day);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabStop = false;
			componentResourceManager.ApplyResources(this.rdio_9999_day, "rdio_9999_day");
			this.rdio_9999_day.Name = "rdio_9999_day";
			this.rdio_9999_day.TabStop = true;
			this.rdio_9999_day.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.rdio_360_day, "rdio_360_day");
			this.rdio_360_day.Name = "rdio_360_day";
			this.rdio_360_day.TabStop = true;
			this.rdio_360_day.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.rdio_180_day, "rdio_180_day");
			this.rdio_180_day.Name = "rdio_180_day";
			this.rdio_180_day.TabStop = true;
			this.rdio_180_day.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.rdio_90_day, "rdio_90_day");
			this.rdio_90_day.Name = "rdio_90_day";
			this.rdio_90_day.TabStop = true;
			this.rdio_90_day.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.rdio_30_day, "rdio_30_day");
			this.rdio_30_day.Name = "rdio_30_day";
			this.rdio_30_day.TabStop = true;
			this.rdio_30_day.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.rdio_6_day, "rdio_6_day");
			this.rdio_6_day.Name = "rdio_6_day";
			this.rdio_6_day.TabStop = true;
			this.rdio_6_day.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.rdio_1_day, "rdio_1_day");
			this.rdio_1_day.Name = "rdio_1_day";
			this.rdio_1_day.TabStop = true;
			this.rdio_1_day.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			componentResourceManager.ApplyResources(this.lblAccountName, "lblAccountName");
			this.lblAccountName.Name = "lblAccountName";
			componentResourceManager.ApplyResources(this.lblGGBalance, "lblGGBalance");
			this.lblGGBalance.Name = "lblGGBalance";
			componentResourceManager.ApplyResources(this.btnMuaBlock, "btnMuaBlock");
			this.btnMuaBlock.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnMuaBlock.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.btnMuaBlock.Name = "btnMuaBlock";
			this.btnMuaBlock.UseVisualStyleBackColor = false;
			this.btnMuaBlock.Click += new global::System.EventHandler(this.btnMuaBlock_Click);
			componentResourceManager.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.label2);
			base.Controls.Add(this.btnMuaBlock);
			base.Controls.Add(this.lblGGBalance);
			base.Controls.Add(this.lblAccountName);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.groupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.MaximizeBox = false;
			base.Name = "frmMuaBlock";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmMuaBlock_FormClosing);
			base.Load += new global::System.EventHandler(this.frmMuaBlock_Load);
			base.Shown += new global::System.EventHandler(this.frmMuaBlock_Shown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000C40 RID: 3136
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000C41 RID: 3137
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000C42 RID: 3138
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000C43 RID: 3139
		private global::System.Windows.Forms.Label lblAccountName;

		// Token: 0x04000C44 RID: 3140
		private global::System.Windows.Forms.Label lblGGBalance;

		// Token: 0x04000C45 RID: 3141
		private global::System.Windows.Forms.RadioButton rdio_360_day;

		// Token: 0x04000C46 RID: 3142
		private global::System.Windows.Forms.RadioButton rdio_180_day;

		// Token: 0x04000C47 RID: 3143
		private global::System.Windows.Forms.RadioButton rdio_90_day;

		// Token: 0x04000C48 RID: 3144
		private global::System.Windows.Forms.RadioButton rdio_30_day;

		// Token: 0x04000C49 RID: 3145
		private global::System.Windows.Forms.RadioButton rdio_6_day;

		// Token: 0x04000C4A RID: 3146
		private global::System.Windows.Forms.RadioButton rdio_1_day;

		// Token: 0x04000C4B RID: 3147
		private global::System.Windows.Forms.Button btnMuaBlock;

		// Token: 0x04000C4C RID: 3148
		private global::System.Windows.Forms.RadioButton rdio_9999_day;

		// Token: 0x04000C4D RID: 3149
		private global::System.Windows.Forms.Label label2;
	}
}
