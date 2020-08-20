using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalTal
{
     class HeadManagerProf : SManagerProf
    {
        public HeadManagerProf(string name, int id, int risk) : base(name, id, false, true, true,
             false, true, false)
        {
            base.NumberRisk = risk;
        }
    }
}
