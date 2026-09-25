using System;

namespace ns0
{
	// Token: 0x02000010 RID: 16
	internal sealed class Class7
	{
		// Token: 0x0600007C RID: 124 RVA: 0x000024FD File Offset: 0x000006FD
		internal Class7()
		{
			this.bool_0 = false;
			this.string_0 = "";
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00002517 File Offset: 0x00000717
		internal string String_0
		{
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000177EC File Offset: 0x000159EC
		internal void method_0(string string_1, string string_2)
		{
			this.string_0 = string.Concat(new string[]
			{
				this.string_0,
				this.bool_0 ? "" : "&",
				string_1,
				"=",
				string_2
			});
			this.bool_0 = false;
		}

		// Token: 0x04000018 RID: 24
		private string string_0;

		// Token: 0x04000019 RID: 25
		private bool bool_0;
	}
}
