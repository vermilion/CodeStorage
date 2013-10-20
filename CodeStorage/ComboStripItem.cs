using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace CodeStorage
{
    [//ToolboxBitmap("image path or use another overload..."),
     ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.MenuStrip |
                                       ToolStripItemDesignerAvailability.ContextMenuStrip |
                                       ToolStripItemDesignerAvailability.StatusStrip)]
    public class ComboStripItem : ToolStripControlHost
    {
        private ComboBox combo;

        public ComboStripItem()
            : base(new ComboBox())
        {
            this.combo = this.Control as ComboBox;
        }

        public ComboBox Combo
        {
            get { return combo; }
            set { combo = value; }
        }
    }
}
