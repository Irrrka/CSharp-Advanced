using System;
using System.Collections.Generic;
using System.Linq;



public class Program
{
    public static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());//2
        Queue<long> elementsofQueue = new Queue<long>();
        elementsofQueue.Enqueue(n);
        //•	S1 = N //5
        //•	S2 = S1 + 1 //5+1
        //•	S3 = 2 * S1 + 1 //2*5+1
        //•	S4 = S1 + 2 //5+2=5+1+1
        //•	S5 = S2 + 1//5+1+1
        //•	S6 = 2 * S2 + 1//2*(5+1) +1
        //•	S7 = S2 + 2//5+1+2
        List<long> result = new List<long>();
        result.Add(n);
        while (result.Count<50)
        {
            long currentElement = elementsofQueue.Dequeue();

            long firstNumber = currentElement + 1;
            long secondNumber = currentElement * 2 + 1;
            long thirdNumber = currentElement + 2;

            elementsofQueue.Enqueue(firstNumber);
            elementsofQueue.Enqueue(secondNumber);
            elementsofQueue.Enqueue(thirdNumber);

            result.Add(firstNumber);
            result.Add(secondNumber);
            result.Add(thirdNumber);
        }
        for (int i = 0; i < 50; i++)
        {
            Console.Write(result[i] + " ");
        }
        
    }
}
