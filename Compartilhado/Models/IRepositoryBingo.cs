using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartilhado.Models
{
    public interface IRepositoryBingo
    {
        int Id { get; set; }

        int SortearPedra();

        bool VericarCartela(Cartela cartela);

        List<int> GetNumerosSorteados();
    }
}
