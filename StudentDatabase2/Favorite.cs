using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase2
{
    public class Favorite
    {
        public string food { get; set; }
        public string color { get; set; }
        public string movie { get; set; }
        public string book { get; set; }

        public string GetFavoriteFood(string food)
        {
            Console.WriteLine("What is your favorite food?");
            return food = Console.ReadLine();
            Console.WriteLine($"Your favorite food is {food}");
        }

    }
}

 
