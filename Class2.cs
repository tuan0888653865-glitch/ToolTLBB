using System;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x02000008 RID: 8
	internal sealed class Class2
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00002486 File Offset: 0x00000686
		internal Class2(string string_1, bool bool_1)
		{
			this.ResponseBody = string_1;
			this.Error = bool_1;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001E RID: 30 RVA: 0x0000249C File Offset: 0x0000069C
		// (set) Token: 0x0600001F RID: 31 RVA: 0x000024A4 File Offset: 0x000006A4
		internal string ResponseBody { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000024AD File Offset: 0x000006AD
		// (set) Token: 0x06000021 RID: 33 RVA: 0x000024B5 File Offset: 0x000006B5
		internal bool Error { get; set; }

		// Token: 0x04000010 RID: 16
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000011 RID: 17
		[CompilerGenerated]
		private bool bool_0;
	}
}
