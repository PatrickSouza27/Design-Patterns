using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.Singleton.Model
{
    internal class Client
    {
        public void Main()
        {
            // Constructor is protected -- cannot use new
            SingletonModel s1 = SingletonModel.Instance();
            SingletonModel s2 = SingletonModel.Instance();
            // Test for same instance
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }
            // Wait for user
            Console.ReadKey();
        }
    }
}
