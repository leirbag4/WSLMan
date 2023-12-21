namespace WSLMan.UI
{
    partial class InfoPanel
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
            titleLabel = new Label();
            descriptionLabel = new Label();
            outp = new RichTextBox();
            closeButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.SlateBlue;
            titleLabel.Location = new Point(10, 10);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(515, 15);
            titleLabel.TabIndex = 22;
            titleLabel.Text = "Title";
            titleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // descriptionLabel
            // 
            descriptionLabel.ForeColor = Color.Silver;
            descriptionLabel.Location = new Point(10, 29);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(515, 35);
            descriptionLabel.TabIndex = 23;
            descriptionLabel.Text = "This is a description";
            descriptionLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // outp
            // 
            outp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            outp.BackColor = Color.FromArgb(30, 30, 30);
            outp.BorderStyle = BorderStyle.None;
            outp.ForeColor = Color.FromArgb(140, 140, 140);
            outp.Location = new Point(10, 67);
            outp.Margin = new Padding(3, 2, 3, 2);
            outp.Name = "outp";
            outp.Size = new Size(515, 84);
            outp.TabIndex = 25;
            outp.Text = "";
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            closeButton.BackColor = Color.FromArgb(20, 20, 20);
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.ForeColor = Color.Silver;
            closeButton.Location = new Point(214, 170);
            closeButton.Margin = new Padding(3, 2, 3, 2);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(94, 22);
            closeButton.TabIndex = 26;
            closeButton.Text = "close";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += OnCloseButtonPressed;
            // 
            // InfoPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(536, 201);
            Controls.Add(closeButton);
            Controls.Add(outp);
            Controls.Add(titleLabel);
            Controls.Add(descriptionLabel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "InfoPanel";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProgressPanel";
            ResumeLayout(false);
        }

        #endregion

        private Label titleLabel;
        private Label descriptionLabel;
        private RichTextBox outp;
        private Button closeButton;
    }
}