﻿using Microsoft.AspNetCore.Mvc;
using RawRabbit;

namespace Fibon.Service.Controllers
{
    [Route("[controller]")]
    public class FibonacciController : Controller
    {
        private readonly IBusClient _busClient;
        
        public FibonacciController(IBusClient busClient)
        {
            _busClient = busClient;
        }
        
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