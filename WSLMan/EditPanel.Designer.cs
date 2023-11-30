using WSLMan.UI;

namespace WSLMan
{
    partial class EditPanel
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
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.setUserButton = new System.Windows.Forms.Button();
            this.groupBox2 = new WSLMan.UI.SimpleGroupBox();
            this.defaultUserLoginCKBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new WSLMan.UI.SimpleGroupBox();
            this.osList = new System.Windows.Forms.ComboBox();
            this.distroName = new System.Windows.Forms.Label();
            this.groupBox3 = new WSLMan.UI.SimpleGroupBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.simpleGroupBox1 = new WSLMan.UI.SimpleGroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.selectedUserLabel = new System.Windows.Forms.Label();
            this.setDefaultUserButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.includeNonUsersCKBox = new System.Windows.Forms.CheckBox();
            this.columnFilterCBox = new System.Windows.Forms.ComboBox();
            this.userList = new WSLMan.UI.SimpleListView();
            this.colUsername = new System.Windows.Forms.ColumnHeader();
            this.colPassword = new System.Windows.Forms.ColumnHeader();
            this.colUserId = new System.Windows.Forms.ColumnHeader();
            this.colGroupId = new System.Windows.Forms.ColumnHeader();
            this.colUserDescription = new System.Windows.Forms.ColumnHeader();
            this.colHomeDirectory = new System.Windows.Forms.ColumnHeader();
            this.colShell = new System.Windows.Forms.ColumnHeader();
            this.refreshUserListButton = new System.Windows.Forms.Button();
            this.simpleGroupBox2 = new WSLMan.UI.SimpleGroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.simpleGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameInput
            // 
            this.usernameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.usernameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameInput.ForeColor = System.Drawing.Color.Silver;
            this.usernameInput.Location = new System.Drawing.Point(98, 25);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(133, 27);
            this.usernameInput.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.SlateBlue;
            this.label4.Location = new System.Drawing.Point(10, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Username";
            // 
            // passwordInput
            // 
            this.passwordInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordInput.ForeColor = System.Drawing.Color.Silver;
            this.passwordInput.Location = new System.Drawing.Point(98, 61);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(133, 27);
            this.passwordInput.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(10, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Password";
            // 
            // setUserButton
            // 
            this.setUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.setUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.setUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setUserButton.ForeColor = System.Drawing.Color.Silver;
            this.setUserButton.Location = new System.Drawing.Point(10, 142);
            this.setUserButton.Name = "setUserButton";
            this.setUserButton.Size = new System.Drawing.Size(221, 29);
            this.setUserButton.TabIndex = 16;
            this.setUserButton.Text = "create";
            this.setUserButton.UseVisualStyleBackColor = false;
            this.setUserButton.Click += new System.EventHandler(this.OnSetUserPressed);
            // 
            // groupBox2
            // 
            this.groupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.groupBox2.BorderSize = 2;
            this.groupBox2.Controls.Add(this.defaultUserLoginCKBox);
            this.groupBox2.Controls.Add(this.passwordInput);
            this.groupBox2.Controls.Add(this.setUserButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.usernameInput);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.CStyle = WSLMan.UI.SimpleGroupBox.CustomStyle.SOLID;
            this.groupBox2.ForeColor = System.Drawing.Color.Silver;
            this.groupBox2.Location = new System.Drawing.Point(12, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 185);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New User";
            // 
            // defaultUserLoginCKBox
            // 
            this.defaultUserLoginCKBox.AutoSize = true;
            this.defaultUserLoginCKBox.Checked = true;
            this.defaultUserLoginCKBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.defaultUserLoginCKBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defaultUserLoginCKBox.ForeColor = System.Drawing.Color.Silver;
            this.defaultUserLoginCKBox.Location = new System.Drawing.Point(13, 99);
            this.defaultUserLoginCKBox.Name = "defaultUserLoginCKBox";
            this.defaultUserLoginCKBox.Size = new System.Drawing.Size(176, 24);
            this.defaultUserLoginCKBox.TabIndex = 18;
            this.defaultUserLoginCKBox.Text = "set as default for login";
            this.defaultUserLoginCKBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.groupBox1.BorderSize = 2;
            this.groupBox1.Controls.Add(this.osList);
            this.groupBox1.Controls.Add(this.distroName);
            this.groupBox1.CStyle = WSLMan.UI.SimpleGroupBox.CustomStyle.SOLID;
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 102);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distro";
            // 
            // osList
            // 
            this.osList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.osList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.osList.ForeColor = System.Drawing.Color.Silver;
            this.osList.FormattingEnabled = true;
            this.osList.Location = new System.Drawing.Point(13, 53);
            this.osList.Name = "osList";
            this.osList.Size = new System.Drawing.Size(151, 28);
            this.osList.TabIndex = 13;
            this.osList.SelectedIndexChanged += new System.EventHandler(this.OnOsListChanged);
            // 
            // distroName
            // 
            this.distroName.AutoSize = true;
            this.distroName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.distroName.ForeColor = System.Drawing.Color.Silver;
            this.distroName.Location = new System.Drawing.Point(10, 21);
            this.distroName.Name = "distroName";
            this.distroName.Size = new System.Drawing.Size(93, 20);
            this.distroName.TabIndex = 12;
            this.distroName.Text = "distro name";
            // 
            // groupBox3
            // 
            this.groupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.groupBox3.BorderSize = 2;
            this.groupBox3.Controls.Add(this.infoLabel);
            this.groupBox3.CStyle = WSLMan.UI.SimpleGroupBox.CustomStyle.SOLID;
            this.groupBox3.ForeColor = System.Drawing.Color.Silver;
            this.groupBox3.Location = new System.Drawing.Point(264, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 102);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info";
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoLabel.ForeColor = System.Drawing.Color.Silver;
            this.infoLabel.Location = new System.Drawing.Point(8, 21);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(408, 78);
            this.infoLabel.TabIndex = 12;
            this.infoLabel.Text = "----";
            // 
            // simpleGroupBox1
            // 
            this.simpleGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.simpleGroupBox1.BorderSize = 2;
            this.simpleGroupBox1.Controls.Add(this.pictureBox3);
            this.simpleGroupBox1.Controls.Add(this.selectedUserLabel);
            this.simpleGroupBox1.Controls.Add(this.setDefaultUserButton);
            this.simpleGroupBox1.Controls.Add(this.label2);
            this.simpleGroupBox1.Controls.Add(this.includeNonUsersCKBox);
            this.simpleGroupBox1.Controls.Add(this.columnFilterCBox);
            this.simpleGroupBox1.Controls.Add(this.userList);
            this.simpleGroupBox1.Controls.Add(this.refreshUserListButton);
            this.simpleGroupBox1.CStyle = WSLMan.UI.SimpleGroupBox.CustomStyle.SOLID;
            this.simpleGroupBox1.ForeColor = System.Drawing.Color.Silver;
            this.simpleGroupBox1.Location = new System.Drawing.Point(264, 107);
            this.simpleGroupBox1.Name = "simpleGroupBox1";
            this.simpleGroupBox1.Size = new System.Drawing.Size(424, 337);
            this.simpleGroupBox1.TabIndex = 19;
            this.simpleGroupBox1.TabStop = false;
            this.simpleGroupBox1.Text = "User List";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WSLMan.Properties.Resources.hor_separator_line;
            this.pictureBox3.Location = new System.Drawing.Point(37, 277);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(350, 2);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // selectedUserLabel
            // 
            this.selectedUserLabel.ForeColor = System.Drawing.Color.Silver;
            this.selectedUserLabel.Location = new System.Drawing.Point(101, 296);
            this.selectedUserLabel.Name = "selectedUserLabel";
            this.selectedUserLabel.Size = new System.Drawing.Size(188, 20);
            this.selectedUserLabel.TabIndex = 14;
            this.selectedUserLabel.Text = "-";
            // 
            // setDefaultUserButton
            // 
            this.setDefaultUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.setDefaultUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.setDefaultUserButton.Enabled = false;
            this.setDefaultUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setDefaultUserButton.ForeColor = System.Drawing.Color.Silver;
            this.setDefaultUserButton.Location = new System.Drawing.Point(295, 292);
            this.setDefaultUserButton.Name = "setDefaultUserButton";
            this.setDefaultUserButton.Size = new System.Drawing.Size(121, 29);
            this.setDefaultUserButton.TabIndex = 19;
            this.setDefaultUserButton.Text = "set as default";
            this.setDefaultUserButton.UseVisualStyleBackColor = false;
            this.setDefaultUserButton.Click += new System.EventHandler(this.OnSetDefaultUserPressed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(18, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username";
            // 
            // includeNonUsersCKBox
            // 
            this.includeNonUsersCKBox.AutoSize = true;
            this.includeNonUsersCKBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.includeNonUsersCKBox.ForeColor = System.Drawing.Color.Silver;
            this.includeNonUsersCKBox.Location = new System.Drawing.Point(18, 231);
            this.includeNonUsersCKBox.Name = "includeNonUsersCKBox";
            this.includeNonUsersCKBox.Size = new System.Drawing.Size(141, 24);
            this.includeNonUsersCKBox.TabIndex = 19;
            this.includeNonUsersCKBox.Text = "include non users";
            this.includeNonUsersCKBox.UseVisualStyleBackColor = true;
            this.includeNonUsersCKBox.CheckedChanged += new System.EventHandler(this.OnIncludedNonUsersChanged);
            // 
            // columnFilterCBox
            // 
            this.columnFilterCBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.columnFilterCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.columnFilterCBox.ForeColor = System.Drawing.Color.Silver;
            this.columnFilterCBox.FormattingEnabled = true;
            this.columnFilterCBox.Items.AddRange(new object[] {
            "summary",
            "detailed"});
            this.columnFilterCBox.Location = new System.Drawing.Point(177, 230);
            this.columnFilterCBox.Name = "columnFilterCBox";
            this.columnFilterCBox.Size = new System.Drawing.Size(151, 28);
            this.columnFilterCBox.TabIndex = 21;
            this.columnFilterCBox.SelectedIndexChanged += new System.EventHandler(this.OnColumnFilterChanged);
            // 
            // userList
            // 
            this.userList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.userList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUsername,
            this.colPassword,
            this.colUserId,
            this.colGroupId,
            this.colUserDescription,
            this.colHomeDirectory,
            this.colShell});
            this.userList.ForeColor = System.Drawing.Color.White;
            this.userList.FullRowSelect = true;
            this.userList.Location = new System.Drawing.Point(8, 26);
            this.userList.MultiSelect = false;
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(408, 197);
            this.userList.TabIndex = 20;
            this.userList.UseCompatibleStateImageBehavior = false;
            this.userList.View = System.Windows.Forms.View.Details;
            this.userList.SelectedIndexChanged += new System.EventHandler(this.OnUserSelectedChanged);
            // 
            // colUsername
            // 
            this.colUsername.Text = "Username";
            this.colUsername.Width = 140;
            // 
            // colPassword
            // 
            this.colPassword.Text = "Password";
            this.colPassword.Width = 100;
            // 
            // colUserId
            // 
            this.colUserId.Text = "UID";
            this.colUserId.Width = 70;
            // 
            // colGroupId
            // 
            this.colGroupId.Text = "GID";
            this.colGroupId.Width = 70;
            // 
            // colUserDescription
            // 
            this.colUserDescription.Text = "User Description";
            this.colUserDescription.Width = 140;
            // 
            // colHomeDirectory
            // 
            this.colHomeDirectory.Text = "Home";
            this.colHomeDirectory.Width = 140;
            // 
            // colShell
            // 
            this.colShell.Text = "Shell";
            this.colShell.Width = 100;
            // 
            // refreshUserListButton
            // 
            this.refreshUserListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refreshUserListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.refreshUserListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshUserListButton.ForeColor = System.Drawing.Color.Silver;
            this.refreshUserListButton.Location = new System.Drawing.Point(345, 229);
            this.refreshUserListButton.Name = "refreshUserListButton";
            this.refreshUserListButton.Size = new System.Drawing.Size(69, 29);
            this.refreshUserListButton.TabIndex = 19;
            this.refreshUserListButton.Text = "refresh";
            this.refreshUserListButton.UseVisualStyleBackColor = false;
            this.refreshUserListButton.Click += new System.EventHandler(this.OnRefreshUserListPressed);
            // 
            // simpleGroupBox2
            // 
            this.simpleGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.simpleGroupBox2.BorderSize = 2;
            this.simpleGroupBox2.CStyle = WSLMan.UI.SimpleGroupBox.CustomStyle.SOLID;
            this.simpleGroupBox2.ForeColor = System.Drawing.Color.Silver;
            this.simpleGroupBox2.Location = new System.Drawing.Point(12, 298);
            this.simpleGroupBox2.Name = "simpleGroupBox2";
            this.simpleGroupBox2.Size = new System.Drawing.Size(246, 146);
            this.simpleGroupBox2.TabIndex = 21;
            this.simpleGroupBox2.TabStop = false;
            // 
            // EditPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(700, 456);
            this.Controls.Add(this.simpleGroupBox2);
            this.Controls.Add(this.simpleGroupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edition";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.simpleGroupBox1.ResumeLayout(false);
            this.simpleGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox usernameInput;
        private Label label4;
        private TextBox passwordInput;
        private Label label1;
        private Button setUserButton;
        private SimpleGroupBox groupBox2;
        private CheckBox defaultUserLoginCKBox;
        private SimpleGroupBox groupBox1;
        private Label distroName;
        private ComboBox osList;
        private SimpleGroupBox groupBox3;
        private Label infoLabel;
        private SimpleGroupBox simpleGroupBox1;
        private Button refreshUserListButton;
        private SimpleListView userList;
        private ColumnHeader colUsername;
        private ColumnHeader colPassword;
        private ColumnHeader colUserId;
        private ColumnHeader colGroupId;
        private ColumnHeader colUserDescription;
        private ColumnHeader colHomeDirectory;
        private ColumnHeader colShell;
        private ComboBox columnFilterCBox;
        private CheckBox includeNonUsersCKBox;
        private SimpleGroupBox simpleGroupBox2;
        private Label selectedUserLabel;
        private Label label2;
        private Button setDefaultUserButton;
        private PictureBox pictureBox3;
    }
}