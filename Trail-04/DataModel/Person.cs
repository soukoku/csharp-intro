using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    // Goal: want to model a person in a re-usable lib.

    // this is the first naive attempt
    // with a Person class and some typical
    // personal attributes 

    public class Person : LivingThing
    {

        public bool IsMale { get; set; } // true=M, false=F

        public HairColor HairColor { get; set; }


    }
}
