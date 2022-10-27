using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TesteClima.Helper;
using TesteClima.Model.Response;

namespace TesteClima.Controllers
{    
    [ApiController]
    public class ComumController : ControllerBase
    {

        [HttpGet]
        [Route("[controller]/GetFire")]
        public async Task<IActionResult> GetFire()
        {
            try
            {
                //Como é teste nao criei Camada de negocio como Interface
                //Como é teste não criei Camada de Repositorio assim como Interface
                // Nome da procedure na camada de repositorio ter constante com os nomes das procedures
                using (SqlConnection cnn = new SqlConnection(Configuration.GetConnectionString()))
                {
                    var result = await cnn.QueryAsync<FireResponse>("SP_GET_FIRE",null                        
                        , commandType: System.Data.CommandType.StoredProcedure);
                    return StatusCode(200,result);
                }                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpGet]
        [Route("[controller]/GetCold")]
        public async Task<IActionResult> GetCold()
        {
            try
            {
                //Como é teste nao criei Camada de negocio como Interface
                //Como é teste não criei Camada de Repositorio assim como Interface
                // Nome da procedure na camada de repositorio ter constante com os nomes das procedures
                using (SqlConnection cnn = new SqlConnection(Configuration.GetConnectionString()))
                {
                    var result = await cnn.QueryAsync<ColdResponse>("SP_GET_COLD", null
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
