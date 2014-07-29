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
using Android.Support.V4.View;
using Org.W3c.Dom;
using Android.Support.V4.Widget;

namespace Meme.Droid.Helpers
{

    public class Fragment1 : Android.Support.V4.App.Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            HasOptionsMenu = true;
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(Resource.Layout.NavDrawerFrag, null);
            return view;
        }

        public override void OnCreateOptionsMenu(IMenu menu, MenuInflater inflater)
        {
			inflater.Inflate(Resource.Menu.main_menu, menu);
        }
    }

    public class Fragment3 : Android.Support.V4.App.Fragment
	{
		Activity1 ct;
		public Fragment3(Activity1 ctx)
		{
			ct = ctx;
		}
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
			List<TableItem> songsList = new List<TableItem> ();
			songsList.Add(new TableItem(){Heading = "Bolitas #X Col. Centro", SubHeading = "Local 1"});
			songsList.Add(new TableItem(){Heading = "Benigno Romo #4X Col. Centro", SubHeading = "Local 2"});
            HasOptionsMenu = true;
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
			var view = inflater.Inflate(Resource.Layout.ListFrag, null);
			SwipeRefreshLayout swipe = view.FindViewById<SwipeRefreshLayout> (Resource.Id.swipe_container);
			swipe.Refresh += (sender, e) => {
				swipe.Refreshing = false;
			};
			ListView list = view.FindViewById<ListView> (Resource.Id.list);
			LazyAdapter adapter =new LazyAdapter(ct, songsList);        
			list.Adapter = adapter;
			list.ItemClick += (sender, e) => {
				var next = new Intent (ct, typeof(DetailActivity));
				StartActivity (next);
			};
			RegisterForContextMenu (list);
            return view;
        }

		public override void OnCreateContextMenu (IContextMenu menu, View v, IContextMenuContextMenuInfo menuInfo)
		{
			base.OnCreateContextMenu (menu, v, menuInfo);
			MenuInflater m = ct.MenuInflater;
			m.Inflate(Resource.Menu.context_menu, menu);  
		}

		Android.Support.V7.Widget.SearchView searchView;
        public override void OnCreateOptionsMenu(IMenu menu, MenuInflater inflater)
        {
			inflater.Inflate(Resource.Menu.menu_search, menu);

			var searchItem = menu.FindItem(Resource.Id.action_search);
			var test = MenuItemCompat.GetActionView(searchItem);
			searchView = test.JavaCast<Android.Support.V7.Widget.SearchView>();

			searchView.QueryTextSubmit += (sender, args) =>
			{
				ct.MostrarMSJ(args.Query);
			};

        }
    }

    public class Fragment2 : Android.Support.V4.App.Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            HasOptionsMenu = true;
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(Resource.Layout.NavDrawerFrag, null);

            return view;
        }

        public override void OnCreateOptionsMenu(IMenu menu, MenuInflater inflater)
        {
			inflater.Inflate(Resource.Menu.menu_search, menu);
        }
    }

}