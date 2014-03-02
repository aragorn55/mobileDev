// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace Timer.IOS
{
	[Register ("MainUI")]
	partial class MainUI
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnReset { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnStart { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnStop { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblDisplay { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (lblDisplay != null) {
				lblDisplay.Dispose ();
				lblDisplay = null;
			}

			if (btnStart != null) {
				btnStart.Dispose ();
				btnStart = null;
			}

			if (btnStop != null) {
				btnStop.Dispose ();
				btnStop = null;
			}

			if (btnReset != null) {
				btnReset.Dispose ();
				btnReset = null;
			}
		}
	}
}
