using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.Models;

using System.Net;
using Newtonsoft.Json;
using System.IO;
using DAL;

namespace Web.Controllers
{	 
	public class HomeController : Controller
	{
		
		private static string forecastDaily = "api.openweathermap.org/data/2.5/forecast/daily?id=703448&APPID=3e1125480c3c82908e7a4531618c3082";
		private static string forecastSTR =
	   "api.openweathermap.org/data/2.5/forecast?id=703448&APPID=3e1125480c3c82908e7a4531618c3082";
		private static string CityId = "703448";
		private static string ApiKey = "&units=metric&APPID=" + "3e1125480c3c82908e7a4531618c3082";
		//private static string ApiKey = "&APPID=" + "7f1e9f3473468550ad03c2c53a9a90d1";
		private static string startPathCurentWeather = "http://api.openweathermap.org/data/2.5/weather?id=";
		//3e1125480c3c82908e7a4531618c3082
		// присланий ключ 37766c27205f21f7f3115c2727d3e4c1
		//"http://api.openweathermap.org/data/2.5/forecast/daily?id=703448&units=metric&cnt=8&APPID=37766c27205f21f7f3115c2727d3e4c1"
		//поточна температура
		//  http://api.openweathermap.org/data/2.5/weather?id=703448&units=metric&APPID=37766c27205f21f7f3115c2727d3e4c1


		//  http://api.openweathermap.org/data/2.5/weather?id=703448&APPID=3e1125480c3c82908e7a4531618c3082

		//"http://api.openweathermap.org/data/2.5/forecast/daily?id=703448&APPID=37766c27205f21f7f3115c2727d3e4c1&cnt=5"

		//http://api.openweathermap.org/data/2.5/weather?id=b1b15e88fa797225412429c1c50c122a1
		static City Kyiv = new City
		{
			name = "Kiev",
			id = 703448,
			country = "UA",
			coord = new Coord { lat = 30.516666, lon = 50.433334 }
		};
		Country country = new Country{cities = new List<City> { Kyiv }, countryName = Kyiv.country };
				

		public ActionResult Index()
		{			
			return View(Kyiv);
		}

		public ActionResult WeatherPartial(int id = 0 /*703448*/)
		{
			id = Kyiv.id;
			RootObject model;
			//string path = "http://api.openweathermap.org/data/2.5/weather?id=703448&APPID=3e1125480c3c82908e7a4531618c3082";
			string path = startPathCurentWeather + id + ApiKey;
			
			string jsonStr;
			//WebRequest request = WebRequest.Create(path);
			//WebResponse response = request.GetResponse();
			//using (Stream stream = response.GetResponseStream())
			//{
			//	using (StreamReader reader = new StreamReader(stream))
			//	{
			//		jsonStr = reader.ReadToEnd();					
			//	}
			//}
			//response.Close();
			///// TMP!!!!!
			jsonStr = StabCurentW.GetJSONbezLimit;
			/////
			model = JsonConvert.DeserializeObject<RootObject>(jsonStr);
					
			return PartialView(model);			
		}


		public ActionResult TMP()
		{
			var model = new City();
			return View(model);
		}
	}
}
