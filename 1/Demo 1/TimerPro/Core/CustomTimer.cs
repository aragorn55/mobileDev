using System;

namespace Core
{
	public class CustomTimer
	{
		private int Sec;
		private int Min;
		private int Hour;

		public CustomTimer()
		{
			Sec = 0;
			Min = 0;
			Hour = 0;
		}

		public void SetTickElapsed()
		{
			Sec++;
			if (Sec == 60)
			{
				Sec = 0;
				Min++;
			}
			if (Min == 60)
			{
				Min = 0;
				Hour++;
			}

		}

		public string GetCurrentTickCount()
		{
			return Hour.ToString().PadLeft(2, '0') + ":" + Min.ToString().PadLeft(2, '0') + ":" + Sec.ToString().PadLeft(2, '0');
		}

		public void Reset()
		{
			Sec = 0;
			Min = 0;
			Hour = 0;
		}

	}
}
