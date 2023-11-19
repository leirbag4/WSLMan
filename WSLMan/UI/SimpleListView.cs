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

        public void ClearSelection()
        { 
            SelectedItems.Clear();
        }

        public SimpleListView()
        {
            BackColor =     Color.FromArgb(50, 50, 50);
            ForeColor =     Color.White;
            View =          View.Details;
            MultiSelect =   false;
            FullRowSelect = true;
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

    }
}
