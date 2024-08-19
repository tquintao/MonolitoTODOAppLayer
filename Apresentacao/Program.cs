using System;
using Negocio;

namespace Apresentacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var todoManager = new TodoManager();

            while (true)
            {
                Console.WriteLine("To-Do List Application");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. List Tasks");
                Console.WriteLine("3. Remove Task");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddTask(todoManager);
                        break;
                    case "2":
                        ListTasks(todoManager);
                        break;
                    case "3":
                        RemoveTask(todoManager);
                        break;
                    case "4":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid option, try again.");
                        break;
                }
            }
        }

        static void AddTask(TodoManager todoManager)
        {
            Console.Write("Enter task description: ");
            var description = Console.ReadLine();
            todoManager.AddTask(description);
            Console.WriteLine("Task added.");
        }

        static void ListTasks(TodoManager todoManager)
        {
            var tasks = todoManager.GetTasks();
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }

        static void RemoveTask(TodoManager todoManager)
        {
            Console.Write("Enter task number to remove: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= todoManager.GetTasks().Count)
            {
                todoManager.RemoveTask(taskNumber - 1);
                Console.WriteLine("Task removed.");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }
    }
}
