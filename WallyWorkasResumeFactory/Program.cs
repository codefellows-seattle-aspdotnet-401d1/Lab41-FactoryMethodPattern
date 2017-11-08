using System;

namespace WallyWorkasResumeFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //introduction to program
                Console.WriteLine("Welcome to Wally Workas Document factory!");
                Console.WriteLine("Please enter resume or report, and we'll whip you up a shiny new document! ");
                //user input for specifying desired document
                string input = Console.ReadLine();
                //creates a new ddocument factory for proccessing the document request
                DocumentFactory myFactory = new DocumentFactory();
                //creates the document in the factory
                Document myDocument = myFactory.CreateDocument(input);
                //prints a list of pages in the new document
                myDocument.PrintPages();
                Console.ReadLine();
            }
        }
    }
}
