using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using DAL.Models;

using System.Net;
using Newtonsoft.Json;
using System.IO;
//using DAL;
using Web.Models;

namespace Web.Controllers
{	 
	public class HomeController : Controller
	{
		private static string KEY = "37766c27205f21f7f3115c2727d3e4c1";
		private static string startPathCurentWeather = "http://api.openweathermap.org/data/2.5/weather?id=";
		private static string startPathForecastDaily = "http://api.openweathermap.org/data/2.5/forecast/daily?id=";

		private static string ApiCurrent = "&units=metric&APPID=";
		private static string ApiForecast = "&units=metric&cnt=6&APPID="; // first 6 days



		//forecast
		//  "http://api.openweathermap.org/data/2.5/forecast/daily?id=703448&units=metric&APPID=37766c27205f21f7f3115c2727d3e4c1"

		//current
		// "http://api.openweathermap.org/data/2.5/weather?id=703448&units=metric&APPID=37766c27205f21f7f3115c2727d3e4c1"



		public ActionResult Index()
		{
			//виймаємо із json 1675 українських міст (92kb)
			string citieaJSon = StaticData.GetUkrainianCities;
			List<CityVM> cities = JsonConvert.DeserializeObject<List<CityVM>>(citieaJSon);
			
			ViewBag.UkrainianCities = new SelectList(cities, "id", "name");

			return View();
		}

		public ActionResult WeatherPartial(int id = 703448 /*Kyiv*/)
		{
			//ViewBag.PassedIdTMP = id; //tmp !!
			
			GeneralViewModel model = new GeneralViewModel();// modelObject
						
			string pathCurrent = startPathCurentWeather + id + ApiCurrent + KEY; //запит на поточну погоду
			string pathForecast = startPathForecastDaily + id + ApiForecast + KEY; // запит на прогноз

			//string jsonCurrent;//json Current
			string jsonForecast;// json Forecast

			////// 1) отримуємо поточну погоду
			//WebRequest request1 = WebRequest.Create(pathCurrent);
			//WebResponse response1 = request1.GetResponse();
			//using (Stream stream = response1.GetResponseStream())
			//{
			//	using (StreamReader reader = new StreamReader(stream))
			//	{
			//		jsonCurrent = reader.ReadToEnd();
			//	}
			//}
			//response1.Close();

			//2) отримуємо прогноз на 6 днів 
			WebRequest request2 = WebRequest.Create(pathForecast);
			WebResponse response2 = request2.GetResponse();
			using (Stream stream = response2.GetResponseStream())
			{
				using (StreamReader reader = new StreamReader(stream))
				{
					jsonForecast = reader.ReadToEnd();
				}
			}
			response2.Close();

			/////// TMP!!!!! // для отладки закоментувати запити
			//jsonCurrent = StaticData.GetJSONCurrent(Server.MapPath("~"));
			//jsonForecast = StaticData.GetJSONForecast(Server.MapPath("~"));
			///////

			// десеріалізація результатів у C# класи
			//model.CurrentWeather = JsonConvert.DeserializeObject<CurrentWeatherVM>(jsonCurrent);
			model.Forecast = JsonConvert.DeserializeObject<ForecastVM>(jsonForecast);

			#region MyRegion	
			//// для економії одного запиту можна
			//// витягувати поточну погоду з об'єкту прогнозу:	
			DateTime today = DateTime.Today;
			model.CurrentWeather = model.Forecast.list
				.Where(f => f.date.Day == today.Day)
				.Select(c => new CurrentWeatherVM
				{
					name = model.Forecast.city.name,
					dt = c.dt,
					weather = new List<CurrentWeatherVM.Weather>
					{
						new CurrentWeatherVM.Weather
						{
							description = c.weather.First().description ,
							icon = c.weather.First().icon
						}
					},
					main = new CurrentWeatherVM.Main
					{
						temp = c.temp.day,
						temp_max = c.temp.max,
						temp_min = c.temp.min,
						pressure = c.pressure,
						humidity = c.humidity
					},
					id = model.Forecast.city.id
				})
				.First();

			#endregion

			return PartialView(model);			
		}		
	}
}
