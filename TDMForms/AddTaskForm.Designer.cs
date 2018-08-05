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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTaskForm));
            this.addTaskButton = new System.Windows.Forms.Button();
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.taskDescriptionLabel = new System.Windows.Forms.Label();
            this.taskNameValue = new System.Windows.Forms.TextBox();
            this.taskDescriptionValue = new System.Windows.Forms.TextBox();
            this.completeDayLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.closeTaskWindowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addTaskButton
            // 
            this.addTaskButton.BackColor = System.Drawing.Color.Transparent;
            this.addTaskButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addTaskButton.BackgroundImage")));
            this.addTaskButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addTaskButton.FlatAppearance.BorderSize = 0;
            this.addTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTaskButton.ForeColor = System.Drawing.Color.White;
            this.addTaskButton.Location = new System.Drawing.Point(214, 209);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(46, 31);
            this.addTaskButton.TabIndex = 2;
            this.addTaskButton.UseVisualStyleBackColor = false;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskNameLabel.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.taskNameLabel.Location = new System.Drawing.Point(5, 11);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(61, 24);
            this.taskNameLabel.TabIndex = 3;
            this.taskNameLabel.Text = "Name";
            // 
            // taskDescriptionLabel
            // 
            this.taskDescriptionLabel.AutoSize = true;
            this.taskDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDescriptionLabel.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.taskDescriptionLabel.Location = new System.Drawing.Point(5, 61);
            this.taskDescriptionLabel.Name = "taskDescriptionLabel";
            this.taskDescriptionLabel.Size = new System.Drawing.Size(104, 24);
            this.taskDescriptionLabel.TabIndex = 4;
            this.taskDescriptionLabel.Text = "Description";
            // 
            // taskNameValue
            // 
            this.taskNameValue.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.taskNameValue.Location = new System.Drawing.Point(115, 11);
            this.taskNameValue.Multiline = true;
            this.taskNameValue.Name = "taskNameValue";
            this.taskNameValue.Size = new System.Drawing.Size(383, 32);
            this.taskNameValue.TabIndex = 5;
            // 
            // taskDescriptionValue
            // 
            this.taskDescriptionValue.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.taskDescriptionValue.Location = new System.Drawing.Point(115, 66);
            this.taskDescriptionValue.Multiline = true;
            this.taskDescriptionValue.Name = "taskDescriptionValue";
            this.taskDescriptionValue.Size = new System.Drawing.Size(383, 98);
            this.taskDescriptionValue.TabIndex = 6;
            // 
            // completeDayLabel
            // 
            this.completeDayLabel.AutoSize = true;
            this.completeDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeDayLabel.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.completeDayLabel.Location = new System.Drawing.Point(5, 170);
            this.completeDayLabel.Name = "completeDayLabel";
            this.completeDayLabel.Size = new System.Drawing.Size(128, 24);
            this.completeDayLabel.TabIndex = 7;
            this.completeDayLabel.Text = "Complete Day";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.LightGoldenrodYellow;
            this.dateTimePicker.Location = new System.Drawing.Point(9, 197);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(164, 20);
            this.dateTimePicker.TabIndex = 8;
            // 
            // closeTaskWindowButton
            // 
            this.closeTaskWindowButton.BackColor = System.Drawing.Color.Transparent;
            this.closeTaskWindowButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeTaskWindowButton.BackgroundImage")));
            this.closeTaskWindowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeTaskWindowButton.FlatAppearance.BorderSize = 0;
            this.closeTaskWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeTaskWindowButton.ForeColor = System.Drawing.Color.White;
            this.closeTaskWindowButton.Location = new System.Drawing.Point(266, 209);
            this.closeTaskWindowButton.Name = "closeTaskWindowButton";
            this.closeTaskWindowButton.Size = new System.Drawing.Size(44, 31);
            this.closeTaskWindowButton.TabIndex = 9;
            this.closeTaskWindowButton.UseVisualStyleBackColor = false;
            this.closeTaskWindowButton.Click += new System.EventHandler(this.closeTaskWindowButton_Click);
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(505, 251);
            this.Controls.Add(this.closeTaskWindowButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.completeDayLabel);
            this.Controls.Add(this.taskDescriptionValue);
            this.Controls.Add(this.taskNameValue);
            this.Controls.Add(this.taskDescriptionLabel);
            this.Controls.Add(this.taskNameLabel);
            this.Controls.Add(this.addTaskButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "New Task";
            this.Load += new System.EventHandler(this.AddTaskForm_Load);
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
        private System.Windows.Forms.Button closeTaskWindowButton;
    }
}