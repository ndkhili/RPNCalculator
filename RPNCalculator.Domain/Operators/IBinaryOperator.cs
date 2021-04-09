using System;
using System.Collections.Generic;
using System.Text;

namespace RPNCalculator.Domain.Operators
{
    public interface IBinaryOperator
    {
        decimal CalculateBinary(decimal left, decimal right);

        bool IsTriggerInput(string input);
    }
}
