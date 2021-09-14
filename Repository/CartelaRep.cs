using Cbm.BaseRazor.Helpers;
using Compartilhado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd.Repository
{
    public class CartelaRep : IRepositoryCartela
    {
        private IHttpService _httpService;
        private string baseUrl = @"/api/Cartela";

        public CartelaRep(IHttpService httpService) : base()
        {

        }
        public Usuario ComprarCartela(Usuario user, Cartela cartela)
        {
            throw new NotImplementedException();
        }

        public Cartela GenerateCartela()
        {
            throw new NotImplementedException();
        }
    }
}
