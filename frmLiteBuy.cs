using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using BrightIdeasSoftware;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x020000EE RID: 238
	internal sealed partial class frmLiteBuy : Form
	{
		// Token: 0x06000938 RID: 2360 RVA: 0x000A8934 File Offset: 0x000A6B34
		internal frmLiteBuy(bool bool_3 = false)
		{
			this.InitializeComponent();
			this.bool_1 = bool_3;
			this.lbUsername.DataBindings.Clear();
			this.lbUsername.DataBindings.Add("Text", frmLogin.class101_0.globalSettings_0.Account, "Username");
			this.lbGG.DataBindings.Clear();
			this.lbGG.DataBindings.Add("Text", frmLogin.class101_0.globalSettings_0.Account, "RemainGGDisplay");
			this.lbGGPromo.DataBindings.Clear();
			this.lbGGPromo.DataBindings.Add("Text", frmLogin.class101_0.globalSettings_0.Account, "RemainGGPromoDisplay");
			this.lbHanDung.DataBindings.Clear();
			this.lbHanDung.DataBindings.Add("Text", frmLogin.class101_0.globalSettings_0.Account, "Shorthandung");
			this.method_2();
			this.MinimumSize = new Size(base.Width, 300);
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00009E60 File Offset: 0x00008060
		private void method_0(bool bool_3)
		{
			this.method_1(bool_3);
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x000A8AB0 File Offset: 0x000A6CB0
		internal void method_1(bool bool_3)
		{
			if (this.bool_2 == bool_3 && bool_3)
			{
				this.bool_2 = !this.bool_2;
				this.pnelMuaGio.Visible = !bool_3;
				base.Height -= this.int_6;
				this.btnPackageExpand.Image = Class212.expand;
				return;
			}
			if (this.bool_2 == bool_3 && !bool_3)
			{
				this.bool_2 = !this.bool_2;
				this.pnelMuaGio.Visible = !bool_3;
				base.Height += this.int_6;
				this.btnPackageExpand.Image = Class212.collapse;
				return;
			}
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x000A8B5C File Offset: 0x000A6D5C
		private void method_2()
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			List<string> list4 = new List<string>();
			List<string> list5 = new List<string>();
			for (int i = 0; i < frmLogin.class101_0.globalSettings_0.Account.list_1.Count; i++)
			{
				Class39 @class = frmLogin.class101_0.globalSettings_0.Account.list_1[i];
				if (@class.string_0 == "time")
				{
					list.Add(@class.String_2);
				}
				else if (@class.string_0 == "tnchedo")
				{
					list2.Add(@class.String_2);
				}
				else if (@class.string_0 == "tnyto")
				{
					list4.Add(@class.String_2);
				}
				else if (@class.string_0 == "tnq12")
				{
					list5.Add(@class.String_2);
				}
				else
				{
					list3.Add(@class.String_2);
				}
			}
			if (list.Count > 0)
			{
				if (this.list_2.Count > 0)
				{
					for (int j = 0; j < this.list_2.Count; j++)
					{
						this.list_2[j].Visible = false;
						this.list_2[j].Dispose();
					}
					this.list_2.Clear();
				}
				for (int k = 0; k < list.Count; k++)
				{
					this.method_3(list[k], false, false, null);
				}
				GroupBox groupBox = new GroupBox();
				groupBox.Left = 0;
				groupBox.Top = this.int_5;
				groupBox.Width = this.groupLicenses.Width;
				groupBox.Height = list2.Count * 25 + 10;
				groupBox.Text = "Mua giờ chế đồ";
				this.int_4 = frmLiteBuy.int_0;
				this.int_5 = frmLiteBuy.int_1;
				this.groupLicenses.Controls.Add(groupBox);
				for (int l = 0; l < list2.Count; l++)
				{
					this.method_3(list2[l], true, false, groupBox);
				}
				GroupBox groupBox2 = new GroupBox();
				groupBox2.Left = 0;
				groupBox2.Top = groupBox.Top + groupBox.Height + 5;
				groupBox2.Width = this.groupLicenses.Width;
				groupBox2.Height = list4.Count * 25 + 15;
				groupBox2.Text = "Mua giờ Yến Tử Ổ + Q12";
				this.int_4 = frmLiteBuy.int_0;
				this.int_5 = frmLiteBuy.int_1;
				this.groupLicenses.Controls.Add(groupBox2);
				for (int m = 0; m < list4.Count; m++)
				{
					this.method_3(list4[m], true, false, groupBox2);
				}
				this.int_5 = frmLiteBuy.int_1;
				for (int n = 0; n < list5.Count; n++)
				{
					this.method_3(list5[n], true, true, groupBox2);
				}
			}
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x000A8E70 File Offset: 0x000A7070
		private void method_3(string string_0, bool bool_3 = false, bool bool_4 = false, Control control_0 = null)
		{
			RadioButton radioButton = new RadioButton();
			radioButton.Click += this.method_5;
			radioButton.CheckedChanged += this.method_4;
			radioButton.Text = string_0;
			if (!bool_3)
			{
				radioButton.Left = this.int_4;
			}
			else
			{
				if (!bool_4)
				{
					radioButton.Left = frmLiteBuy.int_0;
				}
				else
				{
					radioButton.Left = frmLiteBuy.int_0 + this.int_2;
				}
				if (!this.bool_0)
				{
					this.int_5 += this.int_3;
				}
				this.bool_0 = true;
			}
			radioButton.Top = this.int_5;
			radioButton.Width = 150;
			radioButton.AutoSize = true;
			if (control_0 == null)
			{
				this.groupLicenses.Controls.Add(radioButton);
			}
			else
			{
				control_0.Controls.Add(radioButton);
			}
			if (!bool_3)
			{
				if (this.bool_0)
				{
					this.bool_0 = false;
					this.int_4 += this.int_2;
				}
				else
				{
					this.bool_0 = true;
					this.int_5 += this.int_3;
					this.int_4 = frmLiteBuy.int_0;
				}
			}
			else
			{
				this.int_5 += this.int_3;
			}
			this.list_2.Add(radioButton);
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x000A8FB4 File Offset: 0x000A71B4
		private void method_4(object sender, EventArgs e)
		{
			RadioButton radioButton = sender as RadioButton;
			if (!radioButton.Checked)
			{
				if (radioButton.ForeColor == Color.DarkGreen)
				{
					radioButton.ForeColor = Color.Black;
				}
				if (this.list_0.Count > 0)
				{
					for (int i = this.list_0.Count - 1; i >= 0; i--)
					{
						if (this.list_0[i].String_2 == radioButton.Text)
						{
							this.list_0.RemoveAt(i);
							return;
						}
					}
				}
			}
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x000A9040 File Offset: 0x000A7240
		private void method_5(object sender, EventArgs e)
		{
			RadioButton radioButton = sender as RadioButton;
			if (radioButton.Checked && frmLogin.class101_0.globalSettings_0.Account.list_1.Count > 0)
			{
				int i = 0;
				while (i < frmLogin.class101_0.globalSettings_0.Account.list_1.Count)
				{
					if (!(frmLogin.class101_0.globalSettings_0.Account.list_1[i].String_2 == radioButton.Text))
					{
						i++;
					}
					else
					{
						bool flag = false;
						if (this.list_0.Count > 0)
						{
							int j = this.list_0.Count - 1;
							while (j >= 0)
							{
								if (!(this.list_0[j].string_0 == frmLogin.class101_0.globalSettings_0.Account.list_1[i].string_0))
								{
									j--;
								}
								else
								{
									if (this.list_0[j].String_2 == frmLogin.class101_0.globalSettings_0.Account.list_1[i].String_2)
									{
										this.list_0.RemoveAt(j);
										radioButton.Checked = false;
										flag = true;
										break;
									}
									this.list_0[j] = frmLogin.class101_0.globalSettings_0.Account.list_1[i];
									flag = true;
									break;
								}
							}
						}
						if (!flag)
						{
							this.list_0.Add(frmLogin.class101_0.globalSettings_0.Account.list_1[i]);
							break;
						}
						break;
					}
				}
			}
			this.double_0 = frmLiteBuy.smethod_0(this.list_0);
			if (this.double_0 > frmLogin.class101_0.globalSettings_0.Account.TotalBalance)
			{
				this.method_6("Không đủ GG để mua.", Color.Red, 5000);
				return;
			}
			this.stripStatus.Text = "";
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x000A9228 File Offset: 0x000A7428
		internal static double smethod_0(List<Class39> list_3)
		{
			if (list_3 != null && list_3.Count > 0)
			{
				double num = 0.0;
				try
				{
					for (int i = list_3.Count - 1; i >= 0; i--)
					{
						num += list_3[i].double_0;
					}
				}
				catch (Exception)
				{
				}
				return num;
			}
			return 0.0;
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x000A9290 File Offset: 0x000A7490
		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (this.lvTinhnang.Items.Count != frmLogin.class101_0.globalSettings_0.Account.class70_0.list_0.Count)
			{
				this.lvTinhnang.SetObjects(frmLogin.class101_0.globalSettings_0.Account.class70_0.list_0);
			}
			if (this.long_0 > 0L && frmLogin.stopwatch_0.ElapsedMilliseconds > this.long_0)
			{
				this.stripStatus.Text = "";
				this.long_0 = 0L;
			}
			string text = string.Format("Sẽ tốn {0:n1} GG", this.double_0.ToString());
			if (text.Contains(".0"))
			{
				text = string.Format("Sẽ tốn {0} GG", this.double_0.ToString("0"));
			}
			if (this.double_0 > frmLogin.class101_0.globalSettings_0.Account.TotalBalance)
			{
				text = "(Không đủ GG) " + text;
				if (this.stripTotal.ForeColor != Color.Red)
				{
					this.stripTotal.ForeColor = Color.Red;
				}
			}
			else if (this.stripTotal.ForeColor == Color.Red)
			{
				this.stripTotal.ForeColor = Color.DarkGreen;
			}
			this.stripTotal.Text = text;
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x000A93E8 File Offset: 0x000A75E8
		private void method_6(string string_0, Color color_0, int int_7 = 5000)
		{
			frmLiteBuy.Class173 @class = new frmLiteBuy.Class173();
			@class.frmLiteBuy_0 = this;
			@class.string_0 = string_0;
			@class.color_0 = color_0;
			@class.int_0 = int_7;
			this.btnBuyHour.Invoke(new MethodInvoker(@class.method_0));
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x000A9430 File Offset: 0x000A7630
		private void frmLiteBuy_Load(object sender, EventArgs e)
		{
			this.olvcolumn_3.AspectGetter = new AspectGetterDelegate(frmLiteBuy.<>c.<>c_0.method_0);
			this.olvcolumn_3.Renderer = new MappedImageRenderer(new object[]
			{
				true,
				Class212.add
			});
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00009E69 File Offset: 0x00008069
		private void btnClose_Click(object sender, EventArgs e)
		{
			this.method_7();
			base.Hide();
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x000A9490 File Offset: 0x000A7690
		private void method_7()
		{
			if (this.list_2.Count > 0)
			{
				for (int i = 0; i < this.list_2.Count; i++)
				{
					this.list_2[i].Checked = false;
				}
			}
			if (this.list_0.Count > 0)
			{
				this.list_0.Clear();
			}
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x000A94EC File Offset: 0x000A76EC
		private void btnBuyHour_Click(object sender, EventArgs e)
		{
			if (this.list_0.Count > 0)
			{
				double num = frmLiteBuy.smethod_0(this.list_0);
				bool flag;
				if (num <= frmLogin.class101_0.globalSettings_0.Account.TotalBalance)
				{
					string arg = num.ToString("0.0").Replace(".0", "") + frmLogin.String_1;
					string text = "";
					Class39 @class = null;
					foreach (Class39 class2 in this.list_0)
					{
						text = text + "+ " + class2.String_2 + "\n";
						if (class2.string_0 == "time" && @class == null)
						{
							@class = class2;
						}
					}
					if (this.double_1 <= 0.0 && !string.IsNullOrEmpty(this.txtCoupon.Text))
					{
						Class83.smethod_46("Bạn phải bấm nút refresh lấy thông tin mã khuyến mãi trước.\nNếu mã không đúng phải bỏ ra trước khi thanh toán.", "Cần thông tin mã KM", 30000, new object[0]);
						return;
					}
					if (this.double_1 > 0.0 && @class != null)
					{
						if (this.double_2 > 0.0 && this.double_2 / frmLogin.double_0 > @class.double_0)
						{
							Class83.smethod_46("Mã khuyến mãi chỉ áp dụng cho gói giờ mệnh giá nhỏ nhất {0} GG.", "Mã khuyến mãi lỗi", 60000, new object[]
							{
								(this.double_2 / frmLogin.double_0).ToString("0.0").Replace(".0", "")
							});
							return;
						}
						int num2 = (int)Math.Round((double)(@class.int_0 * 24) * this.double_1);
						string text2 = num2.ToString() + " giờ";
						if (num2 >= 72)
						{
							text2 = ((int)Math.Round((double)num2 / 24.0)).ToString("0.0").Replace(".0", "") + " ngày";
						}
						text = string.Concat(new string[]
						{
							text,
							"+ Tặng thêm ",
							text2,
							" (giờ chơi) (",
							this.txtCoupon.Text.ToUpper(),
							")\n"
						});
					}
					flag = (MessageBox.Show(string.Format("Bạn sẽ tốn {0} để mua thêm tính năng mới:\n{1}\nBấm YES để xác nhận.\nBấm NO để hủy thao tác.", arg, text), "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
				}
				else
				{
					flag = false;
					Class83.smethod_46("Bạn không đủ GG để thanh toán.\nVui lòng nạp thêm vào tài khoản", "Không đủ", 10000, new object[0]);
				}
				if (flag)
				{
					bool flag2 = false;
					bool flag3 = false;
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
					List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
					Dictionary<string, object> dictionary3 = new Dictionary<string, object>();
					List<Dictionary<string, object>> list2 = new List<Dictionary<string, object>>();
					Dictionary<string, object> dictionary4 = new Dictionary<string, object>();
					List<Dictionary<string, object>> list3 = new List<Dictionary<string, object>>();
					Dictionary<string, object> dictionary5 = new Dictionary<string, object>();
					List<Dictionary<string, object>> list4 = new List<Dictionary<string, object>>();
					for (int i = this.list_0.Count - 1; i >= 0; i--)
					{
						if (this.list_0[i].string_0 == "time")
						{
							flag2 = true;
							Class83.smethod_33(list, this.list_0[i], this.list_0[i].string_0, "");
							if (this.double_1 > 0.0 && list != null && list.Count > 0)
							{
								if (list[0].ContainsKey("tcoupon"))
								{
									list[0].Remove("tcoupon");
								}
								list[0].Add("tcoupon", this.txtCoupon.Text.ToUpper());
							}
						}
						if (this.list_0[i].string_0 == "tnchedo")
						{
							flag3 = true;
							Class83.smethod_33(list2, this.list_0[i], this.list_0[i].string_0, "");
						}
						if (this.list_0[i].string_0 == "tnyto")
						{
							Class83.smethod_33(list3, this.list_0[i], this.list_0[i].string_0, "");
						}
						if (this.list_0[i].string_0 == "tnq12")
						{
							Class83.smethod_33(list4, this.list_0[i], this.list_0[i].string_0, "");
						}
					}
					if (list.Count > 0)
					{
						dictionary2.Add("request", list);
						dictionary2.Add("count", "1");
					}
					if (list2.Count > 0)
					{
						dictionary3.Add("request", list2);
						dictionary3.Add("count", list2.Count);
					}
					if (list3.Count > 0)
					{
						dictionary4.Add("request", list3);
						dictionary4.Add("count", list3.Count);
					}
					if (list4.Count > 0)
					{
						dictionary5.Add("request", list4);
						dictionary5.Add("count", list4.Count);
					}
					if (!flag2 && !flag3 && frmLogin.bool_30)
					{
						if (frmLogin.class101_0.globalSettings_0.IsLoggedIn)
						{
							Class83.smethod_46("Bạn phải chọn gói giờ chơi để tự động gia hạn", "Mua giờ sử dụng", 30000, new object[0]);
						}
						else
						{
							Class83.smethod_46("Tài khoản đang có GG. Bạn phải chọn gói giờ chơi để vào game.", "Mua giờ sử dụng", 30000, new object[0]);
						}
					}
					if (dictionary2.Count > 0)
					{
						dictionary.Add("reqtime", dictionary2);
					}
					if (dictionary3.Count > 0)
					{
						dictionary.Add("reqtnchedo", dictionary3);
					}
					if (dictionary4.Count > 0)
					{
						dictionary.Add("reqtnyto", dictionary4);
					}
					if (dictionary5.Count > 0)
					{
						dictionary.Add("reqtnq12", dictionary5);
					}
					if (dictionary.Count > 0)
					{
						long num3 = frmLogin.stopwatch_0.ElapsedMilliseconds + 5000L;
						while (frmLogin.stopwatch_0.ElapsedMilliseconds <= num3)
						{
							if (!this.backgroundWorker_0.IsBusy)
							{
								this.btnBuyHour.Enabled = false;
								this.lvTinhnang.Enabled = false;
								this.backgroundWorker_0.RunWorkerAsync(dictionary);
								return;
							}
							Thread.Sleep(100);
						}
						return;
					}
				}
			}
			else
			{
				Class83.smethod_46("Bạn phải chọn một gói giờ hoặc tính năng để mua", "Chưa chọn gói", 10000, new object[0]);
			}
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x0000997A File Offset: 0x00007B7A
		private void frmLiteBuy_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			base.Hide();
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x000A9B80 File Offset: 0x000A7D80
		private void frmLiteBuy_Shown(object sender, EventArgs e)
		{
			this.lvTinhnang.SetObjects(frmLogin.class101_0.globalSettings_0.Account.class70_0.list_0);
			this.int_6 = this.pnelMuaGio.Height;
			this.method_0(!this.bool_1);
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x000A9BD4 File Offset: 0x000A7DD4
		private void method_8(object sender, CellClickEventArgs e)
		{
			try
			{
				ObjectListView objectListView = sender as ObjectListView;
				if (objectListView != null && e.Item != null && e.ColumnIndex == 4)
				{
					if (this.long_2 != 0L && (this.long_2 <= 0L || frmLogin.stopwatch_0.ElapsedMilliseconds <= this.long_2))
					{
						Class83.smethod_46(frmMain.String_783, frmMain.String_784, 10000, new object[0]);
					}
					else
					{
						this.long_2 = frmLogin.stopwatch_0.ElapsedMilliseconds + 5000L;
						Class41 @class = (Class41)objectListView.GetModelObject(e.Item.Index);
						if (@class != null)
						{
							Class39 class2 = Class83.smethod_97(@class);
							if (class2 != null && class2.double_0 <= frmLogin.class101_0.globalSettings_0.Account.TotalBalance)
							{
								DialogResult dialogResult;
								if (!(@class.GiaHanTime == frmMain.String_782) && !(@class.GiaHanTime == ""))
								{
									dialogResult = MessageBox.Show(string.Format("Bạn sẽ gia hạn '{0}' tốn {1} {2}.\nBấm YES để tiếp tục. Bấm NO để hủy.", class2.string_3, class2.String_0, frmLogin.String_1), "Gia hạn giờ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
								}
								else
								{
									dialogResult = MessageBox.Show(string.Format("Bạn sẽ gia hạn '{0} {1}' tốn {2} {3}.\nBấm YES để tiếp tục. Bấm NO để hủy.", new object[]
									{
										@class.Comment,
										@class.Tinhnang.ToLower(),
										class2.String_0,
										frmLogin.String_1
									}), "Gia hạn giờ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
								}
								if (dialogResult == DialogResult.Yes)
								{
									this.method_11(@class.TNKey, class2, @class.string_5, true);
								}
							}
							else if (class2 != null && class2.double_0 > frmLogin.class101_0.globalSettings_0.Account.TotalBalance)
							{
								Class83.smethod_46(string.Format("Không đủ {0} để gia hạn thêm tính năng.\nVui lòng nạp thêm vào tài khoản và mua lại lần nữa.", frmLogin.String_1), "Không thể thanh toán", 60000, new object[0]);
							}
							else
							{
								Class83.smethod_46("Không tìm thấy giá của gói tính năng này.\n- {0}\nVui lòng liên hệ fanpage để được hỗ trợ.", "Không thấy giá", 60000, new object[]
								{
									@class.Tinhnang + " " + @class.Comment
								});
							}
							@class.GiaHanTime = frmMain.String_782;
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x000A9E00 File Offset: 0x000A8000
		internal void method_9(Class39 class39_0)
		{
			if (this.list_1.Count > 0)
			{
				try
				{
					for (int i = 0; i < this.list_1.Count; i++)
					{
						if (this.list_1[i].string_0 == class39_0.string_0)
						{
							this.list_1[i] = class39_0;
							return;
						}
					}
				}
				catch (Exception)
				{
				}
			}
			this.list_1.Add(class39_0);
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x000024E9 File Offset: 0x000006E9
		internal void method_10(string string_0)
		{
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x000A9E80 File Offset: 0x000A8080
		internal void method_11(string string_0, Class39 class39_0, string string_1 = "", bool bool_3 = true)
		{
			if (string_1 == string.Empty)
			{
				string_1 = Class83.smethod_98(5);
			}
			this.method_9(class39_0);
			List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
			Class83.smethod_33(list, class39_0, string_0, string_1);
			if (list.Count > 0)
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
				dictionary2.Add("count", list.Count);
				dictionary2.Add("request", list);
				dictionary.Add("req" + string_0, dictionary2);
				if (dictionary.Count > 0)
				{
					if (bool_3)
					{
						this.btnBuyHour.Enabled = false;
						this.lvTinhnang.Enabled = false;
						long num = frmLogin.stopwatch_0.ElapsedMilliseconds + 5000L;
						while (frmLogin.stopwatch_0.ElapsedMilliseconds <= num)
						{
							if (!this.backgroundWorker_0.IsBusy)
							{
								this.backgroundWorker_0.RunWorkerAsync(dictionary);
								return;
							}
							Thread.Sleep(100);
						}
						return;
					}
					try
					{
						Class83.smethod_29(new Class73
						{
							string_0 = frmLogin.class101_0.globalSettings_0.Account.Username,
							string_1 = frmLogin.class101_0.globalSettings_0.Account.string_1,
							bool_1 = false
						}, dictionary);
					}
					catch (Exception)
					{
					}
				}
			}
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x000A9FD0 File Offset: 0x000A81D0
		private void lvTinhnang_ItemChecked(object sender, ItemCheckedEventArgs e)
		{
			ObjectListView objectListView = sender as ObjectListView;
			if (objectListView != null && e != null && e.Item != null)
			{
				Class41 @class = (Class41)objectListView.GetModelObject(e.Item.Index);
				if (@class != null)
				{
					@class.Giahan = !e.Item.Checked;
				}
			}
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x000AA020 File Offset: 0x000A8220
		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
			if (e.Argument != null && e.Argument.GetType() == typeof(Dictionary<string, object>))
			{
				try
				{
					Class72 result = Class83.smethod_29(new Class73
					{
						string_0 = frmLogin.class101_0.globalSettings_0.Account.Username,
						string_1 = frmLogin.class101_0.globalSettings_0.Account.string_1,
						bool_1 = false
					}, (Dictionary<string, object>)e.Argument);
					e.Result = result;
				}
				catch (Exception ex)
				{
					e.Result = new Class72
					{
						int_0 = 0,
						object_0 = "Lỗi khi xử lý lệnh mua. Msg: " + ex.Message
					};
				}
			}
			if (e.Argument != null && e.Argument.GetType() == typeof(int))
			{
				if ((int)e.Argument == 1)
				{
					e.Result = Class83.smethod_26();
				}
				if ((int)e.Argument == 2)
				{
					e.Result = frmNapThe.smethod_0(this.txtCoupon.Text, 1);
				}
			}
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x000AA144 File Offset: 0x000A8344
		private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Result != null && e.Result.GetType() == typeof(Class72))
			{
				this.btnBuyHour.Enabled = true;
				this.lvTinhnang.Enabled = true;
				Class72 @class = (Class72)e.Result;
				if (@class.int_0 == 0)
				{
					if (@class.object_0 != null && @class.object_0.ToString() != "")
					{
						MessageBox.Show(@class.object_0.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
					else
					{
						MessageBox.Show("Không thể mua giờ, chưa phân biệt được lỗi.\nVui lòng báo admin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
				else
				{
					if (@class.int_0 != 1)
					{
						Class83.smethod_46(@class.string_0, "Lỗi mua giờ", 60000, new object[0]);
						this.method_7();
						return;
					}
					Class83.smethod_46("Mua giờ thành công", "OK", 15000, new object[0]);
					this.method_7();
				}
				if (!this.backgroundWorker_0.IsBusy)
				{
					this.backgroundWorker_0.RunWorkerAsync(1);
				}
			}
			if (e.Result != null && e.Result.GetType() == typeof(Dictionary<string, object>))
			{
				Dictionary<string, object> dictionary = (Dictionary<string, object>)e.Result;
				if (dictionary.ContainsKey("history"))
				{
					frmLogin.class101_0.globalSettings_0.Account.list_0.Clear();
					if (dictionary.Count > 0)
					{
						int num = 0;
						if (dictionary.ContainsKey("count"))
						{
							num = ((dictionary["count"] != null) ? int.Parse(dictionary["count"].ToString()) : 0);
						}
						if (num > 0 && dictionary["username"].ToString() == frmLogin.class101_0.globalSettings_0.Account.Username)
						{
							List<Dictionary<string, object>> list = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(dictionary["history"].ToString());
							if (list.Count > 0)
							{
								try
								{
									int num2 = 1;
									foreach (Dictionary<string, object> dictionary2 in list)
									{
										Class37 class2 = new Class37();
										class2.ActDate = ((dictionary2["date"] != null) ? DateTime.Parse(dictionary2["date"].ToString()) : DateTime.MinValue);
										double num3 = (dictionary2["endbalance"] != null) ? (double.Parse(dictionary2["endbalance"].ToString()) / 1000.0) : 0.0;
										class2.Balance = ((num3 > 0.0) ? num3.ToString("0.0") : "-");
										class2.Balance = class2.Balance.Replace(".0", "");
										num3 = ((dictionary2["ggcost"] != null) ? (double.Parse(dictionary2["ggcost"].ToString()) / 1000.0) : 0.0);
										class2.Cost = ((num3 > 0.0) ? num3.ToString("0.0") : "-");
										class2.Cost = class2.Cost.Replace(".0", "");
										if (dictionary2["comment"] != null)
										{
											if (dictionary2["comment"].ToString().StartsWith("Nạp"))
											{
												class2.Comment = dictionary2["comment"].ToString();
												class2.Cost = "+" + class2.Cost;
											}
											else
											{
												MatchCollection matchCollection = Regex.Matches(dictionary2["comment"].ToString(), "^.*hết hạn", RegexOptions.Multiline);
												if (matchCollection.Count > 0)
												{
													string text = matchCollection[0].ToString().Replace("hết hạn", "").Trim().Replace("Mua gói", "").Replace(" giờ", "h").Replace(" ngày", "d");
													int num4 = text.IndexOf('[');
													if (num4 > 0)
													{
														text = text.Substring(0, num4);
													}
													class2.Comment = text;
												}
												class2.Cost = "-" + class2.Cost;
											}
										}
										else
										{
											class2.Comment = "---";
										}
										class2.Index = num2;
										frmLogin.class101_0.globalSettings_0.Account.list_0.Add(class2);
										num2++;
									}
								}
								catch (Exception)
								{
								}
							}
						}
					}
					this.lvHistory.SetObjects(frmLogin.class101_0.globalSettings_0.Account.list_0);
					return;
				}
				if (dictionary.ContainsKey("cp") && dictionary.ContainsKey("cpmsg"))
				{
					this.btnCoupon.Enabled = true;
					this.txtCoupon.Enabled = true;
					object obj = null;
					string text2 = "";
					dictionary.TryGetValue("cpmsg", out obj);
					if (obj != null)
					{
						text2 = obj.ToString();
					}
					bool flag = true;
					if (text2 == string.Empty)
					{
						flag = false;
					}
					else if (text2.Contains("không hợp lệ") || text2.Contains("không đúng"))
					{
						flag = false;
					}
					if (!flag)
					{
						this.double_1 = 0.0;
						this.double_2 = 0.0;
						this.lbCoupon.ForeColor = Color.DarkRed;
						this.lbCoupon.Text = text2;
						return;
					}
					dictionary.TryGetValue("ad", out obj);
					double.TryParse(obj.ToString(), out this.double_1);
					dictionary.TryGetValue("cpmin", out obj);
					double.TryParse(obj.ToString(), out this.double_2);
					string str = "";
					if (this.double_2 > 0.0)
					{
						str = string.Format(" (gói thuê bao {0} GG trở lên)", (this.double_2 / frmLogin.double_0).ToString("0.0").Replace(".0", ""));
					}
					this.lbCoupon.ForeColor = Color.DarkGreen;
					this.lbCoupon.Text = text2 + str;
				}
			}
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x000AA7F0 File Offset: 0x000A89F0
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			if (frmLogin.stopwatch_0.ElapsedMilliseconds > this.long_1)
			{
				this.long_1 = frmLogin.stopwatch_0.ElapsedMilliseconds + 5000L;
				if (!this.backgroundWorker_0.IsBusy)
				{
					this.backgroundWorker_0.RunWorkerAsync(1);
				}
			}
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00009E77 File Offset: 0x00008077
		private void btnPackageExpand_Click(object sender, EventArgs e)
		{
			this.method_1(this.bool_2);
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00009E77 File Offset: 0x00008077
		private void label6_Click(object sender, EventArgs e)
		{
			this.method_1(this.bool_2);
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00009E85 File Offset: 0x00008085
		private void lvTinhnang_CellEditFinished(object sender, CellEditEventArgs e)
		{
			e.AutoDispose = false;
			((ObjectListView)sender).RefreshItem(e.ListViewItem);
			e.Cancel = true;
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x000AA844 File Offset: 0x000A8A44
		private void lvTinhnang_CellEditStarting(object sender, CellEditEventArgs e)
		{
			frmLiteBuy.Class174 @class = new frmLiteBuy.Class174();
			@class.frmLiteBuy_0 = this;
			@class.object_0 = sender;
			@class.cellEditEventArgs_0 = e;
			if (@class.cellEditEventArgs_0.RowObject != null)
			{
				try
				{
					@class.class41_0 = (Class41)@class.cellEditEventArgs_0.RowObject;
					if (@class.class41_0 != null && frmLogin.class101_0.globalSettings_0.Account.list_1.Count > 0)
					{
						List<string> list = new List<string>();
						for (int i = 0; i < frmLogin.class101_0.globalSettings_0.Account.list_1.Count; i++)
						{
							if (frmLogin.class101_0.globalSettings_0.Account.list_1[i].string_0 == @class.class41_0.TNKey && frmLogin.class101_0.globalSettings_0.Account.list_1[i].int_1 == @class.class41_0.int_2)
							{
								list.Add(frmLogin.class101_0.globalSettings_0.Account.list_1[i].string_4);
							}
						}
						@class.comboBox_0 = new ComboBox();
						@class.comboBox_0.Bounds = @class.cellEditEventArgs_0.CellBounds;
						@class.comboBox_0.DropDownWidth = (int)Math.Round((double)@class.comboBox_0.Bounds.Width * 1.2);
						@class.comboBox_0.BeginUpdate();
						ComboBox.ObjectCollection items = @class.comboBox_0.Items;
						object[] items2 = list.ToArray();
						items.AddRange(items2);
						@class.comboBox_0.EndUpdate();
						@class.comboBox_0.GotFocus += this.method_13;
						@class.comboBox_0.DropDown += this.method_12;
						@class.comboBox_0.SelectedIndexChanged += @class.method_0;
						@class.cellEditEventArgs_0.Control = @class.comboBox_0;
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00009EA6 File Offset: 0x000080A6
		private void method_12(object sender, EventArgs e)
		{
			(sender as ComboBox).DroppedDown = false;
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00009EB4 File Offset: 0x000080B4
		private void method_13(object sender, EventArgs e)
		{
			(sender as ComboBox).DroppedDown = true;
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x000024E9 File Offset: 0x000006E9
		private void pnelButtons_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00009EC2 File Offset: 0x000080C2
		private void btnCoupon_Click(object sender, EventArgs e)
		{
			if (!this.backgroundWorker_0.IsBusy)
			{
				this.btnCoupon.Enabled = false;
				this.txtCoupon.Enabled = false;
				this.backgroundWorker_0.RunWorkerAsync(2);
			}
		}

		// Token: 0x04000BF3 RID: 3059
		private long long_0;

		// Token: 0x04000BF4 RID: 3060
		private static int int_0 = 20;

		// Token: 0x04000BF5 RID: 3061
		private static int int_1 = 20;

		// Token: 0x04000BF6 RID: 3062
		private int int_2 = 150;

		// Token: 0x04000BF7 RID: 3063
		private int int_3 = 20;

		// Token: 0x04000BF8 RID: 3064
		private bool bool_0 = true;

		// Token: 0x04000BF9 RID: 3065
		private int int_4 = frmLiteBuy.int_0;

		// Token: 0x04000BFA RID: 3066
		private int int_5 = frmLiteBuy.int_1;

		// Token: 0x04000BFB RID: 3067
		private List<Class39> list_0 = new List<Class39>();

		// Token: 0x04000BFC RID: 3068
		internal List<Class39> list_1 = new List<Class39>();

		// Token: 0x04000BFD RID: 3069
		internal double double_0;

		// Token: 0x04000BFE RID: 3070
		private bool bool_1;

		// Token: 0x04000BFF RID: 3071
		private List<RadioButton> list_2 = new List<RadioButton>();

		// Token: 0x04000C00 RID: 3072
		private long long_1;

		// Token: 0x04000C01 RID: 3073
		internal bool bool_2 = true;

		// Token: 0x04000C02 RID: 3074
		private int int_6;

		// Token: 0x04000C03 RID: 3075
		private long long_2;

		// Token: 0x04000C04 RID: 3076
		private double double_1;

		// Token: 0x04000C05 RID: 3077
		private double double_2;

		// Token: 0x020000EF RID: 239
		[CompilerGenerated]
		private sealed class Class173
		{
			// Token: 0x0600095C RID: 2396 RVA: 0x000AC858 File Offset: 0x000AAA58
			internal void method_0()
			{
				this.frmLiteBuy_0.stripStatus.Text = this.string_0;
				this.frmLiteBuy_0.stripStatus.ForeColor = this.color_0;
				this.frmLiteBuy_0.long_0 = frmLogin.stopwatch_0.ElapsedMilliseconds + (long)this.int_0;
			}

			// Token: 0x04000C35 RID: 3125
			public frmLiteBuy frmLiteBuy_0;

			// Token: 0x04000C36 RID: 3126
			public string string_0;

			// Token: 0x04000C37 RID: 3127
			public Color color_0;

			// Token: 0x04000C38 RID: 3128
			public int int_0;
		}

		// Token: 0x020000F1 RID: 241
		[CompilerGenerated]
		private sealed class Class174
		{
			// Token: 0x06000961 RID: 2401 RVA: 0x000AC8B0 File Offset: 0x000AAAB0
			internal void method_0(object sender, EventArgs e)
			{
				try
				{
					if (this.comboBox_0 != null && this.comboBox_0.SelectedItem != null && this.class41_0 != null)
					{
						try
						{
							this.class41_0.GiaHanTime = this.comboBox_0.SelectedItem.ToString();
						}
						catch (Exception)
						{
						}
					}
				}
				catch (Exception)
				{
				}
				finally
				{
					this.frmLiteBuy_0.lvTinhnang_CellEditFinished(this.object_0, this.cellEditEventArgs_0);
				}
			}

			// Token: 0x04000C3B RID: 3131
			public frmLiteBuy frmLiteBuy_0;

			// Token: 0x04000C3C RID: 3132
			public object object_0;

			// Token: 0x04000C3D RID: 3133
			public CellEditEventArgs cellEditEventArgs_0;

			// Token: 0x04000C3E RID: 3134
			public Class41 class41_0;

			// Token: 0x04000C3F RID: 3135
			public ComboBox comboBox_0;
		}
	}
}
