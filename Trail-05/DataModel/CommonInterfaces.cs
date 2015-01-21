using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel
{
    // interfaces are like contracts
    // and only define whatever is necessary

    public interface IIdentifiable
    {
        string Name { get; set; }
    }

    // can even be named like English if that's your thing
    public interface IHaveAge
    {
        int Age { get; } // note this contract doesn't specify set even if actual class can set.
    }
}
