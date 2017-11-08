using System;
using System.Collections.Generic;
using System.Text;

namespace Lab41Tom.Classes
{
    public abstract class Documents
    {
        //abstract method to be inherited by children
        protected abstract Pages CreateDocuments(string docType);

        public Pages RequestDocuments(string docType)
        {
            Pages page = null;

            page = CreateDocuments(docType);
            page.Write();
            page.Edit();
            page.Print();

            return page;
            
        }
    }
}
