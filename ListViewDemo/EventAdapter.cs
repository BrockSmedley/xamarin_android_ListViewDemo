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

namespace ListViewDemo {
	public class EventAdapter : BaseAdapter<Event> {
		List<Event> events;
		Activity context;

		public EventAdapter(Activity context, List<Event> events) {
			this.context = context;
			this.events = events;
		}

		public override long GetItemId(int position) {
			return position;
		}

		public override Event this[int position] {
			get { return events[position]; }
		}

		public override int Count {
			get { return events.Count; }
		}

		public override View GetView(int position, View convertView, ViewGroup parent) {
			View view = convertView;//reuse existing view if available
			if (view == null) {
				view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem2, null);
			}

			view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = events[position].Title;
			view.FindViewById<TextView>(Android.Resource.Id.Text2).Text = (events[position].Start + " - " + events[position].End);

			return view;
		}

	}
}