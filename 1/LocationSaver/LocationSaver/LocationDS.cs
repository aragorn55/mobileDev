using System;
using MonoTouch.UIKit;
using System.Collections.Generic;

namespace LocationSaver
{
	public class LocationDS:UITableViewDataSource
	{
		List<string> _MyLocations;

		public LocationDS (List<string> Locations)
		{
			_MyLocations = Locations;
		}

		public override int RowsInSection (UITableView tableView, int section)
		{
			return _MyLocations.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell ("MyCell");

			if(cell == null){
				cell = new UITableViewCell (UITableViewCellStyle.Default, "MyCell");
			}

			cell.TextLabel.Text = _MyLocations [indexPath.Row];
			return cell;
		}

	}
}

