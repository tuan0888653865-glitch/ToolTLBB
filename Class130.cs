using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x020000A9 RID: 169
	internal sealed class Class130
	{
		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x000093D0 File Offset: 0x000075D0
		[JsonIgnore]
		internal bool Boolean_0
		{
			get
			{
				return this.bool_0 || this.bool_1 || this.bool_2 || this.bool_3;
			}
		}

		// Token: 0x04000918 RID: 2328
		[JsonProperty("_hasVS")]
		internal bool bool_0;

		// Token: 0x04000919 RID: 2329
		[JsonProperty("_hasCE")]
		internal bool bool_1;

		// Token: 0x0400091A RID: 2330
		[JsonProperty("_hasOlly")]
		internal bool bool_2;

		// Token: 0x0400091B RID: 2331
		[JsonProperty("_isVM")]
		internal bool bool_3;

		// Token: 0x0400091C RID: 2332
		[JsonProperty("_itsdata")]
		internal Dictionary<string, object> dictionary_0 = new Dictionary<string, object>();

		// Token: 0x0400091D RID: 2333
		internal bool bool_4;
	}
}
