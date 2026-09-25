using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using BrightIdeasSoftware;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x020000F5 RID: 245
	internal sealed partial class frmPickSession : Form
	{
		// Token: 0x06000988 RID: 2440 RVA: 0x0000A02F File Offset: 0x0000822F
		internal frmPickSession()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x000B0174 File Offset: 0x000AE374
		internal bool method_0(Dictionary<string, object>[] dictionary_0)
		{
			bool flag = false;
			if (dictionary_0 != null && dictionary_0.Length != 0)
			{
				try
				{
					int num = 1;
					foreach (Dictionary<string, object> dictionary in dictionary_0)
					{
						Class175 @class = new Class175();
						@class.string_0 = dictionary["autoid"].ToString();
						@class.col_ID = num;
						string text = dictionary["hwid"].ToString();
						@class.col_HWID = text.Substring(text.Length - 7);
						text = dictionary["last_seen"].ToString();
						@class.string_1 = dictionary["logout"].ToString();
						if (@class.string_1 == "0")
						{
							text += " (Bận)";
						}
						@class.col_LastSeen = text;
						@class.col_Exp = dictionary["expire"].ToString();
						try
						{
							string text2 = "";
							@class.list_0.Clear();
							Class39 class2 = null;
							frmPickSession.smethod_0(dictionary, ref text2, "tnchedo", ref class2);
							if (class2 != null)
							{
								@class.list_0.Add(class2);
							}
							Class39 class3 = null;
							frmPickSession.smethod_0(dictionary, ref text2, "tnyto", ref class3);
							if (class3 != null)
							{
								@class.list_0.Add(class3);
							}
							Class39 class4 = null;
							frmPickSession.smethod_0(dictionary, ref text2, "tntrader", ref class4);
							if (class4 != null)
							{
								@class.list_0.Add(class4);
							}
							Class39 class5 = null;
							frmPickSession.smethod_0(dictionary, ref text2, "tnq12", ref class5);
							if (class5 != null)
							{
								@class.list_0.Add(class5);
							}
							text2 = text2.Trim(new char[]
							{
								','
							});
							text2 = text2.Replace(",", ", ");
							@class.col_Tinhnang = text2;
						}
						catch (Exception)
						{
						}
						this.list_0.Add(@class);
						num++;
					}
					flag = true;
				}
				catch (Exception)
				{
					flag = false;
				}
			}
			if (flag)
			{
				this.method_1();
			}
			return flag;
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x000B03A4 File Offset: 0x000AE5A4
		private static void smethod_0(Dictionary<string, object> dictionary_0, ref string string_0, string string_1, ref Class39 class39_0)
		{
			object obj = null;
			if (dictionary_0.ContainsKey(string_1))
			{
				int num = 0;
				Dictionary<string, object> dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(dictionary_0[string_1].ToString());
				dictionary.TryGetValue("count", out obj);
				if (obj != null)
				{
					int.TryParse(obj.ToString(), out num);
				}
				if (num > 0)
				{
					string arg = Class83.smethod_31(string_1, true);
					string_0 = string_0 + string.Format("{0} gói {1}", num.ToString(), arg) + ",";
					List<Dictionary<string, object>> list = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(dictionary["data"].ToString());
					if (list.Count > 0)
					{
						int num2 = 999;
						foreach (Dictionary<string, object> dictionary2 in list)
						{
							int num3 = 999;
							obj = null;
							dictionary2.TryGetValue("count", out obj);
							if (obj != null)
							{
								int.TryParse(obj.ToString(), out num3);
							}
							if (num3 > 0 && num3 < num2)
							{
								num2 = num3;
								if (class39_0 == null)
								{
									class39_0 = new Class39();
								}
								class39_0.string_0 = string_1;
								class39_0.int_0 = num3;
								class39_0.string_1 = dictionary2["countunit"].ToString();
								int.TryParse(dictionary2["slot"].ToString(), out class39_0.int_1);
								class39_0.string_2 = dictionary2["slotunit"].ToString();
							}
						}
					}
				}
			}
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x0000A048 File Offset: 0x00008248
		private void method_1()
		{
			this.lvSessions.SetObjects(this.list_0);
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x000024E9 File Offset: 0x000006E9
		private void frmPickSession_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x000B053C File Offset: 0x000AE73C
		private void method_2()
		{
			if (frmLogin.class101_0.globalSettings_0.Account.list_1.Count > 0)
			{
				List<string> list = new List<string>();
				foreach (Class39 @class in frmLogin.class101_0.globalSettings_0.Account.list_1)
				{
					if (@class.string_0 == "time")
					{
						list.Add(string.Format("{0} GG | {1}", @class.double_0, @class.string_3));
					}
				}
				if (list.Count > 0)
				{
					this.cboPrice.BeginUpdate();
					this.cboPrice.Items.Clear();
					ComboBox.ObjectCollection items = this.cboPrice.Items;
					object[] items2 = list.ToArray();
					items.AddRange(items2);
					this.cboPrice.EndUpdate();
					this.cboPrice.SelectedIndex = 0;
				}
			}
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x000B0644 File Offset: 0x000AE844
		private void btnNewSession_Click(object sender, EventArgs e)
		{
			if (frmLogin.class101_0.globalSettings_0.Account.TotalBalance > 3.3)
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
				List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
				if (frmLogin.class101_0.globalSettings_0.Account.list_1.Count > 0)
				{
					Class39 @class = null;
					string text = this.cboPrice.Text;
					int i = 0;
					while (i < frmLogin.class101_0.globalSettings_0.Account.list_1.Count)
					{
						if (!(text == string.Concat(new string[]
						{
							frmLogin.class101_0.globalSettings_0.Account.list_1[i].String_0,
							" ",
							frmLogin.String_1,
							" | ",
							frmLogin.class101_0.globalSettings_0.Account.list_1[i].string_3
						})))
						{
							i++;
						}
						else
						{
							@class = frmLogin.class101_0.globalSettings_0.Account.list_1[i];
							IL_11D:
							if (@class != null && frmLogin.class101_0.globalSettings_0.Account.TotalBalance > @class.double_0)
							{
								Class83.smethod_33(list, @class, "time", "");
								goto IL_188;
							}
							if (@class == null)
							{
								Class83.smethod_46("Không tìm thấy gói giá hợp lý.\nVui lòng báo admin", "Không thấy giá", 10000, new object[0]);
								goto IL_188;
							}
							Class83.smethod_46("Bạn không đủ tiền để mua gói giá này.\nNạp thêm tiền vào tài khoản.", "Không đủ tiền", 30000, new object[0]);
							goto IL_188;
						}
					}
					goto IL_11D;
				}
				IL_188:
				if (list.Count > 0)
				{
					dictionary2.Add("request", list);
					dictionary2.Add("count", "1");
					dictionary.Add("reqtime", dictionary2);
				}
				if (dictionary.Count > 0)
				{
					this.btnChonPhien.Enabled = false;
					this.btnNewSession.Enabled = false;
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
			}
			else
			{
				Class83.smethod_46("Tài khoản đã hết tiền nên không thể đăng nhập ở nhiều máy.\nNạp thêm tiền để ủng hộ auto và đăng nhập ở nhiều máy cùng lúc.", "Tài khoản không đủ tiền", 30000, new object[0]);
			}
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x000B088C File Offset: 0x000AEA8C
		private void btnChonPhien_Click(object sender, EventArgs e)
		{
			Class175 class175_ = (Class175)this.lvSessions.SelectedObject;
			this.method_3(class175_);
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x000B08B4 File Offset: 0x000AEAB4
		private void method_3(Class175 class175_0)
		{
			if (class175_0 != null)
			{
				bool flag = true;
				if (class175_0.string_1 == "0" && MessageBox.Show(string.Format("Bạn sẽ chiếm phiên làm việc số {0}. Auto bên máy kia sẽ bị đóng.\nBạn có đồng ý không?", class175_0.col_ID), "Lấy phiên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
				{
					flag = false;
				}
				if (flag)
				{
					if (frmLogin.frmLiteBuy_0 == null)
					{
						frmLogin.frmLiteBuy_0 = new frmLiteBuy(false);
					}
					frmLogin.frmLiteBuy_0.list_1 = class175_0.list_0;
					long num = frmLogin.stopwatch_0.ElapsedMilliseconds + 10000L;
					this.btnChonPhien.Enabled = false;
					this.btnNewSession.Enabled = false;
					while (frmLogin.stopwatch_0.ElapsedMilliseconds <= num)
					{
						if (!this.backgroundWorker_0.IsBusy)
						{
							Class73 @class = new Class73();
							@class.string_0 = frmLogin.class101_0.globalSettings_0.Account.Username;
							@class.string_1 = frmLogin.class101_0.globalSettings_0.Account.string_1;
							@class.bool_1 = true;
							@class.string_2 = "picksession";
							@class.string_3 = class175_0.string_0;
							this.backgroundWorker_0.RunWorkerAsync(@class);
							return;
						}
						Thread.Sleep(100);
					}
				}
			}
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x000B09E0 File Offset: 0x000AEBE0
		private void frmPickSession_Shown(object sender, EventArgs e)
		{
			if (frmLogin.string_2 == string.Empty)
			{
				frmLogin.string_2 = new Class83.Class85().String_0;
			}
			string string_ = frmLogin.string_2;
			this.lbHWID.Text = "Mã máy : " + string_.Substring(string_.Length - 7);
			this.lbUsername.Text = "Tài khoản: " + frmLogin.class101_0.globalSettings_0.Account.Username;
			string text = (frmLogin.class101_0.globalSettings_0.Account.RemainGGoldBalance / frmLogin.double_0).ToString("0.0");
			if (text.Contains(".0"))
			{
				text = (frmLogin.class101_0.globalSettings_0.Account.RemainGGoldBalance / frmLogin.double_0).ToString("0");
			}
			string text2 = (frmLogin.class101_0.globalSettings_0.Account.RemainGGoldPromo / frmLogin.double_0).ToString("0.0");
			if (text2.Contains(".0"))
			{
				text2 = (frmLogin.class101_0.globalSettings_0.Account.RemainGGoldPromo / frmLogin.double_0).ToString("0");
			}
			string text3 = ((frmLogin.class101_0.globalSettings_0.Account.RemainGGoldBalance + frmLogin.class101_0.globalSettings_0.Account.RemainGGoldPromo) / frmLogin.double_0).ToString("0.0");
			if (text3.Contains(".0"))
			{
				text3 = ((frmLogin.class101_0.globalSettings_0.Account.RemainGGoldBalance + frmLogin.class101_0.globalSettings_0.Account.RemainGGoldPromo) / frmLogin.double_0).ToString("0");
			}
			this.lbTotalGG.Text = string.Concat(new string[]
			{
				"GG còn: ",
				text,
				" + ",
				text2,
				" = ",
				text3
			});
			this.method_2();
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0000A05B File Offset: 0x0000825B
		private void btnThoatAuto_Click(object sender, EventArgs e)
		{
			this.method_4();
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x0000A063 File Offset: 0x00008263
		private void method_4()
		{
			if (MessageBox.Show("Bạn có muốn thoát auto không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Class83.smethod_62(false);
			}
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0000A080 File Offset: 0x00008280
		private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			Class72 @class = (Class72)e.Result;
			this.btnChonPhien.Enabled = true;
			this.btnNewSession.Enabled = true;
			if (@class.int_0 == 1)
			{
				frmLogin.smethod_13();
				this.bool_0 = true;
				base.Close();
			}
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x000B0BE8 File Offset: 0x000AEDE8
		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
			if (e.Argument != null && e.Argument.GetType() == typeof(Class73))
			{
				Class72 result = Class83.smethod_29((Class73)e.Argument, null);
				e.Result = result;
			}
			if (e.Argument != null && e.Argument.GetType() == typeof(Dictionary<string, object>))
			{
				Class72 result2 = Class83.smethod_29(new Class73
				{
					string_0 = frmLogin.class101_0.globalSettings_0.Account.Username,
					string_1 = frmLogin.class101_0.globalSettings_0.Account.string_1,
					bool_1 = true,
					string_2 = "picksession",
					string_3 = Class83.smethod_98(18)
				}, (Dictionary<string, object>)e.Argument);
				e.Result = result2;
			}
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x000024E9 File Offset: 0x000006E9
		private void cboPrice_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x000024E9 File Offset: 0x000006E9
		private void lbUsername_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x000024E9 File Offset: 0x000006E9
		private void frmPickSession_FormClosed(object sender, FormClosedEventArgs e)
		{
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0000A0BF File Offset: 0x000082BF
		private void frmPickSession_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!this.bool_0)
			{
				this.method_4();
				e.Cancel = true;
			}
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x000024E9 File Offset: 0x000006E9
		private void lvSessions_DoubleClick(object sender, EventArgs e)
		{
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_5(object sender, CellClickEventArgs e)
		{
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x000B0CC0 File Offset: 0x000AEEC0
		private void lvSessions_ItemActivate(object sender, EventArgs e)
		{
			try
			{
				ObjectListView objectListView = sender as ObjectListView;
				if (objectListView.SelectedObject != null)
				{
					Class175 class175_ = (Class175)objectListView.SelectedObject;
					this.method_3(class175_);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x04000C86 RID: 3206
		internal List<Class175> list_0 = new List<Class175>();

		// Token: 0x04000C87 RID: 3207
		internal bool bool_0;
	}
}
