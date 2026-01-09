using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myapi.WakeService;

namespace myapi.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class WakeController : ControllerBase
    {
    
        private readonly Wake _service;

        public WakeController(Wake service)
        {
            _service = service;
        } 

        [HttpGet("wakeup/{name}/{time}")]
        public string WakeUpInfo(string name, string time)
        {
            return _service.GetWakeUpInfo(name, time);
        }
    
    }
}