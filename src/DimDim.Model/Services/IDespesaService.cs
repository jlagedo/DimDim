using System;

namespace DimDim.Model.Services
{
    public interface IDespesaService
    {
        Despesa Registrar(string descricao, decimal valor, DateTimeOffset data);
    }
}