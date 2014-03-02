// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace Demo3
{
	[Register ("ThirdViewController")]
	partial class ThirdViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnGo { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblDisplay { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (lblDisplay != null) {
				lblDisplay.Dispose ();
				lblDisplay = null;
			}

			if (btnGo != null) {
				btnGo.Dispose ();
				btnGo = null;
			}
		}
	}
}
