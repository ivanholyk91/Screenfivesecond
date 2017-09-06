using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V7.App;

namespace XamarinSplashScreen
{
    [Activity(Label = "TargetActivity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class TargetActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Target);
        }
    }
}