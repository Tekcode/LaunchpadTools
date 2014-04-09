namespace LaunchpadTools
{
    partial class ABOUT
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
            this.aboutText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nullPtrLink = new System.Windows.Forms.LinkLabel();
            this.launchVisionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aboutText
            // 
            this.aboutText.BackColor = System.Drawing.SystemColors.Control;
            this.aboutText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aboutText.Location = new System.Drawing.Point(12, 25);
            this.aboutText.Multiline = true;
            this.aboutText.Name = "aboutText";
            this.aboutText.ReadOnly = true;
            this.aboutText.Size = new System.Drawing.Size(260, 122);
            this.aboutText.TabIndex = 0;
            this.aboutText.TabStop = false;
            this.aboutText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nullPtrLink
            // 
            this.nullPtrLink.AutoSize = true;
            this.nullPtrLink.Location = new System.Drawing.Point(68, 150);
            this.nullPtrLink.Name = "nullPtrLink";
            this.nullPtrLink.Size = new System.Drawing.Size(131, 13);
            this.nullPtrLink.TabIndex = 2;
            this.nullPtrLink.TabStop = true;
            this.nullPtrLink.Text = "http://www.thenullptr.com";
            this.nullPtrLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nullPtrLink_LinkClicked);
            // 
            // launchVisionLabel
            // 
            this.launchVisionLabel.AutoSize = true;
            this.launchVisionLabel.Location = new System.Drawing.Point(42, 9);
            this.launchVisionLabel.Name = "launchVisionLabel";
            this.launchVisionLabel.Size = new System.Drawing.Size(183, 13);
            this.launchVisionLabel.TabIndex = 3;
            this.launchVisionLabel.Text = "Launchpad Control Version 0.1 Alpha";
            // 
            // ABOUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 194);
            this.Controls.Add(this.launchVisionLabel);
            this.Controls.Add(this.nullPtrLink);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aboutText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ABOUT";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.ABOUT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aboutText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel nullPtrLink;
        private System.Windows.Forms.Label launchVisionLabel;
    }
}