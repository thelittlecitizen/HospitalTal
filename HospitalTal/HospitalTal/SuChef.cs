using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalTal
{
    class SuChef : Cooking
    {
        public SuChef(string name, int id) : base(name, id, false, true, true,
             false, false, false)
        {

        }
    }
}
