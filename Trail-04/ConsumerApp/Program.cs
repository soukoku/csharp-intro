using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[Trail-04]");

            #region using persons

            Person pan = new Person();
            pan.Name = "Pan";
            pan.Age = 25;
            pan.HairColor = HairColor.Black;
            pan.Height = 6;
            pan.IsMale = true;

            Person friend = new Person();
            friend.Name = "Melissa";
            friend.Age = 20;
            friend.HairColor = HairColor.Yellow;
            friend.Height = 6;


            // use the person object in various scenarios
            ToolMethods tool = new ToolMethods();

            Console.Write("The main person's name is ");
            tool.EchoName(pan);

            Console.Write(tool.GetGenderThirdPersonSubject(pan) + " has a friend called ");
            tool.EchoName(friend);

            Console.WriteLine("Their combined age is " + tool.AddAges(pan, friend) + ", average age is " + tool.AverageAge(pan, friend));

            #endregion

            #region using plants

            Plant p1 = new Plant();
            p1.Name = "Sunflower";
            p1.Age = 3;
            p1.Height = 4;

            Plant p2 = new Plant();
            p2.Name = "Basil";
            p2.Age = 1;
            p2.Height = 1;

            // use the plant object in various scenarios
            //Console.WriteLine("We have 2 plants:");
            //tool.EchoName(p1);
            //tool.EchoName(p2);

            //Console.WriteLine("Their combined age is " + tool.AddAges(p1, p2) + ", average age is " + tool.AverageAge(p1, p2));

            #endregion

            // app concluded
            Console.ReadLine();
        }
    }

    // utility class containing various work methods 
    class ToolMethods
    {
        // write the name to the console
        public void EchoName(Person person)
        {
            Console.WriteLine(person.Name);
        }
        //public void EchoName(Plant plant)
        //{
        //    Console.WriteLine(plant.Name);
        //}

        public string GetGenderThirdPersonSubject(Person person)
        {
            if (person.IsMale)
            {
                return "He";
            }
            return "She";
        }

        public int AddAges(Person person1, Person person2)
        {
            return person1.Age + person2.Age;
        }

        public int AverageAge(Person person1, Person person2)
        {
            return AddAges(person1, person2) / 2;
        }

        //public int AddAges(Plant p1, Plant p2)
        //{
        //    return p1.Age + p2.Age;
        //}

        //public int AverageAge(Plant p1, Plant p2)
        //{
        //    return AddAges(p1, p2) / 2;
        //}
    }

    // version that uses base types if possible
    //class ToolMethods2
    //{
    //    // write the name to the console
    //    public void EchoName(LivingThing thing)
    //    {
    //        Console.WriteLine(thing.Name);
    //    }

    //    public string GetGenderThirdPersonSubject(Person person)
    //    {
    //        if (person.IsMale)
    //        {
    //            return "He";
    //        }
    //        return "She";
    //    }

    //    public int AddAges(LivingThing person1, LivingThing person2)
    //    {
    //        return person1.Age + person2.Age;
    //    }

    //    public int AverageAge(LivingThing person1, LivingThing person2)
    //    {
    //        return AddAges(person1, person2) / 2;
    //    }
    //}
}
