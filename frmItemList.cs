using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BrightIdeasSoftware;
using SmartBot;

namespace ns0
{
	// Token: 0x020000EC RID: 236
	internal sealed partial class frmItemList : Form
	{
		// Token: 0x0600091A RID: 2330 RVA: 0x000A6C7C File Offset: 0x000A4E7C
		internal frmItemList()
		{
			this.InitializeComponent();
			this.olvcolumn_0.AspectGetter = new AspectGetterDelegate(frmItemList.<>c.<>c_0.method_0);
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x000024E9 File Offset: 0x000006E9
		private void frmItemList_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x00009D7F File Offset: 0x00007F7F
		private void btnAddName_Click(object sender, EventArgs e)
		{
			this.method_1(true);
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x000A6D1C File Offset: 0x000A4F1C
		private void method_0(Class58 class58_1, Class210<string> class210_1, bool bool_3 = false)
		{
			if (this.long_0 <= Class83.Int64_0)
			{
				this.long_0 = Class83.Int64_0 + 1400L;
				this.list_0.Clear();
				if (!bool_3 && class58_1.class92_0 != null && class58_1.class92_0.list_0.Count > 0)
				{
					try
					{
						for (int i = class58_1.class92_0.list_0.Count - 1; i >= 0; i--)
						{
							Class93 @class = class58_1.class92_0.list_0[i];
							bool flag = false;
							if (class210_1 != null && class210_1.Count > 0)
							{
								for (int j = 0; j < class210_1.Count; j++)
								{
									if (class210_1[j] == @class.string_0)
									{
										flag = true;
										break;
									}
								}
							}
							bool flag2 = false;
							if (this.list_0.Count > 0)
							{
								for (int k = 0; k < this.list_0.Count; k++)
								{
									if (this.list_0[k].Name == @class.string_0)
									{
										flag2 = true;
										break;
									}
								}
							}
							if (!flag && !flag2)
							{
								PlayerListItem playerListItem = new PlayerListItem();
								playerListItem.Name = @class.string_0;
								playerListItem.Level = @class.int_7;
								this.list_0.Add(playerListItem);
							}
						}
					}
					catch (Exception)
					{
					}
				}
				if (bool_3 && class58_1.class118_0 != null && class58_1.class118_0.list_1.Count > 0)
				{
					try
					{
						for (int l = class58_1.class118_0.list_1.Count - 1; l >= 0; l--)
						{
							Class119 class2 = class58_1.class118_0.list_1[l];
							if (class2.byte_0 == 255)
							{
								bool flag3 = false;
								if (class210_1 != null && class210_1.Count > 0)
								{
									for (int m = 0; m < class210_1.Count; m++)
									{
										if (class210_1[m] == class2.string_0)
										{
											flag3 = true;
											break;
										}
									}
								}
								bool flag4 = false;
								if (this.list_0.Count > 0)
								{
									for (int n = 0; n < this.list_0.Count; n++)
									{
										if (this.list_0[n].Name == class2.string_0)
										{
											flag4 = true;
											break;
										}
									}
								}
								if (!flag3 && !flag4)
								{
									PlayerListItem playerListItem2 = new PlayerListItem();
									playerListItem2.Name = class2.string_0;
									playerListItem2.Level = class2.int_5;
									this.list_0.Add(playerListItem2);
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
				try
				{
					if (this.list_0.Count > 0)
					{
						this.list_0.Sort(new Comparison<PlayerListItem>(Class55.smethod_1));
					}
					int num = -1;
					if (this.listRight.Items.Count > 0 && this.listRight.SelectedObjects != null && this.listRight.SelectedObjects.Count > 0)
					{
						num = this.listRight.IndexOf(this.listRight.SelectedObjects[0]);
					}
					this.listRight.SetObjects(this.list_0);
					if (0 <= num && num <= this.listRight.Items.Count - 1)
					{
						this.listRight.SelectedIndex = num;
						this.listRight.FocusedItem = this.listRight.SelectedItems[0];
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x000A70D4 File Offset: 0x000A52D4
		private void method_1(bool bool_3 = true)
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
				Class210<string> @class = this.method_3();
				if (@class != null)
				{
					if (this.int_0 != 1)
					{
						if (!@class.Contains(text))
						{
							@class.method_1(text);
							if (bool_3)
							{
								@class.Sort();
								this.listLeft.SetObjects(@class);
							}
						}
					}
					else
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
									Class113 class2 = this.class58_0.class112_0.list_1[i];
									string b = "";
									string text2 = "";
									Class83.smethod_130(class2.int_0, out b, out text2);
									if (text == b)
									{
										flag = true;
										if (!@class.Contains(class2.int_0.ToString()))
										{
											@class.method_1(class2.int_0.ToString());
											if (bool_3)
											{
												@class.Sort();
												this.listLeft.SetObjects(@class);
											}
											IL_182:
											if (!flag)
											{
												Class83.smethod_58(string.Format(frmMain.String_790, text), frmMain.String_784, this.class58_0, 10000, new object[0]);
												goto IL_1DD;
											}
											goto IL_1DD;
										}
									}
								}
								goto IL_182;
							}
						}
						else if (!@class.Contains(text.ToLower()))
						{
							@class.method_1(text.ToLower());
							if (bool_3)
							{
								@class.Sort();
								this.listLeft.SetObjects(@class);
							}
						}
					}
				}
				IL_1DD:
				this.cboItemName.Text = "";
			}
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x000A72D0 File Offset: 0x000A54D0
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
						Class210<string> @class = this.method_3();
						while (!streamReader.EndOfStream)
						{
							string text = streamReader.ReadLine();
							if (!string.IsNullOrEmpty(text) && !text.StartsWith("#") && @class != null && !@class.Contains(text))
							{
								@class.method_1(text);
							}
						}
						@class.Sort();
						this.listLeft.SetObjects(@class);
						streamReader.Close();
					}
				}
			}
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x000A736C File Offset: 0x000A556C
		private void method_2(ObjectListView objectListView_0)
		{
			if (objectListView_0.SelectedObjects != null && objectListView_0.SelectedObjects.Count > 0 && this.class58_0 != null)
			{
				Class210<string> @class = this.method_3();
				if (@class != null)
				{
					for (int i = 0; i < objectListView_0.SelectedObjects.Count; i++)
					{
						@class.method_0(objectListView_0.SelectedObjects[i].ToString());
					}
					@class.Sort();
					this.listLeft.SetObjects(@class);
				}
			}
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x000A73E0 File Offset: 0x000A55E0
		private Class210<string> method_3()
		{
			if (this.class58_0 != null)
			{
				if (this.int_0 == 0)
				{
					return frmLogin.class101_0.globalSettings_0.BuffNameList;
				}
				if (this.int_0 == 1)
				{
					return frmLogin.class101_0.globalSettings_0.ItemTuHuyList;
				}
				if (this.int_0 == 2)
				{
					return frmLogin.class101_0.globalSettings_0.ItemBanList;
				}
				if (this.int_0 == 3)
				{
					return this.class58_0.autoSettings_0.AutoPartyList;
				}
				if (this.int_0 == 4)
				{
					return this.class58_0.autoSettings_0.PTBlacklist;
				}
				if (this.int_0 == 5)
				{
					return frmLogin.class101_0.globalSettings_0.ListItemNhat;
				}
				if (this.int_0 == 6)
				{
					return frmLogin.class101_0.globalSettings_0.ListBuffPetID;
				}
				if (this.int_0 == 7)
				{
					return this.class58_0.autoSettings_0.QuaiNoAttackList;
				}
				if (this.int_0 == 8)
				{
					return this.class58_0.autoSettings_0.PKPlayerList;
				}
				if (this.int_0 == 9)
				{
					return this.class58_0.autoSettings_0.PKBlackList;
				}
				if (this.int_0 == 10)
				{
					return this.class58_0.autoSettings_0.ListItemNhatIgnore;
				}
			}
			return null;
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x000A7514 File Offset: 0x000A5714
		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (this.class58_0 != null && (this.bool_2 || this.bool_1) && this.list_1.Contains(this.int_0))
			{
				if (this.int_0 != 6)
				{
					this.method_0(this.class58_0, this.method_3(), false);
					return;
				}
				this.method_0(this.class58_0, this.method_3(), true);
			}
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00009D88 File Offset: 0x00007F88
		private void method_4()
		{
			if (!this.bool_0)
			{
				this.btnRemove.Visible = true;
				this.btnAdd.Visible = true;
				base.Width = 399;
				this.bool_0 = true;
			}
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00009DBC File Offset: 0x00007FBC
		private void btnClose_Click(object sender, EventArgs e)
		{
			base.Close();
			base.Dispose();
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x000A757C File Offset: 0x000A577C
		private void frmItemList_Shown(object sender, EventArgs e)
		{
			switch (this.int_0)
			{
			case 0:
				this.lblTop.Text = frmMain.String_313;
				this.listLeft.Columns[0].Text = frmMain.String_357;
				this.Text = frmMain.String_312;
				break;
			case 1:
				this.lblTop.Text = frmMain.String_311;
				this.listLeft.Columns[0].Text = frmMain.String_310;
				this.Text = frmMain.String_309;
				break;
			case 2:
				this.lblTop.Text = frmMain.String_308;
				this.listLeft.Columns[0].Text = frmMain.String_307;
				this.Text = frmMain.String_306;
				break;
			case 3:
				this.lblTop.Text = frmMain.String_305;
				this.listLeft.Columns[0].Text = frmMain.String_304;
				this.Text = frmMain.String_303;
				break;
			case 4:
				this.lblTop.Text = frmMain.String_302;
				this.listLeft.Columns[0].Text = frmMain.String_301;
				this.Text = frmMain.String_300;
				break;
			case 5:
				this.lblTop.Text = frmMain.String_299;
				this.listLeft.Columns[0].Text = frmMain.String_298;
				this.Text = frmMain.String_297;
				break;
			case 6:
				this.lblTop.Text = frmMain.String_296;
				this.listLeft.Columns[0].Text = frmMain.String_295;
				this.Text = frmMain.String_294;
				break;
			case 7:
				this.lblTop.Text = frmMain.String_291;
				this.listLeft.Columns[0].Text = frmMain.String_289;
				this.Text = frmMain.String_286;
				break;
			case 8:
				this.lblTop.Text = frmMain.String_293;
				this.listLeft.Columns[0].Text = frmMain.String_290;
				this.Text = frmMain.String_287;
				break;
			case 9:
				this.lblTop.Text = frmMain.String_292;
				this.listLeft.Columns[0].Text = frmMain.String_290;
				this.Text = frmMain.String_288;
				break;
			case 10:
				this.lblTop.Text = frmMain.String_743;
				this.listLeft.Columns[0].Text = frmMain.String_744;
				this.Text = frmMain.String_745;
				break;
			}
			Class210<string> @class = this.method_3();
			if (@class != null)
			{
				@class.Sort();
				this.listLeft.SetObjects(@class);
				if (this.list_1.Contains(this.int_0))
				{
					this.method_0(this.class58_0, @class, false);
					this.listRight.SetObjects(this.list_0);
					this.method_4();
				}
			}
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x000A789C File Offset: 0x000A5A9C
		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (this.listRight.SelectedObjects != null && this.listRight.SelectedObjects.Count > 0)
			{
				for (int i = 0; i < this.listRight.SelectedObjects.Count - 1; i++)
				{
					this.cboItemName.Text = ((PlayerListItem)this.listRight.SelectedObjects[i]).Name;
					this.method_1(false);
				}
				this.cboItemName.Text = ((PlayerListItem)this.listRight.SelectedObjects[this.listRight.SelectedObjects.Count - 1]).Name;
				this.method_1(true);
			}
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00009DCA File Offset: 0x00007FCA
		private void btnRemove_Click(object sender, EventArgs e)
		{
			this.method_2(this.listLeft);
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x000A7958 File Offset: 0x000A5B58
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
							Class210<string> @class = this.method_3();
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

		// Token: 0x06000929 RID: 2345 RVA: 0x00009DD8 File Offset: 0x00007FD8
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			this.bool_1 = true;
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00009DE1 File Offset: 0x00007FE1
		private void cboxTuRefresh_CheckedChanged(object sender, EventArgs e)
		{
			this.bool_2 = this.cboxTuRefresh.Checked;
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x000A7A64 File Offset: 0x000A5C64
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

		// Token: 0x0600092C RID: 2348 RVA: 0x00009DF4 File Offset: 0x00007FF4
		private void cboItemName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r' || e.KeyChar == '\r')
			{
				this.method_1(true);
			}
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x000024E9 File Offset: 0x000006E9
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x000024E9 File Offset: 0x000006E9
		private void label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x000A7D1C File Offset: 0x000A5F1C
		private void method_5(object sender, CellClickEventArgs e)
		{
			if (e.ClickCount == 2)
			{
				if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
				{
					string text = (string)e.Model;
					if (text != "")
					{
						Class210<string> @class = this.method_3();
						if (@class != null)
						{
							@class.method_0(text);
							this.listLeft.SetObjects(@class);
							return;
						}
					}
				}
			}
			else if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
			{
				string text2 = (string)e.Model;
				if (text2 != "")
				{
					this.cboItemName.Text = text2;
				}
			}
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x000A7DB4 File Offset: 0x000A5FB4
		private void method_6(object sender, CellClickEventArgs e)
		{
			if (e.ClickCount == 2 && e.ColumnIndex >= 0 && e.RowIndex >= 0)
			{
				PlayerListItem playerListItem = (PlayerListItem)e.Model;
				if (playerListItem != null)
				{
					this.cboItemName.Text = playerListItem.Name;
					this.method_1(true);
				}
			}
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x000024E9 File Offset: 0x000006E9
		private void listLeft_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x000024E9 File Offset: 0x000006E9
		private void listLeft_SelectionChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x04000BD1 RID: 3025
		internal Class58 class58_0;

		// Token: 0x04000BD2 RID: 3026
		private List<PlayerListItem> list_0 = new List<PlayerListItem>();

		// Token: 0x04000BD3 RID: 3027
		internal int int_0;

		// Token: 0x04000BD4 RID: 3028
		private bool bool_0;

		// Token: 0x04000BD5 RID: 3029
		private bool bool_1 = true;

		// Token: 0x04000BD6 RID: 3030
		private bool bool_2 = true;

		// Token: 0x04000BD7 RID: 3031
		private long long_0;

		// Token: 0x04000BD8 RID: 3032
		private List<int> list_1 = new List<int>
		{
			0,
			3,
			4,
			6,
			8,
			9
		};

		// Token: 0x04000BD9 RID: 3033
		private Class210<string> class210_0 = new Class210<string>();

		// Token: 0x04000BDA RID: 3034
		private static long long_1;
	}
}
