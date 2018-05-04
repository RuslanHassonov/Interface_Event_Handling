using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingApp_Events_Interface
{
    public interface ILocalisable
    {
        string Location { get; set; }
        string TrackId { get; set; }
    }
}
