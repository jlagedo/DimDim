using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DimDim.Model.Command
{
    public class RegistroDespesaCommand
    {
        public DateTimeOffset Data { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
    }
}
