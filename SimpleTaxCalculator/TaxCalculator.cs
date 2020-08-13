using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTaxCalculator
{
    class TaxCalculator
    {
        private int Salary { get; set; }
        private int Age { get; set; }
        public TaxCalculator(int Salary,int Age)
        {
            this.Salary = Salary;
            this.Age = Age;
        }
    }
}
