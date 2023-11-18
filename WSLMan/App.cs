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

        private void OnFindInstalledDistros(object sender, EventArgs e)
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

        private async void OnListDistrosPressed(object sender, EventArgs e)
        {
            List<DistroInfo> distros = await wsl.ListDistrosAsync();

            foreach (var distro in distros)
            {
                Println(" -> " + distro.ToString() + " Path: " + distro.Path);
            }
        }

        private void OnReadListPressed(object sender, EventArgs e)
        {
            foreach (var distro in wsl.Distros)
            {
                Println(" -> " + distro.ToString());
            }
        }

        private void OnClearPressed(object sender, EventArgs e)
        {
            Clear();
        }

        private void OnListRegistryPressed(object sender, EventArgs e)
        {
            var distros = RegDistroLister.GetAll();

            foreach(var distro in distros) 
            {
                Println(distro.ToString());
            }

        }
    }
}