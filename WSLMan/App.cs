using CommandLauncher;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using WSLMan.Distro;
using WSLMan.Properties;
using WSLMan.Register;
using WSLMan.UI;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WSLMan
{
    public partial class App : Form
    {

        private DistroInfo CurrentDistro 
        { 
            get 
            {
                return distroList.GetSelectedItem<DistroInfo>();
            } 
        }

        private bool Error { get; set; } = false;
        private ErrorInfo ErrorInfo { get; set; } = null;
        private WSL wsl;
        
        private ContextMenuStrip ctxMenuDistroList;
        private ToolStripMenuItem ctxSetDefaultItem;
        private ToolStripMenuItem ctxRemoveItem;
        private ToolStripMenuItem ctxCloneItem;
        private ToolStripMenuItem ctxOpenLocationItem;


        public App()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            SaveData.Initialize();

            XConsole.SetOutput(outp);

            wsl = new WSL();

            startButton.AssignClickableLabel(startLabel);
            stopButton.AssignClickableLabel(stopLabel);
            configButton.AssignClickableLabel(configLabel);
            createNewButton.AssignClickableLabel(createNewLabel);
            removeButton.AssignClickableLabel(removeLabel);

            distroList.MouseUp += OnDistroListMouseUp;

            InitContextMenu();

            //createNewButton.PerformClick();


            base.OnLoad(e);
        }

        private void OnDistroListMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var distro = CurrentDistro;

                if (distro != null)
                {
                    Point mousePos = distroList.PointToClient(Cursor.Position);
                    ctxMenuDistroList.Show(distroList, mousePos);
                }
            }
        }

        private void InitContextMenu()
        {
            ctxSetDefaultItem =     new ToolStripMenuItem("Set Default", Resources.ctx_tick_button_mini, OnCtxSetDefaultPressed);
            ctxRemoveItem =         new ToolStripMenuItem("Remove", Resources.ctx_remove_button_mini, OnCtxRemovePressed);
            ctxCloneItem =          new ToolStripMenuItem("Clone", Resources.ctx_duplicate_button_mini, OnCtxClonePressed);
            ctxOpenLocationItem =   new ToolStripMenuItem("Open Location", Resources.ctx_folder_button_mini, OnCtxOpenLocationPressed);

            ctxMenuDistroList =     new ContextMenuStrip();
            ctxMenuDistroList.ForeColor = Color.Silver;
            ctxMenuDistroList.Renderer = new WSLMan.UI.Renderer.ToolStripRenderer();
            
            AddDefaultContextMenuItems();
        }

        public void AddDefaultContextMenuItems()
        {
            //this.ContextMenuStrip.Items.AddRange(new ToolStripMenuItem[] { ctxDuplicateItem, new ToolStripMenuItem("-"), ctxUnregisterItem});

            ctxMenuDistroList.Items.Add(ctxSetDefaultItem);
            ctxMenuDistroList.Items.Add(ctxRemoveItem);
            ctxMenuDistroList.Items.Add(new ToolStripSeparator());
            ctxMenuDistroList.Items.Add(ctxCloneItem);
            ctxMenuDistroList.Items.Add(ctxOpenLocationItem);

        }

        private async void OnCtxSetDefaultPressed(object sender, EventArgs e)
        {
            await wsl.SetDefault(CurrentDistro.Name);
            await RefreshDistrosList();
        }

        private void OnCtxRemovePressed(object sender, EventArgs e)
        {
            OnRemovePressed(null, EventArgs.Empty);
        }

        private async void OnCtxClonePressed(object sender, EventArgs e)
        {
            



            ClonePanel clonePanel = new ClonePanel();
            clonePanel.ShowMe(this);
            string newDistroName;
            string newPath;
            string clonedFileName;

            if (clonePanel.DialogResult == DialogResult.OK)
            {
                newDistroName =     clonePanel.NewDistroName;
                newPath =           clonePanel.SelectedPath;
                clonedFileName =    CurrentDistro.Path + "_clone.tar";

                SimpleOverlay.ShowFX(this);
                await wsl.Export(CurrentDistro.Name, clonedFileName);
                await wsl.Import(newDistroName, "C:\\WSL_OUT2\\" + newDistroName, clonedFileName);
                try
                {
                    File.Delete(clonedFileName);
                    Println("File '" + clonedFileName + "' removed");
                }
                catch (Exception ex)
                {
                    CallError("Can't delete file: " + clonedFileName);
                }

                RefreshDistrosList();

                SimpleOverlay.HideFX();
                
            }
        }

        private void OnCtxOpenLocationPressed(object sender, EventArgs e)
        {
            string path = '"' + pathOutp.Text + '"';
            Process.Start("Explorer.exe", path);
        }

        private void FillDistroList(List<DistroInfo> distros)
        {
            string defaultStr;
            distroList.ClearItems();

            for (int a = 0; a < distros.Count; a++)
            {
                DistroInfo distro = distros[a];

                if (distro.Default)
                    defaultStr = " (default)";
                else
                    defaultStr = "";

                distroList.AddItem(distro, distro.Name + defaultStr, distro.State.ToString(), distro.Version.ToString());
                if (distro.Default)
                    distroList.SetBoldIndex(a, true);
            }

        }

        private void SelectDistroIndex(DistroInfo distro)
        {
            for (int a = 0; a < distroList.Items.Count; a++)
            {
                if ((distroList.Items[a].Tag as DistroInfo).Hash == distro.Hash)
                {
                    distroList.SelectByIndex(a);
                    break;
                }
            }
        }

        private void SelectDistro(DistroInfo distro)
        {
            if (distro == null)
            {
                nameOutp.Text =         "";
                hashOutp.Text =         "";
                pathOutp.Text =         "";
                stateLabel.Text =       "";
                versionLabel.Text =     "";
                uidLabel.Text =         "";
                startButton.Enabled =   false;
                stopButton.Enabled =    false;
                configButton.Enabled =  false;
                removeButton.Enabled =  false;
            }
            else
            {
                nameOutp.Text =         distro.Name;
                hashOutp.Text =         distro.Hash;
                pathOutp.Text =         distro.Path;
                stateLabel.Text =       distro.State.ToString();
                versionLabel.Text =     distro.Version.ToString();
                uidLabel.Text =         distro.DefaultUid.ToString();
                startButton.Enabled =   true;
                stopButton.Enabled =    true;
                configButton.Enabled =  true;
                removeButton.Enabled =  true;
            }
        }

        private async Task RefreshDistrosList()
        {
            List<DistroInfo> distros = await wsl.ListDistrosAsync();
            string lastSelDistroHash = "";

            if (CurrentDistro != null)
                lastSelDistroHash = CurrentDistro.Hash;

            FillDistroList(distros);

            foreach (var distro in distros)
            {
                //Println(" -> " + distro.ToString() + " Path: " + distro.Path);
                if (distro.Hash == lastSelDistroHash)
                {
                    SelectDistroIndex(distro);
                    break;
                }
            }
        }

        private async void OnListDistrosPressed(object sender, EventArgs e)
        {
            await RefreshDistrosList();

            /*var distros = await wsl.ListOnlineDistrosAsync();

            foreach (var distro in distros)
            {
                Println(distro.ToString());
            }*/
        }


        private void OnClearPressed(object sender, EventArgs e)
        {
            Clear();
        }

        private void OnDistroIndexChanged(object sender, EventArgs e)
        {
            SelectDistro(CurrentDistro);
        }

        private void OnStartPressed(object sender, EventArgs e)
        {
            wsl.StartDistro(CurrentDistro);

            Println("start distro -> " + CurrentDistro.Name);
        }

        private async void OnStopPressed(object sender, EventArgs e)
        {
            string output = wsl.StopDistro(CurrentDistro);
            
            Println(output);
            await RefreshDistrosList();
        }

        private async void OnRemovePressed(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you really want to remove '" + CurrentDistro.Name + "'?\nThis will unregister your distro and all your stored data will be deleted.", "Remove Distro", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                SimpleOverlay.ShowFX(this);
                bool unregistered = await wsl.Unregister(CurrentDistro.Name);
                if (unregistered)
                {
                    try
                    {
                        Directory.Delete(CurrentDistro.Path, true);
                    }
                    catch (Exception ex)
                    {
                        CallError("Can't delete directory '" + CurrentDistro.Path + "'", ex);
                    }
                }

                await RefreshDistrosList();
                SimpleOverlay.HideFX();                
            }
        }

        private void OnConfigPressed(object sender, EventArgs e)
        {

        }

        private void OnCreateNewPressed(object sender, EventArgs e)
        {
            InstallNew installNew= new InstallNew();
            installNew.ShowMe(this, wsl);
        }

        private void OnDistroListDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startButton.PerformClick();
            }
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


        protected void Clear()
        { 
            XConsole.Clear();
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