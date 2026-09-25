using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x02000134 RID: 308
	internal static class Class211
	{
		// Token: 0x06001284 RID: 4740 RVA: 0x0011A3A0 File Offset: 0x001185A0
		[STAThread]
		private static void Main(string[] args)
		{
			AppDomain.CurrentDomain.UnhandledException += Class211.smethod_0;
			new Thread(new ThreadStart(Class211.<>c.<>c_0.method_0)).Start();
			new Thread(new ThreadStart(Class211.<>c.<>c_0.method_1)).Start();
			if (!Class211.mutex_0.WaitOne(TimeSpan.Zero, true))
			{
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
				{
					MessageBox.Show("Đã có bản GAuto khác đang chạy trên máy, không thể mở thêm.\nNếu bạn tin là chưa có bản GAuto nào khác mở, vui lòng thử cách sau:\nKhởi động lại máy\n- Tắt chương trình diệt virus\n- Click phải chọn Run as Administrator.", "Không thể mở GAuto", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
				{
					MessageBox.Show("You can only run one instance of AutoTL on this computer.\nIf you believe there is no other running AutoTL version, please try these steps:\nRestart computer\n- Turn off anti-virus application\n- Right click on the auto and select Run as Administrator.", "Cannot open AutoTL", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "CN")
				{
					MessageBox.Show("You can only run one instance of AutoTL on this computer.\nIf you believe there is no other running AutoTL version, please try these steps:\nRestart computer\n- Turn off anti-virus application\n- Right click on the auto and select Run as Administrator.", "Cannot open AutoTL", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				Class83.smethod_62(false);
				return;
			}
			int num = 0;
			try
			{
				bool flag = false;
				Process currentProcess = Process.GetCurrentProcess();
				FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(currentProcess.MainModule.FileName);
				if (versionInfo.OriginalFilename != "GAuto_Auto_bs.exe" && versionInfo.OriginalFilename != "GAuto_Auto_None.exe")
				{
					flag = false;
				}
				if (flag && args.Length == 0)
				{
					Process.GetCurrentProcess().Kill();
				}
				if (flag && args.Length != 0 && args[0].ToLower() == "master")
				{
					Process.GetCurrentProcess().Kill();
				}
				bool flag2;
				if ((flag2 = false) || args.Length != 0)
				{
					if (!flag2 && !(args[0].ToLower() == "master"))
					{
						frmLogin.bool_33 = true;
						if (args[0] != "")
						{
							try
							{
								string text = args[0].Substring(8, args[0].Length - 8);
								text = Class83.smethod_41(text, 0);
								text = text.Substring(8, text.Length - 8);
								frmLogin.string_12 = JsonConvert.DeserializeObject<Dictionary<string, object>>(text)["realversion"].ToString();
								goto IL_344;
							}
							catch (Exception)
							{
								Class83.smethod_62(false);
								goto IL_344;
							}
						}
						Class83.smethod_62(false);
					}
					else
					{
						try
						{
							string text2 = Class83.smethod_18(Class83.smethod_98(4)) + ".exe";
							File.Copy(currentProcess.MainModule.ModuleName, text2, true);
							Class83.smethod_19(text2);
							Thread.Sleep(2000);
							Class83.smethod_20(text2);
							Thread.Sleep(2000);
							Dictionary<string, object> dictionary = new Dictionary<string, object>();
							dictionary.Add(Class83.smethod_98(5), Class83.smethod_98(5));
							dictionary.Add("pseudo", "CCTN Tinh Kiem");
							dictionary.Add("realversion", Application.ProductVersion);
							string str = Class83.smethod_98(8);
							string text3 = JsonConvert.SerializeObject(dictionary);
							text3 = str + Class83.smethod_39(str + text3, 0);
							Process.Start(new ProcessStartInfo
							{
								Arguments = text3,
								FileName = text2,
								WorkingDirectory = Application.StartupPath
							});
							Process.GetCurrentProcess().Kill();
						}
						catch (Exception ex)
						{
							MessageBox.Show("Error: " + ex.Message + ". Stack = " + ex.StackTrace.ToString());
							Process.GetCurrentProcess().Kill();
						}
					}
				}
				IL_344:
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new frmLogin());
			}
			catch (Exception ex2)
			{
				string text4 = ex2.Message + " Stack: " + ex2.StackTrace.ToString();
				num++;
				MessageBox.Show(text4);
			}
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x0011A780 File Offset: 0x00118980
		private static void smethod_0(object sender, UnhandledExceptionEventArgs e)
		{
			MessageBox.Show(string.Format("Có lỗi, vui lòng chụp hình và gửi GAuto.\n{0}", e.ExceptionObject.ToString()));
			Thread.CurrentThread.IsBackground = true;
			Thread.CurrentThread.Name = "Dead thread";
			Thread.Sleep(TimeSpan.FromSeconds(1.0));
			Class83.smethod_62(false);
		}

		// Token: 0x0400138C RID: 5004
		private static Mutex mutex_0 = new Mutex(true, "40dcf750-e9ca-4819-b060-52715f3a494c");
	}
}
