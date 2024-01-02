using DesignPatternsApp.Patterns.FactoryMethod.Abstract;
using DesignPatternsApp.Patterns.FactoryMethod.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.FactoryMethod.Creators
{
    public class CreatorBangalore : Creator
    {
        public override CharacterBangalore FactoryMethod()
        {
            return new CharacterBangalore()
            {
                Id = Guid.NewGuid(),
                Description = "Bangalore é uma Lenda estratégica. A sua habilidade tática lança uma cortina de fumaça que reduz fortemente a visibilidade na área afetada. A sua habilidade passiva Tempo Duplo dá-lhe um aumento de velocidade de movimento quando é atingida por um disparo."
            };
        }
    }
}
