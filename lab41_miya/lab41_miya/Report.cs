using System;
using System.Collections.Generic;
using System.Text;

namespace lab41_miya
{
    class Report : Document
    {
        protected override Page NewPage(string pageType)
        {
            Console.WriteLine("Here is your daily report.");
            return ReportFactory.CreatePage(pageType);
        }
    }
}
