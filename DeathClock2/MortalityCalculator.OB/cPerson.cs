using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Utilities.OB;
namespace MortalityCalculator.OB
{
    public class cPerson
    {
        
		private DateTime _BirthDate;
        private double _BloodPressure;
        private double _CigPerDay;
        private double _DrinksPerDay;
        private double _Height;
        private double _HrsSleep;
        private double _MinExcercisePerWeek;
        private eGender _Sex;

        private double _Weight;

       
		public DateTime BirthDate
		{
			get { return _BirthDate; }
			set { _BirthDate = value; }
		}
        public double BloodPressure
        {
            get { return _BloodPressure; }
            set { _BloodPressure = value; }
        }

        public double CigPerDay
        {
            get { return _CigPerDay; }
            set { _CigPerDay = value; }
        }

        public double DrinksPerDay
        {
            get { return _DrinksPerDay; }
            set { _DrinksPerDay = value; }
        }

        public double Height
        {
            get { return _Height; }
            set { _Height = value; }
        }


       

        public double HrsSleep
        {
            get { return _HrsSleep; }
            set { _HrsSleep = value; }
        }

        public double MinExcercisePerWeek
        {
            get { return _MinExcercisePerWeek; }
            set { _MinExcercisePerWeek = value; }
        }

        public eGender Sex
        {
            get { return _Sex; }
            set { _Sex = value; }
        }
        public double Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }
        public cPerson()
        {



			_CigPerDay = -1;
			_Height = -1;
			_HrsSleep = -1;
			_DrinksPerDay = -1;
			_MinExcercisePerWeek = -1;
			//_Sex = eGender;
			_Weight = -1;


        }
		public double ComputeAge()
		{
			DateTime newDate = DateTime.Now;

			// Difference in days, hours, and minutes.
			TimeSpan ts = newDate - _BirthDate;
			// Difference in days.
			//int differenceInDays = ts.;
			//  int differenceInDays = newDate.Subtract(mdBirthDate).TotalDays;
			//Console.WriteLine("Difference in days: {0} ", differenceInDays);
			DateTime now = DateTime.Today;
			int age = now.Year - _BirthDate.Year;
			if (_BirthDate > now.AddYears(-age)) age--;
			return age;
		}
    }
}
