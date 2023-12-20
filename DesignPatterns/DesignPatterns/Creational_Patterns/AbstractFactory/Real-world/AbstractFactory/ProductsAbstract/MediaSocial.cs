using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.AbstractFactory.Real_world.AbstractFactory.Products
{
    internal abstract class MediaSocial
    {
        public abstract void Post(string title, string body);
        public abstract void Like();
    }
}
