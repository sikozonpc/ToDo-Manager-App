namespace TDMForms
{
    partial class AddTaskForm
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
            this.addTaskButton = new System.Windows.Forms.Button();
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.taskDescriptionLabel = new System.Windows.Forms.Label();
            this.taskNameValue = new System.Windows.Forms.TextBox();
            this.taskDescriptionValue = new System.Windows.Forms.TextBox();
            this.completeDayLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // addTaskButton
            // 
            this.addTaskButton.BackColor = System.Drawing.Color.Maroon;
            this.addTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTaskButton.ForeColor = System.Drawing.Color.White;
            this.addTaskButton.Location = new System.Drawing.Point(236, 227);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(90, 31);
            this.addTaskButton.TabIndex = 2;
            this.addTaskButton.Text = "Add Task";
            this.addTaskButton.UseVisualStyleBackColor = false;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskNameLabel.Location = new System.Drawing.Point(12, 9);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(106, 24);
            this.taskNameLabel.TabIndex = 3;
            this.taskNameLabel.Text = "Task Name";
            // 
            // taskDescriptionLabel
            // 
            this.taskDescriptionLabel.AutoSize = true;
            this.taskDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDescriptionLabel.Location = new System.Drawing.Point(12, 61);
            this.taskDescriptionLabel.Name = "taskDescriptionLabel";
            this.taskDescriptionLabel.Size = new System.Drawing.Size(149, 24);
            this.taskDescriptionLabel.TabIndex = 4;
            this.taskDescriptionLabel.Text = "Task Description";
            // 
            // taskNameValue
            // 
            this.taskNameValue.Location = new System.Drawing.Point(162, 9);
            this.taskNameValue.Multiline = true;
            this.taskNameValue.Name = "taskNameValue";
            this.taskNameValue.Size = new System.Drawing.Size(383, 32);
            this.taskNameValue.TabIndex = 5;
            // 
            // taskDescriptionValue
            // 
            this.taskDescriptionValue.Location = new System.Drawing.Point(162, 61);
            this.taskDescriptionValue.Multiline = true;
            this.taskDescriptionValue.Name = "taskDescriptionValue";
            this.taskDescriptionValue.Size = new System.Drawing.Size(383, 98);
            this.taskDescriptionValue.TabIndex = 6;
            // 
            // completeDayLabel
            // 
            this.completeDayLabel.AutoSize = true;
            this.completeDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeDayLabel.Location = new System.Drawing.Point(12, 165);
            this.completeDayLabel.Name = "completeDayLabel";
            this.completeDayLabel.Size = new System.Drawing.Size(128, 24);
            this.completeDayLabel.TabIndex = 7;
            this.completeDayLabel.Text = "Complete Day";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(162, 179);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(383, 20);
            this.dateTimePicker.TabIndex = 8;
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 261);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.completeDayLabel);
            this.Controls.Add(this.taskDescriptionValue);
            this.Controls.Add(this.taskNameValue);
            this.Controls.Add(this.taskDescriptionLabel);
            this.Controls.Add(this.taskNameLabel);
            this.Controls.Add(this.addTaskButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.Label taskNameLabel;
        private System.Windows.Forms.Label taskDescriptionLabel;
        private System.Windows.Forms.TextBox taskNameValue;
        private System.Windows.Forms.TextBox taskDescriptionValue;
        private System.Windows.Forms.Label completeDayLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}