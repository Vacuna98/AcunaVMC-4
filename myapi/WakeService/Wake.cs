using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace myapi.WakeService
{
    public class Wake
    {
        public string GetWakeUpInfo(string name, string time)
        {
            return $"My name is {name} and I woke up at {time}.";
        }
    }
}