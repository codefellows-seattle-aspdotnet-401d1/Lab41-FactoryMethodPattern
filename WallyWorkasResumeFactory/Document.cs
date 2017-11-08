using System;
using System.Collections.Generic;
using System.Text;

//Constructs the specified document
namespace WallyWorkasResumeFactory
{
    public class Document
    {
        //holds pages specific to the document type
        List<Page> Pages { get; set; }

        public Document()
        {
            Pages = new List<Page>();
        }

        //Adds new pages to the page list
        public void AddPages(Page page)
        {
            Pages.Add(page);
        }

        //prints the pages
        public void PrintPages()
        {
            foreach (var item in Pages)
            {
                Console.WriteLine(item.Type);
            }
        }
    }
}
