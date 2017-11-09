using Lab41FactoryMethod.Classes.Documents;
using Lab41FactoryMethod.Classes.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab41FactoryMethod.Classes.Factorys
{
    class DocMakerFactory
    {
        public Document CreateDocument(string docType)
        {
            Document document = new Document();
            switch(docType)
            {
                case "Resume":
                    document = new Resume();
                    Console.WriteLine("Make a resume");
                    break;

                case "Report":
                    document = new Report();
                    Console.WriteLine("Make a report");
                    break;

                case "License":
                    document = new License();
                    Console.WriteLine("Make a License");
                    break;

                case "Will":
                    document = new Will();
                    Console.WriteLine("Make a Will");
                    break;
            }
            return document;
        }
    }
}
