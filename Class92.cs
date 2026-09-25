using System;
using System.Collections.Generic;

namespace ns0
{
	// Token: 0x0200007F RID: 127
	internal sealed class Class92
	{
		// Token: 0x06000464 RID: 1124 RVA: 0x000047AF File Offset: 0x000029AF
		internal Class92()
		{
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x000047CA File Offset: 0x000029CA
		internal void method_0(Class59 class59_1)
		{
			this.class59_0 = class59_1;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x000047AC File Offset: 0x000029AC
		private bool method_1()
		{
			return true;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0007C56C File Offset: 0x0007A76C
		internal Class119 method_2(int int_1, bool bool_0 = false)
		{
			if (this.list_0.Count > 0)
			{
				try
				{
					int i = this.list_0.Count - 1;
					while (i >= 0)
					{
						Class93 @class = this.list_0[i];
						if (@class.int_0 == int_1)
						{
							Class119 class2 = new Class119();
							class2.int_0 = @class.int_0;
							class2.float_4 = @class.float_0;
							class2.float_0 = @class.float_2;
							class2.float_1 = @class.float_3;
							class2.int_9 = @class.int_4;
							if (bool_0 && @class.float_0 <= 0f)
							{
								return null;
							}
							return class2;
						}
						else
						{
							i--;
						}
					}
					goto IL_A2;
				}
				catch (Exception)
				{
					goto IL_A2;
				}
				Class119 result;
				return result;
			}
			IL_A2:
			return null;
		}

		// Token: 0x040002F3 RID: 755
		private int int_0 = 82;

		// Token: 0x040002F4 RID: 756
		private Class59 class59_0;

		// Token: 0x040002F5 RID: 757
		internal List<Class93> list_0 = new List<Class93>();
	}
}
