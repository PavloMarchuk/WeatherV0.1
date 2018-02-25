using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public static class StabCurentW
	{
		public static string GetJSONbezLimit {
			get
			{
				return  System.IO.File.ReadAllText(@"F:\Projects\0.9 WORK\07. OpenWeatherMapAPI_.Net_4.5\Weather\DAL\json1Request.json");
			}
		}

		public static string GetJSONForecast
		{
			get
			{
				return System.IO.File.ReadAllText(@"F:\Projects\0.9 WORK\07. OpenWeatherMapAPI_.Net_4.5\Weather\DAL\forecast.json");
			}
		}

	}
}
