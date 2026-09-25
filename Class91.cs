using System;
using System.Collections.Generic;

namespace ns0
{
	// Token: 0x0200007E RID: 126
	internal sealed class Class91
	{
		// Token: 0x06000460 RID: 1120 RVA: 0x0007C4E4 File Offset: 0x0007A6E4
		internal Class91()
		{
			for (int i = 0; i < 30; i++)
			{
				this.list_0.Add(new Class127());
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x000047A3 File Offset: 0x000029A3
		internal void method_0(Class59 class59_1)
		{
			this.class59_0 = class59_1;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x000047AC File Offset: 0x000029AC
		private bool method_1()
		{
			return true;
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x0007C52C File Offset: 0x0007A72C
		internal bool Boolean_0
		{
			get
			{
				if (this.list_0.Count > 0)
				{
					for (int i = 0; i < 30; i++)
					{
						if (this.list_0[i].int_0 != 0)
						{
							return true;
						}
					}
				}
				return false;
			}
		}

		// Token: 0x040002F0 RID: 752
		private int int_0 = 66;

		// Token: 0x040002F1 RID: 753
		private Class59 class59_0;

		// Token: 0x040002F2 RID: 754
		internal List<Class127> list_0 = new List<Class127>(30);
	}
}
