using RPNCalculator.Domain.Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPNCalculator.Models
{
    public class GetListOperatorsResponse
    {
        public List<IBinaryOperator> operators { get; set; }
    }
}
