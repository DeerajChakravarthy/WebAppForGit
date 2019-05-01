using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppForGitHub.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page changed. Change from branch.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page. New change";

			return View();
		}
	}
}