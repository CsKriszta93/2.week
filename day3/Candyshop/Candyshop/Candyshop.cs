using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candyshop
{
    class Candyshop
    {
        static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            list[1] = "Croissant";
            list[3] = "Ice cream";

            foreach (var candy in list)
            {
                Console.WriteLine(candy);

            }

            Console.ReadLine();

            //result[1] = "Croissant";
            //result[3] = "Ice cream";



        }
    }
}
