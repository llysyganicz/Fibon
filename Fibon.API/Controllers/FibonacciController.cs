﻿using Microsoft.AspNetCore.Mvc;
using RawRabbit;

namespace Fibon.API.Controllers
{
    [Route("[controller]")]
    public class FibonacciController : Controller
    {
        [HttpGet("{number}")]
        public IActionResult Get(int number)
        {
            return Content("0");
        }

        [HttpPost("{number}")]
        public IActionResult Post(int number)
        {
            return Accepted($"Fibonacci/{number}", null);
        }
    }
}