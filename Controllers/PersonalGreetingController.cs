using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MiniChallenge_1_Endpoint_MVC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonalGreetingController : ControllerBase
    {
        [HttpGet]
        public string PersonGreeting(string name){
            return "Hello " + name + "!";
        }
    }
}