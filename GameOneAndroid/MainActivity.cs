using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
//using Microsoft.Xna.Framework;
using Android.Util;
//using GameOneSharedProject;
//using Xamarin;
using GameOneSharedProject;
using Microsoft.Xna.Framework;

namespace GameOneAndroid
{
	[Activity (Label = "GameOneAndroid", 
		MainLauncher = true, 
		Icon = "@drawable/icon",
		AlwaysRetainTaskState = true,
		LaunchMode = Android.Content.PM.LaunchMode.SingleInstance,
		ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation |
		Android.Content.PM.ConfigChanges.KeyboardHidden |
		Android.Content.PM.ConfigChanges.Keyboard)]
	public class MainActivity : AndroidGameActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			//base.OnCreate (bundle);

			// Create our OpenGL view, and display it
			//Game1.Activity = this;
//			var g = new Game1 ();
//			//g.setPlatfromSpecific (new MacSpecific ());
//			//gameC.setAnalytics (new Analytics ());
//			SetContentView (g.Window);
//			g.Run ();

			base.OnCreate(bundle);

			var g = new Game1();
			SetContentView((View)g.Services.GetService(typeof(View)));
			g.Run();

		}
	}
}


