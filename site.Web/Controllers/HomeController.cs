using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using site.Business;
using site.Entities;
using site.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace site.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBolumService bolumService;

        public HomeController(ILogger<HomeController> logger, IBolumService bolumService) 
        {
            _logger = logger;
            this.bolumService = bolumService;
        }

        public IActionResult Index(int page=1)
        {
            var bolums = bolumService.GetEpisodes();
            var episodePerPages = 3;
            ViewBag.TotalEpisodes = Math.Ceiling(((decimal)bolums.Count / episodePerPages)+1);
            var paginatedBolums = bolums.OrderBy(x => x.Id)
                .Skip((page - 1) * episodePerPages).Take(episodePerPages);
            
            return View(paginatedBolums);
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
