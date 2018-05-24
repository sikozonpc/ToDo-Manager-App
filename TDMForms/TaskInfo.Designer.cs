namespace TDMForms
{
    partial class TaskInfo
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
            this.InfoTextBox = new System.Windows.Forms.RichTextBox();
            this.SaveEditButton = new System.Windows.Forms.Button();
            this.TaskInfoTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.InfoTextBox.Location = new System.Drawing.Point(12, 42);
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.Size = new System.Drawing.Size(411, 121);
            this.InfoTextBox.TabIndex = 0;
            this.InfoTextBox.Text = "";
            // 
            // SaveEditButton
            // 
            this.SaveEditButton.Location = new System.Drawing.Point(358, 169);
            this.SaveEditButton.Name = "SaveEditButton";
            this.SaveEditButton.Size = new System.Drawing.Size(75, 23);
            this.SaveEditButton.TabIndex = 1;
            this.SaveEditButton.Text = "Save Edit";
            this.SaveEditButton.UseVisualStyleBackColor = true;
            this.SaveEditButton.Click += new System.EventHandler(this.SaveEditButton_Click);
            // 
            // TaskInfoTitleLabel
            // 
            this.TaskInfoTitleLabel.AutoSize = true;
            this.TaskInfoTitleLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskInfoTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.TaskInfoTitleLabel.Name = "TaskInfoTitleLabel";
            this.TaskInfoTitleLabel.Size = new System.Drawing.Size(0, 28);
            this.TaskInfoTitleLabel.TabIndex = 2;
            // 
            // TaskInfo
            // 
            this.AccessibleName = "Task Info Window";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.PropertyPage;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 194);
            this.Controls.Add(this.TaskInfoTitleLabel);
            this.Controls.Add(this.SaveEditButton);
            this.Controls.Add(this.InfoTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TaskInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox InfoTextBox;
        private System.Windows.Forms.Button SaveEditButton;
        private System.Windows.Forms.Label TaskInfoTitleLabel;
    }
}