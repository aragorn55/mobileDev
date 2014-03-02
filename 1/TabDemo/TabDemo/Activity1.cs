using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;



// [Activity (MainLauncher=true, Label="@string/app_name", Theme="@android:style/Theme.NoTitleBar")]  


namespace TabDemo
{
    [Activity(Label = "TabDemo", MainLauncher = true, Icon = "@drawable/icon", Theme="@android:style/Theme.NoTitleBar")]  
    public class Activity1 : TabActivity 
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            TabHost.TabSpec spec;     // Resusable TabSpec for each tab
            Intent intent;            // Reusable Intent for each tab

            // Create an Intent to launch an Activity for the tab (to be reused)
            intent = new Intent(this, typeof(ArtistsActivity));
            intent.AddFlags(ActivityFlags.NewTask);

            // Initialize a TabSpec for each tab and add it to the TabHost
            spec = TabHost.NewTabSpec("artists");
            spec.SetIndicator("Artists", Resources.GetDrawable(Resource.Drawable.ic_tab_artists));
            spec.SetContent(intent);
            TabHost.AddTab(spec);

            // Do the same for the other tabs
            intent = new Intent(this, typeof(AlbumsActivity));
            intent.AddFlags(ActivityFlags.NewTask);

            spec = TabHost.NewTabSpec("albums");
            spec.SetIndicator("Albums", Resources.GetDrawable(Resource.Drawable.ic_tab_albums));
            spec.SetContent(intent);
            TabHost.AddTab(spec);

            intent = new Intent(this, typeof(SongsActivity));
            intent.AddFlags(ActivityFlags.NewTask);

            spec = TabHost.NewTabSpec("songs");
            spec.SetIndicator("Songs", Resources.GetDrawable(Resource.Drawable.ic_tab_songs));
            spec.SetContent(intent);
            TabHost.AddTab(spec);

            TabHost.CurrentTab = 2;
        }
    }
}

