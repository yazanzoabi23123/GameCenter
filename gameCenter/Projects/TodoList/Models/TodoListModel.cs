using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace gameCenter.Projects.TodoList.Models
{
    internal class TodoListModel
    {
        public ObservableCollection<TodoTask> TodoList { get; set; }


        //properties
        //List of tasks - ObservableCollection
        public List<TodoTask> Tasks { get; set; }


        //methods
        //Constructor
        public TodoListModel()
        {
            Tasks = new List<TodoTask>();
        }
        //Update Task(int id)
        public void UpdateTask(int taskId, string newDescription)
        {
            TodoTask task = Tasks.Find(task => task.Id == taskId);
            if (task != null)
            {
                task.Description = newDescription;
            }
            else
            {
                throw new Exception("The task with this Id wasn't found");
            }
        }
        //ToggleTaskIsComplete(int id)
        public void ToggleTaskIsComplete(int taskId)
        {
            TodoTask task = Tasks.Find(task => task.Id == taskId);
            if (task != null)
            {
                task.IsComplete = !task.IsComplete;
            }
            else
            {
                throw new Exception("The task with this Id wasn't found");
            }
        }
        //AddNewTask(task)
        public void AddNewTask(TodoTask task)
        {
            Tasks.Add(task);
        }

    }
}