using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._13
{

    internal class Program
    {

        public static string RunApp(int[] marks, int input)
        {
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] == input)
                {
                    Console.WriteLine(marks[i] + " was found at location " + i);
                    break;
                }
                
            }
            return "Element not found";
        }




        static void Main(string[] args)
        {
            int[] marks = new int[10] { 56, 90, 76, 88, 82, 67, 98, 83, 67, 79 };

            Console.WriteLine("Enter marks to search and press Enter:");
            int input = int.Parse(Console.ReadLine());

           var result = RunApp(marks, input);
            Console.WriteLine(result);
        }

    }
}
    

