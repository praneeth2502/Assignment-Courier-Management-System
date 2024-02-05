﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.model
{
    internal class Location
    {
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public string Address { get; set; }
        public Location()
        {

        }
        public Location(int locationID, string locationName, string address)
        {
            LocationID = locationID;
            LocationName = locationName;
            Address = address;
        }
    }
}
