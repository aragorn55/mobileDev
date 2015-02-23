using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MortalityCalculatorIOS.OB;
namespace MortalityCalculatorIOS.UI
{
	public class Application
	{
		// This is the main entry point of the application.
		static void Main (string[] args)
		{
			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			UIApplication.Main (args, null, "AppDelegate");
			cPerson oUser;
			oUser = new cPerson ();
			cDeathCalculator dCalc;
			dCalc = new cDeathCalculator ();
			oUser.Age = 28;
			oUser.CigPerDay = 0;
			dCalc.FindTimeLeft (oUser);

		}
	}
}
