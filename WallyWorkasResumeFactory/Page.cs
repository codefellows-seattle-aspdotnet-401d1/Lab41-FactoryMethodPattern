using System;
using System.Collections.Generic;
using System.Text;

namespace WallyWorkasResumeFactory
{
    //Individual pages
    //created in the factory and added to the document
    public class Page
    {
        public string Type { get; set; }

        public Page(string type)
        {
            Type = type;
        }
    }
}
