using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
namespace MortalityCalculator.OB
{
    public class cDeathCalculator
    {
		public cDeathCalculator()
		{

		}
		cPerson oUser;
		private double _YearsLeft;
		//private int _YearsLeft;
        

		public DateTime TimeLeft()
		{
		//_YearsLeft
		 throw new System.NotImplementedException();
		}
        public double FindTimeLeft(cPerson voUser)
        {
			oUser = voUser;
			_YearsLeft = FindBaseYears() + FindBMIYrs() + CigarettePenalty() + Sleep();
			_YearsLeft = FindYearsLeft(_YearsLeft);
			return _YearsLeft;
        }

        public double FindYearsLeft(double vBaseYears)
        {
			return vBaseYears - oUser.ComputeAge();
        }
		public double FindBaseYears()
		{
			if (oUser.Sex == eGender.male) {
				return 85.0;
			} else {
				return 90.0;
			}
		}

		public double FindBMIYrs()
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
        
        public double CigarettePenalty()
        {
            double _CigPenalty = 0.0;
            _CigPenalty = (oUser.CigPerDay * 365.0 * 20.0) / 525949.0;
            return _CigPenalty;
        }
        public double Sleep()
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
        
        
        public double BaseLine()
        {
            throw new System.NotImplementedException();
        }

    }
}
