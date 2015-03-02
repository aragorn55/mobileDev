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
		//cPerson _User;
//		public LifeStyle()
//		{
//			//_User = ((ControllClass)Application)._oUser;
//
//		}
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.LifeStyle);
			//Button btnCalculate = FindViewById<Button> (Resource.Id.);
			EditText txtSleep = FindViewById<EditText> (Resource.Id.txtSleep);
			EditText txtCigarettes = FindViewById<EditText> (Resource.Id.txtCigarettes);
			Button btnCalculate = FindViewById<Button> (Resource.Id.btnCalculate);
			btnCalculate.Click += delegate {
				double dSleep = -1;
				double dCigarettes = -1;
				if (double.TryParse (txtSleep.Text, out dSleep)) {
					if (double.TryParse (txtCigarettes.Text, out dCigarettes)) {
						((ControllClass)Application)._oUser.HrsSleep = dSleep;
						((ControllClass)Application)._oUser.CigPerDay = dCigarettes;
						//_User.HrsSleep = dSleep;
						//_User.CigPerDay = dCigarettes;
						//((ControllClass)Application)._oUser = _User;
						StartActivity(typeof(Results));
						//NavigationController.PushViewController(_cResultsVC,true);
					}
				}
//				if ((dSleep == -1)||(dCigarettes == -1))
//				{
//					//	UIAlertView alert = new  UIAlertView("Error", "Please input a number into all fields", "OK", null);
//					//	alert.Show(); 
//				}
			
			};

		//txtSleep.ShouldReturn = delegate {
		//	txtSleep.ResignFirstResponder();
		//	return true;
		//	};
//		txtCigarettes.ShouldReturn = delegate {
//			txtCigarettes.ResignFirstResponder();
//			return true;
//		};
		
		}


				

			




		}

	}


