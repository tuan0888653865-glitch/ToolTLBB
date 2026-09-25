using System;

namespace ns0
{
	// Token: 0x02000093 RID: 147
	internal sealed class Class110
	{
		// Token: 0x060006C7 RID: 1735 RVA: 0x00008223 File Offset: 0x00006423
		internal Class110()
		{
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00008233 File Offset: 0x00006433
		internal void method_0(Class59 class59_1)
		{
			this.class59_0 = class59_1;
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x000047AC File Offset: 0x000029AC
		private bool method_1()
		{
			return true;
		}

		// Token: 0x1700014F RID: 335
		internal unsafe Class111 this[int int_1]
		{
			get
			{
				Class111 @class = new Class111();
				if (this.method_1())
				{
					int num = 24 + this.int_0 * int_1;
					@class.int_0 = Class208.smethod_2(this.class59_0.pByte_4, num);
					@class.int_1 = Class208.smethod_2(this.class59_0.pByte_4, num + 4);
					@class.int_2 = Class208.smethod_2(this.class59_0.pByte_4, num + 8);
					if (this.class59_0.pByte_4[num + 12] == 0)
					{
						@class.bool_0 = false;
					}
					else
					{
						@class.bool_0 = true;
					}
				}
				return @class;
			}
		}

		// Token: 0x0400049E RID: 1182
		private int int_0 = 13;

		// Token: 0x0400049F RID: 1183
		private Class59 class59_0;
	}
}
