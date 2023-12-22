using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.Singleton.Model
{
    internal sealed class SingletonModel
    {
        internal static SingletonModel? instance;
        // Constructor is 'protected'
        private SingletonModel()
        {
        }
        public static SingletonModel Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            instance ??= new SingletonModel();

            return instance;
        }
    }
}
