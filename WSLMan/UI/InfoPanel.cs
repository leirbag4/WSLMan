using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSLMan.UI
{
    public partial class InfoPanel : Form
    {

        public InfoPanel()
        {
            InitializeComponent();
        }

        public static void ShowMsg(ContainerControl parent, string title, string description, string message, int height = -1)
        {
            if (parent != null) SimpleOverlay.ShowFX(parent);

            InfoPanel panel = new InfoPanel();

            if (height != -1)
                panel.Height = height;

            panel.titleLabel.Text = title;
            panel.descriptionLabel.Text = description;
            panel.outp.Text = message;
            panel.ShowDialog(parent);

            if (parent != null) SimpleOverlay.HideFX();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void OnCloseButtonPressed(object sender, EventArgs e)
        {
            Close();
        }
    }
}
