using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.NewModels;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        //далее модель сотрудников (_emploees)
        private readonly List<EmployeController> _emploees = new List<EmployeController>
        {
          new EmployeController
          {
            Id =1,
            FirstName = "Иван",
            SureName = "Иванов",
            Patronimic ="Иванович",
            Age=32,
            Position = "Начальник",
            PhoneNumber = 89067044949

          },

           new EmployeController
          {
            Id =2,
            FirstName = "Василий",
            SureName = "Васильев",
            Patronimic ="Васильевич",
            Age=37,
            Position = "Подчиненный",
            PhoneNumber = 89067042341

          }


    

};


        public List<EmployeController> ReturnEmployeeList()
        {
            return _emploees; 
        }


        public IActionResult Index()
        {
            //return Content("Hello from controller");
             return View(_emploees);
        }

        public IActionResult Employee()
        {
            return View(_emploees);
        }

        public IActionResult EmployeeDetails(int id)
        {

            var employe_ViewModel = _emploees.FirstOrDefault(x => x.Id == id);


                if (employe_ViewModel == null)
                return NotFound();
                
           return View(employe_ViewModel);
        }


        public IActionResult Message()
        {
            return Content("Message from controller");
            
        }
    }
}
