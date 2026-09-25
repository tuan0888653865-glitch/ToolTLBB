using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000106 RID: 262
	internal sealed partial class frmScheduler : Form
	{
		// Token: 0x06000AC0 RID: 2752 RVA: 0x0000AB39 File Offset: 0x00008D39
		internal frmScheduler()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x000024E9 File Offset: 0x000006E9
		private void frmScheduler_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00009909 File Offset: 0x00007B09
		private void btnClose_Click(object sender, EventArgs e)
		{
			base.Hide();
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x0000997A File Offset: 0x00007B7A
		private void frmScheduler_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			base.Hide();
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x000D02A4 File Offset: 0x000CE4A4
		private void btnAddEvent_Click(object sender, EventArgs e)
		{
			if (this.class58_0 != null && this.cboEventName.Text != "")
			{
				if (this.class58_0.autoSettings_0.ListScheduler == null)
				{
					this.class58_0.autoSettings_0.ListScheduler = new Class210<GClass1>();
				}
				if (this.class58_0.autoSettings_0.ListScheduler != null)
				{
					GClass1 gclass = new GClass1();
					int.TryParse(this.cboHour.Text, out gclass.int_0);
					int.TryParse(this.cboMinute.Text, out gclass.int_1);
					gclass.string_0 = this.cboEventName.Text;
					this.class58_0.autoSettings_0.ListScheduler.method_1(gclass);
				}
			}
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x000D036C File Offset: 0x000CE56C
		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (this.class58_0 != null)
			{
				if (!this.cboxScheduler.Focused && this.class58_0.class114_0 != null)
				{
					this.cboxScheduler.Checked = this.class58_0.class114_0.bool_169;
				}
				this.lvAllEvents.BeginUpdate();
				int num = 0;
				int num2 = 0;
				if (this.lvAllEvents.Items.Count == 0)
				{
					num = this.class58_0.autoSettings_0.ListScheduler.Count;
				}
				else if (this.lvAllEvents.Items.Count > this.class58_0.autoSettings_0.ListScheduler.Count)
				{
					num2 = this.lvAllEvents.Items.Count - this.class58_0.autoSettings_0.ListScheduler.Count;
					num = 0;
				}
				else if (this.lvAllEvents.Items.Count < this.class58_0.autoSettings_0.ListScheduler.Count)
				{
					num2 = 0;
					num = this.class58_0.autoSettings_0.ListScheduler.Count - this.lvAllEvents.Items.Count;
				}
				new List<int>();
				if (num > 0)
				{
					this.lvAllEvents.Items.Clear();
					ListViewItem[] array = new ListViewItem[num];
					int num3 = 0;
					try
					{
						for (int i = this.class58_0.autoSettings_0.ListScheduler.Count - 1; i >= 0; i--)
						{
							GClass1 gclass = this.class58_0.autoSettings_0.ListScheduler[i];
							bool flag = false;
							foreach (object obj in this.lvAllEvents.Items)
							{
								ListViewItem listViewItem = (ListViewItem)obj;
								if (gclass.string_0 == listViewItem.SubItems[1].Text && gclass.String_0 == listViewItem.Text)
								{
									flag = true;
									break;
								}
							}
							if (!flag)
							{
								array[num3] = new ListViewItem();
								array[num3].Text = gclass.String_0;
								array[num3].SubItems.Add(gclass.string_0);
								num3++;
							}
						}
						this.lvAllEvents.Items.AddRange(array);
						goto IL_36B;
					}
					catch (Exception)
					{
						goto IL_36B;
					}
				}
				if (num2 > 0)
				{
					try
					{
						List<ListViewItem> list = new List<ListViewItem>();
						int j = this.lvAllEvents.Items.Count - 1;
						IL_323:
						while (j >= 0)
						{
							ListViewItem listViewItem2 = this.lvAllEvents.Items[j];
							bool flag2 = false;
							for (int k = this.class58_0.autoSettings_0.ListScheduler.Count - 1; k >= 0; k--)
							{
								GClass1 gclass2 = this.class58_0.autoSettings_0.ListScheduler[k];
								if (gclass2.string_0 == listViewItem2.SubItems[1].Text && gclass2.String_0 == listViewItem2.Text)
								{
									flag2 = true;
									IL_310:
									if (!flag2)
									{
										list.Add(listViewItem2);
									}
									j--;
									goto IL_323;
								}
							}
							goto IL_310;
						}
						if (list.Count > 0)
						{
							for (int l = list.Count - 1; l >= 0; l--)
							{
								this.lvAllEvents.Items.Remove(list[l]);
							}
						}
					}
					catch (Exception)
					{
					}
				}
				IL_36B:
				if (this.class58_0.autoSettings_0.ListScheduler.Count > 0 && this.class58_0.autoSettings_0.ListScheduler.Count == this.lvAllEvents.Items.Count)
				{
					for (int m = 0; m < this.lvAllEvents.Items.Count; m++)
					{
						this.lvAllEvents.Items[m].Text = this.class58_0.autoSettings_0.ListScheduler[m].String_0;
						this.lvAllEvents.Items[m].SubItems[1].Text = this.class58_0.autoSettings_0.ListScheduler[m].string_0;
					}
				}
				this.lvAllEvents.EndUpdate();
			}
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x000D0814 File Offset: 0x000CEA14
		private void btnDelEvent_Click(object sender, EventArgs e)
		{
			if (this.lvAllEvents.SelectedItems.Count > 0)
			{
				int i = this.lvAllEvents.SelectedItems.Count - 1;
				IL_EA:
				while (i >= 0)
				{
					for (int j = this.class58_0.autoSettings_0.ListScheduler.Count - 1; j >= 0; j--)
					{
						if (this.class58_0.autoSettings_0.ListScheduler[j].String_0 == this.lvAllEvents.SelectedItems[i].Text && this.class58_0.autoSettings_0.ListScheduler[j].string_0 == this.lvAllEvents.SelectedItems[i].SubItems[1].Text)
						{
							this.class58_0.autoSettings_0.ListScheduler.RemoveAt(j);
							IL_E6:
							i--;
							goto IL_EA;
						}
					}
					goto IL_E6;
				}
				this.class58_0.method_81(this.class58_0.autoSettings_0.ListScheduler, null);
			}
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x000D0930 File Offset: 0x000CEB30
		private void cboxScheduler_CheckedChanged(object sender, EventArgs e)
		{
			frmScheduler.Class180 @class = new frmScheduler.Class180();
			@class.object_0 = sender;
			@class.eventArgs_0 = e;
			try
			{
				if (this.cboxScheduler.Focused)
				{
					frmMain.frmMain_0.cboxScheduler.Invoke(new MethodInvoker(@class.method_0));
				}
			}
			catch (Exception ex)
			{
				Class83.smethod_66("Event Scheduler [1]: " + ex.Message, this.class58_0, new object[0]);
			}
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x0000AB47 File Offset: 0x00008D47
		private void btnEditEvent_Click(object sender, EventArgs e)
		{
			this.class58_0.method_81(this.class58_0.autoSettings_0.ListScheduler, null);
		}

		// Token: 0x04000F26 RID: 3878
		internal Class58 class58_0;

		// Token: 0x02000107 RID: 263
		[CompilerGenerated]
		private sealed class Class180
		{
			// Token: 0x06000ACC RID: 2764 RVA: 0x0000AB84 File Offset: 0x00008D84
			internal void method_0()
			{
				frmMain.frmMain_0.cboxScheduler.Focus();
				frmMain.frmMain_0.cboxScheduler_CheckedChanged(this.object_0, this.eventArgs_0);
			}

			// Token: 0x04000F39 RID: 3897
			public object object_0;

			// Token: 0x04000F3A RID: 3898
			public EventArgs eventArgs_0;
		}
	}
}
