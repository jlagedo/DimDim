using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DimDim.Model.Services
{
    public class DespesaService : IDespesaService
    {
        public Despesa Registrar(string descricao, decimal valor, DateTimeOffset data)
        {
            var despesa = new Despesa
            {
                Valor = valor,
                Descricao = descricao,
                Data = data
            };

            //TODO: Salvar no bando de dados
            despesa.Id = 1;

            return despesa;
        }
    }
}
