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
    [Activity(Label = "FUTURE DESTINATIONS")]
    public class myListView2 : Activity
    {

        static readonly string[] countries = new String[] {
            "DUBAI","GREECE","SWITZERLAND","AUSTRALIA","EGYPT"
            };
        ListView lstCountryList;
        ArrayAdapter<string> countryDataAdapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            
            SetContentView(Resource.Layout.myListView);

            lstCountryList = FindViewById(Resource.Id.countryList) as ListView;

            countryDataAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, countries);
            lstCountryList.Adapter = countryDataAdapter;


            lstCountryList.ItemClick += listView_ItemClick;
        }

        void listView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            
            var item = this.countryDataAdapter.GetItem(e.Position);

            
            Toast.MakeText(this, item + " Clicked!", ToastLength.Short).Show();
        }

    }
}
