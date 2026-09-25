using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace ns0
{
	// Token: 0x0200000A RID: 10
	internal sealed class Class4
	{
		// Token: 0x0600002A RID: 42
		[DllImport("mscoree.dll", CharSet = CharSet.Unicode)]
		internal static extern bool StrongNameSignatureVerificationEx(string string_0, [MarshalAs(UnmanagedType.U1)] bool bool_0, [MarshalAs(UnmanagedType.U1)] ref bool bool_1);

		// Token: 0x0600002B RID: 43 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_0()
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_1()
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_2()
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_3()
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_4()
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_5()
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_6()
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_7()
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_8()
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_9()
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_10()
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_11()
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_12()
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_13()
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_14()
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_15()
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_16()
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_17()
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_18()
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_19()
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_20()
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_21()
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_22()
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_23()
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_24()
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_25()
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_26()
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000024E9 File Offset: 0x000006E9
		private void method_27()
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000024EB File Offset: 0x000006EB
		private static bool smethod_0()
		{
			return Type.GetType("Mono.Runtime") != null;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000172E8 File Offset: 0x000154E8
		internal static void smethod_1()
		{
			string string_ = "scGqwl1/afI=";
			if (Environment.Version.Major >= 4 && !Class4.smethod_0())
			{
				Class4.Class5.smethod_0(string_);
				return;
			}
			Class4.smethod_2(string_);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0001731C File Offset: 0x0001551C
		internal static void smethod_2(string string_0)
		{
			Exception ex = null;
			bool flag = false;
			try
			{
				if (string_0 != null && string_0.Length > 0)
				{
					byte[] array = Convert.FromBase64String(string_0);
					if (array != null)
					{
						byte[] publicKeyToken = Assembly.GetExecutingAssembly().GetName().GetPublicKeyToken();
						for (int i = 0; i < array.Length; i++)
						{
							if (array[i] != publicKeyToken[i])
							{
								throw new Exception("Public key mistmatch");
							}
						}
					}
				}
				bool flag2 = false;
				string location = Assembly.GetExecutingAssembly().Location;
				if (location != null && location.Length != 0)
				{
					bool flag3 = Class4.StrongNameSignatureVerificationEx(location, true, ref flag2);
					if (!(flag = (flag2 && flag3)))
					{
						throw new Exception(string.Format("Verification via API failed. Verified = {0}, Return={1}, Location={2}", flag2, flag3, location));
					}
				}
				else
				{
					flag = true;
				}
			}
			catch (DllNotFoundException)
			{
				flag = true;
			}
			catch (Exception ex2)
			{
				ex = ex2;
			}
			if (!flag)
			{
				string text = "Strong name validation for the assembly '" + Assembly.GetExecutingAssembly().GetName().Name + "'  failed. Assembly not strong-named or is tampered. ";
				if (ex != null)
				{
					string text2 = text;
					text = string.Concat(new string[]
					{
						text2,
						ex.Message,
						" (",
						ex.GetType().FullName,
						")"
					});
				}
				throw new Exception(text);
			}
		}

		// Token: 0x0200000B RID: 11
		private sealed class Class5
		{
			// Token: 0x0600004C RID: 76 RVA: 0x0001759C File Offset: 0x0001579C
			internal static void smethod_0(string string_0)
			{
				bool flag = false;
				Exception ex = null;
				try
				{
					if (string_0 != null && string_0.Length > 0)
					{
						byte[] array = Convert.FromBase64String(string_0);
						if (array != null)
						{
							byte[] publicKeyToken = Assembly.GetExecutingAssembly().GetName().GetPublicKeyToken();
							for (int i = 0; i < array.Length; i++)
							{
								if (array[i] != publicKeyToken[i])
								{
									throw new Exception("Public Key mistmatch");
								}
							}
						}
					}
					string location = Assembly.GetExecutingAssembly().Location;
					if (location != null && location.Length != 0)
					{
						if (!(flag = Class4.Class5.smethod_1(location)))
						{
							throw new Exception("Verification via API failed.");
						}
					}
					else
					{
						flag = true;
					}
				}
				catch (Exception ex2)
				{
					ex = ex2;
				}
				if (!flag)
				{
					string text = "Strong name validation for the assembly '" + Assembly.GetExecutingAssembly().GetName().Name + "'  failed. Assembly not strong-named or is tampered. ";
					if (ex != null)
					{
						text += ex.Message;
					}
					throw new Exception(text);
				}
			}

			// Token: 0x0600004D RID: 77 RVA: 0x00017688 File Offset: 0x00015888
			private static bool smethod_1(string string_0)
			{
				Class4.Class5.Interface1 @interface = null;
				Class4.Class5.Interface0 interface2 = null;
				Class4.Class5.Interface2 interface3 = null;
				try
				{
					IntPtr zero = IntPtr.Zero;
					if (Class4.Class5.CLRCreateInstance(ref Class4.Class5.guid_2, ref Class4.Class5.guid_3, ref zero) == 0 && zero != IntPtr.Zero)
					{
						@interface = (Marshal.GetObjectForIUnknown(zero) as Class4.Class5.Interface1);
						Marshal.Release(zero);
						string text = Environment.Version.ToString();
						text = "v" + text.Substring(0, text.LastIndexOf('.'));
						zero = IntPtr.Zero;
						if (@interface.imethod_0(text, ref Class4.Class5.guid_4, out zero) == 0 && zero != IntPtr.Zero)
						{
							interface2 = (Marshal.GetObjectForIUnknown(zero) as Class4.Class5.Interface0);
							Marshal.Release(zero);
							zero = IntPtr.Zero;
							if (interface2.imethod_6(ref Class4.Class5.guid_0, ref Class4.Class5.guid_1, ref zero) == 0 && zero != IntPtr.Zero)
							{
								interface3 = (Marshal.GetObjectForIUnknown(zero) as Class4.Class5.Interface2);
								Marshal.Release(zero);
								byte b = 0;
								return interface3.imethod_20(string_0, 1, ref b) == 0 && b != 0;
							}
						}
					}
				}
				finally
				{
					if (interface3 != null)
					{
						Marshal.ReleaseComObject(interface3);
						interface3 = null;
					}
					if (interface2 != null)
					{
						Marshal.ReleaseComObject(interface2);
						interface2 = null;
					}
					if (@interface != null)
					{
						Marshal.ReleaseComObject(@interface);
						@interface = null;
					}
				}
				return false;
			}

			// Token: 0x0600004E RID: 78
			[DllImport("mscoree.dll")]
			private static extern int CLRCreateInstance(ref Guid guid_5, ref Guid guid_6, ref IntPtr intptr_0);

			// Token: 0x04000013 RID: 19
			private static Guid guid_0 = new Guid(3080391373U, 62925, 16539, 181, 165, 161, 98, 68, 97, 11, 146);

			// Token: 0x04000014 RID: 20
			private static Guid guid_1 = new Guid(2681814223U, 12928, 17297, 179, 169, 150, 225, 205, 231, 124, 141);

			// Token: 0x04000015 RID: 21
			private static Guid guid_2 = new Guid(2457868429U, 3726, 18535, 179, 12, 127, 168, 56, 132, 232, 222);

			// Token: 0x04000016 RID: 22
			private static Guid guid_3 = new Guid(3543325598U, 47539, 16677, 130, 7, 161, 72, 132, 245, 50, 22);

			// Token: 0x04000017 RID: 23
			private static Guid guid_4 = new Guid(3174683090U, 47663, 18538, 137, 176, 180, 176, 203, 70, 104, 145);

			// Token: 0x0200000C RID: 12
			private sealed class Class6
			{
			}

			// Token: 0x0200000D RID: 13
			[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
			[Guid("BD39D1D2-BA2F-486a-89B0-B4B0CB466891")]
			[ComImport]
			private interface Interface0
			{
				// Token: 0x06000050 RID: 80
				[PreserveSig]
				int imethod_0();

				// Token: 0x06000051 RID: 81
				[PreserveSig]
				int imethod_1();

				// Token: 0x06000052 RID: 82
				[PreserveSig]
				int imethod_2();

				// Token: 0x06000053 RID: 83
				[PreserveSig]
				int imethod_3();

				// Token: 0x06000054 RID: 84
				[PreserveSig]
				int imethod_4();

				// Token: 0x06000055 RID: 85
				[PreserveSig]
				int imethod_5();

				// Token: 0x06000056 RID: 86
				[PreserveSig]
				int imethod_6(ref Guid guid_0, ref Guid guid_1, ref IntPtr intptr_0);

				// Token: 0x06000057 RID: 87
				[PreserveSig]
				int imethod_7();

				// Token: 0x06000058 RID: 88
				[PreserveSig]
				int imethod_8();

				// Token: 0x06000059 RID: 89
				[PreserveSig]
				int imethod_9();

				// Token: 0x0600005A RID: 90
				[PreserveSig]
				int imethod_10();

				// Token: 0x0600005B RID: 91
				[PreserveSig]
				int imethod_11();
			}

			// Token: 0x0200000E RID: 14
			[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
			[Guid("D332DB9E-B9B3-4125-8207-A14884F53216")]
			[ComImport]
			private interface Interface1
			{
				// Token: 0x0600005C RID: 92
				[PreserveSig]
				int imethod_0(string string_0, ref Guid guid_0, out IntPtr intptr_0);

				// Token: 0x0600005D RID: 93
				[PreserveSig]
				int imethod_1(string string_0, StringBuilder stringBuilder_0, ref uint uint_0);

				// Token: 0x0600005E RID: 94
				[PreserveSig]
				int imethod_2();

				// Token: 0x0600005F RID: 95
				[PreserveSig]
				int imethod_3();

				// Token: 0x06000060 RID: 96
				[PreserveSig]
				int imethod_4();

				// Token: 0x06000061 RID: 97
				[PreserveSig]
				int imethod_5();

				// Token: 0x06000062 RID: 98
				[PreserveSig]
				int imethod_6();
			}

			// Token: 0x0200000F RID: 15
			[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
			[Guid("9FD93CCF-3280-4391-B3A9-96E1CDE77C8D")]
			[ComImport]
			private interface Interface2
			{
				// Token: 0x06000063 RID: 99
				[PreserveSig]
				int imethod_0();

				// Token: 0x06000064 RID: 100
				[PreserveSig]
				int imethod_1();

				// Token: 0x06000065 RID: 101
				[PreserveSig]
				int imethod_2();

				// Token: 0x06000066 RID: 102
				[PreserveSig]
				int imethod_3();

				// Token: 0x06000067 RID: 103
				[PreserveSig]
				int imethod_4();

				// Token: 0x06000068 RID: 104
				[PreserveSig]
				int imethod_5();

				// Token: 0x06000069 RID: 105
				[PreserveSig]
				int imethod_6();

				// Token: 0x0600006A RID: 106
				[PreserveSig]
				int imethod_7();

				// Token: 0x0600006B RID: 107
				[PreserveSig]
				int imethod_8();

				// Token: 0x0600006C RID: 108
				[PreserveSig]
				int imethod_9();

				// Token: 0x0600006D RID: 109
				[PreserveSig]
				int imethod_10();

				// Token: 0x0600006E RID: 110
				[PreserveSig]
				int imethod_11();

				// Token: 0x0600006F RID: 111
				[PreserveSig]
				int imethod_12();

				// Token: 0x06000070 RID: 112
				[PreserveSig]
				int imethod_13();

				// Token: 0x06000071 RID: 113
				[PreserveSig]
				int imethod_14();

				// Token: 0x06000072 RID: 114
				[PreserveSig]
				int imethod_15();

				// Token: 0x06000073 RID: 115
				[PreserveSig]
				int imethod_16();

				// Token: 0x06000074 RID: 116
				[PreserveSig]
				int imethod_17();

				// Token: 0x06000075 RID: 117
				[PreserveSig]
				int imethod_18();

				// Token: 0x06000076 RID: 118
				[PreserveSig]
				int imethod_19();

				// Token: 0x06000077 RID: 119
				[PreserveSig]
				int imethod_20(string string_0, byte byte_0, ref byte byte_1);

				// Token: 0x06000078 RID: 120
				[PreserveSig]
				int imethod_21();

				// Token: 0x06000079 RID: 121
				[PreserveSig]
				int imethod_22();

				// Token: 0x0600007A RID: 122
				[PreserveSig]
				int imethod_23();

				// Token: 0x0600007B RID: 123
				[PreserveSig]
				int imethod_24();
			}
		}
	}
}
