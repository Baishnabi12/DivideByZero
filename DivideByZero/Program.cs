using System;
using System.Collections.Generic;
public class DivideZero
{
    static void Main(string[] args)
    {
        int number1 = 10;
        int number2 = 0;
        try
        {
            Console.WriteLine(number1/number2); 
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine("Invalid Input");
        }
    }
}
