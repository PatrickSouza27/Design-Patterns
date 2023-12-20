using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.FactoryMethod.Real_world2.Violacao
{
    internal class Client
    {
        static void Main()
        {
            var pagamento_CartãoDeCredito = new Pagamento("Conta de luz", 2000, "Cartão de Credito");
            pagamento_CartãoDeCredito.Paid();


            var pagamentoBoleto = new Pagamento("Conta de luz", 2000, "Boleto");
            pagamentoBoleto.Paid();


            //a classe Client está fortemente acoplado com Pagamento
        }
    }
}
