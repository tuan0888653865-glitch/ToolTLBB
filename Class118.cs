using System;
using System.Collections.Generic;

namespace ns0
{
	// Token: 0x0200009D RID: 157
	internal sealed class Class118
	{
		// Token: 0x060007A0 RID: 1952 RVA: 0x00099798 File Offset: 0x00097998
		internal Class118()
		{
			this.list_1 = new List<Class119>();
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x000091D5 File Offset: 0x000073D5
		internal void method_0(Class59 class59_1)
		{
			this.class59_0 = class59_1;
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x000091DE File Offset: 0x000073DE
		private unsafe bool method_1()
		{
			return this.class59_0 == null || (IntPtr)((void*)this.class59_0.pByte_3) != IntPtr.Zero;
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060007A3 RID: 1955 RVA: 0x00009204 File Offset: 0x00007404
		internal string String_0
		{
			get
			{
				return Class83.smethod_99(this.int_2, true);
			}
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0009980C File Offset: 0x00097A0C
		internal Class119 method_2(int int_6, bool bool_0 = false)
		{
			if (this.list_1.Count > 0)
			{
				try
				{
					int i = this.list_1.Count - 1;
					while (i >= 0)
					{
						Class119 @class = this.list_1[i];
						if (@class.int_0 == int_6)
						{
							if (!bool_0)
							{
								return @class;
							}
							if (@class.float_4 > 0f)
							{
								return @class;
							}
							return null;
						}
						else
						{
							i--;
						}
					}
					goto IL_61;
				}
				catch (Exception)
				{
					goto IL_61;
				}
				Class119 result;
				return result;
			}
			IL_61:
			return null;
		}

		// Token: 0x04000877 RID: 2167
		private int int_0 = 140;

		// Token: 0x04000878 RID: 2168
		private Class59 class59_0;

		// Token: 0x04000879 RID: 2169
		internal List<int> list_0 = new List<int>
		{
			-1
		};

		// Token: 0x0400087A RID: 2170
		internal int int_1;

		// Token: 0x0400087B RID: 2171
		internal int int_2 = -1;

		// Token: 0x0400087C RID: 2172
		internal int int_3 = -1;

		// Token: 0x0400087D RID: 2173
		internal int int_4;

		// Token: 0x0400087E RID: 2174
		internal float float_0;

		// Token: 0x0400087F RID: 2175
		internal List<Class119> list_1;

		// Token: 0x04000880 RID: 2176
		internal int int_5 = -1;

		// Token: 0x04000881 RID: 2177
		internal long long_0;

		// Token: 0x04000882 RID: 2178
		internal List<string> list_2 = new List<string>();

		// Token: 0x04000883 RID: 2179
		internal List<string> list_3 = new List<string>();

		// Token: 0x04000884 RID: 2180
		internal List<int> list_4 = new List<int>();
	}
}
