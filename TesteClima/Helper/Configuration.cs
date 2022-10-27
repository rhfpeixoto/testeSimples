using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace TesteClima.Helper
{
    public static class Configuration
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.AppSettings["Connection"];
        }
    }
}
