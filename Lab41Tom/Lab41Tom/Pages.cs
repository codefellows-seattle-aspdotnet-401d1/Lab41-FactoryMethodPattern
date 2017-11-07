using System;
using System.Collections.Generic;
using System.Text;

namespace Lab41Tom
{
    public class Pages
    {
        public string Paper { get; set; }

        public void Write()
        {
            Console.WriteLine("Writing document");
        }

        public void Edit()
        {
            Console.WriteLine("Editing document");
        }

        public void Print()
        {
            Console.WriteLine("Printing document");
        }
    }
}
