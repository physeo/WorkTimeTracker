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
using Java.Lang;
using WorkTimeTracker.Resources.Models;

namespace WorkTimeTracker.Resources
{
    public class ViewHolder:Java.Lang.Object
    {
        public TextView txtBeginTime { get; set; }
        public TextView txtBreak { get; set; }
        public TextView txtEndTime { get; set; }
        public TextView txtTotalHours { get; set; }
    }
    public class ListViewAdapter:BaseAdapter
    {
        private Activity activity;
        private List<Shift> lstShifts;
        public ListViewAdapter(Activity activity, List<Shift> lstShift)
        {
            this.activity = activity;
            this.lstShifts = lstShift;
        }

        public override int Count => this.lstShifts.Count;

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return lstShifts[position].Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            throw new NotImplementedException();
           // var view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout., parent, false);
        }
    }
}