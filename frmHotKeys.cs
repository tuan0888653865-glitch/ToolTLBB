using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x020000F9 RID: 249
	internal sealed partial class frmHotKeys : Form
	{
		// Token: 0x060009CF RID: 2511 RVA: 0x000B42E8 File Offset: 0x000B24E8
		internal frmHotKeys()
		{
			if (frmLogin.string_0 == "EN")
			{
				CultureInfo cultureInfo = new CultureInfo("en-GB");
				Thread.CurrentThread.CurrentCulture = cultureInfo;
				Thread.CurrentThread.CurrentUICulture = cultureInfo;
			}
			else if (frmLogin.string_0 == "CN")
			{
				CultureInfo currentUICulture = new CultureInfo("zh-Hans");
				CultureInfo currentCulture = new CultureInfo("zh-CN");
				Thread.CurrentThread.CurrentCulture = currentCulture;
				Thread.CurrentThread.CurrentUICulture = currentUICulture;
			}
			this.InitializeComponent();
			this.list_0.Add(this.cbo_1);
			this.list_0.Add(this.cbo_2);
			this.list_0.Add(this.cbo_3);
			this.list_0.Add(this.cbo_4);
			this.list_0.Add(this.cbo_5);
			this.list_0.Add(this.cbo_6);
			this.list_0.Add(this.cbo_7);
			this.list_0.Add(this.cbo_8);
			this.list_0.Add(this.cbo_9);
			this.list_0.Add(this.cbo_10);
			this.list_0.Add(this.cbo_11);
			this.list_0.Add(this.cbo_12);
			this.list_0.Add(this.cbo_13);
			this.list_0.Add(this.cbo_14);
			this.list_0.Add(this.cbo_15);
			this.list_0.Add(this.cbo_16);
			this.list_0.Add(this.cbo_17);
			this.list_0.Add(this.cbo_18);
			this.list_0.Add(this.cbo_19);
			this.list_0.Add(this.cbo_20);
			this.list_0.Add(this.cbo_21);
			this.list_0.Add(this.cbo_22);
			this.list_0.Add(this.cbo_23);
			this.list_0.Add(this.cbo_24);
			this.list_0.Add(this.cbo_25);
			this.list_0.Add(this.cbo_26);
			this.list_0.Add(this.cbo_27);
			this.list_0.Add(this.cbo_28);
			this.list_0.Add(this.cbo_29);
			this.list_0.Add(this.cbo_30);
			this.list_0.Add(this.cbo_31);
			this.list_0.Add(this.cbo_32);
			this.list_0.Add(this.cbo_33);
			this.list_0.Add(this.cbo_34);
			this.list_0.Add(this.cbo_35);
			this.list_0.Add(this.cbo_36);
			this.list_0.Add(this.cbo_37);
			this.list_0.Add(this.cbo_38);
			this.list_0.Add(this.cbo_39);
			this.list_0.Add(this.cbo_40);
			this.list_0.Add(this.cbo_41);
			this.list_0.Add(this.cbo_42);
			this.list_0.Add(this.cbo_43);
			this.list_0.Add(this.cbo_44);
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x000B4670 File Offset: 0x000B2870
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
			toolTip.SetToolTip(this.lblTrongTrot, frmMain.String_682);
			toolTip.SetToolTip(this.lblNgungDanhNgay, frmMain.String_681);
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x000024E9 File Offset: 0x000006E9
		private void frmHotKeys_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00009909 File Offset: 0x00007B09
		private void btnHKClose_Click(object sender, EventArgs e)
		{
			base.Hide();
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x000B46E4 File Offset: 0x000B28E4
		private void btnHKDefault_Click(object sender, EventArgs e)
		{
			if (Class83.list_1.Count > 0)
			{
				bool flag = false;
				for (int i = 0; i < Class83.list_0.Count; i++)
				{
					if (Class83.list_0[i].int_0 == Class83.list_1[i].int_0 && Class83.list_0[i].int_1 != Class83.list_1[i].int_1)
					{
						Class83.list_1[i].int_1 = Class83.list_0[i].int_1;
						Class83.list_1[i].bool_1 = false;
						if (frmLogin.class101_0.class210_0.Count > 0)
						{
							try
							{
								for (int j = frmLogin.class101_0.class210_0.Count - 1; j >= 0; j--)
								{
									frmLogin.class101_0.class210_0[j].method_62(i, Class83.list_0[i].int_1);
								}
								goto IL_1C1;
							}
							catch (Exception)
							{
								goto IL_1C1;
							}
							goto IL_101;
						}
						goto IL_1C1;
						IL_1A5:
						this.list_0[i].EndUpdate();
						flag = true;
						goto IL_1B8;
						IL_101:
						if (this.list_0[i].BackColor != Color.FromArgb(253, 206, 206))
						{
							this.list_0[i].BackColor = Color.FromArgb(253, 206, 206);
							goto IL_1A5;
						}
						goto IL_1A5;
						IL_1C1:
						this.list_0[i].BeginUpdate();
						this.list_0[i].Text = Class83.smethod_1(i + 1);
						if (this.list_0[i].Text == frmMain.String_172)
						{
							goto IL_101;
						}
						if (this.list_0[i].BackColor != Color.FromArgb(206, 233, 253))
						{
							this.list_0[i].BackColor = Color.FromArgb(206, 233, 253);
							goto IL_1A5;
						}
						goto IL_1A5;
					}
					IL_1B8:;
				}
				if (flag)
				{
					Class161.smethod_4("gauto", "hotkey", "", "Hotkey dùng trong auto", null);
				}
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x0000A354 File Offset: 0x00008554
		// (set) Token: 0x060009D6 RID: 2518 RVA: 0x0000A35C File Offset: 0x0000855C
		internal int MyTest { get; set; }

		// Token: 0x060009D7 RID: 2519 RVA: 0x000B4930 File Offset: 0x000B2B30
		private void frmHotKeys_Shown(object sender, EventArgs e)
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			for (int i = 0; i < this.list_0.Count; i++)
			{
				this.list_0[i].BeginUpdate();
				this.list_0[i].Text = Class83.smethod_2(i + 1);
				if (this.list_0[i].Text == frmMain.String_172)
				{
					this.list_0[i].BackColor = Color.FromArgb(253, 206, 206);
				}
				this.list_0[i].EndUpdate();
			}
			this.bool_0 = true;
			stopwatch.Stop();
			stopwatch.Reset();
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x000B49F8 File Offset: 0x000B2BF8
		private void method_2(ComboBox comboBox_0)
		{
			this.int_0 = comboBox_0.SelectedIndex;
			string name = comboBox_0.Name;
			string[] array = comboBox_0.Name.Split(new char[]
			{
				'_'
			});
			int num = 0;
			int.TryParse(array[1], out num);
			if (this.int_0 != 0)
			{
				if (num > 0 && num <= this.list_0.Count)
				{
					int num2 = Class83.list_1[num - 1].int_1;
					int num3 = Class83.smethod_0(comboBox_0.Text);
					if (num3 != num2)
					{
						Class83.list_1[num - 1].int_1 = num3;
						Class83.list_1[num - 1].bool_1 = true;
						comboBox_0.BackColor = Color.FromArgb(206, 233, 253);
						for (int i = 0; i < this.list_0.Count; i++)
						{
							if (i != num - 1 && this.list_0[i].Text == comboBox_0.Text && this.list_0[i].Text != frmMain.String_172)
							{
								this.list_0[i].BeginUpdate();
								this.bool_1 = false;
								this.list_0[i].SelectedIndex = 0;
								this.list_0[i].EndUpdate();
								IL_152:
								Class83.smethod_4();
								this.bool_1 = true;
								return;
							}
						}
						goto IL_152;
					}
				}
			}
			else if (this.int_0 == 0)
			{
				Class83.list_1[num - 1].int_1 = 0;
				Class83.list_1[num - 1].bool_1 = true;
				this.list_0[num - 1].BackColor = Color.FromArgb(253, 206, 206);
				if (this.bool_1)
				{
					Class83.smethod_4();
				}
			}
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x000B4BC8 File Offset: 0x000B2DC8
		private void cbo_44_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.bool_0)
			{
				ComboBox comboBox_ = sender as ComboBox;
				this.method_2(comboBox_);
			}
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x0000997A File Offset: 0x00007B7A
		private void frmHotKeys_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			base.Hide();
		}

		// Token: 0x04000CCA RID: 3274
		private List<ComboBox> list_0 = new List<ComboBox>();

		// Token: 0x04000CCB RID: 3275
		private bool bool_0;

		// Token: 0x04000CCC RID: 3276
		private int int_0;

		// Token: 0x04000CCD RID: 3277
		private bool bool_1 = true;

		// Token: 0x04000CCE RID: 3278
		[CompilerGenerated]
		private int int_1;
	}
}
