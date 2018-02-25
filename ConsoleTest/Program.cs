using System;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using DAL.Models;

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

			string NOW = DateTime.Now.ToString("dd.MM");

			//response.Close();

			int id = 12345;
			string res = "qwerty" + id;
			Console.WriteLine(res);
			Console.Read();
		}		
	}
}
