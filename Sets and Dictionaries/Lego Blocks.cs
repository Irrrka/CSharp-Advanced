using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoBlocks
{
    class Lego
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] firstLegoBlock = new int[n][];
            int[][] secondLegoBlock = new int[n][];

            for (int row = 0; row < n; row++)
                firstLegoBlock[row] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int row = 0; row < n; row++)
                secondLegoBlock[row] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            bool isMatrixValid = true;
            int maxLenght = firstLegoBlock[0].Length + secondLegoBlock[0].Length;
            for (int row = 1; row < n; row++)
            {
                int currentLenght = firstLegoBlock[row].Length + secondLegoBlock[row].Length;
                if (currentLenght!=maxLenght)
                {
                    isMatrixValid = false;
                    break;
                }
            }
            if (isMatrixValid)
            {
                for (int row = 0; row < n; row++)
                    Array.Reverse(secondLegoBlock[row]);
                for (int row = 0; row < n; row++)
                    firstLegoBlock[row].Concat(secondLegoBlock[row]).ToArray();
                for (int row = 0; row < n; row++)
                    Console.WriteLine("[{0}]", string.Join(", ", firstLegoBlock[row]));
            }
            else
            {
                int cellCounter = 0;
                for (int row = 0; row < n; row++)
                {
                    cellCounter += firstLegoBlock[row].Length;
                    cellCounter += secondLegoBlock[row].Length;
                }
                    Console.WriteLine("The total number of cells is: {0}", cellCounter);
            }


        }
    }
}
