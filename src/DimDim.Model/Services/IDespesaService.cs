using System;
using System.Collections;
using System.Collections.Generic;

namespace DimDim.Model.Services
{
    public interface IDespesaService
    {
        Despesa Registrar(string descricao, decimal valor, DateTimeOffset data);
        IEnumerable<Despesa> ObterTodas();
    }
}