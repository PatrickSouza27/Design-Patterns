using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world.AbstractFactory;
using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world.AbstractFactory.Products;
using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.AbstractFactory.Real_world
{
    public class Client
    {
        static void Main()
        {
            AbstractFactorySocial rede = new MediaSocialFactory();
            var mediasocial = rede.CreateMediaSocial();
            mediasocial.Post("Title", "estou fazendo um post");
            mediasocial.Like();
        }
    }
}
