using System;

namespace lab41_miya
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Document jobSearch = new Resume();
            jobSearch.CreatePage("ReferenceLetter");
            Console.WriteLine();

            Document homework = new Report();
            homework.CreatePage("WorkHistory");
            Console.WriteLine();

            Console.Read();
        }
    }
}
