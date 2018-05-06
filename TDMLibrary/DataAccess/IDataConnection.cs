using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDMLibrary.Models;

namespace TDMLibrary.DataAccess
{
    public interface IDataConnection
    {
        TaskModel CreateTaskModel(TaskModel model);

        List<TaskModel> GetTaskModelsData();

        void RemoveTask(TaskModel task);
    }
}
