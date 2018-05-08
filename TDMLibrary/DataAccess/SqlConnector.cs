using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TDMLibrary.Models;
using System.Data;

using Dapper;


namespace TDMLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string Db = "ToDo Manager App";


        /// <summary>
        /// Saves a new TaskModel to the database and return it
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        public TaskModel CreateTaskModel(TaskModel task)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(Db)))
            {
                var p = new DynamicParameters();
                p.Add("@Name", task.Name);
                p.Add("@Description", task.Descritpion);
                p.Add("@id", 0, DbType.Int32, direction: ParameterDirection.Output);

                // Executes the store procedure to insert the task data
                connection.Execute("dbo.spTaskModels_Insert", p, commandType: CommandType.StoredProcedure);

                task.Id = p.Get<int>("@id");

                return task;
            }

        }

        /// <summary>
        /// Returns a list of populated TaskModels from the database
        /// </summary>
        /// <returns></returns>
        public List<TaskModel> GetTaskModelsData()
        {
            List<TaskModel> tasks = new List<TaskModel>();

            
            // Logic of connecting and retrieving the data from the Sql Database
            using (SqlConnection connection = new SqlConnection(GlobalConfig.CnnString(Db)))
            {
                string cmdString = "select * from dbo.tasksModels";
                SqlCommand cmd = new SqlCommand(cmdString, connection);

                connection.Open();
                using (SqlDataReader cmdReader = cmd.ExecuteReader())
                {
                    while (cmdReader.Read())
                    {
                        TaskModel model = new TaskModel();

                        model.Name = cmdReader["Name"].ToString();
                        model.Descritpion = cmdReader["Description"].ToString();
                        model.Id = int.Parse(cmdReader["id"].ToString());

                        // Adding to the list the data
                        tasks.Add(model);
                    }
                    connection.Close();
                }
            }
            return tasks;
        }


        public void RemoveTask(TaskModel task, List<TaskModel> tasksList = null)
        {
            throw new NotImplementedException();
            // Connection to the database
            // Delete in the database 
        }
    }
}
