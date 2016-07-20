using DimDim.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DimDim.Model.Services
{
    public class DespesaService : IDespesaService
    {
        private readonly IDespesaRepository repository;

        public DespesaService(IDespesaRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Despesa> ObterTodas()
        {
            return repository.ObterTodas();
        }

        public Despesa Registrar(string descricao, decimal valor, DateTimeOffset data)
        {
            var despesa = new Despesa
            {
                Valor = valor,
                Descricao = descricao,
                Data = data
            };

            //TODO: Salvar no bando de dados
            return repository.Insert(despesa);
        }
    }
}
