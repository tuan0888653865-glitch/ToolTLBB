using System;

namespace ns0
{
	// Token: 0x020000AD RID: 173
	internal sealed class Class134
	{
		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x00009466 File Offset: 0x00007666
		// (set) Token: 0x060007C3 RID: 1987 RVA: 0x0000946E File Offset: 0x0000766E
		internal int Int32_0
		{
			get
			{
				return this.int_4;
			}
			set
			{
				this.int_4 = value;
				if (this.int_4 > 0)
				{
					this.bool_1 = true;
				}
			}
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00009487 File Offset: 0x00007687
		internal void method_0(int int_5)
		{
			this.Int32_0 = int_5;
		}

		// Token: 0x04000927 RID: 2343
		internal string string_0 = "";

		// Token: 0x04000928 RID: 2344
		internal string string_1 = "";

		// Token: 0x04000929 RID: 2345
		internal int int_0;

		// Token: 0x0400092A RID: 2346
		internal Class133 class133_0;

		// Token: 0x0400092B RID: 2347
		internal int int_1 = 1;

		// Token: 0x0400092C RID: 2348
		internal int int_2;

		// Token: 0x0400092D RID: 2349
		internal bool bool_0;

		// Token: 0x0400092E RID: 2350
		internal bool bool_1;

		// Token: 0x0400092F RID: 2351
		internal int int_3;

		// Token: 0x04000930 RID: 2352
		private int int_4;
	}
}
