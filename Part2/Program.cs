/// Chapter No. 2		Exercise No. 2
/// File Name: Program.cs
/// @author: Marcus Moore
/// Date:  September 3, 2021
///
/// Problem Statement: Have the user give a temperature in Fahrenheit and convert it to Celsius.
/// 
/// Overall Plan:
/// 1) Create a string called input.
/// 2) Write a message to the console prompting the user to input a temperature in Fahrenheit.
/// 3) Store the user's input in the variable input.
/// 4) Create an int called temp_Cels.
/// 5) Set temp_Cels to input parsed as an integer.
/// 6) Set temp_Cels to itself minus 32 times 5 divided by 9 in that order.
/// 7) Write temp_Cels to the console.
/// 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.Write("Enter a temperature in Fahrenheit you would like converted to Celsius: ");
            input = Console.ReadLine();
            double temp_Cels = (double.Parse(input) - 32) * 5 / 9;
            temp_Cels = Math.Round(temp_Cels, 1);
            Console.WriteLine(input + " Degrees Fahrenheit = " + temp_Cels + " Degress Celsius");
            Console.ReadLine();
        }
    }
}
