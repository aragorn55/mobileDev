using System;
using System.Drawing;

using DeathClock.OB;

namespace DeathClock.Droid
{
	public partial class cLifeStyleVC
	{
		//txtSleep
		//imgLifestyle
		//btnCalculate
		//_txtCigarettes
		//
		//
		cPerson _User;
		cResultsVC _cResultsVC;

		public cLifeStyleVC (cPerson voUser) : base ("cLifeStyleVC", null)
		{
			_User = voUser;
			//imgLifestyle.Image = UIImage.FromBundle ("Images/life.png");
			//imgLogo.Image = UIImage.FromBundle ("Images/apple.jpg");
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			//base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			//UIBarButtonItem btnPhysical = new UIBarButtonItem ("Physical Atributes", UIBarButtonItemStyle.Plain, null);
			//NavigationItem.SetRightBarButtonItem (btnPhysical, true);
			//base.ViewDidLoad ();
			//imgLifestyle.Image = UIImage.FromBundle ("Images/life.png");
			//txtSleep.Text = "8";
			//txtCigarettes.Text = "0";
			protected override void OnCreate (Bundle bundle)
			{
				base.OnCreate (bundle);

				// Set our view from the "main" layout resource
				SetContentView (Resource.Layout.Main);

				// Get our button from the layout resource,
				// and attach an event to it
				Button btnCalculate = FindViewById<Button> (Resource.Id.btnCalculate);
				textedit button = FindViewById<Button> (Resource.Id.myButton);
				Button button = FindViewById<Button> (Resource.Id.myButton);
				btnCalculate.Click += delegate {
					double dSleep = -1;
					double dCigarettes = -1;


					if (double.TryParse (txtSleep.Text, out dSleep)) {

						if (double.TryParse (txtCigarettes.Text, out dCigarettes)) {

							_User.HrsSleep = dSleep;
							_User.CigPerDay = dCigarettes;


							_cResultsVC = new cResultsVC (_User);
							//NavigationController.PushViewController(_cResultsVC,true);

						}
					}
					if ((dSleep == -1)||(dCigarettes == -1))
					{
						//	UIAlertView alert = new  UIAlertView("Error", "Please input a number into all fields", "OK", null);
						//	alert.Show(); 
					}
				};
			}
			txtSleep.ShouldReturn = delegate {
				txtSleep.ResignFirstResponder();
				return true;
			};
			txtCigarettes.ShouldReturn = delegate {
				txtCigarettes.ResignFirstResponder();
				return true;
			};
			btnCalculate.TouchUpInside += delegate {
				

				

				double dSleep = -1;
				double dCigarettes = -1;


				if (double.TryParse (txtSleep.Text, out dSleep)) {

					if (double.TryParse (txtCigarettes.Text, out dCigarettes)) {
						
						_User.HrsSleep = dSleep;
						_User.CigPerDay = dCigarettes;
						

						_cResultsVC = new cResultsVC (_User);
						//NavigationController.PushViewController(_cResultsVC,true);

					}
				}
				if ((dSleep == -1)||(dCigarettes == -1))
				{
					//	UIAlertView alert = new  UIAlertView("Error", "Please input a number into all fields", "OK", null);
					//	alert.Show(); 
				}
			};



			}
			// Perform any additional setup after loading the view, typically from a nib.
		}
	}


