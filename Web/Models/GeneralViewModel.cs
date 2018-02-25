using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
	public class GeneralViewModel
	{	
		public ForecastVM Forecast { get; set; }
		public CurrentWeatherVM CurrentWeather { get; set; }
	}
}