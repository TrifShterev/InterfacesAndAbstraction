using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace BorderControl
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<IName> citizens = new List<IName>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input.Length==4)
                {
                 Citizen citizen = new Citizen(input[0], int.Parse(input[1]), input[2],input[3]);
                    citizens.Add(citizen);
                }
                else if (input.Length==3)
                {
                    Rebel rebel = new Rebel(input[0],int.Parse(input[1]),input[2]);
                    citizens.Add(rebel);
                }
            }


            string names;
            while ((names=Console.ReadLine())!="End")
            {
                for (int i = 0; i < citizens.Count; i++)
                {
                    if (citizens[i].Name==names)
                    {
                        citizens[i].BuyFood();
                    }
                }
               
            }
          var totalFood=  citizens
                .Where(x => x.Food != 0)
                .ToList();
            var total = 0;
            foreach (var item in totalFood)
            {
                total += item.Food;
            }
            Console.WriteLine(total);
        }
    }
}
