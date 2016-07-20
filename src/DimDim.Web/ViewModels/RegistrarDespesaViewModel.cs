using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DimDim.Web.ViewModels
{
    public class RegistroDespesaViewModel
    {
        public DateTimeOffset Data { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
    }
}
