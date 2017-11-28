using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeFactory
{
    class DocumentFactory
    {
        public Document CreateDocument(string type)
        {
            switch (type)
            {
                case "resume":
                    Document resume = new Resume();
                    resume.AddPage(new Page("Cover Letter"));
                    resume.AddPage(new Page("Personal Statement"));
                    resume.AddPage(new Page("Skills"));
                    resume.AddPage(new Page("Experience"));
                    resume.AddPage(new Page("Education"));
                    return resume;
                case "report":
                    Document report = new Report();
                    report.AddPage(new Page("Introduction"));
                    report.AddPage(new Page("Overview"));
                    report.AddPage(new Page("Statement"));
                    report.AddPage(new Page("Arguments"));
                    report.AddPage(new Page("Data"));
                    report.AddPage(new Page("Conclusion"));
                    report.AddPage(new Page("Sources and Bibliography"));
                    return report;
                default:
                    Document document = new Document();
                    return document;
            }
        }
    }
}
