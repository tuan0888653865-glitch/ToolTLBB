namespace ns0
{
	// Token: 0x020000E4 RID: 228
	internal sealed partial class frmCheDo : global::System.Windows.Forms.Form
	{
		// Token: 0x06000893 RID: 2195 RVA: 0x00009989 File Offset: 0x00007B89
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x0009F820 File Offset: 0x0009DA20
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmCheDo));
			this.cboItemCheDo = new global::System.Windows.Forms.ComboBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.cboCheDoDTD = new global::System.Windows.Forms.ComboBox();
			this.numCheDoAmount = new global::System.Windows.Forms.NumericUpDown();
			this.label13 = new global::System.Windows.Forms.Label();
			this.numCheDoSao = new global::System.Windows.Forms.NumericUpDown();
			this.cboxHuyCheDo = new global::System.Windows.Forms.CheckBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.numCheDoDong = new global::System.Windows.Forms.NumericUpDown();
			this.cboxIsCheDo = new global::System.Windows.Forms.CheckBox();
			this.cboxGiu2DongTM = new global::System.Windows.Forms.CheckBox();
			this.btnCheDoClose = new global::System.Windows.Forms.Button();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.label5 = new global::System.Windows.Forms.Label();
			this.cboCheDoXong = new global::System.Windows.Forms.ComboBox();
			this.numCheDoSLmua = new global::System.Windows.Forms.NumericUpDown();
			this.label6 = new global::System.Windows.Forms.Label();
			this.numCheDoChiSo = new global::System.Windows.Forms.NumericUpDown();
			this.label7 = new global::System.Windows.Forms.Label();
			this.cboxCheDoMap = new global::System.Windows.Forms.ComboBox();
			this.cboxBanChoNPC = new global::System.Windows.Forms.CheckBox();
			this.cboxHuyNLThua = new global::System.Windows.Forms.CheckBox();
			this.cboAutoGiaHan = new global::System.Windows.Forms.ComboBox();
			this.cboxCDExtend = new global::System.Windows.Forms.CheckBox();
			((global::System.ComponentModel.ISupportInitialize)this.numCheDoAmount).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numCheDoSao).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numCheDoDong).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numCheDoSLmua).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numCheDoChiSo).BeginInit();
			base.SuspendLayout();
			this.cboItemCheDo.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.cboItemCheDo, "cboItemCheDo");
			this.cboItemCheDo.FormattingEnabled = true;
			this.cboItemCheDo.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("cboItemCheDo.Items"),
				componentResourceManager.GetString("cboItemCheDo.Items1"),
				componentResourceManager.GetString("cboItemCheDo.Items2"),
				componentResourceManager.GetString("cboItemCheDo.Items3"),
				componentResourceManager.GetString("cboItemCheDo.Items4"),
				componentResourceManager.GetString("cboItemCheDo.Items5"),
				componentResourceManager.GetString("cboItemCheDo.Items6"),
				componentResourceManager.GetString("cboItemCheDo.Items7"),
				componentResourceManager.GetString("cboItemCheDo.Items8"),
				componentResourceManager.GetString("cboItemCheDo.Items9"),
				componentResourceManager.GetString("cboItemCheDo.Items10"),
				componentResourceManager.GetString("cboItemCheDo.Items11"),
				componentResourceManager.GetString("cboItemCheDo.Items12"),
				componentResourceManager.GetString("cboItemCheDo.Items13"),
				componentResourceManager.GetString("cboItemCheDo.Items14"),
				componentResourceManager.GetString("cboItemCheDo.Items15")
			});
			this.cboItemCheDo.Name = "cboItemCheDo";
			this.cboItemCheDo.SelectedIndexChanged += new global::System.EventHandler(this.cboItemCheDo_SelectedIndexChanged);
			componentResourceManager.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			componentResourceManager.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			this.cboCheDoDTD.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.cboCheDoDTD, "cboCheDoDTD");
			this.cboCheDoDTD.FormattingEnabled = true;
			this.cboCheDoDTD.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("cboCheDoDTD.Items"),
				componentResourceManager.GetString("cboCheDoDTD.Items1"),
				componentResourceManager.GetString("cboCheDoDTD.Items2"),
				componentResourceManager.GetString("cboCheDoDTD.Items3"),
				componentResourceManager.GetString("cboCheDoDTD.Items4"),
				componentResourceManager.GetString("cboCheDoDTD.Items5"),
				componentResourceManager.GetString("cboCheDoDTD.Items6"),
				componentResourceManager.GetString("cboCheDoDTD.Items7")
			});
			this.cboCheDoDTD.Name = "cboCheDoDTD";
			this.cboCheDoDTD.SelectedIndexChanged += new global::System.EventHandler(this.cboCheDoDTD_SelectedIndexChanged);
			this.numCheDoAmount.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.numCheDoAmount, "numCheDoAmount");
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numCheDoAmount;
			int[] array = new int[4];
			array[0] = 99999;
			numericUpDown.Maximum = new decimal(array);
			this.numCheDoAmount.Name = "numCheDoAmount";
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numCheDoAmount;
			int[] array2 = new int[4];
			array2[0] = 200;
			numericUpDown2.Value = new decimal(array2);
			this.numCheDoAmount.ValueChanged += new global::System.EventHandler(this.numCheDoAmount_ValueChanged);
			this.numCheDoAmount.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numCheDoAmount_KeyPress);
			componentResourceManager.ApplyResources(this.label13, "label13");
			this.label13.Name = "label13";
			this.numCheDoSao.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.numCheDoSao, "numCheDoSao");
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numCheDoSao;
			int[] array3 = new int[4];
			array3[0] = 20;
			numericUpDown3.Maximum = new decimal(array3);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.numCheDoSao;
			int[] array4 = new int[4];
			array4[0] = 1;
			numericUpDown4.Minimum = new decimal(array4);
			this.numCheDoSao.Name = "numCheDoSao";
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.numCheDoSao;
			int[] array5 = new int[4];
			array5[0] = 8;
			numericUpDown5.Value = new decimal(array5);
			this.numCheDoSao.ValueChanged += new global::System.EventHandler(this.numCheDoSao_ValueChanged);
			this.numCheDoSao.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numCheDoSao_KeyPress);
			componentResourceManager.ApplyResources(this.cboxHuyCheDo, "cboxHuyCheDo");
			this.cboxHuyCheDo.ForeColor = global::System.Drawing.Color.Black;
			this.cboxHuyCheDo.Name = "cboxHuyCheDo";
			this.cboxHuyCheDo.UseVisualStyleBackColor = true;
			this.cboxHuyCheDo.CheckedChanged += new global::System.EventHandler(this.cboxHuyCheDo_CheckedChanged);
			componentResourceManager.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			componentResourceManager.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			this.numCheDoDong.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.numCheDoDong, "numCheDoDong");
			global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.numCheDoDong;
			int[] array6 = new int[4];
			array6[0] = 50;
			numericUpDown6.Maximum = new decimal(array6);
			global::System.Windows.Forms.NumericUpDown numericUpDown7 = this.numCheDoDong;
			int[] array7 = new int[4];
			array7[0] = 1;
			numericUpDown7.Minimum = new decimal(array7);
			this.numCheDoDong.Name = "numCheDoDong";
			global::System.Windows.Forms.NumericUpDown numericUpDown8 = this.numCheDoDong;
			int[] array8 = new int[4];
			array8[0] = 5;
			numericUpDown8.Value = new decimal(array8);
			this.numCheDoDong.ValueChanged += new global::System.EventHandler(this.numCheDoDong_ValueChanged);
			this.numCheDoDong.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numCheDoDong_KeyPress);
			componentResourceManager.ApplyResources(this.cboxIsCheDo, "cboxIsCheDo");
			this.cboxIsCheDo.Name = "cboxIsCheDo";
			this.cboxIsCheDo.UseVisualStyleBackColor = true;
			this.cboxIsCheDo.CheckedChanged += new global::System.EventHandler(this.cboxIsCheDo_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxGiu2DongTM, "cboxGiu2DongTM");
			this.cboxGiu2DongTM.ForeColor = global::System.Drawing.Color.Black;
			this.cboxGiu2DongTM.Name = "cboxGiu2DongTM";
			this.cboxGiu2DongTM.UseVisualStyleBackColor = true;
			this.cboxGiu2DongTM.CheckedChanged += new global::System.EventHandler(this.cboxGiu2DongTM_CheckedChanged);
			this.btnCheDoClose.BackColor = global::System.Drawing.Color.FromArgb(247, 207, 142);
			this.btnCheDoClose.ForeColor = global::System.Drawing.Color.Black;
			componentResourceManager.ApplyResources(this.btnCheDoClose, "btnCheDoClose");
			this.btnCheDoClose.Name = "btnCheDoClose";
			this.btnCheDoClose.UseVisualStyleBackColor = false;
			this.btnCheDoClose.Click += new global::System.EventHandler(this.btnCheDoClose_Click);
			this.timer_0.Enabled = true;
			this.timer_0.Interval = 400;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			componentResourceManager.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
			this.cboCheDoXong.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.cboCheDoXong, "cboCheDoXong");
			this.cboCheDoXong.FormattingEnabled = true;
			this.cboCheDoXong.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("cboCheDoXong.Items"),
				componentResourceManager.GetString("cboCheDoXong.Items1"),
				componentResourceManager.GetString("cboCheDoXong.Items2"),
				componentResourceManager.GetString("cboCheDoXong.Items3")
			});
			this.cboCheDoXong.Name = "cboCheDoXong";
			this.cboCheDoXong.SelectedIndexChanged += new global::System.EventHandler(this.cboCheDoXong_SelectedIndexChanged);
			this.numCheDoSLmua.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.numCheDoSLmua, "numCheDoSLmua");
			global::System.Windows.Forms.NumericUpDown numericUpDown9 = this.numCheDoSLmua;
			int[] array9 = new int[4];
			array9[0] = 5000;
			numericUpDown9.Maximum = new decimal(array9);
			global::System.Windows.Forms.NumericUpDown numericUpDown10 = this.numCheDoSLmua;
			int[] array10 = new int[4];
			array10[0] = 11;
			numericUpDown10.Minimum = new decimal(array10);
			this.numCheDoSLmua.Name = "numCheDoSLmua";
			global::System.Windows.Forms.NumericUpDown numericUpDown11 = this.numCheDoSLmua;
			int[] array11 = new int[4];
			array11[0] = 30;
			numericUpDown11.Value = new decimal(array11);
			this.numCheDoSLmua.ValueChanged += new global::System.EventHandler(this.numCheDoSLmua_ValueChanged);
			this.numCheDoSLmua.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numCheDoSLmua_KeyPress);
			componentResourceManager.ApplyResources(this.label6, "label6");
			this.label6.Name = "label6";
			this.numCheDoChiSo.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.numCheDoChiSo, "numCheDoChiSo");
			global::System.Windows.Forms.NumericUpDown numericUpDown12 = this.numCheDoChiSo;
			int[] array12 = new int[4];
			array12[0] = 200;
			numericUpDown12.Maximum = new decimal(array12);
			this.numCheDoChiSo.Name = "numCheDoChiSo";
			global::System.Windows.Forms.NumericUpDown numericUpDown13 = this.numCheDoChiSo;
			int[] array13 = new int[4];
			array13[0] = 90;
			numericUpDown13.Value = new decimal(array13);
			this.numCheDoChiSo.ValueChanged += new global::System.EventHandler(this.numCheDoChiSo_ValueChanged);
			this.numCheDoChiSo.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numCheDoChiSo_KeyPress);
			componentResourceManager.ApplyResources(this.label7, "label7");
			this.label7.Name = "label7";
			this.cboxCheDoMap.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.cboxCheDoMap, "cboxCheDoMap");
			this.cboxCheDoMap.FormattingEnabled = true;
			this.cboxCheDoMap.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("cboxCheDoMap.Items"),
				componentResourceManager.GetString("cboxCheDoMap.Items1"),
				componentResourceManager.GetString("cboxCheDoMap.Items2"),
				componentResourceManager.GetString("cboxCheDoMap.Items3")
			});
			this.cboxCheDoMap.Name = "cboxCheDoMap";
			this.cboxCheDoMap.SelectedIndexChanged += new global::System.EventHandler(this.cboxCheDoMap_SelectedIndexChanged);
			componentResourceManager.ApplyResources(this.cboxBanChoNPC, "cboxBanChoNPC");
			this.cboxBanChoNPC.ForeColor = global::System.Drawing.Color.Black;
			this.cboxBanChoNPC.Name = "cboxBanChoNPC";
			this.cboxBanChoNPC.UseVisualStyleBackColor = true;
			this.cboxBanChoNPC.CheckedChanged += new global::System.EventHandler(this.cboxBanChoNPC_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxHuyNLThua, "cboxHuyNLThua");
			this.cboxHuyNLThua.ForeColor = global::System.Drawing.Color.Black;
			this.cboxHuyNLThua.Name = "cboxHuyNLThua";
			this.cboxHuyNLThua.UseVisualStyleBackColor = true;
			this.cboxHuyNLThua.CheckedChanged += new global::System.EventHandler(this.cboxHuyNLThua_CheckedChanged);
			this.cboAutoGiaHan.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.cboAutoGiaHan, "cboAutoGiaHan");
			this.cboAutoGiaHan.FormattingEnabled = true;
			this.cboAutoGiaHan.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("cboAutoGiaHan.Items"),
				componentResourceManager.GetString("cboAutoGiaHan.Items1"),
				componentResourceManager.GetString("cboAutoGiaHan.Items2")
			});
			this.cboAutoGiaHan.Name = "cboAutoGiaHan";
			this.cboAutoGiaHan.SelectedIndexChanged += new global::System.EventHandler(this.cboAutoGiaHan_SelectedIndexChanged);
			componentResourceManager.ApplyResources(this.cboxCDExtend, "cboxCDExtend");
			this.cboxCDExtend.Name = "cboxCDExtend";
			this.cboxCDExtend.UseVisualStyleBackColor = true;
			this.cboxCDExtend.CheckedChanged += new global::System.EventHandler(this.cboxCDExtend_CheckedChanged);
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.cboAutoGiaHan);
			base.Controls.Add(this.cboxCDExtend);
			base.Controls.Add(this.cboxHuyNLThua);
			base.Controls.Add(this.cboxBanChoNPC);
			base.Controls.Add(this.cboxCheDoMap);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.numCheDoChiSo);
			base.Controls.Add(this.numCheDoSLmua);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.cboCheDoXong);
			base.Controls.Add(this.btnCheDoClose);
			base.Controls.Add(this.cboxGiu2DongTM);
			base.Controls.Add(this.cboxIsCheDo);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.numCheDoDong);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.numCheDoSao);
			base.Controls.Add(this.cboxHuyCheDo);
			base.Controls.Add(this.numCheDoAmount);
			base.Controls.Add(this.label13);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.cboCheDoDTD);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.cboItemCheDo);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.Name = "frmCheDo";
			base.ShowIcon = false;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmCheDo_FormClosing);
			base.Load += new global::System.EventHandler(this.frmCheDo_Load);
			base.Shown += new global::System.EventHandler(this.frmCheDo_Shown);
			((global::System.ComponentModel.ISupportInitialize)this.numCheDoAmount).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numCheDoSao).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numCheDoDong).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numCheDoSLmua).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numCheDoChiSo).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000B1D RID: 2845
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000B1E RID: 2846
		private global::System.Windows.Forms.ComboBox cboItemCheDo;

		// Token: 0x04000B1F RID: 2847
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000B20 RID: 2848
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000B21 RID: 2849
		private global::System.Windows.Forms.ComboBox cboCheDoDTD;

		// Token: 0x04000B22 RID: 2850
		private global::System.Windows.Forms.NumericUpDown numCheDoAmount;

		// Token: 0x04000B23 RID: 2851
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000B24 RID: 2852
		private global::System.Windows.Forms.NumericUpDown numCheDoSao;

		// Token: 0x04000B25 RID: 2853
		private global::System.Windows.Forms.CheckBox cboxHuyCheDo;

		// Token: 0x04000B26 RID: 2854
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000B27 RID: 2855
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000B28 RID: 2856
		private global::System.Windows.Forms.NumericUpDown numCheDoDong;

		// Token: 0x04000B29 RID: 2857
		private global::System.Windows.Forms.CheckBox cboxIsCheDo;

		// Token: 0x04000B2A RID: 2858
		private global::System.Windows.Forms.CheckBox cboxGiu2DongTM;

		// Token: 0x04000B2B RID: 2859
		private global::System.Windows.Forms.Button btnCheDoClose;

		// Token: 0x04000B2C RID: 2860
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000B2D RID: 2861
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000B2E RID: 2862
		private global::System.Windows.Forms.ComboBox cboCheDoXong;

		// Token: 0x04000B2F RID: 2863
		private global::System.Windows.Forms.NumericUpDown numCheDoSLmua;

		// Token: 0x04000B30 RID: 2864
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000B31 RID: 2865
		private global::System.Windows.Forms.NumericUpDown numCheDoChiSo;

		// Token: 0x04000B32 RID: 2866
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000B33 RID: 2867
		private global::System.Windows.Forms.ComboBox cboxCheDoMap;

		// Token: 0x04000B34 RID: 2868
		private global::System.Windows.Forms.CheckBox cboxBanChoNPC;

		// Token: 0x04000B35 RID: 2869
		private global::System.Windows.Forms.CheckBox cboxHuyNLThua;

		// Token: 0x04000B36 RID: 2870
		private global::System.Windows.Forms.ComboBox cboAutoGiaHan;

		// Token: 0x04000B37 RID: 2871
		private global::System.Windows.Forms.CheckBox cboxCDExtend;
	}
}
