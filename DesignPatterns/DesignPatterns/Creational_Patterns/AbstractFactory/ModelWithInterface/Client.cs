﻿using DesignPatterns.Creational_Patterns.AbstractFactory.ModelWithInterface.Abstract;


namespace DesignPatterns.Creational_Patterns.AbstractFactory.ModelWithInterface.Factory
{
    internal class Client
    {
        public void Main()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new ConcreteFactory1());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new ConcreteFactory2());
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();
        }
    }
}
