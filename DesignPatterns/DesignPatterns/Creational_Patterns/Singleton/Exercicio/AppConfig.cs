using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.Singleton.Exercicio
{
    internal sealed class AppConfig
    {
        private static AppConfig? _config;
        private static readonly object _lock = new object();
        public string DatabaseConnectionString { get; set; }
        public string LogLevel { get; set; }
        public string Language { get; set; }
        private AppConfig()
        {
            DatabaseConnectionString = "SqlServer Connection string";
            LogLevel = "Logs Server Level";
            Language = "en";
        }

        public static AppConfig GetInstanceConfig()
        {
            if(_config == null )
            {
                lock(_lock)
                {
                    _config = new();
                }
            }
            return _config;
        }

        public override string ToString()
        {
            return $"connection String: {DatabaseConnectionString}\nLogLevel: {LogLevel}\nLanguage: {Language}";
        }
    }
}
