using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211D_Lab2.Entities
{
    internal class Wages : Employee
    {
        private double rate;

        public double Rate { get {  return rate; } }

        /*public Salaried(string id, string name, string address, double salary) : base(id, name, address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.salary = salary;
        }*/

        public Wages(string id, string name, string address, double rate)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.rate = rate;
        }

    }
}
