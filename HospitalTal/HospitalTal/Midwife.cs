using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalTal
{
    class Midwife : Nurse
    {
        public Midwife(string name, int id) : base(name, id, false, true, false,
             false, false, false)
        {

        }
    }
}
