using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myapi.GreaterOrLessService;

namespace myapi.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class GreaterOrLessController : ControllerBase
    {
        private readonly GreaterOrLess _service;

        public GreaterOrLessController(GreaterOrLess service)
        {
            _service = service;
        }

        [HttpGet("{num1}/{num2}")]
        public string GreaterOrLessResult(int num1, int num2)
        {
            return _service.COmpareNumbers(num1, num2);
        }
    }
}