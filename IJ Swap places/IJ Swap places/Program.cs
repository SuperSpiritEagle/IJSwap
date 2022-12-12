using System;

namespace IJ_Swap_places
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jordan";
            string surname = "Maichel";
            string swap;
            Console.WriteLine($"{name} {surname}");
            swap = name;
            name = surname;
            surname = swap;
            Console.WriteLine($"{name} {surname}");
        }
    }
}
