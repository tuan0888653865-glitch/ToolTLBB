using System;
using System.Drawing;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x0200002C RID: 44
	internal sealed class Class31 : Class26
	{
		// Token: 0x0600011C RID: 284 RVA: 0x00002BBE File Offset: 0x00000DBE
		internal Class31()
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002C8F File Offset: 0x00000E8F
		internal Class31(bool bool_1)
		{
			this.bool_0 = bool_1;
			base.String_0 = bool_1.ToString();
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00002CAB File Offset: 0x00000EAB
		// (set) Token: 0x0600011F RID: 287 RVA: 0x00002CB3 File Offset: 0x00000EB3
		internal bool Boolean_0
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
				base.String_0 = value.ToString();
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00019278 File Offset: 0x00017478
		internal override int vmethod_0(DrawListViewSubItemEventArgs drawListViewSubItemEventArgs_0, int int_0, Class23 class23_0)
		{
			Class25 @class = (Class25)class23_0;
			Image image;
			if (this.Boolean_0)
			{
				image = @class.Image_0;
			}
			else
			{
				image = @class.Image_1;
			}
			int y = drawListViewSubItemEventArgs_0.Bounds.Y + drawListViewSubItemEventArgs_0.Bounds.Height / 2 - image.Height / 2;
			drawListViewSubItemEventArgs_0.Graphics.DrawImage(image, int_0, y, image.Width, image.Height);
			int_0 += image.Width + 2;
			return int_0;
		}

		// Token: 0x04000058 RID: 88
		private bool bool_0;
	}
}
