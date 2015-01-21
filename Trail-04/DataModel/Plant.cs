using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel
{
    public class Plant
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
    }
}
