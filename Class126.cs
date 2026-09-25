using System;
using System.Collections.Generic;

namespace ns0
{
	// Token: 0x020000A5 RID: 165
	internal sealed class Class126
	{
		// Token: 0x060007B3 RID: 1971 RVA: 0x00099D0C File Offset: 0x00097F0C
		internal Class126()
		{
			for (int i = 0; i < 6; i++)
			{
				this.list_0.Add(new Class127());
			}
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x000092FF File Offset: 0x000074FF
		internal void method_0(Class59 class59_1)
		{
			this.class59_0 = class59_1;
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00009308 File Offset: 0x00007508
		private unsafe bool method_1()
		{
			return this.class59_0 == null || (IntPtr)((void*)this.class59_0.pByte_6) != IntPtr.Zero;
		}

		// Token: 0x040008F1 RID: 2289
		private int int_0 = 66;

		// Token: 0x040008F2 RID: 2290
		private Class59 class59_0;

		// Token: 0x040008F3 RID: 2291
		internal int int_1;

		// Token: 0x040008F4 RID: 2292
		internal int int_2;

		// Token: 0x040008F5 RID: 2293
		internal int int_3;

		// Token: 0x040008F6 RID: 2294
		internal int int_4;

		// Token: 0x040008F7 RID: 2295
		internal int int_5;

		// Token: 0x040008F8 RID: 2296
		internal int int_6;

		// Token: 0x040008F9 RID: 2297
		internal int int_7;

		// Token: 0x040008FA RID: 2298
		internal int int_8;

		// Token: 0x040008FB RID: 2299
		internal int int_9 = -1;

		// Token: 0x040008FC RID: 2300
		internal int int_10 = 9;

		// Token: 0x040008FD RID: 2301
		internal long long_0;

		// Token: 0x040008FE RID: 2302
		internal string string_0 = "";

		// Token: 0x040008FF RID: 2303
		internal List<Class127> list_0 = new List<Class127>();

		// Token: 0x04000900 RID: 2304
		internal string string_1 = "";

		// Token: 0x04000901 RID: 2305
		internal int int_11;

		// Token: 0x04000902 RID: 2306
		internal int int_12;

		// Token: 0x04000903 RID: 2307
		internal int int_13;

		// Token: 0x04000904 RID: 2308
		internal int int_14;

		// Token: 0x04000905 RID: 2309
		internal int int_15;
	}
}
