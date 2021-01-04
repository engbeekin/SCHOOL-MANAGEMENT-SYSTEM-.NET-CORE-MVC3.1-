using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchoolMangmentSystemCore.Models;

namespace SchoolMangmentSystemCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly schoolcontext Context;

        public HomeController(ILogger<HomeController> logger, schoolcontext context)
        {
            _logger = logger;
            Context = context;
        }
        
        //public HomeController(schoolcontext context)
        //{
           
        //}
        public IActionResult Index()
        {
            ViewBag.NumOfStudents = Context.students.Count();
            ViewBag.NumOfCourses = Context.subjects.Count();
            ViewBag.NumOfTeachers = Context.teachers.Count();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
