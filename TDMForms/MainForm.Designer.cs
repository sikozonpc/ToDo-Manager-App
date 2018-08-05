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
            this.taskListBox = new System.Windows.Forms.ListBox();
            this.datesListBox = new System.Windows.Forms.ListBox();
            this.MainFormTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cloudButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.completeTaskButton = new System.Windows.Forms.Button();
            this.removeTaskButton = new System.Windows.Forms.Button();
            this.addNewTaskButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskListBox
            // 
            this.taskListBox.BackColor = System.Drawing.Color.ForestGreen;
            this.taskListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taskListBox.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskListBox.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.taskListBox.FormattingEnabled = true;
            this.taskListBox.HorizontalScrollbar = true;
            this.taskListBox.ItemHeight = 27;
            this.taskListBox.Location = new System.Drawing.Point(79, 69);
            this.taskListBox.Name = "taskListBox";
            this.taskListBox.Size = new System.Drawing.Size(293, 513);
            this.taskListBox.TabIndex = 10;
            this.taskListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.taskListBox_MouseDoubleClick);
            // 
            // datesListBox
            // 
            this.datesListBox.BackColor = System.Drawing.Color.ForestGreen;
            this.datesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datesListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datesListBox.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datesListBox.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.datesListBox.FormattingEnabled = true;
            this.datesListBox.HorizontalScrollbar = true;
            this.datesListBox.ItemHeight = 27;
            this.datesListBox.Location = new System.Drawing.Point(369, 69);
            this.datesListBox.Name = "datesListBox";
            this.datesListBox.Size = new System.Drawing.Size(128, 513);
            this.datesListBox.TabIndex = 11;
            this.datesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.taskListBox_MouseDoubleClick);
            // 
            // MainFormTitle
            // 
            this.MainFormTitle.AutoSize = true;
            this.MainFormTitle.Font = new System.Drawing.Font("Trebuchet MS", 45F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainFormTitle.ForeColor = System.Drawing.Color.White;
            this.MainFormTitle.Location = new System.Drawing.Point(-15, -10);
            this.MainFormTitle.Name = "MainFormTitle";
            this.MainFormTitle.Size = new System.Drawing.Size(298, 76);
            this.MainFormTitle.TabIndex = 25;
            this.MainFormTitle.Text = "ToDo App";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.settingsButton);
            this.panel2.Controls.Add(this.cloudButton);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(-2, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(83, 513);
            this.panel2.TabIndex = 26;
            // 
            // cloudButton
            // 
            this.cloudButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.cloudButton.BackgroundImage = global::TDMForms.Properties.Resources.cloud_computing;
            this.cloudButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cloudButton.FlatAppearance.BorderSize = 0;
            this.cloudButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cloudButton.ForeColor = System.Drawing.Color.Transparent;
            this.cloudButton.Location = new System.Drawing.Point(7, 309);
            this.cloudButton.Name = "cloudButton";
            this.cloudButton.Size = new System.Drawing.Size(67, 62);
            this.cloudButton.TabIndex = 28;
            this.cloudButton.UseVisualStyleBackColor = false;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.settingsButton.BackgroundImage = global::TDMForms.Properties.Resources.settings;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.ForeColor = System.Drawing.Color.Transparent;
            this.settingsButton.Location = new System.Drawing.Point(7, 241);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(67, 62);
            this.settingsButton.TabIndex = 27;
            this.settingsButton.UseVisualStyleBackColor = false;
            // 
            // completeTaskButton
            // 
            this.completeTaskButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.completeTaskButton.BackgroundImage = global::TDMForms.Properties.Resources.File_complete_icon;
            this.completeTaskButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.completeTaskButton.FlatAppearance.BorderSize = 0;
            this.completeTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completeTaskButton.ForeColor = System.Drawing.Color.Transparent;
            this.completeTaskButton.Location = new System.Drawing.Point(14, 164);
            this.completeTaskButton.Margin = new System.Windows.Forms.Padding(0);
            this.completeTaskButton.Name = "completeTaskButton";
            this.completeTaskButton.Size = new System.Drawing.Size(62, 53);
            this.completeTaskButton.TabIndex = 4;
            this.completeTaskButton.UseVisualStyleBackColor = false;
            this.completeTaskButton.Click += new System.EventHandler(this.completeTaskButton_Click);
            // 
            // removeTaskButton
            // 
            this.removeTaskButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.removeTaskButton.BackgroundImage = global::TDMForms.Properties.Resources.trash;
            this.removeTaskButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeTaskButton.FlatAppearance.BorderSize = 0;
            this.removeTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeTaskButton.ForeColor = System.Drawing.Color.Transparent;
            this.removeTaskButton.Location = new System.Drawing.Point(10, 230);
            this.removeTaskButton.Name = "removeTaskButton";
            this.removeTaskButton.Size = new System.Drawing.Size(63, 53);
            this.removeTaskButton.TabIndex = 2;
            this.removeTaskButton.UseVisualStyleBackColor = false;
            this.removeTaskButton.Click += new System.EventHandler(this.removeTaskButton_Click);
            // 
            // addNewTaskButton
            // 
            this.addNewTaskButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.addNewTaskButton.BackgroundImage = global::TDMForms.Properties.Resources.clipboard;
            this.addNewTaskButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addNewTaskButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addNewTaskButton.FlatAppearance.BorderSize = 0;
            this.addNewTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewTaskButton.ForeColor = System.Drawing.Color.Transparent;
            this.addNewTaskButton.Location = new System.Drawing.Point(10, 81);
            this.addNewTaskButton.Name = "addNewTaskButton";
            this.addNewTaskButton.Size = new System.Drawing.Size(70, 55);
            this.addNewTaskButton.TabIndex = 1;
            this.addNewTaskButton.UseVisualStyleBackColor = false;
            this.addNewTaskButton.Click += new System.EventHandler(this.addNewTaskButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(518, 557);
            this.Controls.Add(this.taskListBox);
            this.Controls.Add(this.datesListBox);
            this.Controls.Add(this.completeTaskButton);
            this.Controls.Add(this.removeTaskButton);
            this.Controls.Add(this.addNewTaskButton);
            this.Controls.Add(this.MainFormTitle);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.ForestGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To Do - Task Manager";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void taskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                
            
        }

        #endregion
        private System.Windows.Forms.Button removeTaskButton;
        private System.Windows.Forms.Button completeTaskButton;
        private System.Windows.Forms.Button addNewTaskButton;
        private System.Windows.Forms.ListBox taskListBox;
        private System.Windows.Forms.ListBox datesListBox;
        private System.Windows.Forms.Label MainFormTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button cloudButton;
    }
}

