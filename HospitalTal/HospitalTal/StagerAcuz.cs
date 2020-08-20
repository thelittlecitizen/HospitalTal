using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalTal
{
    class StagerAcuz : Nurse
    {
        public StagerAcuz(string name, int id) : base(name, id, true, false, false,
             false, false, true)
        {

        }
    }
}
