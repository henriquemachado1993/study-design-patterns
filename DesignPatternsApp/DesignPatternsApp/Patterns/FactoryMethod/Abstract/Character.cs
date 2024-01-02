using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.FactoryMethod.Abstract
{
    public abstract class Character
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
    }
}
