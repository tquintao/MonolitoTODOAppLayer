using System.Collections.Generic;
using Dados;

namespace Negocio
{
    public class TodoManager
    {
        private List<string> tasks;
        private FileStorage storage;

        public TodoManager()
        {
            storage = new FileStorage();
            tasks = storage.LoadTasks();
        }

        public void AddTask(string description)
        {
            tasks.Add(description);
            storage.SaveTasks(tasks);
        }

        public List<string> GetTasks()
        {
            return tasks;
        }

        public void RemoveTask(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks.RemoveAt(index);
                storage.SaveTasks(tasks);
            }
        }
    }
}
