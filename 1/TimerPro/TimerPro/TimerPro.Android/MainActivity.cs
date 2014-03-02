using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Core;
using System.Timers;

namespace TimerPro.Android
{
	[Activity (Label = "TimerPro.Android", MainLauncher = true)]
	public class MainActivity : Activity
	{
		CustomTimer MyTimerLogic = new CustomTimer ();
		Timer timer = new Timer (1000);

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
			TextView lblDisplay = FindViewById<TextView>(Resource.Id.lblDisplay);

			btnStart.Enabled = true;
			btnStop.Enabled = false;

			btnStart.Click += delegate {
				btnStart.Enabled = false;
				btnStop.Enabled = true;
				timer.Start();
			};

			btnStop.Click += delegate {
				btnStart.Enabled = true;
				btnStop.Enabled = false;
				timer.Stop();
			};

			btnReset.Click += delegate {
				MyTimerLogic.Reset();
				lblDisplay.Text = MyTimerLogic.GetCurrentTickCount();
			};

			timer.Elapsed += delegate {

				MyTimerLogic.SetTickElapsed();
				RunOnUiThread(delegate { 
					lblDisplay.Text = MyTimerLogic.GetCurrentTickCount();
				});


			};

		}
	}
}


