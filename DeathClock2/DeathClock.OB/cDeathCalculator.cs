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
		public cDeathCalculator()
		{

		}

		//private int _YearsLeft;
        

        public double FindTimeLeft(cPerson voUser)
        {
			oUser = voUser;
			_YearsLeft = FindYearsLeft(FindBaseYears()) + FindBMIYrs() + Sleep();
			double dCigYears = (_YearsLeft * CigarettePenalty ()) / 1440;
			_YearsLeft =_YearsLeft - dCigYears;
			return _YearsLeft;
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
        
        
       

    }
}
