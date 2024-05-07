using System;
using System.Net;

namespace birthdayCalculator// okay 

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your birthdate? Please formate it in YYYY-MM-DD");
            string response = Console.ReadLine();
            while (true)
            {
                if(DateTime.TryParse(response, out var birthday))
                {
                    TimeSpan age = DateTime.Now - birthday;
                    int ageInDays = (int)age.TotalDays;

                    Console.WriteLine($"Your age in days it {ageInDays} ");

                    break;
                }
                else
                {
                    Console.WriteLine("Something when wrong, Please try again. Formatting it YYYY-MM-DD");
                }
                Console.WriteLine("Press any key to continue");
            }
        }
    }
}