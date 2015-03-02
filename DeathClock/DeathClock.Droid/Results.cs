using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DeathClock.OB;
namespace DeathClock.Droid
{
	[Activity (Label = "Results")]			
	public class Results : Activity
	{
		cDeathCalculator oCalc;
		DateTime DeathDate;
		public Results ()
		{

			oCalc = new cDeathCalculator ();
		}
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Results);
			TextView lblYears = FindViewById<TextView> (Resource.Id.lblYears);
			DeathDate = oCalc.DayYouDie (((ControllClass)Application)._oUser);
			//lblYears.Text = oCalc.FindTimeLeft (((ControllClass)Application)._oUser).ToString ();
			lblYears.Text = CreateOutput ();
			ImageView imgLogo = FindViewById<ImageView> (Resource.Id.imgLogo);
			imgLogo.SetImageResource (Resource.Drawable.clock);
			//			imgLogo.Image = UIImage.FromBundle ("Images/clock.png");
			// Create your application here
		}
		private string CreateOutput()
		{

			//string format = "MMM ddd d";
			string sOutput = "You will Die  : " + string.Format("{0:D}", DeathDate);
			//string sOutput = "You will Die  : " + DeathDate.ToString (format);
			//sOutput = sOutput + " Years " + _months.ToString() + " Months and " + _days.ToString() + " Days"; 
			return sOutput;
		}
	}
}

