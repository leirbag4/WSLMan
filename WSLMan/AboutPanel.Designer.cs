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
            label7 = new Label();
            appVersionLabel = new Label();
            pictureBox1 = new PictureBox();
            descriptionLabel = new Label();
            closeButton = new Button();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(346, 21);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 25;
            label7.Text = "WSLMan";
            // 
            // appVersionLabel
            // 
            appVersionLabel.AutoSize = true;
            appVersionLabel.ForeColor = Color.Silver;
            appVersionLabel.Location = new Point(346, 46);
            appVersionLabel.Name = "appVersionLabel";
            appVersionLabel.Size = new Size(93, 20);
            appVersionLabel.TabIndex = 23;
            appVersionLabel.Text = "version: 0.2.0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.flat_logo_small;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // descriptionLabel
            // 
            descriptionLabel.ForeColor = Color.Silver;
            descriptionLabel.Location = new Point(11, 86);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(434, 29);
            descriptionLabel.TabIndex = 26;
            descriptionLabel.Text = "WSL Manager     Copyright: develop by Leirbag4";
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            closeButton.BackColor = Color.FromArgb(20, 20, 20);
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.ForeColor = Color.Silver;
            closeButton.Location = new Point(178, 161);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(94, 29);
            closeButton.TabIndex = 27;
            closeButton.Text = "close";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += OnClosePressed;
            // 
            // linkLabel1
            // 
            linkLabel1.LinkColor = Color.BlueViolet;
            linkLabel1.Location = new Point(11, 122);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(434, 25);
            linkLabel1.TabIndex = 28;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://github.com/leirbag4/WSLMan";
            linkLabel1.TextAlign = ContentAlignment.TopCenter;
            linkLabel1.LinkClicked += OnGithubLinkPressed;
            // 
            // AboutPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(457, 202);
            Controls.Add(linkLabel1);
            Controls.Add(closeButton);
            Controls.Add(descriptionLabel);
            Controls.Add(label7);
            Controls.Add(appVersionLabel);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AboutPanel";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AboutPanel";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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