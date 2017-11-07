using System;
using System.Collections.Generic;
using System.Text;

namespace lab41_miya
{
    //the report class (concrete creator) inherits from document which is the creator
    class Report : Document
    {
        protected override Page NewPage(string pageType)
        {
            Console.WriteLine("Here is your daily report.");
            return ReportFactory.CreatePage(pageType);
        }
    }
}
