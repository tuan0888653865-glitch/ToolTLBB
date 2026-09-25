using System;
using System.Collections.Generic;

namespace ns0
{
	// Token: 0x0200007D RID: 125
	internal sealed class Class90
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x00004715 File Offset: 0x00002915
		internal bool Boolean_0
		{
			get
			{
				return this.class100_0 != null;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00004722 File Offset: 0x00002922
		internal bool Boolean_1
		{
			get
			{
				return this.class89_1 != null && this.int_0 < this.class89_1.Int32_0;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x00004742 File Offset: 0x00002942
		internal bool Boolean_2
		{
			get
			{
				return this.class89_1 != null && this.int_0 < this.class89_1.Int32_0 - 1;
			}
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00004764 File Offset: 0x00002964
		internal void method_0()
		{
			this.int_1 = 0;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0000476D File Offset: 0x0000296D
		internal void method_1()
		{
			this.bool_0 = true;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00004776 File Offset: 0x00002976
		internal void method_2()
		{
			this.bool_0 = false;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0007C318 File Offset: 0x0007A518
		internal void method_3()
		{
			this.int_0 = 0;
			if (this.class89_1 != null)
			{
				for (int i = 0; i < this.class89_1.Int32_0; i++)
				{
					this.class89_1.list_0[i].enum2_0 = Class57.Enum2.const_0;
					this.class89_1.list_0[i].enum2_1 = Class57.Enum2.const_0;
				}
			}
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0007C378 File Offset: 0x0007A578
		internal Class100 method_4()
		{
			Class100 result = null;
			if (this.class89_1 != null && this.int_0 < this.class89_1.Int32_0)
			{
				result = this.class89_1.list_0[this.int_0];
			}
			return result;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0000477F File Offset: 0x0000297F
		internal void method_5()
		{
			this.int_0++;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0007C3BC File Offset: 0x0007A5BC
		internal void method_6()
		{
			for (int i = 0; i < this.class89_1.Int32_0; i++)
			{
				this.class89_1.list_0[i].enum2_0 = Class57.Enum2.const_0;
				this.class89_1.list_0[i].enum2_1 = Class57.Enum2.const_0;
			}
			this.int_0 = 0;
			this.int_1++;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0007C424 File Offset: 0x0007A624
		internal static void smethod_0(string string_0, Class100 class100_3)
		{
			if (!string.IsNullOrEmpty(string_0))
			{
				string[] array = string_0.Split(new char[]
				{
					','
				});
				if (array.Length != 0)
				{
					class100_3.string_0 = array[0];
					if (array.Length > 1)
					{
						for (int i = 1; i < array.Length; i++)
						{
							class100_3.list_0.Add(array[i]);
						}
					}
				}
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0007C47C File Offset: 0x0007A67C
		internal static void smethod_1(string string_0, Class89 class89_2)
		{
			if (!string.IsNullOrEmpty(string_0))
			{
				Class100 @class = new Class100();
				string[] array = string_0.Split(new char[]
				{
					','
				});
				if (array.Length != 0)
				{
					@class.string_0 = array[0];
					if (array.Length > 1)
					{
						for (int i = 1; i < array.Length; i++)
						{
							@class.list_0.Add(array[i]);
						}
					}
					class89_2.list_0.Add(@class);
				}
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0000478F File Offset: 0x0000298F
		internal void method_7()
		{
			this.method_0();
			this.method_3();
			this.method_1();
		}

		// Token: 0x040002E6 RID: 742
		internal bool bool_0;

		// Token: 0x040002E7 RID: 743
		internal Class89 class89_0;

		// Token: 0x040002E8 RID: 744
		internal Class89 class89_1;

		// Token: 0x040002E9 RID: 745
		internal List<Class89> list_0 = new List<Class89>();

		// Token: 0x040002EA RID: 746
		internal bool bool_1;

		// Token: 0x040002EB RID: 747
		internal Class100 class100_0;

		// Token: 0x040002EC RID: 748
		internal int int_0;

		// Token: 0x040002ED RID: 749
		internal Class100 class100_1;

		// Token: 0x040002EE RID: 750
		internal Class100 class100_2;

		// Token: 0x040002EF RID: 751
		internal int int_1;
	}
}
