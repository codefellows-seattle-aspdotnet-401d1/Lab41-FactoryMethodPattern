using System;
using System.Collections.Generic;
using System.Text;

namespace lab41_miya
{
    class Resume : Document
    {
        protected override Page NewPage(string pageType)
        {
            Console.WriteLine("I've been expecting your call.");
            return ResumeFactory.CreatePage(pageType);
        }
    }
}
