using System;

namespace SimpleTaxCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int ageInput, salaryInput;
            do
            {
                Console.Write("Enter Age :");
                ageInput = Convert.ToInt32(Console.ReadLine());

                if (ageInput <= 0 || ageInput > 100)
                    Console.WriteLine("Invalid Age!");

            } while (ageInput <= 0 || ageInput > 100);
            do
            {
                Console.Write("Enter Salary :");
                salaryInput = Convert.ToInt32(Console.ReadLine());

                if (salaryInput <= 0)
                    Console.WriteLine("Invalid Salary!");

            } while (salaryInput <= 0);

            TaxCalculator taxCalculator = new TaxCalculator(ageInput, salaryInput);
            Console.WriteLine();
            Console.WriteLine($"Tax to Pay {taxCalculator.CalculateTax()}!");
        }
    }
}
