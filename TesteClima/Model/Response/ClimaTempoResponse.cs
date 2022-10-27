using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteClima.Model.Response
{
    public class ClimaTempoResponse
    {
        public DateTime DataPrevisao { get; set; }

        public string Semana { get; set; }

        public string Clima { get; set; }

        public decimal TemperaturaMinima { get; set; }

        public decimal TemperaturaMaxima { get; set; }
    }
}
