using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world2.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.AbstractFactory.Real_world2.Factory.Products.GuinchoFactory
{
    internal static class GuinchoCreator
    {
        public static Guincho Criar(Porte porte)
        {
            return porte switch
            {
                Porte.Pequeno => new GuinchoPequenoPorte(porte),
                Porte.Medio => new GuinchoMedioPorte(porte),
                Porte.Grande => new GuinchoGrandePorte(porte),
                _ => throw new ApplicationException("Porte de Guincho Desconhecido"),
            };
        }
    }
}
