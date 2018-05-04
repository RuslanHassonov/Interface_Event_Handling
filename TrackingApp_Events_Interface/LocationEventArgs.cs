using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingApp_Events_Interface
{
    public class LocationEventArgs
    {
        public string TrackId { get; set; }
        public string Location { get; set; }

        public LocationEventArgs(string id, string location)
        {
            TrackId = id;
            Location = location;
        }
    }
}
