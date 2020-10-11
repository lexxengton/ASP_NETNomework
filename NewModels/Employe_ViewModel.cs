using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.NewModels
{
    public class Employe_ViewModel
    {
        public int Id {get;set;}
        public string FirstName { get; set; }
        public string SureName { get; set; }
        public string Patronimic { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }

        public long PhoneNumber { get; set; }
    }
}
