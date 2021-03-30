using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using System;
using System.Runtime.CompilerServices;

namespace HelloAndroid
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var button = FindViewById(Resource.Id.button1);

            button.Click += OnButtonClicked;
        }

        int count = 0;

        private void OnButtonClicked(object sender, EventArgs e)
        {
            count++;
            ((Button)sender).Text = $"Clicked {count} times";
        }
    }
}