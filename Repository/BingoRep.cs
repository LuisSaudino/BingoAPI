using Cbm.BaseRazor.Helpers;
using Compartilhado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd.Repository
{
    public class BingoRep : IRepositoryBingo
    {
        private IHttpService _httpService;

        private String baseUrl = "/api/Bingo";

        public BingoRep(IHttpService httpService)
        {
            _httpService = httpService;
        }
        public int Id { get; set; } = 1;

        public async Task<List<int>> GetNumerosSorteados()
        {
            HttpResponseWrapper<List<int>> retorno = await _httpService.Get<List<int>>(baseUrl + @"/numerosSorteio");
            if (retorno.Sucess)
            {
                return retorno.Response;
            }
            throw new NotImplementedException();

        }

        public async Task<int> SortearPedra()
        {
            var retorno = await _httpService.Post<Object, int>(baseUrl + @"/", null);

            if (retorno.Sucess)
                return retorno.Response;

            return -1;
        }

        public bool VericarCartela(Cartela cartela)
        {
            throw new NotImplementedException();
        }

        List<int> IRepositoryBingo.GetNumerosSorteados()
        {
            throw new NotImplementedException();
        }

        int IRepositoryBingo.SortearPedra()
        {
            throw new NotImplementedException();
        }
    }
}
