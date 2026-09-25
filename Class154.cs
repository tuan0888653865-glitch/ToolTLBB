using System;
using System.Collections.Generic;

namespace ns0
{
	// Token: 0x020000C1 RID: 193
	internal sealed class Class154
	{
		// Token: 0x060007D9 RID: 2009 RVA: 0x00099E1C File Offset: 0x0009801C
		internal Class154(Class59 class59_1)
		{
			this.class59_0 = class59_1;
			for (int i = 0; i < 12; i++)
			{
				this.list_0.Add(new Class155());
			}
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x000096CE File Offset: 0x000078CE
		private unsafe bool method_0()
		{
			return (IntPtr)((void*)this.class59_0.pByte_0) != IntPtr.Zero;
		}

		// Token: 0x04000992 RID: 2450
		private int int_0 = 12;

		// Token: 0x04000993 RID: 2451
		private int int_1 = 33;

		// Token: 0x04000994 RID: 2452
		private Class59 class59_0;

		// Token: 0x04000995 RID: 2453
		private List<Class155> list_0 = new List<Class155>();
	}
}
