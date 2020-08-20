using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalTal
{
    class ExpertDr : Dr
    {
        public ExpertDr(string name, int id) : base(name, id, false, true, false,
             false, false, true)
        {

        }
    }
}
