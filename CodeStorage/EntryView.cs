using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FarsiLibrary.Win;
using Model;

namespace CodeStorage
{
    public partial class EntryView : UserControl
    {
        private readonly Dictionary<int, Entry> _storedEntries; 

        public EntryView()
        {
            InitializeComponent();
            _storedEntries = new Dictionary<int, Entry>();
        }

        public IEnumerator<Entry> GetEnumerator()
        {
            return _storedEntries.Values.GetEnumerator();
        }

        public void Add(Entry item)
        {
            var itemHash = item.GetHashCode();

            foreach (FATabStripItem fatab in faTabStrip1.Items)
            {
                if (Convert.ToInt32(fatab.Tag) == itemHash)
                {
                    faTabStrip1.SelectedItem = fatab;
                    return;
                }
            }
            
            _storedEntries.Add(itemHash, item);
            var tab = new FATabStripItem
                {
                    Tag = itemHash,
                    Title = string.Format("[{0}] {1}", item.Category, item.Name)
                };
            tab.Controls.Add(new EntryEditor(item)
                {
                    Name = "EntryEditor",
                    Dock = DockStyle.Fill
                });
            faTabStrip1.AddTab(tab, true);
        }

        public void Clear()
        {
            _storedEntries.Clear();
        }

        public bool Remove(Entry item)
        {
            return _storedEntries.Remove(item.GetHashCode());
        }

        public bool Contains(Entry item)
        {
            return _storedEntries.ContainsValue(item);
        }

        public Entry CurrentEntry
        {
            get
            {
                var control = faTabStrip1.SelectedItem.Controls.Find("EntryEditor", false)[0] as EntryEditor;
                return control == null ? null : control.EntryItem;
            }
        }

        private void FaTabStrip1TabStripItemClosing(TabStripItemClosingEventArgs e)
        {
            _storedEntries.Remove(Convert.ToInt32(e.Item.Tag));
        }
    }
}
