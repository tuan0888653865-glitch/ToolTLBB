using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BrightIdeasSoftware;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x020000F3 RID: 243
	internal sealed partial class frmNewUserInfo : Form
	{
		// Token: 0x0600096A RID: 2410 RVA: 0x00009F5A File Offset: 0x0000815A
		internal frmNewUserInfo()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x000AD270 File Offset: 0x000AB470
		private void frmNewUserInfo_Load(object sender, EventArgs e)
		{
			if (frmLogin.class101_0.globalSettings_0.Account != null)
			{
				this.lbUsername.DataBindings.Clear();
				this.lbUsername.DataBindings.Add("Text", frmLogin.class101_0.globalSettings_0.Account, "Username");
				this.lbGGNap.DataBindings.Clear();
				this.lbGGNap.DataBindings.Add("Text", frmLogin.class101_0.globalSettings_0.Account, "RemainGGoldBalance");
				this.lbGGKM.DataBindings.Clear();
				this.lbGGKM.DataBindings.Add("Text", frmLogin.class101_0.globalSettings_0.Account, "RemainGGoldPromo");
				this.lbHandung.DataBindings.Clear();
				this.lbHandung.DataBindings.Add("Text", frmLogin.class101_0.globalSettings_0.Account, "Handung");
				this.method_0(0);
			}
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x000AD380 File Offset: 0x000AB580
		private void method_0(int int_0 = 0)
		{
			if (frmLogin.class101_0.globalSettings_0.Account.list_1.Count > 0)
			{
				List<Class39> list_ = frmLogin.class101_0.globalSettings_0.Account.list_1;
				List<string> list = new List<string>
				{
					"Không mua"
				};
				List<string> list2 = new List<string>
				{
					"Không mua"
				};
				List<string> list3 = new List<string>
				{
					"Không mua"
				};
				List<string> list4 = new List<string>
				{
					"Không mua"
				};
				for (int i = list_.Count - 1; i >= 0; i--)
				{
					if (list_[i].string_0 == "time")
					{
						list.Add(string.Format("{0} | {1} {2}", list_[i].string_3, list_[i].double_0, frmLogin.String_1));
					}
					else if (list_[i].string_0 == "tnchedo")
					{
						list2.Add(string.Format("{0} | {1} {2}", list_[i].string_3, list_[i].double_0, frmLogin.String_1));
					}
					else if (list_[i].string_0 == "tnyto")
					{
						list3.Add(string.Format("{0} | {1} {2}", list_[i].string_3, list_[i].double_0, frmLogin.String_1));
					}
					else if (list_[i].string_0 == "tntrader")
					{
						list4.Add(string.Format("{0} | {1} {2}", list_[i].string_3, list_[i].double_0, frmLogin.String_1));
					}
				}
				this.cboBuyTime.BeginUpdate();
				ComboBox.ObjectCollection items = this.cboBuyTime.Items;
				object[] items2 = list.ToArray();
				items.AddRange(items2);
				this.cboBuyTime.SelectedIndex = 0;
				this.cboBuyTime.EndUpdate();
				this.cboBuyChedo.BeginUpdate();
				ComboBox.ObjectCollection items3 = this.cboBuyChedo.Items;
				items2 = list2.ToArray();
				items3.AddRange(items2);
				this.cboBuyChedo.SelectedIndex = 0;
				this.cboBuyChedo.EndUpdate();
				this.cboBuyYTO.BeginUpdate();
				ComboBox.ObjectCollection items4 = this.cboBuyYTO.Items;
				items2 = list3.ToArray();
				items4.AddRange(items2);
				this.cboBuyYTO.SelectedIndex = 0;
				this.cboBuyYTO.EndUpdate();
				this.cboBuyTrader.BeginUpdate();
				ComboBox.ObjectCollection items5 = this.cboBuyTrader.Items;
				items2 = list4.ToArray();
				items5.AddRange(items2);
				this.cboBuyTrader.SelectedIndex = 0;
				this.cboBuyTrader.EndUpdate();
			}
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x000024E9 File Offset: 0x000006E9
		private void groupBox1_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x000024E9 File Offset: 0x000006E9
		private void label7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x000024E9 File Offset: 0x000006E9
		private void groupBox2_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x000024E9 File Offset: 0x000006E9
		private void label6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00009F68 File Offset: 0x00008168
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			this.backgroundWorker_0.RunWorkerAsync(1);
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00009F7B File Offset: 0x0000817B
		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
			if (e.Argument != null && e.Argument.GetType() == typeof(int) && (int)e.Argument == 1)
			{
				e.Result = Class83.smethod_26();
			}
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x000AD658 File Offset: 0x000AB858
		private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Result != null && e.Result.GetType() == typeof(Dictionary<string, object>))
			{
				Dictionary<string, object> dictionary = (Dictionary<string, object>)e.Result;
				if (dictionary != null)
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
										Class37 @class = new Class37();
										@class.ActDate = ((dictionary2["date"] != null) ? DateTime.Parse(dictionary2["date"].ToString()) : DateTime.MinValue);
										double num3 = (dictionary2["endbalance"] != null) ? (double.Parse(dictionary2["endbalance"].ToString()) / 1000.0) : 0.0;
										@class.Balance = ((num3 > 0.0) ? (num3.ToString("0.0") + " " + frmLogin.String_1) : "-");
										num3 = ((dictionary2["ggcost"] != null) ? (double.Parse(dictionary2["ggcost"].ToString()) / 1000.0) : 0.0);
										@class.Cost = ((num3 > 0.0) ? (num3.ToString("0.0") + " " + frmLogin.String_1) : "-");
										if (dictionary2["comment"] != null)
										{
											if (dictionary2["comment"].ToString().StartsWith("Nạp"))
											{
												@class.Comment = dictionary2["comment"].ToString();
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
													@class.Comment = text;
												}
											}
										}
										else
										{
											@class.Comment = "---";
										}
										@class.Index = num2;
										frmLogin.class101_0.globalSettings_0.Account.list_0.Add(@class);
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
				}
			}
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00009FB5 File Offset: 0x000081B5
		private void cboBuyChedo_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_1(sender);
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x000ADA1C File Offset: 0x000ABC1C
		private void cboBuyTime_DropDown(object sender, EventArgs e)
		{
			ComboBox comboBox = sender as ComboBox;
			if (comboBox.Focused && comboBox.Items.Count == 0)
			{
				this.method_0(0);
			}
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x000ADA1C File Offset: 0x000ABC1C
		private void cboBuyChedo_DropDown(object sender, EventArgs e)
		{
			ComboBox comboBox = sender as ComboBox;
			if (comboBox.Focused && comboBox.Items.Count == 0)
			{
				this.method_0(0);
			}
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x000ADA1C File Offset: 0x000ABC1C
		private void cboBuyYTO_DropDown(object sender, EventArgs e)
		{
			ComboBox comboBox = sender as ComboBox;
			if (comboBox.Focused && comboBox.Items.Count == 0)
			{
				this.method_0(0);
			}
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00009FB5 File Offset: 0x000081B5
		private void cboBuyTime_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_1(sender);
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x000ADA4C File Offset: 0x000ABC4C
		private void method_1(object object_0)
		{
			ComboBox comboBox = object_0 as ComboBox;
			if (comboBox.Focused)
			{
				string text = comboBox.SelectedItem.ToString();
				Class39 @class = null;
				List<Class39> list_ = frmLogin.class101_0.globalSettings_0.Account.list_1;
				if (list_.Count > 0)
				{
					if (text.Contains("Không mua"))
					{
						string text2 = "";
						if (object_0 == this.cboBuyTime)
						{
							text2 = "time";
						}
						else if (object_0 == this.cboBuyChedo)
						{
							text2 = "tnchedo";
						}
						else if (object_0 == this.cboBuyYTO)
						{
							text2 = "tnyto";
						}
						else if (object_0 == this.cboBuyTrader)
						{
							text2 = "tntrader";
						}
						if (text2 != "" && frmLogin.class101_0.globalSettings_0.Account.list_2.Count > 0)
						{
							for (int i = frmLogin.class101_0.globalSettings_0.Account.list_2.Count - 1; i >= 0; i--)
							{
								if (frmLogin.class101_0.globalSettings_0.Account.list_2[i].string_1 == text2)
								{
									frmLogin.class101_0.globalSettings_0.Account.list_2.RemoveAt(i);
									break;
								}
							}
						}
					}
					else
					{
						Match match = Regex.Match(text, "^.*\\|", RegexOptions.Multiline);
						if (match.Length > 0)
						{
							text = match.ToString().Replace("|", "").Trim();
							int j = list_.Count - 1;
							while (j >= 0)
							{
								if (!(list_[j].string_3 == text))
								{
									j--;
								}
								else
								{
									@class = list_[j];
									IL_1B4:
									if (@class == null)
									{
										goto IL_353;
									}
									Class40 class2 = null;
									if (frmLogin.class101_0.globalSettings_0.Account.list_2.Count > 0)
									{
										for (int k = frmLogin.class101_0.globalSettings_0.Account.list_2.Count - 1; k >= 0; k--)
										{
											if (frmLogin.class101_0.globalSettings_0.Account.list_2[k].string_1 == @class.string_0 && @class.double_0 == frmLogin.class101_0.globalSettings_0.Account.list_2[k].double_0)
											{
												class2 = frmLogin.class101_0.globalSettings_0.Account.list_2[k];
												break;
											}
										}
									}
									if (class2 == null)
									{
										class2 = new Class40();
										class2.string_2 = text;
										class2.double_0 = @class.double_0;
										class2.string_1 = @class.string_0;
										class2.int_0 = @class.int_0;
										class2.string_3 = @class.string_1;
										class2.int_1 = @class.int_1;
										class2.string_4 = @class.string_2;
										class2.string_0 = Class83.smethod_98(5);
										frmLogin.class101_0.globalSettings_0.Account.list_2.Add(class2);
										goto IL_353;
									}
									class2.string_2 = text;
									class2.double_0 = @class.double_0;
									class2.int_0 = @class.int_0;
									class2.string_3 = @class.string_1;
									class2.int_1 = @class.int_1;
									class2.string_4 = @class.string_2;
									goto IL_353;
								}
							}
							goto IL_1B4;
						}
					}
					IL_353:
					this.lvBuyLic.SetObjects(frmLogin.class101_0.globalSettings_0.Account.list_2);
				}
			}
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00009FB5 File Offset: 0x000081B5
		private void cboBuyYTO_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_1(sender);
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00009FB5 File Offset: 0x000081B5
		private void cboBuyTrader_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_1(sender);
		}
	}
}
