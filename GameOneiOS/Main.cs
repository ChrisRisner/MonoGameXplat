using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using GameOneSharedProject;

namespace GameOneiOS
{
//	public class Application
//	{
//		// This is the main entry point of the application.
//		static void Main (string[] args)
//		{
//			// if you want to use a different Application Delegate class from "AppDelegate"
//			// you can specify it here.
//			UIApplication.Main (args, null, "AppDelegate");
//		}
//	}

	[Register ("AppDelegate")]
	class Program : UIApplicationDelegate
	{
		Game1 game;

		public override void FinishedLaunching (UIApplication app)
		{
			// Fun begins..
			game = new Game1 ();
			game.Run ();

		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main (string[] args)
		{
			UIApplication.Main (args, null, "AppDelegate");
		}


	}
}
