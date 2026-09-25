using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ns0
{
	// Token: 0x02000012 RID: 18
	internal sealed class Class8
	{
		// Token: 0x06000080 RID: 128 RVA: 0x00002544 File Offset: 0x00000744
		internal Class8(string string_0)
		{
			this.method_0(string_0);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002553 File Offset: 0x00000753
		internal Class8()
		{
			this.bool_0 = false;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00017844 File Offset: 0x00015A44
		internal void method_0(string string_0)
		{
			try
			{
				this.x509Certificate2_0 = this.method_3(string_0);
				this.bool_0 = true;
			}
			catch (Exception inner)
			{
				this.bool_0 = false;
				throw new CryptographicException("There was an error reading the certificate.", inner);
			}
			if (this.x509Certificate2_0.HasPrivateKey)
			{
				throw new CryptographicException("Use a certificate that does not contain a private key for security purposes.");
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000178A4 File Offset: 0x00015AA4
		internal void method_1(string string_0)
		{
			try
			{
				this.x509Certificate2_0 = this.method_2(string_0);
				this.bool_0 = true;
			}
			catch (Exception inner)
			{
				this.bool_0 = false;
				throw new CryptographicException("There was an error reading the certificate.", inner);
			}
			if (this.x509Certificate2_0.HasPrivateKey)
			{
				throw new CryptographicException("Use a certificate that does not contain a private key for security purposes.");
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00017904 File Offset: 0x00015B04
		private X509Certificate2 method_2(string string_0)
		{
			X509Certificate2 result;
			try
			{
				if (string_0.Contains("-----"))
				{
					string_0 = string_0.Split(new string[]
					{
						"-----"
					}, StringSplitOptions.RemoveEmptyEntries)[1];
				}
				string_0.Replace("\n", "");
				result = new X509Certificate2(Convert.FromBase64String(string_0));
			}
			catch (Exception innerException)
			{
				throw new FormatException("The certificate key was not in the expected format.", innerException);
			}
			return result;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002562 File Offset: 0x00000762
		private X509Certificate2 method_3(string string_0)
		{
			return this.method_2(File.ReadAllText(string_0));
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002570 File Offset: 0x00000770
		internal byte[] method_4(byte[] byte_0)
		{
			if (!this.bool_0)
			{
				throw new Exception("The RSA engine has not been initialized with a certificate yet.");
			}
			return ((RSACryptoServiceProvider)this.x509Certificate2_0.PublicKey.Key).Encrypt(byte_0, false);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000025A1 File Offset: 0x000007A1
		internal string method_5(string string_0)
		{
			if (!this.bool_0)
			{
				throw new Exception("The RSA engine has not been initialized with a certificate yet.");
			}
			return Class12.smethod_0(this.method_4(Encoding.ASCII.GetBytes(string_0)));
		}

		// Token: 0x0400001E RID: 30
		private X509Certificate2 x509Certificate2_0;

		// Token: 0x0400001F RID: 31
		private bool bool_0;
	}
}
