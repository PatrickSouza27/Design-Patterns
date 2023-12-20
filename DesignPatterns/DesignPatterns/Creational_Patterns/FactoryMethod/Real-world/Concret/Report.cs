using DesignPatterns.Creational_Patterns.FactoryMethod.Real_World.Concret.Products;
using DesignPatterns.Creational_Patterns.FactoryMethod.Real_World.CreatorAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.FactoryMethod.Real_World.Concret
{
    internal class Report : DocumentCreator
    {
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}
