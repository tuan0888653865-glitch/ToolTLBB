using System;
using System.Collections;

namespace ns0
{
	// Token: 0x0200002F RID: 47
	internal sealed class Class34 : Class32
	{
		// Token: 0x0600012C RID: 300 RVA: 0x00002CF1 File Offset: 0x00000EF1
		internal Class34()
		{
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002CF9 File Offset: 0x00000EF9
		internal Class34(string string_1)
		{
			base.Text = string_1;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002D5B File Offset: 0x00000F5B
		internal Class34(ArrayList arrayList_1)
		{
			this.arrayList_0 = arrayList_1;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002D6A File Offset: 0x00000F6A
		internal Class34(string string_1, ArrayList arrayList_1)
		{
			base.Text = string_1;
			this.arrayList_0 = arrayList_1;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002D80 File Offset: 0x00000F80
		internal Class34(string string_1, ArrayList arrayList_1, string string_2)
		{
			base.Text = string_1;
			this.arrayList_0 = arrayList_1;
			base.String_0 = string_2;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00002D9D File Offset: 0x00000F9D
		// (set) Token: 0x06000132 RID: 306 RVA: 0x00002DA5 File Offset: 0x00000FA5
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

		// Token: 0x0400005B RID: 91
		private ArrayList arrayList_0;
	}
}
