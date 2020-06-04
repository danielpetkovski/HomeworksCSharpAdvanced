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

        public User CheckIfUserExists(string username)
        {
            return _userRepository.GetUserByUserName(username);
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
            Console.Clear();

            if (user.IsDone)
            {
                Console.WriteLine($"Hello {user.FullName}, you have already finished the test and got grade {user.Grade}."); 
                return null;
            }

            Console.WriteLine($"Welcome {user.FullName}");
            return user;
        }

        public int UserType(User user)
        {
            if (!user.IsTeacher)
            {
                return 1;
            }
            return 2;
        }

        public List<User> GenerateListOfStudents()
        {
            return _userRepository.GetAllStudents();
        
        }



        // za prikazuvanje na studentite crveni i zeleni zavrseni
        public void ShowStudents(List<User> listOfStudents)
        {
            foreach (User student in listOfStudents)
            {
                if (student.IsDone)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"The student {student.FullName} has grade {student.Grade}");
                    Console.ResetColor();
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"The student {student.FullName} has not finished yet!");
                    Console.ResetColor();
                }
            }
        }






    }
}
