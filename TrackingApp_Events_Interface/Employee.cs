﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingApp_Events_Interface
{
    public class Employee: ILocalisable
    {
        public string Name { get; set; }

        public string Location { get; set; }

        public string TrackId { get; set; }

        public Employee(string name)
        {
            Name = name;
            TrackId = name;
        }

        public override string ToString()
        {
            return "Employee: " + Name;
        }


    }
}