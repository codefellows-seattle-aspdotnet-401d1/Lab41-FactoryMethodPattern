using System;
using System.Collections.Generic;
using System.Text;

namespace WallyWorkasResumeFactory
{
    class DocumentFactory
    {
        public Document CreateDocument(string type)
        {
            Document document = new Document();
            if(type == "resume")
            {
                Console.WriteLine($"You requested a {type}. Here are your pages!");

                document = new Resume();
                document.AddPages(new Page("Cover Letter"));
                document.AddPages(new Page("Skills"));
                document.AddPages(new Page("Experience"));
                document.AddPages(new Page("Education"));

                return document;
            }
            else
            {
                Console.WriteLine($"You requested a {type}. Here are your pages!");
                document = new Report();
                document.AddPages(new Page("Overview"));
                document.AddPages(new Page("Problem Domain"));
                document.AddPages(new Page("Research"));
                document.AddPages(new Page("Experiments"));
                document.AddPages(new Page("Results"));

                return document;
            }
        }
    }
}
