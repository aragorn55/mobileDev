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

namespace StringDemo
{
	[Activity (Label = "DisplayName")]			
	public class DisplayName : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.DisplayName);

			TextView lblDisplay = FindViewById<TextView> (Resource.Id.lblDisplay);

			lblDisplay.Text = Intent.GetStringExtra ("FullName") + "~" + Intent.GetStringExtra ("MoreStuff");
		
		}
	}
}

