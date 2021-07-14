using System;
using System.Linq;

namespace SCA_Cloud_Schhol_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input here: ");
            
            string input = Console.ReadLine();

            Console.WriteLine(RemoveDuplicates(input));

            Console.ReadLine();
        }

        static string RemoveDuplicates(string input)
        {
            return string.Join("",input.ToHashSet());
        }
    }
}