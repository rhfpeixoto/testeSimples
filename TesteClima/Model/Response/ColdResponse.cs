using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteClima.Model.Response
{
    public class ColdResponse
    {
        public string nome { get; set; }
        public string uf { get; set; }

        public decimal temperaturaMaxima { get; set; }
    }
}
