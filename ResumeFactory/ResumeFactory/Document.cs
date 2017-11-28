using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeFactory
{
    class Document
    {
        List<Page> Pages { get; set; }

        public Document()
        {
            Pages = new List<Page>();
        }

        // Adds a Page to the Document
        public void AddPage(Page page)
        {
            Pages.Add(page);
        }

        // Prints all current Page objects attached to the Document to the Console
        public void PrintPages()
        {
            foreach (var page in Pages)
            {
                Console.WriteLine(page.Type);
            }
        }
    }
}
