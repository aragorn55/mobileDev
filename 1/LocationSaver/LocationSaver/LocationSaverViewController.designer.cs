// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace LocationSaver
{
	[Register ("LocationSaverViewController")]
	partial class LocationSaverViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnClear { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnSave { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITableView tvList { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (tvList != null) {
				tvList.Dispose ();
				tvList = null;
			}

			if (btnSave != null) {
				btnSave.Dispose ();
				btnSave = null;
			}

			if (btnClear != null) {
				btnClear.Dispose ();
				btnClear = null;
			}
		}
	}
}
