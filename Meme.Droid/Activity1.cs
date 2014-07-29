using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Meme.Droid.Helpers;
using Android.Content.Res;
using Android.Support.V4.View;

namespace Meme.Droid
{
	[Activity(Label = "Meme San Juan", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait, MainLauncher = true, Theme = "@style/Theme.AppCompat.Light", Icon = "@drawable/ic_launcher")]
    public class Activity1 : ActionBarActivity
    {
        private MyActionBarDrawerToggle drawerToggle;
        private string drawerTitle;
        private string title;

        private Android.Support.V4.Widget.DrawerLayout drawer;
        private ListView drawerList;
        private static readonly string[] Sections = 
            {
			"Inicio", "Abogados", "Aceros", "Agencias de viajes", 
			"Aceros","Bancos", "Bares","Cafeterías","Computación","Dentistas",
			"Escuelas","Farmacias","Ferreterías","Florerías","Gasolineras","Gimnasios",
			"Guarderías","Hospitales","Hoteles","Imprentas","Materiales de construcción","Médicos","Moteles","Notarios",
			"Pizzas","Psicólogos","Refacciones","Renta de autos","Restaurantes", "Reposterias",
			"Salones para fiestas","Taller mecánico","Taxis",
			"Viajes"
            };

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            title = drawerTitle = Title;

            drawer = FindViewById<Android.Support.V4.Widget.DrawerLayout>(Resource.Id.drawer_layout);
            drawerList = FindViewById<ListView>(Resource.Id.left_drawer);

            drawerList.Adapter = new ArrayAdapter<string>(this, Resource.Layout.ItemMenu, Sections);

            drawerList.ItemClick += (sender, args) => ListItemClicked(args.Position);


            drawer.SetDrawerShadow(Resource.Drawable.drawer_shadow_dark, GravityCompat.End); //start



            //DrawerToggle is the animation that happens with the indicator next to the actionbar
            drawerToggle = new MyActionBarDrawerToggle(this, drawer,
                                                      Resource.Drawable.ic_drawer_light,
                                                      Resource.String.drawer_open,
                                                      Resource.String.drawer_close);

            //Display the current fragments title and update the options menu
            drawerToggle.DrawerClosed += (o, args) =>
            {
                SupportActionBar.Title = title;
                SupportInvalidateOptionsMenu();
            };

            //Display the drawer title and update the options menu
            drawerToggle.DrawerOpened += (o, args) =>
            {
                SupportActionBar.Title = drawerTitle;
                SupportInvalidateOptionsMenu();
            };

            //Set the drawer lister to be the toggle.
            drawer.SetDrawerListener(drawerToggle);



            //if first time you will want to go ahead and click first item.
            if (savedInstanceState == null)
            {
                ListItemClicked(0);
            }


            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);
        }

		public void MostrarMSJ(string m)
		{
			Toast.MakeText(this, "You searched: " + m, ToastLength.Short).Show();
		}

        protected override void OnPostCreate(Bundle savedInstanceState)
        {
            base.OnPostCreate(savedInstanceState);
            drawerToggle.SyncState();
        }

        public override void OnConfigurationChanged(Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);
            drawerToggle.OnConfigurationChanged(newConfig);
        }

        // Pass the event to ActionBarDrawerToggle, if it returns
        // true, then it has handled the app icon touch event
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (drawerToggle.OnOptionsItemSelected(item))
                return true;

			switch (item.ItemId) {
			case Resource.Id.action_edit:
				var next = new Intent (this, typeof(FavActivity));
				StartActivity (next);
				break;
			}

            return base.OnOptionsItemSelected(item);
        }

        private void ListItemClicked(int position)
        {
            Android.Support.V4.App.Fragment fragment = null;
            switch (position)
            {
                case 0:
                    fragment = new Fragment1();
                    break;
                case 1:
                    fragment = new Fragment2();
                    break;
                case 2:
				fragment = new Fragment3(this);
                    break;
			default:
				fragment = new Fragment1 ();
				break;
            }

            SupportFragmentManager.BeginTransaction()
                .Replace(Resource.Id.content_frame, fragment)
                .Commit();

            drawerList.SetItemChecked(position, true);
            SupportActionBar.Title = title = Sections[position];
            drawer.CloseDrawer(drawerList);
        }





        public override bool OnPrepareOptionsMenu(IMenu menu)
        {

            var drawerOpen = this.drawer.IsDrawerOpen(this.drawerList);
            //when open don't show anything
            for (int i = 0; i < menu.Size(); i++)
                menu.GetItem(i).SetVisible(!drawerOpen);


            return base.OnPrepareOptionsMenu(menu);
        }


    }

}

