using Lab41Tom.Classes;
using System;

namespace Lab41Tom
{
    class Program
    {
        static void Main(string[] args)
        {
            Documents tomsDocs = new DocPlace();
            tomsDocs.RequestDocuments("Resume");

            Console.Read();
        }
    }
}
