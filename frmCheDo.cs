using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x020000E4 RID: 228
	internal sealed partial class frmCheDo : Form
	{
		// Token: 0x06000877 RID: 2167 RVA: 0x000098FB File Offset: 0x00007AFB
		internal frmCheDo()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x0009EE74 File Offset: 0x0009D074
		private void frmCheDo_Load(object sender, EventArgs e)
		{
			if (frmLogin.class101_0.globalSettings_0.Account.list_1.Count > 0)
			{
				List<string> list = new List<string>();
				for (int i = 0; i < frmLogin.class101_0.globalSettings_0.Account.list_1.Count; i++)
				{
					if (frmLogin.class101_0.globalSettings_0.Account.list_1[i].string_0 == "tnchedo")
					{
						list.Add(frmLogin.class101_0.globalSettings_0.Account.list_1[i].String_1);
					}
				}
				if (list.Count > 0)
				{
					this.cboAutoGiaHan.BeginUpdate();
					this.cboAutoGiaHan.Items.Clear();
					ComboBox.ObjectCollection items = this.cboAutoGiaHan.Items;
					object[] items2 = list.ToArray();
					items.AddRange(items2);
					if (frmLogin.class101_0.globalSettings_0.cboCDExtend != "" && list.Contains(frmLogin.class101_0.globalSettings_0.cboCDExtend))
					{
						this.cboAutoGiaHan.SelectedItem = frmLogin.class101_0.globalSettings_0.cboCDExtend;
					}
					else
					{
						this.cboAutoGiaHan.SelectedIndex = 0;
					}
					this.cboAutoGiaHan.EndUpdate();
				}
			}
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x0009EFC0 File Offset: 0x0009D1C0
		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (base.Visible)
			{
				if (this.class58_0 != null)
				{
					if (!this.cboxIsCheDo.Focused && this.class58_0.class114_0 != null)
					{
						this.cboxIsCheDo.Checked = this.class58_0.class114_0.bool_152;
					}
					if (!this.cboCheDoXong.Focused)
					{
						this.cboCheDoXong.SelectedItem = this.class58_0.autoSettings_0.cboCheDoXong;
					}
					if (!this.cboItemCheDo.Focused)
					{
						this.cboItemCheDo.SelectedItem = this.class58_0.autoSettings_0.cboItemCheDo;
					}
					if (!this.cboCheDoDTD.Focused)
					{
						this.cboCheDoDTD.SelectedItem = this.class58_0.autoSettings_0.cboCheDoDTD;
					}
					if (!this.numCheDoAmount.Focused)
					{
						this.numCheDoAmount.Value = this.class58_0.autoSettings_0.numCheDoAmount;
					}
					if (!this.cboxHuyCheDo.Focused)
					{
						this.cboxHuyCheDo.Checked = this.class58_0.autoSettings_0.cboxHuyCheDo;
					}
					if (!this.cboxBanChoNPC.Focused)
					{
						this.cboxBanChoNPC.Checked = this.class58_0.autoSettings_0.cboxBanChoNPC;
					}
					if (!this.cboxHuyNLThua.Focused)
					{
						this.cboxHuyNLThua.Checked = this.class58_0.autoSettings_0.cboxHuyNLThua;
					}
					if (!this.numCheDoSao.Focused)
					{
						this.numCheDoSao.Value = this.class58_0.autoSettings_0.numCheDoSao;
					}
					if (!this.numCheDoDong.Focused)
					{
						this.numCheDoDong.Value = this.class58_0.autoSettings_0.numCheDoDong;
					}
					if (!this.numCheDoChiSo.Focused)
					{
						this.numCheDoChiSo.Value = this.class58_0.autoSettings_0.numCheDoChiSo;
					}
					if (!this.numCheDoSLmua.Focused)
					{
						this.numCheDoSLmua.Value = this.class58_0.autoSettings_0.numCheDoSLmua;
					}
					if (!this.cboxGiu2DongTM.Focused)
					{
						this.cboxGiu2DongTM.Checked = this.class58_0.autoSettings_0.cboxGiu2DongTM;
					}
					if (!this.cboxCheDoMap.Focused)
					{
						string text = Class83.smethod_133(this.class58_0.autoSettings_0.cboCheDoMap);
						if (this.cboxCheDoMap.Text != text)
						{
							this.cboxCheDoMap.Text = text;
						}
					}
				}
				if (!this.cboxCDExtend.Focused)
				{
					this.cboxCDExtend.Checked = frmLogin.class101_0.globalSettings_0.cboxCDExtend;
				}
				if (!this.cboAutoGiaHan.Focused)
				{
					this.cboAutoGiaHan.SelectedItem = frmLogin.class101_0.globalSettings_0.cboCDExtend;
				}
			}
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x0009F2A4 File Offset: 0x0009D4A4
		private void cboxHuyCheDo_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;
			if (this.class58_0 != null && checkBox.Focused)
			{
				this.class58_0.autoSettings_0.cboxHuyCheDo = checkBox.Checked;
			}
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x0009F2E0 File Offset: 0x0009D4E0
		private void cboItemCheDo_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.class58_0 != null)
			{
				ComboBox comboBox = sender as ComboBox;
				if (comboBox.Focused)
				{
					string a = comboBox.SelectedItem.ToString();
					if (a != "")
					{
						this.class58_0.autoSettings_0.cboItemCheDo = a;
					}
				}
			}
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x0009F330 File Offset: 0x0009D530
		private void cboCheDoDTD_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.class58_0 != null)
			{
				ComboBox comboBox = sender as ComboBox;
				if (comboBox.Focused)
				{
					string a = comboBox.SelectedItem.ToString();
					if (a != "")
					{
						this.class58_0.autoSettings_0.cboCheDoDTD = a;
					}
				}
			}
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x0009F380 File Offset: 0x0009D580
		private void cboxGiu2DongTM_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;
			if (this.class58_0 != null && checkBox.Focused)
			{
				this.class58_0.autoSettings_0.cboxGiu2DongTM = checkBox.Checked;
			}
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x0009F3BC File Offset: 0x0009D5BC
		private void numCheDoAmount_ValueChanged(object sender, EventArgs e)
		{
			NumericUpDown numericUpDown = sender as NumericUpDown;
			if (this.class58_0 != null && (numericUpDown.Focused || this.bool_0))
			{
				this.class58_0.autoSettings_0.numCheDoAmount = (int)numericUpDown.Value;
				this.bool_0 = false;
			}
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x0009F40C File Offset: 0x0009D60C
		private void numCheDoSao_ValueChanged(object sender, EventArgs e)
		{
			NumericUpDown numericUpDown = sender as NumericUpDown;
			if (this.class58_0 != null && (numericUpDown.Focused || this.bool_1))
			{
				this.class58_0.autoSettings_0.numCheDoSao = (int)numericUpDown.Value;
				this.bool_1 = false;
			}
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x0009F45C File Offset: 0x0009D65C
		private void numCheDoDong_ValueChanged(object sender, EventArgs e)
		{
			NumericUpDown numericUpDown = sender as NumericUpDown;
			if (this.class58_0 != null && (numericUpDown.Focused || this.bool_2))
			{
				this.class58_0.autoSettings_0.numCheDoDong = (int)numericUpDown.Value;
				this.bool_2 = false;
			}
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00009909 File Offset: 0x00007B09
		private void btnCheDoClose_Click(object sender, EventArgs e)
		{
			base.Hide();
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x0009F4AC File Offset: 0x0009D6AC
		private void cboxIsCheDo_CheckedChanged(object sender, EventArgs e)
		{
			frmCheDo.Class171 @class = new frmCheDo.Class171();
			@class.object_0 = sender;
			@class.eventArgs_0 = e;
			try
			{
				if (this.cboxIsCheDo.Focused)
				{
					frmMain.frmMain_0.cboxIsCheDo.Invoke(new MethodInvoker(@class.method_0));
				}
			}
			catch (Exception ex)
			{
				Class83.smethod_66("Crafting [1]: " + ex.Message, this.class58_0, new object[0]);
			}
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00009911 File Offset: 0x00007B11
		private void frmCheDo_Shown(object sender, EventArgs e)
		{
			this.btnCheDoClose.Focus();
			this.method_0();
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x0009F52C File Offset: 0x0009D72C
		private void method_0()
		{
			ToolTip toolTip = new ToolTip();
			toolTip.OwnerDraw = true;
			toolTip.BackColor = Color.Yellow;
			toolTip.AutoPopDelay = 20000;
			toolTip.InitialDelay = 500;
			toolTip.ReshowDelay = 500;
			toolTip.ShowAlways = true;
			toolTip.IsBalloon = true;
			toolTip.SetToolTip(this.numCheDoAmount, frmMain.String_559);
			toolTip.SetToolTip(this.cboxIsCheDo, frmMain.String_598);
			toolTip.SetToolTip(this.numCheDoChiSo, frmMain.String_558);
			toolTip.SetToolTip(this.cboxBanChoNPC, "Lựa chọn bán cho NPC hay là hủy vật phẩm\n- Nếu không tick chọn thì auto sẽ hủy");
			toolTip.SetToolTip(this.cboxHuyNLThua, "Riêng cho Tình Kiếm: Lựa chọn khi nhận NL chế đồ\nở chỗ Tiêu Phong có hủy bớt NL thừa không\n- Nếu chế Vải Bông sẽ vứt Bí Ngân, Tinh Thiết");
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00009925 File Offset: 0x00007B25
		private void numCheDoAmount_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (this.class58_0 != null)
			{
				this.bool_0 = true;
			}
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00009936 File Offset: 0x00007B36
		private void numCheDoSao_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (this.class58_0 != null)
			{
				this.bool_1 = true;
			}
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00009947 File Offset: 0x00007B47
		private void numCheDoDong_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (this.class58_0 != null)
			{
				this.bool_2 = true;
			}
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x0009F5D4 File Offset: 0x0009D7D4
		private void cboCheDoXong_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.class58_0 != null)
			{
				ComboBox comboBox = sender as ComboBox;
				if (comboBox.Focused)
				{
					string a = comboBox.SelectedItem.ToString();
					if (a != "")
					{
						this.class58_0.autoSettings_0.cboCheDoXong = a;
					}
				}
			}
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x0009F624 File Offset: 0x0009D824
		private void numCheDoChiSo_ValueChanged(object sender, EventArgs e)
		{
			NumericUpDown numericUpDown = sender as NumericUpDown;
			if (this.class58_0 != null && (numericUpDown.Focused || this.bool_3))
			{
				this.class58_0.autoSettings_0.numCheDoChiSo = (int)numericUpDown.Value;
				this.bool_3 = false;
			}
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x0009F674 File Offset: 0x0009D874
		private void numCheDoSLmua_ValueChanged(object sender, EventArgs e)
		{
			NumericUpDown numericUpDown = sender as NumericUpDown;
			if (this.class58_0 != null && (numericUpDown.Focused || this.bool_4))
			{
				this.class58_0.autoSettings_0.numCheDoSLmua = (int)numericUpDown.Value;
				this.bool_4 = false;
			}
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00009958 File Offset: 0x00007B58
		private void numCheDoSLmua_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (this.class58_0 != null)
			{
				this.bool_4 = true;
			}
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00009969 File Offset: 0x00007B69
		private void numCheDoChiSo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (this.class58_0 != null)
			{
				this.bool_3 = true;
			}
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x0009F6C4 File Offset: 0x0009D8C4
		private void cboxCheDoMap_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.class58_0 != null)
			{
				ComboBox comboBox = sender as ComboBox;
				if (comboBox.Text != "" && comboBox.Focused)
				{
					int num = Class83.smethod_143(comboBox.Text);
					if (num >= 0 && frmLogin.class101_0.CurrentAuto != null)
					{
						frmLogin.class101_0.CurrentAuto.autoSettings_0.cboCheDoMap = num;
					}
				}
			}
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x0000997A File Offset: 0x00007B7A
		private void frmCheDo_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			base.Hide();
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x0009F72C File Offset: 0x0009D92C
		private void cboxBanChoNPC_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;
			if (this.class58_0 != null && checkBox.Focused)
			{
				this.class58_0.autoSettings_0.cboxBanChoNPC = checkBox.Checked;
			}
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x0009F768 File Offset: 0x0009D968
		private void cboxHuyNLThua_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;
			if (this.class58_0 != null && checkBox.Focused)
			{
				this.class58_0.autoSettings_0.cboxHuyNLThua = checkBox.Checked;
			}
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x0009F7A4 File Offset: 0x0009D9A4
		private void cboxCDExtend_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;
			if (checkBox.Focused)
			{
				frmLogin.class101_0.globalSettings_0.cboxCDExtend = checkBox.Checked;
			}
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x0009F7D8 File Offset: 0x0009D9D8
		private void cboAutoGiaHan_SelectedIndexChanged(object sender, EventArgs e)
		{
			ComboBox comboBox = sender as ComboBox;
			if (comboBox.Text != "" && comboBox.Focused)
			{
				frmLogin.class101_0.globalSettings_0.cboCDExtend = comboBox.SelectedItem.ToString();
			}
		}

		// Token: 0x04000B17 RID: 2839
		internal Class58 class58_0;

		// Token: 0x04000B18 RID: 2840
		private bool bool_0;

		// Token: 0x04000B19 RID: 2841
		private bool bool_1;

		// Token: 0x04000B1A RID: 2842
		private bool bool_2;

		// Token: 0x04000B1B RID: 2843
		private bool bool_3;

		// Token: 0x04000B1C RID: 2844
		private bool bool_4;

		// Token: 0x020000E5 RID: 229
		[CompilerGenerated]
		private sealed class Class171
		{
			// Token: 0x06000896 RID: 2198 RVA: 0x000099A8 File Offset: 0x00007BA8
			internal void method_0()
			{
				frmMain.frmMain_0.cboxIsCheDo.Focus();
				frmMain.frmMain_0.cboxIsCheDo_CheckedChanged(this.object_0, this.eventArgs_0);
			}

			// Token: 0x04000B38 RID: 2872
			public object object_0;

			// Token: 0x04000B39 RID: 2873
			public EventArgs eventArgs_0;
		}
	}
}
