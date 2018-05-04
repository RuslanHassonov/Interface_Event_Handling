using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingApp_Events_Interface
{
    public class Car : Vehicle
    {
        public override string ToString()
        {
            return "Car: " + TrackId;
        }
    }
}
