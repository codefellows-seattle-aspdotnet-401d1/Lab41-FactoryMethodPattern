using System;
using System.Collections.Generic;
using System.Text;

namespace Lab41Tom.Classes
{   
    //inheriting from Pages
    class ResumePage : Pages
    {
        public ResumePage()
        {
            Font = "Verdana";
            TextColor = "black";
            NumberOfPages = 2;
            //PageTypes unique to Resume
            PageTypes.Add("- Cover Letter");
            PageTypes.Add("- References");
            PageTypes.Add("- Work History");
            PageTypes.Add("- Summary");
        }
    }
}
