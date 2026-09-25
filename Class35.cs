using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000030 RID: 48
	internal sealed class Class35 : INotifyPropertyChanged
	{
		// Token: 0x06000133 RID: 307 RVA: 0x000192F8 File Offset: 0x000174F8
		internal Class35()
		{
			this.secureString_1.AppendChar('Y');
			this.secureString_1.AppendChar('8');
			this.secureString_1.AppendChar('g');
			this.secureString_1.AppendChar('9');
			this.secureString_1.AppendChar('z');
			this.secureString_1.AppendChar('k');
			this.secureString_1.AppendChar('P');
			this.secureString_1.AppendChar('o');
			this.secureString_1.AppendChar('r');
			this.secureString_1.AppendChar('i');
			this.secureString_0.AppendChar('H');
			this.secureString_0.AppendChar('a');
			this.secureString_0.AppendChar('c');
			this.secureString_0.AppendChar('k');
			this.secureString_0.AppendChar('?');
			this.secureString_0.AppendChar('c');
			this.secureString_0.AppendChar('c');
			this.secureString_0.AppendChar('t');
			this.secureString_0.AppendChar('n');
			this.secureString_0.AppendChar('!');
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000134 RID: 308 RVA: 0x00019540 File Offset: 0x00017740
		// (remove) Token: 0x06000135 RID: 309 RVA: 0x00019578 File Offset: 0x00017778
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

		// Token: 0x06000136 RID: 310 RVA: 0x000195B0 File Offset: 0x000177B0
		private void method_0(string string_12)
		{
			Class35.Class36 @class = new Class35.Class36();
			@class.class35_0 = this;
			@class.string_0 = string_12;
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

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00002DAE File Offset: 0x00000FAE
		// (set) Token: 0x06000138 RID: 312 RVA: 0x00002DB6 File Offset: 0x00000FB6
		public string Username
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
					this.method_0("Username");
				}
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00002DD8 File Offset: 0x00000FD8
		// (set) Token: 0x0600013A RID: 314 RVA: 0x00019634 File Offset: 0x00017834
		public double RemainGGoldBalance
		{
			get
			{
				return this.double_1;
			}
			set
			{
				if (this.double_1 != value || value <= 0.0)
				{
					this.double_1 = value;
					this.RemainGGDisplay = string.Format("{0:n0}", value / frmLogin.double_0);
					this.TotalBalance = (this.RemainGGoldBalance + this.RemainGGoldPromo) / frmLogin.double_0;
					this.method_0("RemainGGoldBalance");
				}
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00002DE0 File Offset: 0x00000FE0
		// (set) Token: 0x0600013C RID: 316 RVA: 0x00002DE8 File Offset: 0x00000FE8
		public string RemainGGDisplay
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
					this.method_0("RemainGGDisplay");
				}
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00002E0A File Offset: 0x0000100A
		// (set) Token: 0x0600013E RID: 318 RVA: 0x000196A0 File Offset: 0x000178A0
		public double TotalBalance
		{
			get
			{
				return this.double_2;
			}
			set
			{
				if (this.double_2 != value || value <= 0.0)
				{
					this.double_2 = value;
					if (!frmLogin.bool_33)
					{
						this.TitleDisplay = string.Format("{0}-{1} | {2} " + frmLogin.String_1, frmMain.String_0, Class83.smethod_22(), this.double_2.ToString("0.0").Replace(".0", ""));
					}
					else
					{
						this.TitleDisplay = Class83.smethod_21(1);
					}
					this.method_0("TotalBalance");
				}
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00002E12 File Offset: 0x00001012
		// (set) Token: 0x06000140 RID: 320 RVA: 0x00002E1A File Offset: 0x0000101A
		public string TitleDisplay
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
					this.method_0("TitleDisplay");
				}
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00002E3C File Offset: 0x0000103C
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00002E44 File Offset: 0x00001044
		public string RemainGGPromoDisplay
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
					this.method_0("RemainGGPromoDisplay");
				}
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00002E66 File Offset: 0x00001066
		// (set) Token: 0x06000144 RID: 324 RVA: 0x0001972C File Offset: 0x0001792C
		public double RemainGGoldPromo
		{
			get
			{
				return this.double_3;
			}
			set
			{
				if (this.double_3 != value || value <= 0.0)
				{
					this.double_3 = value;
					this.RemainGGPromoDisplay = string.Format("{0:n0}", this.RemainGGoldPromo / frmLogin.double_0);
					this.TotalBalance = (this.RemainGGoldBalance + this.RemainGGoldPromo) / frmLogin.double_0;
					this.method_0("RemainGGoldPromo");
				}
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00002E6E File Offset: 0x0000106E
		// (set) Token: 0x06000146 RID: 326 RVA: 0x0001979C File Offset: 0x0001799C
		internal double RemainMSeconds
		{
			get
			{
				return this.double_4;
			}
			set
			{
				this.double_4 = value;
				TimeSpan timeSpan = TimeSpan.FromSeconds(this.double_4 / 1000.0);
				string text = string.Format("{0} ngày, {1} giờ {2} phút", timeSpan.Days.ToString("0"), timeSpan.Hours.ToString("00"), timeSpan.Minutes.ToString("00"));
				if (text != this.Handung)
				{
					this.Handung = text;
				}
				text = string.Format("{0} ngày, {1}:{2}", timeSpan.Days.ToString("0"), timeSpan.Hours.ToString("00"), timeSpan.Minutes.ToString("00"));
				if (text != this.Shorthandung)
				{
					this.Shorthandung = text;
				}
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00002E76 File Offset: 0x00001076
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00002E7E File Offset: 0x0000107E
		public string Shorthandung
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
					this.method_0("Shorthandung");
				}
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00002EA0 File Offset: 0x000010A0
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00002EA8 File Offset: 0x000010A8
		public string Handung
		{
			get
			{
				return this.string_6;
			}
			set
			{
				if (this.string_6 != value)
				{
					this.string_6 = value;
					this.method_0("Handung");
				}
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00002ECA File Offset: 0x000010CA
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00002ED2 File Offset: 0x000010D2
		internal int Price1HQuest
		{
			get
			{
				return this.int_6;
			}
			set
			{
				if (value != 0)
				{
					this.int_6 = value;
				}
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00002EDE File Offset: 0x000010DE
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00002EE6 File Offset: 0x000010E6
		internal int Price3HQuest
		{
			get
			{
				return this.int_7;
			}
			set
			{
				if (value != 0)
				{
					this.int_7 = value;
				}
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00002EF2 File Offset: 0x000010F2
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00002EFA File Offset: 0x000010FA
		internal int CraftingPrice
		{
			get
			{
				return this.int_8;
			}
			set
			{
				if (value != 0)
				{
					this.int_8 = value;
				}
			}
		}

		// Token: 0x0400005C RID: 92
		[CompilerGenerated]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x0400005D RID: 93
		private string string_0 = "";

		// Token: 0x0400005E RID: 94
		internal Class70 class70_0 = new Class70();

		// Token: 0x0400005F RID: 95
		internal List<Class37> list_0 = new List<Class37>();

		// Token: 0x04000060 RID: 96
		internal List<Class39> list_1 = new List<Class39>();

		// Token: 0x04000061 RID: 97
		internal List<Class40> list_2 = new List<Class40>();

		// Token: 0x04000062 RID: 98
		internal string string_1 = "";

		// Token: 0x04000063 RID: 99
		internal double double_0;

		// Token: 0x04000064 RID: 100
		private double double_1;

		// Token: 0x04000065 RID: 101
		private string string_2 = "0";

		// Token: 0x04000066 RID: 102
		private double double_2;

		// Token: 0x04000067 RID: 103
		private string string_3 = "GAuto TLBB";

		// Token: 0x04000068 RID: 104
		private string string_4 = "0";

		// Token: 0x04000069 RID: 105
		private double double_3;

		// Token: 0x0400006A RID: 106
		private double double_4;

		// Token: 0x0400006B RID: 107
		private string string_5 = "";

		// Token: 0x0400006C RID: 108
		private string string_6 = "";

		// Token: 0x0400006D RID: 109
		internal long long_0;

		// Token: 0x0400006E RID: 110
		internal string string_7 = "";

		// Token: 0x0400006F RID: 111
		internal long long_1;

		// Token: 0x04000070 RID: 112
		internal bool bool_0;

		// Token: 0x04000071 RID: 113
		internal DateTime dateTime_0;

		// Token: 0x04000072 RID: 114
		internal int int_0;

		// Token: 0x04000073 RID: 115
		internal SecureString secureString_0 = new SecureString();

		// Token: 0x04000074 RID: 116
		internal SecureString secureString_1 = new SecureString();

		// Token: 0x04000075 RID: 117
		internal SecureString secureString_2 = new SecureString();

		// Token: 0x04000076 RID: 118
		internal bool bool_1;

		// Token: 0x04000077 RID: 119
		internal string string_8 = "Buff máu + đánh quái nhanh nhất";

		// Token: 0x04000078 RID: 120
		internal int int_1;

		// Token: 0x04000079 RID: 121
		internal int int_2;

		// Token: 0x0400007A RID: 122
		internal int int_3;

		// Token: 0x0400007B RID: 123
		internal long long_2;

		// Token: 0x0400007C RID: 124
		internal long long_3;

		// Token: 0x0400007D RID: 125
		internal int int_4;

		// Token: 0x0400007E RID: 126
		internal string string_9 = "-1";

		// Token: 0x0400007F RID: 127
		internal object object_0 = 0;

		// Token: 0x04000080 RID: 128
		internal int int_5 = -1;

		// Token: 0x04000081 RID: 129
		internal Class210<Class139> class210_0 = new Class210<Class139>();

		// Token: 0x04000082 RID: 130
		internal Class210<Class139> class210_1 = new Class210<Class139>();

		// Token: 0x04000083 RID: 131
		private int int_6 = 20;

		// Token: 0x04000084 RID: 132
		private int int_7 = 50;

		// Token: 0x04000085 RID: 133
		private int int_8 = 30;

		// Token: 0x04000086 RID: 134
		internal int int_9 = 9999999;

		// Token: 0x04000087 RID: 135
		internal int int_10 = 9999999;

		// Token: 0x04000088 RID: 136
		internal int int_11;

		// Token: 0x04000089 RID: 137
		internal int int_12;

		// Token: 0x0400008A RID: 138
		internal int int_13 = 30;

		// Token: 0x0400008B RID: 139
		internal string string_10 = "0";

		// Token: 0x0400008C RID: 140
		internal string string_11 = "";

		// Token: 0x0400008D RID: 141
		internal long long_4;

		// Token: 0x0400008E RID: 142
		internal int int_14;

		// Token: 0x02000031 RID: 49
		[CompilerGenerated]
		private sealed class Class36
		{
			// Token: 0x06000152 RID: 338 RVA: 0x00002F06 File Offset: 0x00001106
			internal void method_0()
			{
				this.class35_0.propertyChangedEventHandler_0(this.class35_0, new PropertyChangedEventArgs(this.string_0));
			}

			// Token: 0x0400008F RID: 143
			public Class35 class35_0;

			// Token: 0x04000090 RID: 144
			public string string_0;
		}
	}
}
