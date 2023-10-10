using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Declare variables and then initialize to zero.
            int num1 = 0; int num2 = 0;

            // Display title as the C# console calculator app.
            Console.WriteLine("IDB Marks Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            // Ask the user to type the first number.
            Console.WriteLine("Type Mid-Mothnly number, and then press Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to type the second number.
            Console.WriteLine("Type Mothnly number, and then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\tResult - Press T :  ");

            // Use a switch statement to do the math.
            switch (Console.ReadLine().ToUpper())
            {
                case "T":
                    Console.WriteLine($"Your result: {num1 * .20} + {num2 * .80} = " + Math.Round(num1 * .20 + num2 * .80));
                    break;     
                default:
                    break;
            }
            Console.WriteLine("Thank You");
            Console.ReadKey();
        }
    }
}
