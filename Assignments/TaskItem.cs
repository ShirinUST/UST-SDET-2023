using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TaskItem
    {
        public TaskItem(int taskId, string? taskDescription, string isCompleted)
        {
            TaskId = taskId;
            TaskDescription = taskDescription;
            IsCompleted = isCompleted;
        }

        public int TaskId {  get; set; }
        public string? TaskDescription {  get; set; }
        public string? IsCompleted {  get; set; }
        public static List<TaskItem> TodoList= new List<TaskItem>();
        
        public static void RemoveTask(int id)
        {
            TodoList.RemoveAll(x => x.TaskId == id);
         
        }

        public static void UpdateTask(int Id)
        {
            var obj=TodoList.Find(x => x.TaskId == Id);
            if (obj != null)
            {
                //obj.TaskId = Id;
                obj.IsCompleted = "Completed";
            }
            else
            {
                Console.WriteLine("No such task exist");
            }
        }
        public static void DisplayTasks()
        {
            foreach(var task in TodoList)
            {
                Console.WriteLine(task.TaskId+"   "+task.TaskDescription+"   "+task.IsCompleted);
                Console.WriteLine("-------------------------------------------------------------");
            }

        }

    }
}
