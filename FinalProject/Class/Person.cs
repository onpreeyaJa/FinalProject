using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Class
{
    public class Person : Order
    {
        public string name;
        public string lastname;
        public string tel;

        public Person(string name, string lastname, string tel)
        {
            this.name = name;
            this.lastname = lastname;
            this.tel = tel;
        }
    }
}
