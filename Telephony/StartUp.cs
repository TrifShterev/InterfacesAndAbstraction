using System;
using System.IO;

namespace Telephony
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var phoneNumbers = Console.ReadLine().Split();
            var sites = Console.ReadLine().Split();

            foreach (var number in phoneNumbers)
            {
                if (number.Length == 7)
                {
                    try
                    {
                        ICall stationaryPhone = new StationaryPhone(number);
                        Console.WriteLine(stationaryPhone.Calling());
                    }
                    catch (ArgumentException ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                    

                }
                else if (number.Length == 10)
                {
                    try
                    {
                        ICall smartPhone = new Smartphone(number);
                        Console.WriteLine(smartPhone.Calling());
                    }
                    catch (ArgumentException ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                     
                }

            }
            

            foreach (var site in sites)
            {
                try
                {
                    Smartphone smartphone = new Smartphone() { Site = site };
                    Console.WriteLine(smartphone.Browsing());
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                }
               
            }
            
        }



    }
}

