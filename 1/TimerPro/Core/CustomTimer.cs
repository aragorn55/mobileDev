using System;

namespace Core
{
	public class CustomTimer
	{
		private int _Sec;
		private int _Min;
		private int _Hours;

		public CustomTimer ()
		{
			_Sec = 0;
			_Min = 0;
			_Hours = 0;
		}	public void SetTickElapsed(){
			_Sec ++;
			if (_Sec == 60) {
				_Min++;
				_Sec = 0;
			}
			if (_Min == 60) {
				_Hours++;
				_Min = 0;
			}

		}
		public void Rest()
		{
			_Sec = 0;
			_Min = 0;
			_Hours = 0;
		}
		public string GetCurrentTickCount(){

			string strResult;
			strResult = _Hours.ToString ().PadLeft (2, '0') + ":" + _Min.ToString ().PadLeft (2, '0') + ":" + _Sec.ToString ().PadLeft (2, '0');
			return strResult;

		}

	}
}

