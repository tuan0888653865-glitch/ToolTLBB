using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x020000F8 RID: 248
	internal sealed partial class frmBuffList : Form
	{
		// Token: 0x060009BA RID: 2490 RVA: 0x0000A277 File Offset: 0x00008477
		internal frmBuffList()
		{
			this.InitializeComponent();
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x000024E9 File Offset: 0x000006E9
		private void frmBuffList_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x0000A293 File Offset: 0x00008493
		private void btnAddName_Click(object sender, EventArgs e)
		{
			this.method_0();
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x000B2398 File Offset: 0x000B0598
		private void method_0()
		{
			if (this.class58_0 != null && !string.IsNullOrEmpty(this.cboItemName.Text))
			{
				string text = this.cboItemName.Text;
				if (text.Contains("~"))
				{
					string[] array = text.Split(new char[]
					{
						'~'
					});
					if (array.Length >= 2)
					{
						text = array[1];
					}
				}
				if (this.int_0 == 0)
				{
					if (!frmLogin.class101_0.globalSettings_0.BuffNameList.Contains(text))
					{
						frmLogin.class101_0.globalSettings_0.BuffNameList.method_1(text);
					}
				}
				else if (this.int_0 == 1)
				{
					int num = 0;
					int.TryParse(text, out num);
					if (!text.Contains(" ") && !text.Contains("hài") && !text.Contains("mão") && num <= 0)
					{
						if (!text.Contains(" "))
						{
							bool flag = false;
							for (int i = 0; i < 60; i++)
							{
								Class113 @class = this.class58_0.class112_0.list_1[i];
								string b = "";
								string text2 = "";
								Class83.smethod_130(@class.int_0, out b, out text2);
								if (text == b)
								{
									flag = true;
									if (!frmLogin.class101_0.globalSettings_0.ItemTuHuyList.Contains(@class.int_0.ToString()))
									{
										frmLogin.class101_0.globalSettings_0.ItemTuHuyList.method_1(@class.int_0.ToString());
										IL_189:
										if (!flag)
										{
											Class83.smethod_58(string.Format(frmMain.String_790, text), frmMain.String_784, this.class58_0, 10000, new object[0]);
											goto IL_469;
										}
										goto IL_469;
									}
								}
							}
							goto IL_189;
						}
					}
					else if (!frmLogin.class101_0.globalSettings_0.ItemTuHuyList.Contains(text.ToLower()))
					{
						frmLogin.class101_0.globalSettings_0.ItemTuHuyList.method_1(text.ToLower());
					}
				}
				else if (this.int_0 == 2)
				{
					if (!frmLogin.class101_0.globalSettings_0.ItemBanList.Contains(text.ToLower()))
					{
						frmLogin.class101_0.globalSettings_0.ItemBanList.method_1(text.ToLower());
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
						if (frmLogin.class101_0.globalSettings_0.ListItemNhat.Contains(text.ToLower()))
						{
							goto IL_469;
						}
						object object_ = frmLogin.object_5;
						lock (object_)
						{
							frmLogin.class101_0.globalSettings_0.ListItemNhat.method_1(text.ToLower());
							goto IL_469;
						}
					}
					if (this.int_0 == 6)
					{
						if (!frmLogin.class101_0.globalSettings_0.ListBuffPetID.Contains(text))
						{
							frmLogin.class101_0.globalSettings_0.ListBuffPetID.method_1(text);
						}
					}
					else if (this.int_0 == 7)
					{
						if (!this.class58_0.autoSettings_0.QuaiNoAttackList.Contains(text))
						{
							this.class58_0.autoSettings_0.QuaiNoAttackList.method_1(text);
						}
					}
					else if (this.int_0 == 8)
					{
						if (!this.class58_0.autoSettings_0.PKPlayerList.Contains(text))
						{
							this.class58_0.autoSettings_0.PKPlayerList.method_1(text);
						}
					}
					else if (this.int_0 == 9)
					{
						if (!this.class58_0.autoSettings_0.PKBlackList.Contains(text))
						{
							this.class58_0.autoSettings_0.PKBlackList.method_1(text);
						}
					}
					else if (this.int_0 == 10 && !this.class58_0.autoSettings_0.ListItemNhatIgnore.Contains(text.ToLower()))
					{
						object object_ = frmLogin.object_5;
						lock (object_)
						{
							this.class58_0.autoSettings_0.ListItemNhatIgnore.method_1(text.ToLower());
						}
					}
				}
				IL_469:
				this.cboItemName.Text = "";
			}
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x000B283C File Offset: 0x000B0A3C
		private void btnDanhSachBuff_Click(object sender, EventArgs e)
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
							if (!string.IsNullOrEmpty(text) && !text.StartsWith("#"))
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
									if (!frmLogin.class101_0.globalSettings_0.ItemTuHuyList.Contains(text.ToLower()))
									{
										frmLogin.class101_0.globalSettings_0.ItemTuHuyList.method_1(text.ToLower());
									}
								}
								else if (this.int_0 == 2)
								{
									if (!frmLogin.class101_0.globalSettings_0.ItemBanList.Contains(text.ToLower()))
									{
										frmLogin.class101_0.globalSettings_0.ItemBanList.method_1(text.ToLower());
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
										if (frmLogin.class101_0.globalSettings_0.ListItemNhat.Contains(text.ToLower()))
										{
											continue;
										}
										object object_ = frmLogin.object_5;
										lock (object_)
										{
											frmLogin.class101_0.globalSettings_0.ListItemNhat.method_1(text.ToLower());
											continue;
										}
									}
									if (this.int_0 == 6)
									{
										if (!frmLogin.class101_0.globalSettings_0.ListBuffPetID.Contains(text))
										{
											frmLogin.class101_0.globalSettings_0.ListBuffPetID.method_1(text);
										}
									}
									else if (this.int_0 == 7)
									{
										if (!this.class58_0.autoSettings_0.QuaiNoAttackList.Contains(text))
										{
											this.class58_0.autoSettings_0.QuaiNoAttackList.method_1(text);
										}
									}
									else if (this.int_0 == 8)
									{
										if (!this.class58_0.autoSettings_0.PKPlayerList.Contains(text))
										{
											this.class58_0.autoSettings_0.PKPlayerList.method_1(text);
										}
									}
									else if (this.int_0 == 9)
									{
										if (!this.class58_0.autoSettings_0.PKBlackList.Contains(text))
										{
											this.class58_0.autoSettings_0.PKBlackList.method_1(text);
										}
									}
									else if (this.int_0 == 10 && !this.class58_0.autoSettings_0.ListItemNhatIgnore.Contains(text.ToLower()))
									{
										object object_ = frmLogin.object_5;
										lock (object_)
										{
											this.class58_0.autoSettings_0.ListItemNhatIgnore.method_1(text.ToLower());
										}
									}
								}
							}
						}
						streamReader.Close();
					}
				}
			}
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x000B2BCC File Offset: 0x000B0DCC
		private void lvBuffList_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			ListView listView_ = sender as ListView;
			this.method_1(listView_);
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x000B2BE8 File Offset: 0x000B0DE8
		private void method_1(ListView listView_0)
		{
			if (listView_0.SelectedItems.Count > 0)
			{
				ListViewItem listViewItem = listView_0.SelectedItems[0];
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
					case 7:
						this.class58_0.autoSettings_0.QuaiNoAttackList.method_0(listViewItem.Text);
						return;
					case 8:
						this.class58_0.autoSettings_0.PKPlayerList.method_0(listViewItem.Text);
						return;
					case 9:
						this.class58_0.autoSettings_0.PKBlackList.method_0(listViewItem.Text);
						return;
					case 10:
					{
						object object_ = frmLogin.object_5;
						lock (object_)
						{
							this.class58_0.autoSettings_0.ListItemNhatIgnore.method_0(listViewItem.Text);
						}
						return;
					}
					default:
						return;
					}
					frmLogin.class101_0.globalSettings_0.ListBuffPetID.method_0(listViewItem.Text);
					return;
				}
			}
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x000B2DE0 File Offset: 0x000B0FE0
		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (this.class58_0 != null)
			{
				if (this.int_0 == 0)
				{
					frmMain.smethod_5(frmLogin.class101_0.globalSettings_0.BuffNameList, this.lvBuffList);
					if (this.bool_1 || this.bool_2)
					{
						frmMain.smethod_31(this.class58_0, this.lvPlayers, frmLogin.class101_0.globalSettings_0.BuffNameList);
						this.bool_1 = false;
					}
					this.method_2();
				}
				else if (this.int_0 == 1)
				{
					frmMain.smethod_5(frmLogin.class101_0.globalSettings_0.ItemTuHuyList, this.lvBuffList);
				}
				else if (this.int_0 == 2)
				{
					frmMain.smethod_5(frmLogin.class101_0.globalSettings_0.ItemBanList, this.lvBuffList);
				}
				else if (this.int_0 == 3)
				{
					frmMain.smethod_5(this.class58_0.autoSettings_0.AutoPartyList, this.lvBuffList);
					if (this.bool_1 || this.bool_2)
					{
						frmMain.smethod_31(this.class58_0, this.lvPlayers, this.class58_0.autoSettings_0.AutoPartyList);
					}
					this.method_2();
				}
				else if (this.int_0 == 4)
				{
					frmMain.smethod_5(this.class58_0.autoSettings_0.PTBlacklist, this.lvBuffList);
					if (this.bool_1 || this.bool_2)
					{
						frmMain.smethod_31(this.class58_0, this.lvPlayers, this.class58_0.autoSettings_0.PTBlacklist);
						this.bool_1 = false;
					}
					this.method_2();
				}
				else if (this.int_0 == 5)
				{
					frmMain.smethod_5(frmLogin.class101_0.globalSettings_0.ListItemNhat, this.lvBuffList);
				}
				else if (this.int_0 == 6)
				{
					frmMain.smethod_5(frmLogin.class101_0.globalSettings_0.ListBuffPetID, this.lvBuffList);
					if (this.bool_1 || this.bool_2)
					{
						frmMain.smethod_30(this.class58_0, this.lvPlayers, frmLogin.class101_0.globalSettings_0.ListBuffPetID);
						this.bool_1 = false;
					}
					this.method_2();
				}
				else if (this.int_0 == 7)
				{
					frmMain.smethod_5(this.class58_0.autoSettings_0.QuaiNoAttackList, this.lvBuffList);
				}
				else if (this.int_0 == 8)
				{
					frmMain.smethod_5(this.class58_0.autoSettings_0.PKPlayerList, this.lvBuffList);
					if (this.bool_1 || this.bool_2)
					{
						frmMain.smethod_31(this.class58_0, this.lvPlayers, this.class58_0.autoSettings_0.PKPlayerList);
						this.bool_1 = false;
					}
					this.method_2();
				}
				else if (this.int_0 == 9)
				{
					frmMain.smethod_5(this.class58_0.autoSettings_0.PKBlackList, this.lvBuffList);
					if (this.bool_1 || this.bool_2)
					{
						frmMain.smethod_31(this.class58_0, this.lvPlayers, this.class58_0.autoSettings_0.PKBlackList);
						this.bool_1 = false;
					}
					this.method_2();
				}
				else if (this.int_0 == 10)
				{
					frmMain.smethod_5(this.class58_0.autoSettings_0.ListItemNhatIgnore, this.lvBuffList);
				}
				if (this.lvBuffList.SelectedItems.Count > 0)
				{
					this.btnRemove.Enabled = true;
				}
				else
				{
					this.btnRemove.Enabled = false;
				}
				if (this.lvPlayers.SelectedItems.Count > 0)
				{
					this.btnAdd.Enabled = true;
					return;
				}
				this.btnAdd.Enabled = false;
			}
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x0000A29B File Offset: 0x0000849B
		private void method_2()
		{
			if (!this.bool_0)
			{
				this.btnRemove.Visible = true;
				this.btnAdd.Visible = true;
				base.Width = 399;
				this.bool_0 = true;
			}
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00009DBC File Offset: 0x00007FBC
		private void btnClose_Click(object sender, EventArgs e)
		{
			base.Close();
			base.Dispose();
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x000B3174 File Offset: 0x000B1374
		private void frmBuffList_Shown(object sender, EventArgs e)
		{
			switch (this.int_0)
			{
			case 0:
				this.lblTop.Text = frmMain.String_313;
				this.lvBuffList.Columns[0].Text = frmMain.String_357;
				this.Text = frmMain.String_312;
				return;
			case 1:
				this.lblTop.Text = frmMain.String_311;
				this.lvBuffList.Columns[0].Text = frmMain.String_310;
				this.Text = frmMain.String_309;
				return;
			case 2:
				this.lblTop.Text = frmMain.String_308;
				this.lvBuffList.Columns[0].Text = frmMain.String_307;
				this.Text = frmMain.String_306;
				return;
			case 3:
				this.lblTop.Text = frmMain.String_305;
				this.lvBuffList.Columns[0].Text = frmMain.String_304;
				this.Text = frmMain.String_303;
				return;
			case 4:
				this.lblTop.Text = frmMain.String_302;
				this.lvBuffList.Columns[0].Text = frmMain.String_301;
				this.Text = frmMain.String_300;
				return;
			case 5:
				this.lblTop.Text = frmMain.String_299;
				this.lvBuffList.Columns[0].Text = frmMain.String_298;
				this.Text = frmMain.String_297;
				return;
			case 6:
				this.lblTop.Text = frmMain.String_296;
				this.lvBuffList.Columns[0].Text = frmMain.String_295;
				this.Text = frmMain.String_294;
				return;
			case 7:
				this.lblTop.Text = frmMain.String_291;
				this.lvBuffList.Columns[0].Text = frmMain.String_289;
				this.Text = frmMain.String_286;
				return;
			case 8:
				this.lblTop.Text = frmMain.String_293;
				this.lvBuffList.Columns[0].Text = frmMain.String_290;
				this.Text = frmMain.String_287;
				return;
			case 9:
				this.lblTop.Text = frmMain.String_292;
				this.lvBuffList.Columns[0].Text = frmMain.String_290;
				this.Text = frmMain.String_288;
				return;
			case 10:
				this.lblTop.Text = frmMain.String_743;
				this.lvBuffList.Columns[0].Text = frmMain.String_744;
				this.Text = frmMain.String_745;
				return;
			default:
				return;
			}
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x000B3418 File Offset: 0x000B1618
		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (this.lvPlayers.SelectedItems.Count > 0)
			{
				foreach (object obj in this.lvPlayers.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					this.cboItemName.Text = listViewItem.Text;
					this.method_0();
				}
			}
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x0000A2CF File Offset: 0x000084CF
		private void btnRemove_Click(object sender, EventArgs e)
		{
			this.method_1(this.lvBuffList);
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x0000A2DD File Offset: 0x000084DD
		private void lvPlayers_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (this.lvPlayers.SelectedItems.Count > 0)
			{
				this.cboItemName.Text = this.lvPlayers.SelectedItems[0].Text;
				this.method_0();
			}
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x000024E9 File Offset: 0x000006E9
		private void lvBuffList_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x000B349C File Offset: 0x000B169C
		private void btnSaveList_Click(object sender, EventArgs e)
		{
			if (this.class58_0 != null)
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				if (saveFileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(saveFileDialog.FileName))
				{
					if (!saveFileDialog.FileName.Contains("."))
					{
						saveFileDialog.FileName += ".txt";
					}
					try
					{
						StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
						if (streamWriter != null)
						{
							Class210<string> @class = null;
							if (this.int_0 == 0)
							{
								@class = frmLogin.class101_0.globalSettings_0.BuffNameList;
							}
							else if (this.int_0 == 1)
							{
								@class = frmLogin.class101_0.globalSettings_0.ItemTuHuyList;
							}
							else if (this.int_0 == 2)
							{
								@class = frmLogin.class101_0.globalSettings_0.ItemBanList;
							}
							else if (this.int_0 == 3)
							{
								@class = this.class58_0.autoSettings_0.AutoPartyList;
							}
							else if (this.int_0 == 4)
							{
								@class = this.class58_0.autoSettings_0.PTBlacklist;
							}
							else if (this.int_0 == 5)
							{
								@class = frmLogin.class101_0.globalSettings_0.ListItemNhat;
							}
							else if (this.int_0 == 6)
							{
								@class = frmLogin.class101_0.globalSettings_0.ListBuffPetID;
							}
							else if (this.int_0 == 7)
							{
								@class = this.class58_0.autoSettings_0.QuaiNoAttackList;
							}
							else if (this.int_0 == 8)
							{
								@class = this.class58_0.autoSettings_0.PKPlayerList;
							}
							else if (this.int_0 == 9)
							{
								@class = this.class58_0.autoSettings_0.PKBlackList;
							}
							else if (this.int_0 == 10)
							{
								@class = this.class58_0.autoSettings_0.ListItemNhatIgnore;
							}
							if (@class != null)
							{
								foreach (string value in @class)
								{
									streamWriter.WriteLine(value);
								}
							}
							streamWriter.Close();
							MessageBox.Show(frmMain.String_285 + saveFileDialog.FileName, frmMain.String_284, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
					}
					catch (Exception)
					{
						Class83.smethod_66(frmMain.String_283, this.class58_0, new object[0]);
					}
				}
			}
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x0000A319 File Offset: 0x00008519
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			this.bool_1 = true;
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x0000A322 File Offset: 0x00008522
		private void cboxTuRefresh_CheckedChanged(object sender, EventArgs e)
		{
			this.bool_2 = this.cboxTuRefresh.Checked;
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x000B3700 File Offset: 0x000B1900
		private void cboItemName_DropDown(object sender, EventArgs e)
		{
			if (this.int_0 != 1 && this.int_0 != 2 && this.int_0 != 5)
			{
				if (this.int_0 != 10)
				{
					if (this.cboItemName.Items.Count > 0)
					{
						this.cboItemName.Items.Clear();
						return;
					}
					return;
				}
			}
			if (this.class58_0 != null)
			{
				try
				{
					List<string> list = new List<string>();
					string text = "";
					int i = 0;
					while (i < 60)
					{
						text = "";
						if (this.class58_0.class112_0.list_1[i].string_0 != "" && this.class58_0.class112_0.list_1[i].int_0 > 0)
						{
							text = this.class58_0.class112_0.list_1[i].string_0;
						}
						if (this.class58_0.class112_0.list_1[i].string_0 == string.Empty && this.class58_0.class112_0.list_1[i].int_0 > 0)
						{
							text = this.class58_0.class112_0.list_1[i].int_0.ToString();
						}
						bool flag = false;
						if (list.Count > 0)
						{
							try
							{
								foreach (string text2 in list)
								{
									if (text2.Contains("~"))
									{
										string[] array = text2.Split(new char[]
										{
											'~'
										});
										if (array.Length < 2 || !(array[1] == text))
										{
											continue;
										}
										flag = true;
									}
									else
									{
										if (!(text2 == text))
										{
											continue;
										}
										flag = true;
									}
									break;
								}
								goto IL_1F6;
							}
							catch (Exception)
							{
								goto IL_1F6;
							}
							goto IL_1CC;
						}
						goto IL_1F6;
						IL_1ED:
						i++;
						continue;
						IL_1CC:
						if (!flag)
						{
							list.Add((i + 1).ToString() + "~" + text);
							goto IL_1ED;
						}
						goto IL_1ED;
						IL_1F6:
						if (text != "")
						{
							goto IL_1CC;
						}
						goto IL_1ED;
					}
					this.cboItemName.BeginUpdate();
					string[] array2 = list.ToArray();
					this.cboItemName.Items.Clear();
					ComboBox.ObjectCollection items = this.cboItemName.Items;
					object[] items2 = array2;
					items.AddRange(items2);
					this.cboItemName.EndUpdate();
				}
				catch (Exception)
				{
					this.cboItemName.Items.Clear();
				}
			}
		}

		// Token: 0x04000CAF RID: 3247
		internal Class58 class58_0;

		// Token: 0x04000CB0 RID: 3248
		internal int int_0;

		// Token: 0x04000CB1 RID: 3249
		private bool bool_0;

		// Token: 0x04000CB2 RID: 3250
		private bool bool_1 = true;

		// Token: 0x04000CB3 RID: 3251
		private bool bool_2 = true;
	}
}
