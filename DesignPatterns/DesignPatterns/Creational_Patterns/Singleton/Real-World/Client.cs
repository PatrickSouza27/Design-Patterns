namespace DesignPatterns.Creational_Patterns.Singleton.Real_World
{
    internal class Client
    {
        public void Main()
        {
            var balancer1 = LoadBalancer.GetLoadBalancer();
            var balancer2 = LoadBalancer.GetLoadBalancer();
            var balancer3 = LoadBalancer.GetLoadBalancer();


            if(balancer1 == balancer2 && balancer2 == balancer3 && balancer3 == balancer1)
            {
                Console.WriteLine("Mesma Instancia!");
            }
        }
    }
}
