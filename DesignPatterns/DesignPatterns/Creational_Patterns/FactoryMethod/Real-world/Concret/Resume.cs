using DesignPatterns.Creational_Patterns.FactoryMethod.Real_World.Concret.Products;
using DesignPatterns.Creational_Patterns.FactoryMethod.Real_World.CreatorAbstract;
using DesignPatterns.Creational_Patterns.FactoryMethod.Real_World.CreatorAbstract.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.FactoryMethod.Real_World.Concret
{
    internal class Resume : DocumentCreator
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
}
