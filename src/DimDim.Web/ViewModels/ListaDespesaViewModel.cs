using DimDim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DimDim.Web.ViewModels
{
    public class ListaDespesaViewModel
    {
        public ListaDespesaViewModel()
        {
            Despesas = Array.Empty<Despesa>();
        }

        public IEnumerable<Despesa> Despesas { get; set; }
    }
}
