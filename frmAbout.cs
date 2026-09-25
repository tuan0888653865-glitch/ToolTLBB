using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using SmartBot;

namespace ns0
{
	// Token: 0x020000E3 RID: 227
	internal sealed partial class frmAbout : Form
	{
		// Token: 0x0600086C RID: 2156 RVA: 0x0009E4E4 File Offset: 0x0009C6E4
		internal frmAbout()
		{
			this.InitializeComponent();
			this.Text = string.Format(frmMain.Object_0 + "Games Automation Team", GlobalSettings.AutoName);
			this.labelProductName.Text = GlobalSettings.AutoName + frmMain.String_781 + "Games Automation Team";
			this.labelVersion.Text = string.Format("Version {0}", this.String_1);
			this.labelCopyright.Text = this.String_4;
			this.labelCompanyName.Text = "Games Automation Team";
			if (frmLogin.string_0 == "VN")
			{
				this.textBoxDescription.Text = "Games Automation Team xin giới thiệu tới các bạn TLBB Auto. Auto sẽ ngày càng có nhiều tính năng độc đáo hơn và thông minh hơn.\nThông tin về phiên bản mới liên tục được cập nhật tại trang chủ www.gameauto.net";
				return;
			}
			this.textBoxDescription.Text = "Games Automation Team is pleased to introduce Dragon Oath Auto. Auto is actively developed and will have more intelligent functions. Latest news about this auto are publised on www.tianlongauto.net";
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x0009E5AC File Offset: 0x0009C7AC
		internal string String_0
		{
			get
			{
				object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
				if (customAttributes.Length != 0)
				{
					AssemblyTitleAttribute assemblyTitleAttribute = (AssemblyTitleAttribute)customAttributes[0];
					if (assemblyTitleAttribute.Title != "")
					{
						return assemblyTitleAttribute.Title;
					}
				}
				return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x000098BE File Offset: 0x00007ABE
		internal string String_1
		{
			get
			{
				return Assembly.GetExecutingAssembly().GetName().Version.ToString();
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x0009E604 File Offset: 0x0009C804
		internal string String_2
		{
			get
			{
				object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
				if (customAttributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyDescriptionAttribute)customAttributes[0]).Description;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x0009E640 File Offset: 0x0009C840
		internal string String_3
		{
			get
			{
				object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
				if (customAttributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyProductAttribute)customAttributes[0]).Product;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x0009E67C File Offset: 0x0009C87C
		internal string String_4
		{
			get
			{
				object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
				if (customAttributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyCopyrightAttribute)customAttributes[0]).Copyright;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000872 RID: 2162 RVA: 0x0009E6B8 File Offset: 0x0009C8B8
		internal string String_5
		{
			get
			{
				object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
				if (customAttributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyCompanyAttribute)customAttributes[0]).Company;
			}
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x000024E9 File Offset: 0x000006E9
		private void frmAbout_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x000098D4 File Offset: 0x00007AD4
		private void okButton_Click(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
