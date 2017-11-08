using Lab41Tom.Classes;
using System;

namespace Lab41Tom
{
    class Program
    {
        static void Main(string[] args)
        {
            Documents tomsDocs = new DocPlace();
            //RequestDocuments method from Documents class, with docType of "Resume"
            tomsDocs.RequestDocuments("Resume");

            Console.Read();
        }
    }
}
