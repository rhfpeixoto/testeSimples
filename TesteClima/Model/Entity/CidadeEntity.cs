using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteClima.Model.Entity
{
    public class CidadeEntity
    {
        public int id { get; set; }

        public string nome { get; set; }

        public int EstadoId { get; set; }
    }
}
