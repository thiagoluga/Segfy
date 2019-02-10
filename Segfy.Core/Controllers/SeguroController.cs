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
    public class SeguroController : ControllerBase
    {
        private readonly SeguroService seguroService;

        public SeguroController(SeguroService seguroService)
        {
            this.seguroService = seguroService;
        }

        [HttpGet]
        public ActionResult<List<Seguro>> Get()
        {
            var result = seguroService.Get();
            return result;
        }

        [HttpGet("{id:length(24)}")]
        public ActionResult<Seguro> Get(string id)
        {
            var result = seguroService.Get(id);

            if (result == null)
                return NotFound();

            return result; 
        }

        [HttpPost]
        public ActionResult<Seguro> Create(Seguro seguro)
        {
            seguroService.Create(seguro);

            return CreatedAtRoute("Get", new { id = seguro.Id.ToString() }, seguro);
        }

        public IActionResult Update(Seguro seguroIn)
        {
            var seguro = seguroService.Get(seguroIn.Id);

            if (seguro == null)
                return NotFound();

            seguroService.Update(seguroIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var seguro = seguroService.Get(id);

            if (seguro == null)
                return NotFound();

            seguroService.Remove(id);

            return NoContent();
        }

    }
}