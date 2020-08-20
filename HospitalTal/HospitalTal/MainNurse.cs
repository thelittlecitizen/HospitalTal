using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalTal
{
    class MainNurse : Nurse
    {
        public MainNurse(string name, int id) : base(name, id, false, true, true,
             false, false, false)
        {

        }

    }
}
