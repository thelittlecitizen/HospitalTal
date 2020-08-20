using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalTal
{
    class MidwifeAcuz : Nurse
    {
        public MidwifeAcuz(string name, int id) : base(name, id, false, false, false,
             false, false, true)
        {

        }
    }
}
