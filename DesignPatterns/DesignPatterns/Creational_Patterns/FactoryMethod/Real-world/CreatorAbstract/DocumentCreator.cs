using DesignPatterns.Creational_Patterns.FactoryMethod.Real_World.CreatorAbstract.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.FactoryMethod.Real_World.CreatorAbstract
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    internal abstract class DocumentCreator
    {
        private List<Page> _pages = new List<Page>();
        // Constructor calls abstract Factory method
        public DocumentCreator()
        {
            this.CreatePages();
        }
        public List<Page> Pages
        {
            get { return _pages; }
        }
        // Factory Method
        public abstract void CreatePages();
    }
}
