using CommandLauncher;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;
using WSLMan.Distro;
using WSLMan.OS;
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
        private ToolStripMenuItem ctxStartItem;
        private ToolStripMenuItem ctxStopItem;
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
            OsManager.Initialize();
            SaveData.Initialize();

            appVersionLabel.Text = "version: " + Application.ProductVersion;

            menuStrip.Renderer = new UI.Renderer.MenuStripRenderer();
            menuStrip.BackColor= Color.FromArgb(30, 30, 30);
            //menuStrip.ForeColor = Color.FromArgb(140, 140, 140);

            XConsole.SetOutput(outp);

            wsl = new WSL();

            startButton.AssignClickableLabel(startLabel);
            stopButton.AssignClickableLabel(stopLabel);
            configButton.AssignClickableLabel(configLabel);
            createNewButton.AssignClickableLabel(createNewLabel);
            removeButton.AssignClickableLabel(removeLabel);
            openLocationButton.AssignClickableLabel(openLocationLabel);

            distroList.MouseUp += OnDistroListMouseUp;

            InitContextMenu();

            //createNewButton.PerformClick();
            RefreshDistrosList();

            base.OnLoad(e);
        }

        private void MenuStrip_Paint(object? sender, PaintEventArgs e)
        {
            // Obtener el área de dibujo del MenuStrip
            Rectangle rect = new Rectangle(0, 0, menuStrip.Width, menuStrip.Height);

            // Rellenar el fondo del MenuStrip con color negro
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), rect);

            // Iterar a través de los elementos del menú para personalizar los colores
            foreach (ToolStripMenuItem item in menuStrip.Items)
            {
                // Rellenar el fondo de los elementos del menú principal con color blanco cuando están seleccionados
                if (item.Selected)
                    e.Graphics.FillRectangle(new SolidBrush(Color.White), item.Bounds);

                // Rellenar el fondo de los elementos de submenú con color verde cuando están seleccionados
                foreach (ToolStripMenuItem subItem in item.DropDownItems)
                {
                    if (subItem.Selected)
                        e.Graphics.FillRectangle(new SolidBrush(Color.Green), subItem.Bounds);
                }
            }
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
            ctxStartItem =          new ToolStripMenuItem("Start", Resources.ctx_play_button_mini, OnCtxStartPressed);
            ctxStopItem =           new ToolStripMenuItem("Stop", Resources.ctx_stop_button_mini, OnCtxStopPressed);
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

            ctxMenuDistroList.Items.Add(ctxStartItem);
            ctxMenuDistroList.Items.Add(ctxStopItem);
            ctxMenuDistroList.Items.Add(new ToolStripSeparator());
            ctxMenuDistroList.Items.Add(ctxSetDefaultItem);
            ctxMenuDistroList.Items.Add(ctxRemoveItem);
            ctxMenuDistroList.Items.Add(new ToolStripSeparator());
            ctxMenuDistroList.Items.Add(ctxCloneItem);
            ctxMenuDistroList.Items.Add(ctxOpenLocationItem);

        }

        private void OnCtxStartPressed(object sender, EventArgs e)
        {
            OnStartPressed(null, EventArgs.Empty);
        }

        private void OnCtxStopPressed(object sender, EventArgs e)
        {
            OnStopPressed(null, EventArgs.Empty);
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

                await RefreshDistrosList();

                SimpleOverlay.HideFX();
                
            }
        }

        private void OnCtxOpenLocationPressed(object sender, EventArgs e)
        {
            OnOpenLocationPressed(null, EventArgs.Empty);
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
                nameOutp.Text =                 "";
                hashOutp.Text =                 "";
                pathOutp.Text =                 "";
                stateLabel.Text =               "";
                versionLabel.Text =             "";
                uidLabel.Text =                 "";
                startButton.Enabled =           false;
                stopButton.Enabled =            false;
                configButton.Enabled =          false;
                removeButton.Enabled =          false;
                openLocationButton.Enabled =    false;
            }
            else
            {
                nameOutp.Text =                 distro.Name;
                hashOutp.Text =                 distro.Hash;
                pathOutp.Text =                 distro.Path;
                stateLabel.Text =               distro.State.ToString();
                versionLabel.Text =             distro.Version.ToString();
                uidLabel.Text =                 distro.DefaultUid.ToString();
                startButton.Enabled =           true;
                stopButton.Enabled =            true;
                configButton.Enabled =          true;
                removeButton.Enabled =          true;
                openLocationButton.Enabled =    true;
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

                bool unregistered = (await wsl.Unregister(CurrentDistro.Name)).IsOk;
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

        private void OnOpenLocationPressed(object sender, EventArgs e)
        {
            string path = '"' + pathOutp.Text + '"';
            Process.Start("Explorer.exe", path);
        }

        private void OnConfigPressed(object sender, EventArgs e)
        {
            if (CurrentDistro == null)
                return;

            ConfigPanel configPanel = new ConfigPanel();
            configPanel.ShowMe(this, wsl, CurrentDistro);
        }

        private async void OnCreateNewPressed(object sender, EventArgs e)
        {
            InstallNew installNew= new InstallNew();
            installNew.ShowMe(this, wsl);

            if(installNew.NewDistroInstalled)
                await RefreshDistrosList();
        }

        private async void OnMItemShutdownPressed(object sender, EventArgs e)
        {
            await wsl.Shutdown();
        }

        private void OnMItemGithubPressed(object sender, EventArgs e)
        {
            try
            {
                string url = "https://github.com/leirbag4/WSLMan";
                Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
            }
            catch (Exception ex)
            {
                PrintError("Can't open url");
            }
        }

        private void OnMItemAboutPressed(object sender, EventArgs e)
        {
            AboutPanel aboutPanel = new AboutPanel();
            aboutPanel.ShowMe(this);
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