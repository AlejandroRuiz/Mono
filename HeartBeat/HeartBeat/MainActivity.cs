using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Animation;
using Android.Views.Animations;
using System.Collections.Generic;

namespace HeartBeat
{
	[Activity (Label = "HeartBeat", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			// Set our view from the "main" layout resource
			//SetContentView (Resource.Layout.Main);
			ImageView img = new ImageView (this);
			//set heart image to imageview
			img.SetImageResource (Resource.Drawable.Heart);
			//Set the imageview as a content view
			SetContentView (img);

			//Create an action
			Action act = new Action (() => {
				//Create an instance of our custom interpolator
				customInterpolator i = new customInterpolator ();
				//Create an Scale Animation(fromX,toX,fromY,toY,pivotX,pivotY)
				ScaleAnimation anim = new ScaleAnimation (1, 1.2f, 1, 1.2f, img.Width / 2, img.Height / 2);
				//Set repeat count to infinite
				anim.RepeatCount = Animation.Infinite;
				//Set the animation duration
				anim.Duration = 750;
				//Set the animation custom interpolator
				anim.Interpolator = i;
				//Attach our Custom Scale Animation to the imageview
				img.StartAnimation (anim);
			});
			//Post the action to the imageview
			img.Post (act);
		}
	}

	public class customInterpolator:Java.Lang.Object, IInterpolator
	{
		public float GetInterpolation (float input)
		{
			float x = input < 1/3f? 2 * input : (1 + input) / 2;
			return (float) Math.Sin(x * Math.PI);
		}
	}
}


