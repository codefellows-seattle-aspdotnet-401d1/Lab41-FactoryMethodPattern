using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab41Cameron.Classes
{
    //Setting properties for each resume.
    public class Resume
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Position { get; set; }
        public string Summary { get; set; }
        public List<string> WorkHistory = new List<string>();
        public List<string> Experience = new List<string>();

        //Printing Applicants Basic info
        public void ApplicantInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Email);
            Console.WriteLine(Phone);
            Console.WriteLine();
        }

        //Printing each list item in work history and experience.
        public void Eligibility()
        {
            Console.WriteLine("Reviewing Work History");

            foreach(string job in WorkHistory)
            {
                Console.WriteLine(job);
            }
            Console.WriteLine();
            Console.WriteLine("Reviewing Previous Experience");
            foreach (string project in Experience)
            {
                Console.WriteLine(project);
            }
            Console.WriteLine();
        }

        public void SpellCheck()
        {
            Console.WriteLine("All words appear to be spelled correctly.");
            Console.WriteLine();
        }

        public void ContactInfo()
        {
            Console.WriteLine("We encourage you to double check your contact information.");
            Console.WriteLine();
        }

        public void Complete()
        {
            Console.WriteLine("Your resume is complete! Thanks for Applying");
            Console.WriteLine();
        }

    }
}
