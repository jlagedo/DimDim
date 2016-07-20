using DimDim.Model;
using Microsoft.EntityFrameworkCore;

namespace DimDim.Infra.Data
{
    public class DimDimDbContext : DbContext
    {
        public DbSet<Despesa> Despesas { get; set; }
    }
}
