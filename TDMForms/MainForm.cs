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
        public List<TaskModel> allTaks = GlobalConfig.Connection.GetTaskModelsData();


        //private int lastYPosition = 0;
        //private int increment = 25;

        
        public MainForm()
        {
            InitializeComponent();

            taskListBox.DataSource = allTaks;
            datesListBox.DataSource = allTaks;
            taskListBox.DisplayMember = "Name";
            datesListBox.DisplayMember = "FinishDay";


            updateListBox();
            

            /*
             *  Dynanic button task info generation system  got replaced by double click
             *  
            // Generate buttons 
            int padding = 0;
            foreach (TaskModel task in allTaks)
            {
                GenerateInfoButton(task.Id, task.Descritpion, 0, padding);
                padding += increment;
            }

            lastYPosition = padding;
            increment = 0;
            */
        }

        public void updateListBox()
        {
            allTaks = GlobalConfig.Connection.GetTaskModelsData();

            taskListBox.DataSource = null;
            datesListBox.DataSource = null;

            taskListBox.DataSource = allTaks;
            datesListBox.DataSource = allTaks;
            taskListBox.DisplayMember = "Name";
            datesListBox.DisplayMember = "FinishDay";
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

            //GenerateInfoButton(task.Id, task.Descritpion, 0, lastYPosition + increment);

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

                foreach (Control item in Controls.OfType<Button>())
                {
                    if (item.Name == task.Id.ToString())
                        Controls.Remove(item);
                }
            }
        }


        private void CreateTaskInfoWindow(int id, string name, string description)
        {
        
            TaskInformation taskInfo = new TaskInformation(this ,id ,name, description);
            taskInfo.Show();

        }

        /* 
         *  Dynanic button task info generation system  got replaced by double click
         *  
         *  
        public void GenerateInfoButton(int id, string description, int x_increment, int y_increment)
        {
            Button but = new Button();
            but.Name = id.ToString();
            but.BackColor = Color.White;
            but.Text = "+";
            but.Size = new System.Drawing.Size(50, 25);

            System.Drawing.Point locat = new System.Drawing.Point(450 + x_increment , 70 + y_increment);

            but.Location = locat;
            but.Show();
            but.BringToFront();

            but.Click += (sender, EventArgs) => { buttClick(sender, EventArgs, description); };


            Controls.Add(but);
            
        }
        */

        private void taskListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TaskModel selectedItem = (TaskModel)taskListBox.SelectedItem;
            CreateTaskInfoWindow(selectedItem.Id ,selectedItem.Name, selectedItem.Descritpion);

        }
    }
}       