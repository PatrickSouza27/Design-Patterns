using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world2.Enum;
using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world2.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns
{
    internal class GuinchoPequenoPorte : Guincho
    {
        public GuinchoPequenoPorte(Porte porte) : base(porte)
        {
        }

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine("Guincho Pequeno Porte - Veiculo Modelo: " +  veiculo.Modelo);
        }
    }
}
