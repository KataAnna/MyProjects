using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sitecore.FakeDb;
using TestTaskWithMVC.Models;

namespace TestTaskWithMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProjectContext db;
        public HomeController(ProjectContext context)
        {
            db = context;
        }

    }
    public async Task<IActionResult> Index()
    {
        return View(await Db.Programmers.ToListAsync());
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(Programmer programmers)
    {
        db.Programmers.Add(programmers);
        await db.SaveChangesAsync();
        return RedirectToAction("Index");
    }

    //public class HomeController : Controller
    //{
    //    private readonly ILogger<HomeController> _logger;

    //    public HomeController(ILogger<HomeController> logger)
    //    {
    //        _logger = logger;
    //    }

    //    public IActionResult Index()
    //    {
    //        return View();
    //    }

    //    public IActionResult Privacy()
    //    {
    //        return View();
    //    }

    //    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    //    public IActionResult Error()
    //    {
    //        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    //    }
    //}
}
