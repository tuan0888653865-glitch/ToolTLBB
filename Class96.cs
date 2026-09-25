using System;

namespace ns0
{
	// Token: 0x02000083 RID: 131
	internal sealed class Class96
	{
		// Token: 0x0600046F RID: 1135 RVA: 0x0000486F File Offset: 0x00002A6F
		internal Class96(Class59 class59_1)
		{
			this.class59_0 = class59_1;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00004889 File Offset: 0x00002A89
		private unsafe bool method_0()
		{
			return (IntPtr)((void*)this.class59_0.pByte_12) != IntPtr.Zero;
		}

		// Token: 0x17000057 RID: 87
		internal unsafe Class158 this[int int_1]
		{
			get
			{
				Class158 @class = new Class158();
				if (this.method_0() && int_1 < frmLogin.class101_0.globalSettings_0.RingMsgSize)
				{
					int num = this.int_0 * int_1;
					@class.int_0 = Class208.smethod_2(this.class59_0.pByte_12, num);
					@class.float_0 = Class208.smethod_6(this.class59_0.pByte_12, num + 4);
					@class.float_1 = Class208.smethod_6(this.class59_0.pByte_12, num + 8);
					@class.float_2 = Class208.smethod_6(this.class59_0.pByte_12, num + 12);
					@class.float_3 = Class208.smethod_6(this.class59_0.pByte_12, num + 16);
					@class.int_1 = Class208.smethod_2(this.class59_0.pByte_12, num + 20);
					@class.int_2 = Class208.smethod_2(this.class59_0.pByte_12, num + 24);
					@class.int_3 = Class208.smethod_2(this.class59_0.pByte_12, num + 28);
					@class.int_4 = Class208.smethod_2(this.class59_0.pByte_12, num + 32);
					@class.int_5 = Class208.smethod_2(this.class59_0.pByte_12, num + 36);
					@class.int_6 = Class208.smethod_2(this.class59_0.pByte_12, num + 40);
					@class.int_7 = Class208.smethod_2(this.class59_0.pByte_12, num + 44);
					@class.int_8 = Class208.smethod_2(this.class59_0.pByte_12, num + 48);
					@class.int_9 = Class208.smethod_2(this.class59_0.pByte_12, num + 52);
					@class.int_10 = Class208.smethod_2(this.class59_0.pByte_12, num + 56);
					@class.double_0 = Class208.smethod_4(this.class59_0.pByte_12, num + 60);
					@class.double_1 = Class208.smethod_4(this.class59_0.pByte_12, num + 68);
					@class.double_2 = Class208.smethod_4(this.class59_0.pByte_12, num + 76);
					@class.double_3 = Class208.smethod_4(this.class59_0.pByte_12, num + 84);
					if (this.class59_0.pByte_12[num + 92] == 1)
					{
						@class.bool_0 = true;
					}
					else
					{
						@class.bool_0 = false;
					}
					if (this.class59_0.pByte_12[num + 93] == 1)
					{
						@class.bool_1 = true;
					}
					else
					{
						@class.bool_1 = false;
					}
					@class.byte_0 = this.class59_0.pByte_12[num + 94];
					@class.byte_1 = this.class59_0.pByte_12[num + 95];
					@class.byte_2 = this.class59_0.pByte_12[num + 96];
					@class.byte_3 = this.class59_0.pByte_12[num + 97];
					byte[] array = new byte[512];
					bool flag = false;
					int num2 = 0;
					while (!flag)
					{
						if (this.class59_0.pByte_12[num + num2 + 98] != 0)
						{
							array[num2] = this.class59_0.pByte_12[num + num2 + 98];
						}
						if (this.class59_0.pByte_12[num + num2 + 98] == 0 || num2 >= 511)
						{
							flag = true;
						}
						num2++;
					}
					@class.string_0 = Class83.smethod_142(array, 0, num2 - 1);
					@class.string_2 = Class83.smethod_54(array);
					if (num2 > 1)
					{
						@class.string_2 = @class.string_2.Substring(0, (num2 - 1 - 1) * 3 + 2);
					}
					Array.Clear(array, 0, array.Length);
					flag = false;
					num2 = 0;
					while (!flag)
					{
						if (this.class59_0.pByte_12[num + num2 + 610] != 0)
						{
							array[num2] = this.class59_0.pByte_12[num + num2 + 610];
						}
						if (this.class59_0.pByte_12[num + num2 + 610] == 0 || num2 >= 511)
						{
							flag = true;
						}
						num2++;
					}
					@class.string_1 = Class83.smethod_142(array, 0, num2 - 1);
					@class.long_0 = Class208.smethod_3(this.class59_0.pByte_12, num + 1122);
					@class.long_1 = Class208.smethod_3(this.class59_0.pByte_12, num + 1130);
					if (@class.string_0.Length > 2 || @class.string_1.Length > 2)
					{
						Class83.smethod_142(array, 0, num2 - 1);
					}
				}
				return @class;
			}
		}

		// Token: 0x04000309 RID: 777
		private int int_0 = 1138;

		// Token: 0x0400030A RID: 778
		private Class59 class59_0;
	}
}
