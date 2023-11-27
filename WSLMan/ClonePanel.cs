using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSLMan.UI;

namespace WSLMan
{
    public partial class ClonePanel : Form
    {
        public string NewDistroName { get; private set; }
        public string SelectedPath { get; private set; }

        public ClonePanel()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            outputPathOutp.Text = SaveData.OutputVhdxDirPath;
            //DialogResult = DialogResult.Cancel;
            base.OnLoad(e);
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

        private bool CheckName()
        {
            if (newDistroNameInput.Text.Trim() == "")
            {
                XConsole.Alert("Custom distro name is empty.");
                return false;
            }
            else
                return true;
        }

        private bool CheckDir(string dirPath, string name)
        {
            if (!Directory.Exists(dirPath))
            {
                XConsole.Alert("Directory for '" + name + "' does not exist at\n\nPath: " + dirPath);
                return false;
            }
            else
                return true;
        }

        private void OnClonePressed(object sender, EventArgs e)
        {
            string installDirPath = outputPathOutp.Text;

            if (!CheckName()) return;
            if (!CheckDir(installDirPath, "output installation")) return;

            NewDistroName = newDistroNameInput.Text.Trim();
            SelectedPath = outputPathOutp.Text.Trim();
            DialogResult = DialogResult.OK;
        }

        private void OnCancelPressed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnOutputPathPressed(object sender, EventArgs e)
        {
            
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            folderBrowserDialog.ShowNewFolderButton = false;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                outputPathOutp.Text = folderBrowserDialog.SelectedPath;
                SaveData.OutputVhdxDirPath = outputPathOutp.Text;
                SaveData.Save();
            }
            
        }
    }
}
