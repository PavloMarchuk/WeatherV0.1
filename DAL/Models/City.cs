using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL.Models
{
	public class City
	{
		public int id { get; set; }
		public string name { get; set; }
		public string country { get; set; }
		public Coord coord { get; set; }
	}
}
/*
[
  {
    "id": 707860,
    "name": "Hurzuf",
    "country": "UA",
    "coord": {
      "lon": 34.283333,
      "lat": 44.549999
    }
  },
  {
    "id": 519188,
    "name": "Novinki",
    "country": "RU",
    "coord": {
      "lon": 37.666668,
      "lat": 55.683334
    }
  },

	*/

