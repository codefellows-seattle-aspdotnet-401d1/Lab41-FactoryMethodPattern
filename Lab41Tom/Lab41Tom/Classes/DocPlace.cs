using System;
using System.Collections.Generic;
using System.Text;

namespace Lab41Tom.Classes
{
    class DocPlace : Documents
    {
        //overriding abstract method from Documents
        protected override Pages CreateDocuments(string docType)
        {
            Console.WriteLine("Welcome to the Doc Place!");

            return DocumentsFactory.CreateDocuments(docType);
        }
    }
}
