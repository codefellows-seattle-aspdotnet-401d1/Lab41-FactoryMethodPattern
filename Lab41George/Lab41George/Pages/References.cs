﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab41George.Pages
{
    // each concreate product in herits the product class (Page)
    class References : Page
    {
        public References(string author) : base(author)
        {
            Author = author;
            Title = "References?";
            Body = "I work best alone!";
        }
    }
}
