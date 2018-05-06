using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDMLibrary.Models;

namespace TDMLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string TaskModels_File = "TaskModels.csv";
        
        /// <summary>
        /// Saves to a text file and returns a TaskModel
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        public TaskModel CreateTaskModel(TaskModel task)
        {
            // Gets the file, reads it and converts it into a TaskModel to be saved.
            List<TaskModel> tasks = TaskModels_File.FullFilePath().LoadFile().ConvertToTaskModel();
            
            int currentId = 1;
            if (tasks.Count > 0)
            {
                currentId = tasks.OrderByDescending(x => x.Id).First().Id + 1;
            }
            
            task.Id = currentId;
            tasks.Add(task);

            tasks.SaveToTaskModelsFile(TaskModels_File);


            return task;
        }


        public List<TaskModel> GetTaskModelsData()
        {
            return TaskModels_File.FullFilePath().LoadFile().ConvertToTaskModel();
        }


        public void RemoveTask(TaskModel task)
        {
            List<TaskModel> tasks = TaskModels_File.FullFilePath().LoadFile().ConvertToTaskModel();

            foreach (TaskModel t in tasks)
            {
                if (task.Name == t.Name && task.Descritpion == t.Descritpion)
                {
                    tasks.Remove(t);

                    t.RemoveTaskModelFromFile(TaskModels_File);

                    return;
                }
            }

            return;
        }


    }
}
