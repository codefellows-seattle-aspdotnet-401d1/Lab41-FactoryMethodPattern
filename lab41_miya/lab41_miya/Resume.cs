using System;
using System.Collections.Generic;
using System.Text;

namespace lab41_miya
{
    //the resume class (concrete creator) inherits from document which is the creator
    class Resume : Document
    {
        protected override Page NewPage(string pageType)
        {
            Console.WriteLine("I've been expecting your call.");
            return ResumeFactory.CreatePage(pageType);
        }
    }
}
