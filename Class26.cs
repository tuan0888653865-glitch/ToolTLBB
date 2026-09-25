using System;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000027 RID: 39
	internal abstract class Class26 : ListViewItem.ListViewSubItem
	{
		// Token: 0x06000100 RID: 256 RVA: 0x00002B80 File Offset: 0x00000D80
		internal Class26()
		{
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002B93 File Offset: 0x00000D93
		internal Class26(string string_1)
		{
			base.Text = string_1;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00002BAD File Offset: 0x00000DAD
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00002BB5 File Offset: 0x00000DB5
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

		// Token: 0x06000104 RID: 260
		internal abstract int vmethod_0(DrawListViewSubItemEventArgs drawListViewSubItemEventArgs_0, int int_0, Class23 class23_0);

		// Token: 0x04000054 RID: 84
		private string string_0 = "";
	}
}
