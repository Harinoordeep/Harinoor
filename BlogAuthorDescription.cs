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
    [Activity(Label = "BlogAuthorDescription")]
    public class BlogAuthorDescription : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.BlogAuthorDescription);

           
            Button showPopupMenu = FindViewById<Button>(Resource.Id.button1);

            showPopupMenu.Click += delegate {
                //Toast.MakeText(this, "hello", ToastLength.Long).Show();

                PopupMenu menu = new PopupMenu(this, showPopupMenu);
                menu.Inflate(Resource.Menu.popup_menu);

                menu.MenuItemClick += (s1, e1) =>
                {




                    switch (e1.Item.TitleFormatted.ToString())
                    {
                        case "Visited Places":
                            StartActivity(typeof(myListView));
                            break;
                        case "Future Destinations":
                            StartActivity(typeof(myListView2));
                            break;
                        case "Contact":
                            StartActivity(typeof(contact));
                            break;
                    }
                };
                menu.Show();


            };
        }
    }
}

