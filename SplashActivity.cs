
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App5

{
    [Activity(Label = "App5", MainLauncher = true)]
    public class splashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            
            SetContentView(Resource.Layout.SplashActivity);
        }

        protected override void OnResume()
        {
            base.OnResume();
            Task startupWork = new Task(() => { SimulateStartup(); });
            startupWork.Start();
        }

        
        async void SimulateStartup()
        {
            await Task.Delay(7000); 
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }

    }
}

