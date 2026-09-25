using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns0
{
	// Token: 0x02000138 RID: 312
	[CompilerGenerated]
	internal sealed class Class213
	{
		// Token: 0x060012BD RID: 4797 RVA: 0x0011A8E8 File Offset: 0x00118AE8
		internal static uint smethod_0(string string_0)
		{
			uint num;
			if (string_0 != null)
			{
				num = 2166136261U;
				for (int i = 0; i < string_0.Length; i++)
				{
					num = ((uint)string_0[i] ^ num) * 16777619U;
				}
			}
			return num;
		}

		// Token: 0x04001393 RID: 5011 RVA: 0x000020D0 File Offset: 0x000002D0
		internal static readonly Class213.Struct13 struct13_0;

		// Token: 0x04001394 RID: 5012 RVA: 0x000020E0 File Offset: 0x000002E0
		internal static readonly Class213.Struct12 struct12_0;

		// Token: 0x04001395 RID: 5013 RVA: 0x000020F0 File Offset: 0x000002F0
		internal static readonly Class213.Struct10 struct10_0;

		// Token: 0x04001396 RID: 5014 RVA: 0x00002100 File Offset: 0x00000300
		internal static readonly Class213.Struct9 struct9_0;

		// Token: 0x04001397 RID: 5015 RVA: 0x00002108 File Offset: 0x00000308
		internal static readonly Class213.Struct13 struct13_1;

		// Token: 0x04001398 RID: 5016 RVA: 0x00002118 File Offset: 0x00000318
		internal static readonly Class213.Struct15 struct15_0;

		// Token: 0x04001399 RID: 5017 RVA: 0x00002130 File Offset: 0x00000330
		internal static readonly Class213.Struct9 struct9_1;

		// Token: 0x0400139A RID: 5018 RVA: 0x00002138 File Offset: 0x00000338
		internal static readonly Class213.Struct16 struct16_0;

		// Token: 0x0400139B RID: 5019 RVA: 0x00002390 File Offset: 0x00000590
		internal static readonly Class213.Struct14 struct14_0;

		// Token: 0x0400139C RID: 5020 RVA: 0x000023A0 File Offset: 0x000005A0
		internal static readonly Class213.Struct11 struct11_0;

		// Token: 0x02000139 RID: 313
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 6)]
		private struct Struct9
		{
		}

		// Token: 0x0200013A RID: 314
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 10)]
		private struct Struct10
		{
		}

		// Token: 0x0200013B RID: 315
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 11)]
		private struct Struct11
		{
		}

		// Token: 0x0200013C RID: 316
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 12)]
		private struct Struct12
		{
		}

		// Token: 0x0200013D RID: 317
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 14)]
		private struct Struct13
		{
		}

		// Token: 0x0200013E RID: 318
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
		private struct Struct14
		{
		}

		// Token: 0x0200013F RID: 319
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 20)]
		private struct Struct15
		{
		}

		// Token: 0x02000140 RID: 320
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 600)]
		private struct Struct16
		{
		}
	}
}
