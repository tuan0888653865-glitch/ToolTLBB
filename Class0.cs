using System;
using System.IO;
using System.Security.Cryptography;

namespace ns0
{
	// Token: 0x02000002 RID: 2
	internal sealed class Class0
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000023AC File Offset: 0x000005AC
		internal Class0()
		{
			this.byte_0 = new byte[32];
			this.byte_1 = new byte[16];
			this.method_0();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00016C5C File Offset: 0x00014E5C
		internal Class0(string string_0, string string_1)
		{
			this.byte_0 = Convert.FromBase64String(string_0);
			this.byte_1 = Convert.FromBase64String(string_1);
			if (this.byte_0.Length * 8 != 256)
			{
				throw new Exception("The Key must be exactally 256 bits long!");
			}
			if (this.byte_1.Length * 8 != 128)
			{
				throw new Exception("The IV must be exactally 128 bits long!");
			}
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x000023D4 File Offset: 0x000005D4
		internal string String_0
		{
			get
			{
				return Convert.ToBase64String(this.byte_0);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000023E1 File Offset: 0x000005E1
		internal string String_1
		{
			get
			{
				return Convert.ToBase64String(this.byte_1);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000023EE File Offset: 0x000005EE
		internal byte[] Byte_0
		{
			get
			{
				return this.byte_0;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000023F6 File Offset: 0x000005F6
		internal byte[] Byte_1
		{
			get
			{
				return this.byte_1;
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000023FE File Offset: 0x000005FE
		internal void method_0()
		{
			RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider();
			rngcryptoServiceProvider.GetBytes(this.byte_0);
			rngcryptoServiceProvider.GetBytes(this.byte_1);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000241C File Offset: 0x0000061C
		internal string method_1(string string_0)
		{
			return Class12.smethod_0(this.method_2(string_0));
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00016CC0 File Offset: 0x00014EC0
		private byte[] method_2(string string_0)
		{
			byte[] result;
			try
			{
				RijndaelManaged rijndaelManaged = new RijndaelManaged();
				rijndaelManaged.Padding = PaddingMode.PKCS7;
				rijndaelManaged.Mode = CipherMode.CBC;
				rijndaelManaged.KeySize = 256;
				rijndaelManaged.Key = this.byte_0;
				rijndaelManaged.IV = this.byte_1;
				ICryptoTransform transform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				StreamWriter streamWriter = new StreamWriter(cryptoStream);
				streamWriter.Write(string_0);
				streamWriter.Close();
				cryptoStream.Close();
				rijndaelManaged.Clear();
				result = memoryStream.ToArray();
			}
			catch (Exception inner)
			{
				throw new CryptographicException("Problem trying to encrypt.", inner);
			}
			return result;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000242A File Offset: 0x0000062A
		internal string method_3(string string_0)
		{
			return this.method_4(Class12.smethod_1(string_0));
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00016D68 File Offset: 0x00014F68
		private string method_4(byte[] byte_2)
		{
			string result;
			try
			{
				RijndaelManaged rijndaelManaged = new RijndaelManaged();
				rijndaelManaged.Padding = PaddingMode.PKCS7;
				rijndaelManaged.Mode = CipherMode.CBC;
				rijndaelManaged.KeySize = 256;
				rijndaelManaged.Key = this.byte_0;
				rijndaelManaged.IV = this.byte_1;
				ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
				MemoryStream memoryStream = new MemoryStream(byte_2);
				CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
				StreamReader streamReader = new StreamReader(cryptoStream);
				string text = streamReader.ReadToEnd();
				streamReader.Close();
				cryptoStream.Close();
				memoryStream.Close();
				rijndaelManaged.Clear();
				result = text;
			}
			catch (Exception inner)
			{
				throw new CryptographicException("Problem trying to decrypt.", inner);
			}
			return result;
		}

		// Token: 0x04000001 RID: 1
		private byte[] byte_0;

		// Token: 0x04000002 RID: 2
		private byte[] byte_1;
	}
}
