using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApp.Data;

namespace MovieApp.Controllers
{
    public class DirectorsController : Controller
    {
        private readonly AppDbContext _context;
        public DirectorsController(AppDbContext context)
        {
            _context = context;      
        }
        public async Task<IActionResult> Index()
        {
            var allDirectors = await _context.Directors.ToListAsync();
            return View();
        }
    }
}
