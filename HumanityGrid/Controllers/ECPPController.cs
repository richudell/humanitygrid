using HumanityGrid.ECPP;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace HumanityGrid.Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EcppController : ControllerBase
    {
        private readonly EcppAlgorithm _ecpp;

        public EcppController(EcppAlgorithm ecpp)
        {
            _ecpp = ecpp;
        }

        [HttpGet("isprime/{number}")]
        public IActionResult IsPrime(string number)
        {
            if (!BigInteger.TryParse(number, out BigInteger n))
            {
                return BadRequest("Invalid number format.");
            }

            var result = _ecpp.IsPrime(n);
            return Ok(new { Number = n, IsPrime = result });
        }
    }
}
