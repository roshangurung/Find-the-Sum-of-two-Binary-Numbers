using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication
{
    class Program///This C# program we are reading the first and second binary numbers using ‘b1’ and ‘b2’ variables respectively. Here Binary number is a number that can be represented using only two numeric symbols 0 and 1. Using while loop check the condition that both the values of ‘b1’ or ‘b2’variables are not equal to 0.///
    {
        static void Main(string[] args)
        {
            int b1, b2;
            int i = 0, rem = 0;
            int[] sum = new int[20];
            Console.WriteLine("Enter the first binary number: ");
            b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second binary number: ");
            b2 = int.Parse(Console.ReadLine());
            while (b1 != 0 || b2 != 0)////If the condition is true then execute the iteration of the loop. Compute the modulus of the value of ‘b1’ variable by 10 and the value of ‘b2’ variable by 10. Compute the summation of both the values. Divide the resulted value by 2.///
            {
                sum[i++] = (b1 % 10 + b2 % 10 + rem) % 2;
                rem = (b1 % 10 + b2 % 10 + rem) / 2;
                b1 = b1 / 10;
                b2 = b2 / 10;
            }
            if (rem != 0)////If the condition is true then execute the iteration of the loop. Compute the modulus of the value of ‘b1’ variable by 10 and the value of ‘b2’ variable by 10. Compute the summation of both the values. Divide the resulted value by 2.//
                sum[i++] = rem;
            --i;
            Console.WriteLine("Sum of two binary numbers: ");
            while (i >= 0)
                Console.Write("{0}", sum[i--]);
            Console.ReadLine();
        }
    }
}
///Output:Enter the first binary number:100
///Enter the second binary number:110
//Sum of two binary numbers:1010