using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x020000E1 RID: 225
	internal sealed class Class169
	{
		// Token: 0x06000862 RID: 2146 RVA: 0x0009E38C File Offset: 0x0009C58C
		internal void method_0(IPEndPoint ipendPoint_0, IPEndPoint ipendPoint_1)
		{
			this.socket_0.Bind(ipendPoint_0);
			this.socket_0.Listen(10);
			for (;;)
			{
				Socket socket = this.socket_0.Accept();
				Class169 @class = new Class169();
				Class169.Class170 class2 = new Class169.Class170(socket, @class.socket_0);
				@class.method_1(ipendPoint_1, socket);
				socket.BeginReceive(class2.Buffer, 0, class2.Buffer.Length, SocketFlags.None, new AsyncCallback(Class169.smethod_0), class2);
			}
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x0009E400 File Offset: 0x0009C600
		private void method_1(EndPoint endPoint_0, Socket socket_1)
		{
			Class169.Class170 @class = new Class169.Class170(this.socket_0, socket_1);
			this.socket_0.Connect(endPoint_0);
			this.socket_0.BeginReceive(@class.Buffer, 0, @class.Buffer.Length, SocketFlags.None, new AsyncCallback(Class169.smethod_0), @class);
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x0009E450 File Offset: 0x0009C650
		private static void smethod_0(IAsyncResult iasyncResult_0)
		{
			Class169.Class170 @class = (Class169.Class170)iasyncResult_0.AsyncState;
			try
			{
				int num = @class.SourceSocket.EndReceive(iasyncResult_0);
				if (num > 0)
				{
					@class.DestinationSocket.Send(@class.Buffer, num, SocketFlags.None);
					@class.SourceSocket.BeginReceive(@class.Buffer, 0, @class.Buffer.Length, SocketFlags.None, new AsyncCallback(Class169.smethod_0), @class);
				}
			}
			catch
			{
				@class.DestinationSocket.Close();
				@class.SourceSocket.Close();
			}
		}

		// Token: 0x04000B0A RID: 2826
		private readonly Socket socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

		// Token: 0x020000E2 RID: 226
		private sealed class Class170
		{
			// Token: 0x06000865 RID: 2149 RVA: 0x00009865 File Offset: 0x00007A65
			internal Class170(Socket socket_2, Socket socket_3)
			{
				this.SourceSocket = socket_2;
				this.DestinationSocket = socket_3;
				this.Buffer = new byte[8192];
			}

			// Token: 0x170001D3 RID: 467
			// (get) Token: 0x06000866 RID: 2150 RVA: 0x0000988B File Offset: 0x00007A8B
			// (set) Token: 0x06000867 RID: 2151 RVA: 0x00009893 File Offset: 0x00007A93
			internal Socket SourceSocket { get; private set; }

			// Token: 0x170001D4 RID: 468
			// (get) Token: 0x06000868 RID: 2152 RVA: 0x0000989C File Offset: 0x00007A9C
			// (set) Token: 0x06000869 RID: 2153 RVA: 0x000098A4 File Offset: 0x00007AA4
			internal Socket DestinationSocket { get; private set; }

			// Token: 0x170001D5 RID: 469
			// (get) Token: 0x0600086A RID: 2154 RVA: 0x000098AD File Offset: 0x00007AAD
			// (set) Token: 0x0600086B RID: 2155 RVA: 0x000098B5 File Offset: 0x00007AB5
			internal byte[] Buffer { get; private set; }

			// Token: 0x04000B0B RID: 2827
			[CompilerGenerated]
			private Socket socket_0;

			// Token: 0x04000B0C RID: 2828
			[CompilerGenerated]
			private Socket socket_1;

			// Token: 0x04000B0D RID: 2829
			[CompilerGenerated]
			private byte[] byte_0;
		}
	}
}
