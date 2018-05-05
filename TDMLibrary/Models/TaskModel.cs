using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDMLibrary.Models
{
    public class TaskModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Descritpion { get; set; }

        public DateTime FinishDay { get; set; }

        public bool Completed { get; set; }

        public TaskModel()
        {

        }

        public TaskModel(string name, string description, DateTime finishDay, bool completed)
        {
            Name = name;
            Descritpion = description;
            FinishDay = finishDay;
            Completed = completed;

        }

        
    }
}
