using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class TMPController : Controller
    {
        // GET: TMP
        public ActionResult Index()
        {
			string path = StaticData.GetUkrainianCities;
			


			ViewBag.modelstr = path;
				//JsonConvert.DeserializeObject<CityVM>(jsonCities);
			return View();
        }
    }
}