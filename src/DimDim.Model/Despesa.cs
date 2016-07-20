using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DimDim.Model
{
    public class Despesa
    {
        public int Id { get; set; }
        public DateTimeOffset Data { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
    }
}
