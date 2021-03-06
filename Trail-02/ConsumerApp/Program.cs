﻿using DataModel;
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
            Console.WriteLine("[Trail-02]");

            // establish some person objects
            Person pan = new Person();
            pan.Name = "Pan";
            pan.Age = 25;
            pan.HairColor = 0;
            pan.Height = 6;
            pan.IsMale = true;

            Person friend = new Person();
            friend.Name = "Melissa";

            friend.Age = -20; // evil code passes invalid age number, how to prevent?
            //friend.SetAge(-20); // attempt 1

            friend.HairColor = 1;
            friend.Height = 6;


            // use the person object in various scenarios
            ToolMethods tool = new ToolMethods();

            Console.Write("The main person's name is ");
            tool.EchoName(pan);

            Console.Write(tool.GetGenderThirdPersonSubject(pan) + " has a friend called ");
            tool.EchoName(friend);

            Console.WriteLine("Their combined age is " + tool.AddAges(pan, friend) + ", average age is " + tool.AverageAge(pan, friend));


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
            //return person1.GetAge() + person2.GetAge(); // attempt 1
        }

        public int AverageAge(Person person1, Person person2)
        {
            return AddAges(person1, person2) / 2;
        }
    }
}
