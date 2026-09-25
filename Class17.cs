using System;
using System.Collections;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x0200001D RID: 29
	internal sealed class Class17 : ListView
	{
		// Token: 0x060000C2 RID: 194 RVA: 0x00017DE4 File Offset: 0x00015FE4
		internal Class17()
		{
			this.int_2 = 4;
			this.arrayList_0 = new ArrayList();
			this.int_1 = -1;
			this.brush_0 = SystemBrushes.ControlLight;
			this.brush_1 = SystemBrushes.Highlight;
			base.OwnerDraw = true;
			base.FullRowSelect = true;
			base.View = View.Details;
			base.MouseDown += this.Class17_MouseDown;
			base.MouseDoubleClick += this.Class17_MouseDoubleClick;
			base.DrawColumnHeader += this.Class17_DrawColumnHeader;
			base.DrawSubItem += this.Class17_DrawSubItem;
			base.MouseMove += this.Class17_MouseMove;
			base.ColumnClick += this.Class17_ColumnClick;
			this.textBox_0 = new TextBox();
			this.textBox_0.Visible = false;
			base.Controls.Add(this.textBox_0);
			this.textBox_0.Leave += this.textBox_0_Leave;
			this.textBox_0.KeyPress += this.textBox_0_KeyPress;
		}

		// Token: 0x060000C3 RID: 195
		[DllImport("user32.dll")]
		private static extern bool SendMessage(IntPtr intptr_0, uint uint_2, int int_7, int int_8);

		// Token: 0x060000C4 RID: 196 RVA: 0x00017F00 File Offset: 0x00016100
		protected override void WndProc(ref Message m)
		{
			if (m.Msg == 15)
			{
				foreach (object obj in this.arrayList_0)
				{
					Class17.Struct2 @struct = (Class17.Struct2)obj;
					Rectangle bounds = @struct.class28_0.Bounds;
					if (bounds.Y > 0 && bounds.Y < base.ClientRectangle.Height)
					{
						@struct.control_0.Visible = true;
						@struct.control_0.Bounds = new Rectangle(bounds.X + this.int_2, bounds.Y + this.int_2, bounds.Width - 2 * this.int_2, bounds.Height - 2 * this.int_2);
					}
					else
					{
						@struct.control_0.Visible = false;
					}
				}
			}
			int msg = m.Msg;
			if (msg - 276 <= 1 || msg == 522)
			{
				base.Focus();
			}
			base.WndProc(ref m);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000028C2 File Offset: 0x00000AC2
		private void method_0(int int_7, int int_8)
		{
			Class17.SendMessage(base.Handle, 4116U, int_7, int_8);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00018028 File Offset: 0x00016228
		internal void method_1(Control control_0, Class28 class28_0)
		{
			base.Controls.Add(control_0);
			class28_0.Control_0 = control_0;
			Class17.Struct2 @struct;
			@struct.control_0 = control_0;
			@struct.class28_0 = class28_0;
			control_0.Margin = new Padding(0, 5, 0, 0);
			this.arrayList_0.Add(@struct);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0001807C File Offset: 0x0001627C
		internal void method_2(Class28 class28_0)
		{
			Control control_ = class28_0.Control_0;
			for (int i = 0; i < this.arrayList_0.Count; i++)
			{
				if (((Class17.Struct2)this.arrayList_0[i]).class28_0 == class28_0)
				{
					this.arrayList_0.RemoveAt(i);
					class28_0.Control_0 = null;
					base.Controls.Remove(control_);
					control_.Dispose();
					return;
				}
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x000028D7 File Offset: 0x00000AD7
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x000028DF File Offset: 0x00000ADF
		internal int Int32_0
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

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000CA RID: 202 RVA: 0x000028E8 File Offset: 0x00000AE8
		// (set) Token: 0x060000CB RID: 203 RVA: 0x000028F0 File Offset: 0x00000AF0
		internal Brush Brush_0
		{
			get
			{
				return this.brush_0;
			}
			set
			{
				this.brush_0 = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000CC RID: 204 RVA: 0x000028F9 File Offset: 0x00000AF9
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00002901 File Offset: 0x00000B01
		internal Brush Brush_1
		{
			get
			{
				return this.brush_1;
			}
			set
			{
				this.brush_1 = value;
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000290A File Offset: 0x00000B0A
		private void textBox_0_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				this.listViewSubItem_0.Text = this.textBox_0.Text;
				this.textBox_0.Visible = false;
				this.listViewItem_0.Tag = null;
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000180E8 File Offset: 0x000162E8
		private void textBox_0_Leave(object sender, EventArgs e)
		{
			Control control = (Control)sender;
			this.listViewSubItem_0.Text = control.Text;
			control.Visible = false;
			this.listViewItem_0.Tag = null;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00018120 File Offset: 0x00016320
		private void Class17_MouseDown(object sender, MouseEventArgs e)
		{
			ListViewItem.ListViewSubItem subItem = base.HitTest(e.X, e.Y).SubItem;
			if (subItem == null)
			{
				return;
			}
			int left = subItem.Bounds.Left;
			if (left < 0)
			{
				this.method_0(left, 0);
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00018164 File Offset: 0x00016364
		private void Class17_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Class32 @class = base.GetItemAt(e.X, e.Y) as Class32;
			if (@class == null)
			{
				return;
			}
			this.listViewItem_0 = @class;
			int num = @class.Bounds.Left;
			int i = 0;
			while (i < base.Columns.Count)
			{
				num += base.Columns[i].Width;
				if (num <= e.X)
				{
					i++;
				}
				else
				{
					num -= base.Columns[i].Width;
					this.listViewSubItem_0 = @class.SubItems[i];
					this.int_0 = i;
					IL_95:
					if (!(base.Columns[i] is Class23))
					{
						return;
					}
					Class23 class2 = (Class23)base.Columns[i];
					if (class2.GetType() != typeof(Class24))
					{
						if (class2.GetType() == typeof(Class25) && ((Class25)class2).Boolean_0)
						{
							Class31 class3 = (Class31)this.listViewSubItem_0;
							if (class3.Boolean_0)
							{
								class3.Boolean_0 = false;
							}
							else
							{
								class3.Boolean_0 = true;
							}
							base.Invalidate(class3.Bounds);
						}
						return;
					}
					Class24 class4 = (Class24)class2;
					if (class4.Control_0 != null)
					{
						Control control_ = class4.Control_0;
						if (control_.Tag != null)
						{
							base.Controls.Add(control_);
							control_.Tag = null;
							if (control_ is ComboBox)
							{
								((ComboBox)control_).SelectedValueChanged += this.method_3;
							}
							control_.Leave += this.textBox_0_Leave;
						}
						control_.Location = new Point(num, base.GetItemRect(base.Items.IndexOf(@class)).Y);
						control_.Width = base.Columns[i].Width;
						if (control_.Width > base.Width)
						{
							control_.Width = base.ClientRectangle.Width;
						}
						control_.Text = this.listViewSubItem_0.Text;
						control_.Visible = true;
						control_.BringToFront();
						control_.Focus();
						return;
					}
					this.textBox_0.Location = new Point(num, base.GetItemRect(base.Items.IndexOf(@class)).Y);
					this.textBox_0.Width = base.Columns[i].Width;
					if (this.textBox_0.Width > base.Width)
					{
						this.textBox_0.Width = base.ClientRectangle.Width;
					}
					this.textBox_0.Text = this.listViewSubItem_0.Text;
					this.textBox_0.Visible = true;
					this.textBox_0.BringToFront();
					this.textBox_0.Focus();
					return;
				}
			}
			goto IL_95;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00018444 File Offset: 0x00016644
		private void method_3(object sender, EventArgs e)
		{
			if (((Control)sender).Visible && this.listViewSubItem_0 != null)
			{
				if (sender.GetType() == typeof(Class13))
				{
					object selectedItem = ((Class13)sender).SelectedItem;
					if (selectedItem.GetType() == typeof(Class13.Class15))
					{
						Class13.Class15 @class = (Class13.Class15)selectedItem;
						if (this.int_0 == 0)
						{
							if (this.listViewItem_0.GetType() == typeof(Class33))
							{
								((Class33)this.listViewItem_0).Image_0 = @class.Image_0;
							}
							else if (this.listViewItem_0.GetType() == typeof(Class34))
							{
								Class34 class2 = (Class34)this.listViewItem_0;
								class2.ArrayList_0.Clear();
								class2.ArrayList_0.AddRange(new object[]
								{
									@class.Image_0
								});
							}
						}
						else if (this.listViewSubItem_0.GetType() == typeof(Class29))
						{
							((Class29)this.listViewSubItem_0).Image_0 = @class.Image_0;
						}
						else if (this.listViewSubItem_0.GetType() == typeof(Class30))
						{
							Class30 class3 = (Class30)this.listViewSubItem_0;
							class3.ArrayList_0.Clear();
							class3.ArrayList_0.Add(@class.Image_0);
							class3.String_0 = @class.String_1;
						}
					}
					else if (selectedItem.GetType() == typeof(Class13.Class16))
					{
						Class13.Class16 class4 = (Class13.Class16)selectedItem;
						if (this.int_0 == 0)
						{
							if (this.listViewItem_0.GetType() == typeof(Class33))
							{
								((Class33)this.listViewItem_0).Image_0 = (Image)class4.ArrayList_0[0];
							}
							else if (this.listViewItem_0.GetType() == typeof(Class34))
							{
								Class34 class5 = (Class34)this.listViewItem_0;
								class5.ArrayList_0.Clear();
								class5.ArrayList_0.AddRange(class4.ArrayList_0);
							}
						}
						else if (this.listViewSubItem_0.GetType() == typeof(Class29))
						{
							Class29 class6 = (Class29)this.listViewSubItem_0;
							if (class4.ArrayList_0 != null)
							{
								class6.Image_0 = (Image)class4.ArrayList_0[0];
							}
						}
						else if (this.listViewSubItem_0.GetType() == typeof(Class30))
						{
							Class30 class7 = (Class30)this.listViewSubItem_0;
							class7.ArrayList_0.Clear();
							class7.ArrayList_0.AddRange(class4.ArrayList_0);
							class7.String_0 = class4.String_1;
						}
					}
				}
				ComboBox comboBox = (ComboBox)sender;
				this.listViewSubItem_0.Text = comboBox.Text;
				comboBox.Visible = false;
				this.listViewItem_0.Tag = null;
				return;
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0001871C File Offset: 0x0001691C
		private void Class17_MouseMove(object sender, MouseEventArgs e)
		{
			ListViewItem itemAt = base.GetItemAt(e.X, e.Y);
			if (itemAt != null && itemAt.Tag == null)
			{
				base.Invalidate(itemAt.Bounds);
				itemAt.Tag = "t";
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002944 File Offset: 0x00000B44
		private void Class17_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
		{
			e.DrawDefault = true;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00018760 File Offset: 0x00016960
		private void Class17_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
		{
			e.DrawBackground();
			if (e.ColumnIndex == this.int_1)
			{
				e.Graphics.FillRectangle(this.brush_0, e.Bounds);
			}
			if ((e.ItemState & ListViewItemStates.Selected) != (ListViewItemStates)0)
			{
				e.Graphics.FillRectangle(this.brush_1, e.Bounds);
			}
			int num = e.Bounds.Y + e.Bounds.Height / 2 - e.SubItem.Font.Height / 2;
			int num2 = e.Bounds.X + 2;
			if (e.ColumnIndex == 0)
			{
				Class32 @class = (Class32)e.Item;
				if (@class.GetType() == typeof(Class33))
				{
					Class33 class2 = (Class33)@class;
					if (class2.Image_0 != null)
					{
						Image image_ = class2.Image_0;
						int y = e.Bounds.Y + e.Bounds.Height / 2 - image_.Height / 2;
						e.Graphics.DrawImage(image_, num2, y, image_.Width, image_.Height);
						num2 += image_.Width + 2;
					}
				}
				e.Graphics.DrawString(e.SubItem.Text, e.SubItem.Font, new SolidBrush(e.SubItem.ForeColor), (float)num2, (float)num);
				return;
			}
			Class26 class3 = e.SubItem as Class26;
			if (class3 == null)
			{
				e.DrawDefault = true;
				return;
			}
			num2 = class3.vmethod_0(e, num2, base.Columns[e.ColumnIndex] as Class23);
			e.Graphics.DrawString(e.SubItem.Text, e.SubItem.Font, new SolidBrush(e.SubItem.ForeColor), (float)num2, (float)num);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0001893C File Offset: 0x00016B3C
		private void Class17_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			if (base.Items.Count == 0)
			{
				return;
			}
			for (int i = 0; i < base.Columns.Count; i++)
			{
				base.Columns[i].ImageKey = null;
			}
			for (int j = 0; j < base.Items.Count; j++)
			{
				base.Items[j].Tag = null;
			}
			if (e.Column != this.int_1)
			{
				this.int_1 = e.Column;
				base.Sorting = SortOrder.Ascending;
				base.Columns[e.Column].ImageKey = "up";
			}
			else if (base.Sorting == SortOrder.Ascending)
			{
				base.Sorting = SortOrder.Descending;
				base.Columns[e.Column].ImageKey = "down";
			}
			else
			{
				base.Sorting = SortOrder.Ascending;
				base.Columns[e.Column].ImageKey = "up";
			}
			if (this.int_1 == 0)
			{
				if (base.Items[0].GetType() == typeof(Class32))
				{
					base.ListViewItemSorter = new Class17.Class20(e.Column, base.Sorting);
					return;
				}
				base.ListViewItemSorter = new Class17.Class21(e.Column, base.Sorting);
				return;
			}
			else
			{
				if (base.Items[0].SubItems[this.int_1].GetType() == typeof(Class26))
				{
					base.ListViewItemSorter = new Class17.Class18(e.Column, base.Sorting);
					return;
				}
				base.ListViewItemSorter = new Class17.Class19(e.Column, base.Sorting);
				return;
			}
		}

		// Token: 0x04000031 RID: 49
		private ListViewItem.ListViewSubItem listViewSubItem_0;

		// Token: 0x04000032 RID: 50
		private ListViewItem listViewItem_0;

		// Token: 0x04000033 RID: 51
		private int int_0;

		// Token: 0x04000034 RID: 52
		private TextBox textBox_0;

		// Token: 0x04000035 RID: 53
		private int int_1;

		// Token: 0x04000036 RID: 54
		private Brush brush_0;

		// Token: 0x04000037 RID: 55
		private Brush brush_1;

		// Token: 0x04000038 RID: 56
		private int int_2;

		// Token: 0x04000039 RID: 57
		private static uint uint_0;

		// Token: 0x0400003A RID: 58
		private static uint uint_1;

		// Token: 0x0400003B RID: 59
		private static int int_3;

		// Token: 0x0400003C RID: 60
		private static int int_4;

		// Token: 0x0400003D RID: 61
		private static int int_5;

		// Token: 0x0400003E RID: 62
		private static int int_6;

		// Token: 0x0400003F RID: 63
		private ArrayList arrayList_0;

		// Token: 0x0200001E RID: 30
		private struct Struct2
		{
			// Token: 0x04000040 RID: 64
			internal Control control_0;

			// Token: 0x04000041 RID: 65
			internal Class28 class28_0;
		}

		// Token: 0x0200001F RID: 31
		private sealed class Class18 : IComparer
		{
			// Token: 0x060000D7 RID: 215 RVA: 0x0000294D File Offset: 0x00000B4D
			public Class18()
			{
				this.int_0 = 0;
				this.sortOrder_0 = SortOrder.Ascending;
			}

			// Token: 0x060000D8 RID: 216 RVA: 0x00002963 File Offset: 0x00000B63
			public Class18(int int_1, SortOrder sortOrder_1)
			{
				this.int_0 = int_1;
				this.sortOrder_0 = sortOrder_1;
			}

			// Token: 0x060000D9 RID: 217 RVA: 0x00018AE8 File Offset: 0x00016CE8
			public int Compare(object x, object y)
			{
				string text = ((ListViewItem)x).SubItems[this.int_0].Text;
				string text2 = ((ListViewItem)y).SubItems[this.int_0].Text;
				decimal d;
				decimal d2;
				int num;
				DateTime t;
				DateTime t2;
				if (decimal.TryParse(text, out d) && decimal.TryParse(text2, out d2))
				{
					num = decimal.Compare(d, d2);
				}
				else if (DateTime.TryParse(text, out t) && DateTime.TryParse(text2, out t2))
				{
					num = DateTime.Compare(t, t2);
				}
				else
				{
					num = string.Compare(text, text2);
				}
				if (this.sortOrder_0 == SortOrder.Descending)
				{
					num *= -1;
				}
				return num;
			}

			// Token: 0x04000042 RID: 66
			private int int_0;

			// Token: 0x04000043 RID: 67
			private SortOrder sortOrder_0;
		}

		// Token: 0x02000020 RID: 32
		private sealed class Class19 : IComparer
		{
			// Token: 0x060000DA RID: 218 RVA: 0x00002979 File Offset: 0x00000B79
			public Class19()
			{
				this.int_0 = 0;
				this.sortOrder_0 = SortOrder.Ascending;
			}

			// Token: 0x060000DB RID: 219 RVA: 0x0000298F File Offset: 0x00000B8F
			public Class19(int int_1, SortOrder sortOrder_1)
			{
				this.int_0 = int_1;
				this.sortOrder_0 = sortOrder_1;
			}

			// Token: 0x060000DC RID: 220 RVA: 0x00018B84 File Offset: 0x00016D84
			public int Compare(object x, object y)
			{
				string string_ = ((Class26)((ListViewItem)x).SubItems[this.int_0]).String_0;
				string string_2 = ((Class26)((ListViewItem)y).SubItems[this.int_0]).String_0;
				decimal d;
				decimal d2;
				int num;
				DateTime t;
				DateTime t2;
				if (decimal.TryParse(string_, out d) && decimal.TryParse(string_2, out d2))
				{
					num = decimal.Compare(d, d2);
				}
				else if (DateTime.TryParse(string_, out t) && DateTime.TryParse(string_2, out t2))
				{
					num = DateTime.Compare(t, t2);
				}
				else
				{
					num = string.Compare(string_, string_2);
				}
				if (this.sortOrder_0 == SortOrder.Descending)
				{
					num *= -1;
				}
				return num;
			}

			// Token: 0x04000044 RID: 68
			private int int_0;

			// Token: 0x04000045 RID: 69
			private SortOrder sortOrder_0;
		}

		// Token: 0x02000021 RID: 33
		private sealed class Class20 : IComparer
		{
			// Token: 0x060000DD RID: 221 RVA: 0x000029A5 File Offset: 0x00000BA5
			public Class20()
			{
				this.int_0 = 0;
				this.sortOrder_0 = SortOrder.Ascending;
			}

			// Token: 0x060000DE RID: 222 RVA: 0x000029BB File Offset: 0x00000BBB
			public Class20(int int_1, SortOrder sortOrder_1)
			{
				this.int_0 = int_1;
				this.sortOrder_0 = sortOrder_1;
			}

			// Token: 0x060000DF RID: 223 RVA: 0x00018C2C File Offset: 0x00016E2C
			public int Compare(object x, object y)
			{
				string text = ((ListViewItem)x).Text;
				string text2 = ((ListViewItem)y).Text;
				decimal d;
				decimal d2;
				int num;
				DateTime t;
				DateTime t2;
				if (decimal.TryParse(text, out d) && decimal.TryParse(text2, out d2))
				{
					num = decimal.Compare(d, d2);
				}
				else if (DateTime.TryParse(text, out t) && DateTime.TryParse(text2, out t2))
				{
					num = DateTime.Compare(t, t2);
				}
				else
				{
					num = string.Compare(text, text2);
				}
				if (this.sortOrder_0 == SortOrder.Descending)
				{
					num *= -1;
				}
				return num;
			}

			// Token: 0x04000046 RID: 70
			private int int_0;

			// Token: 0x04000047 RID: 71
			private SortOrder sortOrder_0;
		}

		// Token: 0x02000022 RID: 34
		private sealed class Class21 : IComparer
		{
			// Token: 0x060000E0 RID: 224 RVA: 0x000029D1 File Offset: 0x00000BD1
			public Class21()
			{
				this.int_0 = 0;
				this.sortOrder_0 = SortOrder.Ascending;
			}

			// Token: 0x060000E1 RID: 225 RVA: 0x000029E7 File Offset: 0x00000BE7
			public Class21(int int_1, SortOrder sortOrder_1)
			{
				this.int_0 = int_1;
				this.sortOrder_0 = sortOrder_1;
			}

			// Token: 0x060000E2 RID: 226 RVA: 0x00018CA8 File Offset: 0x00016EA8
			public int Compare(object x, object y)
			{
				string string_ = ((Class32)x).String_0;
				string string_2 = ((Class32)y).String_0;
				decimal d;
				decimal d2;
				int num;
				DateTime t;
				DateTime t2;
				if (decimal.TryParse(string_, out d) && decimal.TryParse(string_2, out d2))
				{
					num = decimal.Compare(d, d2);
				}
				else if (DateTime.TryParse(string_, out t) && DateTime.TryParse(string_2, out t2))
				{
					num = DateTime.Compare(t, t2);
				}
				else
				{
					num = string.Compare(string_, string_2);
				}
				if (this.sortOrder_0 == SortOrder.Descending)
				{
					num *= -1;
				}
				return num;
			}

			// Token: 0x04000048 RID: 72
			private int int_0;

			// Token: 0x04000049 RID: 73
			private SortOrder sortOrder_0;
		}
	}
}
