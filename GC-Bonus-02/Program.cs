using System;

namespace GC_Bonus_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateToday = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);

            int year, month, day;

            while (true)
            {
                Console.Write("What year were you born? (YYYY) ");
                year = CheckValidity();

                if (year > 1900 && year < 2010)
                {
                    break;
                }

                Console.WriteLine("That doesn't seem right. Please try again"); 
                Console.WriteLine("with a year between 1901 and 2010.");
            } 

            while (true)
            {
                Console.Write("What month were you born? (in digits - MM): ");
                month = CheckValidity();

                if (month > 0 && month < 13)
                {
                    break;
                }

                Console.WriteLine("That doesn't seem right. Please try again");
                Console.WriteLine("with an integer between 01 and 12.");
            }

            while (true)
            {
                Console.Write("What day were you born? (DD) ");
                day = CheckValidity();

                if (day > 0 && day < 32)
                {
                    break;
                }

                Console.WriteLine("That doesn't seem right. Please try again");
                Console.WriteLine("with an integer between 01 and 31.");

            }


            var birthDate = new DateTime(year, month, day);

            var daysPast =  dateToday - birthDate;

            int daysLived = Convert.ToInt32(daysPast.TotalDays);

           
            Console.WriteLine($"\nOh my! You're lived...\n");
            Console.WriteLine($"  {daysLived} days");
            Console.WriteLine($"  {daysLived * 24} hours");
            Console.WriteLine($"  {daysLived * 24 * 60} minute");
            Console.WriteLine("   or");
            Console.WriteLine($"  {daysLived * 24 * 60 * 60} seconds!");
            Console.WriteLine("  (assuming it's midnight and you were born at midnight, of course.)");


            if (month == DateTime.Today.Month && day == DateTime.Today.Day)
            {
                Console.WriteLine("\nAnd OHMYGOSH! Happy Birthday!");
            }






        }



        // Method to check validity of user input.
        static int CheckValidity()
        {

            // Keep asking for user input until valid number is returned.
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




            //// try to convert input into intiger, else make year 1967
            //if(!Int32.TryParse(yearString, out year))
            //{
            //    Console.WriteLine("That's not a valid year. Let's just say you were born in 1967, because, reasons!");
            //    year = 1967;
            //}

            //// check for obvious wrong years and make it 1967 instead
            //if (year < 1900 || year > 2009)
            //{
            //    Console.WriteLine("Your birthyear seems odd. Let's just say you were born in 1967, becasue, reasons!");
            //    year = 1967;
            //}

            //Console.WriteLine($"The year is {year}");

    }

}
