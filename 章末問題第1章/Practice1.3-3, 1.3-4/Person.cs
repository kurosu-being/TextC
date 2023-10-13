using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1._3_1 {
    class Person : object {
        public string Name{ get; set;}
        public DateTime Birthday{get; set; }
        public int GetAge(){
            DateTime　today = DateTime.Today;
            int age = today.Year - Birthday.Year;
            if(today < Birthday.AddYears(age))
            age--;
            return age;
        }
    }
}
