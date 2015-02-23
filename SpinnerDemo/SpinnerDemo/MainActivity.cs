using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
namespace SpinnerDemo
{
	[Activity (Label = "SpinnerDemo", MainLauncher = true)]
	public class MainActivity : Activity
	{
		List<string> lstUserNames = new List<string> ();

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			lstUserNames.Add ("Bob");
			lstUserNames.Add ("Mike");
			lstUserNames.Add ("Rick");
			lstUserNames.Add ("Stu");
			lstUserNames.Add ("Jim");

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Spinner spnUser = FindViewById<Spinner> (Resource.Id.spnUser);
			TextView lblCurrentUser =  FindViewById<TextView> (Resource.Id.lblCurrentUser);
			ArrayAdapter adapter = new ArrayAdapter (this, Android.Resource.Layout.SimpleSpinnerItem, lstUserNames);
			spnUser.Adapter = adapter;
			spnUser.ItemSelected += delegate {
				lblCurrentUser.Text = spnUser.SelectedItem.ToString();
			};
			//Button button = FindViewById<Button> (Resource.Id.myButton);
			
		//	button.Click += delegate {
		//		button.Text = string.Format ("{0} clicks!", count++);
		//	};
		}
	}
}


