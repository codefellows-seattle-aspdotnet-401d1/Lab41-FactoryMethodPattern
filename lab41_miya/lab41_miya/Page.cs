using System;
using System.Collections.Generic;
using System.Text;

namespace lab41_miya
{
    public class Page
    {
        public string Name
        {
            get; set;
        }

        public string Font
        {
            get; set;
        }

        public int NumberOfPages
        {
            get; set;
        }

        public string GetName()
        {
            return Name;
        }

        public void RoughDraft()
        {
            Console.WriteLine("Once is not enough.");
        }

        public void Edit()
        {
            Console.WriteLine("A second pair of eyes is a good thing.");
        }

        public void PrintCopies()
        {
            Console.WriteLine("Always be prepared.");
        }

        public void Share()
        {
            Console.WriteLine("Here's why you should hire me.");
        }
    }
}
