using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Core;

namespace Timer.IOS
{
	public partial class MainUI : UIViewController
	{
		NSTimer timer;
		CustomTimer MyTimer = new CustomTimer();

		public MainUI () : base ("MainUI", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			btnStart.TouchUpInside+= delegate {
				timer = NSTimer.CreateRepeatingScheduledTimer(TimeSpan.FromSeconds(1),timer_tick);
				btnStart.Enabled = false;
				btnStop.Enabled = true;
			};

			btnStop.TouchUpInside+= delegate {
				timer.Invalidate();
				btnStart.Enabled = true;
				btnStop.Enabled = false;
			};

			btnReset.TouchUpInside+= delegate {
				MyTimer.Reset();
				lblDisplay.Text = MyTimer.GetCurrentTickCount();
			};
		}

		public void timer_tick(){
			MyTimer.SetTickElapsed();
			lblDisplay.Text = MyTimer.GetCurrentTickCount();
		}
	}
}

