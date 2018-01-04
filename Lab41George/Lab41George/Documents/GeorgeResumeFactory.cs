using System;
using System.Collections.Generic;
using System.Text;
using Lab41George.Pages;

namespace Lab41George.Documents
{
    class GeorgeResumeFactory
    {
        public static References CreatePage(string PageType, string name)
        {
            Page page = new Page(name);

            switch (PageType)
            {
                // create new reference
                case "References":
                    Console.WriteLine("These are my references.");
                    page = new References(name);
                    break;
                default:
                    break;
            }

            return page;
        }
    }
}
