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
                if (distroList.SelectedItems.Count > 0)
                    return (distroList.SelectedItems[0].Tag as DistroInfo);
                else
                    return null;
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

            

            base.OnLoad(e);
        }

        private void FillDistroList(List<DistroInfo> distros)
        {
            distroList.Items.Clear();


            foreach (DistroInfo distro in distros)
            {
                ListViewItem item = new ListViewItem();
                item.Text = distro.Name;
                item.SubItems.Add(distro.State.ToString());
                item.SubItems.Add(distro.Version.ToString());
                item.Tag = distro;

                distroList.Items.Add(item);
            }

        }

        private void SelectDistroIndex(DistroInfo distro)
        {
            for (int a = 0; a < distroList.Items.Count; a++)
            {
                if ((distroList.Items[a].Tag as DistroInfo).Hash == distro.Hash)
                {
                    distroList.SelectedIndices.Clear();
                    distroList.SelectedIndices.Add(a);
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
                playButton.Enabled =    false;
                stopButton.Enabled =    false;
                configButton.Enabled =  false;
            }
            else
            {
                nameOutp.Text +=        distro.Name;
                hashOutp.Text =         distro.Hash;
                pathOutp.Text =         distro.Path;
                stateLabel.Text =       distro.State.ToString();
                versionLabel.Text =     distro.Version.ToString();
                uidLabel.Text =         distro.DefaultUid.ToString();
                playButton.Enabled =    true;
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
            string fullCommand = "-d " + CurrentDistro.Name;

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "wsl",
                Arguments = fullCommand,
                //RedirectStandardInput = true,
                UseShellExecute = false,
                CreateNoWindow = false,
                //RedirectStandardOutput = true,
                //RedirectStandardError = true
            };

            Process process = new Process { StartInfo = psi };
            process.Start();

            Println("start distro -> " + CurrentDistro.Name);
        }

        private async void OnStopPressed(object sender, EventArgs e)
        {
            string fullCommand = "--terminate " + CurrentDistro.Name;

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "wsl",
                Arguments = fullCommand,
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                StandardOutputEncoding = System.Text.Encoding.Unicode,
                StandardErrorEncoding = System.Text.Encoding.Unicode
        };

            Process process = new Process { StartInfo = psi };
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            string errors = process.StandardError.ReadToEnd();

            Println(output);

            await RefreshDistrosList();
        }

        private void OnConfigPressed(object sender, EventArgs e)
        {

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