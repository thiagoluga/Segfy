using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Segfy.Core.Services;
using Segfy.Shared.Models;

namespace Segfy.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuscaController : ControllerBase
    {
        private readonly BuscaService buscaService;

        public BuscaController(BuscaService buscaService)
        {
            this.buscaService = buscaService;
        }

        [HttpGet("{placa:length(8)}")]
        public ActionResult<List<Seguro>> Get(string placa)
        {
            var result = buscaService.Get(placa);
            return result;
        }
    }
}