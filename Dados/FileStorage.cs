using System.Collections.Generic;
using System.IO;

namespace Dados
{
    public class FileStorage
    {
        private string filePath = "tasks.txt";

        public List<string> LoadTasks()
        {
            if (!File.Exists(filePath))
            {
                return new List<string>();
            }

            return new List<string>(File.ReadAllLines(filePath));
        }

        public void SaveTasks(List<string> tasks)
        {
            File.WriteAllLines(filePath, tasks);
        }
    }
}
