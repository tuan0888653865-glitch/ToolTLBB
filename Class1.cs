using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns0
{
	// Token: 0x02000004 RID: 4
	internal sealed class Class1
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00016E14 File Offset: 0x00015014
		internal Class1()
		{
			this.class3_0 = new Class3();
			this.backgroundWorker_0 = new BackgroundWorker();
			this.backgroundWorker_0.DoWork += this.backgroundWorker_0_DoWork;
			this.backgroundWorker_0.RunWorkerCompleted += this.backgroundWorker_0_RunWorkerCompleted;
			this.bool_0 = false;
			this.bool_1 = false;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002440 File Offset: 0x00000640
		internal bool Boolean_0
		{
			get
			{
				return this.bool_0;
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600000F RID: 15 RVA: 0x00016E7C File Offset: 0x0001507C
		// (remove) Token: 0x06000010 RID: 16 RVA: 0x00016EB4 File Offset: 0x000150B4
		internal event Class1.Delegate0 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class1.Delegate0 @delegate = this.delegate0_0;
				Class1.Delegate0 delegate2;
				do
				{
					delegate2 = @delegate;
					Class1.Delegate0 value2 = (Class1.Delegate0)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class1.Delegate0>(ref this.delegate0_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class1.Delegate0 @delegate = this.delegate0_0;
				Class1.Delegate0 delegate2;
				do
				{
					delegate2 = @delegate;
					Class1.Delegate0 value2 = (Class1.Delegate0)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class1.Delegate0>(ref this.delegate0_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00016EEC File Offset: 0x000150EC
		internal bool method_0(string string_1, Struct1 struct1_0)
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				this.struct0_0 = default(Struct0);
				this.struct0_0.string_0 = string_1;
				this.struct0_0.struct1_0 = struct1_0;
				this.backgroundWorker_0.RunWorkerAsync(Enum0.const_1);
				return true;
			}
			return false;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00016F40 File Offset: 0x00015140
		internal bool method_1(string string_1)
		{
			Struct1 struct1_ = new Struct1
			{
				bool_0 = false
			};
			return this.method_0(string_1, struct1_);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002448 File Offset: 0x00000648
		internal bool method_2(string string_1, Class7 class7_0, Struct1 struct1_0)
		{
			return this.method_5(string_1, class7_0.String_0, struct1_0);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00016F68 File Offset: 0x00015168
		internal bool method_3(string string_1, Class7 class7_0)
		{
			Struct1 struct1_ = new Struct1
			{
				bool_0 = false
			};
			return this.method_5(string_1, class7_0.String_0, struct1_);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00016F98 File Offset: 0x00015198
		internal bool method_4(string string_1, string string_2)
		{
			Struct1 struct1_ = new Struct1
			{
				bool_0 = false
			};
			return this.method_5(string_1, string_2, struct1_);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00016FC0 File Offset: 0x000151C0
		internal bool method_5(string string_1, string string_2, Struct1 struct1_0)
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				this.struct0_0 = default(Struct0);
				this.struct0_0.string_0 = string_1;
				this.struct0_0.struct1_0 = struct1_0;
				this.struct0_0.string_1 = string_2;
				this.backgroundWorker_0.RunWorkerAsync(Enum0.const_0);
				return true;
			}
			return false;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002458 File Offset: 0x00000658
		private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (this.delegate0_0 != null)
			{
				this.delegate0_0(this, new Class2(this.string_0, this.bool_1));
				this.bool_0 = false;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00017020 File Offset: 0x00015220
		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				this.bool_1 = false;
				Enum0 @enum = (Enum0)e.Argument;
				if (@enum != Enum0.const_0)
				{
					if (@enum == Enum0.const_1)
					{
						this.string_0 = this.class3_0.method_0(this.struct0_0.string_0, this.struct0_0.struct1_0);
					}
				}
				else
				{
					this.string_0 = this.class3_0.method_5(this.struct0_0.string_0, this.struct0_0.string_1, this.struct0_0.struct1_0);
				}
			}
			catch (Exception ex)
			{
				this.bool_1 = true;
				this.string_0 = "Error getting HTTP request: " + ex.Message;
			}
		}

		// Token: 0x04000003 RID: 3
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x04000004 RID: 4
		private string string_0;

		// Token: 0x04000005 RID: 5
		private bool bool_0;

		// Token: 0x04000006 RID: 6
		private Struct0 struct0_0;

		// Token: 0x04000007 RID: 7
		private bool bool_1;

		// Token: 0x04000008 RID: 8
		private Class3 class3_0;

		// Token: 0x04000009 RID: 9
		[CompilerGenerated]
		private Class1.Delegate0 delegate0_0;

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x0600001A RID: 26
		internal delegate void Delegate0(object sender, Class2 e);
	}
}
