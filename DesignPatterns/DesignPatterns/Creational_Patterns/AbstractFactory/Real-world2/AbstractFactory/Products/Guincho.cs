using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world2.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.AbstractFactory.Real_world2.Factory
{
    internal abstract class Guincho
    {
        public Porte Porte { get; }
        protected Guincho(Porte porte)
            => Porte = porte;

        public abstract void Socorrer(Veiculo veiculo);
    
    }
}
