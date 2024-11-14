using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RMSByInfinitix.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult LogIn()
		{
			return View();	
		}

		public ActionResult Dashboard()
		{
			return View();	
		}

		public ActionResult ClientIndex()
		{
			return View();	
		}

		public ActionResult ClientAddEdit()
		{
			return View();	
		}
	}
}