using System;

namespace ns0
{
	// Token: 0x02000084 RID: 132
	internal sealed class Class97
	{
		// Token: 0x06000472 RID: 1138 RVA: 0x000048A5 File Offset: 0x00002AA5
		internal Class97(Class59 class59_1)
		{
			this.class59_0 = class59_1;
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x000047AC File Offset: 0x000029AC
		private bool method_0()
		{
			return true;
		}

		// Token: 0x17000058 RID: 88
		internal unsafe Class158 this[int int_1]
		{
			get
			{
				Class158 @class = new Class158();
				bool flag = true;
				if ((IntPtr)((void*)this.class59_0.pByte_10) != IntPtr.Zero && int_1 < frmLogin.class101_0.globalSettings_0.RingNguoiSize)
				{
					int num = this.int_0 * int_1;
					@class.int_0 = Class208.smethod_2(this.class59_0.pByte_10, num);
					@class.int_6 = Class208.smethod_2(this.class59_0.pByte_10, num + 40);
					if (this.class59_0.class58_0 != null && this.class59_0.class58_0.class92_0.list_0.Count > 0)
					{
						int i = this.class59_0.class58_0.class92_0.list_0.Count - 1;
						while (i >= 0)
						{
							Class93 class2 = this.class59_0.class58_0.class92_0.list_0[i];
							if (class2.int_2 != @class.int_6 || class2.int_2 <= 0)
							{
								i--;
							}
							else
							{
								if (class2.int_7 > 0 && class2.int_1 >= 0 && class2.string_0 != "")
								{
									flag = false;
									break;
								}
								break;
							}
						}
					}
					@class.float_0 = Class208.smethod_6(this.class59_0.pByte_10, num + 4);
					@class.float_1 = Class208.smethod_6(this.class59_0.pByte_10, num + 8);
					@class.int_4 = Class208.smethod_2(this.class59_0.pByte_10, num + 32);
					@class.int_1 = Class208.smethod_2(this.class59_0.pByte_10, num + 20);
					@class.int_2 = Class208.smethod_2(this.class59_0.pByte_10, num + 24);
					if (flag)
					{
						@class.int_3 = Class208.smethod_2(this.class59_0.pByte_10, num + 28);
						@class.int_8 = Class208.smethod_2(this.class59_0.pByte_10, num + 48);
						@class.int_9 = Class208.smethod_2(this.class59_0.pByte_10, num + 52);
						@class.byte_0 = this.class59_0.pByte_10[num + 94];
					}
				}
				return @class;
			}
		}

		// Token: 0x0400030B RID: 779
		private int int_0 = 1138;

		// Token: 0x0400030C RID: 780
		private Class59 class59_0;
	}
}
