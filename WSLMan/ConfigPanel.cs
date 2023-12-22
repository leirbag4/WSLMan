using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSLMan.Commands.Props;
using WSLMan.Distro;
using WSLMan.OS;
using WSLMan.Save;
using WSLMan.UI;

namespace WSLMan
{
    public partial class ConfigPanel : Form
    {

        private WSL wsl;

        public ConfigPanel()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            versionLabel.Text = Application.ProductVersion;
            showConsoleWarnings.Checked = SaveData.ShowWarnings;

            base.OnLoad(e);
        }

        public void ShowMe(ContainerControl parent, WSL wsl)
        {
            this.wsl = wsl;

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

        private void OnResetConfigFilePressed(object sender, EventArgs e)
        {
            SaveData.CreateNew();
            SaveData.Save();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            SaveData.ShowWarnings = showConsoleWarnings.Checked;

            SaveData.Save();

            base.OnClosing(e);
        }


    }
}
