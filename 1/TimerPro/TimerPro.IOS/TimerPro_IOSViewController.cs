using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Core;

namespace TimerPro.IOS
{
	public partial class TimerPro_IOSViewController : UIViewController
	{
		NSTimer timer;
		CustomTimer MyTimerLogic = new CustomTimer ();
		public TimerPro_IOSViewController () : base ("TimerPro_IOSViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		public void timer_tick(){
		
		//do stuff
			MyTimerLogic.SetTickElapsed ();
			lblDisplay.Text = MyTimerLogic.GetCurrentTickCount ();
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			btnStart.Enabled = true;
			btnStop.Enabled = false;
			//btnReset.Enabled = true;

		btnStart.TouchUpInside += delegate {
				btnStart.Enabled = false;
				btnStop.Enabled = true;
				timer = NSTimer.CreateRepeatingScheduledTimer(TimeSpan.FromSeconds(1),timer_tick);
			};

			btnStop.TouchUpInside += delegate {
				btnStart.Enabled = true;
				btnStop.Enabled = false;
				timer.Invalidate();
			};

			btnReset.TouchUpInside += delegate {
				MyTimerLogic.Rest();
				lblDisplay.Text = MyTimerLogic.GetCurrentTickCount();
				btnStart.Enabled = true;
				btnStop.Enabled = false;

			};
		}


		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}
	}
}

