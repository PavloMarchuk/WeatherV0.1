
using System.Web.Hosting;

namespace Web.Models
{
	public static class StaticData
	{
		public static string GetJSONCurrent
		{
			get
			{
				//return System.IO.File.ReadAllText(@"F:\Projects\0.9 WORK\07. OpenWeatherMapAPI_.Net_4.5\Weather\DAL\json1Request.json");
				
				return System.IO.File.ReadAllText(HostingEnvironment.MapPath("~/AppFiles/CurrentWeather.json"));
			}
		}

		public static string GetJSONForecast
		{
			get  
			{
				//return System.IO.File.ReadAllText(@"F:\Projects\0.9 WORK\07. OpenWeatherMapAPI_.Net_4.5\Weather\DAL\forecast8.json");

				return System.IO.File.ReadAllText(HostingEnvironment.MapPath("~/AppFiles/forecast.json"));
			}
		}
		public static string GetUkrainianCities
		{
			get
			{
				//return System.IO.File.ReadAllText(@"F:\Projects\0.9 WORK\07. OpenWeatherMapAPI_.Net_4.5\Weather\Web\App_Data\UkrainianCities.json");


				return System.IO.File.ReadAllText(HostingEnvironment.MapPath("~/AppFiles/UkrainianCities.json"));
				
			}			
		}

	}
}



