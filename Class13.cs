using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000019 RID: 25
	internal sealed class Class13 : ComboBox
	{
		// Token: 0x060000A7 RID: 167 RVA: 0x00002737 File Offset: 0x00000937
		internal Class13()
		{
			this.brush_0 = SystemBrushes.Highlight;
			base.DrawMode = DrawMode.OwnerDrawFixed;
			base.DrawItem += this.Class13_DrawItem;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00002763 File Offset: 0x00000963
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x0000276B File Offset: 0x0000096B
		internal Brush Brush_0
		{
			get
			{
				return this.brush_0;
			}
			set
			{
				this.brush_0 = value;
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00017C14 File Offset: 0x00015E14
		private void Class13_DrawItem(object sender, DrawItemEventArgs e)
		{
			if (e.Index == -1)
			{
				return;
			}
			e.DrawBackground();
			if ((e.State & DrawItemState.Selected) != DrawItemState.None)
			{
				e.Graphics.FillRectangle(this.brush_0, e.Bounds);
			}
			Class13.Class14 @class = (Class13.Class14)base.Items[e.Index];
			Rectangle bounds = e.Bounds;
			int num = bounds.X + 2;
			if (@class.GetType() == typeof(Class13.Class15))
			{
				Class13.Class15 class2 = (Class13.Class15)@class;
				if (class2.Image_0 != null)
				{
					Image image_ = class2.Image_0;
					int y = bounds.Y + bounds.Height / 2 - image_.Height / 2 + 1;
					e.Graphics.DrawImage(image_, num, y, image_.Width, image_.Height);
					num += image_.Width + 2;
				}
			}
			else if (@class.GetType() == typeof(Class13.Class16))
			{
				Class13.Class16 class3 = (Class13.Class16)@class;
				if (class3.ArrayList_0 != null)
				{
					for (int i = 0; i < class3.ArrayList_0.Count; i++)
					{
						Image image = (Image)class3.ArrayList_0[i];
						int y2 = bounds.Y + bounds.Height / 2 - image.Height / 2 + 1;
						e.Graphics.DrawImage(image, num, y2, image.Width, image.Height);
						num += image.Width + 2;
					}
				}
			}
			int num2 = bounds.Y + bounds.Height / 2 - e.Font.Height / 2;
			e.Graphics.DrawString(@class.String_0, e.Font, new SolidBrush(e.ForeColor), (float)num, (float)num2);
			e.DrawFocusRectangle();
		}

		// Token: 0x0400002C RID: 44
		private Brush brush_0;

		// Token: 0x0200001A RID: 26
		public class Class14
		{
			// Token: 0x060000AB RID: 171 RVA: 0x00002774 File Offset: 0x00000974
			internal Class14()
			{
			}

			// Token: 0x060000AC RID: 172 RVA: 0x00002792 File Offset: 0x00000992
			internal Class14(string string_2)
			{
				this.string_0 = string_2;
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x060000AD RID: 173 RVA: 0x000027B7 File Offset: 0x000009B7
			// (set) Token: 0x060000AE RID: 174 RVA: 0x000027BF File Offset: 0x000009BF
			internal string String_0
			{
				get
				{
					return this.string_0;
				}
				set
				{
					this.string_0 = value;
				}
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x060000AF RID: 175 RVA: 0x000027C8 File Offset: 0x000009C8
			// (set) Token: 0x060000B0 RID: 176 RVA: 0x000027D0 File Offset: 0x000009D0
			internal string String_1
			{
				get
				{
					return this.string_1;
				}
				set
				{
					this.string_1 = value;
				}
			}

			// Token: 0x060000B1 RID: 177 RVA: 0x000027B7 File Offset: 0x000009B7
			public override string ToString()
			{
				return this.string_0;
			}

			// Token: 0x0400002D RID: 45
			private string string_0 = "";

			// Token: 0x0400002E RID: 46
			private string string_1 = "";
		}

		// Token: 0x0200001B RID: 27
		internal sealed class Class15 : Class13.Class14
		{
			// Token: 0x060000B2 RID: 178 RVA: 0x000027D9 File Offset: 0x000009D9
			internal Class15()
			{
			}

			// Token: 0x060000B3 RID: 179 RVA: 0x000027E1 File Offset: 0x000009E1
			internal Class15(string string_2)
			{
				base.String_0 = string_2;
			}

			// Token: 0x060000B4 RID: 180 RVA: 0x000027F0 File Offset: 0x000009F0
			internal Class15(Image image_1)
			{
				this.image_0 = image_1;
			}

			// Token: 0x060000B5 RID: 181 RVA: 0x000027FF File Offset: 0x000009FF
			internal Class15(string string_2, Image image_1)
			{
				base.String_0 = string_2;
				this.image_0 = image_1;
			}

			// Token: 0x060000B6 RID: 182 RVA: 0x00002815 File Offset: 0x00000A15
			internal Class15(Image image_1, string string_2)
			{
				this.image_0 = image_1;
				base.String_1 = string_2;
			}

			// Token: 0x060000B7 RID: 183 RVA: 0x0000282B File Offset: 0x00000A2B
			internal Class15(string string_2, Image image_1, string string_3)
			{
				base.String_0 = string_2;
				this.image_0 = image_1;
				base.String_1 = string_3;
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x060000B8 RID: 184 RVA: 0x00002848 File Offset: 0x00000A48
			// (set) Token: 0x060000B9 RID: 185 RVA: 0x00002850 File Offset: 0x00000A50
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

			// Token: 0x0400002F RID: 47
			private Image image_0;
		}

		// Token: 0x0200001C RID: 28
		internal sealed class Class16 : Class13.Class14
		{
			// Token: 0x060000BA RID: 186 RVA: 0x000027D9 File Offset: 0x000009D9
			internal Class16()
			{
			}

			// Token: 0x060000BB RID: 187 RVA: 0x000027E1 File Offset: 0x000009E1
			internal Class16(string string_2)
			{
				base.String_0 = string_2;
			}

			// Token: 0x060000BC RID: 188 RVA: 0x00002859 File Offset: 0x00000A59
			internal Class16(ArrayList arrayList_1)
			{
				this.arrayList_0 = arrayList_1;
			}

			// Token: 0x060000BD RID: 189 RVA: 0x00002868 File Offset: 0x00000A68
			internal Class16(string string_2, ArrayList arrayList_1)
			{
				base.String_0 = string_2;
				this.arrayList_0 = arrayList_1;
			}

			// Token: 0x060000BE RID: 190 RVA: 0x0000287E File Offset: 0x00000A7E
			internal Class16(ArrayList arrayList_1, string string_2)
			{
				this.arrayList_0 = arrayList_1;
				base.String_1 = string_2;
			}

			// Token: 0x060000BF RID: 191 RVA: 0x00002894 File Offset: 0x00000A94
			internal Class16(string string_2, ArrayList arrayList_1, string string_3)
			{
				base.String_0 = string_2;
				this.arrayList_0 = arrayList_1;
				base.String_1 = string_3;
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x060000C0 RID: 192 RVA: 0x000028B1 File Offset: 0x00000AB1
			// (set) Token: 0x060000C1 RID: 193 RVA: 0x000028B9 File Offset: 0x00000AB9
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

			// Token: 0x04000030 RID: 48
			private ArrayList arrayList_0;
		}
	}
}
