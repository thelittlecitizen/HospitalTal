using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalTal
{
     class ToxicCleaner : Cleaner
    {
        public ToxicCleaner(string name, int id,int risk) : base(name, id, true, false, true,
             true, false, true)
        {
            base.NumberRisk = risk;
        }
       
    }
}
