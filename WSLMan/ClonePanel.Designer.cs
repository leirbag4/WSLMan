namespace WSLMan
{
    partial class ClonePanel
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
            this.outputPathButton = new WSLMan.UI.PictureButton();
            this.outputPathOutp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newDistroNameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cloneButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outputPathButton);
            this.groupBox1.Controls.Add(this.outputPathOutp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.newDistroNameInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 96);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distro";
            // 
            // outputPathButton
            // 
            this.outputPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outputPathButton.Image = global::WSLMan.Properties.Resources.folder_button_mini;
            this.outputPathButton.Location = new System.Drawing.Point(355, 63);
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
            this.outputPathOutp.Location = new System.Drawing.Point(144, 63);
            this.outputPathOutp.Name = "outputPathOutp";
            this.outputPathOutp.Size = new System.Drawing.Size(205, 20);
            this.outputPathOutp.TabIndex = 29;
            this.outputPathOutp.Text = "C:\\Users\\wsltester\\anypath";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Output path";
            // 
            // newDistroNameInput
            // 
            this.newDistroNameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.newDistroNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newDistroNameInput.ForeColor = System.Drawing.Color.Silver;
            this.newDistroNameInput.Location = new System.Drawing.Point(144, 26);
            this.newDistroNameInput.Name = "newDistroNameInput";
            this.newDistroNameInput.Size = new System.Drawing.Size(238, 27);
            this.newDistroNameInput.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.SlateBlue;
            this.label3.Location = new System.Drawing.Point(11, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "New Distro Name";
            // 
            // cloneButton
            // 
            this.cloneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cloneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cloneButton.ForeColor = System.Drawing.Color.Silver;
            this.cloneButton.Location = new System.Drawing.Point(205, 105);
            this.cloneButton.Name = "cloneButton";
            this.cloneButton.Size = new System.Drawing.Size(94, 29);
            this.cloneButton.TabIndex = 19;
            this.cloneButton.Text = "clone";
            this.cloneButton.UseVisualStyleBackColor = false;
            this.cloneButton.Click += new System.EventHandler(this.OnClonePressed);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.Color.Silver;
            this.cancelButton.Location = new System.Drawing.Point(309, 105);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 29);
            this.cancelButton.TabIndex = 28;
            this.cancelButton.Text = "cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.OnCancelPressed);
            // 
            // ClonePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(411, 142);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cloneButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClonePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CloneForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private UI.PictureButton outputPathButton;
        private TextBox outputPathOutp;
        private Label label2;
        private TextBox newDistroNameInput;
        private Label label3;
        private Button cloneButton;
        private Button cancelButton;
    }
}