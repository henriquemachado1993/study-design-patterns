using DesignPatternsApp.Patterns.Interator.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.Interator
{
    public class TaskList : ITaskCollection
    {
        private List<string> tasks = new List<string>();

        public IIterator GetIterator()
        {
            return new TaskIterator(this);
        }

        public void AddTask(string task)
        {
            tasks.Add(task);
        }

        public int CountTasks()
        {
            return tasks.Count;
        }

        public string GetTask(int index)
        {
            return tasks[index];
        }
    }
}
