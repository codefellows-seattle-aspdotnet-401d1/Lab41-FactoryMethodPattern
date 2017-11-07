using System;
using System.Collections.Generic;
using System.Text;

namespace lab41_miya
{
    class ResumeFactory
    {
        public static Page CreatePage(string pageType)
        {
            Page page = new Page();

            switch (pageType)
            {
                //create a cover letter
                case "CoverLetter":
                    Console.WriteLine("Who reads these??");
                    page = new CoverLetter();
                    break;

                 //create a reference letter
                case "ReferenceLetter":
                    Console.WriteLine("Did you leave your previous employer on good terms?");
                    page = new BackgroundCheck();
                    break;

                //complete the work history form
                case "WorkHistory":
                    Console.WriteLine("Where have you worked for the last 5 years?");
                    page = new WorkHistory();
                    break;

                default:
                    break;
            }
            return page;
        }
    }
}
