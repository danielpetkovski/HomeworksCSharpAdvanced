using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdvanced.Quizz.Data.Database
{
   public class Questions
    {


        public static int FirstQuestion()
        {
            Console.WriteLine("Q: What is the capital of Tasmania?");
            Console.WriteLine(" 1: Dodoma \n 2: Hobart \n 3: Launceston \n 4: Wellington");
            int firstAnswer = ToInteger(1, 4);


            if (firstAnswer == 1)
            {
                return 1;
            }
            return 0;


        }
        
        public static int SecondQuestion()
        {
            Console.WriteLine("Q: What is the tallest building in the Republic of the Congo?");
            Console.WriteLine(" 1: Kinshasa Democratic Republic of the Congo Temple \n 2: Palais de la Nation \n" +
                " 3: Kongo Trade Centre \n" +
                " 4: Nabemba Tower");
            int secondAnswer = ToInteger(1, 4);
            if (secondAnswer == 1)
            {
                return 1;
            }
            return 0;
        }

        public static int ThirdQuestion()
        {
            Console.WriteLine("Q: Which of these is not one of Pluto's moons?");
            Console.WriteLine(" 1: Styx \n 2: Hydra \n 3: Nix \n 4: Lugia");

            int thirdAnswer = ToInteger(1, 4);
            if (thirdAnswer == 1)
            {
                return 1;
            }
            return 0;
        }

        public static int FourthQuestion()
        {
            Console.WriteLine("Q: What is the smallest lake in the world?");
            Console.WriteLine(" 1: Onega Lake \n 2: Benxi Lake \n 3: Kivu Lake \n 4: Wakatipu Lake");

            int fourthAnswer = ToInteger(1, 4);
            if (fourthAnswer == 1)
            {
                return 1;
            }
            return 0;

        }

        public static int FifthQuestion()
        {
            Console.WriteLine("5.Q: What country has the largest population of alpacas?");
            Console.WriteLine(" 1: Chad \n 2: Peru \n 3: Australia \n 4: Niger");

            int fifthAnswer = ToInteger(1, 4);
            if (fifthAnswer == 1)
            {
                return 1;
            }
            return 0;
        }

        public static int ToInteger(int min, int max)
        {
            int parsedNumber = 0;
            bool isValid = false;
            while (!isValid)
            {
                try
                {
                    parsedNumber = int.Parse(Console.ReadLine());
                    if (!(parsedNumber >= min && parsedNumber <= max))
                    {
                        throw new Exception($"Please select from given input range from {min} to {max}.");
                    }
                    isValid = !isValid;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Please enter argument.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not valid input.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number is too large or too low.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return parsedNumber;
        }
    }
}
