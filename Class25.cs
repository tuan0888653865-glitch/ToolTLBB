using System;
using System.Drawing;

namespace ns0
{
	// Token: 0x02000026 RID: 38
	internal sealed class Class25 : Class23
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x00002AB7 File Offset: 0x00000CB7
		internal Class25()
		{
			this.method_0();
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002AC5 File Offset: 0x00000CC5
		internal Class25(string string_0)
		{
			this.method_0();
			base.Text = string_0;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002ADA File Offset: 0x00000CDA
		internal Class25(string string_0, int int_0)
		{
			this.method_0();
			base.Text = string_0;
			base.Width = int_0;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002AF6 File Offset: 0x00000CF6
		internal Class25(string string_0, Image image_2, Image image_3)
		{
			this.method_0();
			base.Text = string_0;
			this.image_0 = image_2;
			this.image_1 = image_3;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002B19 File Offset: 0x00000D19
		internal Class25(string string_0, Image image_2, Image image_3, int int_0)
		{
			this.method_0();
			base.Text = string_0;
			this.image_0 = image_2;
			this.image_1 = image_3;
			base.Width = int_0;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002B44 File Offset: 0x00000D44
		private void method_0()
		{
			this.bool_0 = false;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00002B4D File Offset: 0x00000D4D
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00002B55 File Offset: 0x00000D55
		internal Image Image_0
		{
			get
			{
				return this.image_0;
			}
			set
			{
				this.image_0 = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00002B5E File Offset: 0x00000D5E
		// (set) Token: 0x060000FD RID: 253 RVA: 0x00002B66 File Offset: 0x00000D66
		internal Image Image_1
		{
			get
			{
				return this.image_1;
			}
			set
			{
				this.image_1 = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00002B6F File Offset: 0x00000D6F
		// (set) Token: 0x060000FF RID: 255 RVA: 0x00002B77 File Offset: 0x00000D77
		internal bool Boolean_0
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
			}
		}

		// Token: 0x04000051 RID: 81
		private Image image_0;

		// Token: 0x04000052 RID: 82
		private Image image_1;

		// Token: 0x04000053 RID: 83
		private bool bool_0;
	}
}
