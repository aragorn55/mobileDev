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
	[Activity (Label = "LifeStyle")]	
	public class LifeStyle : Activity
	{
		public LifeStyle()
		{
		}
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.LifeStyle);
			EditText txtSleep = FindViewById<EditText> (Resource.Id.txtSleep);
			EditText txtCigarettes = FindViewById<EditText> (Resource.Id.txtCigarettes);
			ImageView imgLogo = FindViewById<ImageView> (Resource.Id.imgLogo);
			Button btnCalculate = FindViewById<Button> (Resource.Id.btnCalculate);
			imgLogo.SetImageResource (Resource.Drawable.life);
			btnCalculate.Click += delegate {
				double dSleep = -1;
				double dCigarettes = -1;
				if (double.TryParse (txtSleep.Text, out dSleep)) {
					if (double.TryParse (txtCigarettes.Text, out dCigarettes)) {
						((ControllClass)Application)._oUser.HrsSleep = dSleep;
						((ControllClass)Application)._oUser.CigPerDay = dCigarettes;
						StartActivity(typeof(Results));					}
				}
			if ((dSleep == -1)||(dCigarettes == -1))
			{
					var builder = new AlertDialog.Builder(this);
					builder.SetTitle("Error");
					builder.SetMessage("please enter a number of 0 or more for both number of Cigarettes and hours of sleep");
					var dialog = builder.Create();
					dialog.Show();
						}
			};
		}
		}
	}


