using System;

namespace ns0
{
	// Token: 0x02000081 RID: 129
	internal sealed class Class94
	{
		// Token: 0x06000469 RID: 1129 RVA: 0x00004803 File Offset: 0x00002A03
		internal Class94(Class59 class59_1)
		{
			this.class59_0 = class59_1;
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0000481D File Offset: 0x00002A1D
		private unsafe bool method_0()
		{
			return (IntPtr)((void*)this.class59_0.pByte_11) != IntPtr.Zero;
		}

		// Token: 0x17000055 RID: 85
		internal unsafe Class158 this[int int_1]
		{
			get
			{
				Class158 @class = new Class158();
				if (this.method_0() && int_1 < frmLogin.class101_0.globalSettings_0.RingBocSize)
				{
					int num = this.int_0 * int_1;
					@class.int_0 = Class208.smethod_2(this.class59_0.pByte_11, num);
					@class.float_0 = Class208.smethod_6(this.class59_0.pByte_11, num + 4);
					@class.float_1 = Class208.smethod_6(this.class59_0.pByte_11, num + 8);
					@class.float_2 = Class208.smethod_6(this.class59_0.pByte_11, num + 12);
					@class.float_3 = Class208.smethod_6(this.class59_0.pByte_11, num + 16);
					@class.int_1 = Class208.smethod_2(this.class59_0.pByte_11, num + 20);
					@class.int_2 = Class208.smethod_2(this.class59_0.pByte_11, num + 24);
					@class.int_3 = Class208.smethod_2(this.class59_0.pByte_11, num + 28);
					@class.int_4 = Class208.smethod_2(this.class59_0.pByte_11, num + 32);
					@class.int_5 = Class208.smethod_2(this.class59_0.pByte_11, num + 36);
					@class.int_6 = Class208.smethod_2(this.class59_0.pByte_11, num + 40);
					@class.int_7 = Class208.smethod_2(this.class59_0.pByte_11, num + 44);
					@class.int_8 = Class208.smethod_2(this.class59_0.pByte_11, num + 48);
					@class.int_9 = Class208.smethod_2(this.class59_0.pByte_11, num + 52);
					@class.int_10 = Class208.smethod_2(this.class59_0.pByte_11, num + 56);
					@class.double_0 = Class208.smethod_4(this.class59_0.pByte_11, num + 60);
					@class.double_1 = Class208.smethod_4(this.class59_0.pByte_11, num + 68);
					@class.double_2 = Class208.smethod_4(this.class59_0.pByte_11, num + 76);
					@class.double_3 = Class208.smethod_4(this.class59_0.pByte_11, num + 84);
					if (this.class59_0.pByte_11[num + 92] == 1)
					{
						@class.bool_0 = true;
					}
					else
					{
						@class.bool_0 = false;
					}
					if (this.class59_0.pByte_11[num + 93] == 1)
					{
						@class.bool_1 = true;
					}
					else
					{
						@class.bool_1 = false;
					}
					@class.byte_0 = this.class59_0.pByte_11[num + 94];
					@class.byte_1 = this.class59_0.pByte_11[num + 95];
					@class.byte_2 = this.class59_0.pByte_11[num + 96];
					@class.byte_3 = this.class59_0.pByte_11[num + 97];
					@class.long_0 = Class208.smethod_3(this.class59_0.pByte_11, num + 1122);
					@class.long_1 = Class208.smethod_3(this.class59_0.pByte_11, num + 1130);
				}
				return @class;
			}
		}

		// Token: 0x04000305 RID: 773
		private int int_0 = 1138;

		// Token: 0x04000306 RID: 774
		private Class59 class59_0;
	}
}
