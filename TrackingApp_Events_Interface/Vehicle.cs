using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingApp_Events_Interface
{
    public class Vehicle: ILocalisable
    {
        public string LicensePlate { get; set; }

        public string Location { get; set; }

        public string TrackId { get; set; }

        public bool VehicleExists (List<Vehicle> vehicles, string plate)
        {
            foreach (var item in vehicles)
            {
                if (item.LicensePlate == plate)
                {
                    return true;
                }
            }

            return false;
        }
    }

    
}
