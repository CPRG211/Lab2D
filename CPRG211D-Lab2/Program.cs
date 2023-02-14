using CPRG211D_Lab2.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211D_Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            string path = "employees.txt";

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] cells = line.Split(':');

                string id = cells[0];
                string name = cells[1];
                string address = cells[2];

                string firstDigit = id.Substring(0, 1);

                int firstDigitInt = int.Parse(firstDigit);

                if (firstDigitInt >= 0 && firstDigitInt <= 4)
                {
                    // Salaried
                    string salary = cells[7];

                    double salaryDouble = double.Parse(salary);

                    Salaried salaried = new Salaried(id, name, address, salaryDouble);
                    employees.Add(salaried);
                }
                else if (firstDigitInt >= 5 && firstDigitInt <= 7)
                {
                    // Wage
                    string rate = cells[7];
                    string hours = cells[8];

                    double rateDouble = double.Parse(rate);
                    int hoursInt = int.Parse(hours);

                    Wages wages = new Wages(id,name, address, rateDouble);
                    employees.Add(wages);
                }
                else if (firstDigitInt >= 8 && firstDigitInt <= 9)
                {
                    // Part time
                    string rate = cells[7];
                    string hours = cells[8];

                    double rateDouble = double.Parse(rate);
                    int hoursInt = int.Parse(hours);

                    PartTime partTime = new PartTime(id, name, address, rateDouble);
                    employees.Add(partTime);

                }

                /*if (firstDigit == "0" || firstDigit == "1" || firstDigit == "2" || firstDigit == "3" || firstDigit == "4")
                {

                }*/

                foreach (Employee employee in employees) { 
                } 
            }
        }
    }
}
