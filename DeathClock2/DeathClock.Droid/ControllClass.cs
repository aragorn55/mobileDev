using System;
using Android.App;
using Android.Runtime;
using DeathClock.OB;
namespace DeathClock.Droid
{
	[Application]
	public class ControllClass : Android.App.Application
	{
		public cPerson _oUser;
		public ControllClass (System.IntPtr handle, JniHandleOwnership transfer) : base(handle,transfer)
		{
		}
		public override void OnCreate ()
		{
			base.OnCreate ();
			_oUser = new cPerson ();
		}
	}
}

