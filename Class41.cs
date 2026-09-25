using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000036 RID: 54
	internal sealed class Class41 : INotifyPropertyChanged
	{
		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600016A RID: 362 RVA: 0x00019D88 File Offset: 0x00017F88
		// (remove) Token: 0x0600016B RID: 363 RVA: 0x00019DC0 File Offset: 0x00017FC0
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

		// Token: 0x0600016C RID: 364 RVA: 0x00019DF8 File Offset: 0x00017FF8
		private void method_0(string string_8)
		{
			Class41.Class42 @class = new Class41.Class42();
			@class.class41_0 = this;
			@class.string_0 = string_8;
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

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00003093 File Offset: 0x00001293
		// (set) Token: 0x0600016E RID: 366 RVA: 0x0000309B File Offset: 0x0000129B
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

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600016F RID: 367 RVA: 0x000030B8 File Offset: 0x000012B8
		// (set) Token: 0x06000170 RID: 368 RVA: 0x000030C0 File Offset: 0x000012C0
		public string Tinhnang
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
					this.method_0("Tinhnang");
				}
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000171 RID: 369 RVA: 0x000030E2 File Offset: 0x000012E2
		// (set) Token: 0x06000172 RID: 370 RVA: 0x000030EA File Offset: 0x000012EA
		public string GiaHanTime
		{
			get
			{
				return this.string_1;
			}
			set
			{
				if (this.string_1 != value && value != null)
				{
					this.string_1 = value;
					this.method_0("GiaHanTime");
				}
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0000310F File Offset: 0x0000130F
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00003117 File Offset: 0x00001317
		public string Remain
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
					this.method_0("Remain");
				}
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00003139 File Offset: 0x00001339
		// (set) Token: 0x06000176 RID: 374 RVA: 0x00019E7C File Offset: 0x0001807C
		public long RemainMS
		{
			get
			{
				return this.long_1;
			}
			set
			{
				if (this.long_1 != value || value == 0L)
				{
					this.long_1 = value;
					if (this.long_1 <= 0L)
					{
						this.Remain = "Hết hạn";
					}
					else
					{
						TimeSpan timeSpan = TimeSpan.FromSeconds((double)this.long_1);
						if (timeSpan.Days > 0)
						{
							this.Remain = string.Format("{0}d {1}:{2}", timeSpan.Days.ToString(), timeSpan.Hours.ToString("00"), timeSpan.Minutes.ToString("00"));
							return;
						}
						this.Remain = string.Format("{0}:{1}", timeSpan.Hours.ToString("00"), timeSpan.Minutes.ToString("00"));
					}
					this.method_0("Remain");
				}
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00003141 File Offset: 0x00001341
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00003149 File Offset: 0x00001349
		public string Comment
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
					this.method_0("Comment");
				}
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000179 RID: 377 RVA: 0x0000316B File Offset: 0x0000136B
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00019F5C File Offset: 0x0001815C
		public string TNKey
		{
			get
			{
				return this.string_4;
			}
			set
			{
				if (this.string_4 != value)
				{
					this.string_4 = value;
					this.Tinhnang = Class83.smethod_31(this.string_4, false);
					string text;
					if (this.string_6 == "day")
					{
						if (this.int_1 > 0 && this.int_1 % 30 == 0)
						{
							text = (this.int_1 % 30).ToString() + " tháng";
						}
						else
						{
							text = this.int_1.ToString() + " ngày";
						}
					}
					else
					{
						text = this.int_1.ToString() + " giờ";
					}
					string arg;
					if (this.string_7 == "player")
					{
						arg = this.int_2.ToString() + " nhân vật";
					}
					else
					{
						arg = this.int_2.ToString() + " party";
					}
					if (this.TNKey == "time")
					{
						this.Comment = "Gói " + text;
						return;
					}
					this.Comment = string.Format("{0} {1}", text, arg);
				}
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00003173 File Offset: 0x00001373
		// (set) Token: 0x0600017C RID: 380 RVA: 0x0000317B File Offset: 0x0000137B
		public bool Giahan
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				if (this.bool_0 != value)
				{
					this.bool_0 = value;
					this.method_0("Giahan");
				}
			}
		}

		// Token: 0x040000AA RID: 170
		[CompilerGenerated]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x040000AB RID: 171
		private int int_0;

		// Token: 0x040000AC RID: 172
		private string string_0 = "";

		// Token: 0x040000AD RID: 173
		private string string_1 = "Chọn";

		// Token: 0x040000AE RID: 174
		private string string_2 = "Hết hạn";

		// Token: 0x040000AF RID: 175
		internal long long_0;

		// Token: 0x040000B0 RID: 176
		private long long_1;

		// Token: 0x040000B1 RID: 177
		private string string_3 = "(xxx) Yến Tử Ổ - 2pt - 1h";

		// Token: 0x040000B2 RID: 178
		private string string_4 = "na";

		// Token: 0x040000B3 RID: 179
		internal string string_5 = "";

		// Token: 0x040000B4 RID: 180
		internal int int_1;

		// Token: 0x040000B5 RID: 181
		internal string string_6 = "day";

		// Token: 0x040000B6 RID: 182
		internal int int_2;

		// Token: 0x040000B7 RID: 183
		internal string string_7 = "player";

		// Token: 0x040000B8 RID: 184
		private bool bool_0 = true;

		// Token: 0x02000037 RID: 55
		[CompilerGenerated]
		private sealed class Class42
		{
			// Token: 0x0600017E RID: 382 RVA: 0x00003198 File Offset: 0x00001398
			internal void method_0()
			{
				this.class41_0.propertyChangedEventHandler_0(this.class41_0, new PropertyChangedEventArgs(this.string_0));
			}

			// Token: 0x040000B9 RID: 185
			public Class41 class41_0;

			// Token: 0x040000BA RID: 186
			public string string_0;
		}
	}
}
