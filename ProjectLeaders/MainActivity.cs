using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Views;

namespace ProjectLeaders
{
    [Activity(Label = "ProjectLeaders", MainLauncher = true, Icon = "@drawable/icon")]
    public partial class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            ListView listview = FindViewById<ListView>(Resource.Id.listViewPrograms);
            List<Programs> ListItems = new List<Programs>();
            ListItems.Add(new Programs("Visit Jerusalem", Resource.Drawable.earthpictures));
            ListItems.Add(new Programs("Visit Ramallah", Resource.Drawable.earthpictures));
            ListItems.Add(new Programs("Visit Bethlehem", Resource.Drawable.earthpictures));
            ListItems.Add(new Programs("Visit Nablus", Resource.Drawable.earthpictures));
            //listview.Adapter = new HomeScreenAdapter(this, ListItems);
        }
        
    }
}

