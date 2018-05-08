using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingApp_Events_Interface
{
    public class Employee: ILocalisable
    {
        public string TrackId { get; set; }
        public string Location { get; set; }

        public Employee(string name)
        {
            TrackId = name;
        }

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

        public override string ToString()
        {
            return "Employee: " + TrackId;
        }
    }
}
