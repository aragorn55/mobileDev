// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace Demo5
{
	[Register ("Demo5ViewController")]
	partial class Demo5ViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIScrollView MyScrollView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (MyScrollView != null) {
				MyScrollView.Dispose ();
				MyScrollView = null;
			}
		}
	}
}
