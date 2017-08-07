using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using LeapYear.Models;

namespace LeapYear.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet("/")]
		public ActionResult Index()
		{
			return View();
		}
		[HttpGet("/calculate")]
		public ActionResult Calculate()
		{
			LeapYearClass leapyear = new LeapYearClass();
			leapyear.SetLeapYear(int.Parse(Request.Query["year"]));
			return View("Index", leapyear);
		}
	}
}