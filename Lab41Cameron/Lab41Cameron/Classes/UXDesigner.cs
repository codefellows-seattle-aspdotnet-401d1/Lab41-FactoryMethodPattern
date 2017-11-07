using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab41Cameron.Classes
{
    class UXDesigner : Resume
    {
        //New Resume for a UX Designer. Properties from Resume class.
        public UXDesigner()
        {
            Name = "Benj Grinker";
            Email = "needMore@Grink.com";
            Phone = "554 - 554 - 5544";
            Position = "UX Designer";
            Summary = "I swear Im always on time, don't call my previous job.";
            WorkHistory.Add("Night Stocker");
            WorkHistory.Add("Day Sleeper");
            Experience.Add("Painted the Sky");
            Experience.Add("Gimp Genius");
        }
    }
}
