using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;

namespace ns0
{
	// Token: 0x02000013 RID: 19
	internal sealed class Class9
	{
		// Token: 0x06000088 RID: 136 RVA: 0x00017978 File Offset: 0x00015B78
		internal Class9()
		{
			this.bool_0 = false;
			this.bool_1 = false;
			this.class3_0 = new Class3();
			this.class8_0 = new Class8();
			this.class0_0 = new Class0();
			this.backgroundWorker_0 = new BackgroundWorker();
			this.backgroundWorker_0.DoWork += this.backgroundWorker_0_DoWork;
			this.backgroundWorker_0.RunWorkerCompleted += this.backgroundWorker_0_RunWorkerCompleted;
			this.backgroundWorker_1 = new BackgroundWorker();
			this.backgroundWorker_1.DoWork += this.backgroundWorker_1_DoWork;
			this.backgroundWorker_1.RunWorkerCompleted += this.backgroundWorker_1_RunWorkerCompleted;
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000089 RID: 137 RVA: 0x00017A2C File Offset: 0x00015C2C
		// (remove) Token: 0x0600008A RID: 138 RVA: 0x00017A64 File Offset: 0x00015C64
		internal event Class9.Delegate1 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class9.Delegate1 @delegate = this.delegate1_0;
				Class9.Delegate1 delegate2;
				do
				{
					delegate2 = @delegate;
					Class9.Delegate1 value2 = (Class9.Delegate1)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class9.Delegate1>(ref this.delegate1_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class9.Delegate1 @delegate = this.delegate1_0;
				Class9.Delegate1 delegate2;
				do
				{
					delegate2 = @delegate;
					Class9.Delegate1 value2 = (Class9.Delegate1)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class9.Delegate1>(ref this.delegate1_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600008B RID: 139 RVA: 0x00017A9C File Offset: 0x00015C9C
		// (remove) Token: 0x0600008C RID: 140 RVA: 0x00017AD4 File Offset: 0x00015CD4
		internal event Class9.Delegate2 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class9.Delegate2 @delegate = this.delegate2_0;
				Class9.Delegate2 delegate2;
				do
				{
					delegate2 = @delegate;
					Class9.Delegate2 value2 = (Class9.Delegate2)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class9.Delegate2>(ref this.delegate2_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class9.Delegate2 @delegate = this.delegate2_0;
				Class9.Delegate2 delegate2;
				do
				{
					delegate2 = @delegate;
					Class9.Delegate2 value2 = (Class9.Delegate2)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class9.Delegate2>(ref this.delegate2_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600008D RID: 141 RVA: 0x000025CC File Offset: 0x000007CC
		internal string String_0
		{
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000025D4 File Offset: 0x000007D4
		internal bool Boolean_0
		{
			get
			{
				return this.bool_0;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000025DC File Offset: 0x000007DC
		internal bool Boolean_1
		{
			get
			{
				return this.bool_0 && !this.bool_1;
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000025F1 File Offset: 0x000007F1
		internal void method_0(string string_2)
		{
			this.string_0 = string_2;
			this.bool_0 = false;
			this.bool_1 = false;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002608 File Offset: 0x00000808
		private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (!this.bool_0)
			{
				throw new CryptographicException("There was an error communicating with the PHP script while establishing a secure connection.");
			}
			if (this.delegate1_0 != null)
			{
				this.delegate1_0(this, new Class10());
				return;
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00017B0C File Offset: 0x00015D0C
		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
			string text = this.class3_0.method_4(this.string_0, "getkey=y");
			this.class8_0.method_1(text);
			this.class0_0.method_0();
			string str = Class12.smethod_0(this.class8_0.method_4(this.class0_0.Byte_0));
			string str2 = Class12.smethod_0(this.class8_0.method_4(this.class0_0.Byte_1));
			string text2 = this.class3_0.method_4(this.string_0, "key=" + str + "&iv=" + str2);
			this.bool_0 = (this.class0_0.method_3(text2) == "AES OK");
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002637 File Offset: 0x00000837
		internal void method_1()
		{
			if (!this.backgroundWorker_0.IsBusy)
			{
				this.backgroundWorker_0.RunWorkerAsync();
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00017BC0 File Offset: 0x00015DC0
		internal string method_2(string string_2)
		{
			if (this.bool_0)
			{
				string str = this.class0_0.method_1(string_2);
				string text = this.class3_0.method_4(this.string_0, "data=" + str);
				return this.class0_0.method_3(text);
			}
			return "NOT CONNECTED";
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002651 File Offset: 0x00000851
		internal void method_3()
		{
			this.method_4("CLOSE CONNECTION");
			this.bool_0 = false;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002665 File Offset: 0x00000865
		internal void method_4(string string_2)
		{
			if (this.bool_0 && !this.bool_1)
			{
				this.backgroundWorker_1.RunWorkerAsync(string_2);
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002683 File Offset: 0x00000883
		private void backgroundWorker_1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.bool_1 = false;
			if (this.delegate2_0 != null)
			{
				this.delegate2_0(this, new Class11(this.string_1));
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000026AB File Offset: 0x000008AB
		private void backgroundWorker_1_DoWork(object sender, DoWorkEventArgs e)
		{
			this.bool_1 = true;
			this.string_1 = this.method_2((string)e.Argument);
		}

		// Token: 0x04000020 RID: 32
		private string string_0;

		// Token: 0x04000021 RID: 33
		private bool bool_0;

		// Token: 0x04000022 RID: 34
		private bool bool_1;

		// Token: 0x04000023 RID: 35
		private string string_1;

		// Token: 0x04000024 RID: 36
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x04000025 RID: 37
		private BackgroundWorker backgroundWorker_1;

		// Token: 0x04000026 RID: 38
		private Class3 class3_0;

		// Token: 0x04000027 RID: 39
		private Class8 class8_0;

		// Token: 0x04000028 RID: 40
		private Class0 class0_0;

		// Token: 0x04000029 RID: 41
		[CompilerGenerated]
		private Class9.Delegate1 delegate1_0;

		// Token: 0x0400002A RID: 42
		[CompilerGenerated]
		private Class9.Delegate2 delegate2_0;

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x0600009A RID: 154
		internal delegate void Delegate1(object sender, Class10 e);

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x0600009E RID: 158
		internal delegate void Delegate2(object sender, Class11 e);
	}
}
