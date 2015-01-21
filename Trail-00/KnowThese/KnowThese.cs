using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowThese
{
    // must know these basic C# ideas/syntax to get started

    // 1. accessor keywords:
    // public - everyone can see/use it
    // private - only current class can see/use it
    // internal - public inside current assembly (dll/exe), private to others


    // 2. built-in types that you can use right-away:
    // bool - boolean with true/false values
    // int - integer type for numbers
    // string - text type


    // 3. how to defining a class (or creating your own type):
    // [accessor] [class keyword] [class name] { }
    public class Point3
    {
    }


    // 4. how to define variables:
    // [accessor] [type name] [variable name];
    //
    // Also note most things you do will exist
    // inside a class (C# is object-oriented)
    public class Point4
    {
        // when defined inside a class these are also called "fields" (not just variables)
        int integer; // private is implied for class members without [accessor].
        public string MyStringField;

        // can also declare fields of your own type
        Point3 myOwnType;
    }


    // 5. how to define methods:
    // [accessor] [return type name] [method name] ([parameter type name] [parameter name],...){ }
    public class Point5
    {
        // return string, without parameters
        public string SayHello()
        {
            return "hello";
        }

        // no return value, with parameter
        public void DoSomething(string task)
        {
            // do some work here 
        }

        // multiple parameters
        public int AddNumbers(int value1, int value2)
        {
            return value1 + value2;
        }
    }

    // 6. how to use a previously defined class
    public class Point6
    {
        void UseClassExample()
        {
            // Can create a instance of it with [new] keyword.
            Point5 p5 = new Point5(); // variables inside a method is called local variable (vs class variable or field)

            // Can call class methods with .
            string result = p5.SayHello(); // can assign return value to another variable
            p5.DoSomething(result);        // no return value so can't assign to variable

            // Can access class fields with . and use it just like a regular variable since that's what it is
            Point4 p4 = new Point4();
            p4.MyStringField = "asdf";         // assign value to it
            string another = p4.MyStringField; // assign its value to another variable.
        }
    }

}
