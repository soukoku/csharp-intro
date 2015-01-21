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
        // name of person
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

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


        // note that properties without validation requirement
        // can use shorthand syntax
        public bool IsMale { get; set; } // true=M, false=F

        #region original

        // magic #,
        // 0=black
        // 1=yellow
        // 2=red
        // 3=white
        //public int HairColor { get; set; }

        #endregion

        #region improved with enum property;

        public HairColor HairColor { get; set; }

        #endregion


    }
}
