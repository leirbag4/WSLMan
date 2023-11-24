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
            this.listButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.distroList = new WSLMan.UI.SimpleListView();
            this._colName = new System.Windows.Forms.ColumnHeader();
            this._colState = new System.Windows.Forms.ColumnHeader();
            this._colVersion = new System.Windows.Forms.ColumnHeader();
            this.outp = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.configButton = new WSLMan.UI.PictureButton();
            this.configLabel = new System.Windows.Forms.Label();
            this.createNewLabel = new System.Windows.Forms.Label();
            this.createNewButton = new WSLMan.UI.PictureButton();
            this.removeLabel = new System.Windows.Forms.Label();
            this.removeButton = new WSLMan.UI.PictureButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listButton
            // 
            this.listButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listButton.ForeColor = System.Drawing.Color.Silver;
            this.listButton.Location = new System.Drawing.Point(414, 315);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(94, 29);
            this.listButton.TabIndex = 0;
            this.listButton.Text = "refresh list";
            this.listButton.UseVisualStyleBackColor = false;
            this.listButton.Click += new System.EventHandler(this.OnListDistrosPressed);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.distroList);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 344);
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
            this.distroList.Location = new System.Drawing.Point(15, 36);
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
            this.outp.Location = new System.Drawing.Point(12, 488);
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
            this.button3.Location = new System.Drawing.Point(685, 614);
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
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 348);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(767, 131);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // nameOutp
            // 
            this.nameOutp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nameOutp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameOutp.ForeColor = System.Drawing.Color.Silver;
            this.nameOutp.Location = new System.Drawing.Point(66, 24);
            this.nameOutp.Name = "nameOutp";
            this.nameOutp.Size = new System.Drawing.Size(133, 27);
            this.nameOutp.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.SlateBlue;
            this.label4.Location = new System.Drawing.Point(10, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            // 
            // uidLabel
            // 
            this.uidLabel.AutoSize = true;
            this.uidLabel.ForeColor = System.Drawing.Color.Silver;
            this.uidLabel.Location = new System.Drawing.Point(299, 93);
            this.uidLabel.Name = "uidLabel";
            this.uidLabel.Size = new System.Drawing.Size(17, 20);
            this.uidLabel.TabIndex = 9;
            this.uidLabel.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.SlateBlue;
            this.label8.Location = new System.Drawing.Point(261, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Uid";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.ForeColor = System.Drawing.Color.Silver;
            this.versionLabel.Location = new System.Drawing.Point(221, 93);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(17, 20);
            this.versionLabel.TabIndex = 7;
            this.versionLabel.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.SlateBlue;
            this.label6.Location = new System.Drawing.Point(161, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Version";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.ForeColor = System.Drawing.Color.Silver;
            this.stateLabel.Location = new System.Drawing.Point(66, 93);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(70, 20);
            this.stateLabel.TabIndex = 5;
            this.stateLabel.Text = "STOPPED";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.SlateBlue;
            this.label3.Location = new System.Drawing.Point(10, 93);
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
            this.hashOutp.Location = new System.Drawing.Point(253, 24);
            this.hashOutp.Name = "hashOutp";
            this.hashOutp.Size = new System.Drawing.Size(127, 27);
            this.hashOutp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(205, 27);
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
            this.pathOutp.Location = new System.Drawing.Point(66, 60);
            this.pathOutp.Name = "pathOutp";
            this.pathOutp.Size = new System.Drawing.Size(314, 27);
            this.pathOutp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(10, 63);
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
            this.startButton.Location = new System.Drawing.Point(414, 171);
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
            this.stopButton.Location = new System.Drawing.Point(414, 217);
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
            this.startLabel.Location = new System.Drawing.Point(460, 171);
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
            this.stopLabel.Location = new System.Drawing.Point(460, 217);
            this.stopLabel.Name = "stopLabel";
            this.stopLabel.Size = new System.Drawing.Size(94, 40);
            this.stopLabel.TabIndex = 12;
            this.stopLabel.Text = "Stop distro";
            this.stopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // configButton
            // 
            this.configButton.Enabled = false;
            this.configButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.configButton.Image = global::WSLMan.Properties.Resources.edit_button_med;
            this.configButton.Location = new System.Drawing.Point(414, 264);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(40, 40);
            this.configButton.TabIndex = 13;
            this.configButton.UseVisualStyleBackColor = true;
            this.configButton.Click += new System.EventHandler(this.OnConfigPressed);
            // 
            // configLabel
            // 
            this.configLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.configLabel.Enabled = false;
            this.configLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.configLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.configLabel.Location = new System.Drawing.Point(460, 264);
            this.configLabel.Name = "configLabel";
            this.configLabel.Size = new System.Drawing.Size(122, 40);
            this.configLabel.TabIndex = 14;
            this.configLabel.Text = "Configuration ...";
            this.configLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // createNewLabel
            // 
            this.createNewLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createNewLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createNewLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.createNewLabel.Location = new System.Drawing.Point(657, 171);
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
            this.createNewButton.Location = new System.Drawing.Point(611, 171);
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
            this.removeLabel.Location = new System.Drawing.Point(657, 217);
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
            this.removeButton.Location = new System.Drawing.Point(611, 217);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(40, 40);
            this.removeButton.TabIndex = 17;
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.OnRemovePressed);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(791, 654);
            this.Controls.Add(this.removeLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.createNewLabel);
            this.Controls.Add(this.createNewButton);
            this.Controls.Add(this.configLabel);
            this.Controls.Add(this.configButton);
            this.Controls.Add(this.stopLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.outp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listButton);
            this.Name = "App";
            this.Text = "WSLMan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button listButton;
        private GroupBox groupBox1;
        private RichTextBox outp;
        private Button button3;
        private GroupBox groupBox2;
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
        private UI.PictureButton configButton;
        private Label configLabel;
        private Label createNewLabel;
        private UI.PictureButton createNewButton;
        private UI.SimpleListView distroList;
        private ColumnHeader _colName;
        private ColumnHeader _colState;
        private ColumnHeader _colVersion;
        private Label removeLabel;
        private UI.PictureButton removeButton;
    }
}