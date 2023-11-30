using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSLMan.UI
{
    public class SimpleListView : ListView
    {

        public ListViewItem SelectedItem 
        {
            get 
            {
                if (SelectedItems.Count > 0)
                    return SelectedItems[0];
                else
                    return null;
            }
            
            //set; 
        }

        private Dictionary<int, int> _columnsVisibility = new Dictionary<int, int>(); // <columnIndex, columnWidth>

        public SimpleListView()
        {
            BackColor =     Color.FromArgb(50, 50, 50);
            ForeColor =     Color.White;
            View =          View.Details;
            MultiSelect =   false;
            FullRowSelect = true;
        }

        public void ClearSelection()
        {
            SelectedItems.Clear();
        }

        public T GetSelectedItem<T>()
        {
            if (SelectedItems.Count > 0)
                return (T)(SelectedItems[0].Tag);
            else
                return default;
        }

        public void SelectByIndex(int index)
        {
            SelectedIndices.Clear();
            SelectedIndices.Add(index);
        }

        public void ClearItems()
        {
            Items.Clear();
        }


        public void SetColumnVisibility(int[] columnIndices, bool visible)
        { 
            foreach(var index in columnIndices)
                SetColumnVisibility(index, visible);
        }

        public void SetColumnVisibility(int index, bool visible)
        {
            
            if (_columnsVisibility.ContainsKey(index))
            {
                

                if (visible)
                {
                    Columns[index].Width = _columnsVisibility[index];
                }
                else
                {
                    _columnsVisibility[index] = Columns[index].Width;
                    Columns[index].Width =      0;
                }
            }
            else
            {
                if (visible)
                { }
                else
                {
                    _columnsVisibility.Add(index, Columns[index].Width);
                    Columns[index].Width = 0;
                }
            }
            
        }

        public void SetBoldIndex(int index, bool active)
        {
            if (index < Items.Count)
            {
                if(active)
                    Items[index].Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                else
                    Items[index].Font = Font;
            }
        }

        public void SetColorIndex(int index, Color color)
        {
            if (index < Items.Count)
                Items[index].ForeColor = color;
        }

        public void AddItem(object obj, string col0)
        {
            ListViewItem item = new ListViewItem();
            item.Tag =  obj;
            item.Text = col0;
            Items.Add(item);
        }

        public void AddItem(object obj, string col0, string col1)
        {
            ListViewItem item = new ListViewItem();
            item.Tag =  obj;
            item.Text = col0;
            item.SubItems.Add(col1);
            Items.Add(item);
        }

        public void AddItem(object obj, string col0, string col1, string col2)
        {
            ListViewItem item = new ListViewItem();
            item.Tag =  obj;
            item.Text = col0;
            item.SubItems.Add(col1);
            item.SubItems.Add(col2);
            Items.Add(item);
        }

        public void AddItem(object obj, string col0, string col1, string col2, string col3)
        {
            ListViewItem item = new ListViewItem();
            item.Tag =  obj;
            item.Text = col0;
            item.SubItems.Add(col1);
            item.SubItems.Add(col2);
            item.SubItems.Add(col3);
            Items.Add(item);
        }

        public void AddItem(object obj, string col0, string col1, string col2, string col3, string col4)
        {
            ListViewItem item = new ListViewItem();
            item.Tag =  obj;
            item.Text = col0;
            item.SubItems.Add(col1); item.SubItems.Add(col2); item.SubItems.Add(col3); item.SubItems.Add(col4);
            Items.Add(item);
        }
        public void AddItem(object obj, string col0, string col1, string col2, string col3, string col4, string col5)
        {
            ListViewItem item = new ListViewItem();
            item.Tag = obj;
            item.Text = col0;
            item.SubItems.Add(col1); item.SubItems.Add(col2); item.SubItems.Add(col3); item.SubItems.Add(col4);
            item.SubItems.Add(col5);
            Items.Add(item);
        }

        public void AddItem(object obj, string col0, string col1, string col2, string col3, string col4, string col5, string col6)
        {
            ListViewItem item = new ListViewItem();
            item.Tag = obj;
            item.Text = col0;
            item.SubItems.Add(col1); item.SubItems.Add(col2); item.SubItems.Add(col3); item.SubItems.Add(col4);
            item.SubItems.Add(col5); item.SubItems.Add(col6);
            Items.Add(item);
        }

        public void AddItem(object obj, string col0, string col1, string col2, string col3, string col4, string col5, string col6, string col7)
        {
            ListViewItem item = new ListViewItem();
            item.Tag = obj;
            item.Text = col0;
            item.SubItems.Add(col1); item.SubItems.Add(col2); item.SubItems.Add(col3); item.SubItems.Add(col4);
            item.SubItems.Add(col5); item.SubItems.Add(col6); item.SubItems.Add(col7);
            Items.Add(item);
        }
    }
}
