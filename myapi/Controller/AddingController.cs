using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myapi.AddNumbersService;

namespace myapi.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddingController : ControllerBase
    {
        
         private readonly AddNumbers _service;

        public AddingController(AddNumbers service)
        {
            _service = service;
        }

        [HttpGet("{num1}/{num2}")]
        public string AddNumbers(int num1, int num2)
        {
            return _service.GetSumSentence(num1, num2);
        }
    }
}