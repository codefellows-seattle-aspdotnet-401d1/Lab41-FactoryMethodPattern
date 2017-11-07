using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab41Cameron.Classes
{
    public abstract class NeedAJob
    {
        protected abstract Resume NewResume(string jobtype);

        //Upon submitting resume. Program will run this . 

        public Resume SubmitResume(string jobtype)
        {
            Resume resume = null;

            resume = NewResume(jobtype);
            resume.ApplicantInfo();
            resume.Eligibility();
            resume.SpellCheck();
            resume.ContactInfo();
            resume.Complete();

            return resume;
        }
       
    }
}
