using WSLMan.UI;

namespace WSLMan
{
    partial class ConfigPanel
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
            label4 = new Label();
            groupBox2 = new SimpleGroupBox();
            closeButton = new Button();
            showConsoleWarnings = new CheckBox();
            versionLabel = new Label();
            simpleGroupBox1 = new SimpleGroupBox();
            descriptionLabel = new Label();
            groupBox2.SuspendLayout();
            simpleGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.SlateBlue;
            label4.Location = new Point(9, 33);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 12;
            label4.Text = "Version";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox2.BorderColor = Color.FromArgb(60, 60, 60);
            groupBox2.BorderSize = 2;
            groupBox2.Controls.Add(closeButton);
            groupBox2.Controls.Add(showConsoleWarnings);
            groupBox2.Controls.Add(versionLabel);
            groupBox2.Controls.Add(label4);
            groupBox2.CStyle = SimpleGroupBox.CustomStyle.SOLID;
            groupBox2.ForeColor = Color.Silver;
            groupBox2.Location = new Point(10, 11);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(231, 178);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Config";
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.FromArgb(20, 20, 20);
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.ForeColor = Color.Silver;
            closeButton.Location = new Point(46, 118);
            closeButton.Margin = new Padding(3, 2, 3, 2);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(150, 26);
            closeButton.TabIndex = 28;
            closeButton.Text = "reset config file";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += OnResetConfigFilePressed;
            // 
            // showConsoleWarnings
            // 
            showConsoleWarnings.AutoSize = true;
            showConsoleWarnings.Checked = true;
            showConsoleWarnings.CheckState = CheckState.Checked;
            showConsoleWarnings.FlatStyle = FlatStyle.Flat;
            showConsoleWarnings.ForeColor = Color.Silver;
            showConsoleWarnings.Location = new Point(49, 72);
            showConsoleWarnings.Margin = new Padding(3, 2, 3, 2);
            showConsoleWarnings.Name = "showConsoleWarnings";
            showConsoleWarnings.Size = new Size(147, 19);
            showConsoleWarnings.TabIndex = 18;
            showConsoleWarnings.Text = "Show console warnings";
            showConsoleWarnings.UseVisualStyleBackColor = true;
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            versionLabel.ForeColor = Color.Silver;
            versionLabel.Location = new Point(70, 33);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(34, 15);
            versionLabel.TabIndex = 12;
            versionLabel.Text = "0.0.0";
            // 
            // simpleGroupBox1
            // 
            simpleGroupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            simpleGroupBox1.BorderColor = Color.FromArgb(60, 60, 60);
            simpleGroupBox1.BorderSize = 2;
            simpleGroupBox1.Controls.Add(descriptionLabel);
            simpleGroupBox1.CStyle = SimpleGroupBox.CustomStyle.SOLID;
            simpleGroupBox1.ForeColor = Color.Silver;
            simpleGroupBox1.Location = new Point(247, 11);
            simpleGroupBox1.Margin = new Padding(3, 2, 3, 2);
            simpleGroupBox1.Name = "simpleGroupBox1";
            simpleGroupBox1.Padding = new Padding(3, 2, 3, 2);
            simpleGroupBox1.Size = new Size(317, 178);
            simpleGroupBox1.TabIndex = 18;
            simpleGroupBox1.TabStop = false;
            simpleGroupBox1.Text = "Info";
            // 
            // descriptionLabel
            // 
            descriptionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descriptionLabel.ForeColor = Color.Silver;
            descriptionLabel.Location = new Point(20, 44);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(276, 119);
            descriptionLabel.TabIndex = 29;
            descriptionLabel.Text = "Set and change all basic configuration here about the application.\r\n\r\n\r\n\r\nWSL Manager     Copyright: develop by Leirbag4";
            // 
            // ConfigPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(576, 200);
            Controls.Add(simpleGroupBox1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ConfigPanel";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Config";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            simpleGroupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private Button setUserButton;
        private SimpleGroupBox groupBox2;
        private CheckBox showConsoleWarnings;
        private Label versionLabel;
        private ComboBox osList;
        private SimpleGroupBox groupBox1;
        private Button closeButton;
        private SimpleGroupBox simpleGroupBox1;
        private Label descriptionLabel;
    }
}