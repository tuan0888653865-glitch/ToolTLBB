using System;
using System.Collections.Generic;

namespace ns0
{
	// Token: 0x0200009B RID: 155
	internal sealed class Class116
	{
		// Token: 0x06000782 RID: 1922 RVA: 0x000992EC File Offset: 0x000974EC
		internal Class116()
		{
			for (int i = 0; i < 10; i++)
			{
				this.list_0.Add(new Class117());
			}
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00008FED File Offset: 0x000071ED
		internal void method_0(Class59 class59_1)
		{
			this.class59_0 = class59_1;
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x000047AC File Offset: 0x000029AC
		private bool method_1()
		{
			return true;
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x00099368 File Offset: 0x00097568
		internal int Int32_0
		{
			get
			{
				if (this.int_2 > 0 && this.list_0 != null && this.list_0.Count > 0)
				{
					for (int i = this.list_0.Count - 1; i >= 0; i--)
					{
						Class117 @class = this.list_0[i];
						if (@class.int_5 == this.int_2 && @class.int_6 == this.int_1 && @class.int_0 > 0)
						{
							return i;
						}
					}
				}
				return -1;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x000993E4 File Offset: 0x000975E4
		internal int Int32_1
		{
			get
			{
				if (this.list_0 != null && this.Int32_0 >= 0 && this.Int32_0 < this.list_0.Count && this.list_0.Count > this.Int32_0)
				{
					return this.list_0[this.Int32_0].int_3;
				}
				return 0;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x00008FF6 File Offset: 0x000071F6
		// (set) Token: 0x06000788 RID: 1928 RVA: 0x00008FFE File Offset: 0x000071FE
		internal string String_0
		{
			get
			{
				return this.string_0;
			}
			set
			{
				if (this.Boolean_0 && this.string_0 != value)
				{
					this.method_9("HuyetTePetName", value.ToString(), "", new string[0]);
				}
				this.string_0 = value;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x00009039 File Offset: 0x00007239
		// (set) Token: 0x0600078A RID: 1930 RVA: 0x00009041 File Offset: 0x00007241
		internal string String_1
		{
			get
			{
				return this.string_1;
			}
			set
			{
				if (this.Boolean_0 && this.string_1 != value)
				{
					this.method_9("CongSinhPetName", value.ToString(), "", new string[0]);
				}
				this.string_1 = value;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x0000907C File Offset: 0x0000727C
		internal int Int32_2
		{
			get
			{
				if (this.String_2 != "")
				{
					return this.method_6(this.String_2);
				}
				return -1;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x0000909E File Offset: 0x0000729E
		internal int Int32_3
		{
			get
			{
				if (this.String_2 != "")
				{
					return this.method_5(this.String_2);
				}
				return -1;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x000090C0 File Offset: 0x000072C0
		// (set) Token: 0x0600078E RID: 1934 RVA: 0x000090C8 File Offset: 0x000072C8
		internal string String_2
		{
			get
			{
				return this.string_2;
			}
			set
			{
				if (this.Boolean_0 && this.string_2 != value)
				{
					this.method_9("AlwaysActivePetName", value.ToString(), "", new string[0]);
				}
				this.string_2 = value;
			}
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00099440 File Offset: 0x00097640
		internal string method_2(int int_6)
		{
			if (int_6 > 0 && this.list_0 != null && this.list_0.Count > 0)
			{
				for (int i = this.list_0.Count - 1; i >= 0; i--)
				{
					Class117 @class = this.list_0[i];
					if (@class.int_5 == int_6)
					{
						return @class.string_0;
					}
				}
			}
			return "";
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x000994A8 File Offset: 0x000976A8
		internal Class117 method_3(string string_3)
		{
			if (string_3 != "" && string_3.Length < 30 && this.list_0 != null && this.list_0.Count > 0)
			{
				try
				{
					for (int i = this.list_0.Count - 1; i >= 0; i--)
					{
						Class117 @class = this.list_0[i];
						if (@class.string_0 == string_3)
						{
							return @class;
						}
					}
					goto IL_BC;
				}
				catch (Exception ex)
				{
					Class83.smethod_66(string.Concat(new string[]
					{
						"Lỗi lấy thông tin pet theo tên. Tên pet: ",
						string_3,
						"\n",
						ex.Message,
						"\nStack traces\n",
						ex.StackTrace
					}), null, new object[0]);
					goto IL_BC;
				}
				Class117 result;
				return result;
			}
			IL_BC:
			return null;
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00099584 File Offset: 0x00097784
		internal Class117 method_4(int int_6, int int_7)
		{
			if (int_6 != 0 && this.list_0 != null && this.list_0.Count > 0)
			{
				try
				{
					for (int i = this.list_0.Count - 1; i >= 0; i--)
					{
						Class117 @class = this.list_0[i];
						if (@class.int_5 == int_6 && int_6 != 0 && @class.int_6 == int_7 && int_7 != 0)
						{
							return @class;
						}
					}
					goto IL_8B;
				}
				catch (Exception ex)
				{
					Class83.smethod_66("Lỗi lấy pet theo dbid. \n" + ex.Message + "\nStack traces\n" + ex.StackTrace, null, new object[0]);
					goto IL_8B;
				}
				Class117 result;
				return result;
			}
			IL_8B:
			return null;
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00099630 File Offset: 0x00097830
		internal int method_5(string string_3)
		{
			if (string_3 != "" && string_3.Length < 30 && this.list_0 != null && this.list_0.Count > 0)
			{
				for (int i = this.list_0.Count - 1; i >= 0; i--)
				{
					Class117 @class = this.list_0[i];
					if (@class.string_0 == string_3)
					{
						return @class.int_6;
					}
				}
			}
			return -1;
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x000996A8 File Offset: 0x000978A8
		internal int method_6(string string_3)
		{
			if (string_3 != "" && string_3.Length < 30 && this.list_0 != null && this.list_0.Count > 0)
			{
				for (int i = this.list_0.Count - 1; i >= 0; i--)
				{
					Class117 @class = this.list_0[i];
					if (@class.string_0 == string_3)
					{
						return @class.int_5;
					}
				}
			}
			return -1;
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00099720 File Offset: 0x00097920
		internal int method_7(string string_3)
		{
			if (string_3 != "" && string_3.Length < 30 && this.list_0 != null && this.list_0.Count > 0)
			{
				for (int i = this.list_0.Count - 1; i >= 0; i--)
				{
					Class117 @class = this.list_0[i];
					if (@class.string_0 == string_3)
					{
						return @class.int_3;
					}
				}
			}
			return -1;
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x00009103 File Offset: 0x00007303
		// (set) Token: 0x06000796 RID: 1942 RVA: 0x0000910B File Offset: 0x0000730B
		internal bool Boolean_0
		{
			get
			{
				return this.bool_1;
			}
			set
			{
				this.bool_1 = value;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x00009114 File Offset: 0x00007314
		// (set) Token: 0x06000798 RID: 1944 RVA: 0x0000911C File Offset: 0x0000731C
		internal int Int32_4
		{
			get
			{
				return this.int_5;
			}
			set
			{
				if (this.int_5 != value)
				{
					this.int_5 = value;
				}
			}
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x0000912E File Offset: 0x0000732E
		private string method_8()
		{
			return Class161.smethod_3(this.Int32_4);
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x0000913B File Offset: 0x0000733B
		internal void method_9(string string_3, string string_4, string string_5 = "", params string[] string_6)
		{
			Class161.smethod_4(this.method_8(), string_3, string_4, string_5, string_6);
		}

		// Token: 0x04000857 RID: 2135
		private int int_0 = 58;

		// Token: 0x04000858 RID: 2136
		private Class59 class59_0;

		// Token: 0x04000859 RID: 2137
		internal int int_1;

		// Token: 0x0400085A RID: 2138
		internal int int_2;

		// Token: 0x0400085B RID: 2139
		internal Class57.Enum9 enum9_0 = Class57.Enum9.const_0;

		// Token: 0x0400085C RID: 2140
		private string string_0 = "";

		// Token: 0x0400085D RID: 2141
		private string string_1 = "";

		// Token: 0x0400085E RID: 2142
		internal int int_3;

		// Token: 0x0400085F RID: 2143
		internal int int_4;

		// Token: 0x04000860 RID: 2144
		private string string_2 = "";

		// Token: 0x04000861 RID: 2145
		internal List<Class117> list_0 = new List<Class117>();

		// Token: 0x04000862 RID: 2146
		internal bool bool_0 = true;

		// Token: 0x04000863 RID: 2147
		private bool bool_1;

		// Token: 0x04000864 RID: 2148
		private int int_5;

		// Token: 0x04000865 RID: 2149
		internal bool bool_2;

		// Token: 0x04000866 RID: 2150
		internal long long_0;

		// Token: 0x04000867 RID: 2151
		internal bool bool_3 = true;

		// Token: 0x04000868 RID: 2152
		internal long long_1;
	}
}
