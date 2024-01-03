using DesignPatternsApp.Patterns.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.Composite.FileSystem
{
    public class Folder : IFileSystemComponent
    {
        private string _name;
        private List<IFileSystemComponent> _children = new List<IFileSystemComponent>();

        public Folder(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void Add(IFileSystemComponent component)
        {
            _children.Add(component);
        }

        public void Remove(IFileSystemComponent component)
        {
            _children.Remove(component);
        }

        public void Display(string path = "")
        {
            Console.WriteLine($"{path}/{_name}");
            path = $"{path}/{_name}";

            foreach (var component in _children)
            {
                component.Display(path);
            }
        }
    }
}
