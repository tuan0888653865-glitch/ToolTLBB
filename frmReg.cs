using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using Newtonsoft.Json;
using SmartBot;

namespace ns0
{
	// Token: 0x0200012A RID: 298
	internal sealed partial class frmReg : Form
	{
		// Token: 0x06001240 RID: 4672 RVA: 0x0011846C File Offset: 0x0011666C
		internal frmReg()
		{
			this.InitializeComponent();
			this.btnDoReg.Enabled = false;
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_0(object object_0, Class10 class10_0)
		{
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_1(object object_0, Class11 class11_0)
		{
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x00118514 File Offset: 0x00116714
		internal static bool smethod_0(string string_5)
		{
			Regex regex = new Regex("^[A-Za-z\\d_-]+$");
			return !string.IsNullOrEmpty(string_5) && regex.IsMatch(string_5);
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x00118540 File Offset: 0x00116740
		internal static bool smethod_1(string string_5)
		{
			Regex regex = new Regex("[\\w-]+@([\\w-]+\\.)+[\\w-]+");
			return !string.IsNullOrEmpty(string_5) && regex.IsMatch(string_5);
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x0011856C File Offset: 0x0011676C
		internal static Image smethod_2(string string_5)
		{
			Image result;
			using (WebClient webClient = new WebClient())
			{
				result = frmReg.smethod_3(webClient.DownloadData(string_5));
			}
			return result;
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x001185AC File Offset: 0x001167AC
		internal static Image smethod_3(byte[] byte_0)
		{
			Image result;
			using (MemoryStream memoryStream = new MemoryStream(byte_0))
			{
				result = Image.FromStream(memoryStream);
			}
			return result;
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x001185E4 File Offset: 0x001167E4
		private void frmReg_Load(object sender, EventArgs e)
		{
			if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
			{
				this.txtUserLogin.Text = "";
				this.txtUserPass.Text = "";
				this.txtRePass.Text = "";
				this.txtUserEmail.Text = "";
				this.txtCode.Text = "Vui lòng chờ";
				this.txtCode.Enabled = false;
				this.backgroundWorker_0.RunWorkerAsync(1);
				return;
			}
			if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
			{
				this.method_3();
				return;
			}
			if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
			{
				this.method_2();
			}
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x001186C0 File Offset: 0x001168C0
		private void method_2()
		{
			Class83.smethod_125(frmLogin.class101_0.globalSettings_0.RegisterAccountURL, "", "GET", frmLogin.class101_0.globalSettings_0.MainCookie, true);
			bool flag = false;
			Image image = Class83.smethod_123(frmLogin.class101_0.globalSettings_0.RegURL, frmLogin.class101_0.globalSettings_0.MainCookie, ref flag);
			this.picCaptcha.Image = image;
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x00118730 File Offset: 0x00116930
		private void method_3()
		{
			Class83.smethod_125(frmLogin.class101_0.globalSettings_0.RegisterAccountURL, "", "GET", frmLogin.class101_0.globalSettings_0.MainCookie, true);
			bool flag = false;
			Image image = Class83.smethod_123("http://www.tianlongauto.net/autotl/models/captcha.php", frmLogin.class101_0.globalSettings_0.MainCookie, ref flag);
			this.picCaptcha.Image = image;
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x00118798 File Offset: 0x00116998
		private bool method_4()
		{
			frmReg.Class203 @class = new frmReg.Class203();
			@class.frmReg_0 = this;
			bool flag = false;
			int num = 0;
			string a;
			for (;;)
			{
				frmLogin.class101_0.globalSettings_0.MainCookie = new CookieContainer();
				a = Class83.smethod_125(frmLogin.class132_0.string_0 + frmLogin.class101_0.globalSettings_0.RegisterAccountURL, "", "GET", frmLogin.class101_0.globalSettings_0.MainCookie, false);
				if (!(a == string.Empty) && !(a == frmLogin.class101_0.globalSettings_0.LoadWebErrorMessage))
				{
					this.string_0 = Class83.smethod_83(a, "id=\"agreed\" value=\"", "\" class=\"button1", 1, 1);
					this.string_1 = Class83.smethod_83(a, "creation_time\" value=\"", "\" />", 1, 1);
					this.string_2 = Class83.smethod_83(a, "form_token\" value=\"", "\" />", 1, 1);
					string text = string.Format("agreed={0}&change_lang=&creation_time={1}&form_token={2}", this.string_0, this.string_1, this.string_2);
					a = Class83.smethod_125(frmLogin.class132_0.string_0 + frmLogin.class101_0.globalSettings_0.RegisterAccountURL, text, "POST", frmLogin.class101_0.globalSettings_0.MainCookie, false);
					this.string_1 = Class83.smethod_83(a, "creation_time\" value=\"", "\" />", 1, 1);
					this.string_2 = Class83.smethod_83(a, "form_token\" value=\"", "\" />", 1, 1);
					this.string_4 = Class83.smethod_83(a, "name=\"confirm_id\" value=\"", "\" />", 1, 1);
					string text2 = frmLogin.class132_0.string_0 + "forum/ucp.php?mode=confirm&confirm_id=" + this.string_4 + "&type=1";
					bool flag2 = false;
					@class.image_0 = Class83.smethod_123(text2, frmLogin.class101_0.globalSettings_0.MainCookie, ref flag2);
					if (flag2)
					{
						goto IL_20D;
					}
					num++;
					if (num > frmLogin.class101_0.globalSettings_0.httpRetries * 2)
					{
						goto IL_23B;
					}
				}
				else
				{
					num++;
					if (num > frmLogin.class101_0.globalSettings_0.httpRetries * 2)
					{
						break;
					}
				}
			}
			flag = true;
			goto IL_241;
			IL_20D:
			base.Invoke(new MethodInvoker(@class.method_0));
			this.string_3 = Class83.smethod_83(a, "name=\"confirm_id\" value=\"", "\" />", 1, 1);
			goto IL_241;
			IL_23B:
			flag = true;
			IL_241:
			bool result;
			if (flag)
			{
				result = false;
				MessageBox.Show("Server đang bị kẻ xấu tấn công nên đăng ký hơi khó. Bạn có thể đăng ký tại trang chủ:\n\nwww.gameauto.net/forum/", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				result = true;
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new MethodInvoker(@class.method_1));
			}
			else
			{
				this.btnDoReg.Enabled = true;
			}
			return result;
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x00118A2C File Offset: 0x00116C2C
		private bool method_5()
		{
			frmReg.Class204 @class = new frmReg.Class204();
			@class.frmReg_0 = this;
			bool flag = false;
			int num = 0;
			do
			{
				if (frmLogin.class101_0.globalSettings_0.MainCookie == null)
				{
					frmLogin.class101_0.globalSettings_0.MainCookie = new CookieContainer();
				}
				bool flag2 = false;
				@class.image_0 = Class83.smethod_123(frmLogin.class132_0.string_0 + frmLogin.class101_0.globalSettings_0.CaptchaURL, frmLogin.class101_0.globalSettings_0.MainCookie, ref flag2);
				if (flag2)
				{
					goto IL_9C;
				}
				num++;
			}
			while (num <= frmLogin.class101_0.globalSettings_0.httpRetries * 2);
			flag = true;
			goto IL_B3;
			IL_9C:
			base.Invoke(new MethodInvoker(@class.method_0));
			IL_B3:
			bool result;
			if (flag)
			{
				result = false;
				MessageBox.Show("Server đang bị kẻ xấu tấn công nên đăng ký hơi khó. Bạn có thể đăng ký tại trang chủ:\n\nwww.gameauto.net/forum/", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				result = true;
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new MethodInvoker(@class.method_1));
			}
			else
			{
				this.btnDoReg.Enabled = true;
			}
			return result;
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x0001656E File Offset: 0x0001476E
		private void frmReg_FormClosed(object sender, FormClosedEventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x00118B34 File Offset: 0x00116D34
		private void btnCheckUserName_Click(object sender, EventArgs e)
		{
			if (!this.backgroundWorker_0.IsBusy)
			{
				this.backgroundWorker_0.RunWorkerAsync(2);
				return;
			}
			long num = frmLogin.stopwatch_0.ElapsedMilliseconds + 500L;
			while (frmLogin.stopwatch_0.ElapsedMilliseconds <= num)
			{
				if (!this.backgroundWorker_0.IsBusy)
				{
					this.backgroundWorker_0.RunWorkerAsync(2);
					return;
				}
				Thread.Sleep(100);
			}
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x00118BA8 File Offset: 0x00116DA8
		private void method_6()
		{
			this.bool_0 = false;
			if (frmLogin.string_0 == "VN" && this.txtUserLogin.Text != "")
			{
				string value = this.txtUserLogin.Text.Replace("%", "");
				value = this.txtUserLogin.Text.Replace("'", "");
				value = this.txtUserLogin.Text.Replace("\"", "");
				bool flag = false;
				if (Class83.smethod_38(value))
				{
					flag = true;
				}
				if (flag)
				{
					this.lblStatus.ForeColor = Color.Red;
					base.Invoke(new MethodInvoker(this.method_11));
				}
				if (!string.IsNullOrEmpty(value) && !flag)
				{
					frmReg.Class205 @class = new frmReg.Class205();
					@class.frmReg_0 = this;
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					string text = JsonConvert.SerializeObject(new Dictionary<string, object>
					{
						{
							"salt",
							Class83.smethod_98(5)
						},
						{
							"action",
							"checkuser"
						},
						{
							"user",
							value
						}
					});
					text = HttpUtility.UrlEncode(Class83.smethod_39(text, 1));
					string text2 = frmLogin.class132_0.string_0 + frmLogin.class101_0.globalSettings_0.HouseKeeperURL;
					string text3 = "POST";
					dictionary = Class83.smethod_27(text2, text3, text);
					@class.string_0 = "";
					if (dictionary.ContainsKey("msg"))
					{
						@class.string_0 = dictionary["msg"].ToString();
					}
					base.Invoke(new MethodInvoker(@class.method_0));
					this.long_0 = frmLogin.stopwatch_0.ElapsedMilliseconds;
				}
			}
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x00118D5C File Offset: 0x00116F5C
		private void method_7()
		{
			this.bool_0 = false;
			if (frmLogin.string_0 == "VN" && this.txtUserLogin.Text != "")
			{
				string text = this.txtUserLogin.Text.Replace("%", "");
				text = this.txtUserLogin.Text.Replace("'", "");
				text = this.txtUserLogin.Text.Replace("\"", "");
				bool flag = false;
				if (Class83.smethod_38(text))
				{
					flag = true;
				}
				if (flag)
				{
					this.lblStatus.ForeColor = Color.Red;
					base.Invoke(new MethodInvoker(this.method_12));
				}
				if (!string.IsNullOrEmpty(text) && !flag)
				{
					string a;
					if (frmLogin.class101_0.globalSettings_0.CheckUserURL.StartsWith("http"))
					{
						a = Class83.smethod_124(frmLogin.class101_0.globalSettings_0.CheckUserURL, "newuser=" + text, "POST", null, true);
					}
					else
					{
						a = Class83.smethod_124(frmLogin.class132_0.string_0 + frmLogin.class101_0.globalSettings_0.CheckUserURL, "newuser=" + text, "POST", null, true);
					}
					if (a != "" && a != frmLogin.class101_0.globalSettings_0.LoadWebErrorMessage)
					{
						frmReg.Class206 @class = new frmReg.Class206();
						@class.frmReg_0 = this;
						@class.string_0 = Class83.smethod_81(a, "msg", false);
						@class.string_0 = HttpUtility.UrlDecode(@class.string_0);
						try
						{
							byte[] bytes = Convert.FromBase64String(@class.string_0);
							@class.string_0 = Encoding.UTF8.GetString(bytes);
						}
						catch (Exception)
						{
						}
						base.Invoke(new MethodInvoker(@class.method_0));
						this.long_0 = frmLogin.stopwatch_0.ElapsedMilliseconds;
					}
				}
			}
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x00118F60 File Offset: 0x00117160
		private void btnDoReg_Click(object sender, EventArgs e)
		{
			if (this.txtUserPass.Text != this.txtRePass.Text)
			{
				MessageBox.Show(frmMain.String_321, frmMain.String_320, MessageBoxButtons.OK, MessageBoxIcon.Hand);
				this.txtUserPass.Text = "";
				this.txtRePass.Text = "";
				return;
			}
			if (!this.cboxTerms.Checked)
			{
				MessageBox.Show(frmMain.String_319, frmMain.String_318, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				this.cboxTerms.ForeColor = Color.Red;
				return;
			}
			if (!this.backgroundWorker_0.IsBusy)
			{
				this.btnDoReg.Enabled = false;
				this.backgroundWorker_0.RunWorkerAsync(3);
			}
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x0011901C File Offset: 0x0011721C
		private void method_8()
		{
			frmReg.Class207 @class = new frmReg.Class207();
			@class.frmReg_0 = this;
			bool flag = false;
			if (Class83.smethod_38(this.txtUserLogin.Text) && Class83.smethod_38(this.txtUserEmail.Text) && Class83.smethod_38(this.txtCode.Text))
			{
				flag = true;
			}
			if (!flag)
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					@class.string_0 = this.txtUserLogin.Text;
					string text = this.txtUserEmail.Text;
					@class.string_1 = this.txtUserPass.Text;
					string text2 = this.txtCode.Text;
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					string text3 = JsonConvert.SerializeObject(new Dictionary<string, object>
					{
						{
							"salt",
							Class83.smethod_98(5)
						},
						{
							"action",
							"register"
						},
						{
							"username",
							@class.string_0
						},
						{
							"displayname",
							@class.string_0
						},
						{
							"email",
							text
						},
						{
							"password",
							@class.string_1
						},
						{
							"passwordc",
							@class.string_1
						},
						{
							"captcha",
							text2
						}
					});
					text3 = HttpUtility.UrlEncode(Class83.smethod_39(text3, 1));
					string text4 = frmLogin.class132_0.string_0 + frmLogin.class101_0.globalSettings_0.HouseKeeperURL;
					string text5 = "POST";
					dictionary = Class83.smethod_27(text4, text5, text3);
					if (dictionary.Count > 0 && dictionary.ContainsKey("ketqua"))
					{
						if (dictionary["ketqua"].ToString() == "REGOK")
						{
							Class83.smethod_46(string.Format("Tài khoản {0} đã được tạo thành công", @class.string_0), "Đăng ký thành công", 60000, new object[0]);
							base.Invoke(new MethodInvoker(@class.method_0));
							return;
						}
						Class83.smethod_46("Đăng ký không thành công.\n\nLỗi: " + dictionary["msg"].ToString(), "Lỗi đăng ký", 60000, new object[0]);
						this.method_5();
						return;
					}
				}
				else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN" || frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
				{
					string text6 = string.Format("username={0}&displayname={1}&password={2}&passwordc={3}&email={4}&captcha={5}", new object[]
					{
						this.txtUserLogin.Text,
						this.txtUserLogin.Text,
						this.txtUserPass.Text,
						this.txtUserPass.Text,
						this.txtUserEmail.Text,
						this.txtCode.Text
					});
					string text7 = Class83.smethod_125(frmLogin.class101_0.globalSettings_0.RegisterAccountURL, text6, "POST", frmLogin.class101_0.globalSettings_0.MainCookie, true);
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
					{
						string text8 = Class83.smethod_83(text7, "<ul><li>", "</li></ul></div>", 1, 1);
						text8 = text8.Replace(" <a href=\"login.php\">here</a>.", ".");
						if (!(text8 != ""))
						{
							MessageBox.Show(text7, "Registration");
							return;
						}
						MessageBox.Show(text8, "Registration");
						if (text8.Contains("successfully registered"))
						{
							frmLogin.frmLogin_0.txtUserID.Text = this.txtUserLogin.Text;
							frmLogin.frmLogin_0.txtUserPassword.Text = this.txtUserPass.Text;
							base.Close();
							return;
						}
					}
					else
					{
						if (text7.Contains("账号注册成功"))
						{
							MessageBox.Show(text7, "注册", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							frmLogin.frmLogin_0.txtUserID.Text = this.txtUserLogin.Text;
							frmLogin.frmLogin_0.txtUserPassword.Text = this.txtUserPass.Text;
							base.Close();
							return;
						}
						MessageBox.Show(text7, "错误注册", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						this.method_2();
					}
				}
			}
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_9(object sender, EventArgs e)
		{
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x00016576 File Offset: 0x00014776
		private void lblTermLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Class83.smethod_88();
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x00119440 File Offset: 0x00117640
		private void cboxTerms_CheckedChanged(object sender, EventArgs e)
		{
			this.cboxTerms.ForeColor = Color.Black;
			if (frmLogin.string_0 == "VN")
			{
				if (!this.cboxTerms.Checked)
				{
					this.method_10();
				}
				if (this.cboxTerms.Checked && !frmReg.bool_3)
				{
					this.cboxTerms.Checked = false;
				}
			}
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x001194A4 File Offset: 0x001176A4
		private void method_10()
		{
			if (frmLogin.string_0 == "VN")
			{
				DialogResult dialogResult = MessageBox.Show(string.Concat(new string[]
				{
					"- Khi đăng ký ",
					GlobalSettings.AutoName,
					" bạn chắc chắn rằng đã tìm hiểu và xem xét kỹ nguồn gốc auto và tải auto từ trang chủ ",
					GlobalSettings.AutoHomeURL,
					", bạn đồng ý rằng:\n- Auto chất lượng, an toàn và không hack tài khoản của bạn.\n- Auto chỉ hỗ trợ tự làm các hoạt động trong game, không hỗ trợ hack\n- Auto luôn có bản miễn phí hỗ trợ anh em train quái.\n - Bạn có thể nạp GG để mua giờ sử dụng\n\n===============================================\n- Nếu không đồng ý với điều khoản này, bạn lập tức xóa ngay auto.\n- Nếu đồng ý rồi thì chơi vui vẻ không được khóc hay méc má\n===============================================\n\nNhấn YES để đồng ý 2 tay 3 chân\nNhấn NO - Chúng ta không thuộc về nhau"
				}), "Điều khoản sử dụng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dialogResult == DialogResult.No)
				{
					frmReg.bool_3 = false;
					base.Close();
					return;
				}
				if (dialogResult == DialogResult.Yes)
				{
					frmReg.bool_3 = true;
					this.cboxTerms.Checked = true;
				}
			}
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x0001657D File Offset: 0x0001477D
		private void txtUserLogin_TextChanged(object sender, EventArgs e)
		{
			this.lblStatus.Text = "";
			this.long_1 = frmLogin.stopwatch_0.ElapsedMilliseconds;
			this.bool_0 = true;
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x0011952C File Offset: 0x0011772C
		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (frmLogin.stopwatch_0.ElapsedMilliseconds - this.long_0 >= 10000L)
			{
				this.lblStatus.Text = "";
			}
			if (this.bool_0 && frmLogin.stopwatch_0.ElapsedMilliseconds - this.long_1 >= 3000L)
			{
				if (!this.backgroundWorker_0.IsBusy)
				{
					this.backgroundWorker_0.RunWorkerAsync(2);
					return;
				}
				this.long_1 = frmLogin.stopwatch_0.ElapsedMilliseconds;
			}
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x001195B4 File Offset: 0x001177B4
		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
			if (e.Argument != null && e.Argument.GetType() == typeof(int) && (int)e.Argument == 1)
			{
				this.bool_1 = this.method_5();
				e.Result = 1;
				return;
			}
			if (e.Argument != null && e.Argument.GetType() == typeof(int) && (int)e.Argument == 2)
			{
				this.method_6();
				return;
			}
			if (e.Argument != null && e.Argument.GetType() == typeof(int) && (int)e.Argument == 3)
			{
				this.method_8();
				e.Result = 3;
			}
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x0011967C File Offset: 0x0011787C
		private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Result != null && e.Result.GetType() == typeof(int) && (int)e.Result == 1 && this.bool_1)
			{
				this.btnDoReg.Enabled = true;
				this.btnRegCaptcha.Enabled = true;
				this.txtCode.Text = "";
				this.txtCode.Enabled = true;
			}
			if (e.Result != null && e.Result.GetType() == typeof(int) && (int)e.Result == 3)
			{
				this.btnDoReg.Enabled = true;
				if (this.bool_2)
				{
					this.bool_2 = false;
					if (!this.backgroundWorker_0.IsBusy)
					{
						this.btnDoReg.Enabled = false;
						this.txtCode.Text = "Vui lòng chờ";
						this.txtCode.Enabled = false;
						this.backgroundWorker_0.RunWorkerAsync(1);
					}
				}
			}
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x00119784 File Offset: 0x00117984
		private void btnRegCaptcha_Click(object sender, EventArgs e)
		{
			if (this.long_2 == 0L || (this.long_2 > 0L && frmLogin.stopwatch_0.ElapsedMilliseconds > this.long_2))
			{
				this.long_2 = frmLogin.stopwatch_0.ElapsedMilliseconds + 2000L;
				this.btnRegCaptcha.Enabled = false;
				if (!this.backgroundWorker_0.IsBusy)
				{
					this.backgroundWorker_0.RunWorkerAsync(1);
				}
			}
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x000165C5 File Offset: 0x000147C5
		[CompilerGenerated]
		private void method_11()
		{
			this.lblStatus.Text = "Tên tài khoản có từ không hợp lệ (sys, table,...)";
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x000165C5 File Offset: 0x000147C5
		[CompilerGenerated]
		private void method_12()
		{
			this.lblStatus.Text = "Tên tài khoản có từ không hợp lệ (sys, table,...)";
		}

		// Token: 0x04001355 RID: 4949
		internal Dictionary<string, string> dictionary_0 = frmLogin.class101_0.globalSettings_0.LoginInfo;

		// Token: 0x04001356 RID: 4950
		internal Dictionary<string, string> dictionary_1 = new Dictionary<string, string>();

		// Token: 0x04001357 RID: 4951
		private Class9 class9_0 = new Class9();

		// Token: 0x04001358 RID: 4952
		internal string string_0 = "";

		// Token: 0x04001359 RID: 4953
		internal string string_1 = "";

		// Token: 0x0400135A RID: 4954
		internal string string_2 = "";

		// Token: 0x0400135B RID: 4955
		private string string_3 = "";

		// Token: 0x0400135C RID: 4956
		private string string_4 = "";

		// Token: 0x0400135D RID: 4957
		private long long_0 = frmLogin.stopwatch_0.ElapsedMilliseconds;

		// Token: 0x0400135E RID: 4958
		private long long_1 = frmLogin.stopwatch_0.ElapsedMilliseconds;

		// Token: 0x0400135F RID: 4959
		private bool bool_0;

		// Token: 0x04001360 RID: 4960
		private bool bool_1;

		// Token: 0x04001361 RID: 4961
		private bool bool_2;

		// Token: 0x04001362 RID: 4962
		private long long_2;

		// Token: 0x04001363 RID: 4963
		private static bool bool_3;

		// Token: 0x0200012B RID: 299
		[CompilerGenerated]
		private sealed class Class203
		{
			// Token: 0x06001260 RID: 4704 RVA: 0x000165D7 File Offset: 0x000147D7
			internal void method_0()
			{
				this.frmReg_0.picCaptcha.Image = this.image_0;
			}

			// Token: 0x06001261 RID: 4705 RVA: 0x000165EF File Offset: 0x000147EF
			internal void method_1()
			{
				this.frmReg_0.btnDoReg.Enabled = true;
			}

			// Token: 0x04001379 RID: 4985
			public frmReg frmReg_0;

			// Token: 0x0400137A RID: 4986
			public Image image_0;
		}

		// Token: 0x0200012C RID: 300
		[CompilerGenerated]
		private sealed class Class204
		{
			// Token: 0x06001263 RID: 4707 RVA: 0x00016602 File Offset: 0x00014802
			internal void method_0()
			{
				this.frmReg_0.picCaptcha.Image = this.image_0;
			}

			// Token: 0x06001264 RID: 4708 RVA: 0x0001661A File Offset: 0x0001481A
			internal void method_1()
			{
				this.frmReg_0.btnDoReg.Enabled = true;
			}

			// Token: 0x0400137B RID: 4987
			public frmReg frmReg_0;

			// Token: 0x0400137C RID: 4988
			public Image image_0;
		}

		// Token: 0x0200012D RID: 301
		[CompilerGenerated]
		private sealed class Class205
		{
			// Token: 0x06001266 RID: 4710 RVA: 0x00119F60 File Offset: 0x00118160
			internal void method_0()
			{
				if (this.string_0.Contains("đã có"))
				{
					this.frmReg_0.lblStatus.ForeColor = Color.Red;
				}
				else
				{
					this.frmReg_0.lblStatus.ForeColor = Color.Blue;
				}
				this.frmReg_0.lblStatus.Text = this.string_0;
			}

			// Token: 0x0400137D RID: 4989
			public string string_0;

			// Token: 0x0400137E RID: 4990
			public frmReg frmReg_0;
		}

		// Token: 0x0200012E RID: 302
		[CompilerGenerated]
		private sealed class Class206
		{
			// Token: 0x06001268 RID: 4712 RVA: 0x00119FC4 File Offset: 0x001181C4
			internal void method_0()
			{
				if (this.string_0.Contains("đã có"))
				{
					this.frmReg_0.lblStatus.ForeColor = Color.Red;
				}
				else
				{
					this.frmReg_0.lblStatus.ForeColor = Color.Blue;
				}
				this.frmReg_0.lblStatus.Text = this.string_0;
			}

			// Token: 0x0400137F RID: 4991
			public string string_0;

			// Token: 0x04001380 RID: 4992
			public frmReg frmReg_0;
		}

		// Token: 0x0200012F RID: 303
		[CompilerGenerated]
		private sealed class Class207
		{
			// Token: 0x0600126A RID: 4714 RVA: 0x0001662D File Offset: 0x0001482D
			internal void method_0()
			{
				frmLogin.frmLogin_0.txtUserID.Text = this.string_0;
				frmLogin.frmLogin_0.txtUserPassword.Text = this.string_1;
				this.frmReg_0.Close();
			}

			// Token: 0x04001381 RID: 4993
			public frmReg frmReg_0;

			// Token: 0x04001382 RID: 4994
			public string string_0;

			// Token: 0x04001383 RID: 4995
			public string string_1;
		}
	}
}
