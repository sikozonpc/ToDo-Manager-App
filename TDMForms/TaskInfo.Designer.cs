namespace TDMForms
{
    partial class TaskInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskInformation));
            this.InfoTextBox = new System.Windows.Forms.RichTextBox();
            this.SaveEditButton = new System.Windows.Forms.Button();
            this.TaskInfoTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InfoTextBox
            // 
            resources.ApplyResources(this.InfoTextBox, "InfoTextBox");
            this.InfoTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.InfoTextBox.Name = "InfoTextBox";
            // 
            // SaveEditButton
            // 
            resources.ApplyResources(this.SaveEditButton, "SaveEditButton");
            this.SaveEditButton.Name = "SaveEditButton";
            this.SaveEditButton.UseVisualStyleBackColor = true;
            this.SaveEditButton.Click += new System.EventHandler(this.SaveEditButton_Click);
            // 
            // TaskInfoTitleLabel
            // 
            resources.ApplyResources(this.TaskInfoTitleLabel, "TaskInfoTitleLabel");
            this.TaskInfoTitleLabel.Name = "TaskInfoTitleLabel";
            // 
            // TaskInformation
            // 
            resources.ApplyResources(this, "$this");
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.PropertyPage;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TaskInfoTitleLabel);
            this.Controls.Add(this.SaveEditButton);
            this.Controls.Add(this.InfoTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "TaskInformation";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox InfoTextBox;
        private System.Windows.Forms.Button SaveEditButton;
        private System.Windows.Forms.Label TaskInfoTitleLabel;
    }
}