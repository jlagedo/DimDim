using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DimDim.Web.Contracts
{
    public class RegistroDespesaDTO
    {
        [Required]
        public DateTimeOffset Data { get; set; }

        [Required]
        public decimal Valor { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Descricao { get; set; }
    }
}
