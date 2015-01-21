using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel
{
    public class Car
    {
        // shared with living things
        public string Name { get; set; }

        // shared with living things
        public int Age
        {
            get
            {
                // note the car doesn't actually store age;
                // it's calculated on the fly by comparing
                // now with manufactured year.
                // (yes you can do this in a property get)
                return DateTime.Now.Year - Year;
            }
        }

        public int Wheels { get; set; }

        // year manufacturered
        public int Year { get; set; }

        public int Miles { get; set; }
    }
}
