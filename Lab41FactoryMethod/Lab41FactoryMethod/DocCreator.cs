using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Lab41FactoryMethod
{
    public abstract class DocCreator
    {
        //this is the factory method
        protected abstract Document CreateDocument(string docTypes);

        public Document StartDocument( string docTypes)
        {
            Document document = null;

            document = CreateDocument(docTypes);
            document.Body();

            return document;
        }
    }
}
