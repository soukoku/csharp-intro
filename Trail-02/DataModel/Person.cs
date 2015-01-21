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

        #region original age

        // age of person
        public int Age;

        #endregion

        #region prevention attempt 1 - hide field and use methods to control access

        //private int _age;
        //public int GetAge()
        //{
        //    return _age;
        //}
        //public void SetAge(int age)
        //{
        //    if (age < 0) { throw new ArgumentOutOfRangeException(); }
        //    _age = age;
        //}

        #endregion

        #region prevention attempt 2 - use language property

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

        #endregion



        // height of person
        public int Height;

        // true=M, false=F
        public bool IsMale;

        // magic #,
        // 0=black
        // 1=yellow
        // 2=red
        // 3=white
        public int HairColor;
    }
}
