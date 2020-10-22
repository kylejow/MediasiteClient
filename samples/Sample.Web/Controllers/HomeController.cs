using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MediasiteUtil;
using MediasiteUtil.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Sample.Web.Models;

namespace Sample.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _config;
        private readonly MediasiteClient _mediasite;

        public HomeController(ILogger<HomeController> logger, IConfiguration config, MediasiteClient mediasite)
        {
            _logger = logger;
            _config = config;
            _mediasite = mediasite;
            mediasite.Config = config.GetSection("MediasiteConfig").Get<MediasiteConfig>();
        }

        public IActionResult Index()
        {
            var folder = _mediasite.FindFolder("Mediasite");
            return View(folder);
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
