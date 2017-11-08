using System;
using System.Collections.Generic;
using System.Text;

namespace Lab41Tom.Classes
{
    public class Pages
    {
        public string Font { get; set; }
        public string TextColor { get; set; }
        public int NumberOfPages { get; set; }
        public List<string> PageTypes = new List<string>();


        public void Write()
        {
            Console.WriteLine("Writing pages");
            foreach (string p in PageTypes)
            {
                Console.WriteLine(p);
            }
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
