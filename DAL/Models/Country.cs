using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL.Models
{
	public class Country
	{
		public string countryName { get; set; }
		public List< City> cities { get; set; }

		public Country()
		{
			cities = new List<City>();
		}
	}
}