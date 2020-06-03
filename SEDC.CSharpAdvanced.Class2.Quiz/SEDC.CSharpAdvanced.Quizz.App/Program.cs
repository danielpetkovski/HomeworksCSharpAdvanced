using SEDC.CSharpAdvanced.Quizz.Data.Database;
using SEDC.CSharpAdvanced.Quizz.Data.Services;
using System;

namespace SEDC.CSharpAdvanced.Quizz.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var register = new Register();

            Console.WriteLine("Please enter your user name:");
            string username = Console.ReadLine();

            Console.WriteLine("Please enter your password:");
            string password = Console.ReadLine();


            register.Login(username,password);


            Console.ReadLine();
        }
    }
}
