using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.Singleton.Exercicio
{
    internal class Client
    {
        public void Main()
        {
            //Instance Default
            var appConfig1 = AppConfig.GetInstanceConfig();
            Console.WriteLine(appConfig1);




            //alter configuration
            appConfig1.Language = "PT-BR";

            Console.WriteLine("=========================================================");


            //get Instance
            var appConfig2 = AppConfig.GetInstanceConfig();

            Console.WriteLine(appConfig2);
        }
    }
}
