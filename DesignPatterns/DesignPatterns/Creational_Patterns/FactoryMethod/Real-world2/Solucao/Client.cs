using DesignPatterns.Creational_Patterns.FactoryMethod.Real_world2.Solucao.Concret;
using DesignPatterns.Creational_Patterns.FactoryMethod.Real_world2.Solucao.CreatorAbstract;


namespace DesignPatterns.Creational_Patterns.FactoryMethod.Real_world2.Solucao
{
    internal class Client
    {
        static void Main()
        {
            TransacaoAbstract transacaoCreator = new CartaoDeCreditoCreator();
            var pagamento = transacaoCreator.Pagamento("19/02/1999", 3000);
            pagamento.Paid();


        }
    }
}
