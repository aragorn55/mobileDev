using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace demo6
{
	public partial class MainUI : UIViewController
	{
		public MainUI () : base ("MainUI", null)
		{
			Title = "My Controlls";
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		partial void btnSave (NSObject sender)
		{
			lblOutput.Text = txtInput.Text;
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			myScrollView.Frame = new RectangleF (0, 20, 320, 460);
			myScrollView.ContentSize = new SizeF (320, 570);

			UIBarButtonItem btnCloseKeyboard = new UIBarButtonItem ("Hide Keyboard", UIBarButtonItemStyle.Plain, null);
			NavigationItem.SetRightBarButtonItem (btnCloseKeyboard, true);

			imgLogo.Image = UIImage.FromBundle ("Images/apple.jpg");

			swOn.ValueChanged += delegate {
				if(swOn.On){
					lblOutput.Text = "On";
				}else{
					lblOutput.Text = "Off";
				}
			};

			segOptions.ValueChanged += delegate {
				switch(segOptions.SelectedSegment){
					case 0:
						lblOutput.Text = "First";
						break;
					case 1:
						lblOutput.Text = "Second";
						break;
					case 2:
						lblOutput.Text = "Third";
						break;
				};
			};

			btnCloseKeyboard.Clicked += delegate {
				txtInput.ResignFirstResponder();
				txtArea.ResignFirstResponder();
			};

			txtArea.Started += delegate {
				RectangleF MyFrame = myScrollView.Frame;
				MyFrame.Y = -240;
				myScrollView.Frame = MyFrame;
			};

			txtArea.Ended += delegate {
				RectangleF MyFrame = myScrollView.Frame;
				MyFrame.Y = 0;
				myScrollView.Frame = MyFrame;
			};
		}
	}
}

