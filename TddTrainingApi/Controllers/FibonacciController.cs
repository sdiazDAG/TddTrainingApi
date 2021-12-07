using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fibonacci;

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
