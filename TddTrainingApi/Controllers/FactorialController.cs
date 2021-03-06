using System;
using Factorial;
using Microsoft.AspNetCore.Mvc;

namespace TddTrainingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactorialController : ControllerBase
    {
        [HttpGet("calculate/{number}")]
        public long Calculate(int number)
        {
            try
            {
                var result = FactorialHandler.Calculate(number);

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}