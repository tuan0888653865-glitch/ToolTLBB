using System;

namespace ns0
{
	// Token: 0x02000034 RID: 52
	internal sealed class Class39
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000164 RID: 356 RVA: 0x000199D0 File Offset: 0x00017BD0
		internal string String_0
		{
			get
			{
				string text = this.double_0.ToString("0.0");
				if (text.Contains(".0"))
				{
					return this.double_0.ToString("0");
				}
				return text;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00019A10 File Offset: 0x00017C10
		internal string String_1
		{
			get
			{
				string str = "nhân vật";
				if (this.string_2 == "party")
				{
					str = "party";
				}
				return this.int_1.ToString() + " " + str;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00019A54 File Offset: 0x00017C54
		internal string String_2
		{
			get
			{
				string text = this.double_0.ToString("0.0") + " GG";
				if (text.Contains(".0"))
				{
					text = this.double_0.ToString("0") + " GG";
				}
				string text2 = Class83.smethod_31(this.string_0, true);
				string text3;
				if (this.string_1 == "day" && this.int_0 == 30)
				{
					text3 = "1 tháng";
				}
				else if (this.string_1 == "day" && this.int_0 == 90)
				{
					text3 = "3 tháng";
				}
				else if (this.string_1 == "day" && this.int_0 == 180)
				{
					text3 = "6 tháng";
				}
				else if (this.string_1 == "day" && this.int_0 == 365)
				{
					text3 = "1 năm";
				}
				else if (this.string_1 == "day" && (this.int_0 == 9999 || this.int_0 == 1095))
				{
					text3 = "3 năm";
				}
				else
				{
					text3 = this.int_0.ToString("0") + " ngày";
				}
				if (this.string_1 == "hour")
				{
					text3 = this.int_0.ToString() + " giờ";
				}
				string result;
				if (this.string_0 == "time")
				{
					result = string.Format("{0} -- {1}", text3, text);
				}
				else
				{
					string text4;
					if (this.string_2 == "party")
					{
						text4 = this.int_1.ToString() + " pt";
					}
					else if (this.string_2 == "player")
					{
						text4 = this.int_1.ToString() + " nv";
					}
					else
					{
						text4 = this.int_1.ToString() + " unit";
					}
					if (this.int_1 > 0)
					{
						result = string.Format("{0}, {1} {2} -- {3:n1}", new object[]
						{
							text2,
							text3,
							text4,
							text
						});
					}
					else
					{
						result = string.Format("{0} {1:n1}", this.string_3, text);
					}
				}
				return result;
			}
		}

		// Token: 0x04000099 RID: 153
		internal string string_0 = "time";

		// Token: 0x0400009A RID: 154
		internal int int_0 = 1;

		// Token: 0x0400009B RID: 155
		internal string string_1 = "day";

		// Token: 0x0400009C RID: 156
		internal int int_1 = 99;

		// Token: 0x0400009D RID: 157
		internal string string_2 = "player";

		// Token: 0x0400009E RID: 158
		internal double double_0;

		// Token: 0x0400009F RID: 159
		internal string string_3 = "";

		// Token: 0x040000A0 RID: 160
		internal string string_4 = "";
	}
}
