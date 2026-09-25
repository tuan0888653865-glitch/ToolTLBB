using System;
using System.Collections.Generic;

namespace ns0
{
	// Token: 0x02000087 RID: 135
	internal sealed class Class100
	{
		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x00004915 File Offset: 0x00002B15
		internal int Int32_0
		{
			get
			{
				if (this.list_0 != null)
				{
					return this.list_0.Count;
				}
				return 0;
			}
		}

		// Token: 0x04000313 RID: 787
		internal Class57.Enum2 enum2_0;

		// Token: 0x04000314 RID: 788
		internal Class57.Enum2 enum2_1;

		// Token: 0x04000315 RID: 789
		internal string string_0 = "";

		// Token: 0x04000316 RID: 790
		internal int int_0;

		// Token: 0x04000317 RID: 791
		internal List<object> list_0 = new List<object>();
	}
}
