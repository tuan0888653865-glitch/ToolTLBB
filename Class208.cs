using System;
using System.Text;

namespace ns0
{
	// Token: 0x02000130 RID: 304
	internal sealed class Class208
	{
		// Token: 0x0600126C RID: 4716 RVA: 0x00016664 File Offset: 0x00014864
		internal unsafe static short smethod_0(byte* pByte_0, int int_0)
		{
			return (short)((int)pByte_0[int_0] | (int)pByte_0[int_0 + 1] << 8);
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x00016674 File Offset: 0x00014874
		internal unsafe static ushort smethod_1(byte* pByte_0, int int_0)
		{
			return (ushort)((int)pByte_0[int_0] | (int)pByte_0[int_0 + 1] << 8);
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x00016684 File Offset: 0x00014884
		internal unsafe static int smethod_2(byte* pByte_0, int int_0)
		{
			return (int)pByte_0[int_0] | (int)pByte_0[int_0 + 1] << 8 | (int)pByte_0[int_0 + 2] << 16 | (int)pByte_0[int_0 + 3] << 24;
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x0011A028 File Offset: 0x00118228
		internal unsafe static long smethod_3(byte* pByte_0, int int_0)
		{
			byte[] array = new byte[8];
			for (int i = int_0; i < int_0 + 8; i++)
			{
				array[i - int_0] = pByte_0[i];
			}
			return BitConverter.ToInt64(array, 0);
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x0011A05C File Offset: 0x0011825C
		internal unsafe static double smethod_4(byte* pByte_0, int int_0)
		{
			byte[] array = new byte[8];
			for (int i = int_0; i < int_0 + 8; i++)
			{
				array[i - int_0] = pByte_0[i];
			}
			return BitConverter.ToDouble(array, 0);
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x000166A7 File Offset: 0x000148A7
		internal unsafe static float smethod_5(byte* pByte_0, int int_0)
		{
			return Class208.smethod_6(pByte_0, int_0);
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x0011A090 File Offset: 0x00118290
		internal unsafe static float smethod_6(byte* pByte_0, int int_0)
		{
			try
			{
				byte[] array = new byte[4];
				for (int i = int_0; i < int_0 + 4; i++)
				{
					array[i - int_0] = pByte_0[i];
				}
				return BitConverter.ToSingle(array, 0);
			}
			catch (Exception)
			{
			}
			return 0f;
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x0011A0E0 File Offset: 0x001182E0
		internal unsafe static string smethod_7(byte* pByte_0)
		{
			byte[] array = new byte[10];
			for (int i = 0; i < 10; i++)
			{
				array[i] = pByte_0[i];
			}
			if (frmLogin.string_0 == "CN")
			{
				return Encoding.GetEncoding("gb2312").GetString(array);
			}
			return Encoding.UTF7.GetString(array);
		}
	}
}
