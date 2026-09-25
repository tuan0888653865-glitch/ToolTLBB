using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns0
{
	// Token: 0x02000132 RID: 306
	internal sealed class Class210<T> : List<T>
	{
		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06001276 RID: 4726 RVA: 0x0011A138 File Offset: 0x00118338
		// (remove) Token: 0x06001277 RID: 4727 RVA: 0x0011A170 File Offset: 0x00118370
		internal event EventHandler Event_0
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06001278 RID: 4728 RVA: 0x0011A1A8 File Offset: 0x001183A8
		// (remove) Token: 0x06001279 RID: 4729 RVA: 0x0011A1E0 File Offset: 0x001183E0
		internal event EventHandler Event_1
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x000166B9 File Offset: 0x000148B9
		internal void method_0(T gparam_0)
		{
			base.Remove(gparam_0);
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(this, null);
			}
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x000166D8 File Offset: 0x000148D8
		internal void method_1(T gparam_0)
		{
			base.Add(gparam_0);
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, null);
			}
		}

		// Token: 0x04001387 RID: 4999
		[CompilerGenerated]
		private EventHandler eventHandler_0;

		// Token: 0x04001388 RID: 5000
		[CompilerGenerated]
		private EventHandler eventHandler_1;
	}
}
