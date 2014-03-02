// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace NavData
{
	[Register ("Form")]
	partial class Form
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnSave { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField txtAge { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField txtName { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (txtName != null) {
				txtName.Dispose ();
				txtName = null;
			}

			if (txtAge != null) {
				txtAge.Dispose ();
				txtAge = null;
			}

			if (btnSave != null) {
				btnSave.Dispose ();
				btnSave = null;
			}
		}
	}
}
