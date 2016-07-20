using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DimDim.Model.Services
{
    public interface IDespesaService
    {
        Despesa Registrar(string descricao, decimal valor, DateTimeOffset data);
        IEnumerable<Despesa> ObterTodas();
        Task RemoverAsync(int id);
    }
}