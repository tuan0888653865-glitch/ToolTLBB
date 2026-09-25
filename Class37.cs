using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000032 RID: 50
	internal sealed class Class37 : INotifyPropertyChanged
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000154 RID: 340 RVA: 0x00019880 File Offset: 0x00017A80
		// (remove) Token: 0x06000155 RID: 341 RVA: 0x000198B8 File Offset: 0x00017AB8
		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			add
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000198F0 File Offset: 0x00017AF0
		private void method_0(string string_3)
		{
			Class37.Class38 @class = new Class37.Class38();
			@class.class37_0 = this;
			@class.string_0 = string_3;
			if (this.propertyChangedEventHandler_0 != null)
			{
				try
				{
					if (frmMain.frmMain_0.tabDieuKhien.InvokeRequired)
					{
						frmMain.frmMain_0.tabDieuKhien.Invoke(new MethodInvoker(@class.method_0));
					}
					else
					{
						this.propertyChangedEventHandler_0(this, new PropertyChangedEventArgs(@class.string_0));
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00002F64 File Offset: 0x00001164
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00002F6C File Offset: 0x0000116C
		public int Index
		{
			get
			{
				return this.int_0;
			}
			set
			{
				if (this.int_0 != value)
				{
					this.int_0 = value;
					this.method_0("Index");
				}
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00002F89 File Offset: 0x00001189
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00002F91 File Offset: 0x00001191
		public DateTime ActDate
		{
			get
			{
				return this.dateTime_0;
			}
			set
			{
				if (this.dateTime_0 != value)
				{
					this.dateTime_0 = value;
					this.method_0("ActDate");
				}
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00002FB3 File Offset: 0x000011B3
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00002FBB File Offset: 0x000011BB
		public string Comment
		{
			get
			{
				return this.string_0;
			}
			set
			{
				if (this.string_0 != value)
				{
					this.string_0 = value;
					this.method_0("Comment");
				}
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00002FDD File Offset: 0x000011DD
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00002FE5 File Offset: 0x000011E5
		public string Cost
		{
			get
			{
				return this.string_1;
			}
			set
			{
				if (this.string_1 != value)
				{
					this.string_1 = value;
					this.method_0("Cost");
				}
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00003007 File Offset: 0x00001207
		// (set) Token: 0x06000160 RID: 352 RVA: 0x0000300F File Offset: 0x0000120F
		public string Balance
		{
			get
			{
				return this.string_2;
			}
			set
			{
				if (this.string_2 != value)
				{
					this.string_2 = value;
					this.method_0("Balance");
				}
			}
		}

		// Token: 0x04000091 RID: 145
		[CompilerGenerated]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x04000092 RID: 146
		private int int_0 = -1;

		// Token: 0x04000093 RID: 147
		private DateTime dateTime_0 = DateTime.Now;

		// Token: 0x04000094 RID: 148
		private string string_0 = "";

		// Token: 0x04000095 RID: 149
		private string string_1 = "";

		// Token: 0x04000096 RID: 150
		private string string_2 = "";

		// Token: 0x02000033 RID: 51
		[CompilerGenerated]
		private sealed class Class38
		{
			// Token: 0x06000162 RID: 354 RVA: 0x00003031 File Offset: 0x00001231
			internal void method_0()
			{
				this.class37_0.propertyChangedEventHandler_0(this.class37_0, new PropertyChangedEventArgs(this.string_0));
			}

			// Token: 0x04000097 RID: 151
			public Class37 class37_0;

			// Token: 0x04000098 RID: 152
			public string string_0;
		}
	}
}
