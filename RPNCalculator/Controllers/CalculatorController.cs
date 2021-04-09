
using Microsoft.AspNetCore.Mvc;
using RPNCalculator.Models;
using RPNCalculator.Services;

namespace RPNCalculator.Controllers
{
    [Route("api/rpn")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private ICalculateService calculateService;

        public CalculatorController(ICalculateService calculateService)
        {
            this.calculateService = calculateService;
        }

        [HttpGet("{id}")]
        public ActionResult<GetStackResponse> GetStack(GetStackRequest request)
        {
            GetStackResponse response = new GetStackResponse();
            if(response != null)
            {
                response.stack = calculateService.GetStack(request.stackId);
            }

            return response;
        }

        [HttpGet("op")]
        public  ActionResult<GetListOperatorsResponse> GetListOperators()
        {
            GetListOperatorsResponse response = new GetListOperatorsResponse();

            response.operators = calculateService.GetListOperators();

            return response;
        }

        [HttpPost("capacity")]
        public ActionResult<CreateStackRepsonse> CreateStack(CreateStackRequest request)
        {
            CreateStackRepsonse response = new CreateStackRepsonse();

            response.stack = calculateService.CreateStack(request.capacity);

            return response;
        }

        [HttpPut("{id}")]
        public ActionResult<CalculateReponse> PushValue([FromBody] int stackId)
        {
            CalculateReponse response = new CalculateReponse();

            response.stack = calculateService.Calculate(stackId);

            return response;
        }
    }
}