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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.defaultUserLoginCKBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.osList = new System.Windows.Forms.ComboBox();
            this.distroName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.passwordInput.Location = new System.Drawing.Point(98, 58);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(133, 27);
            this.passwordInput.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(10, 60);
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
            this.setUserButton.Location = new System.Drawing.Point(10, 138);
            this.setUserButton.Name = "setUserButton";
            this.setUserButton.Size = new System.Drawing.Size(221, 29);
            this.setUserButton.TabIndex = 16;
            this.setUserButton.Text = "create";
            this.setUserButton.UseVisualStyleBackColor = false;
            this.setUserButton.Click += new System.EventHandler(this.OnSetUserPressed);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.defaultUserLoginCKBox);
            this.groupBox2.Controls.Add(this.passwordInput);
            this.groupBox2.Controls.Add(this.setUserButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.usernameInput);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 181);
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
            this.defaultUserLoginCKBox.Location = new System.Drawing.Point(13, 96);
            this.defaultUserLoginCKBox.Name = "defaultUserLoginCKBox";
            this.defaultUserLoginCKBox.Size = new System.Drawing.Size(176, 24);
            this.defaultUserLoginCKBox.TabIndex = 18;
            this.defaultUserLoginCKBox.Text = "set as default for login";
            this.defaultUserLoginCKBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.osList);
            this.groupBox1.Controls.Add(this.distroName);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
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
            this.groupBox3.Controls.Add(this.infoLabel);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(264, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 287);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info";
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoLabel.ForeColor = System.Drawing.Color.Silver;
            this.infoLabel.Location = new System.Drawing.Point(10, 21);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(202, 252);
            this.infoLabel.TabIndex = 12;
            this.infoLabel.Text = "----";
            // 
            // ConfigPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(494, 300);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfigPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuration";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox usernameInput;
        private Label label4;
        private TextBox passwordInput;
        private Label label1;
        private Button setUserButton;
        private GroupBox groupBox2;
        private CheckBox defaultUserLoginCKBox;
        private GroupBox groupBox1;
        private Label distroName;
        private ComboBox osList;
        private GroupBox groupBox3;
        private Label infoLabel;
    }
}