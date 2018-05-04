using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingApp_Events_Interface
{
    public class Van : Vehicle
    {
        public Van(string licensePlate)
        {
            LicensePlate = licensePlate;
        }

        public override string ToString()
        {
            return "Van: " + LicensePlate;
        }
    }
}
