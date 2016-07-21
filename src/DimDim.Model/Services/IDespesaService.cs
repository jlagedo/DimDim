using DimDim.Model.Command;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DimDim.Model.Services
{
    public interface IDespesaService
    {
        Despesa Registrar(RegistroDespesaCommand despesaCommand);
        IEnumerable<Despesa> ObterTodas();
        Task<bool> RemoverAsync(int id);
    }
}