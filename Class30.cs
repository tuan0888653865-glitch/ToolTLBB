using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x0200002B RID: 43
	internal sealed class Class30 : Class26
	{
		// Token: 0x06000114 RID: 276 RVA: 0x00002BBE File Offset: 0x00000DBE
		internal Class30()
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002BC6 File Offset: 0x00000DC6
		internal Class30(string string_1)
		{
			base.Text = string_1;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002C3C File Offset: 0x00000E3C
		internal Class30(ArrayList arrayList_1)
		{
			this.arrayList_0 = arrayList_1;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002C4B File Offset: 0x00000E4B
		internal Class30(ArrayList arrayList_1, string string_1)
		{
			this.arrayList_0 = arrayList_1;
			base.String_0 = string_1;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002C61 File Offset: 0x00000E61
		internal Class30(string string_1, ArrayList arrayList_1, string string_2)
		{
			base.Text = string_1;
			this.arrayList_0 = arrayList_1;
			base.String_0 = string_2;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00002C7E File Offset: 0x00000E7E
		// (set) Token: 0x0600011A RID: 282 RVA: 0x00002C86 File Offset: 0x00000E86
		internal ArrayList ArrayList_0
		{
			get
			{
				return this.arrayList_0;
			}
			set
			{
				this.arrayList_0 = value;
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000191D8 File Offset: 0x000173D8
		internal override int vmethod_0(DrawListViewSubItemEventArgs drawListViewSubItemEventArgs_0, int int_0, Class23 class23_0)
		{
			if (this.ArrayList_0 != null && this.ArrayList_0.Count > 0)
			{
				for (int i = 0; i < this.ArrayList_0.Count; i++)
				{
					Image image = (Image)this.ArrayList_0[i];
					int y = drawListViewSubItemEventArgs_0.Bounds.Y + drawListViewSubItemEventArgs_0.Bounds.Height / 2 - image.Height / 2;
					drawListViewSubItemEventArgs_0.Graphics.DrawImage(image, int_0, y, image.Width, image.Height);
					int_0 += image.Width + 2;
				}
			}
			return int_0;
		}

		// Token: 0x04000057 RID: 87
		private ArrayList arrayList_0;
	}
}
