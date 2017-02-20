using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ParkingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); //4 4
 
            int rows = dimensions[0];//4
            int cols = dimensions[1];//4
            long[,] parking = new long[rows, cols];
 
            string[] coodinates = Console.ReadLine().Split(' ').ToArray();// 1 2 2
 
            while (coodinates[0] != "stop")
            {
                int currentRow = int.Parse(coodinates[0]); // 1
                int currentCol = 0;
                int parkRow = int.Parse(coodinates[1]);//2
                int parkCol = int.Parse(coodinates[2]);//2
                int distance = Math.Abs(parkRow - currentRow)+1;
 
                bool isFree = parking[parkRow, parkCol] == 0;
                if (isFree)
                {
                   
                    parking[parkRow, parkCol] = 1;
                    isFree = false;
                    distance += (currentCol+parkCol);
                    Console.WriteLine(distance);
                }
                   
                else
                {
                   
                    for (parkCol = 1; parkCol < cols; parkCol++)
                    {
                        isFree = parking[parkRow, parkCol] == 0;
                        if (isFree)
                        {
                           
                            parking[parkRow, parkCol] = 1;
                            distance += (currentCol+parkCol);
                            Console.WriteLine(distance);
                            break;
                        }
                    }
                    if (!isFree)
                        Console.WriteLine($"Row {parkRow} full");
                }
               
                coodinates = Console.ReadLine().Split(' ').ToArray();
            }
 
        }
    }
}
