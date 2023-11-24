namespace WSLMan
{
    partial class AboutPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.appVersionLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(346, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "WSLMan";
            // 
            // appVersionLabel
            // 
            this.appVersionLabel.AutoSize = true;
            this.appVersionLabel.ForeColor = System.Drawing.Color.Silver;
            this.appVersionLabel.Location = new System.Drawing.Point(346, 46);
            this.appVersionLabel.Name = "appVersionLabel";
            this.appVersionLabel.Size = new System.Drawing.Size(93, 20);
            this.appVersionLabel.TabIndex = 23;
            this.appVersionLabel.Text = "version: 0.2.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WSLMan.Properties.Resources.flat_logo_small;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 60);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.ForeColor = System.Drawing.Color.Silver;
            this.descriptionLabel.Location = new System.Drawing.Point(11, 86);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(434, 29);
            this.descriptionLabel.TabIndex = 26;
            this.descriptionLabel.Text = "WSL Manager     Copyright: develop by Leirbag4";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.Silver;
            this.closeButton.Location = new System.Drawing.Point(178, 161);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(94, 29);
            this.closeButton.TabIndex = 27;
            this.closeButton.Text = "close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.OnClosePressed);
            // 
            // linkLabel1
            // 
            this.linkLabel1.LinkColor = System.Drawing.Color.BlueViolet;
            this.linkLabel1.Location = new System.Drawing.Point(11, 122);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(434, 25);
            this.linkLabel1.TabIndex = 28;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/leirbag4/WSLMan";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnGithubLinkPressed);
            // 
            // AboutPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(457, 202);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.appVersionLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutPanel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label7;
        private Label appVersionLabel;
        private PictureBox pictureBox1;
        private Label descriptionLabel;
        private Button closeButton;
        private LinkLabel linkLabel1;
    }
}