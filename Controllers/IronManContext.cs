using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspnetmvc5.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnetmvc5.Controllers
{
    public class IronManContext : DbContext
    {
        private readonly IronManContext _context;

        public IronManContext(IronManContext context)
        {
            _context = context;
        }

    }
}
