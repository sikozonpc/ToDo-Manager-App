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

namespace TDMForms
{
    public partial class TaskInformation : Form
    {
        private int _id;
        private string _name;

        // Reference to the main form
        private MainForm _mainForm;
        public TaskInformation(MainForm mainForm ,int id, string name, string description)
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

            // Refractor the new text for data text readability
            changedDescription = RemoveLines(changedDescription);

            // send new description to the database

            GlobalConfig.Connection.ChangeDescription(_id ,changedDescription);

            // Update main form
            _mainForm.updateListBox();

            Close();
        }

        private string RemoveLines(string line)
        {
            string result = Regex.Replace(line, @"\n", " ");

            return result;
        }
    }
}
