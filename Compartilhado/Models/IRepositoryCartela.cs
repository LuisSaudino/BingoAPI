using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartilhado.Models
{
    public interface IRepositoryCartela
    {
        Cartela GenerateCartela();

        Usuario ComprarCartela(Usuario user, Cartela cartela);
    }
}
