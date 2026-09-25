using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace ns0
{
	// Token: 0x020000E8 RID: 232
	internal sealed partial class frmGLogin : Form
	{
		// Token: 0x060008AB RID: 2219 RVA: 0x000A15E0 File Offset: 0x0009F7E0
		internal frmGLogin()
		{
			this.InitializeComponent();
			if (frmGLogin.thread_0 == null)
			{
				frmGLogin.smethod_0();
			}
			this.method_0();
			if (frmLogin.class101_0.globalSettings_0.ListLoginProfile != null)
			{
				this.listGLogin.SetObjects(frmLogin.class101_0.globalSettings_0.ListLoginProfile);
			}
			frmGLogin.frmGLogin_0 = this;
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00009B34 File Offset: 0x00007D34
		internal static void smethod_0()
		{
			frmGLogin.thread_0 = new Thread(new ThreadStart(frmGLogin.smethod_1));
			frmGLogin.thread_0.IsBackground = true;
			frmGLogin.thread_0.Start();
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x000A168C File Offset: 0x0009F88C
		internal static void smethod_1()
		{
			for (;;)
			{
				if (frmGLogin.list_0.Count > 0)
				{
					int count = frmLogin.class101_0.class210_0.Count;
					long num = frmLogin.stopwatch_0.ElapsedMilliseconds + 300000L;
					long num2 = 0L;
					bool flag = false;
					int count2 = frmGLogin.list_0.Count;
					while (frmLogin.stopwatch_0.ElapsedMilliseconds <= num)
					{
						Thread.Sleep(100);
						flag = (frmGLogin.list_0.Count > 0);
						if (frmLogin.class101_0.class210_0.Count <= count)
						{
							goto IL_240;
						}
						num2 = 0L;
						int i = frmGLogin.list_0.Count - 1;
						while (i >= 0)
						{
							GClass2 gclass = frmGLogin.list_0[i];
							if (gclass.long_2 == 0L)
							{
								gclass.long_2 = frmLogin.stopwatch_0.ElapsedMilliseconds + 45000L;
								gclass.int_3 = 0;
								goto IL_120;
							}
							if (0L > gclass.long_2 || gclass.long_2 >= frmLogin.stopwatch_0.ElapsedMilliseconds)
							{
								goto IL_120;
							}
							gclass.int_3++;
							if (gclass.int_3 <= 1)
							{
								goto IL_120;
							}
							frmGLogin.smethod_5(gclass, frmGLogin.list_0, true);
							IL_325:
							i--;
							continue;
							IL_120:
							try
							{
								for (int j = 0; j < frmLogin.class101_0.class210_0.Count; j++)
								{
									Class58 @class = frmLogin.class101_0.class210_0[j];
									if (@class.gclass2_0 == null && !@class.class75_0.Boolean_0 && @class.class75_0.int_15 < 2 && string.Equals(@class.class59_0.string_5, gclass.GamePath, StringComparison.OrdinalIgnoreCase))
									{
										gclass.bool_3 = true;
										gclass.long_1 = frmGLogin.smethod_2() + 30000L;
										flag = true;
										@class.gclass2_0 = gclass;
										gclass.imgCaptcha = null;
										gclass.int_3 = 0;
										gclass.long_2 = 0L;
										gclass.RefAutoAccount = @class;
										gclass.RefAutoAccount.class75_0.int_55 = gclass.int_2;
										gclass.int_1 = gclass.RefAutoAccount.class59_0.int_1;
										if (Monitor.TryEnter(frmGLogin.object_0, 100))
										{
											frmGLogin.list_0.Remove(gclass);
											Monitor.Exit(frmGLogin.object_0);
										}
										IL_235:
										goto IL_325;
									}
								}
								goto IL_235;
							}
							catch (Exception)
							{
								goto IL_325;
							}
							goto IL_240;
						}
						IL_264:
						if (flag)
						{
							continue;
						}
						if (frmLogin.class101_0.class210_0.Count - count < count2)
						{
							continue;
						}
						break;
						IL_240:
						if (num2 == 0L)
						{
							num2 = frmLogin.stopwatch_0.ElapsedMilliseconds + 45000L;
						}
						if (frmLogin.stopwatch_0.ElapsedMilliseconds <= num2)
						{
							flag = true;
							goto IL_264;
						}
						if (frmGLogin.list_0.Count <= 0)
						{
							break;
						}
						for (int k = frmGLogin.list_0.Count - 1; k >= 0; k--)
						{
							frmGLogin.list_0[k].bool_3 = false;
							frmGLogin.list_0[k].RefAutoAccount = null;
							frmGLogin.list_0[k].int_3 = 0;
							frmGLogin.list_0[k].long_2 = 0L;
						}
						if (Monitor.TryEnter(frmGLogin.object_0, 100))
						{
							frmGLogin.list_0.Clear();
							Monitor.Exit(frmGLogin.object_0);
							break;
						}
						break;
					}
				}
				Thread.Sleep(100);
			}
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x000A19E4 File Offset: 0x0009FBE4
		private void method_0()
		{
			this.listGLogin.RowHeight = 36;
			this.olvcolumn_5.AspectGetter = new AspectGetterDelegate(frmGLogin.<>c.<>c_0.method_0);
			this.olvcolumn_5.Renderer = new MappedImageRenderer(new object[]
			{
				true,
				Class212.cbox1,
				false,
				Class212.cbox2
			});
			this.olvcolumn_3.ImageGetter = new ImageGetterDelegate(frmGLogin.<>c.<>c_0.method_1);
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x000A1A8C File Offset: 0x0009FC8C
		private void frmGLogin_Load(object sender, EventArgs e)
		{
			this.olvcolumn_5.AspectGetter = new AspectGetterDelegate(frmGLogin.<>c.<>c_0.method_2);
			this.olvcolumn_5.Renderer = new MappedImageRenderer(new object[]
			{
				true,
				Class212.cbox1,
				false,
				Class212.cbox2
			});
			this.olvcolumn_7.AspectGetter = new AspectGetterDelegate(frmGLogin.<>c.<>c_0.method_3);
			this.olvcolumn_7.Renderer = new MappedImageRenderer(new object[]
			{
				true,
				Class212.cbox1,
				false,
				Class212.cbox2
			});
			this.olvcolumn_6.AspectGetter = new AspectGetterDelegate(frmGLogin.<>c.<>c_0.method_4);
			this.olvcolumn_6.Renderer = new MappedImageRenderer(new object[]
			{
				true,
				Class212.entergame,
				false,
				""
			});
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00009B61 File Offset: 0x00007D61
		private void btnEditProfile_Click(object sender, EventArgs e)
		{
			this.method_5();
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x000024E9 File Offset: 0x000006E9
		private void cboNPH_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x000A1BC0 File Offset: 0x0009FDC0
		private void cboxAgreement_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;
			if (checkBox.Focused)
			{
				frmLogin.class101_0.globalSettings_0.cboxAgreement = checkBox.Checked;
			}
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x000A1BF4 File Offset: 0x0009FDF4
		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (0L < this.long_7 && this.long_7 <= frmLogin.stopwatch_0.ElapsedMilliseconds)
			{
				try
				{
					this.long_7 = 0L;
				}
				catch (Exception)
				{
				}
				this.method_1();
			}
			if (frmLogin.class101_0.globalSettings_0.ListLoginProfile.Count != this.int_0 && base.Visible)
			{
				this.int_0 = frmLogin.class101_0.globalSettings_0.ListLoginProfile.Count;
				this.lbTotal.Text = string.Format(frmMain.String_779, this.int_0);
			}
			if (!this.cboxAgreement.Focused)
			{
				this.cboxAgreement.Checked = frmLogin.class101_0.globalSettings_0.cboxAgreement;
			}
			if (frmLogin.class101_0.globalSettings_0.cboxAgreement && this.long_3 == 0L)
			{
				this.long_3 = frmGLogin.smethod_2() + 1000L;
				this.lblAgreement.ForeColor = Color.RosyBrown;
				this.lblAgreementTitle.ForeColor = Color.RosyBrown;
				this.cboxAgreement.ForeColor = Color.Gainsboro;
				this.cboxAgreement.Enabled = false;
			}
			if (0L < this.long_2 && this.long_2 <= frmGLogin.smethod_2() && frmLogin.class101_0.globalSettings_0.AllInformationLoaded)
			{
				this.long_2 = 0L;
				frmGLogin.smethod_9("Trạng thái: lưu danh sách profiles...", Color.DarkGreen, 5000);
				frmLogin.smethod_9(frmLogin.class101_0.globalSettings_0.ListLoginProfile, "ListLoginProfile");
			}
			if (0L < frmGLogin.long_4 && frmGLogin.long_4 <= frmGLogin.smethod_2())
			{
				this.lbStatus.Text = "Trạng thái: sẵn sàng đăng nhập";
				frmGLogin.long_4 = 0L;
				this.lbStatus.ForeColor = Color.Black;
			}
			if (frmLogin.class101_0.globalSettings_0.ListLoginProfile.Count > 0)
			{
				for (int i = frmLogin.class101_0.globalSettings_0.ListLoginProfile.Count - 1; i >= 0; i--)
				{
					if (frmLogin.class101_0.globalSettings_0.ListLoginProfile[i].RefAutoAccount == null && frmLogin.class101_0.globalSettings_0.ListLoginProfile[i].imgCaptcha != null)
					{
						frmLogin.class101_0.globalSettings_0.ListLoginProfile[i].imgCaptcha = null;
					}
				}
			}
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x000A1E50 File Offset: 0x000A0050
		private void frmGLogin_Shown(object sender, EventArgs e)
		{
			this.timer_0.Enabled = true;
			if (!(frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN"))
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					this.cboNPH.Items[0] = "D.Oath";
					this.cboNPH.Items[1] = "69Dragon";
					this.cboNPH.Items[2] = "Others";
				}
				else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
				{
					this.cboNPH.Items[0] = "CIBMal";
					this.cboNPH.Items[1] = "Changyou";
					this.cboNPH.Items[2] = "Others";
				}
			}
			this.method_1();
			this.cboxNoLoginGame.Checked = frmLogin.class101_0.globalSettings_0.cboxNoLoginGame;
			this.cboxResetOutGame.Checked = frmLogin.class101_0.globalSettings_0.cboxResetOutGame;
			this.tbDelayLogin.Text = frmLogin.class101_0.globalSettings_0.tbDelayLogin.ToString();
			this.tbDelayOutGame.Text = frmLogin.class101_0.globalSettings_0.tbDelayOutGame.ToString();
			this.tbDelayNhanGameSom.Text = frmLogin.class101_0.globalSettings_0.tbDelayNhanGameSom.ToString();
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x000A1FE4 File Offset: 0x000A01E4
		internal void method_1()
		{
			if (frmLogin.class101_0.class210_0.Count > 0)
			{
				try
				{
					int i = frmLogin.class101_0.class210_0.Count - 1;
					IL_1D7:
					while (i >= 0)
					{
						Class58 @class = frmLogin.class101_0.class210_0[i];
						int j = 0;
						while (j < frmLogin.class101_0.globalSettings_0.ListLoginProfile.Count)
						{
							GClass2 gclass = frmLogin.class101_0.globalSettings_0.ListLoginProfile[j];
							if (gclass.RefAutoAccount == null)
							{
								gclass.CharName == "Karami";
								bool flag = false;
								if (@class.class114_0.string_0 != "" && string.Compare(@class.class114_0.string_0, gclass.Username, true) == 0)
								{
									flag = true;
								}
								if (@class.class114_0.string_3 != "" && string.Compare(@class.class114_0.string_3, gclass.CharName, true) == 0)
								{
									flag = true;
								}
								bool flag2 = false;
								if ((gclass.NPHShortName == "VNG" && @class.class59_0.int_2 <= 2) || (gclass.NPHShortName == "TK" && @class.class59_0.int_2 == 3) || ((gclass.NPHShortName == "OT" || gclass.NPHShortName == "Server khác") && @class.class59_0.int_2 > 3))
								{
									flag2 = true;
								}
								if (flag && flag2)
								{
									gclass.RefAutoAccount = @class;
									@class.gclass2_0 = gclass;
									@class.class59_0.bool_25 = true;
									if (@class.class114_0.string_3 != "")
									{
										gclass.CharName = @class.class114_0.string_3;
										break;
									}
									break;
								}
							}
							else if (gclass.RefAutoAccount != null && gclass.RefAutoAccount == @class)
							{
								break;
							}
							j++;
							continue;
							IL_1D3:
							i--;
							goto IL_1D7;
						}
						goto IL_1D3;
					}
				}
				catch (Exception ex)
				{
					Class83.smethod_66("Error attaching profile to account. Msg: " + ex.Message, null, new object[0]);
				}
			}
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00009B69 File Offset: 0x00007D69
		private void btnThemProfile_Click(object sender, EventArgs e)
		{
			this.method_2();
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x000A2210 File Offset: 0x000A0410
		private void method_2()
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
								this.listGLogin.UpdateObject(gclass2);
								break;
							}
						}
					}
					if (!flag2)
					{
						frmLogin.class101_0.globalSettings_0.ListLoginProfile.method_1(gclass);
						this.listGLogin.SetObjects(frmLogin.class101_0.globalSettings_0.ListLoginProfile);
						if (frmLogin.class101_0.globalSettings_0.ListLoginProfile.Count > 0)
						{
							this.listGLogin.EnsureVisible(this.listGLogin.GetItemCount() - 1);
						}
					}
					this.long_2 = frmGLogin.smethod_2() + this.long_1;
				}
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

		// Token: 0x060008B9 RID: 2233 RVA: 0x00009B71 File Offset: 0x00007D71
		private void btnDelProfile_Click(object sender, EventArgs e)
		{
			this.method_3();
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x000A2608 File Offset: 0x000A0808
		private void method_3()
		{
			if (this.listGLogin.SelectedObjects != null && this.listGLogin.SelectedObjects.Count > 0)
			{
				int num = this.listGLogin.IndexOf(this.listGLogin.SelectedObjects[0]) - 1;
				if (num < 0)
				{
					num = 0;
				}
				for (int i = this.listGLogin.SelectedObjects.Count - 1; i >= 0; i--)
				{
					try
					{
						frmLogin.class101_0.globalSettings_0.ListLoginProfile.method_0((GClass2)this.listGLogin.SelectedObjects[i]);
					}
					catch (Exception)
					{
					}
				}
				this.listGLogin.SetObjects(frmLogin.class101_0.globalSettings_0.ListLoginProfile);
				if (num > this.listGLogin.GetItemCount() - 1)
				{
					num = this.listGLogin.GetItemCount() - 1;
				}
				if (0 <= num && num <= this.listGLogin.Items.Count - 1)
				{
					this.listGLogin.SelectedIndex = num;
					this.listGLogin.EnsureVisible(num);
				}
				this.long_2 = frmGLogin.smethod_2() + this.long_1;
			}
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00009B79 File Offset: 0x00007D79
		private void method_4(object sender, MouseEventArgs e)
		{
			if (0L < this.long_5 && this.long_5 < frmGLogin.smethod_2())
			{
				return;
			}
			this.method_5();
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x000A2738 File Offset: 0x000A0938
		private void method_5()
		{
			if (this.listGLogin.SelectedObjects != null && this.listGLogin.SelectedObjects.Count > 0)
			{
				GClass2 gclass = (GClass2)this.listGLogin.SelectedObjects[0];
				if (gclass != null)
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

		// Token: 0x060008BD RID: 2237 RVA: 0x000A2804 File Offset: 0x000A0A04
		private void btnBrowseVNG_Click(object sender, EventArgs e)
		{
			string text = this.method_6();
			this.tboxGameFile.Text = text;
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x000A2824 File Offset: 0x000A0A24
		private string method_6()
		{
			string result = "";
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "TLBB Game.exe | Game.exe";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				result = openFileDialog.FileName;
			}
			return result;
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x000A285C File Offset: 0x000A0A5C
		private void cboServer_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.listGLogin.SelectedObjects != null && this.listGLogin.SelectedObjects.Count > 1)
			{
				foreach (object obj in this.listGLogin.SelectedObjects)
				{
					if (obj != null)
					{
						((GClass2)obj).Server = this.cboServer.Text;
					}
				}
				this.long_2 = frmGLogin.smethod_2() + this.long_1;
			}
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x000A28FC File Offset: 0x000A0AFC
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

		// Token: 0x060008C1 RID: 2241 RVA: 0x000024E9 File Offset: 0x000006E9
		private void cboHopKiem_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x000A2B84 File Offset: 0x000A0D84
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

		// Token: 0x060008C3 RID: 2243 RVA: 0x00009B99 File Offset: 0x00007D99
		private void toolStripMenuItem_0_Click(object sender, EventArgs e)
		{
			frmGLogin.smethod_3(null, -1);
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_7(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x000024E9 File Offset: 0x000006E9
		private void GLoginContextMenu_Opening(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00009B99 File Offset: 0x00007D99
		private void method_8(object sender, EventArgs e)
		{
			frmGLogin.smethod_3(null, -1);
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x000A2C14 File Offset: 0x000A0E14
		private void listGLogin_CellEditStarting(object sender, CellEditEventArgs e)
		{
			if (e.SubItemIndex == this.dictionary_0["entercaptcha"] && e.RowObject != null && ((GClass2)e.RowObject).RefAutoAccount != null)
			{
				TextBox textBox = new TextBox();
				textBox.Bounds = e.CellBounds;
				textBox.Multiline = true;
				textBox.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, 0);
				textBox.Text = this.string_0;
				textBox.Select(textBox.Text.Length, 0);
				e.Control = textBox;
			}
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x000A2CAC File Offset: 0x000A0EAC
		private void method_9(object sender, CellClickEventArgs e)
		{
			if (this.long_5 == 0L || (0L < this.long_5 && this.long_5 < frmGLogin.smethod_2()))
			{
				if (e.ClickCount == 2)
				{
					if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
					{
						this.method_5();
						return;
					}
				}
				else if (e.ColumnIndex == this.dictionary_0["AI"])
				{
					GClass2 gclass = (GClass2)e.Model;
					if (gclass != null && gclass.RefAutoAccount != null)
					{
						if (e.Item.Text == "True")
						{
							Class55.smethod_18(gclass.RefAutoAccount);
							return;
						}
						Class55.smethod_19(gclass.RefAutoAccount);
						return;
					}
				}
				else if (e.ColumnIndex == this.dictionary_0["enter"])
				{
					frmGLogin.smethod_3((GClass2)e.Model, -1);
				}
			}
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x000A2D90 File Offset: 0x000A0F90
		private void method_10(GClass2 gclass2_0)
		{
			if (gclass2_0.long_0 <= frmGLogin.smethod_2())
			{
				gclass2_0.long_0 = frmGLogin.smethod_2() + 1000L;
				if (gclass2_0.RefAutoAccount != null && !gclass2_0.RefAutoAccount.class75_0.Boolean_0)
				{
					gclass2_0.RefAutoAccount.method_135(20);
				}
			}
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00003C2E File Offset: 0x00001E2E
		internal static long smethod_2()
		{
			return frmLogin.stopwatch_0.ElapsedMilliseconds;
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_11(object sender, CellClickEventArgs e)
		{
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x000024E9 File Offset: 0x000006E9
		private void listGLogin_SelectionChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x000024E9 File Offset: 0x000006E9
		private void listGLogin_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x000A2DE4 File Offset: 0x000A0FE4
		private void listGLogin_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar != '\r')
			{
				if ('0' <= e.KeyChar && e.KeyChar <= '9' && this.listGLogin.SelectedObject != null)
				{
					GClass2 gclass = (GClass2)this.listGLogin.SelectedObject;
					if (gclass.RefAutoAccount != null && !gclass.RefAutoAccount.class75_0.Boolean_0 && gclass.imgCaptcha != null)
					{
						this.string_0 = e.KeyChar.ToString();
						this.listGLogin.EditSubItem(this.listGLogin.ModelToItem(gclass), this.dictionary_0["entercaptcha"]);
					}
				}
				return;
			}
			int num = this.listGLogin.SelectedIndex;
			if (-1 < num && num < this.listGLogin.Items.Count - 1)
			{
				num++;
			}
			if (this.listGLogin.SelectedObjects != null && this.listGLogin.SelectedObjects.Count > 0)
			{
				for (int i = 0; i < this.listGLogin.SelectedObjects.Count; i++)
				{
					GClass2 gclass2 = (GClass2)this.listGLogin.SelectedObjects[i];
					if (gclass2.captchaCode == "" && gclass2.RefAutoAccount != null && !gclass2.RefAutoAccount.class75_0.Boolean_0)
					{
						this.method_10(gclass2);
					}
					num = this.listGLogin.IndexOf(gclass2);
				}
				if (-1 < num && num < this.listGLogin.Items.Count - 1)
				{
					num++;
				}
			}
			this.listGLogin.SelectedIndex = num;
			this.listGLogin.FocusedItem = this.listGLogin.SelectedItems[0];
			if (num <= this.listGLogin.Items.Count - 1)
			{
				this.listGLogin.EnsureVisible(num);
				return;
			}
			this.listGLogin.EnsureVisible(this.listGLogin.Items.Count - 1);
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x000A2FD8 File Offset: 0x000A11D8
		private void listGLogin_CellEditFinished(object sender, CellEditEventArgs e)
		{
			this.string_0 = "";
			e.Cancel = true;
			e.AutoDispose = true;
			e.Control = null;
			if (e.NewValue != null && e.SubItemIndex == this.dictionary_0["entercaptcha"])
			{
				string text = e.NewValue.ToString();
				bool flag = Class83.smethod_13(text);
				GClass2 gclass = (GClass2)e.RowObject;
				bool flag2 = false;
				if (gclass != null && gclass.RefAutoAccount != null && !gclass.RefAutoAccount.class75_0.Boolean_0)
				{
					flag2 = true;
				}
				if (text.Length == 4 && !this.cboxNoLoginGame.Checked && flag && flag2)
				{
					frmGLogin.smethod_8((GClass2)e.RowObject, true, true, 100);
				}
				else if (text.Length == 4 && this.cboxNoLoginGame.Checked && flag && flag2)
				{
					frmGLogin.smethod_8((GClass2)e.RowObject, false, true, 100);
				}
				else if (flag2 && string.IsNullOrEmpty(e.NewValue.ToString()))
				{
					this.method_10(gclass);
				}
				int num = this.listGLogin.IndexOf(gclass);
				if (num < this.listGLogin.Items.Count - 1)
				{
					this.listGLogin.SelectedIndex = num + 1;
					GClass2 gclass2 = (GClass2)this.listGLogin.GetModelObject(num + 1);
					if (gclass2 != null && gclass2.RefAutoAccount != null && !gclass2.RefAutoAccount.class75_0.Boolean_0)
					{
						this.listGLogin.SelectedIndex = this.listGLogin.IndexOf(gclass2);
						this.listGLogin.FocusedItem = this.listGLogin.SelectedItems[0];
						if (0 <= this.listGLogin.SelectedIndex && this.listGLogin.SelectedIndex <= this.listGLogin.Items.Count - 1)
						{
							this.listGLogin.EnsureVisible(this.listGLogin.SelectedIndex);
							return;
						}
						this.listGLogin.EnsureVisible(this.listGLogin.Items.Count - 1);
					}
				}
			}
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x000A31F8 File Offset: 0x000A13F8
		internal static void smethod_3(GClass2 gclass2_0 = null, int int_2 = -1)
		{
			List<GClass2> list = new List<GClass2>();
			if (gclass2_0 != null)
			{
				gclass2_0.int_2 = int_2;
				list.Add(gclass2_0);
			}
			else if (frmGLogin.frmGLogin_0.listGLogin.SelectedObjects != null && frmGLogin.frmGLogin_0.listGLogin.SelectedObjects.Count > 0)
			{
				for (int i = 0; i < frmGLogin.frmGLogin_0.listGLogin.SelectedObjects.Count; i++)
				{
					GClass2 gclass = (GClass2)frmGLogin.frmGLogin_0.listGLogin.SelectedObjects[i];
					if (gclass != null)
					{
						gclass.int_2 = int_2;
						list.Add(gclass);
					}
				}
			}
			List<string> list2 = new List<string>();
			if (list.Count > 0)
			{
				for (int j = list.Count - 1; j >= 0; j--)
				{
					gclass2_0 = list[j];
					bool flag = false;
					if (list2.Count > 0)
					{
						for (int k = 0; k < list2.Count; k++)
						{
							if (list2[k] == gclass2_0.GamePath)
							{
								flag = true;
								break;
							}
						}
					}
					if (!flag && File.Exists(gclass2_0.GamePath))
					{
						if (!list2.Contains(gclass2_0.GamePath))
						{
							list2.Add(gclass2_0.GamePath);
						}
						flag = true;
					}
					if (frmGLogin.smethod_4(gclass2_0, list, flag) && Monitor.TryEnter(frmGLogin.object_0, 200))
					{
						frmGLogin.list_0.Add(gclass2_0);
						Monitor.Exit(frmGLogin.object_0);
					}
				}
			}
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x000A3368 File Offset: 0x000A1568
		private static bool smethod_4(GClass2 gclass2_0, List<GClass2> list_1, bool bool_1 = false)
		{
			bool result = true;
			if (!bool_1 && File.Exists(gclass2_0.GamePath))
			{
				bool_1 = true;
			}
			if (bool_1)
			{
				if (!frmGLogin.smethod_6(gclass2_0))
				{
					frmGLogin.smethod_5(gclass2_0, list_1, true);
					result = false;
				}
			}
			else
			{
				frmGLogin.smethod_5(gclass2_0, list_1, true);
				result = false;
			}
			return result;
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00009BA2 File Offset: 0x00007DA2
		private static void smethod_5(GClass2 gclass2_0, List<GClass2> list_1, bool bool_1 = true)
		{
			gclass2_0.bool_3 = false;
			gclass2_0.int_3 = 0;
			gclass2_0.long_2 = 0L;
			if (bool_1 && Monitor.TryEnter(frmGLogin.object_0, 200))
			{
				list_1.Remove(gclass2_0);
				Monitor.Exit(frmGLogin.object_0);
			}
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00009BE0 File Offset: 0x00007DE0
		internal static bool smethod_6(GClass2 gclass2_0)
		{
			if (gclass2_0 != null && frmGLogin.smethod_7(gclass2_0, true))
			{
				frmMain.smethod_2(1, gclass2_0.GamePath, gclass2_0.GamePath.Remove(gclass2_0.GamePath.LastIndexOf("\\"), 9));
				return true;
			}
			return false;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x000A33B0 File Offset: 0x000A15B0
		private static bool smethod_7(GClass2 gclass2_0, bool bool_1 = true)
		{
			bool flag = true;
			if (gclass2_0.RefAutoAccount != null)
			{
				if (bool_1)
				{
					IntPtr intPtr = IntPtr.Zero;
					try
					{
						intPtr = Class159.OpenProcess(33554432U, 0, (uint)gclass2_0.RefAutoAccount.class59_0.int_1);
						if (intPtr != IntPtr.Zero)
						{
							StringBuilder stringBuilder_ = new StringBuilder(255);
							if (Class159.GetModuleFileNameEx(intPtr, IntPtr.Zero, stringBuilder_, 255) > 0U)
							{
								flag = false;
							}
						}
					}
					catch (Exception)
					{
					}
				}
				if (flag && gclass2_0.RefAutoAccount.class75_0.Boolean_0)
				{
					flag = false;
				}
				if (flag)
				{
					gclass2_0.bool_1 = false;
					gclass2_0.bool_3 = false;
				}
				if (gclass2_0.long_1 <= frmGLogin.smethod_2() && flag)
				{
					try
					{
						gclass2_0.RefAutoAccount.gclass2_0 = null;
					}
					catch (Exception)
					{
					}
					gclass2_0.RefAutoAccount = null;
					gclass2_0.imgCaptcha = null;
				}
			}
			return flag;
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x000A3498 File Offset: 0x000A1698
		internal static void smethod_8(GClass2 gclass2_0, bool bool_1 = true, bool bool_2 = true, int int_2 = 100)
		{
			if (gclass2_0.RefAutoAccount != null && !gclass2_0.RefAutoAccount.class75_0.Boolean_0 && gclass2_0.imgCaptcha != null && gclass2_0.captchaCode != "" && gclass2_0.captchaCode != "Code..." && Class83.smethod_13(gclass2_0.captchaCode))
			{
				if (bool_2)
				{
					Class83.smethod_7(gclass2_0.RefAutoAccount.class59_0.intptr_10, gclass2_0.captchaCode);
				}
				if (bool_1)
				{
					Class83.smethod_8(gclass2_0.RefAutoAccount.class59_0.intptr_10, 13);
					if (int_2 > 0)
					{
						Thread.Sleep(int_2);
					}
					gclass2_0.RefAutoAccount.method_135(29);
					gclass2_0.captchaCode = "";
					gclass2_0.imgCaptcha = null;
				}
			}
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00009C1B File Offset: 0x00007E1B
		private void listGLogin_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				this.GLoginContextMenu.Show(this.listGLogin, e.Location);
				return;
			}
			MouseButtons button = e.Button;
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x000024E9 File Offset: 0x000006E9
		private void listGLogin_MouseDoubleClick(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00009B61 File Offset: 0x00007D61
		private void method_12(object sender, EventArgs e)
		{
			this.method_5();
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00009B71 File Offset: 0x00007D71
		private void toolStripMenuItem_1_Click(object sender, EventArgs e)
		{
			this.method_3();
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x000A3568 File Offset: 0x000A1768
		private void toolStripMenuItem_2_Click(object sender, EventArgs e)
		{
			if (this.listGLogin.SelectedObjects != null && this.listGLogin.SelectedObjects.Count > 0)
			{
				string text = this.method_6();
				if (text != "")
				{
					for (int i = 0; i < this.listGLogin.SelectedObjects.Count; i++)
					{
						((GClass2)this.listGLogin.SelectedObjects[i]).GamePath = text;
					}
					this.long_2 = frmGLogin.smethod_2() + this.long_1;
				}
			}
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x000A35F4 File Offset: 0x000A17F4
		internal static void smethod_9(string string_1, Color color_0, int int_2 = 5000)
		{
			frmGLogin.Class172 @class = new frmGLogin.Class172();
			@class.string_0 = string_1;
			@class.color_0 = color_0;
			@class.int_0 = int_2;
			frmGLogin.frmGLogin_0.lbStatus.Invoke(new MethodInvoker(@class.method_0));
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x000024E9 File Offset: 0x000006E9
		private void lbStatus_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x0000997A File Offset: 0x00007B7A
		private void frmGLogin_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			base.Hide();
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x000A3638 File Offset: 0x000A1838
		private void method_13(object sender, OlvDropEventArgs e)
		{
			OLVDataObject olvdataObject = (OLVDataObject)e.DataObject;
			bool flag = true;
			if (olvdataObject.ModelObjects.Count > 0)
			{
				int num = -1;
				try
				{
					foreach (object obj in olvdataObject.ModelObjects)
					{
						GClass2 item = (GClass2)obj;
						if (num == -1)
						{
							num = frmLogin.class101_0.globalSettings_0.ListLoginProfile.IndexOf(item);
						}
						int num2 = frmLogin.class101_0.globalSettings_0.ListLoginProfile.IndexOf(item);
						if (Math.Abs(num - num2) > 1)
						{
							flag = false;
							break;
						}
						num = num2;
					}
				}
				catch (Exception)
				{
					e.Effect = DragDropEffects.None;
					return;
				}
			}
			bool flag2 = false;
			if (0 <= e.DropTargetIndex && e.DropTargetIndex < this.listGLogin.Items.Count)
			{
				flag2 = true;
			}
			int num3 = this.listGLogin.Items.Count - e.DropTargetIndex;
			if (olvdataObject.ModelObjects.Count > 0 && olvdataObject.ModelObjects.Count <= num3 && flag2 && flag)
			{
				e.Effect = DragDropEffects.Move;
				return;
			}
			if (!flag)
			{
				e.InfoMessage = frmMain.String_780;
			}
			e.Effect = DragDropEffects.None;
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x000A3794 File Offset: 0x000A1994
		private void method_14(object sender, OlvDropEventArgs e)
		{
			OLVDataObject olvdataObject = (OLVDataObject)e.DataObject;
			if (olvdataObject.ModelObjects.Count > 0)
			{
				int count = this.listGLogin.Items.Count;
				int num = frmLogin.class101_0.globalSettings_0.ListLoginProfile.IndexOf((GClass2)olvdataObject.ModelObjects[0]);
				GClass2 item = (GClass2)this.listGLogin.GetModelObject(e.DropTargetIndex);
				int num2 = frmLogin.class101_0.globalSettings_0.ListLoginProfile.IndexOf(item);
				if (num2 < num)
				{
					try
					{
						for (int i = olvdataObject.ModelObjects.Count - 1; i >= 0; i--)
						{
							GClass2 gclass = (GClass2)olvdataObject.ModelObjects[i];
							frmLogin.class101_0.globalSettings_0.ListLoginProfile.IndexOf(gclass);
							int index = (num2 == 0) ? 0 : num2;
							frmLogin.class101_0.globalSettings_0.ListLoginProfile.method_0(gclass);
							frmLogin.class101_0.globalSettings_0.ListLoginProfile.Insert(index, gclass);
						}
						goto IL_1A5;
					}
					catch (Exception)
					{
						goto IL_1A5;
					}
				}
				if (num2 > num)
				{
					try
					{
						for (int j = 0; j < olvdataObject.ModelObjects.Count; j++)
						{
							GClass2 gclass2 = (GClass2)olvdataObject.ModelObjects[j];
							frmLogin.class101_0.globalSettings_0.ListLoginProfile.IndexOf(gclass2);
							int index2 = (num2 == count - 1) ? (count - 1) : num2;
							frmLogin.class101_0.globalSettings_0.ListLoginProfile.method_0(gclass2);
							frmLogin.class101_0.globalSettings_0.ListLoginProfile.Insert(index2, gclass2);
						}
					}
					catch (Exception)
					{
					}
				}
				IL_1A5:
				e.Handled = true;
			}
			if (e.Handled)
			{
				this.listGLogin.SetObjects(frmLogin.class101_0.globalSettings_0.ListLoginProfile);
				this.long_2 = frmGLogin.smethod_2() + this.long_1;
				if (this.listGLogin.Items.Count > 0)
				{
					this.listGLogin.EnsureVisible(e.DropTargetIndex);
				}
				this.listGLogin.SelectObjects(olvdataObject.ModelObjects);
				this.listGLogin.FocusedObject = olvdataObject.ModelObjects[0];
			}
			this.long_5 = frmGLogin.smethod_2() + 50L;
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x000A39F8 File Offset: 0x000A1BF8
		private void toolStripMenuItem_3_Click(object sender, EventArgs e)
		{
			if (this.listGLogin.SelectedObjects.Count > 0)
			{
				for (int i = this.listGLogin.SelectedObjects.Count - 1; i >= 0; i--)
				{
					GClass2 gclass = (GClass2)this.listGLogin.SelectedObjects[i];
					frmLogin.class101_0.globalSettings_0.ListLoginProfile.method_0(gclass);
					frmLogin.class101_0.globalSettings_0.ListLoginProfile.Insert(0, gclass);
				}
				this.listGLogin.SetObjects(frmLogin.class101_0.globalSettings_0.ListLoginProfile);
				this.listGLogin.SelectedIndex = 0;
				this.listGLogin.EnsureVisible(0);
				this.long_2 = frmGLogin.smethod_2() + this.long_1;
			}
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x000A3AC0 File Offset: 0x000A1CC0
		private void toolStripMenuItem_4_Click(object sender, EventArgs e)
		{
			if (this.listGLogin.SelectedObjects.Count > 0)
			{
				for (int i = this.listGLogin.SelectedObjects.Count - 1; i >= 0; i--)
				{
					GClass2 gclass = (GClass2)this.listGLogin.SelectedObjects[i];
					frmLogin.class101_0.globalSettings_0.ListLoginProfile.method_0(gclass);
					frmLogin.class101_0.globalSettings_0.ListLoginProfile.Insert(frmLogin.class101_0.globalSettings_0.ListLoginProfile.Count, gclass);
				}
				this.listGLogin.SetObjects(frmLogin.class101_0.globalSettings_0.ListLoginProfile);
				this.listGLogin.SelectedIndex = this.listGLogin.Items.Count - 1;
				this.listGLogin.EnsureVisible(this.listGLogin.Items.Count - 1);
				this.long_2 = frmGLogin.smethod_2() + this.long_1;
			}
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x000024E9 File Offset: 0x000006E9
		private void frmGLogin_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x000A3BBC File Offset: 0x000A1DBC
		private void frmGLogin_KeyDown(object sender, KeyEventArgs e)
		{
			if (!this.listGLogin.Focused && (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down))
			{
				int num = this.listGLogin.SelectedIndex;
				if (e.KeyCode == Keys.Up)
				{
					num--;
				}
				else if (e.KeyCode == Keys.Down)
				{
					num++;
				}
				if (num < 0)
				{
					num = 0;
				}
				if (num > this.listGLogin.Items.Count - 1)
				{
					num = this.listGLogin.Items.Count - 1;
				}
				if (0 <= num && num <= this.listGLogin.Items.Count - 1)
				{
					this.listGLogin.Focus();
					this.listGLogin.SelectedIndex = num;
					this.listGLogin.FocusedItem = this.listGLogin.SelectedItems[0];
					if (num <= this.listGLogin.Items.Count - 1)
					{
						this.listGLogin.EnsureVisible(num);
					}
					else
					{
						this.listGLogin.EnsureVisible(this.listGLogin.Items.Count - 1);
					}
				}
				e.SuppressKeyPress = true;
			}
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x000A3CE0 File Offset: 0x000A1EE0
		private void toolStripMenuItem_5_Click(object sender, EventArgs e)
		{
			if (this.listGLogin.SelectedObject != null)
			{
				GClass2 gclass = (GClass2)this.listGLogin.SelectedObject;
				if (gclass.RefAutoAccount != null && gclass.RefAutoAccount.class75_0.Boolean_0)
				{
					Class55.smethod_0(gclass.RefAutoAccount);
				}
			}
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x000A3D30 File Offset: 0x000A1F30
		private void toolStripMenuItem_6_Click(object sender, EventArgs e)
		{
			if (this.listGLogin.SelectedObject != null)
			{
				GClass2 gclass = (GClass2)this.listGLogin.SelectedObject;
				if (gclass.RefAutoAccount != null && gclass.RefAutoAccount.class75_0.Boolean_0)
				{
					Class55.smethod_16(gclass.RefAutoAccount);
				}
			}
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x000A3D80 File Offset: 0x000A1F80
		private void toolStripMenuItem_7_Click(object sender, EventArgs e)
		{
			List<Class58> list = this.method_16();
			if (list.Count > 0)
			{
				Class55.smethod_15(list);
			}
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x000A3DA4 File Offset: 0x000A1FA4
		private List<GClass2> method_15()
		{
			List<GClass2> list = new List<GClass2>();
			if (this.listGLogin.SelectedObjects != null && this.listGLogin.SelectedObjects.Count > 0)
			{
				for (int i = 0; i < this.listGLogin.SelectedObjects.Count; i++)
				{
					GClass2 gclass = (GClass2)this.listGLogin.SelectedObjects[i];
					if (gclass != null)
					{
						list.Add(gclass);
					}
				}
			}
			return list;
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x000A3E14 File Offset: 0x000A2014
		private List<Class58> method_16()
		{
			List<Class58> list = new List<Class58>();
			if (this.listGLogin.SelectedObjects != null && this.listGLogin.SelectedObjects.Count > 0)
			{
				for (int i = 0; i < this.listGLogin.SelectedObjects.Count; i++)
				{
					GClass2 gclass = (GClass2)this.listGLogin.SelectedObjects[i];
					if (gclass != null && gclass.RefAutoAccount != null)
					{
						list.Add(gclass.RefAutoAccount);
					}
				}
			}
			return list;
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x000A3E94 File Offset: 0x000A2094
		private void toolStripMenuItem_8_Click(object sender, EventArgs e)
		{
			List<Class58> list = this.method_16();
			if (list.Count > 0)
			{
				Class55.smethod_2(list);
			}
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x000A3EB8 File Offset: 0x000A20B8
		private void toolStripMenuItem_9_Click(object sender, EventArgs e)
		{
			List<Class58> list = this.method_16();
			if (list.Count > 0)
			{
				Class55.smethod_4(list);
			}
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x000A3EDC File Offset: 0x000A20DC
		private void toolStripMenuItem_10_Click(object sender, EventArgs e)
		{
			List<Class58> list = this.method_16();
			if (list.Count > 0)
			{
				Class55.smethod_5(list, 0);
			}
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x000A3F00 File Offset: 0x000A2100
		private void toolStripMenuItem_11_Click(object sender, EventArgs e)
		{
			List<Class58> list = this.method_16();
			if (list.Count > 0)
			{
				Class55.smethod_5(list, 1);
			}
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x000A3F24 File Offset: 0x000A2124
		private void toolStripMenuItem_12_Click(object sender, EventArgs e)
		{
			List<Class58> list = this.method_16();
			if (list.Count > 0)
			{
				Class55.smethod_13(list);
			}
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x000A3F48 File Offset: 0x000A2148
		private void toolStripMenuItem_13_Click(object sender, EventArgs e)
		{
			List<Class58> list = this.method_16();
			if (list.Count > 0)
			{
				Class55.smethod_6(list);
			}
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x000A3F6C File Offset: 0x000A216C
		private void toolStripMenuItem_14_Click(object sender, EventArgs e)
		{
			List<Class58> list = this.method_16();
			if (list.Count > 0)
			{
				Class55.smethod_12(list);
			}
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00009C4F File Offset: 0x00007E4F
		private void tboxUsername_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.method_17(e);
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00009C58 File Offset: 0x00007E58
		private void method_17(KeyPressEventArgs keyPressEventArgs_0)
		{
			if (keyPressEventArgs_0.KeyChar == '\r' || keyPressEventArgs_0.KeyChar == '\r')
			{
				this.method_2();
			}
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x000A3F90 File Offset: 0x000A2190
		internal static void smethod_10(GClass2 gclass2_0)
		{
			if (frmLogin.class101_0.globalSettings_0.optStartNewGame && File.Exists(gclass2_0.GamePath))
			{
				using (Process process = Process.Start(new ProcessStartInfo
				{
					FileName = gclass2_0.GamePath,
					Arguments = "-fl",
					WorkingDirectory = gclass2_0.GamePath.Remove(gclass2_0.GamePath.LastIndexOf("\\"), 9)
				}))
				{
					if (process.WaitForInputIdle(60000))
					{
						gclass2_0.int_1 = process.Id;
						long num = frmLogin.stopwatch_0.ElapsedMilliseconds + 30000L;
						long num2 = 0L;
						bool flag = false;
						while (frmLogin.stopwatch_0.ElapsedMilliseconds <= num)
						{
							Thread.Sleep(100);
							if (num2 <= frmLogin.stopwatch_0.ElapsedMilliseconds)
							{
								num2 = frmLogin.stopwatch_0.ElapsedMilliseconds + 1000L;
								if (frmLogin.class101_0.class210_0.Count > 0)
								{
									try
									{
										for (int i = frmLogin.class101_0.class210_0.Count - 1; i >= 0; i--)
										{
											if (frmLogin.class101_0.class210_0[i].gclass2_0 == null)
											{
												flag = true;
											}
											if (!frmLogin.class101_0.class210_0[i].class75_0.Boolean_0)
											{
												flag = true;
											}
											if (frmLogin.class101_0.class210_0[i].class59_0 != null && frmLogin.class101_0.class210_0[i].class59_0.int_1 == gclass2_0.int_1 && flag)
											{
												gclass2_0.imgCaptcha = null;
												frmLogin.class101_0.class210_0[i].gclass2_0 = gclass2_0;
												gclass2_0.RefAutoAccount = frmLogin.class101_0.class210_0[i];
												gclass2_0.RefAutoAccount.class75_0.int_55 = gclass2_0.int_2;
												num = 0L;
												break;
											}
										}
									}
									catch (Exception)
									{
									}
								}
							}
							if (num == 0L)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00009C4F File Offset: 0x00007E4F
		private void tboxPassword_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.method_17(e);
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00009C4F File Offset: 0x00007E4F
		private void tboxName_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.method_17(e);
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00009C4F File Offset: 0x00007E4F
		private void tboxGameFile_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.method_17(e);
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00009C4F File Offset: 0x00007E4F
		private void cboNPH_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.method_17(e);
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00009C4F File Offset: 0x00007E4F
		private void cboServer_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.method_17(e);
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00009C4F File Offset: 0x00007E4F
		private void cboHopKiem_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.method_17(e);
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00009C74 File Offset: 0x00007E74
		private void toolStripMenuItem_16_Click(object sender, EventArgs e)
		{
			frmGLogin.smethod_3(null, 1);
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x000A41C0 File Offset: 0x000A23C0
		private void toolStripMenuItem_18_Click(object sender, EventArgs e)
		{
			List<GClass2> list = this.method_15();
			if (list.Count > 0 && list[0].databaseIDStr != "")
			{
				Class163.smethod_9(null, list[0].databaseIDStr);
			}
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x000A4208 File Offset: 0x000A2408
		private void toolStripMenuItem_19_Click(object sender, EventArgs e)
		{
			List<GClass2> list = this.method_15();
			if (list.Count > 0)
			{
				List<string> list2 = new List<string>();
				foreach (GClass2 gclass in list)
				{
					if (gclass != null && gclass.databaseIDStr != "")
					{
						list2.Add(gclass.databaseIDStr);
					}
				}
				Class163.smethod_8(null, list2);
			}
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x000A4290 File Offset: 0x000A2490
		private void toolStripMenuItem_20_Click(object sender, EventArgs e)
		{
			List<GClass2> list = this.method_15();
			if (list.Count > 0)
			{
				if (list[0].databaseIDStr == "")
				{
					Class83.smethod_46("Bạn phải chọn profile nào đã có thiết lập rồi để áp dụng cho toàn auto", "Profile chưa đăng nhập", 10000, new object[0]);
					return;
				}
				Class163.smethod_6(null, list[0].databaseIDStr);
			}
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x000A42F4 File Offset: 0x000A24F4
		private void toolStripMenuItem_21_Click(object sender, EventArgs e)
		{
			List<GClass2> list = this.method_15();
			if (list.Count > 0)
			{
				List<string> list2 = new List<string>();
				foreach (GClass2 gclass in list)
				{
					if (gclass != null && gclass.databaseIDStr != "")
					{
						list2.Add(gclass.databaseIDStr);
					}
				}
				Class163.smethod_7(null, list2);
			}
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_18(object sender, EventArgs e)
		{
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x000A437C File Offset: 0x000A257C
		private void toolStripMenuItem_22_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < this.listGLogin.SelectedObjects.Count; i++)
			{
				GClass2 gclass = (GClass2)frmGLogin.frmGLogin_0.listGLogin.SelectedObjects[i];
				if (gclass.captchaCode.Length == 4)
				{
					frmGLogin.smethod_8(gclass, true, false, 0);
				}
			}
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x000A43D8 File Offset: 0x000A25D8
		private void cboxNoLoginGame_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;
			if (checkBox.Focused)
			{
				frmLogin.class101_0.globalSettings_0.cboxNoLoginGame = checkBox.Checked;
			}
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x000A440C File Offset: 0x000A260C
		private void cboxResetOutGame_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;
			if (checkBox.Focused)
			{
				frmLogin.class101_0.globalSettings_0.cboxResetOutGame = checkBox.Checked;
			}
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x000A4440 File Offset: 0x000A2640
		private void tbDelayLogin_Validating(object sender, CancelEventArgs e)
		{
			int num = 4;
			int.TryParse((sender as TextBox).Text, out num);
			frmLogin.class101_0.globalSettings_0.tbDelayLogin = num;
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x000A4474 File Offset: 0x000A2674
		private void tbDelayOutGame_Validating(object sender, CancelEventArgs e)
		{
			int num = 120;
			int.TryParse((sender as TextBox).Text, out num);
			frmLogin.class101_0.globalSettings_0.tbDelayOutGame = num;
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x000A44A8 File Offset: 0x000A26A8
		private void tbDelayNhanGameSom_Validating(object sender, CancelEventArgs e)
		{
			int num = 30;
			int.TryParse((sender as TextBox).Text, out num);
			frmLogin.class101_0.globalSettings_0.tbDelayNhanGameSom = num;
		}

		// Token: 0x04000B55 RID: 2901
		internal static List<GClass2> list_0 = new List<GClass2>();

		// Token: 0x04000B56 RID: 2902
		internal static object object_0 = new object();

		// Token: 0x04000B57 RID: 2903
		internal static Thread thread_0 = null;

		// Token: 0x04000B58 RID: 2904
		private int int_0;

		// Token: 0x04000B59 RID: 2905
		private bool bool_0;

		// Token: 0x04000B5A RID: 2906
		private string string_0 = "";

		// Token: 0x04000B5B RID: 2907
		private Class17 class17_0;

		// Token: 0x04000B5C RID: 2908
		private long long_0;

		// Token: 0x04000B5D RID: 2909
		private int int_1 = -1;

		// Token: 0x04000B5E RID: 2910
		internal static frmGLogin frmGLogin_0 = null;

		// Token: 0x04000B5F RID: 2911
		internal long long_1 = 2500L;

		// Token: 0x04000B60 RID: 2912
		internal long long_2;

		// Token: 0x04000B61 RID: 2913
		private long long_3;

		// Token: 0x04000B62 RID: 2914
		private static long long_4 = 0L;

		// Token: 0x04000B63 RID: 2915
		private long long_5;

		// Token: 0x04000B64 RID: 2916
		private Dictionary<string, int> dictionary_0 = new Dictionary<string, int>
		{
			{
				"AI",
				0
			},
			{
				"entercaptcha",
				6
			},
			{
				"enter",
				8
			}
		};

		// Token: 0x04000B65 RID: 2917
		private static long long_6 = 305000L;

		// Token: 0x04000B66 RID: 2918
		public long long_7;

		// Token: 0x020000EA RID: 234
		[CompilerGenerated]
		private sealed class Class172
		{
			// Token: 0x0600090F RID: 2319 RVA: 0x000A643C File Offset: 0x000A463C
			internal void method_0()
			{
				frmGLogin.frmGLogin_0.lbStatus.Text = this.string_0;
				frmGLogin.frmGLogin_0.lbStatus.ForeColor = this.color_0;
				if (this.int_0 <= 1000)
				{
					this.int_0 = 5000;
				}
				frmGLogin.long_4 = frmGLogin.smethod_2() + (long)this.int_0;
			}

			// Token: 0x04000BC2 RID: 3010
			public string string_0;

			// Token: 0x04000BC3 RID: 3011
			public Color color_0;

			// Token: 0x04000BC4 RID: 3012
			public int int_0;
		}
	}
}
