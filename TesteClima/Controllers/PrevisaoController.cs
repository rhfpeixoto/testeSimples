using Dapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TesteClima.Helper;
using TesteClima.Model.Request;
using TesteClima.Model.Response;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TesteClima.Controllers
{    
    [ApiController]
    public class PrevisaoController : ControllerBase
    {


        [HttpPost]
        [Route("[controller]/Search")]
        public async Task<IActionResult> Search(SearchRequest search)
        {
            try
            {
                //Como é teste nao criei Camada de negocio como Interface
                //Como é teste não criei Camada de Repositorio assim como Interface
                // Nome da procedure na camada de repositorio ter constante com os nomes das procedures
                using (SqlConnection cnn = new SqlConnection(Configuration.GetConnectionString()))
                {
                    var result = await cnn.QueryAsync<ClimaTempoResponse>("SP_SEARCH", new
                    {
                        Search =  search.Texto
                    }
                        , commandType: System.Data.CommandType.StoredProcedure);
                    return StatusCode(200, result);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }





    }
}
