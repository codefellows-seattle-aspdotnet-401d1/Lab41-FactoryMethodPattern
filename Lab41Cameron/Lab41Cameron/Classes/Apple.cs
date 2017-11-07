using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab41Cameron.Classes
{
    public class Apple : NeedAJob
    {
        protected override Resume NewResume(string jobtype)
        {
            Console.WriteLine("Welcome to Apple. Your resume will most likely never get looked at!");
            return AppleJobPost.NewResume(jobtype);
        }
    }
}
