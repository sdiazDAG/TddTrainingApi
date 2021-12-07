using System;
using Fibonacci;
using Microsoft.AspNetCore.Mvc;

namespace TddTrainingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        [HttpGet("calculate/{position}")]
        public long Calculate(int position)
        {
            try
            {
                long result = FibonacciHandler.Calculate(position);

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}