using System;
using System.Collections.Generic;
using System.Text;

namespace Lab41George.Pages
{
    // each concreate product in herits the product class (Page)
    class CoverLetter : Page
    {
        public CoverLetter()
        {
            Title = "Cover Letter";
            Body = "I'm really interested in this position because reeasons.";
        }
    }
}
