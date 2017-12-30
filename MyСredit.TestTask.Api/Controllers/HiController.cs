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
    public class HiController : System.Web.Http.ApiController
    {
        private readonly IGreeter helloService;

        public HiController(IGreeter helloService)
        {
            this.helloService = helloService;
        }

        [HttpGet]
        public string Hi()
        {
            return helloService.SayHello();
        }
    }
}
