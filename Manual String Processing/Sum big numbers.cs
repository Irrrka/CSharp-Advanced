using System;
using System.Text;
class SumBigNum
{
    static void Main(string[] args)
    {
        string number1 = Console.ReadLine();
        string number2 = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        string n1 = number1;
        string n2 = number2;
        int remainder = 0;
        if (number1.Length<number2.Length)
            n1 = number1.PadLeft(number2.Length, '0');
        else if (number1.Length > number2.Length)
            n2 = number2.PadLeft(number1.Length, '0');

        for (int i = n1.Length-1; i >= 0; i--)
        {
            int d1 = int.Parse(n1[i].ToString())+remainder;
            int d2 = int.Parse(n2[i].ToString());
            remainder = d1+d2>=10 ? 1 : 0;
            sb.Append((d1 + d2)%10);
            if (i==0 && remainder==1)
                sb.Append(remainder);
        }
        string result = null;
        for (int i = sb.Length-1; i >= 0; i--)
        {
            result += sb[i];
        }
        Console.WriteLine(result.TrimStart('0'));
    }
}
