using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase2
{
    public class Address
    {
        public string streetAddress {get; set;}
        public string city { get; set; }
        public string state { get; set; }
        public int zipcode { get; set; }

        public string GetHomeTown(string city, string state)
        {
            { return $"{city} {state}"; }
        }
    }

}
