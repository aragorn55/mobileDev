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

namespace SimpleNavigation
{
	[Activity (Label = "Second")]			
	public class Second : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Main);
			// Create your application here
			//btnSecondView
			Button btnSecondView = FindViewById<Button> (Resource.Id.btnSecondView);

			btnSecondView.Click += delegate {
				StartActivity(typeof(Second));

			};
		}
	}
}

