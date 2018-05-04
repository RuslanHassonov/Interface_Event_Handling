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
        public event EventHandler<LocationEventArgs> LocationSubmitted;

        public Employee(string name)
        {
            TrackId = name;
        }

        private void OnLocationSubmitted() => LocationSubmitted?.Invoke(this, new LocationEventArgs(TrackId, Location));

        public void SubmitLocation (string location)
        {
            Location = location;
            OnLocationSubmitted();
        }

        public override string ToString()
        {
            return "Employee: " + TrackId;
        }
    }
}
