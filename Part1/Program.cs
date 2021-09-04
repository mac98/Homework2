/// Chapter No. 2		Exercise No. 1
/// File Name: Program.cs
/// @author: Marcus Moore
/// Date:  September 3, 2021
///
/// Problem Statement: Starting with two string variables containing your first and last name, convert
///                    your name to pig latin.
/// 
/// Overall Plan:
/// 1) Create two strings: first_name and last_name, that contain my first and last name respectively.
/// 2) Create another string called pig_first.
/// 3) Set pig_first equal to the second letter of first_name, set to uppercase.
/// 4) Add another substring of first_name to pig_first that contains every letter after the second
///    letter, all remaining lowercase.
/// 5) Add a final substring to pig_first only containing the first letter of first_name.
/// 6) Add the string literal "ay" to the end of pig_first.
/// 7) Create another string called pig_last.
/// 8) Repeat the same process as what happened to pig_first with pig_last, using the last_name string
///    in place of the first_name string.
/// 9) Write the pig_first and pig_last strings to the console.
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            string first_name = "marcus";
            string last_name = "moore";
            string pig_first = first_name.Substring(1, 1).ToUpper() + first_name.Substring(2) + first_name.Substring(0, 1) + "ay";
            string pig_last = last_name.Substring(1, 1).ToUpper() + last_name.Substring(2) + last_name.Substring(0, 1) + "ay";
            Console.WriteLine(pig_first + " " + pig_last);
            Console.ReadLine();
        }
    }
}
