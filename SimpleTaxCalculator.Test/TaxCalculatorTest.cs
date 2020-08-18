using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleTaxCalculator.Test
{
    [TestClass]
    public class TaxCalculatorTest
    {
        TaxCalculator taxCalculator;

        public string ZeroAgeValue(int age)
        {
            if (age == 0)
                return "Invalid Age";
            else
                return age.ToString();
        }
        public string ZeroSalaryValue(int salary)
        {
            if (salary == 0)
                return "Invalid Salary";
            else
                return salary.ToString();
        }
        public string SalaryValueLessthan0(int salary)
        {
            if (salary < 0)
                return "Invalid Salary";
            else
                return salary.ToString();
        }

        [TestMethod]
        public void CalculateTax_WhenAge0()
        {
            int age = 0;
            int salary = 200000;
            string expected = "Invalid Age";
            taxCalculator = new TaxCalculator(age, salary);
            string actual = ZeroAgeValue(age);
            Assert.AreEqual(expected, actual);            
        }
        [TestMethod]
        public void CalculateTax_malefemaleWhenSalary0()
        {
            int age = 25;
            int salary = 0;
            string expected = "Invalid Salary";
            taxCalculator = new TaxCalculator(age, salary);
            string actual = ZeroSalaryValue(salary);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateTax_malefemalenotax()
        {
            int age = 21;
            int salary = 200000;
            int expected = 0;
            taxCalculator = new TaxCalculator(age, salary);
            int actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_malefemaleNoTaxWithNegativeSalaryValue()
        {
            int age = 21;
            int salary = -200000;
            string expected = "Invalid Salary";
            taxCalculator = new TaxCalculator(age, salary);
            string actual = SalaryValueLessthan0(salary);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_malefemale2lto5lWithNegativeSalaryValue()
        {
            int age = 21;
            int salary = -200000;
            string expected = "Invalid Salary";
            taxCalculator = new TaxCalculator(age, salary);
            string actual = SalaryValueLessthan0(salary);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_malefemale2lto5l()
        {
            int age = 21;
            int salary = 300000;
            int expected = 2500;
            taxCalculator = new TaxCalculator(age, salary);
            int actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_malefemale5lto10l()
        {
            int age = 21;
            int salary = 600000;
            int expected = 32500;
            taxCalculator = new TaxCalculator(age, salary);
            int actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_malefemale5lto10lWithNegativeSalaryValue()
        {
            int age = 21;
            int salary = -600000;
            string expected = "Invalid Salary";
            taxCalculator = new TaxCalculator(age, salary);
            string actual = SalaryValueLessthan0(salary);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_malefemaleAbove10l()
        {
            int age = 21;
            int salary = 1100000;
            int expected = 142500;
            taxCalculator = new TaxCalculator(age, salary);
            int actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_malefemaleAbove10LWithNegativeSalaryValue()
        {
            int age = 21;
            int salary = -1100000;
            string expected = "Invalid Salary";
            taxCalculator = new TaxCalculator(age, salary);
            string actual = SalaryValueLessthan0(salary);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_SeniorCitizenWhenSalary0()
        {
            int age = 61;
            int salary = 0;
            string expected = "Invalid Salary";
            taxCalculator = new TaxCalculator(age, salary);
            string actual = ZeroSalaryValue(salary);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_SeniorCitizennotax()
        {
            int age = 61;
            int salary = 250000;
            int expected = 0;
            taxCalculator = new TaxCalculator(age, salary);
            int actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_SeniorCitizen3lto5l()
        {
            int age = 61;
            int salary = 350000;
            int expected = 2500;
            taxCalculator = new TaxCalculator(age, salary);
            int actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_SeniorCitizen5lto10l()
        {
            int age = 61;
            int salary = 700000;
            int expected = 50000;
            taxCalculator = new TaxCalculator(age, salary);
            int actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_SeniorCitizenAbove10l()
        {
            int age = 61;
            int salary = 1200000;
            int expected = 170000;
            taxCalculator = new TaxCalculator(age, salary);
            int actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_VerySeniorCitizenWhenSalary0()
        {
            int age = 81;
            int salary = 0;
            string expected = "Invalid Salary";
            taxCalculator = new TaxCalculator(age, salary);
            string actual = ZeroSalaryValue(salary);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_VerySeniorCitizennotax()
        {
            int age = 81;
            int salary = 450000;
            int expected = 0;
            taxCalculator = new TaxCalculator(age, salary);
            int actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_VerySeniorCitizen5lto10l()
        {
            int age = 85;
            int salary = 700000;
            int expected = 40000;
            taxCalculator = new TaxCalculator(age, salary);
            int actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_VerySeniorCitizenAbove10l()
        {
            int age = 81;
            int salary = 1200000;
            int expected = 160000;
            taxCalculator = new TaxCalculator(age, salary);
            int actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        
    }
}
