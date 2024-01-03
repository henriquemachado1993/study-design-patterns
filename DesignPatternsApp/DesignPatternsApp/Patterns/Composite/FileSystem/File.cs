using DesignPatternsApp.Patterns.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.Composite.FileSystem
{
    public class File : IFileSystemComponent
    {
        private string _name;

        public File(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void Display(string path = "")
        {
            Console.WriteLine($"{path}/{_name}");
        }
    }
}
