using System;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000025 RID: 37
	internal sealed class Class24 : Class23
	{
		// Token: 0x060000ED RID: 237 RVA: 0x00002A2A File Offset: 0x00000C2A
		internal Class24()
		{
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002A32 File Offset: 0x00000C32
		internal Class24(string string_0)
		{
			base.Text = string_0;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002A41 File Offset: 0x00000C41
		internal Class24(string string_0, int int_0)
		{
			base.Text = string_0;
			base.Width = int_0;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002A57 File Offset: 0x00000C57
		internal Class24(string string_0, Control control_1)
		{
			base.Text = string_0;
			this.Control_0 = control_1;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002A6D File Offset: 0x00000C6D
		internal Class24(string string_0, Control control_1, int int_0)
		{
			base.Text = string_0;
			this.Control_0 = control_1;
			base.Width = int_0;
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00002A8A File Offset: 0x00000C8A
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002A92 File Offset: 0x00000C92
		internal Control Control_0
		{
			get
			{
				return this.control_0;
			}
			set
			{
				this.control_0 = value;
				this.control_0.Visible = false;
				this.control_0.Tag = "not_init";
			}
		}

		// Token: 0x04000050 RID: 80
		private Control control_0;
	}
}
