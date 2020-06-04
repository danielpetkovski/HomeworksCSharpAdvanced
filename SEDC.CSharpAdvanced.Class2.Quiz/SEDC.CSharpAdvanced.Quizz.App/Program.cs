using SEDC.CSharpAdvanced.Quizz.Data.Database;
using SEDC.CSharpAdvanced.Quizz.Data.Models;
using SEDC.CSharpAdvanced.Quizz.Data.Services;
using System;
using System.Threading;

namespace SEDC.CSharpAdvanced.Quizz.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Register register = new Register();

            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Welcome to the QUIZZ App");
                    Console.WriteLine("Please enter your user name:");
                    string username = Console.ReadLine();
                    //proverka na username
                    var checkingUsername = register.CheckIfUserExists(username);

                    if (checkingUsername == null)
                    {
                        Console.WriteLine("1/3 \n You have entered wrong username please try again:");
                        username = Console.ReadLine();
                        checkingUsername = register.CheckIfUserExists(username);
                        if (checkingUsername == null)
                        {
                            Console.WriteLine("2/3 \n You have entered wrong username please try again:");
                            username = Console.ReadLine();
                            checkingUsername = register.CheckIfUserExists(username);
                            if (checkingUsername == null)
                            {
                                Console.WriteLine("3/3 \n You have entered wrong username 3 times! Aplication closes...");
                                Thread.Sleep(3000);
                                Environment.Exit(0);

                            }
                        }
                    }
                    Console.WriteLine("Please enter your password:");
                    string password = Console.ReadLine();
                    // proverka na password i prevzemanje user (dopolnitelna proverka dali ima zavrseno test--)
                    User user = register.Login(username, password);
                    if (user == null)
                    {
                        break;
                    }

                    switch (register.UserType(user))
                    {
                        case 1:
                            //student
                            int firstAnswer = Questions.FirstQuestion();
                            int secondAnswer = Questions.SecondQuestion();
                            int thirdAnswer = Questions.ThirdQuestion();
                            int fourthAnswer = Questions.FourthQuestion();
                            int fifthAnswer = Questions.FifthQuestion();

                            int grade = firstAnswer + secondAnswer + thirdAnswer + fourthAnswer + fifthAnswer;
                            // if every answer is incorect grade should be 1 (grade mora od 1-5)
                            if (grade == 0)
                            {
                                grade++;
                            }

                            user.Grade = grade;
                            user.IsDone = true;

                            Console.WriteLine($"You have finished the quiz and got grade {user.Grade}. Loging out...");
                            Thread.Sleep(4000);
                            Console.Clear();
                            break;

                        case 2:
                            //teacher
                            var listOfAllStudents = register.GenerateListOfStudents();
                            register.ShowStudents(listOfAllStudents);
                            Console.WriteLine("Press enter to exit");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                    }
                }
            }
        }
    }
}
