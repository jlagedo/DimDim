using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DimDim.Web.Contracts
{
    public class DespesaDTO
    {
        public int Id { get; set; }
        public DateTimeOffset Data { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
    }
}
