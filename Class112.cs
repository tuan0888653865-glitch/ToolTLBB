using System;
using System.Collections.Generic;

namespace ns0
{
	// Token: 0x02000096 RID: 150
	internal sealed class Class112
	{
		// Token: 0x0600074A RID: 1866 RVA: 0x00097FF8 File Offset: 0x000961F8
		internal Class112()
		{
			for (int i = 0; i < 90; i++)
			{
				this.list_1.Add(new Class113());
			}
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00008CD1 File Offset: 0x00006ED1
		internal void method_0(Class59 class59_1)
		{
			this.class59_0 = class59_1;
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x000047AC File Offset: 0x000029AC
		private bool method_1()
		{
			return true;
		}

		// Token: 0x04000613 RID: 1555
		private int int_0 = 33;

		// Token: 0x04000614 RID: 1556
		private Class59 class59_0;

		// Token: 0x04000615 RID: 1557
		internal List<int> list_0 = new List<int>();

		// Token: 0x04000616 RID: 1558
		internal string string_0 = "";

		// Token: 0x04000617 RID: 1559
		internal string string_1 = "";

		// Token: 0x04000618 RID: 1560
		internal List<Class113> list_1 = new List<Class113>();

		// Token: 0x04000619 RID: 1561
		internal string string_2 = "Chưa ăn món nào";
	}
}
