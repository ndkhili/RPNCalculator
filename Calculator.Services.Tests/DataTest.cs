using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Services.Tests
{
    public static class DataTest
    {
        public const int CAPACITY = 4;

        public static Stack<decimal> GetStack()
        {
            Stack<decimal> stack = new Stack<decimal>();

            stack.Push(1);
            stack.Push(4);
            stack.Push(6);

            return stack;
        }

    }
}
