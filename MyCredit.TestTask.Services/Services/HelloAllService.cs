using MyCredit.TestTask.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCredit.TestTask.Services.Services
{
    public class HelloAllService : IGreeter
    {
        public string SayHello()
        {
            return "Hi everyone!";
        }
    }
}
