﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWebAPI.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			WebProfiler.Profiler.Run();
			return View();
		}
	}
}
