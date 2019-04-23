using System;

namespace GC_Bonus_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // create integers for user to provide year, month and day of birth
            int year, month, day;

            // validate user-inputted data to be integers and to be real
            // ie. no month 13 or day 65
            while (true)
            {
                Console.Write("What year were you born? (YYYY) ");
                year = CheckValidity();

                if (year > 1900 && year < 2011)
                {
                    break;
                }

                Console.WriteLine("That can't be right. Please try again"); 
                Console.WriteLine("with a year between 1901 and 2010.\n");
            } 

            while (true)
            {
                Console.Write("What month were you born? (in digits - MM): ");
                month = CheckValidity();

                if (month > 0 && month < 13)
                {
                    break;
                }

                Console.WriteLine("That's not right. Please try again");
                Console.WriteLine("with an integer between 01 and 12.\n");
            }

            while (true)
            {
                Console.Write("What day were you born? (DD) ");
                day = CheckValidity();

                if (day > 0 && day < 32)
                {
                    break;
                }

                Console.WriteLine("That can't be right. Please try again");
                Console.WriteLine("with an integer between 01 and 31.");

            }

            // get today as a DATETIME object
            var dateToday = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);

            // convert user-entered brithday information into a DATETIME object
            var birthDate = new DateTime(year, month, day);

            // get number of days as TIMESPAN object
            var daysPast =  dateToday - birthDate;

            // convert days into an integer
            int daysLived = Convert.ToInt32(daysPast.TotalDays);

           
            Console.WriteLine($"\nOh my! You're lived...\n");
            Console.WriteLine($"  {daysLived} days\n");
            Console.WriteLine("And assuming it's midnight and you were born at midnight...\n");

            Console.WriteLine($"  {daysLived * 24} hours");
            Console.WriteLine($"  {daysLived * 24 * 60} minute");
            Console.WriteLine("   or");
            Console.WriteLine($"  {daysLived * 24 * 60 * 60} seconds!");


            // check to see if today is user's birthday
            if (month == DateTime.Today.Month && day == DateTime.Today.Day)
            {
                Console.WriteLine("\nAnd OHMYGOSH! Happy Birthday!");
            }

        }



        // Method to check validity of user input.
        static int CheckValidity()
        {

            // Keep asking for user input until integer is returned.
            while (true)
            {

                string userInput = Console.ReadLine();

                try
                {
                    int output = Convert.ToInt32(userInput);
                    return output;

                }
                catch (Exception)
                {
                    Console.Write("Oops. That's not a valid input. Please try again: ");
                }


            }
        
        }

    }

}
