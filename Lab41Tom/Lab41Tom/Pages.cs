using System;
using System.Collections.Generic;
using System.Text;

namespace Lab41Tom
{
    public class Pages
    {
        public string Font { get; set; }
        public string TextColor { get; set; }
        public int NumberOfPages { get; set; }

        public void Write()
        {
            Console.WriteLine("Writing pages");
        }

        public void Edit()
        {
            Console.WriteLine("Editing pages");
        }

        public void Print()
        {
            Console.WriteLine("Printing pages");
        }
    }
}
