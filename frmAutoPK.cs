using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x0200010D RID: 269
	internal sealed partial class frmAutoPK : Form
	{
		// Token: 0x06000AE6 RID: 2790 RVA: 0x0000ACDB File Offset: 0x00008EDB
		internal frmAutoPK()
		{
			frmLogin.smethod_2();
			this.InitializeComponent();
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x000024E9 File Offset: 0x000006E9
		private void frmAutoPK_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x000D28AC File Offset: 0x000D0AAC
		private void btnGroupPlayerExpand_Click(object sender, EventArgs e)
		{
			if (this.class58_0 != null && this.class58_0.class114_0 != null)
			{
				if (!this.class58_0.class114_0.bool_167)
				{
					this.groupPlayers.Height = 191;
					this.class58_0.class114_0.bool_167 = !this.class58_0.class114_0.bool_167;
				}
				else if (this.class58_0.class114_0.bool_167)
				{
					this.groupPlayers.Height = 19;
					this.class58_0.class114_0.bool_167 = !this.class58_0.class114_0.bool_167;
				}
				this.txtPlayerName.Visible = this.class58_0.class114_0.bool_167;
				this.btnAddPlayer.Visible = this.class58_0.class114_0.bool_167;
				this.btnAddPlayerList.Visible = this.class58_0.class114_0.bool_167;
				if (this.class58_0.class114_0.bool_167)
				{
					this.btnGroupPlayerExpand.Image = Class212.collapse;
					return;
				}
				this.btnGroupPlayerExpand.Image = Class212.expand;
			}
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x000D29E4 File Offset: 0x000D0BE4
		private void btnBangExpand_Click(object sender, EventArgs e)
		{
			if (this.class58_0 != null && this.class58_0.class114_0 != null)
			{
				if (!this.class58_0.class114_0.bool_168)
				{
					this.groupIDBang.Height = 191;
					this.class58_0.class114_0.bool_168 = !this.class58_0.class114_0.bool_168;
				}
				else if (this.class58_0.class114_0.bool_168)
				{
					this.groupIDBang.Height = 19;
					this.class58_0.class114_0.bool_168 = !this.class58_0.class114_0.bool_168;
				}
				this.txtIDBang.Visible = this.class58_0.class114_0.bool_168;
				this.btnIDBangAdd.Visible = this.class58_0.class114_0.bool_168;
				if (this.class58_0.class114_0.bool_168)
				{
					this.btnBangExpand.Image = Class212.collapse;
					return;
				}
				this.btnBangExpand.Image = Class212.expand;
			}
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0000997A File Offset: 0x00007B7A
		private void frmAutoPK_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			base.Hide();
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x000D2B00 File Offset: 0x000D0D00
		private void PKAnyOne_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;
			if (this.class58_0 != null && checkBox.Focused)
			{
				this.class58_0.autoSettings_0.cboxPKAnyOne = checkBox.Checked;
			}
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x000D2B3C File Offset: 0x000D0D3C
		private void PKNgaMyFirst_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;
			if (this.class58_0 != null && checkBox.Focused)
			{
				this.class58_0.autoSettings_0.cboxPKNgaMyFirst = checkBox.Checked;
			}
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x000D2B78 File Offset: 0x000D0D78
		private void PKPlayerList_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;
			if (this.class58_0 != null && checkBox.Focused)
			{
				this.class58_0.autoSettings_0.cboxPKPlayerList = checkBox.Checked;
			}
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x000D2BB4 File Offset: 0x000D0DB4
		private void PKBangList_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;
			if (this.class58_0 != null && checkBox.Focused)
			{
				this.class58_0.autoSettings_0.cboxPKBangList = checkBox.Checked;
			}
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x000D2BF0 File Offset: 0x000D0DF0
		private void PKEnable_CheckedChanged(object sender, EventArgs e)
		{
			frmAutoPK.Class181 @class = new frmAutoPK.Class181();
			@class.object_0 = sender;
			@class.eventArgs_0 = e;
			try
			{
				if (this.PKEnable.Focused)
				{
					frmMain.frmMain_0.cboxAutoPK.Invoke(new MethodInvoker(@class.method_0));
				}
			}
			catch (Exception ex)
			{
				Class83.smethod_66("Auto PK [1]: " + ex.Message, this.class58_0, new object[0]);
			}
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x000D2C70 File Offset: 0x000D0E70
		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (this.class58_0 != null)
			{
				if (!this.PKEnable.Focused)
				{
					this.PKEnable.Checked = this.class58_0.autoSettings_0.cboxPKEnable;
				}
				if (!this.PKBangList.Focused)
				{
					this.PKBangList.Checked = this.class58_0.autoSettings_0.cboxPKBangList;
				}
				if (!this.PKPlayerList.Focused)
				{
					this.PKPlayerList.Checked = this.class58_0.autoSettings_0.cboxPKPlayerList;
				}
				if (!this.PKAnyOne.Focused)
				{
					this.PKAnyOne.Checked = this.class58_0.autoSettings_0.cboxPKAnyOne;
				}
				if (!this.PKNgaMyFirst.Focused)
				{
					this.PKNgaMyFirst.Checked = this.class58_0.autoSettings_0.cboxPKNgaMyFirst;
				}
				if (!this.PKThieuLamLast.Focused)
				{
					this.PKThieuLamLast.Checked = this.class58_0.autoSettings_0.cboxPKThieuLamLast;
				}
				if (!this.cboxBlacklist.Focused)
				{
					this.cboxBlacklist.Checked = this.class58_0.autoSettings_0.cboxBlacklist;
				}
				this.lvIDBang.BeginUpdate();
				int num = 0;
				int num2 = 0;
				if (this.lvIDBang.Items.Count == 0)
				{
					num = this.class58_0.autoSettings_0.PKBangList.Count;
				}
				else if (this.lvIDBang.Items.Count > this.class58_0.autoSettings_0.PKBangList.Count)
				{
					num2 = this.lvIDBang.Items.Count - this.class58_0.autoSettings_0.PKBangList.Count;
					num = 0;
				}
				else if (this.lvIDBang.Items.Count < this.class58_0.autoSettings_0.PKBangList.Count)
				{
					num2 = 0;
					num = this.class58_0.autoSettings_0.PKBangList.Count - this.lvIDBang.Items.Count;
				}
				List<int> list = new List<int>();
				if (num > 0)
				{
					this.lvIDBang.Items.Clear();
					ListViewItem[] array = new ListViewItem[num];
					int num3 = 0;
					try
					{
						for (int i = this.class58_0.autoSettings_0.PKBangList.Count - 1; i >= 0; i--)
						{
							int num4 = this.class58_0.autoSettings_0.PKBangList[i];
							bool flag = false;
							foreach (object obj in this.lvIDBang.Items)
							{
								ListViewItem listViewItem = (ListViewItem)obj;
								if (num4.ToString() == listViewItem.Text)
								{
									flag = true;
									break;
								}
							}
							if (!flag)
							{
								array[num3] = new ListViewItem();
								array[num3].Text = num4.ToString();
								num3++;
							}
						}
						this.lvIDBang.Items.AddRange(array);
						goto IL_3FE;
					}
					catch (Exception)
					{
						goto IL_3FE;
					}
				}
				if (num2 > 0)
				{
					try
					{
						List<ListViewItem> list2 = new List<ListViewItem>();
						int j = this.lvIDBang.Items.Count - 1;
						IL_3B6:
						while (j >= 0)
						{
							ListViewItem listViewItem2 = this.lvIDBang.Items[j];
							bool flag2 = false;
							for (int k = this.class58_0.autoSettings_0.PKBangList.Count - 1; k >= 0; k--)
							{
								if (this.class58_0.autoSettings_0.PKBangList[k].ToString() == listViewItem2.Text)
								{
									flag2 = true;
									IL_3A3:
									if (!flag2)
									{
										list2.Add(listViewItem2);
									}
									j--;
									goto IL_3B6;
								}
							}
							goto IL_3A3;
						}
						if (list2.Count > 0)
						{
							for (int l = list2.Count - 1; l >= 0; l--)
							{
								this.lvIDBang.Items.Remove(list2[l]);
							}
						}
					}
					catch (Exception)
					{
					}
				}
				IL_3FE:
				if (this.class58_0.autoSettings_0.PKBangList.Count > 0 && this.class58_0.autoSettings_0.PKBangList.Count == this.lvIDBang.Items.Count)
				{
					for (int m = 0; m < this.lvIDBang.Items.Count; m++)
					{
						this.lvIDBang.Items[m].Text = this.class58_0.autoSettings_0.PKBangList[m].ToString();
					}
				}
				this.lvIDBang.EndUpdate();
				this.lvPlayers.BeginUpdate();
				num = 0;
				num2 = 0;
				if (this.lvPlayers.Items.Count == 0)
				{
					num = this.class58_0.autoSettings_0.PKPlayerList.Count;
				}
				else if (this.lvPlayers.Items.Count > this.class58_0.autoSettings_0.PKPlayerList.Count)
				{
					num2 = this.lvPlayers.Items.Count - this.class58_0.autoSettings_0.PKPlayerList.Count;
					num = 0;
				}
				else if (this.lvPlayers.Items.Count < this.class58_0.autoSettings_0.PKPlayerList.Count)
				{
					num2 = 0;
					num = this.class58_0.autoSettings_0.PKPlayerList.Count - this.lvPlayers.Items.Count;
				}
				list.Clear();
				if (num > 0)
				{
					this.lvPlayers.Items.Clear();
					ListViewItem[] array2 = new ListViewItem[num];
					int num5 = 0;
					try
					{
						for (int n = this.class58_0.autoSettings_0.PKPlayerList.Count - 1; n >= 0; n--)
						{
							string text = this.class58_0.autoSettings_0.PKPlayerList[n];
							bool flag3 = false;
							foreach (object obj2 in this.lvPlayers.Items)
							{
								ListViewItem listViewItem3 = (ListViewItem)obj2;
								if (text == listViewItem3.Text)
								{
									flag3 = true;
									break;
								}
							}
							if (!flag3)
							{
								array2[num5] = new ListViewItem();
								array2[num5].Text = text;
								num5++;
							}
						}
						this.lvPlayers.Items.AddRange(array2);
						goto IL_764;
					}
					catch (Exception)
					{
						goto IL_764;
					}
				}
				if (num2 > 0)
				{
					try
					{
						List<ListViewItem> list3 = new List<ListViewItem>();
						int num6 = this.lvPlayers.Items.Count - 1;
						IL_71F:
						while (num6 >= 0)
						{
							ListViewItem listViewItem4 = this.lvPlayers.Items[num6];
							bool flag4 = false;
							for (int num7 = this.class58_0.autoSettings_0.PKPlayerList.Count - 1; num7 >= 0; num7--)
							{
								if (this.class58_0.autoSettings_0.PKPlayerList[num7] == listViewItem4.Text)
								{
									flag4 = true;
									IL_70C:
									if (!flag4)
									{
										list3.Add(listViewItem4);
									}
									num6--;
									goto IL_71F;
								}
							}
							goto IL_70C;
						}
						if (list3.Count > 0)
						{
							for (int num8 = list3.Count - 1; num8 >= 0; num8--)
							{
								this.lvPlayers.Items.Remove(list3[num8]);
							}
						}
					}
					catch (Exception)
					{
					}
				}
				IL_764:
				if (this.class58_0.autoSettings_0.PKPlayerList.Count > 0 && this.class58_0.autoSettings_0.PKPlayerList.Count == this.lvPlayers.Items.Count)
				{
					for (int num9 = 0; num9 < this.lvPlayers.Items.Count; num9++)
					{
						this.lvPlayers.Items[num9].Text = this.class58_0.autoSettings_0.PKPlayerList[num9];
					}
				}
				this.lvPlayers.EndUpdate();
				this.lvBlacklist.BeginUpdate();
				num = 0;
				num2 = 0;
				if (this.lvBlacklist.Items.Count == 0)
				{
					num = this.class58_0.autoSettings_0.PKBlackList.Count;
				}
				else if (this.lvBlacklist.Items.Count > this.class58_0.autoSettings_0.PKBlackList.Count)
				{
					num2 = this.lvBlacklist.Items.Count - this.class58_0.autoSettings_0.PKBlackList.Count;
					num = 0;
				}
				else if (this.lvBlacklist.Items.Count < this.class58_0.autoSettings_0.PKBlackList.Count)
				{
					num2 = 0;
					num = this.class58_0.autoSettings_0.PKBlackList.Count - this.lvBlacklist.Items.Count;
				}
				list.Clear();
				if (num > 0)
				{
					this.lvBlacklist.Items.Clear();
					ListViewItem[] array3 = new ListViewItem[num];
					int num10 = 0;
					try
					{
						for (int num11 = this.class58_0.autoSettings_0.PKBlackList.Count - 1; num11 >= 0; num11--)
						{
							string text2 = this.class58_0.autoSettings_0.PKBlackList[num11];
							bool flag5 = false;
							foreach (object obj3 in this.lvBlacklist.Items)
							{
								ListViewItem listViewItem5 = (ListViewItem)obj3;
								if (text2 == listViewItem5.Text)
								{
									flag5 = true;
									break;
								}
							}
							if (!flag5)
							{
								array3[num10] = new ListViewItem();
								array3[num10].Text = text2;
								num10++;
							}
						}
						this.lvBlacklist.Items.AddRange(array3);
						goto IL_AC1;
					}
					catch (Exception)
					{
						goto IL_AC1;
					}
				}
				if (num2 > 0)
				{
					try
					{
						List<ListViewItem> list4 = new List<ListViewItem>();
						int num12 = this.lvBlacklist.Items.Count - 1;
						IL_A7C:
						while (num12 >= 0)
						{
							ListViewItem listViewItem6 = this.lvBlacklist.Items[num12];
							bool flag6 = false;
							for (int num13 = this.class58_0.autoSettings_0.PKBlackList.Count - 1; num13 >= 0; num13--)
							{
								if (this.class58_0.autoSettings_0.PKBlackList[num13] == listViewItem6.Text)
								{
									flag6 = true;
									IL_A69:
									if (!flag6)
									{
										list4.Add(listViewItem6);
									}
									num12--;
									goto IL_A7C;
								}
							}
							goto IL_A69;
						}
						if (list4.Count > 0)
						{
							for (int num14 = list4.Count - 1; num14 >= 0; num14--)
							{
								this.lvBlacklist.Items.Remove(list4[num14]);
							}
						}
					}
					catch (Exception)
					{
					}
				}
				IL_AC1:
				if (this.class58_0.autoSettings_0.PKBlackList.Count > 0 && this.class58_0.autoSettings_0.PKBlackList.Count == this.lvBlacklist.Items.Count)
				{
					for (int num15 = 0; num15 < this.lvBlacklist.Items.Count; num15++)
					{
						this.lvBlacklist.Items[num15].Text = this.class58_0.autoSettings_0.PKBlackList[num15];
					}
				}
				this.lvBlacklist.EndUpdate();
			}
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x000D3848 File Offset: 0x000D1A48
		private void btnIDBangAdd_Click(object sender, EventArgs e)
		{
			if (this.class58_0 != null && !string.IsNullOrEmpty(this.txtIDBang.Text))
			{
				int num = -1;
				int.TryParse(this.txtIDBang.Text, out num);
				if (num != -1 && !this.class58_0.autoSettings_0.PKBangList.Contains(num))
				{
					this.class58_0.autoSettings_0.PKBangList.method_1(num);
				}
				this.txtIDBang.Text = "";
			}
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x000D38C8 File Offset: 0x000D1AC8
		private void btnAddPlayer_Click(object sender, EventArgs e)
		{
			if (this.class58_0 != null && !string.IsNullOrEmpty(this.txtPlayerName.Text))
			{
				string text = this.txtPlayerName.Text;
				if (!this.class58_0.autoSettings_0.PKPlayerList.Contains(text))
				{
					this.class58_0.autoSettings_0.PKPlayerList.method_1(text);
				}
				this.txtPlayerName.Text = "";
			}
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x000D393C File Offset: 0x000D1B3C
		private void lvPlayers_DoubleClick(object sender, EventArgs e)
		{
			ListView listView = sender as ListView;
			if (listView.SelectedItems.Count > 0)
			{
				ListViewItem listViewItem = listView.SelectedItems[0];
				if (this.class58_0 != null && !string.IsNullOrEmpty(listViewItem.Text))
				{
					this.class58_0.autoSettings_0.PKPlayerList.method_0(listViewItem.Text);
				}
			}
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x000D399C File Offset: 0x000D1B9C
		private void lvIDBang_DoubleClick(object sender, EventArgs e)
		{
			ListView listView = sender as ListView;
			if (listView.SelectedItems.Count > 0)
			{
				ListViewItem listViewItem = listView.SelectedItems[0];
				if (this.class58_0 != null && !string.IsNullOrEmpty(listViewItem.Text))
				{
					this.class58_0.autoSettings_0.PKBangList.method_0(int.Parse(listViewItem.Text));
				}
			}
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x0000ACEE File Offset: 0x00008EEE
		private void btnAddPlayerList_Click(object sender, EventArgs e)
		{
			if (this.class58_0 != null)
			{
				new frmItemList
				{
					int_0 = 8,
					class58_0 = this.class58_0
				}.Show();
			}
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x0000AD15 File Offset: 0x00008F15
		private void btnPKHotKey_Click(object sender, EventArgs e)
		{
			frmMain.smethod_39();
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x000D3A00 File Offset: 0x000D1C00
		private void btnGroupBlacklistExpand_Click(object sender, EventArgs e)
		{
			if (this.class58_0 != null && this.class58_0.class114_0 != null)
			{
				if (!this.class58_0.class114_0.bool_170)
				{
					this.groupBlackList.Height = 182;
					this.class58_0.class114_0.bool_170 = !this.class58_0.class114_0.bool_170;
				}
				else if (this.class58_0.class114_0.bool_170)
				{
					this.groupBlackList.Height = 19;
					this.class58_0.class114_0.bool_170 = !this.class58_0.class114_0.bool_170;
				}
				this.txtBlacklistName.Visible = this.class58_0.class114_0.bool_170;
				this.btnBlacklistAdd.Visible = this.class58_0.class114_0.bool_170;
				this.btnBlacklist.Visible = this.class58_0.class114_0.bool_170;
				if (this.class58_0.class114_0.bool_170)
				{
					this.btnGroupBlacklistExpand.Image = Class212.collapse;
					return;
				}
				this.btnGroupBlacklistExpand.Image = Class212.expand;
			}
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x0000AD1C File Offset: 0x00008F1C
		private void btnBlacklist_Click(object sender, EventArgs e)
		{
			if (this.class58_0 != null)
			{
				new frmItemList
				{
					int_0 = 9,
					class58_0 = this.class58_0
				}.Show();
			}
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x000D3B38 File Offset: 0x000D1D38
		private void btnBlacklistAdd_Click(object sender, EventArgs e)
		{
			if (this.class58_0 != null && !string.IsNullOrEmpty(this.txtBlacklistName.Text))
			{
				string text = this.txtBlacklistName.Text;
				if (!this.class58_0.autoSettings_0.PKBlackList.Contains(text))
				{
					this.class58_0.autoSettings_0.PKBlackList.method_1(text);
				}
				this.txtBlacklistName.Text = "";
			}
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x000D3BAC File Offset: 0x000D1DAC
		private void lvBlacklist_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			ListView listView = sender as ListView;
			if (listView.SelectedItems.Count > 0)
			{
				ListViewItem listViewItem = listView.SelectedItems[0];
				if (this.class58_0 != null && !string.IsNullOrEmpty(listViewItem.Text))
				{
					this.class58_0.autoSettings_0.PKBlackList.method_0(listViewItem.Text);
				}
			}
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x000D3C0C File Offset: 0x000D1E0C
		private void cboxBlacklist_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;
			if (this.class58_0 != null && checkBox.Focused)
			{
				this.class58_0.autoSettings_0.cboxBlacklist = checkBox.Checked;
			}
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0000AD44 File Offset: 0x00008F44
		private void frmAutoPK_Shown(object sender, EventArgs e)
		{
			this.btnPKHotKey.Focus();
			this.method_0();
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x000D3C48 File Offset: 0x000D1E48
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
			toolTip.SetToolTip(this.PKEnable, frmMain.String_709);
			toolTip.SetToolTip(this.cboxBlacklist, frmMain.String_710);
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x000D3CBC File Offset: 0x000D1EBC
		private void PKThieuLamLast_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;
			if (this.class58_0 != null && checkBox.Focused)
			{
				this.class58_0.autoSettings_0.cboxPKThieuLamLast = checkBox.Checked;
			}
		}

		// Token: 0x04000F6B RID: 3947
		internal Class58 class58_0;

		// Token: 0x0200010E RID: 270
		[CompilerGenerated]
		private sealed class Class181
		{
			// Token: 0x06000B02 RID: 2818 RVA: 0x0000AD77 File Offset: 0x00008F77
			internal void method_0()
			{
				frmMain.frmMain_0.cboxAutoPK.Focus();
				frmMain.frmMain_0.cboxAutoPK_CheckedChanged(this.object_0, this.eventArgs_0);
			}

			// Token: 0x04000F8B RID: 3979
			public object object_0;

			// Token: 0x04000F8C RID: 3980
			public EventArgs eventArgs_0;
		}
	}
}
