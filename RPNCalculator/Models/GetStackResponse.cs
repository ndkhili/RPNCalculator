using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPNCalculator.Models
{
    public class GetStackResponse
    {
        public Stack<Decimal> stack { get; set; }
    }
}
