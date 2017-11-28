using System;

namespace ResumeFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize a DocumentFactory for making documents
            DocumentFactory factory = new DocumentFactory();

            // Ask user for a document type
            Console.WriteLine("Please enter a document type to create:");
            string response = Console.ReadLine();

            // Pass user response to factory to create document
            Document document = factory.CreateDocument(response);

            // Print the pages of the document created
            document.PrintPages();
            Console.Read();
        }
    }
}
