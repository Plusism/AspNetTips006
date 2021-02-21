using AspNetTips.MvcSite.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetTips.MvcSite.Controllers
{
	public class HomeController : Controller
	{
		private readonly IWebHostEnvironment _env;

		public HomeController(IWebHostEnvironment env)
		{
			_env = env;
		}

		public IActionResult Index()
		{
			var target1 = "/appsettings.json";
			var path1 = _env.MapContentRootPath(target1);
			ViewBag.Result1 = System.IO.File.Exists(path1) ? "存在します" : "存在しません";

			var target2 = "~/pdf/sample.pdf";
			var path2 = _env.MapWebRootPath(target2);
			ViewBag.Result1 = System.IO.File.Exists(path2) ? "存在します" : "存在しません";

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
