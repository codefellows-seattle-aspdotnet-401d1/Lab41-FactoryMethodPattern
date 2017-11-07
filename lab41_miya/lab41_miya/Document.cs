using System;
using System.Collections.Generic;
using System.Text;

namespace lab41_miya
{
    public abstract class Document
    {
        protected abstract Page NewPage(string pageType) { }

        public Page CreatePage()
        {
            Page page = null;

            page = NewPage(pageType);
            page.RoughDraft();
            page.Edit();
            page.PrintCopies();
            page.Share();
        }
        
    }
}
