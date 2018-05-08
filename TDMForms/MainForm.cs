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
    public partial class MainForm : Form
    {
        // Data source for the listbox
        private List<TaskModel> allTaks = GlobalConfig.Connection.GetTaskModelsData();


        public MainForm()
        {
            InitializeComponent();

            taskListBox.DataSource = allTaks;
            taskListBox.DisplayMember = "DisplayProperties";

            updateListBox();
        }

        private void addNewTaskButton_Click(object sender, EventArgs e)
        {
            // Creates a new instace of AddTaskForm and opens it to fill the data
            AddTaskForm addTaskForm = new AddTaskForm(this);
            addTaskForm.Show();
        }

        public void addToListBox(TaskModel task)
        {
            allTaks.Add(task);

            updateListBox();
        }


        public void updateListBox()
        {
            taskListBox.DataSource = null;

            taskListBox.DataSource = allTaks;
            taskListBox.DisplayMember = "DisplayProperties";
        }

        private void completeTaskButton_Click(object sender, EventArgs e)
        {
            // TODO - Wire up complete task button 
        }


        private void removeTaskButton_Click(object sender, EventArgs e)
        {
            TaskModel task = (TaskModel)taskListBox.SelectedItem;

           
            if ( task != null)
            {
                allTaks.Remove(task);
                GlobalConfig.Connection.RemoveTask(task, allTaks);

                updateListBox();
            }
        }

    }
}       