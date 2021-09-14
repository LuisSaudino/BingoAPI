using Compartilhado.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAulaSD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BingoController : Controller
    {
        private FakeBingoRep _bingoHelper;

        public BingoController() : base() {
            _bingoHelper = new FakeBingoRep();
        }

        [HttpGet("numerosSorteio")]
        public List<int> NumerosSorteados(int id_bingo)
        {
            return _bingoHelper.GetNumerosSorteados();
        }

        [HttpPost]
        public void SortearPedra(int id_bingo)
        {
            _bingoHelper.SortearPedra();
            return;
        }

        [HttpPost("Verificar")]
        public bool VerificarCartela()
        {
            var retorno = _bingoHelper.VericarCartela(cartela);
            return retorno;
        }
    }
}
