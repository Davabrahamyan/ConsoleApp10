using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Employer:Person
    {
       public int salary;
       public string workPlace;
        public int numberOfWorkdaysPerMonth;
        public int numberOfAbsentDaysperMonth;
        public int SalaryPerMonth()
        {
            int sum = numberOfWorkdaysPerMonth * 15000 - numberOfAbsentDaysperMonth * 2000;
            if (numberOfAbsentDaysperMonth == 0)
            {
                return sum + 10000;
            }
            else return sum;
        }
    }
}
