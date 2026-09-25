using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x020000F7 RID: 247
	internal sealed partial class frmPlayerPick : Form
	{
		// Token: 0x060009AD RID: 2477 RVA: 0x0000A1F8 File Offset: 0x000083F8
		internal frmPlayerPick()
		{
			this.InitializeComponent();
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x000024E9 File Offset: 0x000006E9
		private void frmPlayerPick_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x0000A206 File Offset: 0x00008406
		private void btnXoaName_Click(object sender, EventArgs e)
		{
			if (this.class58_0 != null)
			{
				this.txtPlayerName.Focus();
				this.lvPlayerList.SelectedItems.Clear();
				this.txtPlayerName.Text = "";
			}
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x000B1B38 File Offset: 0x000AFD38
		private void method_0(object sender, EventArgs e)
		{
			if (this.class58_0 != null)
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				if (openFileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(openFileDialog.FileName))
				{
					StreamReader streamReader = new StreamReader(openFileDialog.FileName);
					if (streamReader != null)
					{
						while (!streamReader.EndOfStream)
						{
							string text = streamReader.ReadLine();
							if (!string.IsNullOrEmpty(text))
							{
								if (this.int_0 == 0)
								{
									if (!frmLogin.class101_0.globalSettings_0.BuffNameList.Contains(text))
									{
										frmLogin.class101_0.globalSettings_0.BuffNameList.method_1(text);
									}
								}
								else if (this.int_0 == 1)
								{
									if (!frmLogin.class101_0.globalSettings_0.ItemTuHuyList.Contains(text))
									{
										frmLogin.class101_0.globalSettings_0.ItemTuHuyList.method_1(text);
									}
								}
								else if (this.int_0 == 2)
								{
									if (!frmLogin.class101_0.globalSettings_0.ItemBanList.Contains(text))
									{
										frmLogin.class101_0.globalSettings_0.ItemBanList.method_1(text);
									}
								}
								else if (this.int_0 == 3)
								{
									if (!this.class58_0.autoSettings_0.AutoPartyList.Contains(text))
									{
										this.class58_0.autoSettings_0.AutoPartyList.method_1(text);
									}
								}
								else if (this.int_0 == 4)
								{
									if (!this.class58_0.autoSettings_0.PTBlacklist.Contains(text))
									{
										this.class58_0.autoSettings_0.PTBlacklist.method_1(text);
									}
								}
								else
								{
									if (this.int_0 == 5)
									{
										if (frmLogin.class101_0.globalSettings_0.ListItemNhat.Contains(text))
										{
											continue;
										}
										object object_ = frmLogin.object_5;
										lock (object_)
										{
											frmLogin.class101_0.globalSettings_0.ListItemNhat.method_1(text);
											continue;
										}
									}
									if (this.int_0 == 6 && !this.class58_0.autoSettings_0.PKPlayerList.Contains(text))
									{
										this.class58_0.autoSettings_0.PKPlayerList.method_1(text);
									}
								}
							}
						}
						streamReader.Close();
					}
				}
			}
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x000B1D74 File Offset: 0x000AFF74
		private void lvPlayerList_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			ListView listView = sender as ListView;
			if (listView.SelectedItems.Count > 0)
			{
				ListViewItem listViewItem = listView.SelectedItems[0];
				if (this.class58_0 != null && !string.IsNullOrEmpty(listViewItem.Text))
				{
					switch (this.int_0)
					{
					case 0:
						frmLogin.class101_0.globalSettings_0.BuffNameList.method_0(listViewItem.Text);
						return;
					case 1:
						frmLogin.class101_0.globalSettings_0.ItemTuHuyList.method_0(listViewItem.Text);
						return;
					case 2:
						frmLogin.class101_0.globalSettings_0.ItemBanList.method_0(listViewItem.Text);
						return;
					case 3:
						this.class58_0.autoSettings_0.AutoPartyList.method_0(listViewItem.Text);
						return;
					case 4:
						this.class58_0.autoSettings_0.PTBlacklist.method_0(listViewItem.Text);
						return;
					case 5:
					{
						object object_ = frmLogin.object_5;
						lock (object_)
						{
							frmLogin.class101_0.globalSettings_0.ListItemNhat.method_0(listViewItem.Text);
							return;
						}
						break;
					}
					case 6:
						break;
					default:
						return;
					}
					this.class58_0.autoSettings_0.PKPlayerList.method_0(listViewItem.Text);
				}
			}
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x0000A23C File Offset: 0x0000843C
		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (this.class58_0 != null)
			{
				frmMain.smethod_31(this.class58_0, this.lvPlayerList, null);
			}
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00009DBC File Offset: 0x00007FBC
		private void btnClose_Click(object sender, EventArgs e)
		{
			base.Close();
			base.Dispose();
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x000B1ED0 File Offset: 0x000B00D0
		private void frmPlayerPick_Shown(object sender, EventArgs e)
		{
			int num = this.int_0;
			if (num == 0)
			{
				this.lblTop.Text = frmMain.String_358;
				this.lvPlayerList.Columns[0].Text = frmMain.String_357;
				this.Text = frmMain.String_356;
				return;
			}
			if (num != 1)
			{
				return;
			}
			this.lblTop.Text = frmMain.String_355;
			this.lvPlayerList.Columns[0].Text = frmMain.String_357;
			this.Text = frmMain.String_354;
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x000B1F5C File Offset: 0x000B015C
		private void txtPlayerName_TextChanged(object sender, EventArgs e)
		{
			if (this.class58_0 != null)
			{
				if (this.int_0 == 0)
				{
					this.class58_0.autoSettings_0.txtDanhTheoAi = this.txtPlayerName.Text;
					return;
				}
				if (this.int_0 == 1)
				{
					this.class58_0.autoSettings_0.txtTheoSauName = this.txtPlayerName.Text;
				}
			}
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x000B1FBC File Offset: 0x000B01BC
		private void lvPlayerList_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListView listView = sender as ListView;
			if (listView.SelectedItems.Count > 0)
			{
				ListViewItem listViewItem = listView.SelectedItems[0];
				if (listViewItem.Text != "")
				{
					this.txtPlayerName.Text = listViewItem.Text;
				}
			}
		}

		// Token: 0x04000CA4 RID: 3236
		internal Class58 class58_0;

		// Token: 0x04000CA5 RID: 3237
		internal int int_0;
	}
}
