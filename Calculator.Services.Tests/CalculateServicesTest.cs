using NUnit.Framework;
using RPNCalculator.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Services.Tests
{
    public class CalculateServicesTest
    {
        private ICalculateService calculateService;

        public CalculateServicesTest(ICalculateService calculateService)
        {
            this.calculateService = calculateService;
        }

        [Test]
        public void Calculate_Should_Succedd()
        {
        }
    }
}
