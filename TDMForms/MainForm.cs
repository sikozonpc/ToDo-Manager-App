﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TDMLibrary;
using TDMLibrary.DataAccess;
using TDMLibrary.Models;

namespace TDMForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

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
            taskListBox.Items.Add(task.Name +" : "+ task.Descritpion + "  for  "+ task.FinishDay);   
        }


        public void updateListBox()
        {
            // List placeholder that will be populated from the dataset 
            List<TaskModel> tasks = GlobalConfig.Connection.GetTaskModelsData();

            // Update the listbox on the UI
            foreach (TaskModel task in tasks)
            {
                taskListBox.Items.Add(task.Name + " : " + task.Descritpion + "  for  " + task.FinishDay);
            }

        }

        private void completeTaskButton_Click(object sender, EventArgs e)
        {
            taskListBox.Items.Remove(sender);
        }


        private void removeTaskButton_Click(object sender, EventArgs e)
        {
            

            // Send the task we selected to the DeleteTaskModel(desired_task)
            
            // connector.DeleteTaskModel();
        }
    }
}       