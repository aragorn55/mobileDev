using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections.Generic;
using Xamarin.Geolocation;
using System.Threading.Tasks;
using  SQLite;

namespace LocationSaver
{
	public partial class LocationSaverViewController : UIViewController
	{
		List<string> MyLocations = new List<string>();

		public LocationSaverViewController () : base ("LocationSaverViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();

			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			//Connected to Database
			string folder = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
			var conn = new SQLiteConnection (System.IO.Path.Combine (folder, "locations.db"));
			conn.CreateTable<Location>();

			//Fill Collection with data from sqlite
			var query = conn.Table<Location>();
			foreach (var item in query) {
				MyLocations.Add ("Latitude:" + item.Latitude);
				MyLocations.Add ("Longitude:" + item.Longitude);
			}

			tvList.DataSource = new LocationDS (MyLocations);

			// Perform any additional setup after loading the view, typically from a nib.
			btnSave.TouchUpInside += delegate {
				var locator = new Geolocator { DesiredAccuracy = 50 };
				locator.GetPositionAsync (timeout: 10000).ContinueWith (t => {

					//Insert data into Database
					var CurrentLocation = new Location();
					CurrentLocation.Latitude = t.Result.Latitude.ToString();
					CurrentLocation.Longitude = t.Result.Longitude.ToString();
					conn.Insert(CurrentLocation);

					//Update TableView
					MyLocations.Add("Latitude:" +  t.Result.Latitude.ToString());
					MyLocations.Add("Longitude:" + t.Result.Longitude.ToString());
					tvList.ReloadData();

				}, TaskScheduler.FromCurrentSynchronizationContext());
			};

			btnClear.TouchUpInside += delegate {
				conn.Execute("delete from Location");
				MyLocations.Clear();
				tvList.ReloadData();
			};
		}

		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}
	}
}

