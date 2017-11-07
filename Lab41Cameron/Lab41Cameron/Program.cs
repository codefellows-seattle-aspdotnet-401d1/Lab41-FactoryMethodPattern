using Lab41Cameron.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab41Cameron
{
    class Program
    {
        //Run Program with Completed Resume
        static void Main(string[] args)
        {
            //New instance of resume
            Resume ricoResume = new Resume();

            //New Software Developer Resume
            NeedAJob ricoJob = new Apple();

            Console.WriteLine();
            ricoJob.SubmitResume("Software Developer");

            Console.Read();
        }
    }
}
