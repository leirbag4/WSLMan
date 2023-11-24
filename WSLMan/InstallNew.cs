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
using WSLMan.UI;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WSLMan
{
    public partial class InstallNew : Form
    {
        public enum State
        { 
            None,
            Preinstalled,
            CustomPackages,
            Online,
            Browse
        }

        public State CurrState 
        {
            get 
            { 
                     if(preinstalledRDButton.Checked)   return State.Preinstalled;
                else if(customRDButton.Checked)         return State.CustomPackages;
                else if(onlineRDButton.Checked)         return State.Online;
                else if(browseRDButton.Checked)         return State.Browse;
                else return State.None;
            } 
            //set; 
        }


        public bool Error { get; private set; }
        public ErrorInfo ErrorInfo { get; private set; } = null;

        private string CustomName { get { return customNameInput.Text.Trim(); } }

        private ProgressPanel progressPanel;
        private ImportCmdProp _importCmdProp;

        private WSL wsl = null;


        public InstallNew()
        {
            InitializeComponent();
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


        private async Task RefreshDistroPreinstalled()
        {
            SimpleOverlay.ShowFX(this);

            distroList.ClearSelection();
            distroList.ClearItems();

            var distros = await wsl.ListDistrosAsync();

            if (distros != null)
            {
                foreach (var distro in distros)
                    distroList.AddItem(distro, distro.Name);
            }
            else
                Println("Can't find pre-installed distros");

            SimpleOverlay.HideFX();
        }

        private void RefreshDistroCustom()
        {
            distroList.ClearSelection();
            distroList.ClearItems();

            pathInput.Text =        SaveData.CustomPackageDirPath;
            outputPathOutp.Text =   SaveData.OutputVhdxDirPath;
            string path =           pathInput.Text.Trim();

            if (!Directory.Exists(path))
            {
                Alert("The path for the custom 'tar.gz' distros doesn't exist");
                return;
            }

            var distros = wsl.GetCustomDistroPackages();

            foreach (var distro in distros)
            {
                distroList.AddItem(distro, distro.Name);
            }
        }

        private async Task RefreshDistroOnline()
        {
            SimpleOverlay.ShowFX(this);

            distroList.ClearSelection();
            distroList.ClearItems();

            var distros = await wsl.ListOnlineDistrosAsync();

            if (distros != null)
            {
                foreach (var distro in distros)
                    distroList.AddItem(distro, distro.Name);
            }
            else
                Println("Can't find online distros");

            SimpleOverlay.HideFX();
        }

        private void RefreshDistroBrowse()
        {
            pathInput.Text = SaveData.LastPackageFilePath;
        }

        private async void OnRefreshListPressed(object sender, EventArgs e)
        {

            if (CurrState == State.Preinstalled)
            {
                await RefreshDistroPreinstalled();
            }
            else if (CurrState == State.CustomPackages)
            {
                RefreshDistroCustom();
            }
            else if (CurrState == State.Online)
            {
                await RefreshDistroOnline();
            }
        }

        private void SetState(State state)
        {
                 if(state == State.Preinstalled)    preinstalledRDButton.Checked = true; 
            else if(state == State.CustomPackages)  customRDButton.Checked = true; 
            else if(state == State.Online)          onlineRDButton.Checked = true; 
            else if(state == State.Browse)          browseRDButton.Checked = true; 
        }

        private async void OnModeCheckedChanged(object sender, EventArgs e)
        {
            State state = CurrState;

            pathInput.Text =        "";
            outputPathOutp.Text = "";
            outputPathButton.Enabled = false;

            distroList.ClearSelection();

            if (state == State.Preinstalled)
            {
                descriptionLabel.Text = "Use any of the preinstalled distros to create your new installation. Click the 'refresh list' button to check for changes.";
                refreshListButton.Enabled = true;
                pathInput.Enabled =         false;
                browseButton.Enabled =      false;
                pathContainer.Visible =     false;
                await RefreshDistroPreinstalled();
            }
            else if (state == State.CustomPackages)
            {
                descriptionLabel.Text = "Select a directory where all your distros.tar.gz are downloaded";
                refreshListButton.Enabled = true;
                pathInput.Enabled =         true;
                browseButton.Enabled =      true;
                pathContainer.Visible =     true;
                outputPathButton.Enabled =  true;
                RefreshDistroCustom();
            }
            else if (state == State.Online)
            {
                descriptionLabel.Text = "Wait for online distro list to be downloaded. Click the 'refresh list' button to check for changes.";
                refreshListButton.Enabled = true;
                pathInput.Enabled =         false;
                browseButton.Enabled =      false;
                pathContainer.Visible =     false;
                await RefreshDistroOnline();
            }
            else if (state == State.Browse)
            {
                descriptionLabel.Text = "Select a downloaded 'tag.gz' package to be used for the installation of the distro.";
                refreshListButton.Enabled = false;
                pathInput.Enabled =         true;
                browseButton.Enabled =      true;
                pathContainer.Visible =     true;
                distroList.ClearItems();
                RefreshDistroBrowse();
            }
        }

        private void OnBrowsePressed(object sender, EventArgs e)
        {

            if (CurrState == State.CustomPackages)
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

                //folderBrowserDialog.Description = "Select the directory where your 'tar.gz' distros are located";
                folderBrowserDialog.ShowNewFolderButton = false;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    pathInput.Text =                folderBrowserDialog.SelectedPath;
                    SaveData.CustomPackageDirPath = pathInput.Text;
                    SaveData.Save();
                }
            }
            else if (CurrState == State.Browse)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Filter = "Files tar.gz|*.tar.gz";
                openFileDialog.Title = "Select file tar.gz";
                openFileDialog.Multiselect = false;


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pathInput.Text =                openFileDialog.FileName;
                    SaveData.LastPackageFilePath =  pathInput.Text;
                    SaveData.Save();
                }
            }
        }

        private void OnDistroIndexChanged(object sender, EventArgs e)
        {
            DistroBase distro = distroList.GetSelectedItem<DistroBase>();

            if (distro != null)
                selectedNameLabel.Text = distro.Name;
            else
                selectedNameLabel.Text = "---";
        }

        private void OnOutputPathPressed(object sender, EventArgs e)
        {
            if (CurrState == State.CustomPackages)
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

        private void OnInstallPressed(object sender, EventArgs e)
        {
            if (CurrState == State.Preinstalled)
                InstallDistroInfo();
            else if (CurrState == State.CustomPackages)
                InstallDistroPackages();
            else if (CurrState == State.Online)
                InstallDistroOnline();
            else if (CurrState == State.Browse)
                InstallBrowse();
        }

        private void InstallDistroInfo()
        {
            DistroInfo distro = distroList.GetSelectedItem<DistroInfo>();

            Println("isa: " + distro);
        }

        

        
        

        private async void InstallDistroPackages()
        {
            DistroPackage distro = distroList.GetSelectedItem<DistroPackage>();
            string installDirPath = outputPathOutp.Text;

            if (!CheckDistro(distro))           return;
            if (!CheckName())                   return;
            if (!CheckDir(installDirPath, "output installation")) return;

            installDirPath += "\\" + CustomName;

            _importCmdProp = new ImportCmdProp() { CustomName = '"' + CustomName + '"', DestinationFolder = '"' + installDirPath + '"', InputFilename = '"' + distro.Path + '"' };

            progressPanel = new ProgressPanel();
            progressPanel.Opened += InstallDistroPackagesOpened;
            progressPanel.ShowMe(this, wsl);
            return;

            //wsl.ImportDistro('"' + CustomName + '"', '"' + installDirPath + '"', '"' + distro.Path + '"');
        }

        private async void InstallDistroPackagesOpened()
        {
            await wsl.Import(_importCmdProp.CustomName, _importCmdProp.DestinationFolder, _importCmdProp.InputFilename);

            progressPanel.SetAsFinished();
            //Alert("name:" + _importCmdProp.CustomName);
        }



        private void InstallDistroOnline()
        {
            DistroOnline distro = distroList.GetSelectedItem<DistroOnline>();

            Println("isc: " + distro);
        }

        private void InstallBrowse()
        { 
        
        }

        private bool CheckDistro(DistroBase distro)
        {
            if (distro == null)
            {
                Alert("Distro is not valid. Please select one.");
                return false;
            }
            else
                return true;
        }

        private bool CheckName()
        {
            if (CustomName == "")
            {
                Alert("Custom distro name is empty.");
                return false;
            }
            else
                return true;
        }

        private bool CheckDir(string dirPath, string name)
        {
            if (!Directory.Exists(dirPath))
            {
                Alert("Directory for '" + name + "' does not exist at\n\nPath: " + dirPath);
                return false;
            }
            else
                return true;
        }

        protected void CallError(string str)
        {
            ErrorInfo = ErrorInfo.Create(str);
            Error = true;
            PrintError(ErrorInfo);
        }

        protected void CallError(string str, Exception e)
        {
            ErrorInfo = ErrorInfo.Create(str, e);
            Error = true;
            PrintError(ErrorInfo);
        }

        protected void Print(string str)
        {
            XConsole.Print(str);
        }

        protected void Println(string str)
        {
            XConsole.Println(str);
        }

        protected void PrintError(string str)
        {
            XConsole.PrintError(str);
        }

        protected void PrintError(ErrorInfo error)
        {
            XConsole.PrintError(error);
        }

        protected void Alert(string str)
        {
            XConsole.Alert(str);
        }

        
    }
}
