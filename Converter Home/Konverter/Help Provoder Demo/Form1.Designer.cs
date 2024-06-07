namespace Help_Provoder_Demo
{
    partial class Form1
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
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.helpLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // addressTextBox
            // 
            this.helpProvider1.SetHelpString(this.addressTextBox, "Enter the street address in this text box.");
            this.addressTextBox.Location = new System.Drawing.Point(16, 24);
            this.addressTextBox.Name = "addressTextBox";
            this.helpProvider1.SetShowHelp(this.addressTextBox, true);
            this.addressTextBox.Size = new System.Drawing.Size(264, 23);
            this.addressTextBox.TabIndex = 0;
            // 
            // helpLabel
            // 
            this.helpLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.helpLabel.Location = new System.Drawing.Point(8, 80);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(272, 72);
            this.helpLabel.TabIndex = 9;
            this.helpLabel.Text = "Click the Help button in the title bar, then click a control to see a Help toolti" +
    "p for the control.  Click on a control and press F1 to invoke the Help system wi" +
    "th a sample Help file.";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Address:";
            // 
            // cityTextBox
            // 
            this.helpProvider1.SetHelpString(this.cityTextBox, "Enter the city here.");
            this.cityTextBox.Location = new System.Drawing.Point(16, 48);
            this.cityTextBox.Name = "cityTextBox";
            this.helpProvider1.SetShowHelp(this.cityTextBox, true);
            this.cityTextBox.Size = new System.Drawing.Size(120, 23);
            this.cityTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(136, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = ",";
            // 
            // stateTextBox
            // 
            this.helpProvider1.SetHelpString(this.stateTextBox, "Enter the state in this text box.");
            this.stateTextBox.Location = new System.Drawing.Point(152, 48);
            this.stateTextBox.MaxLength = 2;
            this.stateTextBox.Name = "stateTextBox";
            this.helpProvider1.SetShowHelp(this.stateTextBox, true);
            this.stateTextBox.Size = new System.Drawing.Size(32, 23);
            this.stateTextBox.TabIndex = 5;
            // 
            // zipTextBox
            // 
            this.helpProvider1.SetHelpString(this.zipTextBox, "Enter the zip code here.");
            this.zipTextBox.Location = new System.Drawing.Point(192, 48);
            this.zipTextBox.Name = "zipTextBox";
            this.helpProvider1.SetShowHelp(this.zipTextBox, true);
            this.zipTextBox.Size = new System.Drawing.Size(88, 23);
            this.zipTextBox.TabIndex = 6;
            // 
            // helpProvider1
            // 
            //this.helpProvider1.HelpNamespace = "help.html";

            this.helpProvider1.HelpNamespace = "mspaint.chm";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 160);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.addressTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Help Provider Demonstration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label helpLabel;
    }
}





