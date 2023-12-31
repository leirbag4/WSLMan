﻿using WSLMan.UI;

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
            listButton = new Button();
            groupBox1 = new SimpleGroupBox();
            distroList = new SimpleListView();
            _colName = new ColumnHeader();
            _colState = new ColumnHeader();
            _colVersion = new ColumnHeader();
            outp = new RichTextBox();
            button3 = new Button();
            groupBox2 = new SimpleGroupBox();
            installLabel = new Label();
            label9 = new Label();
            nameOutp = new TextBox();
            label4 = new Label();
            uidLabel = new Label();
            label8 = new Label();
            versionLabel = new Label();
            label6 = new Label();
            stateLabel = new Label();
            label3 = new Label();
            hashOutp = new TextBox();
            label2 = new Label();
            pathOutp = new TextBox();
            label1 = new Label();
            startButton = new PictureButton();
            stopButton = new PictureButton();
            startLabel = new Label();
            stopLabel = new Label();
            editButton = new PictureButton();
            editLabel = new Label();
            createNewLabel = new Label();
            createNewButton = new PictureButton();
            removeLabel = new Label();
            removeButton = new PictureButton();
            openLocationLabel = new Label();
            openLocationButton = new PictureButton();
            pictureBox1 = new PictureBox();
            appVersionLabel = new Label();
            label7 = new Label();
            menuStrip = new MenuStrip();
            wSLToolStripMenuItem = new ToolStripMenuItem();
            shutdownToolStripMenuItem = new ToolStripMenuItem();
            hElpToolStripMenuItem = new ToolStripMenuItem();
            githubToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            cloneLabel = new Label();
            cloneButton = new PictureButton();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            simpleGroupBox1 = new SimpleGroupBox();
            descriptionInput = new TextBox();
            configToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            simpleGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listButton
            // 
            listButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            listButton.BackColor = Color.FromArgb(20, 20, 20);
            listButton.FlatStyle = FlatStyle.Flat;
            listButton.ForeColor = Color.Silver;
            listButton.Location = new Point(243, 230);
            listButton.Margin = new Padding(3, 2, 3, 2);
            listButton.Name = "listButton";
            listButton.Size = new Size(89, 24);
            listButton.TabIndex = 0;
            listButton.Text = "refresh list";
            listButton.UseVisualStyleBackColor = false;
            listButton.Click += OnListDistrosPressed;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.BorderColor = Color.FromArgb(50, 50, 50);
            groupBox1.BorderSize = 2;
            groupBox1.Controls.Add(distroList);
            groupBox1.Controls.Add(listButton);
            groupBox1.CStyle = SimpleGroupBox.CustomStyle.SOLID;
            groupBox1.ForeColor = Color.Silver;
            groupBox1.Location = new Point(10, 21);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(346, 260);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Distros";
            // 
            // distroList
            // 
            distroList.BackColor = Color.FromArgb(50, 50, 50);
            distroList.Columns.AddRange(new ColumnHeader[] { _colName, _colState, _colVersion });
            distroList.ForeColor = Color.White;
            distroList.FullRowSelect = true;
            distroList.Location = new Point(13, 16);
            distroList.Margin = new Padding(3, 2, 3, 2);
            distroList.MultiSelect = false;
            distroList.Name = "distroList";
            distroList.Size = new Size(320, 211);
            distroList.TabIndex = 17;
            distroList.UseCompatibleStateImageBehavior = false;
            distroList.View = View.Details;
            distroList.SelectedIndexChanged += OnDistroIndexChanged;
            distroList.MouseDoubleClick += OnDistroListDoubleClick;
            // 
            // _colName
            // 
            _colName.Text = "Name";
            _colName.Width = 180;
            // 
            // _colState
            // 
            _colState.Text = "State";
            _colState.Width = 120;
            // 
            // _colVersion
            // 
            _colVersion.Text = "Version";
            // 
            // outp
            // 
            outp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            outp.BackColor = Color.FromArgb(30, 30, 30);
            outp.BorderStyle = BorderStyle.None;
            outp.ForeColor = Color.Silver;
            outp.Location = new Point(10, 388);
            outp.Margin = new Padding(3, 2, 3, 2);
            outp.Name = "outp";
            outp.Size = new Size(671, 90);
            outp.TabIndex = 2;
            outp.Text = "";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(20, 20, 20);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Silver;
            button3.Location = new Point(599, 482);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 5;
            button3.Text = "clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += OnClearPressed;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BorderColor = Color.FromArgb(50, 50, 50);
            groupBox2.BorderSize = 2;
            groupBox2.Controls.Add(installLabel);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(nameOutp);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(uidLabel);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(versionLabel);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(stateLabel);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(hashOutp);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(pathOutp);
            groupBox2.Controls.Add(label1);
            groupBox2.CStyle = SimpleGroupBox.CustomStyle.SOLID;
            groupBox2.ForeColor = Color.Silver;
            groupBox2.Location = new Point(10, 283);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(356, 98);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Info";
            // 
            // installLabel
            // 
            installLabel.AutoSize = true;
            installLabel.ForeColor = Color.Silver;
            installLabel.Location = new Point(296, 73);
            installLabel.Name = "installLabel";
            installLabel.Size = new Size(51, 15);
            installLabel.TabIndex = 13;
            installLabel.Text = "Package";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.SlateBlue;
            label9.Location = new Point(256, 73);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 12;
            label9.Text = "Install";
            // 
            // nameOutp
            // 
            nameOutp.BackColor = Color.FromArgb(50, 50, 50);
            nameOutp.BorderStyle = BorderStyle.FixedSingle;
            nameOutp.ForeColor = Color.Silver;
            nameOutp.Location = new Point(58, 21);
            nameOutp.Margin = new Padding(3, 2, 3, 2);
            nameOutp.Name = "nameOutp";
            nameOutp.Size = new Size(117, 23);
            nameOutp.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.SlateBlue;
            label4.Location = new Point(9, 23);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 10;
            label4.Text = "Name";
            // 
            // uidLabel
            // 
            uidLabel.AutoSize = true;
            uidLabel.ForeColor = Color.Silver;
            uidLabel.Location = new Point(220, 73);
            uidLabel.Name = "uidLabel";
            uidLabel.Size = new Size(13, 15);
            uidLabel.TabIndex = 9;
            uidLabel.Text = "1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.SlateBlue;
            label8.Location = new Point(189, 73);
            label8.Name = "label8";
            label8.Size = new Size(25, 15);
            label8.TabIndex = 8;
            label8.Text = "Uid";
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.ForeColor = Color.Silver;
            versionLabel.Location = new Point(171, 73);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(13, 15);
            versionLabel.TabIndex = 7;
            versionLabel.Text = "1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.SlateBlue;
            label6.Location = new Point(119, 73);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 6;
            label6.Text = "Version";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.ForeColor = Color.Silver;
            stateLabel.Location = new Point(54, 73);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(55, 15);
            stateLabel.TabIndex = 5;
            stateLabel.Text = "STOPPED";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.SlateBlue;
            label3.Location = new Point(9, 73);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 4;
            label3.Text = "State";
            // 
            // hashOutp
            // 
            hashOutp.BackColor = Color.FromArgb(50, 50, 50);
            hashOutp.BorderStyle = BorderStyle.FixedSingle;
            hashOutp.ForeColor = Color.Silver;
            hashOutp.Location = new Point(221, 21);
            hashOutp.Margin = new Padding(3, 2, 3, 2);
            hashOutp.Name = "hashOutp";
            hashOutp.Size = new Size(125, 23);
            hashOutp.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.SlateBlue;
            label2.Location = new Point(179, 23);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "Hash";
            // 
            // pathOutp
            // 
            pathOutp.BackColor = Color.FromArgb(50, 50, 50);
            pathOutp.BorderStyle = BorderStyle.FixedSingle;
            pathOutp.ForeColor = Color.Silver;
            pathOutp.Location = new Point(58, 48);
            pathOutp.Margin = new Padding(3, 2, 3, 2);
            pathOutp.Name = "pathOutp";
            pathOutp.Size = new Size(289, 23);
            pathOutp.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.SlateBlue;
            label1.Location = new Point(9, 50);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Path";
            // 
            // startButton
            // 
            startButton.Enabled = false;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Image = Properties.Resources.play_button_med;
            startButton.Location = new Point(362, 86);
            startButton.Margin = new Padding(3, 2, 3, 2);
            startButton.Name = "startButton";
            startButton.Size = new Size(35, 30);
            startButton.TabIndex = 9;
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += OnStartPressed;
            // 
            // stopButton
            // 
            stopButton.Enabled = false;
            stopButton.FlatStyle = FlatStyle.Flat;
            stopButton.Image = Properties.Resources.stop_button_med;
            stopButton.Location = new Point(535, 86);
            stopButton.Margin = new Padding(3, 2, 3, 2);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(35, 30);
            stopButton.TabIndex = 10;
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += OnStopPressed;
            // 
            // startLabel
            // 
            startLabel.Cursor = Cursors.Hand;
            startLabel.Enabled = false;
            startLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            startLabel.ForeColor = Color.SlateBlue;
            startLabel.Location = new Point(402, 86);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(84, 30);
            startLabel.TabIndex = 11;
            startLabel.Text = "Start distro";
            startLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // stopLabel
            // 
            stopLabel.Cursor = Cursors.Hand;
            stopLabel.Enabled = false;
            stopLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            stopLabel.ForeColor = Color.SlateBlue;
            stopLabel.Location = new Point(575, 86);
            stopLabel.Name = "stopLabel";
            stopLabel.Size = new Size(82, 30);
            stopLabel.TabIndex = 12;
            stopLabel.Text = "Stop distro";
            stopLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // editButton
            // 
            editButton.Enabled = false;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Image = Properties.Resources.edit_button_med;
            editButton.Location = new Point(362, 250);
            editButton.Margin = new Padding(3, 2, 3, 2);
            editButton.Name = "editButton";
            editButton.Size = new Size(35, 30);
            editButton.TabIndex = 13;
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += OnEditPressed;
            // 
            // editLabel
            // 
            editLabel.Cursor = Cursors.Hand;
            editLabel.Enabled = false;
            editLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            editLabel.ForeColor = Color.SlateBlue;
            editLabel.Location = new Point(402, 250);
            editLabel.Name = "editLabel";
            editLabel.Size = new Size(107, 30);
            editLabel.TabIndex = 14;
            editLabel.Text = "Edit distro ...";
            editLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // createNewLabel
            // 
            createNewLabel.Cursor = Cursors.Hand;
            createNewLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            createNewLabel.ForeColor = Color.SlateBlue;
            createNewLabel.Location = new Point(402, 142);
            createNewLabel.Name = "createNewLabel";
            createNewLabel.Size = new Size(102, 30);
            createNewLabel.TabIndex = 16;
            createNewLabel.Text = "Create NEW";
            createNewLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // createNewButton
            // 
            createNewButton.FlatStyle = FlatStyle.Flat;
            createNewButton.Image = Properties.Resources.add_button_med;
            createNewButton.Location = new Point(362, 142);
            createNewButton.Margin = new Padding(3, 2, 3, 2);
            createNewButton.Name = "createNewButton";
            createNewButton.Size = new Size(35, 30);
            createNewButton.TabIndex = 15;
            createNewButton.UseVisualStyleBackColor = true;
            createNewButton.Click += OnCreateNewPressed;
            // 
            // removeLabel
            // 
            removeLabel.Cursor = Cursors.Hand;
            removeLabel.Enabled = false;
            removeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            removeLabel.ForeColor = Color.SlateBlue;
            removeLabel.Location = new Point(402, 176);
            removeLabel.Name = "removeLabel";
            removeLabel.Size = new Size(102, 30);
            removeLabel.TabIndex = 18;
            removeLabel.Text = "Remove distro";
            removeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // removeButton
            // 
            removeButton.Enabled = false;
            removeButton.FlatStyle = FlatStyle.Flat;
            removeButton.Image = Properties.Resources.remove_button_med;
            removeButton.Location = new Point(362, 176);
            removeButton.Margin = new Padding(3, 2, 3, 2);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(35, 30);
            removeButton.TabIndex = 17;
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += OnRemovePressed;
            // 
            // openLocationLabel
            // 
            openLocationLabel.Cursor = Cursors.Hand;
            openLocationLabel.Enabled = false;
            openLocationLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            openLocationLabel.ForeColor = Color.SlateBlue;
            openLocationLabel.Location = new Point(575, 250);
            openLocationLabel.Name = "openLocationLabel";
            openLocationLabel.Size = new Size(107, 30);
            openLocationLabel.TabIndex = 20;
            openLocationLabel.Text = "Open Location";
            openLocationLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // openLocationButton
            // 
            openLocationButton.Enabled = false;
            openLocationButton.FlatStyle = FlatStyle.Flat;
            openLocationButton.Image = Properties.Resources.folder_button_med;
            openLocationButton.Location = new Point(535, 250);
            openLocationButton.Margin = new Padding(3, 2, 3, 2);
            openLocationButton.Name = "openLocationButton";
            openLocationButton.Size = new Size(35, 30);
            openLocationButton.TabIndex = 19;
            openLocationButton.UseVisualStyleBackColor = true;
            openLocationButton.Click += OnOpenLocationPressed;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.flat_logo_small;
            pictureBox1.Location = new Point(370, 29);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 45);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // appVersionLabel
            // 
            appVersionLabel.AutoSize = true;
            appVersionLabel.ForeColor = Color.Silver;
            appVersionLabel.Location = new Point(597, 53);
            appVersionLabel.Name = "appVersionLabel";
            appVersionLabel.Size = new Size(75, 15);
            appVersionLabel.TabIndex = 12;
            appVersionLabel.Text = "version: 0.0.0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(597, 34);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 22;
            label7.Text = "WSLMan";
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { wSLToolStripMenuItem, hElpToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(5, 2, 0, 2);
            menuStrip.Size = new Size(692, 24);
            menuStrip.TabIndex = 23;
            menuStrip.Text = "menuStrip1";
            // 
            // wSLToolStripMenuItem
            // 
            wSLToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { shutdownToolStripMenuItem, configToolStripMenuItem });
            wSLToolStripMenuItem.ForeColor = Color.FromArgb(140, 140, 140);
            wSLToolStripMenuItem.Name = "wSLToolStripMenuItem";
            wSLToolStripMenuItem.Size = new Size(42, 20);
            wSLToolStripMenuItem.Text = "WSL";
            // 
            // shutdownToolStripMenuItem
            // 
            shutdownToolStripMenuItem.ForeColor = Color.Silver;
            shutdownToolStripMenuItem.Name = "shutdownToolStripMenuItem";
            shutdownToolStripMenuItem.Size = new Size(180, 22);
            shutdownToolStripMenuItem.Text = "Shutdown";
            shutdownToolStripMenuItem.Click += OnMItemShutdownPressed;
            // 
            // hElpToolStripMenuItem
            // 
            hElpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { githubToolStripMenuItem, aboutToolStripMenuItem });
            hElpToolStripMenuItem.ForeColor = Color.FromArgb(140, 140, 140);
            hElpToolStripMenuItem.Name = "hElpToolStripMenuItem";
            hElpToolStripMenuItem.Size = new Size(44, 20);
            hElpToolStripMenuItem.Text = "Help";
            // 
            // githubToolStripMenuItem
            // 
            githubToolStripMenuItem.ForeColor = Color.Silver;
            githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            githubToolStripMenuItem.Size = new Size(110, 22);
            githubToolStripMenuItem.Text = "Github";
            githubToolStripMenuItem.Click += OnMItemGithubPressed;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.ForeColor = Color.Silver;
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(110, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += OnMItemAboutPressed;
            // 
            // cloneLabel
            // 
            cloneLabel.Cursor = Cursors.Hand;
            cloneLabel.Enabled = false;
            cloneLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cloneLabel.ForeColor = Color.SlateBlue;
            cloneLabel.Location = new Point(575, 142);
            cloneLabel.Name = "cloneLabel";
            cloneLabel.Size = new Size(102, 30);
            cloneLabel.TabIndex = 25;
            cloneLabel.Text = "Clone distro";
            cloneLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cloneButton
            // 
            cloneButton.Enabled = false;
            cloneButton.FlatStyle = FlatStyle.Flat;
            cloneButton.Image = Properties.Resources.duplicate_button_med;
            cloneButton.Location = new Point(535, 142);
            cloneButton.Margin = new Padding(3, 2, 3, 2);
            cloneButton.Name = "cloneButton";
            cloneButton.Size = new Size(35, 30);
            cloneButton.TabIndex = 24;
            cloneButton.UseVisualStyleBackColor = true;
            cloneButton.Click += OnClonePressed;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.hor_separator_line;
            pictureBox2.Location = new Point(370, 131);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(350, 2);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.hor_separator_line;
            pictureBox3.Location = new Point(370, 236);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(350, 2);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            // 
            // simpleGroupBox1
            // 
            simpleGroupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            simpleGroupBox1.BorderColor = Color.FromArgb(50, 50, 50);
            simpleGroupBox1.BorderSize = 2;
            simpleGroupBox1.Controls.Add(descriptionInput);
            simpleGroupBox1.CStyle = SimpleGroupBox.CustomStyle.SOLID;
            simpleGroupBox1.ForeColor = Color.Silver;
            simpleGroupBox1.Location = new Point(372, 285);
            simpleGroupBox1.Margin = new Padding(3, 2, 3, 2);
            simpleGroupBox1.Name = "simpleGroupBox1";
            simpleGroupBox1.Padding = new Padding(3, 2, 3, 2);
            simpleGroupBox1.Size = new Size(310, 98);
            simpleGroupBox1.TabIndex = 28;
            simpleGroupBox1.TabStop = false;
            simpleGroupBox1.Text = "Description";
            // 
            // descriptionInput
            // 
            descriptionInput.BackColor = Color.FromArgb(45, 45, 45);
            descriptionInput.BorderStyle = BorderStyle.None;
            descriptionInput.ForeColor = Color.FromArgb(140, 140, 140);
            descriptionInput.Location = new Point(7, 19);
            descriptionInput.Margin = new Padding(3, 2, 3, 2);
            descriptionInput.Multiline = true;
            descriptionInput.Name = "descriptionInput";
            descriptionInput.Size = new Size(295, 74);
            descriptionInput.TabIndex = 11;
            descriptionInput.Text = "+ babacoin\r\nmein protocol\r\noka";
            descriptionInput.TextChanged += OnDescriptionChanged;
            // 
            // configToolStripMenuItem
            // 
            configToolStripMenuItem.ForeColor = Color.Silver;
            configToolStripMenuItem.Name = "configToolStripMenuItem";
            configToolStripMenuItem.Size = new Size(180, 22);
            configToolStripMenuItem.Text = "Config";
            configToolStripMenuItem.Click += OnMItemConfigPressed;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(692, 512);
            Controls.Add(simpleGroupBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(cloneLabel);
            Controls.Add(cloneButton);
            Controls.Add(label7);
            Controls.Add(appVersionLabel);
            Controls.Add(pictureBox1);
            Controls.Add(openLocationLabel);
            Controls.Add(openLocationButton);
            Controls.Add(removeLabel);
            Controls.Add(removeButton);
            Controls.Add(createNewLabel);
            Controls.Add(createNewButton);
            Controls.Add(editLabel);
            Controls.Add(editButton);
            Controls.Add(stopLabel);
            Controls.Add(startLabel);
            Controls.Add(stopButton);
            Controls.Add(startButton);
            Controls.Add(groupBox2);
            Controls.Add(button3);
            Controls.Add(outp);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 2, 3, 2);
            Name = "App";
            Text = "WSLMan";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            simpleGroupBox1.ResumeLayout(false);
            simpleGroupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private SimpleGroupBox simpleGroupBox1;
        private TextBox descriptionInput;
        private ToolStripMenuItem configToolStripMenuItem;
    }
}