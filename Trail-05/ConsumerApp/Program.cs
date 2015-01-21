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
            // color is hard to use, can never remember what is what
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
            Console.WriteLine("We have 2 plants:");
            tool.EchoName(p1);
            tool.EchoName(p2);

            Console.WriteLine("Their combined age is " + tool.AddAges(p1, p2) + ", average age is " + tool.AverageAge(p1, p2));

            #endregion

            #region using cars

            Car c1 = new Car();
            c1.Name = "Toyota";
            c1.Year = 2005;
            c1.Miles = 10000;
            c1.Wheels = 4;

            Car c2 = new Car();
            c2.Name = "Kia";
            c2.Year = 2013;
            c2.Miles = 5000;
            c2.Wheels = 4;

            // use the plant object in various scenarios
            Console.WriteLine("We have 2 cars:");
            tool.EchoName(c1);
            tool.EchoName(c2);

            Console.WriteLine("Their combined age is " + tool.AddAges(c1, c2) + ", average age is " + tool.AverageAge(c1, c2));

            #endregion

            // app concluded
            Console.ReadLine();
        }
    }


    // original version
    class ToolMethods
    {
        // write the name to the console
        public void EchoName(LivingThing thing)
        {
            Console.WriteLine(thing.Name);
        }
        public void EchoName(Car car)
        {
            Console.WriteLine(car.Name);
        }

        public string GetGenderThirdPersonSubject(Person person)
        {
            if (person.IsMale)
            {
                return "He";
            }
            return "She";
        }

        public int AddAges(LivingThing person1, LivingThing person2)
        {
            return person1.Age + person2.Age;
        }

        public int AverageAge(LivingThing person1, LivingThing person2)
        {
            return AddAges(person1, person2) / 2;
        }

        public int AddAges(Car car1, Car car2)
        {
            return car1.Age + car2.Age;
        }

        public int AverageAge(Car car1, Car car2)
        {
            return AddAges(car1, car2) / 2;
        }
    }

    // version that uses interface types if possible
    //class ToolMethods
    //{
    //    // write the name to the console
    //    public void EchoName(IIdentifiable identifiable)
    //    {
    //        Console.WriteLine(identifiable.Name);
    //    }

    //    public string GetGenderThirdPersonSubject(Person person)
    //    {
    //        if (person.IsMale)
    //        {
    //            return "He";
    //        }
    //        return "She";
    //    }

    //    public int AddAges(IHaveAge ageable1, IHaveAge ageable2)
    //    {
    //        return ageable1.Age + ageable2.Age;
    //    }

    //    public int AverageAge(IHaveAge ageable1, IHaveAge ageable2)
    //    {
    //        return AddAges(ageable1, ageable2) / 2;
    //    }
    //}
}
