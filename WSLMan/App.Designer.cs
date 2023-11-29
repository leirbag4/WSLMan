using WSLMan.UI;

namespace WSLMan
{
    partial class App
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.listButton = new System.Windows.Forms.Button();
            this.groupBox1 = new WSLMan.UI.SimpleGroupBox();
            this.distroList = new WSLMan.UI.SimpleListView();
            this._colName = new System.Windows.Forms.ColumnHeader();
            this._colState = new System.Windows.Forms.ColumnHeader();
            this._colVersion = new System.Windows.Forms.ColumnHeader();
            this.outp = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new WSLMan.UI.SimpleGroupBox();
            this.installLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nameOutp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uidLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hashOutp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pathOutp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new WSLMan.UI.PictureButton();
            this.stopButton = new WSLMan.UI.PictureButton();
            this.startLabel = new System.Windows.Forms.Label();
            this.stopLabel = new System.Windows.Forms.Label();
            this.editButton = new WSLMan.UI.PictureButton();
            this.editLabel = new System.Windows.Forms.Label();
            this.createNewLabel = new System.Windows.Forms.Label();
            this.createNewButton = new WSLMan.UI.PictureButton();
            this.removeLabel = new System.Windows.Forms.Label();
            this.removeButton = new WSLMan.UI.PictureButton();
            this.openLocationLabel = new System.Windows.Forms.Label();
            this.openLocationButton = new WSLMan.UI.PictureButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.appVersionLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.wSLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hElpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cloneLabel = new System.Windows.Forms.Label();
            this.cloneButton = new WSLMan.UI.PictureButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // listButton
            // 
            this.listButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listButton.ForeColor = System.Drawing.Color.Silver;
            this.listButton.Location = new System.Drawing.Point(278, 307);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(102, 32);
            this.listButton.TabIndex = 0;
            this.listButton.Text = "refresh list";
            this.listButton.UseVisualStyleBackColor = false;
            this.listButton.Click += new System.EventHandler(this.OnListDistrosPressed);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.groupBox1.BorderSize = 2;
            this.groupBox1.Controls.Add(this.distroList);
            this.groupBox1.Controls.Add(this.listButton);
            this.groupBox1.CStyle = WSLMan.UI.SimpleGroupBox.CustomStyle.SOLID;
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 346);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distros";
            // 
            // distroList
            // 
            this.distroList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.distroList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._colName,
            this._colState,
            this._colVersion});
            this.distroList.ForeColor = System.Drawing.Color.White;
            this.distroList.FullRowSelect = true;
            this.distroList.Location = new System.Drawing.Point(15, 21);
            this.distroList.MultiSelect = false;
            this.distroList.Name = "distroList";
            this.distroList.Size = new System.Drawing.Size(365, 280);
            this.distroList.TabIndex = 17;
            this.distroList.UseCompatibleStateImageBehavior = false;
            this.distroList.View = System.Windows.Forms.View.Details;
            this.distroList.SelectedIndexChanged += new System.EventHandler(this.OnDistroIndexChanged);
            this.distroList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnDistroListDoubleClick);
            // 
            // _colName
            // 
            this._colName.Text = "Name";
            this._colName.Width = 180;
            // 
            // _colState
            // 
            this._colState.Text = "State";
            this._colState.Width = 120;
            // 
            // _colVersion
            // 
            this._colVersion.Text = "Version";
            // 
            // outp
            // 
            this.outp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.outp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outp.ForeColor = System.Drawing.Color.Silver;
            this.outp.Location = new System.Drawing.Point(12, 517);
            this.outp.Name = "outp";
            this.outp.Size = new System.Drawing.Size(767, 120);
            this.outp.TabIndex = 2;
            this.outp.Text = "";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(685, 643);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 5;
            this.button3.Text = "clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.OnClearPressed);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.groupBox2.BorderSize = 2;
            this.groupBox2.Controls.Add(this.installLabel);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.nameOutp);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.uidLabel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.versionLabel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.stateLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.hashOutp);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pathOutp);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.CStyle = WSLMan.UI.SimpleGroupBox.CustomStyle.SOLID;
            this.groupBox2.ForeColor = System.Drawing.Color.Silver;
            this.groupBox2.Location = new System.Drawing.Point(12, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(767, 131);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // installLabel
            // 
            this.installLabel.AutoSize = true;
            this.installLabel.ForeColor = System.Drawing.Color.Silver;
            this.installLabel.Location = new System.Drawing.Point(338, 97);
            this.installLabel.Name = "installLabel";
            this.installLabel.Size = new System.Drawing.Size(63, 20);
            this.installLabel.TabIndex = 13;
            this.installLabel.Text = "Package";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.SlateBlue;
            this.label9.Location = new System.Drawing.Point(292, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Install";
            // 
            // nameOutp
            // 
            this.nameOutp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nameOutp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameOutp.ForeColor = System.Drawing.Color.Silver;
            this.nameOutp.Location = new System.Drawing.Point(66, 28);
            this.nameOutp.Name = "nameOutp";
            this.nameOutp.Size = new System.Drawing.Size(133, 27);
            this.nameOutp.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.SlateBlue;
            this.label4.Location = new System.Drawing.Point(10, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            // 
            // uidLabel
            // 
            this.uidLabel.AutoSize = true;
            this.uidLabel.ForeColor = System.Drawing.Color.Silver;
            this.uidLabel.Location = new System.Drawing.Point(251, 97);
            this.uidLabel.Name = "uidLabel";
            this.uidLabel.Size = new System.Drawing.Size(17, 20);
            this.uidLabel.TabIndex = 9;
            this.uidLabel.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.SlateBlue;
            this.label8.Location = new System.Drawing.Point(216, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Uid";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.ForeColor = System.Drawing.Color.Silver;
            this.versionLabel.Location = new System.Drawing.Point(195, 97);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(17, 20);
            this.versionLabel.TabIndex = 7;
            this.versionLabel.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.SlateBlue;
            this.label6.Location = new System.Drawing.Point(136, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Version";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.ForeColor = System.Drawing.Color.Silver;
            this.stateLabel.Location = new System.Drawing.Point(62, 97);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(70, 20);
            this.stateLabel.TabIndex = 5;
            this.stateLabel.Text = "STOPPED";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.SlateBlue;
            this.label3.Location = new System.Drawing.Point(10, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "State";
            // 
            // hashOutp
            // 
            this.hashOutp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.hashOutp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hashOutp.ForeColor = System.Drawing.Color.Silver;
            this.hashOutp.Location = new System.Drawing.Point(253, 28);
            this.hashOutp.Name = "hashOutp";
            this.hashOutp.Size = new System.Drawing.Size(143, 27);
            this.hashOutp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(205, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hash";
            // 
            // pathOutp
            // 
            this.pathOutp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pathOutp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathOutp.ForeColor = System.Drawing.Color.Silver;
            this.pathOutp.Location = new System.Drawing.Point(66, 64);
            this.pathOutp.Name = "pathOutp";
            this.pathOutp.Size = new System.Drawing.Size(330, 27);
            this.pathOutp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(10, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path";
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Image = global::WSLMan.Properties.Resources.play_button_med;
            this.startButton.Location = new System.Drawing.Point(414, 114);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(40, 40);
            this.startButton.TabIndex = 9;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.OnStartPressed);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Image = global::WSLMan.Properties.Resources.stop_button_med;
            this.stopButton.Location = new System.Drawing.Point(611, 114);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(40, 40);
            this.stopButton.TabIndex = 10;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.OnStopPressed);
            // 
            // startLabel
            // 
            this.startLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startLabel.Enabled = false;
            this.startLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.startLabel.Location = new System.Drawing.Point(460, 114);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(96, 40);
            this.startLabel.TabIndex = 11;
            this.startLabel.Text = "Start distro";
            this.startLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stopLabel
            // 
            this.stopLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopLabel.Enabled = false;
            this.stopLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stopLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.stopLabel.Location = new System.Drawing.Point(657, 114);
            this.stopLabel.Name = "stopLabel";
            this.stopLabel.Size = new System.Drawing.Size(94, 40);
            this.stopLabel.TabIndex = 12;
            this.stopLabel.Text = "Stop distro";
            this.stopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Image = global::WSLMan.Properties.Resources.edit_button_med;
            this.editButton.Location = new System.Drawing.Point(414, 334);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(40, 40);
            this.editButton.TabIndex = 13;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.OnEditPressed);
            // 
            // editLabel
            // 
            this.editLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editLabel.Enabled = false;
            this.editLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.editLabel.Location = new System.Drawing.Point(460, 334);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(122, 40);
            this.editLabel.TabIndex = 14;
            this.editLabel.Text = "Edit distro ...";
            this.editLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // createNewLabel
            // 
            this.createNewLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createNewLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createNewLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.createNewLabel.Location = new System.Drawing.Point(460, 189);
            this.createNewLabel.Name = "createNewLabel";
            this.createNewLabel.Size = new System.Drawing.Size(116, 40);
            this.createNewLabel.TabIndex = 16;
            this.createNewLabel.Text = "Create NEW";
            this.createNewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // createNewButton
            // 
            this.createNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewButton.Image = global::WSLMan.Properties.Resources.add_button_med;
            this.createNewButton.Location = new System.Drawing.Point(414, 189);
            this.createNewButton.Name = "createNewButton";
            this.createNewButton.Size = new System.Drawing.Size(40, 40);
            this.createNewButton.TabIndex = 15;
            this.createNewButton.UseVisualStyleBackColor = true;
            this.createNewButton.Click += new System.EventHandler(this.OnCreateNewPressed);
            // 
            // removeLabel
            // 
            this.removeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeLabel.Enabled = false;
            this.removeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.removeLabel.Location = new System.Drawing.Point(460, 235);
            this.removeLabel.Name = "removeLabel";
            this.removeLabel.Size = new System.Drawing.Size(116, 40);
            this.removeLabel.TabIndex = 18;
            this.removeLabel.Text = "Remove distro";
            this.removeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // removeButton
            // 
            this.removeButton.Enabled = false;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Image = global::WSLMan.Properties.Resources.remove_button_med;
            this.removeButton.Location = new System.Drawing.Point(414, 235);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(40, 40);
            this.removeButton.TabIndex = 17;
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.OnRemovePressed);
            // 
            // openLocationLabel
            // 
            this.openLocationLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openLocationLabel.Enabled = false;
            this.openLocationLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.openLocationLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.openLocationLabel.Location = new System.Drawing.Point(657, 334);
            this.openLocationLabel.Name = "openLocationLabel";
            this.openLocationLabel.Size = new System.Drawing.Size(122, 40);
            this.openLocationLabel.TabIndex = 20;
            this.openLocationLabel.Text = "Open Location";
            this.openLocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openLocationButton
            // 
            this.openLocationButton.Enabled = false;
            this.openLocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openLocationButton.Image = global::WSLMan.Properties.Resources.folder_button_med;
            this.openLocationButton.Location = new System.Drawing.Point(611, 334);
            this.openLocationButton.Name = "openLocationButton";
            this.openLocationButton.Size = new System.Drawing.Size(40, 40);
            this.openLocationButton.TabIndex = 19;
            this.openLocationButton.UseVisualStyleBackColor = true;
            this.openLocationButton.Click += new System.EventHandler(this.OnOpenLocationPressed);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WSLMan.Properties.Resources.flat_logo_small;
            this.pictureBox1.Location = new System.Drawing.Point(423, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 60);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // appVersionLabel
            // 
            this.appVersionLabel.AutoSize = true;
            this.appVersionLabel.ForeColor = System.Drawing.Color.Silver;
            this.appVersionLabel.Location = new System.Drawing.Point(682, 71);
            this.appVersionLabel.Name = "appVersionLabel";
            this.appVersionLabel.Size = new System.Drawing.Size(93, 20);
            this.appVersionLabel.TabIndex = 12;
            this.appVersionLabel.Text = "version: 0.0.0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(682, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "WSLMan";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wSLToolStripMenuItem,
            this.hElpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(791, 28);
            this.menuStrip.TabIndex = 23;
            this.menuStrip.Text = "menuStrip1";
            // 
            // wSLToolStripMenuItem
            // 
            this.wSLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shutdownToolStripMenuItem});
            this.wSLToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.wSLToolStripMenuItem.Name = "wSLToolStripMenuItem";
            this.wSLToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.wSLToolStripMenuItem.Text = "WSL";
            // 
            // shutdownToolStripMenuItem
            // 
            this.shutdownToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.shutdownToolStripMenuItem.Name = "shutdownToolStripMenuItem";
            this.shutdownToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.shutdownToolStripMenuItem.Text = "Shutdown";
            this.shutdownToolStripMenuItem.Click += new System.EventHandler(this.OnMItemShutdownPressed);
            // 
            // hElpToolStripMenuItem
            // 
            this.hElpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.githubToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.hElpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.hElpToolStripMenuItem.Name = "hElpToolStripMenuItem";
            this.hElpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.hElpToolStripMenuItem.Text = "Help";
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.githubToolStripMenuItem.Text = "Github";
            this.githubToolStripMenuItem.Click += new System.EventHandler(this.OnMItemGithubPressed);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnMItemAboutPressed);
            // 
            // cloneLabel
            // 
            this.cloneLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cloneLabel.Enabled = false;
            this.cloneLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cloneLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.cloneLabel.Location = new System.Drawing.Point(657, 189);
            this.cloneLabel.Name = "cloneLabel";
            this.cloneLabel.Size = new System.Drawing.Size(116, 40);
            this.cloneLabel.TabIndex = 25;
            this.cloneLabel.Text = "Clone distro";
            this.cloneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cloneButton
            // 
            this.cloneButton.Enabled = false;
            this.cloneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cloneButton.Image = global::WSLMan.Properties.Resources.duplicate_button_med;
            this.cloneButton.Location = new System.Drawing.Point(611, 189);
            this.cloneButton.Name = "cloneButton";
            this.cloneButton.Size = new System.Drawing.Size(40, 40);
            this.cloneButton.TabIndex = 24;
            this.cloneButton.UseVisualStyleBackColor = true;
            this.cloneButton.Click += new System.EventHandler(this.OnClonePressed);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WSLMan.Properties.Resources.hor_separator_line;
            this.pictureBox2.Location = new System.Drawing.Point(423, 175);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 2);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WSLMan.Properties.Resources.hor_separator_line;
            this.pictureBox3.Location = new System.Drawing.Point(423, 315);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(350, 2);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(791, 683);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cloneLabel);
            this.Controls.Add(this.cloneButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.appVersionLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.openLocationLabel);
            this.Controls.Add(this.openLocationButton);
            this.Controls.Add(this.removeLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.createNewLabel);
            this.Controls.Add(this.createNewButton);
            this.Controls.Add(this.editLabel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.stopLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.outp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "App";
            this.Text = "WSLMan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button listButton;
        private SimpleGroupBox groupBox1;
        private RichTextBox outp;
        private Button button3;
        private SimpleGroupBox groupBox2;
        private TextBox pathOutp;
        private Label label1;
        private TextBox hashOutp;
        private Label label2;
        private Label versionLabel;
        private Label label6;
        private Label stateLabel;
        private Label label3;
        private Label uidLabel;
        private Label label8;
        private TextBox nameOutp;
        private Label label4;
        private UI.PictureButton startButton;
        private UI.PictureButton stopButton;
        private Label startLabel;
        private Label stopLabel;
        private UI.PictureButton editButton;
        private Label editLabel;
        private Label createNewLabel;
        private UI.PictureButton createNewButton;
        private UI.SimpleListView distroList;
        private ColumnHeader _colName;
        private ColumnHeader _colState;
        private ColumnHeader _colVersion;
        private Label removeLabel;
        private UI.PictureButton removeButton;
        private Label openLocationLabel;
        private UI.PictureButton openLocationButton;
        private PictureBox pictureBox1;
        private Label appVersionLabel;
        private Label label7;
        private MenuStrip menuStrip;
        private ToolStripMenuItem wSLToolStripMenuItem;
        private ToolStripMenuItem shutdownToolStripMenuItem;
        private ToolStripMenuItem hElpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem githubToolStripMenuItem;
        private Label cloneLabel;
        private UI.PictureButton cloneButton;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label installLabel;
        private Label label9;
    }
}