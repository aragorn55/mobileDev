// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace demo6
{
	[Register ("MainUI")]
	partial class MainUI
	{
		[Outlet]
		MonoTouch.UIKit.UIImageView imgLogo { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblOutput { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIScrollView myScrollView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UISegmentedControl segOptions { get; set; }

		[Outlet]
		MonoTouch.UIKit.UISwitch swOn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextView txtArea { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField txtInput { get; set; }

		[Action ("btnSave:")]
		partial void btnSave (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (myScrollView != null) {
				myScrollView.Dispose ();
				myScrollView = null;
			}

			if (txtInput != null) {
				txtInput.Dispose ();
				txtInput = null;
			}

			if (segOptions != null) {
				segOptions.Dispose ();
				segOptions = null;
			}

			if (imgLogo != null) {
				imgLogo.Dispose ();
				imgLogo = null;
			}

			if (swOn != null) {
				swOn.Dispose ();
				swOn = null;
			}

			if (lblOutput != null) {
				lblOutput.Dispose ();
				lblOutput = null;
			}

			if (txtArea != null) {
				txtArea.Dispose ();
				txtArea = null;
			}
		}
	}
}
