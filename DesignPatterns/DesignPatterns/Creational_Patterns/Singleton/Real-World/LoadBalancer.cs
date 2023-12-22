using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.Singleton.Real_World
{
    internal sealed class LoadBalancer
    {
        internal static LoadBalancer? LoadBalancerInstance;
        internal List<string> serversList { get; set; } = new List<string>();

        private Random random = new();

        private static object _locker = new();

        public string Server
        {
            get
            {
                int r = random.Next(serversList.Count);
                return serversList[r].ToString();
            }
        }

        private LoadBalancer()
        {
            serversList.Add("ServerI");
            serversList.Add("ServerII");
            serversList.Add("ServerIII");
            serversList.Add("ServerIV");
            serversList.Add("ServerV");
        }

        public static LoadBalancer GetLoadBalancer()
        {
            if(LoadBalancerInstance == null)
            {
                lock (_locker)
                {
                    LoadBalancerInstance = new LoadBalancer();
                }
            }
            return LoadBalancerInstance;    
        }
    }
}
