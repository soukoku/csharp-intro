using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Person : LivingThing
    {
        public bool IsMale { get; set; } // true=M, false=F

        public HairColor HairColor { get; set; }

    }
}
