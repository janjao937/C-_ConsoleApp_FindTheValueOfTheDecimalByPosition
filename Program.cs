using System.Numerics;
using System;

public class DecimalPosition
{
    static void Main()
    {
        
        Console.Write("Enter x input: ");
        BigInteger x = BigInteger.Parse(Console.ReadLine());

        Console.Write("Enter y input: ");
        BigInteger y = BigInteger.Parse(Console.ReadLine());

        Console.Write("Enter decimal position: ");
        int position = int.Parse(Console.ReadLine());

        string result = FindDecimalByPosition(x, y, position);
        Console.WriteLine($"{x}/{y} | Position {position} : {result}");
    }
    private static string FindDecimalByPosition(BigInteger x, BigInteger y, int position) //BigO(n)
    {
        BigInteger integerPart = x / y; 
        BigInteger remainder = x % y;

        if (position <= 0)//If desired decimal place is Integer 
        {
            return integerPart.ToString();
        }

        // calculate round off decimal
        for (int i = 1; i <= position; i++) //BigO(n)
        {
            remainder *= 10;  //BigO(1)
            BigInteger decimalDigit = remainder / y;
            remainder = remainder % y;

            if (i == position)
            {
                return decimalDigit.ToString(); //return by position
            }
        }

        return "not found"; // not found
    }

}


