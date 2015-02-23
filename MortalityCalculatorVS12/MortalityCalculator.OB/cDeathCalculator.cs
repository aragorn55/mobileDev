using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
namespace MortalityCalculator.OB
{
    public class cDeathCalculator
    {
		cPerson oUser;
		private int _YearsLeft;
        public int FindTimeLeft(cPerson voUser)
        {
			oUser = voUser;
            throw new System.NotImplementedException();
        }

        public int FindBaseYearsLeft(int vBaseYears, int vAge)
        {
			return vBaseYears - vAge;
        }
		public int FindBaseYears(eGender vGender)
		{
			if (vGender == eGender.male) {
				return 85;
			} else {
				return 90;
			}
		}

		public double FindBMI()
        {
            double _BMI = (oUser.Weight / (oUser.Height * oUser.Height)) * 703;
            return _BMI;
        }
        
        public double CigarettePenalty()
        {
            double _CigPenalty = 0;
            _CigPenalty = (oUser.CigPerDay * 365 * 20) / 525949;
            return _CigPenalty;
        }
        public double Sleep()
        {
            throw new System.NotImplementedException();
        }
        
        
        public double BaseLine()
        {
            throw new System.NotImplementedException();
        }

    }
}
