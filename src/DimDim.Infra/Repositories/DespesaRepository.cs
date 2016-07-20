using DimDim.Infra.Data;
using DimDim.Model;
using DimDim.Model.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace DimDim.Infra.Repositories
{
    public class DespesaRepository : IDespesaRepository
    {
        private readonly DimDimDbContext context;

        public DespesaRepository(DimDimDbContext context)
        {
            this.context = context;
        }

        public Despesa Insert(Despesa despesa)
        {
            context.Despesas.Add(despesa);
            context.SaveChanges();

            return despesa;
        }

        public IEnumerable<Despesa> ObterTodas()
        {
            return context.Despesas.OrderBy(x => x.Data).ToList();
        }
    }
}
