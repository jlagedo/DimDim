using DimDim.Infra.Data;
using DimDim.Model;
using DimDim.Model.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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

        public async Task<bool> RemoverAsync(int id)
        {
            var despesa = await context.Despesas.FirstOrDefaultAsync(x => x.Id == id);
            if (despesa == null)
            {
                return false;
            }
            context.Despesas.Remove(despesa);

            int s = await context.SaveChangesAsync();
            return (s > 0);
        }
    }
}
