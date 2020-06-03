using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdvanced.Quizz.Data.Database
{
   public class Questions
    {


        public static bool FirstQuestion()
        {
            Console.WriteLine("Q: What is the capital of Tasmania?");
            Console.WriteLine("a: Dodoma \n b: Hobart \n c: Launceston \n d: Wellington");
            string firstAnswer = Console.ReadLine();
            if (firstAnswer == "a")
            {
                return true;
            }
            return false;


        }
        
        public static bool SecondQuestion()
        {
            Console.WriteLine("Q: What is the tallest building in the Republic of the Congo?");
            Console.WriteLine("a: Kinshasa Democratic Republic of the Congo Temple \n b: Palais de la Nation \n" +
                " c: Kongo Trade Centre \n" +
                " d: Nabemba Tower");
            string secondAnswer = Console.ReadLine();
            if (secondAnswer == "a")
            {
                return true;
            }
            return false;
        }

        public static bool ThirdQuestion()
        {
            Console.WriteLine("Q: Which of these is not one of Pluto's moons?");
            Console.WriteLine("a: Styx \n b: Hydra \n c: Nix \n d: Lugia");

            string thirdAnswer = Console.ReadLine();
            if (thirdAnswer == "a")
            {
                return true;
            }
            return false;
        }

        public static bool FourthQuestion()
        {
            Console.WriteLine("Q: What is the smallest lake in the world?");
            Console.WriteLine("a: Onega Lake \n b: Benxi Lake \n c: Kivu Lake \n d: Wakatipu Lake");

            string fourthAnswer = Console.ReadLine();
            if (fourthAnswer == "a")
            {
                return true;
            }
            return false;

        }

        public static bool FifthQuestion()
        {
            Console.WriteLine("5.Q: What country has the largest population of alpacas?");
            Console.WriteLine("a: Chad \n b: Peru \n c: Australia \n d: Niger");

            string fifthAnswer = Console.ReadLine();
            if (fifthAnswer == "a")
            {
                return true;
            }
            return false;
        }

    }
}
