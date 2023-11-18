using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSLMan.UI;

namespace WSLMan
{
    public partial class InstallNew : Form
    {
        public InstallNew()
        {
            InitializeComponent();
        }

        public void ShowMe(ContainerControl parent)
        {
            if (parent != null) SimpleOverlay.ShowFX(parent);
            this.ShowDialog(parent);
            if (parent != null) SimpleOverlay.HideFX();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
