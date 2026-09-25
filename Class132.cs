using System;

namespace ns0
{
	// Token: 0x020000AB RID: 171
	internal sealed class Class132
	{
		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x00099D74 File Offset: 0x00097F74
		internal string String_0
		{
			get
			{
				string text = this.string_0.Replace("http://", "").Replace(".gameauto.net/", "");
				if (text == "www")
				{
					text = "GAuto";
				}
				return text;
			}
		}

		// Token: 0x04000921 RID: 2337
		internal string string_0 = "";

		// Token: 0x04000922 RID: 2338
		internal int int_0 = 100;

		// Token: 0x04000923 RID: 2339
		internal bool bool_0;

		// Token: 0x04000924 RID: 2340
		internal bool bool_1;
	}
}
