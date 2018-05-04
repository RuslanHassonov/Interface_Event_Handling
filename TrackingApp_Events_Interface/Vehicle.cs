using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingApp_Events_Interface
{
    public class Vehicle: ILocalisable
    {
        public string Location { get; set; }
        public string TrackId { get; set; }

        public event EventHandler<LocationEventArgs> LocationSubmitted;

        private void OnLocationSubmitted()
        {
            LocationSubmitted?.Invoke(this, new LocationEventArgs(TrackId, Location));
        }

        public void SubmitLocation(string location)
        {
            Location = location;
            OnLocationSubmitted();
        }

        public bool VehicleExists (List<Vehicle> vehicles, string plate)
        {
            foreach (var item in vehicles)
            {
                if (item.TrackId == plate)
                {
                    return true;
                }
            }
            return false;
        }
    }

    
}
