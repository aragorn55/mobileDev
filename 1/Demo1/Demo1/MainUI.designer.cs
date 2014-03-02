// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace Demo1
{
	[Register ("MainUI")]
	partial class MainUI
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnAdd { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnClear { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblDisplay { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField txtOperA { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField txtOperB { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (txtOperA != null) {
				txtOperA.Dispose ();
				txtOperA = null;
			}

			if (txtOperB != null) {
				txtOperB.Dispose ();
				txtOperB = null;
			}

			if (lblDisplay != null) {
				lblDisplay.Dispose ();
				lblDisplay = null;
			}

			if (btnAdd != null) {
				btnAdd.Dispose ();
				btnAdd = null;
			}

			if (btnClear != null) {
				btnClear.Dispose ();
				btnClear = null;
			}
		}
	}
}
