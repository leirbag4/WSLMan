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

            FillDistroList(distros);
        }


        private void OnClearPressed(object sender, EventArgs e)
        {
            Clear();
        }

    }
}