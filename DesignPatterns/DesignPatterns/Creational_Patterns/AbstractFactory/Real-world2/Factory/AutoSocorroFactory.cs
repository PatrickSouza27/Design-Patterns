using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world2.AbstractFactory;
using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world2.Enum;
using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world2.Factory.Products.GuinchoFactory;
using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world2.Factory.Products.VeiculoFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.AbstractFactory.Real_world2.Factory
{
    internal class AutoSocorroFactory : AutoSocorroFactoryAbstract
    {
        public override Guincho CriarGuincho()
        {
            return GuinchoCreator.Criar(Porte.Pequeno);
        }

        public override Veiculo CriarVeiculo(string modelo, Porte porte)
        {
            return VeiculoCreator.Criar(modelo, porte);
        }
    }
}
