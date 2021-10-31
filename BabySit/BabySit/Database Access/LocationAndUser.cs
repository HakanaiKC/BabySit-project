using BabySit.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace BabySit.Database_Access
{
    public class LocationAndUser
    {
        public IEnumerable<User> users { get; set; }
        public IEnumerable<Location> locations { get; set; }
    }
}


