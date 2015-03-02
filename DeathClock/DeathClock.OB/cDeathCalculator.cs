using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeathClock.OB
{
    public class cDeathCalculator
    {
		cPerson oUser;
		private double _YearsLeft;
		private double _Years;
		private double _Months;
		private double _Days;
		private cTimeCalc oCalc = new cTimeCalc();
		public cDeathCalculator()
		{
		}
        public double FindTimeLeft(cPerson voUser)
        {
			oUser = voUser;
			_YearsLeft = FindYearsLeft(FindBaseYears()) + FindBMIYrs() + Sleep();
			double dCigYears = (_YearsLeft * CigarettePenalty ()) / 1440;
			_YearsLeft =_YearsLeft - dCigYears;
			_Years = Math.Floor(_YearsLeft);
			_Days = (_YearsLeft - _Years) * 365.0;
			_Months = Math.Floor (_Days / 30.4);
			_Days = _Days - (_Months * 30.4);
			return _YearsLeft;
        }
		public DateTime DayYouDie(cPerson voUser)
		{
			DateTime _DeathDate;
			oUser = voUser;
			_Days = FindBaseDays() + FindBMIDays() + SleepDays();
			double dCigDays = (_Days * CigarettePenalty ()) / 1440;
			_Days =_Days - dCigDays;
			_DeathDate = oCalc.DaysToDate (voUser.BirthDate, (int)_Days);
			return _DeathDate;

		}
        private double FindYearsLeft(double vBaseYears)
        {
			return vBaseYears - oUser.ComputeAge();
        }

		private double FindBaseYears()
		{
			if (oUser.Sex == eGender.male) {
				return 85.0;
			} else {
				return 90.0;
			}
		}
		private double FindBaseDays()
		{
			if (oUser.Sex == eGender.male) {
				return 31046;
			} else {
				return 32872;
			}
		}
		private double FindBMIDays()
        {
            double _BMI = (oUser.Weight / (oUser.Height * oUser.Height)) * 703.0;
            
			if ( _BMI < 16.0)
			{
				return -1096.0;
			}
			else if ( _BMI < 28.0)
			{
				return 366.0;
			}
			if ( _BMI < 35.0)
			{
				return -1827.0;
			}
			else
			{
				return -2922.0;
			}
        }
		private double FindBMIYrs()
		{
			double _BMI = (oUser.Weight / (oUser.Height * oUser.Height)) * 703.0;

			if ( _BMI < 16.0)
			{
				return -3.0;
			}
			else if ( _BMI < 28.0)
			{
				return 1.0;
			}
			if ( _BMI < 35.0)
			{
				return -5.0;
			}
			else
			{
				return -8.0;
			}
		}
		private double CigarettePenalty()
        {
            double _CigPenalty = 0.0;
            _CigPenalty = (oUser.CigPerDay * 20.0);
            return _CigPenalty;
        }
		private double CigarettePenaltyDays()
		{
			double _CigPenalty = 0.0;
			_CigPenalty = (oUser.CigPerDay * 20.0);
			return _CigPenalty;
		}
		private double Sleep()
        {
			if (oUser.HrsSleep < 7) {

				double _Yrs = (7.0 - oUser.HrsSleep) * -4.0;
				return _Yrs;
			}
			else
			{
			return 0.0;
			}
        }
		private double SleepDays()
		{
			if (oUser.HrsSleep < 7) {

				double _Days = ((7.0 - oUser.HrsSleep) * -4.0) * 366;
				return _Days;
			}
			else
			{
				return 0.0;
			}
		}
		public double Years()
		{
			return Math.Floor (_Years);
		}

		public double Months ()
		{
			return Math.Floor (_Months);
		}

		public double Days ()
		{
			return Math.Floor (_Days);
		}
       

    }
}
