using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSLMan.Commands.Props;
using WSLMan.Distro;
using WSLMan.OS;
using WSLMan.UI;

namespace WSLMan
{
    public partial class EditPanel : Form
    {
        public OS.OS SelectedOS { get { return osList.SelectedItem as OS.OS; } }

        private WSL wsl;
        private DistroInfo distro;
        private ProgressPanel progressPanel;
        
        public EditPanel()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            osList.Items.AddRange(OsManager.operativeSystems.ToArray());
            osList.SelectedIndex= 0;

            base.OnLoad(e);
        }

        public void ShowMe(ContainerControl parent, WSL wsl, DistroInfo distro)
        {
            this.wsl =      wsl;
            this.distro =   distro;

            this.distroName.Text = distro.Name;

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


        private void OnSetUserPressed(object sender, EventArgs e)
        {
            string user = usernameInput.Text.Trim();
            string pass = passwordInput.Text.Trim();

            progressPanel = new ProgressPanel();
            progressPanel.Opened += OnCreateNewUser;
            progressPanel.ShowMe(this, "User add", "Creating new user '" + user + "' on " + distro.Name + ".\nPlease wait...");
        
        }
        private void OnOsListChanged(object sender, EventArgs e)
        {
            OsId osId = SelectedOS.Id;

            if (osId == OsId.OtherLinux)
                infoLabel.Text = "Works fine on maybe most distros for user creation. If doesn't work, try any other option.";
            else if (osId == OsId.Debian)
                infoLabel.Text = "Works well on Debian distro for user creation. If doesn't work, try 'Other Linux'";
            else if (osId == OsId.Ubuntu)
                infoLabel.Text = "Works well on Ubuntu distro for user creation. If doesn't work, try 'Other Linux'";
            else if (osId == OsId.Alpine)
                infoLabel.Text = "Works fine on some simple Alpine versions for user creation. If doesn't work, use 'Alpine (other)'";
            else if (osId == OsId.AlpineOther)
                infoLabel.Text = "Works fine on some different Alpine versions for user creation. If doesn't work, use 'Alpine'";

        }

        private async void OnCreateNewUser()
        {
            string user = usernameInput.Text.Trim();
            string pass = passwordInput.Text.Trim();

            OsId osId = SelectedOS.Id;

            await wsl.CreateUser(distro.Name, user, osId);
            progressPanel.SetProgress(0.3f);
            await wsl.SetUserPassword(distro.Name, user, pass, osId);
            progressPanel.SetProgress(0.6f);
            await wsl.AddUserToGroups(distro.Name, user, new string[] { SudoOrWheel(osId) }, osId);
            progressPanel.SetProgress(0.8f);

            if (defaultUserLoginCKBox.Checked)
            { 
                await wsl.WriteTextFile(distro.Name, "[user]\\ndefault = " + user, "/etc/wsl.conf", osId);
            }

            progressPanel.SetAsFinished();
        }

        private string SudoOrWheel(OsId id)
        {
            if ((id == OsId.Alpine) || (id == OsId.AlpineOther))
                return "wheel";
            else
                return "sudo";
        }

        
    }
}
