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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.preinstalledRDButton = new System.Windows.Forms.RadioButton();
            this.customRDButton = new System.Windows.Forms.RadioButton();
            this.browseRDButton = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(511, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 266);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pre-installed";
            // 
            // preinstalledRDButton
            // 
            this.preinstalledRDButton.AutoSize = true;
            this.preinstalledRDButton.ForeColor = System.Drawing.Color.Silver;
            this.preinstalledRDButton.Location = new System.Drawing.Point(245, 22);
            this.preinstalledRDButton.Name = "preinstalledRDButton";
            this.preinstalledRDButton.Size = new System.Drawing.Size(113, 24);
            this.preinstalledRDButton.TabIndex = 3;
            this.preinstalledRDButton.TabStop = true;
            this.preinstalledRDButton.Text = "Pre-installed";
            this.preinstalledRDButton.UseVisualStyleBackColor = true;
            // 
            // customRDButton
            // 
            this.customRDButton.AutoSize = true;
            this.customRDButton.ForeColor = System.Drawing.Color.Silver;
            this.customRDButton.Location = new System.Drawing.Point(245, 52);
            this.customRDButton.Name = "customRDButton";
            this.customRDButton.Size = new System.Drawing.Size(121, 24);
            this.customRDButton.TabIndex = 4;
            this.customRDButton.TabStop = true;
            this.customRDButton.Text = "Custom tar.gz";
            this.customRDButton.UseVisualStyleBackColor = true;
            // 
            // browseRDButton
            // 
            this.browseRDButton.AutoSize = true;
            this.browseRDButton.ForeColor = System.Drawing.Color.Silver;
            this.browseRDButton.Location = new System.Drawing.Point(245, 82);
            this.browseRDButton.Name = "browseRDButton";
            this.browseRDButton.Size = new System.Drawing.Size(154, 24);
            this.browseRDButton.TabIndex = 5;
            this.browseRDButton.TabStop = true;
            this.browseRDButton.Text = "Browse new tag.gz";
            this.browseRDButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(258, 220);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(167, 124);
            this.listBox1.TabIndex = 6;
            // 
            // listButton
            // 
            this.listButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listButton.ForeColor = System.Drawing.Color.Silver;
            this.listButton.Location = new System.Drawing.Point(286, 404);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(94, 29);
            this.listButton.TabIndex = 7;
            this.listButton.Text = "refresh list";
            this.listButton.UseVisualStyleBackColor = false;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // InstallNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(889, 503);
            this.Controls.Add(this.listButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.browseRDButton);
            this.Controls.Add(this.customRDButton);
            this.Controls.Add(this.preinstalledRDButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InstallNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Install New Distro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton preinstalledRDButton;
        private RadioButton customRDButton;
        private RadioButton browseRDButton;
        private ListBox listBox1;
        private Button listButton;
    }
}