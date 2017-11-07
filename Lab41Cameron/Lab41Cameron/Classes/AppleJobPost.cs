using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab41Cameron.Classes
{
    class AppleJobPost
    {
        public static Resume NewResume(string jobType)
        {
            Resume resume = new Resume();

            //Determines the jobType for each resume.
            switch (jobType)
            {
                case "Software Developer":
                    resume = new SoftwareDeveloper();
                    Console.WriteLine("You are applying as a Software Developer.");
                    Console.WriteLine();
                    break;


                case "UX Designer":
                    resume = new UXDesigner();
                    Console.WriteLine("You are applying for A UX Designer.");
                    Console.WriteLine();
                    break;

                default:
                    break;
            }

            return resume;
        }
    }
}
