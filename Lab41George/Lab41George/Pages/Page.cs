using System;
using System.Collections.Generic;
using System.Text;

namespace Lab41George.Pages
{
    // internal so members can inherit, but not just anyone
    // all of my pages created will inherit from here
    internal class Page
    {
        // some properties each page will have
        public string Title { get; set; }
        public string Body { get; set; }

        public Page(string author)
        {
            Author = author;
        }

        // default author so everything created is made by me!
        public string Author = "George";

        // a few methods to make things interesting
        public string GetAuthor()
        {
            return Author;
        }

        public void PrintTitle()
        {
            Console.Write($"The title is: {Title}");
        }

        public void PrintBody()
        {
            Console.Write($"The title is: {Body}");
        }
    }
}
