using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text.RegularExpressions;

namespace SEDC.ProjectExercise.Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            while (true)
            {
                Console.WriteLine("Please input name, or input x to exit:");
                string input = Console.ReadLine();
                
                if(input == "x")
                {
                    break;
                }
                names.Add(input);
            }
            Console.WriteLine("Please insert text:");
            string inputText = Console.ReadLine();

            List<string> trimmedInputText = inputText.Split(" ").ToList();

            foreach (string name in names)
            {


                var count = trimmedInputText.Where(name1 => name1.ToLower().Contains(name.ToLower()));

                Console.WriteLine($"{name} appears {count.Count()} times ");

            }

        }
    }
}
