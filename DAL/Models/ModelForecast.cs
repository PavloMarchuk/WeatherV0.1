﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
	public class ForecastObject
	{
		public string cod { get; set; }
		public double message { get; set; }
		public int cnt { get; set; }
		public List<List> list { get; set; }
		public City city { get; set; }		
	}
	public class List
	{
		public int dt { get; set; }
		public Main main { get; set; }
		public List<Weather> weather { get; set; }
		public Clouds clouds { get; set; }
		public Wind wind { get; set; }
		//public Snow snow { get; set; }
		public Sys sys { get; set; }
		public string dt_txt { get; set; }
		public class Sys
		{
			public string pod { get; set; }
		}
		public class Main
		{
			public double temp { get; set; }
			public double temp_min { get; set; }
			public double temp_max { get; set; }
			public double pressure { get; set; }
			public double sea_level { get; set; }
			public double grnd_level { get; set; }
			public int humidity { get; set; }
			public double temp_kf { get; set; }
		}






		//public class Snow
		//{
		//	public double __invalid_name__3h { get; set; }
		//}


	}
}