using System;
using System.Collections.Generic;

namespace ns0
{
	// Token: 0x0200009F RID: 159
	internal sealed class Class120
	{
		// Token: 0x060007A8 RID: 1960 RVA: 0x0009988C File Offset: 0x00097A8C
		internal Class120()
		{
			for (int i = 0; i < 51; i++)
			{
				this.list_4.Add(new Class124());
			}
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00009261 File Offset: 0x00007461
		internal void method_0(Class59 class59_1)
		{
			this.class59_0 = class59_1;
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x000047AC File Offset: 0x000029AC
		private bool method_1()
		{
			return true;
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00099BA8 File Offset: 0x00097DA8
		internal bool method_2(int int_9)
		{
			if (int_9 > 0 && (long)int_9 < (long)((ulong)-1) && this.list_4.Count > 0)
			{
				for (int i = 0; i < this.list_4.Count; i++)
				{
					if (this.list_4[i].int_0 == int_9)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00099C00 File Offset: 0x00097E00
		internal int method_3(int int_9)
		{
			if (int_9 > 0 && (long)int_9 < (long)((ulong)-1) && this.list_4.Count > 0)
			{
				for (int i = 0; i < this.list_4.Count; i++)
				{
					Class124 @class = this.list_4[i];
					if (@class.int_0 == int_9)
					{
						return @class.int_12;
					}
				}
			}
			return 0;
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00099C60 File Offset: 0x00097E60
		internal void method_4(int int_9, int int_10)
		{
			if (int_9 > 0 && (long)int_9 < (long)((ulong)-1) && this.list_4.Count > 0)
			{
				for (int i = 0; i < this.list_4.Count; i++)
				{
					Class124 @class = this.list_4[i];
					if (@class.int_0 == int_9)
					{
						@class.int_12 = int_10;
					}
				}
			}
		}

		// Token: 0x040008AB RID: 2219
		private Class59 class59_0;

		// Token: 0x040008AC RID: 2220
		internal List<Class123> list_0 = new List<Class123>();

		// Token: 0x040008AD RID: 2221
		internal List<Class121> list_1 = new List<Class121>();

		// Token: 0x040008AE RID: 2222
		internal List<Class122> list_2 = new List<Class122>
		{
			new Class122
			{
				int_1 = 1,
				int_2 = 2
			},
			new Class122
			{
				int_1 = 1,
				int_2 = 3
			},
			new Class122
			{
				int_1 = 2,
				int_2 = 1
			},
			new Class122
			{
				int_1 = 2,
				int_2 = 2
			},
			new Class122
			{
				int_1 = 2,
				int_2 = 3
			},
			new Class122
			{
				int_1 = 2,
				int_2 = 4
			},
			new Class122
			{
				int_1 = 3,
				int_2 = 1
			},
			new Class122
			{
				int_1 = 3,
				int_2 = 2
			},
			new Class122
			{
				int_1 = 3,
				int_2 = 3
			},
			new Class122
			{
				int_1 = 4,
				int_2 = 2
			},
			new Class122
			{
				int_1 = 4,
				int_2 = 3
			},
			new Class122
			{
				int_1 = 4,
				int_2 = 4
			},
			new Class122
			{
				int_1 = 5,
				int_2 = 2
			},
			new Class122
			{
				int_1 = 5,
				int_2 = 3
			},
			new Class122
			{
				int_1 = 5,
				int_2 = 4
			},
			new Class122
			{
				int_1 = 6,
				int_2 = 1
			},
			new Class122
			{
				int_1 = 6,
				int_2 = 2
			},
			new Class122
			{
				int_1 = 6,
				int_2 = 3
			},
			new Class122
			{
				int_1 = 7,
				int_2 = 1
			},
			new Class122
			{
				int_1 = 7,
				int_2 = 2
			},
			new Class122
			{
				int_1 = 7,
				int_2 = 3
			},
			new Class122
			{
				int_1 = 8,
				int_2 = 1
			},
			new Class122
			{
				int_1 = 8,
				int_2 = 2
			},
			new Class122
			{
				int_1 = 99,
				int_2 = 1
			},
			new Class122
			{
				int_1 = 99,
				int_2 = 4
			},
			new Class122
			{
				int_1 = 99,
				int_2 = 5
			},
			new Class122
			{
				int_1 = 99,
				int_2 = 7
			}
		};

		// Token: 0x040008AF RID: 2223
		internal List<int> list_3 = new List<int>();

		// Token: 0x040008B0 RID: 2224
		internal List<Class124> list_4 = new List<Class124>(51);

		// Token: 0x040008B1 RID: 2225
		internal long long_0;

		// Token: 0x040008B2 RID: 2226
		internal int int_0;

		// Token: 0x040008B3 RID: 2227
		internal int int_1;

		// Token: 0x040008B4 RID: 2228
		internal int int_2;

		// Token: 0x040008B5 RID: 2229
		internal int int_3;

		// Token: 0x040008B6 RID: 2230
		internal int int_4;

		// Token: 0x040008B7 RID: 2231
		internal int int_5;

		// Token: 0x040008B8 RID: 2232
		internal int int_6 = 999;

		// Token: 0x040008B9 RID: 2233
		internal int int_7;

		// Token: 0x040008BA RID: 2234
		internal bool bool_0;

		// Token: 0x040008BB RID: 2235
		internal int int_8;
	}
}
