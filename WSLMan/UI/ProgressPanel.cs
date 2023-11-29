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
        private System.Windows.Forms.Timer _timer = null;
        private SimulateProgress simulateProgress = null;

        public float Progress 
        { 
            set 
            {
                if (value > 1.0f) value = 1.0f;

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
            
            this._finished =                false;
            this.titleLabel.Text =          title;
            this.descriptionLabel.Text =    description;
            this.ShowDialog(parent);
            
            if (parent != null) SimpleOverlay.HideFX();
        }

        public void SimulateTimer(float progressStep, int millisTick)
        {
            simulateProgress = new SimulateProgress(progressStep, millisTick);
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

        protected override void OnLoad(EventArgs e)
        {
            XConsole.Push();
            XConsole.SetOutput(outp);

            if (simulateProgress != null)
                SimulateTimer();

            if (Opened != null)
                Opened();

            base.OnLoad(e);
        }

        public void SimulateTimer()
        {
            simulateProgress.Start();
            _timer =            new System.Windows.Forms.Timer();
            _timer.Interval =   simulateProgress.millisTick;
            _timer.Tick +=      OnSimulateTimerTick;
            _timer.Start();
        }

        private void OnSimulateTimerTick(object sender, EventArgs e)
        {
            SetProgress(simulateProgress.NextStep());
        }

        private void KillIfTimer()
        {
            if (_timer != null)
            {
                _timer.Stop();
                _timer = null;
                simulateProgress = null;
            }
        }

        public void SetProgress(float progress)
        { 
            this.Progress = progress;
        }

        public void SetAsFinished()
        {
            KillIfTimer();

            Progress = 1.0f;
            closeButton.Enabled = true;
            _finished = true;

            KillIfTimer();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            XConsole.Pop();
            KillIfTimer();

            base.OnClosing(e);
        }

        private void OnCloseButtonPressed(object sender, EventArgs e)
        {
            Close();
        }
    }
}
