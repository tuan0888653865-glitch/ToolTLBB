using System;
using System.IO;
using System.Net;
using System.Text;

namespace ns0
{
	// Token: 0x02000009 RID: 9
	internal sealed class Class3
	{
		// Token: 0x06000022 RID: 34 RVA: 0x000024BE File Offset: 0x000006BE
		internal Class3()
		{
			this.cookieContainer_0 = new CookieContainer();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000170D4 File Offset: 0x000152D4
		internal string method_0(string string_0, Struct1 struct1_0)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_0);
			if (struct1_0.bool_0)
			{
				IWebProxy proxy = httpWebRequest.Proxy;
				WebProxy webProxy = new WebProxy();
				Uri address = new Uri(struct1_0.string_0);
				webProxy.Address = address;
				webProxy.Credentials = new NetworkCredential(struct1_0.string_1, struct1_0.string_2);
				httpWebRequest.Proxy = webProxy;
			}
			httpWebRequest.Method = "GET";
			httpWebRequest.CookieContainer = this.cookieContainer_0;
			WebResponse response = httpWebRequest.GetResponse();
			StreamReader streamReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
			string result = streamReader.ReadToEnd();
			streamReader.Close();
			response.Close();
			return result;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00017174 File Offset: 0x00015374
		internal string method_1(string string_0)
		{
			Struct1 struct1_ = new Struct1
			{
				bool_0 = false
			};
			return this.method_0(string_0, struct1_);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000024D1 File Offset: 0x000006D1
		internal string method_2(string string_0, Class7 class7_0, Struct1 struct1_0)
		{
			return this.method_5(string_0, class7_0.String_0, struct1_0);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0001719C File Offset: 0x0001539C
		internal string method_3(string string_0, Class7 class7_0)
		{
			Struct1 struct1_ = new Struct1
			{
				bool_0 = false
			};
			return this.method_5(string_0, class7_0.String_0, struct1_);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000171CC File Offset: 0x000153CC
		internal string method_4(string string_0, string string_1)
		{
			Struct1 struct1_ = new Struct1
			{
				bool_0 = false
			};
			return this.method_5(string_0, string_1, struct1_);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000171F4 File Offset: 0x000153F4
		internal string method_5(string string_0, string string_1, Struct1 struct1_0)
		{
			string result;
			try
			{
				byte[] bytes = Encoding.ASCII.GetBytes(string_1);
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_0);
				if (struct1_0.bool_0)
				{
					IWebProxy proxy = httpWebRequest.Proxy;
					WebProxy webProxy = new WebProxy();
					Uri address = new Uri(struct1_0.string_0);
					webProxy.Address = address;
					webProxy.Credentials = new NetworkCredential(struct1_0.string_1, struct1_0.string_2);
					httpWebRequest.Proxy = webProxy;
				}
				httpWebRequest.Method = "POST";
				httpWebRequest.ContentType = "application/x-www-form-urlencoded";
				httpWebRequest.ContentLength = (long)bytes.Length;
				httpWebRequest.CookieContainer = this.cookieContainer_0;
				Stream requestStream = httpWebRequest.GetRequestStream();
				requestStream.Write(bytes, 0, bytes.Length);
				requestStream.Close();
				result = new StreamReader(((HttpWebResponse)httpWebRequest.GetResponse()).GetResponseStream()).ReadToEnd();
			}
			catch (Exception ex)
			{
				result = "ERROR: " + ex.Message;
			}
			return result;
		}

		// Token: 0x04000012 RID: 18
		private CookieContainer cookieContainer_0;
	}
}
