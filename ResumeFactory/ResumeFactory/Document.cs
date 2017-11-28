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

        public void AddPage(Page page)
        {
            Pages.Add(page);
        }

        public void PrintPages()
        {
            foreach (var page in Pages)
            {
                Console.WriteLine(page.Type);
            }
        }
    }
}
