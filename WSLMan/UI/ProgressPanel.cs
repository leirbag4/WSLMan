using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSLMan.UI
{
    public partial class ProgressPanel : Form
    {

        public delegate void OpenEvent();

        public event OpenEvent Opened;
        private bool _finished = false; 


        public float Progress 
        { 
            set 
            {
                if (progressBar.InvokeRequired)
                {
                    progressBar.Invoke(new MethodInvoker(delegate { progressBar.Value = (int)(value * 100); }));
                }
                else
                    progressBar.Value = (int)(value * 100);
            } 
            get 
            { 
                return progressBar.Value / 100; 
            } 
        }

        public string Description
        {
            set
            {
                if (descriptionLabel.InvokeRequired)
                {
                    descriptionLabel.Invoke(new MethodInvoker(delegate { descriptionLabel.Text = value; }));
                }
                else
                    descriptionLabel.Text = value;
            }
            get
            {
                return descriptionLabel.Text;
            }
        }


        public ProgressPanel()
        {
            InitializeComponent();
        }

        public void ShowMe(ContainerControl parent, string title, string description)
        {

            if (parent != null) SimpleOverlay.ShowFX(parent);
            
            this._finished = false;
            this.titleLabel.Text = title;
            this.descriptionLabel.Text = description;
            this.ShowDialog(parent);
            if (parent != null) SimpleOverlay.HideFX();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                if (_finished)
                {
                    this.Close();
                    return true;
                }
            }
            return base.ProcessDialogKey(keyData);
        }

        public void SetProgress(float progress)
        { 
            this.Progress = progress;
        }

        public void SetAsFinished()
        {
            Progress = 1.0f;
            closeButton.Enabled = true;
            _finished = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            Progress = 0;
            XConsole.Push();
            XConsole.SetOutput(outp);

            if (Opened != null)
                Opened();

            base.OnLoad(e);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            XConsole.Pop();

            base.OnClosing(e);
        }

        private void OnCloseButtonPressed(object sender, EventArgs e)
        {
            Close();
        }
    }
}
