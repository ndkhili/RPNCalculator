using System;
using System.Collections.Generic;
using System.Text;

namespace RPNCalculator.Domain.Operators
{
    public class MultiplicationOperator : IBinaryOperator
    {
        public decimal CalculateBinary(decimal left, decimal right)
        {
            return left * right;
        }

        public bool IsTriggerInput(string input)
        {
            return (input == "*");
        }
    }
}
