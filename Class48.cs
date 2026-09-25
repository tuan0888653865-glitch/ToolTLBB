using System;
using System.Collections.Generic;

namespace ns0
{
	// Token: 0x0200003D RID: 61
	internal sealed class Class48
	{
		// Token: 0x06000188 RID: 392 RVA: 0x00003263 File Offset: 0x00001463
		internal Class48(Class114 class114_1)
		{
			this.class114_0 = class114_1;
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0000327D File Offset: 0x0000147D
		internal int Int32_0
		{
			get
			{
				return this.list_0.Count;
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000328A File Offset: 0x0000148A
		internal void method_0(Class49 class49_0)
		{
			if (this.list_0.Count >= 5)
			{
				this.list_0.RemoveAt(0);
			}
			this.list_0.Add(class49_0);
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0001A158 File Offset: 0x00018358
		internal Class49 Class49_0
		{
			get
			{
				Class49 @class = null;
				if (this.list_0.Count > 0)
				{
					@class = new Class49();
					@class.float_0 = this.list_0[this.list_0.Count - 1].float_0;
					@class.float_1 = this.list_0[this.list_0.Count - 1].float_1;
					@class.long_0 = this.list_0[this.list_0.Count - 1].long_0;
				}
				return @class;
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0001A1E8 File Offset: 0x000183E8
		internal Class49 method_1(double double_0 = 19.0, double double_1 = 0.0)
		{
			Class49 @class = null;
			if (this.list_0.Count >= 2)
			{
				Class49 class2 = this.list_0[this.list_0.Count - 1];
				Class49 class3 = this.list_0[this.list_0.Count - 2];
				@class = new Class49();
				if (class3.float_0 != class2.float_0 || class3.float_1 != class2.float_1)
				{
					double num = Math.Atan((double)((class2.float_1 - class3.float_1) / (class2.float_0 - class3.float_0))) * 180.0 / 3.1415926535897931;
					if (class3.float_0 > class2.float_0 && class3.float_1 > class2.float_1)
					{
						num += 180.0;
					}
					else if (class3.float_0 > class2.float_0 && class3.float_1 < class2.float_1)
					{
						num = 180.0 - num * -1.0;
					}
					double num2 = num + double_1;
					double num3 = Math.Cos(num2 * 3.1415926535897931 / 180.0) * double_0;
					double num4 = Math.Cos((90.0 - num2) * 3.1415926535897931 / 180.0) * double_0;
					@class.float_0 = (float)((double)class2.float_0 + num3);
					@class.float_1 = (float)((double)class2.float_1 + num4);
				}
			}
			return @class;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000032B2 File Offset: 0x000014B2
		internal void method_2()
		{
			this.list_0.Clear();
		}

		// Token: 0x040000F5 RID: 245
		private Class114 class114_0;

		// Token: 0x040000F6 RID: 246
		internal List<Class49> list_0 = new List<Class49>();
	}
}
