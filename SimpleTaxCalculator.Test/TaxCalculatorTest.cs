using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleTaxCalculator.Test
{
    [TestClass]
    public class TaxCalculatorTest
    {
        int age, salary, expected, actual;
        TaxCalculator taxCalculator;

        [TestMethod]
        public void CalculateTax_malefemale2lto5l()
        {
            age = 21;
            salary = 300000;
            expected = 2500;
            taxCalculator = new TaxCalculator(age, salary);
            actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_malefemale5lto10l()
        {
            age = 21;
            salary = 600000;
            expected = 32500;
            taxCalculator = new TaxCalculator(age, salary);
            actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_malefemaleAbove10l()
        {
            age = 21;
            salary = 1100000;
            expected = 142500;
            taxCalculator = new TaxCalculator(age, salary);
            actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_SeniorCitizen3lto5l()
        {
            age = 61;
            salary = 350000;
            expected = 2500;
            taxCalculator = new TaxCalculator(age, salary);
            actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_SeniorCitizen5lto10l()
        {
            age = 61;
            salary = 700000;
            expected = 50000;
            taxCalculator = new TaxCalculator(age, salary);
            actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_SeniorCitizenAbove10l()
        {
            age = 61;
            salary = 1200000;
            expected = 170000;
            taxCalculator = new TaxCalculator(age, salary);
            actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_VerySeniorCitizen5lto10l()
        {
            age = 85;
            salary = 700000;
            expected = 40000;
            taxCalculator = new TaxCalculator(age, salary);
            actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTax_VerySeniorCitizenAbove10l()
        {
            age = 81;
            salary = 1200000;
            expected = 160000;
            taxCalculator = new TaxCalculator(age, salary);
            actual = taxCalculator.CalculateTax();
            Assert.AreEqual(expected, actual);
        }
        
    }
}
