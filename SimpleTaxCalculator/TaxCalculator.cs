using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTaxCalculator
{
    public class TaxCalculator
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

        public int _salary { get; set; }
        public int _age { get; set; }

        #endregion

        #region Constructor

        public TaxCalculator(int age, int salary)
        {
            this._age = age;
            this._salary = salary;

        }

        #endregion



        #region Methods

        public int CalculateTax()
        {

            if (_age < 60 && _salary <= 250000)
            {
                _taxAmount = 0;
            }
            else if (_age < 60 && (_salary > 250001 && _salary <= 500000))
            {
                int sal = _salary - 250000;
                _taxAmount = ((sal * 5) / 100);
            }
            else if (_age < 60 && (_salary > 500001 && _salary <= 1000000))
            {
                int sal = _salary - 500000;
                _taxAmount = ((sal * 20) / 100) + _fixedTaxBetween5Lto10L;
            }
            else if (_age < 60 && _salary > 1000001)
            {
                int sal = _salary - 1000000;
                _taxAmount = ((sal * 30) / 100) + _fixedTaxAbove10L;
            }
            else if ((_age > 60 && _age < 80) && _salary <= 300000)
            {
                _taxAmount = 0;
            }
            else if ((_age > 60 && _age < 80) && (_salary > 300001 && _salary <= 500000))
            {
                int sal = _salary - 300000;
                _taxAmount = ((sal * 5) / 100);
            }
            else if ((_age > 60 && _age < 80) && (_salary > 500001 && _salary <= 1000000))
            {
                int sal = _salary - 500000;
                _taxAmount = ((sal * 20) / 100) + _fixedTaxSeniorCitizenBetween5Lto10L;
            }
            else if ((_age > 60 && _age < 80) && _salary > 1000001)
            {
                int sal = _salary - 1000000;
                _taxAmount = ((sal * 30) / 100) + _fixedTaxSeniorCitizenAbove10L;
            }
            else if (_age >= 80 && _salary <= 500000)
            {
                _taxAmount = 0;
            }
            else if (_age >= 80 && (_salary > 500001 && _salary <= 1000000))
            {
                int sal = _salary - 500000;
                _taxAmount = ((sal * 20) / 100);
            }
            else if (_age >= 80 && _salary > 1000001)
            {
                int sal = _salary - 1000000;
                _taxAmount = ((sal * 30) / 100) + _fixedTaxVerySeniorCitizenAbove10L;
            }
            return _taxAmount;
        }

        #endregion
    }
}
