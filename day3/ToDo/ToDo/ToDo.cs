using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    class Program
    {
        static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";
            string myToDo = "My ToDo:\n";
            string download = " - Download games\n";
            string diablo = " - Diablo\n";

            StringBuilder wholeToDo = new StringBuilder(todoText);
            wholeToDo.Insert(0, myToDo);
            wholeToDo.Insert(wholeToDo.Length, download);
            var a = wholeToDo.Length;
            string b = diablo.PadLeft(10);
            wholeToDo.Insert(a, b + diablo);
            

           

           
            Console.WriteLine(wholeToDo);
            Console.ReadLine();
        }
    }
}
