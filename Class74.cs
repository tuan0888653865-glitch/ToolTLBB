using System;

namespace ns0
{
	// Token: 0x0200006B RID: 107
	internal sealed class Class74
	{
		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000392 RID: 914 RVA: 0x0006C9D0 File Offset: 0x0006ABD0
		internal string String_0
		{
			get
			{
				if (this.string_3 == "chedo")
				{
					if (frmLogin.string_0 == "VN")
					{
						return "Chế đồ";
					}
					if (frmLogin.string_0 == "EN")
					{
						return "Crafting";
					}
					return "Chế đồ CN";
				}
				else if (this.string_3 == "yto")
				{
					if (frmLogin.string_0 == "VN")
					{
						return "Yến Tử Ổ";
					}
					if (frmLogin.string_0 == "EN")
					{
						return "Shallow Deck";
					}
					return "Yến Tử Ổ CN";
				}
				else
				{
					if (!(this.string_3 == "trader"))
					{
						return "Chưa rõ";
					}
					if (frmLogin.string_0 == "VN")
					{
						return "Thương Nhân";
					}
					if (frmLogin.string_0 == "EN")
					{
						return "Trader";
					}
					return "Thương Nhân CN";
				}
			}
		}

		// Token: 0x040001EE RID: 494
		internal bool bool_0 = true;

		// Token: 0x040001EF RID: 495
		internal string string_0 = "-1";

		// Token: 0x040001F0 RID: 496
		internal string string_1 = "hour";

		// Token: 0x040001F1 RID: 497
		internal string string_2 = "player";

		// Token: 0x040001F2 RID: 498
		internal int int_0;

		// Token: 0x040001F3 RID: 499
		internal string string_3 = "";

		// Token: 0x040001F4 RID: 500
		internal string string_4 = "";

		// Token: 0x040001F5 RID: 501
		internal DateTime dateTime_0 = DateTime.MinValue;

		// Token: 0x040001F6 RID: 502
		internal long long_0;
	}
}
