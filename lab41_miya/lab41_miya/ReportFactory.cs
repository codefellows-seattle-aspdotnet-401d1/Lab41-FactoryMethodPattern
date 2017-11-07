using System;
using System.Collections.Generic;
using System.Text;

namespace lab41_miya
{
    class ReportFactory
    {
        public static Page CreatePage(string pageType)
        {
            Page page = new Page();

            switch (pageType)
            {
                //create a cover letter
                case "CoverLetter":
                    Console.WriteLine("Don't bother writing one. It's before our time.");
                    page = new CoverLetter();
                    break;

                //answer honestly - we will find out
                case "BackgroundCheck":
                    Console.WriteLine("We need to make sure you're not going to poison our coffee beans while we're not looking.");
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
