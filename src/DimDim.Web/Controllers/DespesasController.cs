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
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registro()
        {
            var vm = new RegistroDespesaViewModel();
            return View(vm);
        }
    }
}
