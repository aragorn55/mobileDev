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
	[Register ("Report")]
	partial class Report
	{
		[Outlet]
		MonoTouch.UIKit.UILabel lblAge { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblName { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (lblAge != null) {
				lblAge.Dispose ();
				lblAge = null;
			}

			if (lblName != null) {
				lblName.Dispose ();
				lblName = null;
			}
		}
	}
}
