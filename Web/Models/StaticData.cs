
using System.Web.Hosting;

namespace Web.Models
{
	public static class StaticData
	{
		public static string GetJSONCurrent
		{
			get
			{				
				return System.IO.File.ReadAllText(HostingEnvironment.MapPath("~/AppFiles/CurrentWeather.json"));
			}
		}

		public static string GetJSONForecast
		{
			get  
			{
				return System.IO.File.ReadAllText(HostingEnvironment.MapPath("~/AppFiles/forecast.json"));
			}
		}
		public static string GetUkrainianCities
		{
			get
			{
				return System.IO.File.ReadAllText(HostingEnvironment.MapPath("~/AppFiles/UkrainianCities.json"));
			}			
		}
	}
}



