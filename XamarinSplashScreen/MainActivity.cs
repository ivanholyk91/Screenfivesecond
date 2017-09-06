using Android.App;
using Android.Widget; 
using Android.OS;
using Android.Support.V7.App;
using GR.Net.Maroulis.Library;
using System.Drawing;
using Android.Views;


namespace XamarinSplashScreen
{
    [Activity(Label = "XamarinSplashScreen", MainLauncher = true, Theme ="@style/Theme.AppCompat.Light.NoActionBar")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Show Splash Screen
            var config = new EasySplashScreen(this)
                .WithFullScreen()
                .WithTargetActivity(Java.Lang.Class.FromType(typeof(TargetActivity)))
                .WithSplashTimeOut(5000) // 5 sec
                .WithLogo(Resource.Drawable.logo)
                .WithHeaderText("Welcome Guest!!!")
                .WithFooterText("Copyright 2017")
                .WithBeforeLogoText("EDMT Dev Co,Ltd")
                .WithAfterLogoText("This is easy Splesh Screen");


            //Set text Color
           

            //Create View

            View view = config.Create();

            //Set Content View
            SetContentView(view);





        }
    }
}

