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

namespace Meme.Droid
{
	public class LazyAdapter : BaseAdapter<TableItem> {
		private Activity activity;
		private List<TableItem> data;
		private static LayoutInflater inflater=null;
		//public ImageLoader imageLoader; 

		public LazyAdapter(Activity context, List<TableItem> items)
			: base()
		{
			this.activity = context;
			this.data = items;
			inflater = (LayoutInflater)activity.GetSystemService(Context.LayoutInflaterService);
			//imageLoader=new ImageLoader(activity.getApplicationContext());
		}
		public override long GetItemId(int position)
		{
			return position;
		}
		public override TableItem this[int position]
		{
			get { return data[position]; }
		}
		public override int Count
		{
			get { return data.Count; }
		}
		public override View GetView(int position, View convertView, ViewGroup parent)
		{

			View vi=convertView;
			if(convertView==null)
				vi = inflater.Inflate(Resource.Layout.list_row, null);

			TextView title = (TextView)vi.FindViewById(Resource.Id.name); // title
			TextView artist = (TextView)vi.FindViewById(Resource.Id.dir); // artist name
			ImageView thumb_image=(ImageView)vi.FindViewById(Resource.Id.list_image); // thumb image

			// Setting all values in listview
			title.Text = data [position].SubHeading;
			artist.Text = data[position].Heading;
			thumb_image.SetImageResource (Resource.Drawable.meme_logo);
			//imageLoader.DisplayImage(song.get(CustomizedListView.KEY_THUMB_URL), thumb_image);
			return vi;

		}
	}

	public class TableItem
	{
		public string Heading{ get; set; }
		public string SubHeading { get; set;}
	}
}

