using RPNCalculator.Domain.Operators;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPNCalculator.Services
{
    public interface ICalculateService
    {
        Stack<decimal> CreateStack(int capacity);

        Stack<decimal> GetStack(int stackId);

        List<IBinaryOperator> GetListOperators();

        Stack<decimal> Calculate(int stackId);

        void ApplyOperandToStack(string input, int stackId);
    }
}
