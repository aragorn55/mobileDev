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
using DeathClock.OB;
namespace DeathClock.Droid
{
	[Activity (Label = "Physical", MainLauncher = true)]		
	public class Physical : Activity
	{
		private DateTime _userBday;
		private TextView lblDateDisplay;
		public Physical ()
		{
			_userBday = DateTime.Today;
		}
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
					// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Physical);
			EditText txtFeet = FindViewById<EditText> (Resource.Id.txtFeet);
			lblDateDisplay = FindViewById<TextView> (Resource.Id.lblDateDisplay);
			EditText txtInches = FindViewById<EditText> (Resource.Id.txtInches);
			EditText txtLbs = FindViewById<EditText> (Resource.Id.txtLbs);
			Button btnLifeStyle = FindViewById<Button> (Resource.Id.btnLifeStyle);
			Button btnChooseDate = FindViewById<Button> (Resource.Id.btnChooseDate);
			RadioButton rbMale = FindViewById<RadioButton> (Resource.Id.rbMale);
			RadioButton rbFemale = FindViewById<RadioButton> (Resource.Id.rbFemale);
			RadioGroup rbGender = FindViewById<RadioGroup> (Resource.Id.rbGender);
			ImageView imgLogo = FindViewById<ImageView> (Resource.Id.imgLogo);
			imgLogo.SetImageResource (Resource.Drawable.life);
			UpdateDisplay ();
			btnChooseDate.Click += delegate {
				DatePickerDialog setDate = new DatePickerDialog(this,OnDateSet, _userBday.Year,_userBday.Month-1,_userBday.Day);
				setDate.Show();
			};
			rbGender.CheckedChange += delegate {
				if(rbMale.Checked){
					((ControllClass)Application)._oUser.Sex = eGender.male;
				}else if (rbFemale.Checked){
					((ControllClass)Application)._oUser.Sex = eGender.female;
				}
			};
			UpdateDisplay ();
			btnLifeStyle.Click += delegate {
				double dFeet = -1;
				double dInches = -1;
				double dLbs = -1;
				if (double.TryParse(txtFeet.Text, out dFeet))
				{
					if (double.TryParse(txtInches.Text, out dInches))
					{
						if (double.TryParse(txtLbs.Text, out dLbs)){
							((ControllClass)Application)._oUser.BirthDate = _userBday;
							((ControllClass)Application)._oUser.Height = (12.0 * dFeet) + dInches;
							((ControllClass)Application)._oUser.Weight = dLbs;
								if(rbMale.Checked){
									((ControllClass)Application)._oUser.Sex = eGender.male;
								}else if (rbFemale.Checked){
									((ControllClass)Application)._oUser.Sex = eGender.female;
								}

								StartActivity(typeof(LifeStyle));
							}
						}
					}
				if ((dFeet  < 0)||(dInches  < 0)||(dLbs  < 0))
				{
					var builder = new AlertDialog.Builder(this);
					builder.SetTitle("Error");
					builder.SetMessage("please enter a number of 0 or more for the height in inches and feet and weight in lbs.");
					var dialog = builder.Create();
					dialog.Show();	}
			};					
		}
		public void OnDateSet(object sender, DatePickerDialog.DateSetEventArgs e)
		{
			this._userBday = e.Date;
			//lblDateDisplay.Text = _UserBday.ToString ("d");
			UpdateDisplay ();
		}
		private void UpdateDisplay ()
		{
			lblDateDisplay.Text = _userBday.ToString ("d");
		}
	}
}

