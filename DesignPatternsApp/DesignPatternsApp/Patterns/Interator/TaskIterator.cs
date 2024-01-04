using DesignPatternsApp.Patterns.Interator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.Interator
{
    public class TaskIterator : IIterator
    {
        private TaskList taskList;
        private int currentIndex = 0;

        public TaskIterator(TaskList list)
        {
            taskList = list;
        }

        public string First()
        {
            currentIndex = 0;
            return taskList.GetTask(currentIndex);
        }

        public string Next()
        {
            currentIndex++;
            return IsDone() ? null : taskList.GetTask(currentIndex);
        }

        public bool IsDone()
        {
            return currentIndex >= taskList.CountTasks();
        }

        public string CurrentItem()
        {
            return taskList.GetTask(currentIndex);
        }
    }
}
