// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace DateNight
{
	[Register ("Shopping")]
	partial class Shopping
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnSave { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView imgLogo { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField txtShopping { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (imgLogo != null) {
				imgLogo.Dispose ();
				imgLogo = null;
			}

			if (txtShopping != null) {
				txtShopping.Dispose ();
				txtShopping = null;
			}

			if (btnSave != null) {
				btnSave.Dispose ();
				btnSave = null;
			}
		}
	}
}
