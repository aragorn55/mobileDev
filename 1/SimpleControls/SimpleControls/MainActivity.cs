using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace SimpleControls
{
	[Activity (Label = "SimpleControls", MainLauncher = true)]
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
			EditText txtInput = FindViewById<EditText> (Resource.Id.txtInput);
			ToggleButton swControl = FindViewById<ToggleButton> (Resource.Id.swControl);
			RadioButton rbOne = FindViewById<RadioButton> (Resource.Id.rbOne);
			RadioButton rbTwo = FindViewById<RadioButton> (Resource.Id.rbTwo);
			TextView lblDisplay = FindViewById<TextView> (Resource.Id.lblDisplay);
			RadioGroup rbGroup = FindViewById<RadioGroup> (Resource.Id.rbGroup);

			//Button
			btnSave.Click += delegate {
				lblDisplay.Text = txtInput.Text;
			};

			//Toggle
			swControl.Click += delegate {
				if(swControl.Checked){
					lblDisplay.Text = "On";
				}else{
					lblDisplay.Text = "Off";
				}
			};

			rbGroup.CheckedChange += delegate {
				if(rbOne.Checked){
					lblDisplay.Text = "One";
				}else if (rbTwo.Checked){
					lblDisplay.Text = "Two";
				}
			};


		}
	}
}


