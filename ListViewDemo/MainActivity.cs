using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace ListViewDemo {
	[Activity(Label = "ListViewDemo", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : ListActivity {
		List<Event> events;

		protected override void OnCreate(Bundle bundle) {
			base.OnCreate(bundle);

			//populate listview
			PopulateEvents();
		}

		protected override void OnListItemClick(ListView l, View v, int position, long id) {
			var t = events[position];

			Toast.MakeText(this, t.Title, ToastLength.Short).Show();
		}

		//makes some events and set the ListActivity's ListAdapter
		private void PopulateEvents() {
			events = new List<Event>();

			events.Add(new Event(0, 1, "first event"));
			events.Add(new Event(2, 3.5, "second event"));
			events.Add(new Event(4, 5, "third event"));

			ListAdapter = new EventAdapter(this, events);
		}
	}
}

