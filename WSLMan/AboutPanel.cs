using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSLMan.UI;
using WSLMan.Utils;

namespace WSLMan
{
    public partial class AboutPanel : Form
    {
        public AboutPanel()
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

        protected override void OnLoad(EventArgs e)
        {
            appVersionLabel.Text = "version: " + VersionHelper.GetVersion();

            base.OnLoad(e);
        }

        private void OnClosePressed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnGithubLinkPressed(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string url = "https://github.com/leirbag4/WSLMan";
                Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
            }
            catch (Exception ex)
            {
                XConsole.Alert("Can't open url");
            }
        }
    }
}
