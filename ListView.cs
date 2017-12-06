using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;



namespace App5
{
    [Activity(Label = "Visited Places")]
    public class myListView : Activity
    {
        List<TableItem> tableItems = new List<TableItem>();
        ListView listView;



        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.BlogAuthorDescription);

            listView = FindViewById<ListView>(Resource.Id.countryList);

            tableItems.Add(new TableItem() { Heading = "ROME", ImageResourceId = Resource.Drawable.Flag_of_Tokyo_Prefecture.svg.png });
            tableItems.Add(new TableItem() { Heading = "PORTO", ImageResourceId = Resource.Drawable.pt - prt.gif });
            tableItems.Add(new TableItem() { Heading = "LADAKH", ImageResourceId = Resource.Drawable.ladak.gif });
            tableItems.Add(new TableItem() { Heading = "TOKYO",ImageResourceId = Resource.Drawable.Flag_of_Tokyo_Prefecture.svg.png });
            tableItems.Add(new TableItem() { Heading = "FLORENCE", ImageResourceId = Resource.Drawable.Flag_of_Florence.svg.png });

            listView.Adapter = new HomeScreenAdapter(this, tableItems);

        listView.ItemClick += OnListItemClick;
        }

    protected void OnListItemClick(object sender, Android.Widget.AdapterView.ItemClickEventArgs e)
    {
        var listView = sender as ListView;
        var t = tableItems[e.Position];

    }
}
}
