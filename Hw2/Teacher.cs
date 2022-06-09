using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    public class Teacher
    {

        public string Name { get; set; }
        public string Occuration { get; set; }
        private decimal Salary { get; set; }
        public decimal Tax { get; set; }

        public Teacher(string name, string occuration, decimal salary, decimal tax)
        {
            this.Name = name;
            this.Occuration = occuration;
            this.Salary = salary;
            this.Tax = tax;
        }

        public string WhoIam()
        {
            var result = "";
            result = $"{Name} is a {Occuration}";
            //result = this.Name +" is a "+this.Occuration;
            return result;

        }

        public decimal GetTax()
        {
            return (Salary * Tax) / 100;
        }
    }
}
