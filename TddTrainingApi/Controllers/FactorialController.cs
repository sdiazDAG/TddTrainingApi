using System;
using System.Threading.Tasks;
using Factorial;
using Microsoft.AspNetCore.Mvc;

namespace TddTrainingApi.Controllers
{
    public class FactorialController : Controller
    {
        [HttpPost("calculate/{number}")]
        public long Calculate(int number)
        {
            try
            {
                long result = FactorialHandler.Calculate(number);

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
