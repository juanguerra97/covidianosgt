using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace covidiano.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CasosCovidController
    {
        
        [HttpGet]
        public async Task<ActionResult<List<string>>> GetAll()
        {
            return new List<string> {
                "Xela",
                "Chiquimula",
                "Tiqui",
                "San Marcos"
            };
        }
    }
}