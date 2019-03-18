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

namespace WorkTimeTracker.Resources.Models
{
    public class Shift
    {
        public int Id { get; set; }
        public DateTime BeginShift { get; set; }
        public TimeSpan Break { get; set; }
        public DateTime EndShift { get; set; }
    }
}