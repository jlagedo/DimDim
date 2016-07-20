﻿using DimDim.Model.Services;
using DimDim.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DimDim.Web.Controllers
{
    public class DespesasController : Controller
    {
        private readonly IDespesaService despesaService;

        public DespesasController(IDespesaService despesaService)
        {
            this.despesaService = despesaService;
        }

        public IActionResult Index()
        {
            var despesas = despesaService.ObterTodas();
            var vm = new ListaDespesaViewModel { Despesas = despesas };            
            return View(vm);
        }

        public IActionResult Registro()
        {
            var vm = new RegistroDespesaViewModel();
            return View(vm);
        }

        [HttpPost]
        public IActionResult Registro(RegistroDespesaViewModel vm)
        {
            var despesa = despesaService.Registrar(vm.Descricao, vm.Valor, vm.Data);
            return RedirectToAction("Index");
        }
    }
}
