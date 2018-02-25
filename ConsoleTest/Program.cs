using System;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using DAL.Models;
using DAL;
using System.Collections.Generic;
using Web.Models;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Web.Hosting;

namespace ConsoleTest
{
	class Program
	{

		private static string CityId = "703448";
		private static string ApiKey = "&APPID=" +  "3e1125480c3c82908e7a4531618c3082";
		private static string startPathCurentWeather = "http://api.openweathermap.org/data/2.5/weather?id=";

		private static string path = "http://api.openweathermap.org/data/2.5/weather?id=" +
			CityId +  ApiKey;
			//"3e1125480c3c82908e7a4531618c3082";
		//℃ =K - 273.15
		//string id = "707860";
		//api.openweathermap.org/data/2.5/weather? id = 2172797
		static void Main(string[] args)
		{
			//WebRequest request = WebRequest.Create(path);
			//WebResponse response = request.GetResponse();
			//using (Stream stream = response.GetResponseStream())
			//{
			//	using (StreamReader reader = new StreamReader(stream))
			//	{
			//		string jsonStr = reader.ReadToEnd();
			//		RootObject rootObject = JsonConvert.DeserializeObject<RootObject>(jsonStr);


			//		Console.WriteLine(rootObject.name);
			//		Console.WriteLine($"Температура {(Int32)(rootObject.main.temp - 273.15)} C");
			//	}
			//}

			//DateTime NOW = DateTime.Now;

			////response.Close();

			//int id = 12345;
			//string res = "qwerty" + id;
			//Console.WriteLine(res);

			////1519552800
			//DateTime d = new DateTime(1519552800);
			//Console.WriteLine(d.ToString("dd.MM  ss"));

			//long now = NOW.Ticks;
			//Console.WriteLine(now);

			////1519466400
			////1519552800
			//Console.WriteLine(1519552800 /86400/365);

			string jsonCities =  StaticData.GetUkrainianCities;
			//List<CityVM> cities = JsonConvert.DeserializeObject<List<CityVM>>(citieaJSon);
			//List<CityVM> model = cities.Where(c => c.country == "UA").ToList();

			//CityVM model = new CityVM();
			//model  = JsonConvert.DeserializeObject<CityVM>(jsonCities);



			Console.WriteLine(jsonCities);

			




			//string json = JsonConvert.SerializeObject(cities, Formatting.Indented);
			
			//File.WriteAllText(@"F:\Projects\0.9 WORK\07. OpenWeatherMapAPI_.Net_4.5\Weather\ConsoleTest\CitiesList.json", json);
			////Console.WriteLine(json);

			Console.Read();
			Console.Read();
		}		
	}
}
