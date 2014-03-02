using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ObjectDemo
{
	[Activity (Label = "ObjectDemo", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button btnSave = FindViewById<Button> (Resource.Id.btnSave);
			EditText txtName = FindViewById<EditText> (Resource.Id.txtName);
			
			btnSave.Click += delegate {
				((MyApp)Application).UserDetails.FirstName = txtName.Text;
				StartActivity(typeof(DisplayActivity));
			};
		}
	}
}


