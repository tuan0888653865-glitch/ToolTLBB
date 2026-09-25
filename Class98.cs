using System;

namespace ns0
{
	// Token: 0x02000085 RID: 133
	internal sealed class Class98
	{
		// Token: 0x06000475 RID: 1141 RVA: 0x000048BF File Offset: 0x00002ABF
		internal Class98(Class59 class59_1)
		{
			this.class59_0 = class59_1;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x000047AC File Offset: 0x000029AC
		private bool method_0()
		{
			return true;
		}

		// Token: 0x17000059 RID: 89
		internal unsafe Class158 this[int int_1]
		{
			get
			{
				Class158 @class = new Class158();
				bool flag = true;
				if ((IntPtr)((void*)this.class59_0.pByte_9) != IntPtr.Zero && int_1 < frmLogin.class101_0.globalSettings_0.RingQuaiSize)
				{
					int num = this.int_0 * int_1;
					@class.int_0 = Class208.smethod_2(this.class59_0.pByte_9, num);
					@class.int_7 = Class208.smethod_2(this.class59_0.pByte_9, num + 44);
					if (this.class59_0.class58_0 != null && this.class59_0.class58_0.class118_0.list_1.Count > 0)
					{
						for (int i = this.class59_0.class58_0.class118_0.list_1.Count - 1; i >= 0; i--)
						{
							Class119 class2 = this.class59_0.class58_0.class118_0.list_1[i];
							if (class2.int_0 == @class.int_7 && class2.int_0 != -1 && class2.int_5 > 0)
							{
								flag = false;
								break;
							}
						}
					}
					@class.float_0 = Class208.smethod_6(this.class59_0.pByte_9, num + 4);
					@class.float_1 = Class208.smethod_6(this.class59_0.pByte_9, num + 8);
					@class.float_2 = Class208.smethod_6(this.class59_0.pByte_9, num + 12);
					@class.int_3 = Class208.smethod_2(this.class59_0.pByte_9, num + 28);
					if (flag)
					{
						@class.int_5 = Class208.smethod_2(this.class59_0.pByte_9, num + 36);
						@class.int_6 = Class208.smethod_2(this.class59_0.pByte_9, num + 40);
						@class.int_8 = Class208.smethod_2(this.class59_0.pByte_9, num + 48);
						@class.int_10 = Class208.smethod_2(this.class59_0.pByte_9, num + 56);
						@class.byte_0 = this.class59_0.pByte_9[num + 94];
					}
				}
				return @class;
			}
		}

		// Token: 0x0400030D RID: 781
		private int int_0 = 1138;

		// Token: 0x0400030E RID: 782
		private Class59 class59_0;
	}
}
