using DimDim.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DimDim.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var vm = new HomeViewModel
            {
                Now = DateTimeOffset.Now,
                Title = "Dim Dim"
            };
            return View(vm);
        }
    }
}
