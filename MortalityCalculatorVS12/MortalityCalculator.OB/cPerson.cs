using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities.OB;
namespace MortalityCalculator.OB
{
    public class cPerson
    {
        private int _Age;
		private DateTime _BirthDate;
        private int _BloodPressure;
        private int _CigPerDay;
        private int _DrinksPerDay;
        private int _Height;
        private int _HrsSleep;
        private int _MinExcercisePerWeek;
        private int _Sex;

        private int _Weight;

        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }
		public DateTime BirthDate
		{
			get { return _BirthDate; }
			set { _BirthDate = value; }
		}
        public int BloodPressure
        {
            get { return _BloodPressure; }
            set { _BloodPressure = value; }
        }

        public int CigPerDay
        {
            get { return _CigPerDay; }
            set { _CigPerDay = value; }
        }

        public int DrinksPerDay
        {
            get { return _DrinksPerDay; }
            set { _DrinksPerDay = value; }
        }

        public int Height
        {
            get { return _Height; }
            set { _Height = value; }
        }


       

        public int HrsSleep
        {
            get { return _HrsSleep; }
            set { _HrsSleep = value; }
        }

        public int MinExcercisePerWeek
        {
            get { return _MinExcercisePerWeek; }
            set { _MinExcercisePerWeek = value; }
        }

        public int Sex
        {
            get { return _Sex; }
            set { _Sex = value; }
        }
        public int Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }
        public cPerson()
        {

			_Age = -1;
			_BloodPressure = -1;
			_CigPerDay = -1;
			_Height = -1;
			_HrsSleep = -1;
			_DrinksPerDay = -1;
			_MinExcercisePerWeek = -1;
			_Sex = -1;
			_Weight = -1;


        }
		public int ComputeAge()
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
