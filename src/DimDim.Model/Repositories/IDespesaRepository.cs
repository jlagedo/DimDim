using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DimDim.Model.Repositories
{
    public interface IDespesaRepository
    {
        Despesa Insert(Despesa despesa);
        IEnumerable<Despesa> ObterTodas();
        Task RemoverAsync(int id);
    }
}
