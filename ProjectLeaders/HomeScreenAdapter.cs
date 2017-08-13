using Android.App;
using Android.Widget;
using System.Collections.Generic;
using Android.Views;

namespace ProjectLeaders
{
    public partial class MainActivity : Activity
    {
        public class HomeScreenAdapter : BaseAdapter<Programs>
        {
            List<Programs> items;
            Activity context;
            public HomeScreenAdapter(Activity context, List<Programs> items)
                : base()
            {
                this.context = context;
                this.items = items;
            }
            public override long GetItemId(int position)
            {
                return position;
            }
            public override Programs this[int position]
            {
                get { return items[position]; }
            }
            public override int Count
            {
                get { return items.Count; }
            }
            public override View GetView(int position, View convertView, ViewGroup parent)
            {
                var item = items[position];
                View view = convertView;
                if (view == null) // no view to re-use, create new
                    view = context.LayoutInflater.Inflate(Resource.Layout.ProgView, null);
                view.FindViewById<TextView>(Resource.Id.progdesc).Text = item.ProgDesc;
                view.FindViewById<ImageView>(Resource.Id.imagesource).SetImageResource(item.ImageSourceId);
                return view;
            }
        }
    }
}

