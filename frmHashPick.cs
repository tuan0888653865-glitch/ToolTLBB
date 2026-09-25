using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x020000EB RID: 235
	internal sealed partial class frmHashPick : Form
	{
		// Token: 0x06000910 RID: 2320 RVA: 0x000A64A0 File Offset: 0x000A46A0
		internal frmHashPick()
		{
			if (frmLogin.string_0 == "EN")
			{
				CultureInfo cultureInfo = new CultureInfo("en-GB");
				Thread.CurrentThread.CurrentCulture = cultureInfo;
				Thread.CurrentThread.CurrentUICulture = cultureInfo;
			}
			else if (frmLogin.string_0 == "CN")
			{
				CultureInfo currentUICulture = new CultureInfo("zh-Hans");
				CultureInfo currentCulture = new CultureInfo("zh-CN");
				Thread.CurrentThread.CurrentCulture = currentCulture;
				Thread.CurrentThread.CurrentUICulture = currentUICulture;
			}
			this.InitializeComponent();
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00009CCC File Offset: 0x00007ECC
		private void frmHashPick_Load(object sender, EventArgs e)
		{
			if (frmMain.frmMain_0.long_1 > 0L)
			{
				frmMain.frmMain_0.long_1 = frmLogin.stopwatch_0.ElapsedMilliseconds + 5000L;
			}
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00009CF7 File Offset: 0x00007EF7
		private void frmHashPick_Shown(object sender, EventArgs e)
		{
			this.long_0 = frmLogin.stopwatch_0.ElapsedMilliseconds;
			this.cboNPH.SelectedIndex = -1;
			this.timer_0.Enabled = true;
			base.TopMost = true;
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x000A6538 File Offset: 0x000A4738
		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (this.long_0 != 0L)
			{
				if (frmLogin.stopwatch_0.ElapsedMilliseconds - this.long_0 >= 15000L)
				{
					if (this.cboNPH.SelectedIndex >= 0)
					{
						this.method_0();
					}
					else if (!frmLogin.list_23.Contains(this.string_0))
					{
						frmLogin.list_23.Add(this.string_0);
					}
					base.Close();
					return;
				}
				long num = frmLogin.stopwatch_0.ElapsedMilliseconds - this.long_0;
				TimeSpan timeSpan = TimeSpan.FromMilliseconds((double)(15000L - num));
				this.lblTimer.Text = string.Format(frmMain.String_317, timeSpan.Seconds.ToString("00"));
			}
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x000024E9 File Offset: 0x000006E9
		private void cboNPH_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00009D28 File Offset: 0x00007F28
		private void btnHashChon_Click(object sender, EventArgs e)
		{
			this.method_0();
			base.Close();
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x000A65F4 File Offset: 0x000A47F4
		private void method_0()
		{
			if (frmLogin.list_25.Count > 0)
			{
				string a = "Vinagame 2D";
				if (this.cboNPH.SelectedIndex >= 0 && this.cboNPH.SelectedIndex < this.cboNPH.Items.Count)
				{
					a = this.cboNPH.Items[this.cboNPH.SelectedIndex].ToString();
				}
				if (a == "Vinagame 2D")
				{
					using (List<Class144>.Enumerator enumerator = frmLogin.list_25.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Class144 @class = enumerator.Current;
							if (@class.string_2 == "2d")
							{
								Class140 class2 = new Class140();
								class2.string_0 = this.string_0;
								class2.string_1 = @class.string_0;
								frmLogin.list_20.Add(class2);
								frmLogin.list_24.Add(this.string_0);
								break;
							}
						}
						return;
					}
				}
				if (a == "Vinagame 3D")
				{
					using (List<Class144>.Enumerator enumerator = frmLogin.list_25.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Class144 class3 = enumerator.Current;
							if (class3.string_2 == "3d")
							{
								Class140 class4 = new Class140();
								class4.string_0 = this.string_0;
								class4.string_1 = class3.string_0;
								frmLogin.list_20.Add(class4);
								frmLogin.list_24.Add(this.string_0);
								break;
							}
						}
						return;
					}
				}
				if (!(a == "Tình Kiếm") && !(a == "69Dragon"))
				{
					using (List<Class144>.Enumerator enumerator = frmLogin.list_25.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Class144 class5 = enumerator.Current;
							if (class5.string_2 == "tk" && class5.string_1 != "3.66.0000")
							{
								Class140 class6 = new Class140();
								class6.string_0 = this.string_0;
								class6.string_1 = class5.string_0;
								frmLogin.list_20.Add(class6);
								frmLogin.list_24.Add(this.string_0);
								break;
							}
						}
						return;
					}
				}
				foreach (Class144 class7 in frmLogin.list_25)
				{
					if (class7.string_2 == "tk" && class7.string_1 == "3.66.0000")
					{
						Class140 class8 = new Class140();
						class8.string_0 = this.string_0;
						class8.string_1 = class7.string_0;
						frmLogin.list_20.Add(class8);
						frmLogin.list_24.Add(this.string_0);
						break;
					}
				}
			}
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00009D36 File Offset: 0x00007F36
		private void btnHashHuy_Click(object sender, EventArgs e)
		{
			if (!frmLogin.list_23.Contains(this.string_0))
			{
				frmLogin.list_23.Add(this.string_0);
			}
			base.Close();
		}

		// Token: 0x04000BC5 RID: 3013
		private long long_0;

		// Token: 0x04000BC6 RID: 3014
		internal int int_0;

		// Token: 0x04000BC7 RID: 3015
		internal List<int> list_0;

		// Token: 0x04000BC8 RID: 3016
		internal string string_0 = "";
	}
}
