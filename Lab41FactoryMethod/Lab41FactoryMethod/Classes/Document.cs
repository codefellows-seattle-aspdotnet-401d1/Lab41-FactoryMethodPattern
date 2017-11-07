using System;
using System.Collections.Generic;
using System.Text;

namespace Lab41FactoryMethod.Classes
{
    public class Document
    {
        public string DocType { get; set; }
        public string Author { get; set; }
        public List<string> Pages = new List<string>();
        public string GetType()
        {
            return DocType;
        }

        public void Body()
        {
            string d = GetType();
            Console.WriteLine($"This {d} Document contains...");
            foreach(string pag in Pages)
            {
                Console.WriteLine(pag);
            }
        }
    }
}
