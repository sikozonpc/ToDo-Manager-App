using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TDMLibrary.Models;

namespace TDMLibrary.DataAccess
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            // Gets the key of filePath from App.Config and adds the fileName to create the full file path

            return $@"{ ConfigurationManager.AppSettings["filePath"] }\{ fileName }";
        }


        public static List<string> LoadFile(this string file)
        {
            if (File.Exists(file) == false)
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }


        /// <summary>
        /// Reads the lines and populates it into a TaskModel 
        /// </summary>
        /// <param name="lines"> List of the lines of the tasks file </param>
        /// <returns></returns>
        public static List<TaskModel> ConvertToTaskModel(this List<string> lines)
        {
            List<TaskModel> output = new List<TaskModel>();


            foreach(string line in lines)
            {
                // Remove spaces from the descritpion
                //line.Replace(System.Environment.NewLine, "1");
                
                // TODO - Split into sections to populate the model 
                string[] cols = line.Split('|');

                TaskModel model = new TaskModel();

                model.Id = int.Parse(cols[0]);
                model.Name = cols[1];
                model.Descritpion = cols[2];
                // TODO convert bool
                model.Completed = Boolean.Parse(cols[3]);
                
                output.Add(model);
            }

            return output;
        }


        public static void SaveToTaskModelsFile(this List<TaskModel> tasks, string fileName)
        {
            List<string> lines = new List<string>();

            foreach(TaskModel task in tasks)
            {
                lines.Add($"{ task.Id }| { task.Name }| { task.Descritpion }| { task.Completed }");

                File.WriteAllLines(fileName.FullFilePath(), lines);
            }
        }

        public static void RemoveTaskModelFromFile(this TaskModel task, string fileName)
        {
           // REMove
        }
    }
}
