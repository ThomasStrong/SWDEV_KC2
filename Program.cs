using System;
using System.Collections.Generic;
using System.Threading;

namespace SWDEV_KC2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<Unicorn>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                Unicorn unicorn = new();
                unicorn.Id = i + 1;

                Console.WriteLine("Please enter the value for the unicorn's age (in human years):");
                unicorn.Age = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the value for the unicorn's length (in inches):");
                unicorn.Length = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the value for the unicorn's height (in inches):");
                unicorn.Height = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the value for the unicorn's horn color:");
                unicorn.HornColor = Console.ReadLine();

                Console.WriteLine("Please enter the value for the unicorn's mane color:");
                unicorn.ManeColor = Console.ReadLine();

                Console.WriteLine("On the rarest of occasions unicorns have one or more pairs of wings.  How many pairs of wings does this unicorn have?");
                unicorn.NumberWings = int.Parse(Console.ReadLine());
                Console.ReadLine();

                recordList.Add(unicorn);

                Console.Clear();


            }

            Console.WriteLine("Printing unicorns, one moment...");
            Thread.Sleep(2000);
            Console.Clear();

            foreach (Unicorn unicorn in recordList)
            {
                Console.WriteLine(" ");
                Console.WriteLine($"Unicorn: '{unicorn.Id}'");
                Console.WriteLine($"        Age: {unicorn.Age}");
                Console.WriteLine($"        Length: {unicorn.Length}");
                Console.WriteLine($"        Height: {unicorn.Height}");

                Console.WriteLine($"        Horn Color: {unicorn.HornColor}");
                Console.WriteLine($"        Mane Color: {unicorn.ManeColor}");
                Console.WriteLine($"        Pairs of Wings: {unicorn.NumberWings}");

                Console.WriteLine(" ");
            }
        }
    }
}
