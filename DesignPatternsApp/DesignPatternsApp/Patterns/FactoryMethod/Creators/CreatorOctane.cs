using DesignPatternsApp.Patterns.FactoryMethod.Abstract;
using DesignPatternsApp.Patterns.FactoryMethod.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.FactoryMethod.Creators
{
    public class CreatorOctane : Creator
    {
        public override CharacterOctane FactoryMethod()
        {
            return new CharacterOctane()
            {
                Id = Guid.NewGuid(),
                Description = "Acrobata de Alta Velocidade - Otávio 'Octane' Silva está em busca da adrenalina máxima utilizando seus movimentos que desafiam a morte para se tornar Triunfante Apex."
            };
        }
    }
}
