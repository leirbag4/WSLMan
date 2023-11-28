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
            BrowseSingle
        }

        public State CurrState 
        {
            get 
            { 
                     if(preinstalledRDButton.Checked)   return State.Preinstalled;
                else if(customRDButton.Checked)         return State.CustomPackages;
                else if(onlineRDButton.Checked)         return State.Online;
                else if(browseRDButton.Checked)         return State.BrowseSingle;
                else return State.None;
            } 
            //set; 
        }

        public bool NewDistroInstalled { get; private set; } = false;

        public bool Error { get; private set; }
        public ErrorInfo ErrorInfo { get; private set; } = null;

        private string NewDistroName { get { return newDistroNameInput.Text.Trim(); } }

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
            this.NewDistroInstalled = false;

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

            outputPathOutp.Text = SaveData.OutputCloneVhdxDirPath;

            var distros = (await wsl.ListDistrosAsync()).distros;

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

            var distros = (await wsl.ListOnlineDistrosAsync()).distros;

            if (distros != null)
            {
                foreach (var distro in distros)
                    distroList.AddItem(distro, distro.Name);
            }
            else
                Println("Can't find online distros");

            SimpleOverlay.HideFX();
        }

        private void RefreshDistroBrowseSingle()
        {
            distroList.ClearItems();

            pathInput.Text =        SaveData.LastPackageFilePath;
            outputPathOutp.Text =   SaveData.OutputBrowseSingleVhdxDirPath;

            string distroFileName = pathInput.Text;

            if (pathInput.Text != "")
            {
                if (File.Exists(distroFileName))
                {
                    DistroPackage distroPackage = new DistroPackage(Path.GetFileName(distroFileName), distroFileName);
                    distroList.AddItem(distroPackage, distroPackage.Name);
                    distroList.SelectByIndex(0);
                }
                else
                {
                    var result = MessageBox.Show("Package '" + pathInput.Text + "' does not exist anymore.\n\nDo you want to delete the record from the list?", "Can't find package", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        pathInput.Text = "";
                        SaveData.LastPackageFilePath = "";
                        SaveData.Save();
                    }
                }
            }

            //DistroPackage distro = distroList.GetSelectedItem<DistroPackage>();
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
            else if(state == State.BrowseSingle)          browseRDButton.Checked = true; 
        }

        private void SetNewNameEnable(bool enable)
        {
            newDistroLabel.ForeColor = enable ? Color.SlateBlue : Color.DimGray;
            newDistroNameInput.Enabled = enable;
        }

        private void SetOutPathEnable(bool enable)
        { 
            outputPathLabel.ForeColor = enable ? Color.SlateBlue : Color.DimGray;
            outputPathOutp.Enabled =    enable;
            outputPathButton.Enabled =  enable;
        }

        private async void OnModeCheckedChanged(object sender, EventArgs e)
        {
            State state = CurrState;

            pathInput.Text =        "";
            outputPathOutp.Text = "";
            distroList.Enabled = true;
            SetOutPathEnable(false);

            distroList.ClearSelection();

            

            if (state == State.Preinstalled)
            {
                descriptionLabel.Text =         "Use any of the preinstalled distros to create your new installation. Click the 'refresh list' button to check for changes.";
                refreshListButton.Enabled =     true;
                pathInput.Enabled =             false;
                browseButton.Enabled =          false;
                pathContainer.Visible =         false;
                SetOutPathEnable(true);
                SetNewNameEnable(true);
                await RefreshDistroPreinstalled();
            }
            else if (state == State.CustomPackages)
            {
                descriptionLabel.Text = "Select a directory where all your distros.tar.gz are downloaded";
                refreshListButton.Enabled =     true;
                pathInput.Enabled =             true;
                browseButton.Enabled =          true;
                pathContainer.Visible =         true;
                SetOutPathEnable(true);
                SetNewNameEnable(true);
                RefreshDistroCustom();
            }
            else if (state == State.Online)
            {
                descriptionLabel.Text = "Wait for online distro list to be downloaded. Click the 'refresh list' button to check for changes.";
                refreshListButton.Enabled =     true;
                pathInput.Enabled =             false;
                browseButton.Enabled =          false;
                pathContainer.Visible =         false;
                SetNewNameEnable(false);
                await RefreshDistroOnline();
            }
            else if (state == State.BrowseSingle)
            {
                descriptionLabel.Text = "Select a downloaded 'tag.gz' package to be used for the installation of the distro.";
                refreshListButton.Enabled =     false;
                pathInput.Enabled =             true;
                browseButton.Enabled =          true;
                pathContainer.Visible =         true;
                SetOutPathEnable(true);
                SetNewNameEnable(true);
                distroList.ClearItems();
                distroList.Enabled = false;
                RefreshDistroBrowseSingle();
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
                    RefreshDistroCustom();
                }
            }
            else if (CurrState == State.BrowseSingle)
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

                    RefreshDistroBrowseSingle();
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
            if (CurrState == State.Preinstalled)
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

                folderBrowserDialog.ShowNewFolderButton = false;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    outputPathOutp.Text = folderBrowserDialog.SelectedPath.Trim();
                    SaveData.OutputCloneVhdxDirPath = outputPathOutp.Text;
                    SaveData.Save();
                }

            }
            else if (CurrState == State.CustomPackages)
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

                folderBrowserDialog.ShowNewFolderButton = false;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    outputPathOutp.Text = folderBrowserDialog.SelectedPath.Trim();
                    SaveData.OutputVhdxDirPath = outputPathOutp.Text;
                    SaveData.Save();
                }
            }
            else if (CurrState == State.BrowseSingle)
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

                folderBrowserDialog.ShowNewFolderButton = false;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    outputPathOutp.Text = folderBrowserDialog.SelectedPath.Trim();
                    SaveData.OutputBrowseSingleVhdxDirPath = outputPathOutp.Text;
                    SaveData.Save();
                }
            }
        }

        private void OnInstallPressed(object sender, EventArgs e)
        {
            if (CurrState == State.Preinstalled)
                InstallDistroPreinstalled();
            else if (CurrState == State.CustomPackages)
                InstallDistroPackages();
            else if (CurrState == State.Online)
                InstallDistroOnline();
            else if (CurrState == State.BrowseSingle)
                InstallBrowseSingle();
        }

        private async void InstallDistroPreinstalled()
        {
            DistroInfo distro = distroList.GetSelectedItem<DistroInfo>();
            string installDirPath = outputPathOutp.Text;

            if (!CheckDistro(distro)) return;
            if (!CheckName()) return;
            if (!CheckDir(installDirPath, "output installation")) return;

            var result = MessageBox.Show("You are going to make a clone of '" + distro.Name + "'.\nThe new distro '" + NewDistroName + "' will have a copy of all the original distro's content.\nYou can opt to create a clean one using the 'Online' installation mode.\n\nDo you want to continue anyway?", "Clone distro", MessageBoxButtons.OKCancel);

            string clonedFileName = distro.Path + "_clone.tar";
            string newDistroName =  NewDistroName;
            installDirPath += "\\" + NewDistroName;

            if(result == DialogResult.OK)
            { 

                progressPanel = new ProgressPanel();
                progressPanel.Opened += async () => {

                    await wsl.Export(distro.Name, clonedFileName);
                    progressPanel.SetProgress(0.4f);
                    await wsl.Import(NewDistroName, installDirPath, clonedFileName);
                    progressPanel.SetProgress(0.7f);

                    try
                    {
                        File.Delete(clonedFileName);
                        Println("File '" + clonedFileName + "' removed");
                    }
                    catch (Exception ex)
                    {
                        CallError("Can't delete file: " + clonedFileName);
                    }
                    progressPanel.SetProgress(0.8f);

                    //await RefreshDistrosList();
                    await RefreshDistroPreinstalled();

                    XConsole.Println("clone complete");
                    progressPanel.SetAsFinished();
                    NewDistroInstalled = true;
                };

                progressPanel.ShowMe(this, "Clone Distro", "Cloning distro '" + distro.Name + "' to a new one called '" + newDistroName + "'\nInstallation path: " + installDirPath);

            }
        }

        

        
        

        private async void InstallDistroPackages()
        {
            DistroPackage distro = distroList.GetSelectedItem<DistroPackage>();
            string installDirPath = outputPathOutp.Text;

            if (!CheckDistro(distro))           return;
            if (!CheckName())                   return;
            if (!CheckDir(installDirPath, "output installation")) return;

            installDirPath += "\\" + NewDistroName;

            //_importCmdProp = new ImportCmdProp() { CustomName = '"' + NewDistroName + '"', DestinationFolder = '"' + installDirPath + '"', InputFilename = '"' + distro.Path + '"' };
            _importCmdProp = new ImportCmdProp() { CustomName = NewDistroName, DestinationFolder = installDirPath, InputFilename = distro.Path };

            progressPanel = new ProgressPanel();
            progressPanel.Opened += InstallDistroPackagesOpened;
            progressPanel.ShowMe(this, "Install New Distro", "Installing distro '" + _importCmdProp.CustomName + "' from a tar.gz package.\nPlease be patient. Installing will complete as soon as possible...");
            
            //wsl.ImportDistro('"' + CustomName + '"', '"' + installDirPath + '"', '"' + distro.Path + '"');
        }

        private async void InstallDistroPackagesOpened()
        {
            await wsl.Import(_importCmdProp.CustomName, _importCmdProp.DestinationFolder, _importCmdProp.InputFilename);

            progressPanel.SetAsFinished();
            NewDistroInstalled = true;
            //Alert("name:" + _importCmdProp.CustomName);
        }



        private void InstallDistroOnline()
        {
            DistroOnline distro = distroList.GetSelectedItem<DistroOnline>();

            wsl.InstallDistro(distro.Name);
            NewDistroInstalled = true;
        }

        private void InstallBrowseSingle()
        { 
            DistroPackage distro = distroList.GetSelectedItem<DistroPackage>();
            string installDirPath = outputPathOutp.Text;

            if (!CheckDistro(distro))           return;
            if (!CheckName())                   return;
            if (!CheckDir(installDirPath, "output installation")) return;

            installDirPath += "\\" + NewDistroName;

            //_importCmdProp = new ImportCmdProp() { CustomName = NewDistroName, DestinationFolder = installDirPath, InputFilename = distro.Path };

            progressPanel = new ProgressPanel();
            progressPanel.Opened += async () => {
                
                await wsl.Import(NewDistroName, installDirPath, distro.Path);
                progressPanel.SetAsFinished();
                NewDistroInstalled = true;
            };

            progressPanel.ShowMe(this, "Install New Distro", "Installing distro '" + NewDistroName + "' from a tar.gz package.\nPlease be patient. Installing will complete as soon as possible...");
            
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
            if (NewDistroName == "")
            {
                Alert("New distro name is empty.");
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
