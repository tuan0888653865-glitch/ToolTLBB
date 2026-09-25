using System;
using System.Collections.Generic;

namespace ns0
{
	// Token: 0x0200007C RID: 124
	internal sealed class Class89
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x000046CA File Offset: 0x000028CA
		internal bool Boolean_0
		{
			get
			{
				return this.dictionary_0.Count > 0 || this.list_0.Count > 0;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x000046EB File Offset: 0x000028EB
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

		// Token: 0x06000451 RID: 1105 RVA: 0x0007C2D4 File Offset: 0x0007A4D4
		internal object method_0(string string_2)
		{
			object result = null;
			if (this.dictionary_0.Count > 0 && this.dictionary_0.ContainsKey(string_2.ToLower()))
			{
				result = this.dictionary_0[string_2.ToLower()];
			}
			return result;
		}

		// Token: 0x040002DE RID: 734
		internal Dictionary<string, object> dictionary_0 = new Dictionary<string, object>();

		// Token: 0x040002DF RID: 735
		internal string string_0 = "GAuto Team";

		// Token: 0x040002E0 RID: 736
		internal DateTime dateTime_0 = DateTime.Now;

		// Token: 0x040002E1 RID: 737
		internal string string_1 = "http://www.gameauto.net";

		// Token: 0x040002E2 RID: 738
		internal List<Class100> list_0 = new List<Class100>();

		// Token: 0x040002E3 RID: 739
		internal List<Class100> list_1 = new List<Class100>();

		// Token: 0x040002E4 RID: 740
		internal List<string> list_2 = new List<string>();

		// Token: 0x040002E5 RID: 741
		internal Class57.Enum2 enum2_0;
	}
}
