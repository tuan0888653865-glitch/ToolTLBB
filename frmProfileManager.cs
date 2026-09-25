using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000104 RID: 260
	internal sealed partial class frmProfileManager : Form
	{
		// Token: 0x06000A9C RID: 2716 RVA: 0x0000AAA1 File Offset: 0x00008CA1
		internal frmProfileManager()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x000024E9 File Offset: 0x000006E9
		private void frmProfileManager_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x0000AAB6 File Offset: 0x00008CB6
		private void btnEditProfile_Click(object sender, EventArgs e)
		{
			this.method_2();
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x000024E9 File Offset: 0x000006E9
		private void cboNPH_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x000A1BC0 File Offset: 0x0009FDC0
		private void cboxAgreement_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;
			if (checkBox.Focused)
			{
				frmLogin.class101_0.globalSettings_0.cboxAgreement = checkBox.Checked;
			}
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x000CCC38 File Offset: 0x000CAE38
		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (frmLogin.stopwatch_0.ElapsedMilliseconds - frmLogin.long_36 >= 5000L || frmLogin.long_36 == 0L)
			{
				frmLogin.long_36 = frmLogin.stopwatch_0.ElapsedMilliseconds;
				bool flag = true;
				try
				{
					if (frmLogin.class101_0.globalSettings_0.ListLoginProfile.Count > 0 && frmLogin.class101_0.class210_0.Count > 0)
					{
						for (int i = 0; i < frmLogin.class101_0.globalSettings_0.ListLoginProfile.Count; i++)
						{
							if (frmLogin.class101_0.globalSettings_0.ListLoginProfile[i].RefAutoAccount == null && ((frmLogin.class101_0.globalSettings_0.ListLoginProfile[i].int_1 != 0 && !flag) || flag))
							{
								for (int j = frmLogin.class101_0.class210_0.Count - 1; j >= 0; j--)
								{
									if (frmLogin.class101_0.class210_0[j].class75_0.Boolean_0 && string.Compare(frmLogin.class101_0.class210_0[j].class114_0.string_0, frmLogin.class101_0.globalSettings_0.ListLoginProfile[i].Username, true) == 0 && ((frmLogin.class101_0.globalSettings_0.ListLoginProfile[i].NPHShortName == "VNG" && frmLogin.class101_0.class210_0[j].class59_0.int_2 <= 2) || (frmLogin.class101_0.globalSettings_0.ListLoginProfile[i].NPHShortName == "TK" && frmLogin.class101_0.class210_0[j].class59_0.int_2 == 3) || ((frmLogin.class101_0.globalSettings_0.ListLoginProfile[i].NPHShortName == "OT" || frmLogin.class101_0.globalSettings_0.ListLoginProfile[i].NPHShortName == "Server khác") && frmLogin.class101_0.class210_0[j].class59_0.int_2 > 3)) && ((frmLogin.class101_0.class210_0[j].class59_0.int_1 == frmLogin.class101_0.globalSettings_0.ListLoginProfile[i].int_1 && !flag) || flag))
									{
										frmLogin.class101_0.globalSettings_0.ListLoginProfile[i].RefAutoAccount = frmLogin.class101_0.class210_0[j];
										frmLogin.class101_0.class210_0[j].gclass2_0 = frmLogin.class101_0.globalSettings_0.ListLoginProfile[i];
										frmLogin.class101_0.class210_0[j].class59_0.bool_25 = true;
									}
								}
							}
						}
					}
				}
				catch (Exception)
				{
				}
			}
			if (!this.cboxAgreement.Focused)
			{
				this.cboxAgreement.Checked = frmLogin.class101_0.globalSettings_0.cboxAgreement;
			}
			if (frmLogin.class101_0.globalSettings_0.cboxAgreement)
			{
				this.lblAgreement.ForeColor = Color.RosyBrown;
				this.lblAgreementTitle.ForeColor = Color.RosyBrown;
				this.cboxAgreement.ForeColor = Color.Gainsboro;
				this.cboxAgreement.Enabled = false;
			}
			if (this.dataGridView1.Rows.Count < frmLogin.class101_0.globalSettings_0.ListLoginProfile.Count)
			{
				using (List<GClass2>.Enumerator enumerator = frmLogin.class101_0.globalSettings_0.ListLoginProfile.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						GClass2 gclass = enumerator.Current;
						try
						{
							bool flag2 = true;
							foreach (object obj in ((IEnumerable)this.dataGridView1.Rows))
							{
								DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
								if (dataGridViewRow.Cells[0].Value != null && dataGridViewRow.Cells[0].Value.ToString() == gclass.Username && dataGridViewRow.Cells[1].Value != null && dataGridViewRow.Cells[1].Value.ToString() == gclass.NPHShortName)
								{
									flag2 = false;
									break;
								}
							}
							if (this.dataGridView1.Rows.Count == 0)
							{
								flag2 = true;
							}
							if (flag2)
							{
								this.dataGridView1.Rows.Add();
								DataGridViewRow dataGridViewRow2 = this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1];
								dataGridViewRow2.Cells[0].Value = gclass.Username;
								dataGridViewRow2.Cells[1].Value = gclass.NPHShortName;
								dataGridViewRow2.Cells[2].Value = gclass.Server;
								dataGridViewRow2.Cells[3].Value = gclass.MinorServer;
								dataGridViewRow2.Cells[4].Value = gclass.CharName;
							}
						}
						catch (Exception)
						{
						}
					}
					goto IL_69A;
				}
			}
			if (this.dataGridView1.Rows.Count > frmLogin.class101_0.globalSettings_0.ListLoginProfile.Count)
			{
				try
				{
					for (int k = this.dataGridView1.Rows.Count - 1; k >= 0; k--)
					{
						bool flag3 = true;
						DataGridViewRow dataGridViewRow3 = this.dataGridView1.Rows[k];
						foreach (GClass2 gclass2 in frmLogin.class101_0.globalSettings_0.ListLoginProfile)
						{
							if (dataGridViewRow3.Cells[0].Value != null && dataGridViewRow3.Cells[0].Value.ToString() == gclass2.Username && dataGridViewRow3.Cells[1].Value != null && dataGridViewRow3.Cells[1].Value.ToString() == gclass2.NPHShortName)
							{
								break;
							}
							if (flag3)
							{
								this.dataGridView1.Rows.RemoveAt(k);
							}
						}
					}
				}
				catch (Exception)
				{
				}
			}
			IL_69A:
			if (this.dataGridView1.Rows.Count == frmLogin.class101_0.globalSettings_0.ListLoginProfile.Count)
			{
				try
				{
					for (int l = this.dataGridView1.Rows.Count - 1; l >= 0; l--)
					{
						DataGridViewRow dataGridViewRow4 = this.dataGridView1.Rows[l];
						if (dataGridViewRow4.Cells[0].Value != null && dataGridViewRow4.Cells[0].Value.ToString() != frmLogin.class101_0.globalSettings_0.ListLoginProfile[l].Username)
						{
							dataGridViewRow4.Cells[0].Value = frmLogin.class101_0.globalSettings_0.ListLoginProfile[l].Username;
						}
						if (dataGridViewRow4.Cells[1].Value != null && dataGridViewRow4.Cells[1].Value.ToString() != frmLogin.class101_0.globalSettings_0.ListLoginProfile[l].NPHShortName)
						{
							dataGridViewRow4.Cells[1].Value = frmLogin.class101_0.globalSettings_0.ListLoginProfile[l].NPHShortName;
						}
						if (dataGridViewRow4.Cells[2].Value != null && dataGridViewRow4.Cells[2].Value.ToString() != frmLogin.class101_0.globalSettings_0.ListLoginProfile[l].Server)
						{
							dataGridViewRow4.Cells[2].Value = frmLogin.class101_0.globalSettings_0.ListLoginProfile[l].Server;
						}
						if (dataGridViewRow4.Cells[3].Value != null && dataGridViewRow4.Cells[3].Value.ToString() != frmLogin.class101_0.globalSettings_0.ListLoginProfile[l].MinorServer)
						{
							dataGridViewRow4.Cells[3].Value = frmLogin.class101_0.globalSettings_0.ListLoginProfile[l].MinorServer;
						}
						if (dataGridViewRow4.Cells[4].Value != null && dataGridViewRow4.Cells[4].Value.ToString() != frmLogin.class101_0.globalSettings_0.ListLoginProfile[l].CharName)
						{
							dataGridViewRow4.Cells[4].Value = frmLogin.class101_0.globalSettings_0.ListLoginProfile[l].CharName;
						}
						if (frmLogin.class101_0.globalSettings_0.ListLoginProfile[l].RefAutoAccount != null)
						{
							Class58 refAutoAccount = frmLogin.class101_0.globalSettings_0.ListLoginProfile[l].RefAutoAccount;
							object object_ = refAutoAccount.class75_0.object_0;
							lock (object_)
							{
								if (refAutoAccount.class75_0.long_19 != 0L && frmLogin.stopwatch_0.ElapsedMilliseconds - refAutoAccount.class75_0.long_19 <= 10000L && frmLogin.stopwatch_0.ElapsedMilliseconds - refAutoAccount.class75_0.long_19 >= 10L && refAutoAccount.class75_0.bool_8)
								{
									string string_ = Class83.smethod_36(refAutoAccount.class75_0.byte_0);
									PictureBox pictureBox = new PictureBox();
									Class83.smethod_43(string_, pictureBox);
									dataGridViewRow4.Cells[5].Value = pictureBox.Image;
									refAutoAccount.class75_0.bool_8 = false;
									refAutoAccount.class75_0.long_19 = 0L;
									dataGridViewRow4.Cells[7].Value = frmMain.String_734;
								}
							}
							if (refAutoAccount.class75_0.Boolean_0)
							{
								dataGridViewRow4.Cells[8].Value = true;
								if (dataGridViewRow4.Cells[7].Value == null || (dataGridViewRow4.Cells[7].Value != null && dataGridViewRow4.Cells[7].Value.ToString() != frmMain.String_734))
								{
									(dataGridViewRow4.Cells[5] as DataGridViewImageCell).Value = Class212.captchaplace;
								}
								dataGridViewRow4.Cells[7].Value = frmMain.String_734;
							}
							else
							{
								dataGridViewRow4.Cells[8].Value = false;
							}
						}
						else
						{
							if ((dataGridViewRow4.Cells[8].Value != null && (bool)dataGridViewRow4.Cells[8].Value) || dataGridViewRow4.Cells[8].Value == null)
							{
								dataGridViewRow4.Cells[8].Value = false;
							}
							if (dataGridViewRow4.Cells[7].Value != null && dataGridViewRow4.Cells[7].Value.ToString() != "")
							{
								dataGridViewRow4.Cells[7].Value = "";
							}
							DataGridViewImageCell dataGridViewImageCell = dataGridViewRow4.Cells[5] as DataGridViewImageCell;
							Color pixel = ((Bitmap)dataGridViewImageCell.Value).GetPixel(10, 10);
							if (pixel.B != 201 && pixel.G != 198)
							{
								dataGridViewImageCell.Value = Class212.captchaplace;
							}
						}
					}
				}
				catch (Exception)
				{
					Class83.smethod_66(frmMain.String_733, null, new object[0]);
				}
			}
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x000CD96C File Offset: 0x000CBB6C
		private void frmProfileManager_Shown(object sender, EventArgs e)
		{
			this.timer_0.Enabled = true;
			if (!(frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN"))
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					this.cboNPH.Items[0] = "D.Oath";
					this.cboNPH.Items[1] = "69Dragon";
					this.cboNPH.Items[2] = "Others";
					return;
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
				{
					this.cboNPH.Items[0] = "CIBMal";
					this.cboNPH.Items[1] = "Changyou";
					this.cboNPH.Items[2] = "Others";
				}
			}
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x000CDA60 File Offset: 0x000CBC60
		private void btnThemProfile_Click(object sender, EventArgs e)
		{
			if (this.tboxUsername.Text != "" && this.tboxPassword.Text != "" && frmLogin.class101_0.globalSettings_0.cboxAgreement && this.tboxGameFile.Text != null)
			{
				bool flag = false;
				if (this.cboNPH.Text == "Vinagame" && this.cboServer.Text != "")
				{
					flag = true;
				}
				if ((this.cboNPH.Text == "Tình Kiếm" || this.cboNPH.Text == "69Dragon") && this.cboServer.Text != "")
				{
					flag = true;
				}
				if (this.cboNPH.Text == "D.Oath" && this.cboServer.Text != "")
				{
					flag = true;
				}
				if (this.cboNPH.Text == "CIBMal" && this.cboServer.Text != "")
				{
					flag = true;
				}
				if (this.cboNPH.Text == "Changyou" && this.cboServer.Text != "")
				{
					flag = true;
				}
				if ((this.cboNPH.Text == "Server khác" || this.cboNPH.Text == "Others") && this.cboServer.Text != "")
				{
					flag = true;
				}
				if (flag)
				{
					GClass2 gclass = new GClass2();
					gclass.Username = this.tboxUsername.Text;
					gclass.secureString_0 = Class83.smethod_70(this.tboxPassword.Text);
					gclass.Server = this.cboServer.Text;
					gclass.String_0 = this.cboNPH.Text;
					gclass.MinorServer = this.cboHopKiem.Text;
					gclass.CharName = this.tboxName.Text;
					gclass.GamePath = this.tboxGameFile.Text;
					bool flag2 = false;
					if (frmLogin.class101_0.globalSettings_0.ListLoginProfile.Count > 0)
					{
						for (int i = 0; i < frmLogin.class101_0.globalSettings_0.ListLoginProfile.Count; i++)
						{
							GClass2 gclass2 = frmLogin.class101_0.globalSettings_0.ListLoginProfile[i];
							if (gclass2.Username == gclass.Username && gclass2.String_0 == gclass.String_0)
							{
								flag2 = true;
								gclass2.secureString_0 = gclass.secureString_0;
								gclass2.Server = gclass.Server;
								gclass2.String_0 = gclass.String_0;
								gclass2.MinorServer = gclass.MinorServer;
								gclass2.CharName = gclass.CharName;
								gclass2.GamePath = gclass.GamePath;
								frmLogin.frmLogin_0.method_15(frmLogin.class101_0.globalSettings_0.ListLoginProfile, null);
								break;
							}
						}
					}
					if (!flag2)
					{
						frmLogin.class101_0.globalSettings_0.ListLoginProfile.method_1(gclass);
					}
				}
				this.bool_0 = true;
			}
			if (!frmLogin.class101_0.globalSettings_0.cboxAgreement)
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					MessageBox.Show("Để sử dụng tính năng này, bạn phải đồng ý với Điều khoản sử dụng", "Điều khoản sử dụng", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					MessageBox.Show("To use this feature, you must read and agree the terms of use.", "Terms of use", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x000CDE10 File Offset: 0x000CC010
		private void btnDelProfile_Click(object sender, EventArgs e)
		{
			if (this.dataGridView1.SelectedRows.Count > 0)
			{
				int i = this.dataGridView1.SelectedRows.Count - 1;
				IL_147:
				while (i >= 0)
				{
					for (int j = frmLogin.class101_0.globalSettings_0.ListLoginProfile.Count - 1; j >= 0; j--)
					{
						if (this.dataGridView1.SelectedRows[0].Cells[0].Value != null && frmLogin.class101_0.globalSettings_0.ListLoginProfile[j].Username == this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString() && this.dataGridView1.SelectedRows[0].Cells[1].Value != null && frmLogin.class101_0.globalSettings_0.ListLoginProfile[j].NPHShortName == this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString())
						{
							frmLogin.class101_0.globalSettings_0.ListLoginProfile.RemoveAt(j);
							IL_143:
							i--;
							goto IL_147;
						}
					}
					goto IL_143;
				}
				this.bool_0 = true;
				frmLogin.frmLogin_0.method_15(frmLogin.class101_0.globalSettings_0.ListLoginProfile, null);
			}
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x000CDF8C File Offset: 0x000CC18C
		private void btnMoveUp_Click(object sender, EventArgs e)
		{
			bool flag = false;
			if (this.long_0 == 0L)
			{
				flag = true;
			}
			else if (frmLogin.stopwatch_0.ElapsedMilliseconds - this.long_0 > 120L)
			{
				flag = true;
			}
			if (this.dataGridView1.SelectedRows.Count == 1 && flag)
			{
				GClass2 gclass = null;
				int num = -1;
				this.method_1(out gclass, out num);
				if (gclass != null && num != -1 && num > 0)
				{
					frmLogin.class101_0.globalSettings_0.ListLoginProfile.RemoveAt(num);
					frmLogin.class101_0.globalSettings_0.ListLoginProfile.Insert(num - 1, gclass);
					this.dataGridView1.Rows[num - 1].Selected = true;
					this.dataGridView1.Rows[num].Selected = false;
					this.dataGridView1.Select();
					this.dataGridView1.Invalidate();
					this.bool_0 = true;
					frmLogin.frmLogin_0.method_15(frmLogin.class101_0.globalSettings_0.ListLoginProfile, null);
					this.long_0 = frmLogin.stopwatch_0.ElapsedMilliseconds;
				}
			}
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x000CE0A4 File Offset: 0x000CC2A4
		private int method_0(int int_1)
		{
			if (this.dataGridView1.Rows.Count > 0)
			{
				try
				{
					for (int i = frmLogin.class101_0.globalSettings_0.ListLoginProfile.Count - 1; i >= 0; i--)
					{
						if (this.dataGridView1.Rows[int_1].Cells[0].Value != null && frmLogin.class101_0.globalSettings_0.ListLoginProfile[i].Username == this.dataGridView1.Rows[int_1].Cells[0].Value.ToString() && this.dataGridView1.Rows[int_1].Cells[1].Value != null && frmLogin.class101_0.globalSettings_0.ListLoginProfile[i].NPHShortName == this.dataGridView1.Rows[int_1].Cells[1].Value.ToString())
						{
							return i;
						}
					}
					return -1;
				}
				catch (Exception)
				{
					return -1;
				}
				int result;
				return result;
			}
			return -1;
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x000CE1F0 File Offset: 0x000CC3F0
		private void method_1(out GClass2 gclass2_0, out int int_1)
		{
			gclass2_0 = null;
			int_1 = -1;
			if (this.dataGridView1.SelectedRows.Count > 0)
			{
				for (int i = frmLogin.class101_0.globalSettings_0.ListLoginProfile.Count - 1; i >= 0; i--)
				{
					if (this.dataGridView1.SelectedRows[0].Cells[0].Value != null && frmLogin.class101_0.globalSettings_0.ListLoginProfile[i].Username == this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString() && this.dataGridView1.SelectedRows[0].Cells[1].Value != null && frmLogin.class101_0.globalSettings_0.ListLoginProfile[i].NPHShortName == this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString())
					{
						gclass2_0 = frmLogin.class101_0.globalSettings_0.ListLoginProfile[i];
						int_1 = i;
						return;
					}
				}
			}
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x000CE334 File Offset: 0x000CC534
		private void btnMoveDown_Click(object sender, EventArgs e)
		{
			bool flag = false;
			if (this.long_0 == 0L)
			{
				flag = true;
			}
			else if (frmLogin.stopwatch_0.ElapsedMilliseconds - this.long_0 > 120L)
			{
				flag = true;
			}
			if (this.dataGridView1.SelectedRows.Count == 1 && flag)
			{
				GClass2 gclass = null;
				int num = -1;
				this.method_1(out gclass, out num);
				if (gclass != null && num != -1 && num < frmLogin.class101_0.globalSettings_0.ListLoginProfile.Count - 1)
				{
					frmLogin.class101_0.globalSettings_0.ListLoginProfile.RemoveAt(num);
					frmLogin.class101_0.globalSettings_0.ListLoginProfile.Insert(num + 1, gclass);
					this.dataGridView1.Rows[num + 1].Selected = true;
					this.dataGridView1.Rows[num].Selected = false;
					this.dataGridView1.Select();
					this.bool_0 = true;
					frmLogin.frmLogin_0.method_15(frmLogin.class101_0.globalSettings_0.ListLoginProfile, null);
					this.dataGridView1.Invalidate();
					this.long_0 = frmLogin.stopwatch_0.ElapsedMilliseconds;
				}
			}
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0000AAB6 File Offset: 0x00008CB6
		private void lvAllProfiles_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.method_2();
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x000CE460 File Offset: 0x000CC660
		private void method_2()
		{
			if (this.dataGridView1.SelectedRows.Count > 0)
			{
				GClass2 gclass = null;
				int num = -1;
				this.method_1(out gclass, out num);
				if (gclass != null && num != -1)
				{
					this.tboxUsername.Text = gclass.Username;
					this.tboxPassword.Text = Class83.smethod_71(gclass.secureString_0);
					this.tboxName.Text = gclass.CharName;
					this.cboNPH.Text = gclass.String_0;
					this.cboServer.Text = gclass.Server;
					this.cboHopKiem.Text = gclass.MinorServer;
					this.tboxGameFile.Text = gclass.GamePath;
				}
			}
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x000CE518 File Offset: 0x000CC718
		private void btnBrowseVNG_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "TLBB Game.exe | Game.exe";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.tboxGameFile.Text = openFileDialog.FileName;
			}
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x000024E9 File Offset: 0x000006E9
		private void cboServer_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x000CE550 File Offset: 0x000CC750
		private void cboServer_DropDown(object sender, EventArgs e)
		{
			bool flag = true;
			if (frmLogin.string_0 == "VN")
			{
				if (frmLogin.list_17.Count == 0 || frmLogin.list_10.Count == 0 || frmLogin.list_18.Count == 0)
				{
					flag = false;
				}
			}
			else if (frmLogin.string_0 == "EN" && (frmLogin.list_17.Count == 0 || frmLogin.list_18.Count == 0 || frmLogin.list_11.Count == 0))
			{
				flag = false;
			}
			if (!(this.cboNPH.Text == "Tình Kiếm") && !(this.cboNPH.Text == "69Dragon"))
			{
				if (this.cboNPH.Text == "Vinagame")
				{
					if (flag)
					{
						this.cboServer.BeginUpdate();
						this.cboServer.Items.Clear();
						ComboBox.ObjectCollection items = this.cboServer.Items;
						object[] items2 = frmLogin.list_10.ToArray();
						items.AddRange(items2);
						this.cboServer.EndUpdate();
						this.cboHopKiem.Text = "";
						return;
					}
				}
				else if (this.cboNPH.Text == "D.Oath")
				{
					if (flag)
					{
						this.cboServer.BeginUpdate();
						this.cboServer.Items.Clear();
						ComboBox.ObjectCollection items3 = this.cboServer.Items;
						object[] items2 = frmLogin.list_11.ToArray();
						items3.AddRange(items2);
						this.cboServer.EndUpdate();
						this.cboHopKiem.Text = "";
						return;
					}
				}
				else if (this.cboNPH.Text == "Server khác" || this.cboNPH.Text == "Others")
				{
					this.cboServer.BeginUpdate();
					this.cboServer.Items.Clear();
					ComboBox.ObjectCollection items4 = this.cboServer.Items;
					object[] items2 = new List<string>
					{
						"1",
						"2",
						"3",
						"4",
						"5"
					}.ToArray();
					items4.AddRange(items2);
					this.cboServer.EndUpdate();
				}
				return;
			}
			if (flag)
			{
				this.cboServer.BeginUpdate();
				this.cboServer.Items.Clear();
				ComboBox.ObjectCollection items5 = this.cboServer.Items;
				object[] items2 = frmLogin.list_17.ToArray();
				items5.AddRange(items2);
				this.cboServer.EndUpdate();
				return;
			}
			frmMain.smethod_45();
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x000024E9 File Offset: 0x000006E9
		private void cboHopKiem_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x000024E9 File Offset: 0x000006E9
		private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x0000AABE File Offset: 0x00008CBE
		private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
			{
				this.method_2();
			}
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0000AABE File Offset: 0x00008CBE
		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
			{
				this.method_2();
			}
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x000CE7D8 File Offset: 0x000CC9D8
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (((DataGridView)sender).Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
			{
				if (e.ColumnIndex == 9)
				{
					frmLogin.long_25 = frmLogin.stopwatch_0.ElapsedMilliseconds;
					this.method_3(e.RowIndex);
				}
				if (e.ColumnIndex == 6)
				{
					int rowIndex = e.RowIndex;
					if (rowIndex >= 0 && rowIndex < frmLogin.class101_0.globalSettings_0.ListLoginProfile.Count)
					{
						GClass2 gclass = frmLogin.class101_0.globalSettings_0.ListLoginProfile[rowIndex];
						if (gclass.RefAutoAccount != null && !gclass.RefAutoAccount.class75_0.Boolean_0)
						{
							gclass.RefAutoAccount.method_135(20);
						}
					}
				}
			}
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x000CE8A0 File Offset: 0x000CCAA0
		private void method_3(int int_1)
		{
			if (int_1 >= 0 && int_1 < frmLogin.class101_0.globalSettings_0.ListLoginProfile.Count)
			{
				GClass2 gclass = frmLogin.class101_0.globalSettings_0.ListLoginProfile[int_1];
				if (!gclass.bool_1 && !gclass.bool_3)
				{
					try
					{
						if (((!(gclass.String_0 == "Tình Kiếm") && !(gclass.String_0 == "69Dragon")) || frmLogin.list_17.Count <= 0) && !(gclass.String_0 == "Server khác") && !(gclass.String_0 == "Others") && (!(gclass.String_0 == "Vinagame") || frmLogin.list_10.Count <= 0) && (!(gclass.String_0 == "D.Oath") || frmLogin.list_11.Count <= 0) && (!(gclass.String_0 == "CIBMal") || frmLogin.list_12.Count <= 0) && (!(gclass.String_0 == "Changyou") || frmLogin.list_13.Count <= 0))
						{
							MessageBox.Show(frmMain.String_725, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						}
						else
						{
							gclass.bool_3 = true;
							frmGLogin.smethod_10(gclass);
						}
						return;
					}
					catch (Exception)
					{
						return;
					}
				}
				if (this.dataGridView1.Rows[int_1].Cells[7].Value != null)
				{
					string text = this.dataGridView1.Rows[int_1].Cells[7].Value.ToString();
					if (text != "" && text != "Nhập mã" && Class83.smethod_13(text))
					{
						Class83.smethod_7(gclass.RefAutoAccount.class59_0.intptr_10, text);
						Class83.smethod_8(gclass.RefAutoAccount.class59_0.intptr_10, 13);
						Thread.Sleep(100);
						gclass.RefAutoAccount.method_135(29);
						this.dataGridView1.Rows[int_1].Cells[7].Value = "";
					}
				}
			}
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x000CEAF8 File Offset: 0x000CCCF8
		private void cboHopKiem_DropDown(object sender, EventArgs e)
		{
			if (!(this.cboNPH.Text == "Tình Kiếm") && !(this.cboNPH.Text == "69Dragon"))
			{
				this.cboHopKiem.Items.Clear();
				return;
			}
			this.cboHopKiem.BeginUpdate();
			this.cboHopKiem.Items.Clear();
			ComboBox.ObjectCollection items = this.cboHopKiem.Items;
			object[] items2 = frmLogin.list_18.ToArray();
			items.AddRange(items2);
			this.cboHopKiem.EndUpdate();
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0000AAD8 File Offset: 0x00008CD8
		private void toolStripMenuItem_0_Click(object sender, EventArgs e)
		{
			this.method_4(-1);
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x000CEB88 File Offset: 0x000CCD88
		private void method_4(int int_1 = -1)
		{
			if (this.dataGridView1.SelectedRows.Count > 0)
			{
				frmLogin.long_25 = frmLogin.stopwatch_0.ElapsedMilliseconds;
				for (int i = 0; i < this.dataGridView1.SelectedRows.Count; i++)
				{
					frmProfileManager.Class179 @class = new frmProfileManager.Class179();
					@class.frmProfileManager_0 = this;
					@class.int_0 = -1;
					if (int_1 != -1)
					{
						@class.int_0 = int_1;
					}
					if (this.dataGridView1.Rows.Count > 0 && int_1 == -1)
					{
						for (int j = 0; j < this.dataGridView1.Rows.Count; j++)
						{
							if (this.dataGridView1.SelectedRows[i].Cells[0].ToString() == this.dataGridView1.Rows[j].Cells[0].ToString() && this.dataGridView1.SelectedRows[i].Cells[1].ToString() == this.dataGridView1.Rows[j].Cells[1].ToString() && this.dataGridView1.SelectedRows[i].Cells[4].ToString() == this.dataGridView1.Rows[j].Cells[4].ToString())
							{
								@class.int_0 = j;
								break;
							}
						}
					}
					if (@class.int_0 >= 0)
					{
						object object_ = frmLogin.object_12;
						lock (object_)
						{
							new Thread(new ThreadStart(@class.method_0)).Start();
						}
					}
				}
			}
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x0000AAE1 File Offset: 0x00008CE1
		private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				this.GLoginContextMenu.Show(this.dataGridView1, e.Location);
			}
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x000CED64 File Offset: 0x000CCF64
		private void GLoginContextMenu_Opening(object sender, CancelEventArgs e)
		{
			if (this.dataGridView1.SelectedRows.Count > 0)
			{
				try
				{
					bool flag = true;
					for (int i = 0; i < this.dataGridView1.SelectedRows.Count; i++)
					{
						int int_ = -1;
						if (this.dataGridView1.Rows.Count > 0)
						{
							for (int j = 0; j < this.dataGridView1.Rows.Count; j++)
							{
								if (this.dataGridView1.SelectedRows[i] == this.dataGridView1.Rows[j])
								{
									int_ = j;
									break;
								}
							}
						}
						int num = this.method_0(int_);
						if (num > 0 && !frmLogin.class101_0.globalSettings_0.ListLoginProfile[num].bool_1 && !frmLogin.class101_0.globalSettings_0.ListLoginProfile[num].bool_3)
						{
							flag = false;
							IL_E1:
							if (!flag)
							{
								this.GLoginContextMenu.Items[1].Enabled = false;
							}
							else
							{
								this.GLoginContextMenu.Items[1].Enabled = true;
							}
							return;
						}
					}
					goto IL_E1;
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x0000AAD8 File Offset: 0x00008CD8
		private void toolStripMenuItem_1_Click(object sender, EventArgs e)
		{
			this.method_4(-1);
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x000CEEA8 File Offset: 0x000CD0A8
		private int method_5()
		{
			int result = -1;
			if (this.dataGridView1.Rows.Count > 0 && this.dataGridView1.SelectedRows.Count == 1)
			{
				for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
				{
					if (this.dataGridView1.SelectedRows[0].Cells[0].ToString() == this.dataGridView1.Rows[i].Cells[0].ToString() && this.dataGridView1.SelectedRows[0].Cells[1].ToString() == this.dataGridView1.Rows[i].Cells[1].ToString() && this.dataGridView1.SelectedRows[0].Cells[4].ToString() == this.dataGridView1.Rows[i].Cells[4].ToString())
					{
						result = i;
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x000CEFE8 File Offset: 0x000CD1E8
		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			if (this.dataGridView1.SelectedRows.Count > 1)
			{
				this.int_0 = -1;
				return;
			}
			int num = this.method_5();
			if (num != -1 && num == this.int_0 + 1 && this.int_0 != -1)
			{
				string text = "";
				if (this.dataGridView1.Rows[this.int_0].Cells[7].Value != null)
				{
					text = this.dataGridView1.Rows[this.int_0].Cells[7].Value.ToString();
				}
				bool flag = Class83.smethod_13(text);
				if (text.Length == 4 && flag)
				{
					this.method_4(this.int_0);
				}
			}
			this.int_0 = num;
		}

		// Token: 0x04000EED RID: 3821
		private bool bool_0;

		// Token: 0x04000EEE RID: 3822
		private Class17 class17_0;

		// Token: 0x04000EEF RID: 3823
		private long long_0;

		// Token: 0x04000EF0 RID: 3824
		private int int_0 = -1;

		// Token: 0x02000105 RID: 261
		[CompilerGenerated]
		private sealed class Class179
		{
			// Token: 0x06000ABF RID: 2751 RVA: 0x0000AB26 File Offset: 0x00008D26
			internal void method_0()
			{
				this.frmProfileManager_0.method_3(this.int_0);
			}

			// Token: 0x04000F24 RID: 3876
			public int int_0;

			// Token: 0x04000F25 RID: 3877
			public frmProfileManager frmProfileManager_0;
		}
	}
}
