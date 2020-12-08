using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleDotNetCoreMVCApp.Models;

namespace SimpleDotNetCoreMVCApp.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<Car> obj = Car.SelectCarList();
            return View(obj);
        }
    }
}
