using CommandLauncher;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using WSLMan.Register;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WSLMan
{
    public partial class App : Form
    {

        private DistroInfo CurrentDistro 
        { 
            get 
            {
                return distroList2.GetSelectedItem<DistroInfo>();
            } 
        }

        private WSL wsl;

        public App()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            XConsole.Setup(outp);

            wsl = new WSL();

            startButton.AssignClickableLabel(startLabel);
            stopButton.AssignClickableLabel(stopLabel);
            configButton.AssignClickableLabel(configLabel);
            createNewButton.AssignClickableLabel(createNewLabel);


            createNewButton.PerformClick();

            base.OnLoad(e);
        }

        private void FillDistroList(List<DistroInfo> distros)
        {
            distroList2.ClearItems();

            foreach (DistroInfo distro in distros)
            {
                distroList2.AddItem(distro, distro.Name, distro.State.ToString(), distro.Version.ToString());
            }

        }

        private void SelectDistroIndex(DistroInfo distro)
        {
            for (int a = 0; a < distroList2.Items.Count; a++)
            {
                if ((distroList2.Items[a].Tag as DistroInfo).Hash == distro.Hash)
                {
                    distroList2.SelectByIndex(a);
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
                startButton.Enabled =    false;
                stopButton.Enabled =    false;
                configButton.Enabled =  false;
            }
            else
            {
                nameOutp.Text =         distro.Name;
                hashOutp.Text =         distro.Hash;
                pathOutp.Text =         distro.Path;
                stateLabel.Text =       distro.State.ToString();
                versionLabel.Text =     distro.Version.ToString();
                uidLabel.Text =         distro.DefaultUid.ToString();
                startButton.Enabled =    true;
                stopButton.Enabled =    true;
                configButton.Enabled =  true;
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

        private void OnConfigPressed(object sender, EventArgs e)
        {

        }

        private void OnCreateNewPressed(object sender, EventArgs e)
        {
            InstallNew installNew= new InstallNew();
            installNew.ShowMe(this, wsl);
        }

        private void Println(string str)
        {
            XConsole.Println(str);
        }

        private void Clear()
        {
            XConsole.Clear();
        }

        private void Alert(string str)
        {
            XConsole.Alert(str);
        }

        
    }
}