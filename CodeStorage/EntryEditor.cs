using System;
using System.Windows.Forms;
using FarsiLibrary.Win;
using FastColoredTextBoxNS;
using Model;

namespace CodeStorage
{
    public partial class EntryEditor : UserControl
    {
        private Entry _entry;
        public Entry EntryItem
        {
            get
            {
                _entry.Category = _tbCategory.Text;
                _entry.Code = _teCode.Text;
                _entry.DateChanged = DateTime.Now;
                _entry.Description = _tbDescription.Text;
                _entry.Lang = _cbLanguage.Text;
                _entry.Name = _tbName.Text;

                EntryItem = _entry;
                return _entry;
            }
            set
            {
                _entry = value;
                _tbCategory.Text = value.Category;
                _teCode.Text = value.Code;                
                SetHighlighting = _cbLanguage.Text = value.Lang;
                _tbDescription.Text = _entry.Description;
                _tbName.Text = value.Name;

                var parent = Parent as FATabStripItem;
                if (parent != null) parent.Title = string.Format("[{0}] {1}", value.Category, value.Name);
            }
        }

        public EntryEditor()
        {
            InitializeComponent();
        }

        public EntryEditor(Entry entry)
        {
            InitializeComponent();
            EntryItem = entry;
        }


        /// <summary>
        /// Allows to set editor Highlight language
        /// </summary>
        private string SetHighlighting
        {
            set
            {
                switch (value)
                {
                    case "C#":
                        _teCode.Language = Language.CSharp;
                        break;
                    case "VB":
                        _teCode.Language = Language.VB;
                        break;
                    case "HTML":
                        _teCode.Language = Language.HTML;
                        break;
                    case "SQL":
                        _teCode.Language = Language.SQL;
                        break;
                    case "PHP":
                        _teCode.Language = Language.PHP;
                        break;
                    case "JS":
                        _teCode.Language = Language.JS;
                        break;
                    default:
                        _teCode.Language = Language.Custom;
                        break;
                }
                _teCode.OnSyntaxHighlight(new TextChangedEventArgs(_teCode.Range));
            }
        }

        private void LangTextChanged(object sender, EventArgs e)
        {
            SetHighlighting = _cbLanguage.Text;
        }

    }
}
