using System;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x0200002D RID: 45
	internal class Class32 : ListViewItem
	{
		// Token: 0x06000121 RID: 289 RVA: 0x00002CC9 File Offset: 0x00000EC9
		internal Class32()
		{
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002CD1 File Offset: 0x00000ED1
		internal Class32(string string_1)
		{
			base.Text = string_1;
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00002CE0 File Offset: 0x00000EE0
		// (set) Token: 0x06000124 RID: 292 RVA: 0x00002CE8 File Offset: 0x00000EE8
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

		// Token: 0x04000059 RID: 89
		private string string_0;
	}
}
