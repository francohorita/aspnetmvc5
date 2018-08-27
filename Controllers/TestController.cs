using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspnetmvc5.Models;

namespace aspnetmvc5.Controllers
{
    public class TestController : Controller
    {
        private readonly IronManContext _context;

        public TestController(IronManContext context)
        {
            _context = context;
        }

    }
}
