using System;

namespace SimpleTaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Age :");
            int ageInput = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Salary :");
            int salaryInput = Convert.ToInt32(Console.ReadLine());
            

            TaxCalculator taxCalculator = new TaxCalculator(ageInput,salaryInput);
            taxCalculator.CalculateTax();
        }
    }
}
