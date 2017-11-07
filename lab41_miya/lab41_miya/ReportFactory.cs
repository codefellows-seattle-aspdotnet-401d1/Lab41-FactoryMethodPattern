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
                case "CoverLetter":
                    Console.WriteLine("Daily report is on the printing press.");
                    page = new CoverLetter();
                    break;

                case "BackgroundCheck":
                    Console.WriteLine("We need to make sure you're not going to poison our coffee beans.");
                    page = new BackgroundCheck();
                    break;

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
