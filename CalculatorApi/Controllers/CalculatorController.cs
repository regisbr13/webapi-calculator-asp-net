using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MinhaApi.Services;

namespace MinhaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // GET api/calculator/sum/1/1
        [HttpGet("sum/{x1}/{x2}")]
        public ActionResult Sum(string x1, string x2)
        {
            if(Useful.IsNumeric(x1) && Useful.IsNumeric(x2)) {
                var result = double.Parse(x1, CultureInfo.InvariantCulture) + double.Parse(x2, CultureInfo.InvariantCulture);
                return Ok(result.ToString());
            }
            return BadRequest("Invalid input");
        }

        // GET api/calculator/subtract/1/1
        [HttpGet("sub/{x1}/{x2}")]
        public ActionResult Subtract(string x1, string x2)
        {
            if(Useful.IsNumeric(x1) && Useful.IsNumeric(x2)) {
                var result = double.Parse(x1, CultureInfo.InvariantCulture) - double.Parse(x2, CultureInfo.InvariantCulture);
                return Ok(result.ToString("F2", CultureInfo.InvariantCulture));
            }
            return BadRequest("Invalid input");
        }

        // GET api/calculator/multiply/1/1
        [HttpGet("mult/{x1}/{x2}")]
        public ActionResult Multiply(string x1, string x2)
        {
            if(Useful.IsNumeric(x1) && Useful.IsNumeric(x2)) {
                var result = double.Parse(x1, CultureInfo.InvariantCulture) * double.Parse(x2, CultureInfo.InvariantCulture);
                return Ok(result.ToString("F2", CultureInfo.InvariantCulture));
            }
            return BadRequest("Invalid input");
        }

        // GET api/calculator/divide/1/1
        [HttpGet("div/{x1}/{x2}")]
        public ActionResult Divide(string x1, string x2)
        {
            if(Useful.IsNumeric(x1) && Useful.IsNumeric(x2)) {
                var result = double.Parse(x1, CultureInfo.InvariantCulture) / double.Parse(x2, CultureInfo.InvariantCulture);
                return Ok(result.ToString("F2", CultureInfo.InvariantCulture));
            }
            return BadRequest("Invalid input");
        }

        // GET api/calculator/sqrt/1
        [HttpGet("sqrt/{x}")]
        public ActionResult SquareRoot(string x)
        {
            if(Useful.IsNumeric(x)) {
                if(double.Parse(x) >= 0) {
                    var result = Math.Sqrt(double.Parse(x));
                    return Ok(result.ToString("F2", CultureInfo.InvariantCulture));
                }
            }
            return BadRequest("Invalid input");
        }
    }
}
