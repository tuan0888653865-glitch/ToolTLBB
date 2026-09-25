using System;

namespace ns0
{
	// Token: 0x02000018 RID: 24
	internal static class Class12
	{
		// Token: 0x060000A5 RID: 165 RVA: 0x000026EB File Offset: 0x000008EB
		internal static string smethod_0(byte[] byte_0)
		{
			return Convert.ToBase64String(byte_0).Replace("+", "-").Replace("/", "_");
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002711 File Offset: 0x00000911
		internal static byte[] smethod_1(string string_0)
		{
			return Convert.FromBase64String(string_0.Replace("-", "+").Replace("_", "/"));
		}
	}
}
