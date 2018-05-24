using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDMLibrary;

namespace TDMForms
{
    public partial class TaskInfo : Form
    {
        private int _id;
        private string _name;

        // Reference to the main form
        private MainForm _mainForm;
        public TaskInfo(MainForm mainForm ,int id, string name, string description)
        {
            InitializeComponent();
            _mainForm = mainForm;

            TaskInfoTitleLabel.Text = name;
            InfoTextBox.Text = description;

            _id = id;
            _name = name;
        }


        private void SaveEditButton_Click(object sender, EventArgs e)
        {
            string changedDescription = InfoTextBox.Text;

            if (changedDescription == String.Empty )
            {
                return;
            }

            // send new description to the database

            GlobalConfig.Connection.ChangeDescription(_id ,changedDescription);

            // Update main form
            _mainForm.updateListBox();

            Close();
        }
    }
}
