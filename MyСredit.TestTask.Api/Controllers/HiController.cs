using MyCredit.TestTask.Services.Interfaces;
using MyCredit.TestTask.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyСredit.TestTask.Api.Controllers
{
    public class HiController : ApiController
    {
        private readonly IGreeter greeter;

        public HiController(IGreeter greeter)
        {
            this.greeter = greeter;
        }

        [HttpGet]
        public string Get()
        {
            return greeter.SayHello();
        }
    }
}
