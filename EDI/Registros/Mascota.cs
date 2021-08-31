using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Mascota
    {
        public String name { get; set; }
        public String race { get; set; }
        public int age { get; set; }
        public Service service { get; set; }

        public Mascota()
        {
            this.name = "";
            this.race = "";
            this.age = 0;
            this.service = Service.None;
        }

        public Mascota(String name, String race, int age, Service service)
        {
            this.name = name;
            this.race = race;
            this.age = age;
            this.service = service;
        }

    }
}
