using System;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000029 RID: 41
	internal sealed class Class28 : Class26
	{
		// Token: 0x06000108 RID: 264 RVA: 0x00002BBE File Offset: 0x00000DBE
		internal Class28()
		{
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00002BD8 File Offset: 0x00000DD8
		// (set) Token: 0x0600010A RID: 266 RVA: 0x00002BE0 File Offset: 0x00000DE0
		internal Control Control_0
		{
			get
			{
				return this.control_0;
			}
			set
			{
				this.control_0 = value;
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002BD5 File Offset: 0x00000DD5
		internal override int vmethod_0(DrawListViewSubItemEventArgs drawListViewSubItemEventArgs_0, int int_0, Class23 class23_0)
		{
			return int_0;
		}

		// Token: 0x04000055 RID: 85
		private Control control_0;
	}
}
