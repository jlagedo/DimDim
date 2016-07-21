using DimDim.Model.Command;
using DimDim.Model.Services;
using DimDim.Web.Contracts;
using DimDim.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DimDim.Web.Controllers
{
    [Route("api/[controller]")]
    public class DespesasController : Controller
    {
        private readonly IDespesaService despesaService;

        public DespesasController(IDespesaService despesaService)
        {
            this.despesaService = despesaService;
        }

        /* WEB API */
        [HttpGet]
        public IActionResult Get()
        {
            var todas = despesaService.ObterTodas();
            var dtos = todas.Select(MapToDto).ToList();
            return Ok(todas);
        }

        [HttpPost]
        public IActionResult Post([FromBody]RegistroDespesaDTO dto)
        {
            //TODO: Criar Filtro para retirar este codigo
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var despesaCommand = new RegistroDespesaCommand
            {
                Data = dto.Data,
                Descricao = dto.Descricao,
                Valor = dto.Valor
            };
            var despesa = despesaService.Registrar(despesaCommand);

            DespesaDTO retDto = MapToDto(despesa);

            return Ok(retDto);
        }

        private static DespesaDTO MapToDto(Model.Despesa despesa)
        {
            return new DespesaDTO
            {
                Id = despesa.Id,
                Data = despesa.Data,
                Descricao = despesa.Descricao,
                Valor = despesa.Valor
            };
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var removido = await despesaService.RemoverAsync(id);

            if(!removido)
            {
                return NotFound(id);
            }

            return Ok();
        }

        /* WEB API */

        //public IActionResult Index()
        //{
        //    var despesas = despesaService.ObterTodas();
        //    var vm = new ListaDespesaViewModel { Despesas = despesas };            
        //    return View(vm);
        //}

        //public IActionResult Registro()
        //{
        //    var vm = new RegistroDespesaViewModel();
        //    return View(vm);
        //}

        //[HttpPost]
        //public IActionResult Registro(RegistroDespesaViewModel vm)
        //{
        //    var despesaCommand = new RegistroDespesaCommand {
        //        Data = vm.Data,
        //        Descricao = vm.Descricao,
        //        Valor = vm.Valor
        //    };
        //    var despesa = despesaService.Registrar(despesaCommand);
        //    return RedirectToAction("Index");
        //}

        //public async Task<IActionResult> Remover(int id)
        //{
        //    await despesaService.RemoverAsync(id);
        //    return RedirectToAction("Index");
        //}
    }
}
