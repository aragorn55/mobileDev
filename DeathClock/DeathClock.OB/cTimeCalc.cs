using System;

namespace DeathClock.OB
{
	public class cTimeCalc
	{
		public cTimeCalc ()
		{
		}
		public int DaysToNextYear(DateTime voDate)
		{
			int _Days = 0;

			if (DateTime.IsLeapYear(voDate.Year))
				{
					_Days = 366 - voDate.DayOfYear;
					return _Days;
				}
				else
				{
					_Days = 365 - voDate.DayOfYear;
					return _Days;
				}
		}
		public int DaysBetweenDates(DateTime voDate1, DateTime voDate2)
		{
			int _yr1 = voDate1.Year;
			int _yr2 = voDate2.Year;
			int _days = 0;
			if (_yr1 > _yr2) {
				int count = _yr1 - _yr2 - 1 ;
				_days += DaysToNextYear (voDate2);
				for (int cnt = 0; cnt < count; cnt++) {
					if (DateTime.IsLeapYear(_yr2 +cnt + 1))
					{
						_days += 366;
					}
					else
					{
						_days += 366;
					}
				}
				_days += voDate1.DayOfYear;
				return _days;
			} else if (_yr2 > _yr1) {
				int count = _yr2 - _yr1 - 1 ;
				_days += DaysToNextYear (voDate1);
				for (int cnt = 0; cnt < count; cnt++) {
					if (DateTime.IsLeapYear(_yr1 +cnt + 1))
					{
						_days += 366;
					}
					else
					{
						_days += 366;
					}
				}
				_days += voDate2.DayOfYear;
				return _days;
			} else {
				_days = voDate1.DayOfYear - voDate2.DayOfYear;
				_days = Math.Abs(_days);
				return _days;
			}
		}
		public DateTime DaysToDate(DateTime voDate, int viDays)
		{
			DateTime _Date;
			int _Days = viDays;
			_Days += voDate.DayOfYear;
			bool _DateFound = false;
			int _year = voDate.Year;
			while (!_DateFound) {
				if (DateTime.IsLeapYear(_year))
				{
					if (_Days > 366) {
						_year += 1;
						_Days += -366;
					} else {
						_Date = DateFromDayOfYear (_year, _Days);
						_DateFound = true;
					}
			}
				else
				{
					if (_Days > 365) {
						_year += 1;
						_Days += -365;
					} else {
						_Date = DateFromDayOfYear (_year, _Days);
						_DateFound = true;
					}
				}
		}
			return _Date;
	}

		public DateTime DateFromDayOfYear (int _year, int _Days)
		{
			DateTime _Date;
			bool _MonthFound = false;
			int _month = 1;
			while (!_MonthFound) {
				if (_Days < DateTime.DaysInMonth (_year, _month)) {
					_Date = new DateTime (_year, _month, _Days);
					_MonthFound = true;
					return _Date;
				} else {
					_Days += -DateTime.DaysInMonth (_year, _month);
					_month += 1;
				}
				}
			_Date = new DateTime (_year + 1, _month, _Days);
			return _Date;
		}
}
}

