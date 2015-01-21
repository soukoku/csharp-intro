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

    public class Person
    {
        public string Name { get; set; }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0) { throw new ArgumentOutOfRangeException(); }
                _age = value;
            }
        }

        private int _height;
        public int Height
        {
            get { return _height; }
            set
            {
                if (value < 0) { throw new ArgumentOutOfRangeException(); }
                _height = value;
            }
        }


        public bool IsMale { get; set; } // true=M, false=F

        public HairColor HairColor { get; set; }


    }
}
