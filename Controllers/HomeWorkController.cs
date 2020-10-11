using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.NewModels;

namespace WebStore.Controllers
{
    public class HomeWorkController : Controller
    {

        private readonly List<HomeWorkModel> _students = new List<HomeWorkModel>
        {
            new HomeWorkModel
          {
        Id =1,
        PhoneNumber = 890633344949,
        StudentName = "Иван",
        Country= "Россия",
        Book="Гибель дракона"
        
    },


            new HomeWorkModel
          {
        Id =2,
        PhoneNumber = 89067044329,
        StudentName = "Петер",
        Country= "Россия",
        Book="Микроэкономика"

    },
                 new HomeWorkModel
          {
        Id =3,
        PhoneNumber = 89067034141,
        StudentName = "Дмитрий",
        Country= "Живопись",
        Book="Микроэкономика"

    },
        };


        private readonly List<Employe_ViewModel> _emploeesHomeWork = new WebStore.Controllers.HomeController().ReturnEmployeeList();

     public IActionResult HomeWorkIndex()
        {
            return View(_emploeesHomeWork);
        }

        public IActionResult HomeWorkStudents()
        {
            return View(_students);
        }

        public IActionResult StudentsDetails(int id)
        {

            var employe_ViewModel = _students.FirstOrDefault(x => x.Id == id);


            if (employe_ViewModel == null)
                return NotFound();

            return View(employe_ViewModel);
        }

        public IActionResult EmployeeDetails(int id)
        {

            var employe_ViewModel = _emploeesHomeWork.FirstOrDefault(x => x.Id == id);


            if (employe_ViewModel == null)
                return NotFound();

            return View(employe_ViewModel);
        }


        public IActionResult StudentsIndex()
        {
            return View(_emploeesHomeWork);
        }

    }
}
