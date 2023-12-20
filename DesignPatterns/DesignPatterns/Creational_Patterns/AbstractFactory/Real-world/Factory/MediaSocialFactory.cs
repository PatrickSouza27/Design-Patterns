using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world.AbstractFactory;
using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world.AbstractFactory.Products;
using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world.Factory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.AbstractFactory.Real_world.Factory
{
    internal class MediaSocialFactory : AbstractFactorySocial
    {
        public override MediaSocial CreateMediaSocial()
        {
            //coloco a rede social q quero criar na fabrica
            return new Twitter();
        }
    }
}
