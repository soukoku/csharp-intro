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
        public string Name;

        // age of person
        public int Age;



        // mitigate bad age by controlled property setter!
        //private int _age;

        //public int Age
        //{
        //    get { return _age; }
        //    set
        //    {
        //        if (value < 0) { throw new ArgumentOutOfRangeException(); }
        //        _age = value;
        //    }
        //}





        // height of person
        public int Height;

        // magic #,
        // 0=black
        // 1=yellow
        // 2=red
        // 3=white
        public int HairColor;

        // true=M, false=F
        public bool IsMale;
    }
}
