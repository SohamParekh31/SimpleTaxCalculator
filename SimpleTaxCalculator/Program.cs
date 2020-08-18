using System;

namespace SimpleTaxCalculator
{
    public class Program
    {
        private int age;
        private int salary;

        public Program(int age, int salary)
        {
            this.age = age;
            this.salary = salary;
        }
        public Program() { }

        public static void Main(string[] args)
        {
            int ageInput, salaryInput;
            Console.Write("Enter Age :");
            ageInput = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Salary :");
            salaryInput = Convert.ToInt32(Console.ReadLine());
            Program p = new Program();
            p.ValidateData(ageInput, salaryInput);

        }
        public string ValidateData(int age, int salary)
        {
            if (age <= 0 && salary <= 0)
            {
                Console.WriteLine("Invalid Data");
                return "Invalid Data";
            }
            else if (age == 0)
            {
                Console.WriteLine("Invalid Age");
                return "Invalid Age";
            }
            else if (salary == 0)
            {
                Console.WriteLine("Invalid Salary");
                return "Invalid Salary";
            }
            else if (salary < 0)
            {
                Console.WriteLine("Invalid Salary");
                return "Invalid Salary";
            }
            TaxCalculator taxCalculator = new TaxCalculator(age, salary);
            Console.WriteLine();
            Console.WriteLine($"Tax to Pay {taxCalculator.CalculateTax()}!");
            return null;
        }
    }
}
