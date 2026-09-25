using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

namespace ns0
{
	// Token: 0x02000023 RID: 35
	internal sealed class Class22
	{
		// Token: 0x060000E3 RID: 227 RVA: 0x00018D24 File Offset: 0x00016F24
		static Class22()
		{
			Class22.int_0 = int.MaxValue;
			Class22.int_1 = int.MinValue;
			Class22.memoryStream_0 = new MemoryStream(0);
			Class22.memoryStream_1 = new MemoryStream(0);
			Class22.object_0 = new object();
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00018D74 File Offset: 0x00016F74
		private static string smethod_0(Assembly assembly_0)
		{
			string text = assembly_0.FullName;
			int num = text.IndexOf(',');
			if (num >= 0)
			{
				text = text.Substring(0, num);
			}
			return text;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00018DA0 File Offset: 0x00016FA0
		private static byte[] smethod_1(Assembly assembly_0)
		{
			try
			{
				string fullName = assembly_0.FullName;
				int num = fullName.IndexOf("PublicKeyToken=");
				if (num < 0)
				{
					num = fullName.IndexOf("publickeytoken=");
				}
				if (num < 0)
				{
					return null;
				}
				num += 15;
				if (fullName[num] != 'n')
				{
					if (fullName[num] != 'N')
					{
						string s = fullName.Substring(num, 16);
						long value = long.Parse(s, NumberStyles.HexNumber);
						byte[] bytes = BitConverter.GetBytes(value);
						Array.Reverse(bytes);
						return bytes;
					}
				}
				return null;
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00018E40 File Offset: 0x00017040
		internal static byte[] smethod_2(Stream stream_0)
		{
			byte[] result;
			lock (Class22.object_0)
			{
				result = Class22.smethod_4(97L, stream_0);
			}
			return result;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00018E84 File Offset: 0x00017084
		internal static byte[] smethod_3(long long_0, Stream stream_0)
		{
			byte[] result;
			try
			{
				result = Class22.smethod_2(stream_0);
			}
			catch (HostProtectionException)
			{
				result = Class22.smethod_4(97L, stream_0);
			}
			return result;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00018EC0 File Offset: 0x000170C0
		internal static byte[] smethod_4(long long_0, Stream stream_0)
		{
			Stream stream = stream_0;
			MemoryStream memoryStream = null;
			for (int i = 1; i < 4; i++)
			{
				stream_0.ReadByte();
			}
			ushort num = (ushort)stream_0.ReadByte();
			num = ~num;
			if ((num & 2) != 0)
			{
				DESCryptoServiceProvider descryptoServiceProvider = new DESCryptoServiceProvider();
				byte[] array = new byte[8];
				stream_0.Read(array, 0, 8);
				descryptoServiceProvider.IV = array;
				byte[] array2 = new byte[8];
				stream_0.Read(array2, 0, 8);
				bool flag = true;
				byte[] array3 = array2;
				for (int j = 0; j < array3.Length; j++)
				{
					if (array3[j] != 0)
					{
						flag = false;
						IL_8B:
						if (flag)
						{
							array2 = Class22.smethod_1(Assembly.GetExecutingAssembly());
						}
						descryptoServiceProvider.Key = array2;
						if (Class22.memoryStream_0 == null)
						{
							if (Class22.int_0 == 2147483647)
							{
								Class22.memoryStream_0.Capacity = (int)stream_0.Length;
							}
							else
							{
								Class22.memoryStream_0.Capacity = Class22.int_0;
							}
						}
						Class22.memoryStream_0.Position = 0L;
						ICryptoTransform cryptoTransform = descryptoServiceProvider.CreateDecryptor();
						int inputBlockSize = cryptoTransform.InputBlockSize;
						int outputBlockSize = cryptoTransform.OutputBlockSize;
						byte[] array4 = new byte[cryptoTransform.OutputBlockSize];
						byte[] array5 = new byte[cryptoTransform.InputBlockSize];
						int num2 = (int)stream_0.Position;
						while ((long)(num2 + inputBlockSize) < stream_0.Length)
						{
							stream_0.Read(array5, 0, inputBlockSize);
							int count = cryptoTransform.TransformBlock(array5, 0, inputBlockSize, array4, 0);
							Class22.memoryStream_0.Write(array4, 0, count);
							num2 += inputBlockSize;
						}
						stream_0.Read(array5, 0, (int)(stream_0.Length - (long)num2));
						byte[] array6 = cryptoTransform.TransformFinalBlock(array5, 0, (int)(stream_0.Length - (long)num2));
						Class22.memoryStream_0.Write(array6, 0, array6.Length);
						stream = Class22.memoryStream_0;
						stream.Position = 0L;
						memoryStream = Class22.memoryStream_0;
						goto IL_1C6;
					}
				}
				goto IL_8B;
			}
			IL_1C6:
			if ((num & 8) != 0)
			{
				if (Class22.memoryStream_1 == null)
				{
					if (Class22.int_1 == -2147483648)
					{
						Class22.memoryStream_1.Capacity = (int)stream.Length * 2;
					}
					else
					{
						Class22.memoryStream_1.Capacity = Class22.int_1;
					}
				}
				Class22.memoryStream_1.Position = 0L;
				DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
				int num3 = 1000;
				byte[] buffer = new byte[1000];
				int num4;
				do
				{
					num4 = deflateStream.Read(buffer, 0, num3);
					if (num4 > 0)
					{
						Class22.memoryStream_1.Write(buffer, 0, num4);
					}
				}
				while (num4 >= num3);
				memoryStream = Class22.memoryStream_1;
			}
			if (memoryStream != null)
			{
				return memoryStream.ToArray();
			}
			byte[] array7 = new byte[stream_0.Length - stream_0.Position];
			stream_0.Read(array7, 0, array7.Length);
			return array7;
		}

		// Token: 0x0400004A RID: 74
		private static readonly object object_0;

		// Token: 0x0400004B RID: 75
		private static readonly int int_0;

		// Token: 0x0400004C RID: 76
		private static readonly int int_1;

		// Token: 0x0400004D RID: 77
		private static readonly MemoryStream memoryStream_0 = null;

		// Token: 0x0400004E RID: 78
		private static readonly MemoryStream memoryStream_1 = null;

		// Token: 0x0400004F RID: 79
		private static readonly byte byte_0;
	}
}
