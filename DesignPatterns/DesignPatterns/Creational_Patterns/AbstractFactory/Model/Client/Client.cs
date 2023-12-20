using DesignPatterns.Creational_Patterns.AbstractFactory.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.AbstractFactory.Real.Client
{
    internal class Client
    {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;
        // Constructor
        public Client(AbstractFactoryIn factory)
        {
            _abstractProductB = factory.CreateProductB();
            _abstractProductA = factory.CreateProductA();
        }
        public void Run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }
    }
}
