using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix
    {
        static void Main(string[] args)
        {
            int[,] Matrix = new int[4, 4];

            int rowLength = Matrix.GetLength(0);
            int colLength = Matrix.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {

                for (int j = 0; j < colLength; j++)
                {
                    if (i == j)
                    {
                        Matrix[i, j] = 1;
                    }

                    Console.Write(Matrix[i, j]);
                }
                Console.WriteLine();
            }

             Console.ReadLine();

        
        }
    }
}



        




