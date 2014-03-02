using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Core;

namespace Timer.Android
{
	[Activity (Label = "Timer.Android", MainLauncher = true)]
	public class MainActivity : Activity
	{
		System.Timers.Timer timer = new System.Timers.Timer (1000);
		CustomTimer MyTimer = new CustomTimer();

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button btnStart = FindViewById<Button> (Resource.Id.btnStart);
			Button btnStop = FindViewById<Button> (Resource.Id.btnStop);
			Button btnReset = FindViewById<Button> (Resource.Id.btnReset);
			TextView lblDisplay = FindViewById<TextView> (Resource.Id.lblDisplay);

			btnStart.Click += delegate {
				timer.Start();
				btnStart.Enabled = false;
				btnStop.Enabled = true;
			};

			btnStop.Click += delegate {
				timer.Stop();
				btnStart.Enabled = true;
				btnStop.Enabled = false;
			};

			btnReset.Click += delegate {
				RunOnUiThread (delegate {
					MyTimer.Reset();
					lblDisplay.Text = MyTimer.GetCurrentTickCount();
				});
			};

			timer.Elapsed += delegate {
				RunOnUiThread (delegate {
					MyTimer.SetTickElapsed ();
					lblDisplay.Text = MyTimer.GetCurrentTickCount ();
				});
			};
		}
	}
}


