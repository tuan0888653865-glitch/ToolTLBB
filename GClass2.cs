using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x020000FF RID: 255
	public sealed class GClass2 : INotifyPropertyChanged
	{
		// Token: 0x06000A55 RID: 2645 RVA: 0x000CA6A8 File Offset: 0x000C88A8
		public GClass2()
		{
			this.PropertyChanged += this.GClass2_PropertyChanged;
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000A56 RID: 2646 RVA: 0x000CA750 File Offset: 0x000C8950
		// (remove) Token: 0x06000A57 RID: 2647 RVA: 0x000CA788 File Offset: 0x000C8988
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

		// Token: 0x06000A58 RID: 2648 RVA: 0x0000A6E5 File Offset: 0x000088E5
		private void method_0()
		{
			if (frmGLogin.frmGLogin_0 != null && frmGLogin.frmGLogin_0.Visible)
			{
				frmGLogin.frmGLogin_0.listGLogin.RefreshObject(this);
			}
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x0000A70A File Offset: 0x0000890A
		private void method_1(string string_10)
		{
			if (frmMain.frmMain_0 != null && frmMain.frmMain_0.InvokeRequired)
			{
				frmMain.frmMain_0.richLog.Invoke(new MethodInvoker(this.method_2));
				return;
			}
			this.method_0();
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x000024E9 File Offset: 0x000006E9
		private void GClass2_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x0000A742 File Offset: 0x00008942
		// (set) Token: 0x06000A5C RID: 2652 RVA: 0x000CA7C0 File Offset: 0x000C89C0
		internal Class58 RefAutoAccount
		{
			get
			{
				return this.class58_0;
			}
			set
			{
				if (this.class58_0 != value)
				{
					this.class58_0 = value;
					if (value == null)
					{
						this.imgCaptcha = null;
						this.GameStarted = false;
						this.int_2 = 0;
						this.bool_3 = false;
						this.int_3 = 0;
						this.long_2 = 0L;
						this.long_1 = 0L;
					}
				}
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x0000A74A File Offset: 0x0000894A
		// (set) Token: 0x06000A5E RID: 2654 RVA: 0x0000A752 File Offset: 0x00008952
		public Image imgCaptcha
		{
			get
			{
				return this.image_0;
			}
			set
			{
				if (this.image_0 != value)
				{
					this.image_0 = value;
					this.method_1("imgCaptcha");
				}
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x0000A76F File Offset: 0x0000896F
		// (set) Token: 0x06000A60 RID: 2656 RVA: 0x0000A777 File Offset: 0x00008977
		public bool AIEnabled
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
					this.method_1("AIEnabled");
				}
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x0000A794 File Offset: 0x00008994
		// (set) Token: 0x06000A62 RID: 2658 RVA: 0x0000A79C File Offset: 0x0000899C
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
					this.method_1("Username");
				}
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x0000A7BE File Offset: 0x000089BE
		// (set) Token: 0x06000A64 RID: 2660 RVA: 0x000CA814 File Offset: 0x000C8A14
		public string databaseIDStr
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
					if (frmGLogin.frmGLogin_0 != null)
					{
						this.method_1("databaseIDStr");
						frmGLogin.frmGLogin_0.long_2 = frmLogin.stopwatch_0.ElapsedMilliseconds + frmGLogin.frmGLogin_0.long_1;
					}
				}
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x0000A7C6 File Offset: 0x000089C6
		// (set) Token: 0x06000A66 RID: 2662 RVA: 0x0000A7CE File Offset: 0x000089CE
		public int DatabaseID
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
					this.databaseIDStr = value.ToString("X8");
					this.method_1("DatabaseID");
				}
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x0000A7FD File Offset: 0x000089FD
		// (set) Token: 0x06000A68 RID: 2664 RVA: 0x0000A805 File Offset: 0x00008A05
		public string CharName
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
					this.method_1("CharName");
				}
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x0000A827 File Offset: 0x00008A27
		// (set) Token: 0x06000A6A RID: 2666 RVA: 0x0000A82F File Offset: 0x00008A2F
		public string captchaCode
		{
			get
			{
				return this.string_3;
			}
			set
			{
				if (this.string_3 != value && value != "Code...")
				{
					this.string_3 = value;
					this.method_1("captchaCode");
				}
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x0000A85E File Offset: 0x00008A5E
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x0000A866 File Offset: 0x00008A66
		public string String_0
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
					this.method_1("NPH");
				}
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x0000A888 File Offset: 0x00008A88
		// (set) Token: 0x06000A6E RID: 2670 RVA: 0x0000A890 File Offset: 0x00008A90
		public string Server
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
					this.method_1("Server");
				}
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x0000A8B2 File Offset: 0x00008AB2
		// (set) Token: 0x06000A70 RID: 2672 RVA: 0x0000A8BA File Offset: 0x00008ABA
		public string MinorServer
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
					this.method_1("MinorServer");
				}
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x0000A8DC File Offset: 0x00008ADC
		// (set) Token: 0x06000A72 RID: 2674 RVA: 0x0000A8E4 File Offset: 0x00008AE4
		public string GamePath
		{
			get
			{
				return this.string_8;
			}
			set
			{
				if (this.string_8 != value)
				{
					this.string_8 = value;
					this.method_1("GamePath");
				}
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x000CA868 File Offset: 0x000C8A68
		public string NPHShortName
		{
			get
			{
				if (this.String_0 != "")
				{
					if (this.String_0 == "Vinagame")
					{
						return "VNG";
					}
					if (this.String_0 == "Tình Kiếm")
					{
						return "TK";
					}
					if (this.String_0 == "Song Kiếm")
					{
						return "SK";
					}
					if (this.String_0 == "Server khác" || this.String_0 == "Others")
					{
						return "OT";
					}
					if (this.String_0 == "D.Oath")
					{
						return "DO2";
					}
					if (this.String_0 == "69Dragon")
					{
						return "TL69";
					}
					if (this.String_0 == "CIBMal")
					{
						return "CM";
					}
					if (this.String_0 == "Changyou")
					{
						return "CY";
					}
				}
				return "";
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x0000A906 File Offset: 0x00008B06
		// (set) Token: 0x06000A75 RID: 2677 RVA: 0x0000A90E File Offset: 0x00008B0E
		public bool GameStarted
		{
			get
			{
				return this.bool_4;
			}
			set
			{
				if (this.bool_4 != value)
				{
					this.bool_4 = value;
					this.method_1("GameStarted");
				}
			}
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x0000A92B File Offset: 0x00008B2B
		[CompilerGenerated]
		private void method_2()
		{
			this.method_0();
		}

		// Token: 0x04000E96 RID: 3734
		[CompilerGenerated]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x04000E97 RID: 3735
		private Class58 class58_0;

		// Token: 0x04000E98 RID: 3736
		private Image image_0;

		// Token: 0x04000E99 RID: 3737
		private bool bool_0;

		// Token: 0x04000E9A RID: 3738
		public long long_0;

		// Token: 0x04000E9B RID: 3739
		private string string_0 = "";

		// Token: 0x04000E9C RID: 3740
		private string string_1 = "";

		// Token: 0x04000E9D RID: 3741
		private int int_0;

		// Token: 0x04000E9E RID: 3742
		public SecureString secureString_0 = new SecureString();

		// Token: 0x04000E9F RID: 3743
		private string string_2 = "";

		// Token: 0x04000EA0 RID: 3744
		private string string_3 = "";

		// Token: 0x04000EA1 RID: 3745
		private string string_4 = "";

		// Token: 0x04000EA2 RID: 3746
		private string string_5 = "";

		// Token: 0x04000EA3 RID: 3747
		private string string_6 = "";

		// Token: 0x04000EA4 RID: 3748
		public int int_1;

		// Token: 0x04000EA5 RID: 3749
		public string string_7 = "";

		// Token: 0x04000EA6 RID: 3750
		private string string_8 = "";

		// Token: 0x04000EA7 RID: 3751
		public bool bool_1;

		// Token: 0x04000EA8 RID: 3752
		public bool bool_2;

		// Token: 0x04000EA9 RID: 3753
		public bool bool_3;

		// Token: 0x04000EAA RID: 3754
		private bool bool_4;

		// Token: 0x04000EAB RID: 3755
		public string string_9 = "Enter";

		// Token: 0x04000EAC RID: 3756
		public bool bool_5;

		// Token: 0x04000EAD RID: 3757
		public long long_1;

		// Token: 0x04000EAE RID: 3758
		public int int_2 = -1;

		// Token: 0x04000EAF RID: 3759
		public int int_3;

		// Token: 0x04000EB0 RID: 3760
		public long long_2;
	}
}
