using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns0
{
	// Token: 0x020000F6 RID: 246
	internal sealed class Class175 : INotifyPropertyChanged
	{
		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060009A0 RID: 2464 RVA: 0x000B1AC8 File Offset: 0x000AFCC8
		// (remove) Token: 0x060009A1 RID: 2465 RVA: 0x000B1B00 File Offset: 0x000AFD00
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

		// Token: 0x060009A2 RID: 2466 RVA: 0x0000A0F5 File Offset: 0x000082F5
		private void method_0(string string_6)
		{
			if (this.propertyChangedEventHandler_0 != null)
			{
				this.propertyChangedEventHandler_0(this, new PropertyChangedEventArgs(string_6));
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x0000A111 File Offset: 0x00008311
		// (set) Token: 0x060009A4 RID: 2468 RVA: 0x0000A119 File Offset: 0x00008319
		public int col_ID
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
					this.method_0("col_ID");
				}
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x0000A136 File Offset: 0x00008336
		// (set) Token: 0x060009A6 RID: 2470 RVA: 0x0000A13E File Offset: 0x0000833E
		public string col_HWID
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
					this.method_0("col_HWID");
				}
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x0000A160 File Offset: 0x00008360
		// (set) Token: 0x060009A8 RID: 2472 RVA: 0x0000A168 File Offset: 0x00008368
		public string col_LastSeen
		{
			get
			{
				return this.string_3;
			}
			set
			{
				if (this.string_3 != value)
				{
					this.string_3 = value;
					this.method_0("col_LastSeen");
				}
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x0000A18A File Offset: 0x0000838A
		// (set) Token: 0x060009AA RID: 2474 RVA: 0x0000A192 File Offset: 0x00008392
		public string col_Exp
		{
			get
			{
				return this.string_4;
			}
			set
			{
				if (this.string_4 != value)
				{
					if (!value.Contains("1970"))
					{
						this.string_4 = value;
					}
					else
					{
						this.string_4 = "Hết hạn - miễn phí";
					}
					this.method_0("col_Exp");
				}
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x0000A1CE File Offset: 0x000083CE
		// (set) Token: 0x060009AC RID: 2476 RVA: 0x0000A1D6 File Offset: 0x000083D6
		public string col_Tinhnang
		{
			get
			{
				return this.string_5;
			}
			set
			{
				if (this.string_5 != value)
				{
					this.string_5 = value;
					this.method_0("col_Tinhnang");
				}
			}
		}

		// Token: 0x04000C9B RID: 3227
		[CompilerGenerated]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x04000C9C RID: 3228
		internal string string_0 = "";

		// Token: 0x04000C9D RID: 3229
		internal string string_1 = "1";

		// Token: 0x04000C9E RID: 3230
		private int int_0 = -1;

		// Token: 0x04000C9F RID: 3231
		private string string_2 = "";

		// Token: 0x04000CA0 RID: 3232
		private string string_3 = "";

		// Token: 0x04000CA1 RID: 3233
		private string string_4 = "";

		// Token: 0x04000CA2 RID: 3234
		private string string_5 = "";

		// Token: 0x04000CA3 RID: 3235
		internal List<Class39> list_0 = new List<Class39>();
	}
}
