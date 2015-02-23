using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace DatePicker
{
	[Activity (Label = "DatePicker", MainLauncher = true)]
	public class MainActivity : Activity
	{
		private DateTime date;
		private TextView lblDisplay;

		void SetDisplayDate()
		{
			lblDisplay.Text = date.ToString ("d");
		}

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button btnChooseDate = FindViewById<Button> (Resource.Id.btnChooseDate);
			lblDisplay = FindViewById<TextView> (Resource.Id.lblDisplay);
			date = DateTime.Today;
			btnChooseDate.Click += delegate {
				DatePickerDialog setDate = new DatePickerDialog(this, onDateSet, date.Year, date.Month-1,date.Day);
				setDate.Show();
			};
			SetDisplayDate ();
		}
		void onDateSet(object sender, DatePickerDialog.DateSetEventArgs e)
		{
			SetDisplayDate ();
			date = e.Date;
		}
	}
}


