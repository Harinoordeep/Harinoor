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

namespace App5
{
    [Activity(Label = "contact")]
    public class contact : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            
            SetContentView(Resource.Layout.contact);



            
            Button btnCall = FindViewById<Button>(Resource.Id.btnCall);

            btnCall.Click += delegate {
                
                var uri2 = Android.Net.Uri.Parse("tel:1800-200-6065");
                var callIntent = new Intent(Intent.ActionCall, uri2);
                StartActivity(callIntent);
            };

            Button btnSMS = FindViewById<Button>(Resource.Id.btnSMS);

            btnSMS.Click += delegate {

                var smsContent = FindViewById<EditText>(Resource.Id.txtSMS).Text;

                var smsUri = Android.Net.Uri.Parse("smsto:1800-200-6065");
                var smsIntent = new Intent(Intent.ActionSendto, smsUri);
                smsIntent.PutExtra("sms_body", smsContent);
                StartActivity(smsIntent);
            };

            Button btnEmail = FindViewById<Button>(Resource.Id.btnEmail);

            btnEmail.Click += delegate {

                var email = new Intent(Android.Content.Intent.ActionSend);
                email.PutExtra(Android.Content.Intent.ExtraEmail,
                               new string[] { "harinoordeep@gmail.com"});

                email.PutExtra(Android.Content.Intent.ExtraCc, new string[] { "harinoordeep@gmail.com" });

                email.PutExtra(Android.Content.Intent.ExtraSubject, "Email");

                email.PutExtra(Android.Content.Intent.ExtraText, "");

                email.SetType("message/App5");
                StartActivity(email);
            };

        }
    }
}
