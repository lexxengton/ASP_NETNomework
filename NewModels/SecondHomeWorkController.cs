using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebStore.NewModels
{
    public class SecondHomeWorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
