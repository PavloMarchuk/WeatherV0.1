using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
	public class ForecastVM
	{
		
		public List<List> list { get; set; }

		public class Temp
		{
			public double day { get; set; }
			public double min { get; set; }
			public double max { get; set; }
			//public double night { get; set; }
			//public double eve { get; set; }
			//public double morn { get; set; }
		}

		public class Weather
		{
			//public int id { get; set; }
			//public string main { get; set; }
			public string description { get; set; }
			public string icon { get; set; }
		}

		public class List
		{
			
			public DateTime date
			{
				get {
					TimeSpan ts = TimeSpan.FromSeconds(dt);
					return new DateTime().Add(ts); 
				}
			}
			public int dt { get; set; }
			public Temp temp { get; set; }
			//public double pressure { get; set; }
			//public int humidity { get; set; }
			public List<Weather> weather { get; set; }
			//public double speed { get; set; }
			//public int deg { get; set; }
			//public int clouds { get; set; }
			//public double snow { get; set; }
			//public double? rain { get; set; }
		}
	}
}