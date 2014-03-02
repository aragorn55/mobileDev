using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace SimpleNavigation
{
	[Activity (Label = "SimpleNavigation", MainLauncher = true)]
	public class MainActivity : Activity
	{
		//int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button btnLoadView = FindViewById<Button> (Resource.Id.btnLoadView);
			
			btnLoadView.Click += delegate {
				StartActivity(typeof(Second));


			};
		}
	}
}


