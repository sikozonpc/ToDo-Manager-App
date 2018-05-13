using System;
using TDMLibrary;
using TDMLibrary.Models;

namespace TDMForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.addNewTaskButton = new System.Windows.Forms.Button();
            this.removeTaskButton = new System.Windows.Forms.Button();
            this.completeTaskButton = new System.Windows.Forms.Button();
            this.taskListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addNewTaskButton
            // 
            this.addNewTaskButton.BackColor = System.Drawing.Color.Transparent;
            this.addNewTaskButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addNewTaskButton.FlatAppearance.BorderSize = 0;
            this.addNewTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewTaskButton.ForeColor = System.Drawing.Color.Transparent;
            this.addNewTaskButton.Image = ((System.Drawing.Image)(resources.GetObject("addNewTaskButton.Image")));
            this.addNewTaskButton.Location = new System.Drawing.Point(134, 3);
            this.addNewTaskButton.Name = "addNewTaskButton";
            this.addNewTaskButton.Size = new System.Drawing.Size(43, 53);
            this.addNewTaskButton.TabIndex = 1;
            this.addNewTaskButton.UseVisualStyleBackColor = false;
            this.addNewTaskButton.Click += new System.EventHandler(this.addNewTaskButton_Click);
            // 
            // removeTaskButton
            // 
            this.removeTaskButton.BackColor = System.Drawing.Color.Transparent;
            this.removeTaskButton.FlatAppearance.BorderSize = 0;
            this.removeTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeTaskButton.ForeColor = System.Drawing.Color.White;
            this.removeTaskButton.Image = ((System.Drawing.Image)(resources.GetObject("removeTaskButton.Image")));
            this.removeTaskButton.Location = new System.Drawing.Point(183, -4);
            this.removeTaskButton.Name = "removeTaskButton";
            this.removeTaskButton.Size = new System.Drawing.Size(73, 67);
            this.removeTaskButton.TabIndex = 2;
            this.removeTaskButton.UseVisualStyleBackColor = false;
            this.removeTaskButton.Click += new System.EventHandler(this.removeTaskButton_Click);
            // 
            // completeTaskButton
            // 
            this.completeTaskButton.BackColor = System.Drawing.Color.Maroon;
            this.completeTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completeTaskButton.ForeColor = System.Drawing.Color.White;
            this.completeTaskButton.Location = new System.Drawing.Point(286, 18);
            this.completeTaskButton.Name = "completeTaskButton";
            this.completeTaskButton.Size = new System.Drawing.Size(58, 22);
            this.completeTaskButton.TabIndex = 4;
            this.completeTaskButton.Text = "Done";
            this.completeTaskButton.UseVisualStyleBackColor = false;
            this.completeTaskButton.Click += new System.EventHandler(this.completeTaskButton_Click);
            // 
            // taskListBox
            // 
            this.taskListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskListBox.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskListBox.FormattingEnabled = true;
            this.taskListBox.HorizontalScrollbar = true;
            this.taskListBox.ItemHeight = 28;
            this.taskListBox.Location = new System.Drawing.Point(108, 68);
            this.taskListBox.Name = "taskListBox";
            this.taskListBox.Size = new System.Drawing.Size(447, 504);
            this.taskListBox.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(550, 591);
            this.Controls.Add(this.taskListBox);
            this.Controls.Add(this.completeTaskButton);
            this.Controls.Add(this.removeTaskButton);
            this.Controls.Add(this.addNewTaskButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To Do - Task Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        private void taskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                
            
        }

        #endregion
        private System.Windows.Forms.Button removeTaskButton;
        private System.Windows.Forms.Button completeTaskButton;
        private System.Windows.Forms.Button addNewTaskButton;
        private System.Windows.Forms.ListBox taskListBox;
    }
}

