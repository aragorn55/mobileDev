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
		//cPerson _User;
		cDeathCalculator oCalc;
		public Results ()
		{
			//_User = ((ControllClass)Application)._oUser;
			oCalc = new cDeathCalculator ();

		}
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Results);
			TextView lblYears = FindViewById<TextView> (Resource.Id.lblYears);
			lblYears.Text = oCalc.FindTimeLeft (((ControllClass)Application)._oUser).ToString ();
			//lblYears.Text = oCalc.FindTimeLeft (_User).ToString ();
			//			imgLogo.Image = UIImage.FromBundle ("Images/clock.png");
			// Create your application here
		}
	}
}

