using System;
using System.Drawing;

namespace ns0
{
	// Token: 0x0200002E RID: 46
	internal sealed class Class33 : Class32
	{
		// Token: 0x06000125 RID: 293 RVA: 0x00002CF1 File Offset: 0x00000EF1
		internal Class33()
		{
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002CF9 File Offset: 0x00000EF9
		internal Class33(string string_1)
		{
			base.Text = string_1;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002D08 File Offset: 0x00000F08
		internal Class33(Image image_1)
		{
			this.image_0 = image_1;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002D17 File Offset: 0x00000F17
		internal Class33(string string_1, Image image_1)
		{
			this.image_0 = image_1;
			base.Text = string_1;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002D2D File Offset: 0x00000F2D
		internal Class33(string string_1, Image image_1, string string_2)
		{
			base.Text = string_1;
			this.image_0 = image_1;
			base.String_0 = string_2;
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00002D4A File Offset: 0x00000F4A
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00002D52 File Offset: 0x00000F52
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

		// Token: 0x0400005A RID: 90
		private Image image_0;
	}
}
