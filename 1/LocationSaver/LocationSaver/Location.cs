using System;
using SQLite;

namespace LocationSaver
{
	public class Location
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		[MaxLength(20)]
		public string Latitude { get; set; }
		[MaxLength(20)]
		public string Longitude { get; set; }
	}
}

