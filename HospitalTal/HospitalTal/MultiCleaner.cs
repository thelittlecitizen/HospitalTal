using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalTal
{
    class MultiCleaner : Cleaner
    {
        public MultiCleaner(string name, int id) : base(name, id, false, true, false,
             false, false, false)
        {

        }
    }
}
