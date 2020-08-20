using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalTal
{
    class HeadManagerAdmin : Workers
    {
        public HeadManagerAdmin(string name, int id, bool isSimple, bool isBachir, bool isMakeDecision,
               bool inDanger, bool isManager, bool isExpert) : base(name, id, isSimple, isBachir, isMakeDecision,
                inDanger, isManager, isExpert)
        {

        }
    }
}
