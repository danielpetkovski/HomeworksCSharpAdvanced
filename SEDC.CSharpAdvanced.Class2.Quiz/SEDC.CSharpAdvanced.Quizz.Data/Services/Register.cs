using SEDC.CSharpAdvanced.Quizz.Data.Database;
using SEDC.CSharpAdvanced.Quizz.Data.Models;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;

namespace SEDC.CSharpAdvanced.Quizz.Data.Services
{
   public class Register
    {
        public UserServices _userRepository;

        public Register()
        {
            _userRepository = new UserServices();
        }

        public User Login(string username, string password)
        {
            
            

            User user = _userRepository.GetUserByUserName(username);

            if (user.Password != password)
            {
                Console.WriteLine(" try: 1/3 \n The password is incorrect try again:");
                password = Console.ReadLine();
                if (user.Password != password)
                {
                    Console.WriteLine("Try: 2/3 \n The password is incorrect try again: ");
                    password = Console.ReadLine();
                    if (user.Password != password)
                    {
                        Console.WriteLine("You have entered wrong password 3 times! Application closes");
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                    }
                }
            }

            Console.WriteLine($"Welcome {user.FullName}");
            return user;
        }





    }
}
