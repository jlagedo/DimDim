using DimDim.Model.Command;
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

        public Despesa Registrar(RegistroDespesaCommand despesaCommand)
        {
            var despesa = new Despesa
            {
                Valor = despesaCommand.Valor,
                Descricao = despesaCommand.Descricao,
                Data = despesaCommand.Data
            };

            //TODO: Salvar no bando de dados
            return repository.Insert(despesa);
        }

        public Task RemoverAsync(int id)
        {
            return repository.RemoverAsync(id);
        }
    }
}
