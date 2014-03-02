using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace StringDemo
{
	[Activity (Label = "StringDemo", MainLauncher = true)]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button btnSave = FindViewById<Button> (Resource.Id.btnSave);
			EditText txtFullName = FindViewById<EditText> (Resource.Id.txtFullName);
			
			btnSave.Click += delegate {

				DisplayName MyName = new DisplayName();

				Intent MyData = new Intent(this, MyName.Class);
				MyData.PutExtra("FullName", txtFullName.Text);
				MyData.PutExtra("MoreStuff","This is Cool!!!");

				StartActivity(MyData);

			};
		}
	}
}


