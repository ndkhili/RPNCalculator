using System;
using System.Collections.Generic;
using System.Text;
using RPNCalculator.Domain.Operators;

namespace RPNCalculator.Services
{
    public class CalculateService : ICalculateService
    {
        public IBinaryOperator binaryOperator;

        public CalculateService(IBinaryOperator binaryOperator)
        {
            this.binaryOperator = binaryOperator;
        }

        public void ApplyOperandToStack(string input, int stackId)
        {
            var stack = GetStack(stackId);
            var listOperators = GetListOperators();
            foreach(IBinaryOperator op in listOperators)
            {
                if(op.IsTriggerInput(input))
                {
                    Calculate(stackId);
                    ApplyUserInput(stack);
                }
            }
        }

        public Stack<decimal> Calculate(int stackId)
        {
            var stack = GetStack(stackId); 
            if (stack.Count < 2)
            {
                throw new InvalidOperationException("A binary operator requires at least 2 numbers in the stack");
            }

            decimal right = stack.Pop();
            decimal left = stack.Pop();

            decimal result = binaryOperator.CalculateBinary(left, right);

            // the result is expected to be pushed onto the stack
            stack.Push(result);

            return stack;
        }

        public Stack<decimal> CreateStack(int capacity)
        {
            return new Stack<decimal>(capacity);
        }

        public List<IBinaryOperator> GetListOperators()
        {
            var listOperators = new List<IBinaryOperator>();
            listOperators.Add(new AdditionOperator());
            listOperators.Add(new SubstractionOperator());
            listOperators.Add(new MultiplicationOperator());
            listOperators.Add(new DivisionOperator());

            return listOperators;
        }

        public Stack<decimal> GetStack(int stackId)
        {
            throw new NotImplementedException();
        }

        private string ApplyUserInput(Stack<decimal> stack)
        {
            return stack.Peek().ToString();
        }
    }
}
