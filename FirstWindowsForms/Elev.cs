using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWindowsForms
{
    internal class Elev
    {        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        //Konstruktor
        public Elev(int id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }
    }
}
