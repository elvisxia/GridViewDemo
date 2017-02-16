using Android.App;
using Android.Widget;
using Android.OS;

namespace GridViewDemo
{
    [Activity(Label = "GridViewDemo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        GridView gridview;
        ImageAdapter mGridViewAdapter;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            gridview = FindViewById<GridView>(Resource.Id.gridview);
            mGridViewAdapter= new ImageAdapter(this);
            gridview.Adapter = mGridViewAdapter;
            Button btnClick = FindViewById<Button>(Resource.Id.btnClick);
            btnClick.Click += BtnClick_Click;

        }

        private void BtnClick_Click(object sender, System.EventArgs e)
        {
            int newSpan = 4; // new columns count

            gridview.SetNumColumns(newSpan); // set columns
            mGridViewAdapter.NotifyDataSetChanged(); // notify custom adapter
            mGridViewAdapter.thumbIds[0] = Resource.Drawable.gluehbirne;
            mGridViewAdapter.thumbIds[1] = Resource.Drawable.gluehbirne;
            mGridViewAdapter.thumbIds[2] = Resource.Drawable.gluehbirne;
            mGridViewAdapter.thumbIds[3] = Resource.Drawable.gluehbirne;
            mGridViewAdapter.thumbIds[4] = Resource.Drawable.gluehbirne;
        }
    }
}

