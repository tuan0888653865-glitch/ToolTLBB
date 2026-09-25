using System;
using System.Drawing;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000133 RID: 307
	public sealed class GClass3 : ListView
	{
		// Token: 0x0600127C RID: 4732 RVA: 0x000166F6 File Offset: 0x000148F6
		public GClass3()
		{
			base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x0600127D RID: 4733 RVA: 0x00016718 File Offset: 0x00014918
		// (set) Token: 0x0600127E RID: 4734 RVA: 0x00016720 File Offset: 0x00014920
		public int Int32_0
		{
			get
			{
				return this.int_1;
			}
			set
			{
				this.int_1 = value;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x0600127F RID: 4735 RVA: 0x00016729 File Offset: 0x00014929
		// (set) Token: 0x06001280 RID: 4736 RVA: 0x00016731 File Offset: 0x00014931
		public int Int32_1
		{
			get
			{
				return this.int_2;
			}
			set
			{
				this.int_2 = value;
			}
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x0011A218 File Offset: 0x00118418
		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			if (m.Msg == 15)
			{
				if (this.Int32_0 >= 0 && this.Int32_0 < base.Items.Count)
				{
					Rectangle bounds = base.Items[this.Int32_0].GetBounds(ItemBoundsPortion.Entire);
					this.method_0(bounds.Left, bounds.Right, bounds.Top);
				}
				if (this.Int32_1 >= 0 && this.Int32_0 < base.Items.Count)
				{
					Rectangle bounds2 = base.Items[this.Int32_1].GetBounds(ItemBoundsPortion.Entire);
					this.method_0(bounds2.Left, bounds2.Right, bounds2.Bottom);
				}
			}
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x0011A2D8 File Offset: 0x001184D8
		private void method_0(int int_3, int int_4, int int_5)
		{
			using (Graphics graphics = base.CreateGraphics())
			{
				graphics.DrawLine(Pens.Orange, int_3, int_5, int_4 - 1, int_5);
				Point[] points = new Point[]
				{
					new Point(int_3, int_5 - 4),
					new Point(int_3 + 7, int_5),
					new Point(int_3, int_5 + 4)
				};
				Point[] points2 = new Point[]
				{
					new Point(int_4, int_5 - 4),
					new Point(int_4 - 8, int_5),
					new Point(int_4, int_5 + 4)
				};
				graphics.FillPolygon(Brushes.Orange, points);
				graphics.FillPolygon(Brushes.Orange, points2);
			}
		}

		// Token: 0x04001389 RID: 5001
		private static int int_0;

		// Token: 0x0400138A RID: 5002
		private int int_1 = -1;

		// Token: 0x0400138B RID: 5003
		private int int_2 = -1;
	}
}
