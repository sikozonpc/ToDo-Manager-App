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
            this.addNewTaskButton = new System.Windows.Forms.Button();
            this.removeTaskButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.taskListBox = new System.Windows.Forms.ListBox();
            this.completeTaskButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addNewTaskButton
            // 
            this.addNewTaskButton.BackColor = System.Drawing.Color.Maroon;
            this.addNewTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewTaskButton.ForeColor = System.Drawing.Color.White;
            this.addNewTaskButton.Location = new System.Drawing.Point(12, 12);
            this.addNewTaskButton.Name = "addNewTaskButton";
            this.addNewTaskButton.Size = new System.Drawing.Size(90, 31);
            this.addNewTaskButton.TabIndex = 1;
            this.addNewTaskButton.Text = "Add New Task";
            this.addNewTaskButton.UseVisualStyleBackColor = false;
            this.addNewTaskButton.Click += new System.EventHandler(this.addNewTaskButton_Click);
            // 
            // removeTaskButton
            // 
            this.removeTaskButton.BackColor = System.Drawing.Color.Maroon;
            this.removeTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeTaskButton.ForeColor = System.Drawing.Color.White;
            this.removeTaskButton.Location = new System.Drawing.Point(108, 12);
            this.removeTaskButton.Name = "removeTaskButton";
            this.removeTaskButton.Size = new System.Drawing.Size(90, 31);
            this.removeTaskButton.TabIndex = 2;
            this.removeTaskButton.Text = "Remove Task";
            this.removeTaskButton.UseVisualStyleBackColor = false;
            this.removeTaskButton.Click += new System.EventHandler(this.removeTaskButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.taskListBox);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 309);
            this.panel1.TabIndex = 3;
            // 
            // taskListBox
            // 
            this.taskListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskListBox.FormattingEnabled = true;
            this.taskListBox.HorizontalScrollbar = true;
            this.taskListBox.ItemHeight = 24;
            this.taskListBox.Location = new System.Drawing.Point(3, 3);
            this.taskListBox.Name = "taskListBox";
            this.taskListBox.Size = new System.Drawing.Size(600, 292);
            this.taskListBox.TabIndex = 0;
            this.taskListBox.SelectedIndexChanged += new System.EventHandler(this.taskListBox_SelectedIndexChanged);
            // 
            // completeTaskButton
            // 
            this.completeTaskButton.BackColor = System.Drawing.Color.Maroon;
            this.completeTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completeTaskButton.ForeColor = System.Drawing.Color.White;
            this.completeTaskButton.Location = new System.Drawing.Point(311, 50);
            this.completeTaskButton.Name = "completeTaskButton";
            this.completeTaskButton.Size = new System.Drawing.Size(58, 22);
            this.completeTaskButton.TabIndex = 4;
            this.completeTaskButton.Text = "Done";
            this.completeTaskButton.UseVisualStyleBackColor = false;
            this.completeTaskButton.Click += new System.EventHandler(this.completeTaskButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 396);
            this.Controls.Add(this.completeTaskButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.removeTaskButton);
            this.Controls.Add(this.addNewTaskButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To Do - Task Manager";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void taskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                
            
        }

        #endregion

        private System.Windows.Forms.Button addNewTaskButton;
        private System.Windows.Forms.Button removeTaskButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox taskListBox;
        private System.Windows.Forms.Button completeTaskButton;
    }
}

