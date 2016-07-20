using DimDim.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DimDim.Model;
using DimDim.Infra.Data;

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
    }
}
