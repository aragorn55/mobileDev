using System;
using Android.App;
using Android.Runtime;


namespace ObjectDemo
{
	[Application]
	public class MyApp : Android.App.Application
	{
		public person UserDetails;

		public MyApp (System.IntPtr handle, JniHandleOwnership transfer) : base(handle,transfer)
		{
		}

		public override void OnCreate ()
		{
			base.OnCreate ();
			UserDetails = new person ();
		}
	}
}

