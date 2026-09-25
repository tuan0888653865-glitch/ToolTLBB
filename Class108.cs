using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ns0
{
	// Token: 0x02000091 RID: 145
	internal sealed class Class108
	{
		// Token: 0x060006C1 RID: 1729 RVA: 0x00095C8C File Offset: 0x00093E8C
		internal Class108()
		{
			this.list_4 = new List<Class109>();
			for (int i = 0; i < 50; i++)
			{
				this.list_0.Add(new Class109());
			}
			this.stopwatch_0.Start();
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x000081F1 File Offset: 0x000063F1
		internal void method_0(Class59 class59_1)
		{
			this.class59_0 = class59_1;
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x000047AC File Offset: 0x000029AC
		private bool method_1()
		{
			return true;
		}

		// Token: 0x04000484 RID: 1156
		private int int_0 = 28;

		// Token: 0x04000485 RID: 1157
		private Class59 class59_0;

		// Token: 0x04000486 RID: 1158
		internal List<Class109> list_0 = new List<Class109>();

		// Token: 0x04000487 RID: 1159
		internal List<Class109> list_1 = new List<Class109>();

		// Token: 0x04000488 RID: 1160
		internal int int_1;

		// Token: 0x04000489 RID: 1161
		internal List<int> list_2 = new List<int>
		{
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0
		};

		// Token: 0x0400048A RID: 1162
		internal int int_2;

		// Token: 0x0400048B RID: 1163
		internal long long_0;

		// Token: 0x0400048C RID: 1164
		internal bool bool_0;

		// Token: 0x0400048D RID: 1165
		internal Stopwatch stopwatch_0 = new Stopwatch();

		// Token: 0x0400048E RID: 1166
		internal long long_1;

		// Token: 0x0400048F RID: 1167
		internal List<Class111> list_3 = new List<Class111>();

		// Token: 0x04000490 RID: 1168
		internal int int_3;

		// Token: 0x04000491 RID: 1169
		internal float float_0;

		// Token: 0x04000492 RID: 1170
		internal float float_1;

		// Token: 0x04000493 RID: 1171
		internal List<Class109> list_4;
	}
}
