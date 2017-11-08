using System;
using System.Collections.Generic;
using System.Text;

namespace Lab41Tom.Classes
{
    class DocPlace : Documents
    {
        protected override Pages CreateDocuments(string docType)
        {
            Console.WriteLine("Welcome to the Doc Place!");

            return DocumentsFactory.CreateDocuments(docType);
        }
    }
}
