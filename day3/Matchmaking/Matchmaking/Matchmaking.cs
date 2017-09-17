using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matchmaking
{
    class Matchmaking
    {
        static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };
            var order = new List<string> {};
            
            for (int i = 0; i < boys.Count; i++)
            {
                if (i < girls.Count)
                {
                    order.Add(girls[i]);
                    order.Add(boys[i]);
                }
     
                foreach (var names in order)
                    Console.WriteLine(names);

            }
           
            Console.ReadLine();
           

        }
    }
}
