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
	[Register ("Total")]
	partial class Total
	{
		[Outlet]
		MonoTouch.UIKit.UILabel lblTotal { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (lblTotal != null) {
				lblTotal.Dispose ();
				lblTotal = null;
			}
		}
	}
}
