using System;
using System.Globalization;

namespace SEDC.ProjectExercise.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool enterAgain = true;

            while (enterAgain)
            {
               

                Console.WriteLine("Please enter day:");
                string inputDay = Console.ReadLine();
                Console.WriteLine("Please enter month:");
                string inputMonth = Console.ReadLine();
                Console.WriteLine("Please enter year:");
                string inputYear = Console.ReadLine();

                while (true)
                {
                   

                    if (!IsValidDate(inputDay, inputMonth, inputYear))
                    {
                        Console.WriteLine("Invalid Date entered");
                        break;
                    }


                    DateTime dateParsed;
                    string stringDate = inputDay.PadLeft(2, '0') + "." + inputMonth.PadLeft(2, '0') + "." + inputYear;
                    DateTime.TryParseExact(stringDate, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateParsed);

                    if ((dateParsed.Month == 1 && dateParsed.Day == 1) || (dateParsed.Month == 1 && dateParsed.Day == 7)
                        || (dateParsed.Month == 3 && dateParsed.Day == 20) || (dateParsed.Month == 5 && dateParsed.Day == 1)
                        || (dateParsed.Month == 8 && dateParsed.Day == 3) || (dateParsed.Month == 9 && dateParsed.Day == 8)
                        || (dateParsed.Month == 10 && dateParsed.Day == 12) || (dateParsed.Month == 10 && dateParsed.Day == 23)
                        || (dateParsed.Month == 12 && dateParsed.Day == 8))
                    {
                        Console.WriteLine($"This day is {dateParsed.DayOfWeek} and is holiday");

                    }
                    else if (dateParsed.DayOfWeek >= DayOfWeek.Monday && dateParsed.DayOfWeek <= DayOfWeek.Friday)
                    {
                        Console.WriteLine($"This day is  {dateParsed.DayOfWeek} and is working day");

                    }
                    else
                    {
                        Console.WriteLine($"It's {dateParsed.DayOfWeek}, it is weekend and it is not a work day");

                    }

                    Console.WriteLine("Do you want to enter date again?(y/n)");
                    string loop = Console.ReadLine();
                    if (loop == "y")
                    {
                        enterAgain = true;
                        Console.Clear();
                        break;
                    }
                    else if (loop == "n")
                    {
                        enterAgain = false;
                        break;
                    }
                }

               

            }
        }

        private static bool IsValidDate(string day, string month, string year)
        {
            int checker;
            if (!int.TryParse(day, out checker) || !int.TryParse(month, out checker) || !int.TryParse(year, out checker))
            {
                return false;
            }
            DateTime dateParsed;
            string stringDate = day.PadLeft(2, '0') + "." + month.PadLeft(2, '0') + "." + year;
            return DateTime.TryParseExact(stringDate, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateParsed);
        }

        
    }
}
