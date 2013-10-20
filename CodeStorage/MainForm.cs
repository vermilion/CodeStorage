using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Model;

namespace CodeStorage
{
    public partial class MainForm : Form
    {
        private readonly Repository _repository;

        public delegate void SelectedIndexChangedEventHandler(object item);
        public event SelectedIndexChangedEventHandler Changed;

        public MainForm()
        {
            InitializeComponent();
            //File.WriteAllText("repo.db4o", "");
            _repository = new Repository("repo.db4o");
            PupulateTreeView(myListView1, _repository.GetAll<Entry>());

            Changed += MainFormChanged;            
        }

        void MainFormChanged(object item)
        {
            PupulateTreeView(myListView1, _repository.GetAll<Entry>());
        }

        private static void PupulateTreeView(ListView listView, IEnumerable<Entry> list)
        {            
            listView.Items.Clear();
            listView.Groups.Clear();
            
            list
                .Select(x => x.Category)
                .OrderBy(x => x)
                .Distinct()
                .ToList()
                .ForEach(x => listView.Groups.Add
                                  (
                                      new ListViewGroup(x, x)
                                  ));
            
            foreach (Entry x in list.OrderBy(x => x.Name).ToList())
            {
                var item = new ListViewItem(x.Name, 1, listView.Groups[x.Category])
                {
                    Tag = x
                };
                item.SubItems.AddRange(new[]
                    {
                        x.Lang,
                        x.Description
                    });
                listView.Items.Add(item);
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            var entry = new Entry
                {
                    Name = "Empty",
                    Category = "New"
                };
            _repository.Save(entry);
            Changed(null);
        }

        private void MyListView1SelectedIndexChanged(object sender, EventArgs e)
        {
            if (myListView1.SelectedItems.Count == 0) return;
            var item = myListView1.SelectedItems[0];

            entryView1.Add((Entry)item.Tag);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            _repository.Save(entryView1.CurrentEntry);
            Changed(null);
        }

        private void deleteToolStripButton_Click(object sender, System.EventArgs e)
        {
            if (myListView1.SelectedItems.Count == 0) return;
            var item = (Entry) myListView1.SelectedItems[0].Tag;
            _repository.Delete(item);
            Changed(null);
        }

    }
}
