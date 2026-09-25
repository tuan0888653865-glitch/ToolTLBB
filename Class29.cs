using System;
using System.Drawing;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x0200002A RID: 42
	internal sealed class Class29 : Class26
	{
		// Token: 0x0600010C RID: 268 RVA: 0x00002BBE File Offset: 0x00000DBE
		internal Class29()
		{
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002BC6 File Offset: 0x00000DC6
		internal Class29(string string_1)
		{
			base.Text = string_1;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002BE9 File Offset: 0x00000DE9
		internal Class29(Image image_1)
		{
			this.image_0 = image_1;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002BF8 File Offset: 0x00000DF8
		internal Class29(Image image_1, string string_1)
		{
			this.image_0 = image_1;
			base.String_0 = string_1;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002C0E File Offset: 0x00000E0E
		internal Class29(string string_1, Image image_1, string string_2)
		{
			base.Text = string_1;
			this.image_0 = image_1;
			base.String_0 = string_2;
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00002C2B File Offset: 0x00000E2B
		// (set) Token: 0x06000112 RID: 274 RVA: 0x00002C33 File Offset: 0x00000E33
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

		// Token: 0x06000113 RID: 275 RVA: 0x00019168 File Offset: 0x00017368
		internal override int vmethod_0(DrawListViewSubItemEventArgs drawListViewSubItemEventArgs_0, int int_0, Class23 class23_0)
		{
			if (this.Image_0 != null)
			{
				Image image = this.Image_0;
				int y = drawListViewSubItemEventArgs_0.Bounds.Y + drawListViewSubItemEventArgs_0.Bounds.Height / 2 - image.Height / 2;
				drawListViewSubItemEventArgs_0.Graphics.DrawImage(image, int_0, y, image.Width, image.Height);
				int_0 += image.Width + 2;
			}
			return int_0;
		}

		// Token: 0x04000056 RID: 86
		private Image image_0;
	}
}
