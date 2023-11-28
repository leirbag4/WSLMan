namespace WSLMan
{
    partial class InstallNew
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
            this.preinstalledRDButton = new System.Windows.Forms.RadioButton();
            this.customRDButton = new System.Windows.Forms.RadioButton();
            this.browseRDButton = new System.Windows.Forms.RadioButton();
            this.refreshListButton = new System.Windows.Forms.Button();
            this.onlineRDButton = new System.Windows.Forms.RadioButton();
            this.distroList = new WSLMan.UI.SimpleListView();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.installButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pathInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectedNameLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.pathContainer = new System.Windows.Forms.Panel();
            this.browseButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outputPathButton = new WSLMan.UI.PictureButton();
            this.outputPathOutp = new System.Windows.Forms.TextBox();
            this.outputPathLabel = new System.Windows.Forms.Label();
            this.newDistroNameInput = new System.Windows.Forms.TextBox();
            this.newDistroLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.pathContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // preinstalledRDButton
            // 
            this.preinstalledRDButton.AutoSize = true;
            this.preinstalledRDButton.ForeColor = System.Drawing.Color.Silver;
            this.preinstalledRDButton.Location = new System.Drawing.Point(12, 15);
            this.preinstalledRDButton.Name = "preinstalledRDButton";
            this.preinstalledRDButton.Size = new System.Drawing.Size(113, 24);
            this.preinstalledRDButton.TabIndex = 3;
            this.preinstalledRDButton.TabStop = true;
            this.preinstalledRDButton.Text = "Pre-installed";
            this.preinstalledRDButton.UseVisualStyleBackColor = true;
            this.preinstalledRDButton.Click += new System.EventHandler(this.OnModeCheckedChanged);
            // 
            // customRDButton
            // 
            this.customRDButton.AutoSize = true;
            this.customRDButton.ForeColor = System.Drawing.Color.Silver;
            this.customRDButton.Location = new System.Drawing.Point(12, 45);
            this.customRDButton.Name = "customRDButton";
            this.customRDButton.Size = new System.Drawing.Size(146, 24);
            this.customRDButton.TabIndex = 4;
            this.customRDButton.TabStop = true;
            this.customRDButton.Text = "Custom packages";
            this.customRDButton.UseVisualStyleBackColor = true;
            this.customRDButton.Click += new System.EventHandler(this.OnModeCheckedChanged);
            // 
            // browseRDButton
            // 
            this.browseRDButton.AutoSize = true;
            this.browseRDButton.ForeColor = System.Drawing.Color.Silver;
            this.browseRDButton.Location = new System.Drawing.Point(12, 105);
            this.browseRDButton.Name = "browseRDButton";
            this.browseRDButton.Size = new System.Drawing.Size(138, 24);
            this.browseRDButton.TabIndex = 5;
            this.browseRDButton.TabStop = true;
            this.browseRDButton.Text = "Browse package";
            this.browseRDButton.UseVisualStyleBackColor = true;
            this.browseRDButton.Click += new System.EventHandler(this.OnModeCheckedChanged);
            // 
            // refreshListButton
            // 
            this.refreshListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refreshListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.refreshListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshListButton.ForeColor = System.Drawing.Color.Silver;
            this.refreshListButton.Location = new System.Drawing.Point(172, 305);
            this.refreshListButton.Name = "refreshListButton";
            this.refreshListButton.Size = new System.Drawing.Size(235, 29);
            this.refreshListButton.TabIndex = 7;
            this.refreshListButton.Text = "refresh list";
            this.refreshListButton.UseVisualStyleBackColor = false;
            this.refreshListButton.Click += new System.EventHandler(this.OnRefreshListPressed);
            // 
            // onlineRDButton
            // 
            this.onlineRDButton.AutoSize = true;
            this.onlineRDButton.ForeColor = System.Drawing.Color.Silver;
            this.onlineRDButton.Location = new System.Drawing.Point(12, 75);
            this.onlineRDButton.Name = "onlineRDButton";
            this.onlineRDButton.Size = new System.Drawing.Size(73, 24);
            this.onlineRDButton.TabIndex = 8;
            this.onlineRDButton.TabStop = true;
            this.onlineRDButton.Text = "Online";
            this.onlineRDButton.UseVisualStyleBackColor = true;
            this.onlineRDButton.Click += new System.EventHandler(this.OnModeCheckedChanged);
            // 
            // distroList
            // 
            this.distroList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.distroList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName});
            this.distroList.ForeColor = System.Drawing.Color.White;
            this.distroList.FullRowSelect = true;
            this.distroList.Location = new System.Drawing.Point(172, 15);
            this.distroList.MultiSelect = false;
            this.distroList.Name = "distroList";
            this.distroList.Size = new System.Drawing.Size(235, 280);
            this.distroList.TabIndex = 18;
            this.distroList.UseCompatibleStateImageBehavior = false;
            this.distroList.View = System.Windows.Forms.View.Details;
            this.distroList.SelectedIndexChanged += new System.EventHandler(this.OnDistroIndexChanged);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 230;
            // 
            // installButton
            // 
            this.installButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.installButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.installButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.installButton.Location = new System.Drawing.Point(285, 23);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(94, 29);
            this.installButton.TabIndex = 19;
            this.installButton.Text = "install";
            this.installButton.UseVisualStyleBackColor = false;
            this.installButton.Click += new System.EventHandler(this.OnInstallPressed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SlateBlue;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Selected distro";
            // 
            // pathInput
            // 
            this.pathInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pathInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathInput.ForeColor = System.Drawing.Color.Silver;
            this.pathInput.Location = new System.Drawing.Point(14, 35);
            this.pathInput.Name = "pathInput";
            this.pathInput.Size = new System.Drawing.Size(262, 27);
            this.pathInput.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(14, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Input Path";
            // 
            // selectedNameLabel
            // 
            this.selectedNameLabel.AutoSize = true;
            this.selectedNameLabel.ForeColor = System.Drawing.Color.Silver;
            this.selectedNameLabel.Location = new System.Drawing.Point(6, 60);
            this.selectedNameLabel.Name = "selectedNameLabel";
            this.selectedNameLabel.Size = new System.Drawing.Size(27, 20);
            this.selectedNameLabel.TabIndex = 23;
            this.selectedNameLabel.Text = "---";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.descriptionLabel);
            this.groupBox2.Controls.Add(this.pathContainer);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(420, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 170);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.descriptionLabel.Location = new System.Drawing.Point(17, 23);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(362, 69);
            this.descriptionLabel.TabIndex = 26;
            this.descriptionLabel.Text = "Select a directory where all your distros.tar.gz are downloaded";
            // 
            // pathContainer
            // 
            this.pathContainer.Controls.Add(this.browseButton);
            this.pathContainer.Controls.Add(this.label1);
            this.pathContainer.Controls.Add(this.pathInput);
            this.pathContainer.Location = new System.Drawing.Point(4, 95);
            this.pathContainer.Name = "pathContainer";
            this.pathContainer.Size = new System.Drawing.Size(385, 71);
            this.pathContainer.TabIndex = 27;
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.ForeColor = System.Drawing.Color.Silver;
            this.browseButton.Location = new System.Drawing.Point(280, 34);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(94, 29);
            this.browseButton.TabIndex = 25;
            this.browseButton.Text = "browse...";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.OnBrowsePressed);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.outputPathButton);
            this.groupBox1.Controls.Add(this.outputPathOutp);
            this.groupBox1.Controls.Add(this.outputPathLabel);
            this.groupBox1.Controls.Add(this.newDistroNameInput);
            this.groupBox1.Controls.Add(this.newDistroLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.installButton);
            this.groupBox1.Controls.Add(this.selectedNameLabel);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(420, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 160);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distro";
            // 
            // outputPathButton
            // 
            this.outputPathButton.Enabled = false;
            this.outputPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outputPathButton.Image = global::WSLMan.Properties.Resources.folder_button_mini;
            this.outputPathButton.Location = new System.Drawing.Point(352, 127);
            this.outputPathButton.Name = "outputPathButton";
            this.outputPathButton.Size = new System.Drawing.Size(26, 22);
            this.outputPathButton.TabIndex = 30;
            this.outputPathButton.UseVisualStyleBackColor = true;
            this.outputPathButton.Click += new System.EventHandler(this.OnOutputPathPressed);
            // 
            // outputPathOutp
            // 
            this.outputPathOutp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.outputPathOutp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputPathOutp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.outputPathOutp.Location = new System.Drawing.Point(141, 127);
            this.outputPathOutp.Name = "outputPathOutp";
            this.outputPathOutp.Size = new System.Drawing.Size(205, 20);
            this.outputPathOutp.TabIndex = 29;
            this.outputPathOutp.Text = "C:\\Users\\wsltester\\anypath";
            // 
            // outputPathLabel
            // 
            this.outputPathLabel.AutoSize = true;
            this.outputPathLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.outputPathLabel.Location = new System.Drawing.Point(8, 126);
            this.outputPathLabel.Name = "outputPathLabel";
            this.outputPathLabel.Size = new System.Drawing.Size(89, 20);
            this.outputPathLabel.TabIndex = 28;
            this.outputPathLabel.Text = "Output path";
            // 
            // newDistroNameInput
            // 
            this.newDistroNameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.newDistroNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newDistroNameInput.ForeColor = System.Drawing.Color.Silver;
            this.newDistroNameInput.Location = new System.Drawing.Point(141, 90);
            this.newDistroNameInput.Name = "newDistroNameInput";
            this.newDistroNameInput.Size = new System.Drawing.Size(238, 27);
            this.newDistroNameInput.TabIndex = 27;
            // 
            // newDistroLabel
            // 
            this.newDistroLabel.AutoSize = true;
            this.newDistroLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.newDistroLabel.Location = new System.Drawing.Point(8, 93);
            this.newDistroLabel.Name = "newDistroLabel";
            this.newDistroLabel.Size = new System.Drawing.Size(127, 20);
            this.newDistroLabel.TabIndex = 26;
            this.newDistroLabel.Text = "New Distro Name";
            // 
            // InstallNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(827, 343);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.distroList);
            this.Controls.Add(this.onlineRDButton);
            this.Controls.Add(this.refreshListButton);
            this.Controls.Add(this.browseRDButton);
            this.Controls.Add(this.customRDButton);
            this.Controls.Add(this.preinstalledRDButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InstallNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Install New Distro";
            this.groupBox2.ResumeLayout(false);
            this.pathContainer.ResumeLayout(false);
            this.pathContainer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RadioButton preinstalledRDButton;
        private RadioButton customRDButton;
        private RadioButton browseRDButton;
        private Button refreshListButton;
        private RadioButton onlineRDButton;
        private UI.SimpleListView distroList;
        private ColumnHeader colName;
        private ColumnHeader colFriendlyName;
        private Button installButton;
        private Label label4;
        private TextBox pathInput;
        private Label label1;
        private Label selectedNameLabel;
        private GroupBox groupBox2;
        private Button browseButton;
        private GroupBox groupBox1;
        private TextBox newDistroNameInput;
        private Label newDistroLabel;
        private Label descriptionLabel;
        private Panel pathContainer;
        private TextBox outputPathOutp;
        private Label outputPathLabel;
        private UI.PictureButton outputPathButton;
    }
}