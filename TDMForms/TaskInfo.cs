using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDMForms
{
    public partial class TaskInfo : Form
    {
        public TaskInfo(string description)
        {
            InitializeComponent();

            infoTextBox.Text = description;
        }

    
    }
}
