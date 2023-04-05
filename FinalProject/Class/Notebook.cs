using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Class
{
    public class Notebook : Order
    {
        public string brand;
        public string model;
        public Notebook(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
        }
    }
}
