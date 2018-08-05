using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using TDMLibrary;
using TDMLibrary.DataAccess;
using TDMLibrary.Models;

namespace TDMForms
{
    public partial class AddTaskForm : Form
    {
        // Reference to the Main Form
        private MainForm _mainForm;
        public AddTaskForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }


        //TODO - Change the name of this button because of the conflit with the main form
        private void addTaskButton_Click(object sender, EventArgs e)
        {
            // Security check for error in the text boxes
            if (taskNameValue.Text.Length == 0 || taskNameValue.Text.Length >= 100)
            {
                MessageBox.Show("Task Name neded to create a task!", "Task Name Error");
            }
            else
            {
                // Removes the lines from the text boxes so it doesnt mess with the data
                taskDescriptionValue.Text = RemoveLines(taskDescriptionValue.Text);
                taskNameValue.Text = RemoveLines(taskNameValue.Text);

                // Create a new TaskModel if succeded
                TaskModel task = new TaskModel(taskNameValue.Text,
                    taskDescriptionValue.Text,
                    dateTimePicker.Value.ToShortDateString(),
                    false);

                // Send the TaskModel to the data saving type
                GlobalConfig.Connection.CreateTaskModel(task);

                // calls the  addToListBox method in the main form
                _mainForm.addToListBox(task);

                // Closes the window
                this.Close();
            } 

        }

        private string RemoveLines(string line)
        {

            string result = Regex.Replace(line, @"\r\n", " ");


            return result;
        }

        private void closeTaskWindowButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddTaskForm_Load(object sender, EventArgs e)
        {

        }
    }
}
