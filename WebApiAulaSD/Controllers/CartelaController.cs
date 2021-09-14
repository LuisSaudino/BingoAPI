using Compartilhado.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAulaSD.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CartelaController : Controller
    {
        private FakeCartelaRep _cartelaHelper;

        public CartelaController() : base() {
            _cartelaHelper = new FakeCartelaRep();

        }

        [HttpGet("NovaCartela")]
        public async Task<ActionResult<Cartela>> Get()
        {
            return _cartelaHelper.GenerateCartela();
        }
    }
}
