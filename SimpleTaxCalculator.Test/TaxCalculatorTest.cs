using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleTaxCalculator.Test
{
    [TestClass]
    public class TaxCalculatorTest
    {
        TaxCalculator taxCalculator;


        [TestMethod]
        public void CalculateTax_AgeandSalary0()
        {
            int age = 0;
            int salary = 0;
            string expected = "Invalid Data";
            Program p = new Program(age, salary);
            string actual = p.DataValidation(age, salary);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_AgeandSalaryWithNegativeValue()
        {
            int age = -25;
            int salary = -6000000;
            string expected = "Invalid Data";
            Program p = new Program(age, salary);
            string actual = p.DataValidation(age, salary);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_WhenAge0()
        {
            int age = 0;
            int salary = 200000;
            string expected = "Invalid Age";
            Program p = new Program(age, salary);
            string actual = p.DataValidation(age, salary);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_malefemaleWhenSalary0()
        {
            int age = 25;
            int salary = 0;
            string expected = "Invalid Salary";
            Program p = new Program(age, salary);
            string actual = p.DataValidation(age, salary);
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
            Program p = new Program(age, salary);
            string actual = p.DataValidation(age, salary);
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
        public void CalculateTax_malefemale2lto5l1()
        {
            int age = 21;
            int salary = 400000;
            int expected = 7500;
            taxCalculator = new TaxCalculator(age, salary);
            int actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_malefemale2lto5l2()
        {
            int age = 21;
            int salary = 500000;
            int expected = 12500;
            taxCalculator = new TaxCalculator(age, salary);
            int actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_malefemale2lto5lWithNegativeSalaryValue()
        {
            int age = 21;
            int salary = -200000;
            string expected = "Invalid Salary";
            Program p = new Program(age, salary);
            string actual = p.DataValidation(age, salary);
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
        public void CalculateTax_malefemale5lto10l1()
        {
            int age = 21;
            int salary = 800000;
            int expected = 72500;
            taxCalculator = new TaxCalculator(age, salary);
            int actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_malefemale5lto10l2()
        {
            int age = 21;
            int salary = 1000000;
            int expected = 112500;
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
            Program p = new Program(age, salary);
            string actual = p.DataValidation(age, salary);
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
        public void CalculateTax_malefemaleAbove10l2()
        {
            int age = 21;
            int salary = 2000000;
            int expected = 412500;
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
            Program p = new Program(age, salary);
            string actual = p.DataValidation(age, salary);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_SeniorCitizenWhenSalary0()
        {
            int age = 61;
            int salary = 0;
            string expected = "Invalid Salary";
            Program p = new Program(age, salary);
            string actual = p.DataValidation(age, salary);
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
        public void CalculateTax_SeniorCitizenNoTaxWithNegativeSalaryValue()
        {
            int age = 61;
            int salary = -250000;
            string expected = "Invalid Salary";
            Program p = new Program(age, salary);
            string actual = p.DataValidation(age, salary);
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
        public void CalculateTax_SeniorCitizen3lto5l1()
        {
            int age = 61;
            int salary = 400000;
            int expected = 5000;
            taxCalculator = new TaxCalculator(age, salary);
            int actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_SeniorCitizen3lto5l2()
        {
            int age = 61;
            int salary = 500000;
            int expected = 10000;
            taxCalculator = new TaxCalculator(age, salary);
            int actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_SeniorCitizen3lto5lWithNegativeValue()
        {
            int age = 61;
            int salary = -350000;
            string expected = "Invalid Salary";
            Program p = new Program(age, salary);
            string actual = p.DataValidation(age, salary);
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
        public void CalculateTax_SeniorCitizen5lto10l1()
        {
            int age = 61;
            int salary = 850000;
            int expected = 80000;
            taxCalculator = new TaxCalculator(age, salary);
            int actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_SeniorCitizen5lto10l2()
        {
            int age = 61;
            int salary = 1000000;
            int expected = 110000;
            taxCalculator = new TaxCalculator(age, salary);
            int actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_SeniorCitizen5lto10lWithNegativeValue()
        {
            int age = 61;
            int salary = -700000;
            string expected = "Invalid Salary";
            Program p = new Program(age, salary);
            string actual = p.DataValidation(age, salary);
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
        public void CalculateTax_SeniorCitizenAbove10l1()
        {
            int age = 61;
            int salary = 2000000;
            int expected = 410000;
            taxCalculator = new TaxCalculator(age, salary);
            int actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_SeniorCitizenAbove10lWithNegativeValue()
        {
            int age = 61;
            int salary = -1200000;
            string expected = "Invalid Salary";
            Program p = new Program(age, salary);
            string actual = p.DataValidation(age, salary);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_VerySeniorCitizenWhenSalary0()
        {
            int age = 81;
            int salary = 0;
            string expected = "Invalid Salary";
            Program p = new Program(age, salary);
            string actual = p.DataValidation(age, salary);
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
        public void CalculateTax_VerySeniorCitizennotaxWithNegativeValue()
        {
            int age = 81;
            int salary = -450000;
            string expected = "Invalid Salary";
            Program p = new Program(age, salary);
            string actual = p.DataValidation(age, salary);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_VerySeniorCitizen5lto10l()
        {
            int age = 85;
            int salary = 600000;
            int expected = 20000;
            taxCalculator = new TaxCalculator(age, salary);
            int actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_VerySeniorCitizen5lto10l1()
        {
            int age = 85;
            int salary = 800000;
            int expected = 60000;
            taxCalculator = new TaxCalculator(age, salary);
            int actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_VerySeniorCitizen5lto10l2()
        {
            int age = 85;
            int salary = 1000000;
            int expected = 100000;
            taxCalculator = new TaxCalculator(age, salary);
            int actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_VerySeniorCitizen5lto10lWithNegativeValue()
        {
            int age = 81;
            int salary = -700000;
            string expected = "Invalid Salary";
            Program p = new Program(age, salary);
            string actual = p.DataValidation(age, salary);
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
        [TestMethod]
        public void CalculateTax_VerySeniorCitizenAbove10l1()
        {
            int age = 81;
            int salary = 2000000;
            int expected = 400000;
            taxCalculator = new TaxCalculator(age, salary);
            int actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_VerySeniorCitizenAbove10lWithNegativeValue()
        {
            int age = 81;
            int salary = -1200000;
            string expected = "Invalid Salary";
            Program p = new Program(age, salary);
            string actual = p.DataValidation(age, salary);
            Assert.AreEqual(expected, actual);
        }
    }
}
