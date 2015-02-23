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
        private int _BloodPressure;
        private int _CigPerDay;
        private int _DrinksPerDay;
        private int _Height;
        private eMyBoolean _HistBreastCancer;
        private eMyBoolean _HistDiabetes;
        private eMyBoolean _HistHeartDiseases;
        private eMyBoolean _HistLungCancer;
        private eMyBoolean _HistProstateCancer;
        private eMyBoolean _HistStomachCancer;
        private eMyBoolean _HistStroke;
        private int _HrsSleep;
        private int _MinExcercisePerWeek;
        private int _Sex;

        private int _Weight;

        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
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

        public eMyBoolean HistBreastCancer
        {
            get { return _HistBreastCancer; }
            set { _HistBreastCancer = value; }
        }

        public eMyBoolean HistDiabetes
        {
            get { return _HistDiabetes; }
            set { _HistDiabetes = value; }
        }

        public eMyBoolean HistHeartDiseases
        {
            get { return _HistHeartDiseases; }
            set { _HistHeartDiseases = value; }
        }

        public eMyBoolean HistLungCancer
        {
            get { return _HistLungCancer; }
            set { _HistLungCancer = value; }
        }

        public eMyBoolean HistProstateCancer
        {
            get { return _HistProstateCancer; }
            set { _HistProstateCancer = value; }
        }

        public eMyBoolean HistStomachCancer
        {
            get { return _HistStomachCancer; }
            set { _HistStomachCancer = value; }
        }

        public eMyBoolean HistStroke
        {
            get { return _HistStroke; }
            set { _HistStroke = value; }
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
			_HistBreastCancer = eMyBoolean.DontKnow;
			_HistDiabetes = eMyBoolean.DontKnow;
			_HistHeartDiseases = eMyBoolean.DontKnow;
			_HistLungCancer = eMyBoolean.DontKnow;
			_HistProstateCancer  = eMyBoolean.DontKnow;
			_HistStomachCancer = eMyBoolean.DontKnow;
			_HistStroke = eMyBoolean.DontKnow;
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

    }
}
