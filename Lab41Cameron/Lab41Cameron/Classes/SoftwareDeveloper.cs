using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab41Cameron.Classes
{
    class SoftwareDeveloper : Resume
    {
        //New Resume for a Software Developer. Properties from Resume class.
        public SoftwareDeveloper()
        {
            Name = "Rico Suave";
            Email = "  needMore@chestHair.com";
            Phone = "  555 - 555 - 5555";
            Position = "Software Developer";
            Summary = "  I think I can be good at this, right? If your lucky, I will even get the job done";
            WorkHistory.Add("  Salsa Dancer");
            WorkHistory.Add("  Handy Man");
            Experience.Add("  Online Dating");
            Experience.Add("  Fix'd a ssd hard drive");
        }
    }
}
