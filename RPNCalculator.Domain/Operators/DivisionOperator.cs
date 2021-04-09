using System;
using System.Collections.Generic;
using System.Text;

namespace RPNCalculator.Domain.Operators
{
    public class DivisionOperator : IBinaryOperator
    {
        public decimal CalculateBinary(decimal left, decimal right)
        {
            if (right == 0)
            {
                throw new InvalidOperationException("Can not divise by zero");
            }
            return left / right;
        }

        public bool IsTriggerInput(string input)
        {
            return (input == "/");
        }
    }
}
