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

        public void LocationSubmit(string newLocation)
        {
            Location = newLocation;
            OnLocationSubmitted(new LocationEventArgs(TrackId, Location));
        }

        protected virtual void OnLocationSubmitted(LocationEventArgs args)
        {
            LocationSubmitted?.Invoke(this, args);
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
