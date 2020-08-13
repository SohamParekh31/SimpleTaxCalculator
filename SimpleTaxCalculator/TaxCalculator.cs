using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaxCalculator
{
    class TaxCalculator
    {
        #region Variables

        private int fixedTaxBetween5Lto10L = 12500;
        private int fixedTaxAbove10L = 112500;

        private int fixedTaxSeniorCitizenBetween5Lto10L = 10000;
        private int fixedTaxSeniorCitizenAbove10L = 110000;

        private int fixedTaxVerySeniorCitizenAbove10L = 100000;

        private int calculateTax;

        #endregion

        #region Properties

        private int Salary { get; set; }
        private int Age { get; set; }

        #endregion

        #region Constructor
        
        public TaxCalculator(int Age,int Salary)
        {
            this.Age = Age;
            this.Salary = Salary;
        }

        #endregion

        #region Methods
        public void CalculateSalary()
         {
           
            if (Age < 60 && Salary <= 250000)
            {
                Console.WriteLine("No Tax Required!");
            }
            else if(Age < 60 && (Salary > 250001 && Salary <= 500000))
            {
                int sal = Salary - 250000;
                calculateTax = ((sal * 5) / 100);
                Console.WriteLine($"Tax to Pay is {calculateTax}!");
            }
            else if (Age < 60 && (Salary > 500001 && Salary <= 1000000))
            {
                int sal = Salary - 500000;
                calculateTax = ((sal * 20) / 100) + fixedTaxBetween5Lto10L;
                Console.WriteLine($"Tax to Pay is {calculateTax}!");
            }
            else if (Age < 60 && Salary > 1000001 )
            {
                int sal = Salary - 1000000;
                calculateTax = ((sal * 30) / 100) + fixedTaxAbove10L;
                Console.WriteLine($"Tax to Pay is {calculateTax}!");
            }
            else if ((Age > 60 && Age < 80) && Salary <= 300000)
            {
                Console.WriteLine("No Tax Required!");
            }
            else if ((Age > 60 && Age < 80) && (Salary > 300001 && Salary <= 500000))
            {
                int sal = Salary - 300000;
                calculateTax = ((sal * 5) / 100);
                Console.WriteLine($"Tax to Pay is {calculateTax}!");
            }
            else if ((Age > 60 && Age < 80) && (Salary > 500001 && Salary <= 1000000))
            {
                int sal = Salary - 500000;
                calculateTax = ((sal * 20) / 100) + fixedTaxSeniorCitizenBetween5Lto10L;
                Console.WriteLine($"Tax to Pay is {calculateTax}!");
            }
            else if ((Age > 60 && Age < 80) && Salary > 1000001)
            {
                int sal = Salary - 1000000;
                calculateTax = ((sal * 30) / 100) + fixedTaxSeniorCitizenAbove10L;
                Console.WriteLine($"Tax to Pay is {calculateTax}!");
            }
            else if (Age >= 80 && Salary <= 500000)
            {
                Console.WriteLine("No Tax Required!");
            }
            else if (Age >= 80 && (Salary > 500001 && Salary <= 1000000))
            {
                int sal = Salary - 500000;
                calculateTax = ((sal * 20) / 100);
                Console.WriteLine($"Tax to Pay is {calculateTax}!");
            }
            else if (Age >= 80 && Salary > 1000001)
            {
                int sal = Salary - 1000000;
                calculateTax = ((sal * 30) / 100) + fixedTaxVerySeniorCitizenAbove10L;
                Console.WriteLine($"Tax to Pay is {calculateTax}!");
            }
        }
        #endregion

    }
}
