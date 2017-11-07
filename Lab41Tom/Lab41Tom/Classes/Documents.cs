using System;
using System.Collections.Generic;
using System.Text;

namespace Lab41Tom
{
    public abstract class Documents
    {
        protected abstract Pages CreateDocuments(string docType);

        public Pages RequestDocuments(string docType)
        {
            Pages page = null;

            page.CreateDocuments(docType);
            page.Write();
            page.Edit();
            page.Print();

            return page;
            
        }
    }
}
