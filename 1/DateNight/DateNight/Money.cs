using System;

namespace DateNight
{
	public class Money
	{
		public Money ()
		{
		}

		public double CoffeeTotal {
			get;
			set;
		}

		public double ShoppingTotal {
			get;
			set;
		}

		public double MovieTotal {
			get;
			set;
		}

		public double GetTotalCost(){

			return CoffeeTotal + ShoppingTotal + MovieTotal;
		}
	}
}

