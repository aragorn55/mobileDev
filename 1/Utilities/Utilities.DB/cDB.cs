using System;

namespace Utilities.DB
{
	public class cDB
	{

			[PrimaryKey, AutoIncrement]
			public int Id { get; set; }
			[MaxLength(20)]
			public string URL { get; set; }
			[MaxLength(20)]
			public string FileName { get; set; }

	}
}

