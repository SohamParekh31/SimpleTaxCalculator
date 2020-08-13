using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTaxCalculator
{
    class TaxCalculator
    {
        #region Variables

        private int _fixedTaxBetween5Lto10L = 12500;
        private int _fixedTaxAbove10L = 112500;

        private int _fixedTaxSeniorCitizenBetween5Lto10L = 10000;
        private int _fixedTaxSeniorCitizenAbove10L = 110000;

        private int _fixedTaxVerySeniorCitizenAbove10L = 100000;

        private int _taxAmount;

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
        public void CalculateTax()
         {
           
            if (Age < 60 && Salary <= 250000)
            {
                Console.WriteLine("No Tax Required!");
            }
            else if(Age < 60 && (Salary > 250001 && Salary <= 500000))
            {
                int sal = Salary - 250000;
                _taxAmount = ((sal * 5) / 100);
                Console.WriteLine($"Tax to Pay is {_taxAmount}!");
            }
            else if (Age < 60 && (Salary > 500001 && Salary <= 1000000))
            {
                int sal = Salary - 500000;
                _taxAmount = ((sal * 20) / 100) + _fixedTaxBetween5Lto10L;
                Console.WriteLine($"Tax to Pay is {_taxAmount}!");
            }
            else if (Age < 60 && Salary > 1000001 )
            {
                int sal = Salary - 1000000;
                _taxAmount = ((sal * 30) / 100) + _fixedTaxAbove10L;
                Console.WriteLine($"Tax to Pay is {_taxAmount}!");
            }
            else if ((Age > 60 && Age < 80) && Salary <= 300000)
            {
                Console.WriteLine("No Tax Required!");
            }
            else if ((Age > 60 && Age < 80) && (Salary > 300001 && Salary <= 500000))
            {
                int sal = Salary - 300000;
                _taxAmount = ((sal * 5) / 100);
                Console.WriteLine($"Tax to Pay is {_taxAmount}!");
            }
            else if ((Age > 60 && Age < 80) && (Salary > 500001 && Salary <= 1000000))
            {
                int sal = Salary - 500000;
                _taxAmount = ((sal * 20) / 100) + _fixedTaxSeniorCitizenBetween5Lto10L;
                Console.WriteLine($"Tax to Pay is {_taxAmount}!");
            }
            else if ((Age > 60 && Age < 80) && Salary > 1000001)
            {
                int sal = Salary - 1000000;
                _taxAmount = ((sal * 30) / 100) + _fixedTaxSeniorCitizenAbove10L;
                Console.WriteLine($"Tax to Pay is {_taxAmount}!");
            }
            else if (Age >= 80 && Salary <= 500000)
            {
                Console.WriteLine("No Tax Required!");
            }
            else if (Age >= 80 && (Salary > 500001 && Salary <= 1000000))
            {
                int sal = Salary - 500000;
                _taxAmount = ((sal * 20) / 100);
                Console.WriteLine($"Tax to Pay is {_taxAmount}!");
            }
            else if (Age >= 80 && Salary > 1000001)
            {
                int sal = Salary - 1000000;
                _taxAmount = ((sal * 30) / 100) + _fixedTaxVerySeniorCitizenAbove10L;
                Console.WriteLine($"Tax to Pay is {_taxAmount}!");
            }
        }
        #endregion

    }
}
