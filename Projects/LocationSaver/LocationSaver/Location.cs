using System;
using  SQLite;
namespace LocationSaver
{
	public class Location
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		[MaxLength(8)]
		public string Latitude { get; set; }
		public string Longitude { get; set; }
	}
}

