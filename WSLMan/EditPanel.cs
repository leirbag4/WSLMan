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
using WSLMan.UI;

namespace WSLMan
{
    public partial class EditPanel : Form
    {
        public OS.OS SelectedOS { get { return osList.SelectedItem as OS.OS; } }

        public UserInfoProp CurrentSelectedUser { get { return userList.GetSelectedItem<UserInfoProp>(); } }

        private WSL wsl;
        private DistroInfo distro;
        private ProgressPanel progressPanel;
        
        public EditPanel()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            selectedUserLabel.Text = "";
            osList.Items.AddRange(OsManager.operativeSystems.ToArray());
            osList.SelectedIndex= 0;
            columnFilterCBox.SelectedIndex = 0;

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

        private void FillUsersList(UserInfoProp[] users, bool includeNonUsers)
        {
            userList.ClearItems();
            
            foreach (UserInfoProp user in users) 
            {
                if(includeNonUsers || (!includeNonUsers && user.IsUser()))
                    userList.AddItem(user, user.username, user.password, user.uid, user.gid, user.userDescription, user.homeDirectory, user.shell);
            }
        }

        private async void OnRefreshUserListPressed(object sender, EventArgs e)
        {
            SimpleOverlay.ShowFX(this);

            OsId osId = SelectedOS.Id;
            bool incNonUsers = includeNonUsersCKBox.Checked;

            // check if distro was running now.
            // if it wasn't, after getting user list, just stop it
            // to leave it as it was because getting the users will start the distro
            var lastStateRunning = (await GetDistroState(distro)) == DistroState.RUNNING;

            var result = await wsl.GetUsers(distro.Name, osId);

            // if the distro was running before on a window,
            // do not stop it because we can lose user data
            if (!lastStateRunning)
                await wsl.StopDistro(distro);

            FillUsersList(result.Users, incNonUsers);

            SimpleOverlay.HideFX();
        }

        private void OnColumnFilterChanged(object sender, EventArgs e)
        {
            string sel = columnFilterCBox.SelectedItem.ToString();

            if (sel == "summary")
            {
                userList.SetColumnVisibility(new int[] { 1, 2, 3, 4 }, false);

            }
            else if (sel == "detailed")
            {
                userList.SetColumnVisibility(new int[] { 1, 2, 3, 4 }, true);
            }

        }

        private void OnIncludedNonUsersChanged(object sender, EventArgs e)
        {
            OnRefreshUserListPressed(null, EventArgs.Empty);
        }

        private async Task<DistroState> GetDistroState(DistroInfo distro)
        {
            var result =    await wsl.ListDistrosAsync();
            var selDistro = result.GetDistro(distro);
            return selDistro.State;
        }

        private async void OnSetDefaultUserPressed(object sender, EventArgs e)
        {
            string username = selectedUserLabel.Text;
            OsId osId = SelectedOS.Id;

            progressPanel = new ProgressPanel();
            progressPanel.Opened += async () => {

                var lastStateRunning = (await GetDistroState(distro)) == DistroState.RUNNING;
                
                progressPanel.SetProgress(0.3f);

                await wsl.WriteTextFile(distro.Name, "[user]\\ndefault = " + username, "/etc/wsl.conf", osId);
                progressPanel.SetProgress(0.4f);


                // if distro was opened and running before on a window for example
                // let the user select if he want to close and restart the distro
                // in order to lose or not his work
                if (lastStateRunning)
                {
                    var dialogResult = MessageBox.Show("Current distro '" + distro.Name + "' is in RUNNING satate.\nDefault user is '" + username + "' now but changes will be applied after restart.\nDo you want to restart it?", "Restart distro?", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        progressPanel.SetProgress(0.5f);
                        await wsl.StopDistro(distro);
                        progressPanel.SetProgress(0.7f);
                        wsl.StartDistro(distro);
                    }
                }
                // distro was not running before, so we can stop it without telling 
                // to the user
                else
                {
                    progressPanel.SetProgress(0.5f);
                    await wsl.StopDistro(distro);
                }

                progressPanel.SetAsFinished();
            };
            progressPanel.ShowMe(this, "Default User", "Creating default user at file /etc/wsl.conf '" + username + "' on " + distro.Name + ".\nPlease wait...");
        }

        private void OnUserSelectedChanged(object sender, EventArgs e)
        {
            if (CurrentSelectedUser != null)
            {
                selectedUserLabel.Text = CurrentSelectedUser.username;
                setDefaultUserButton.Enabled = true;
            }
            else
            {
                selectedUserLabel.Text = "";
                setDefaultUserButton.Enabled = false;
            }
        }
    }
}
