using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalTal
{
    class BossCleaner : Cleaner
    {
        public BossCleaner(string name, int id) : base(name, id, true, false, true,
             false, false, false)
        {

        }
    }
}
