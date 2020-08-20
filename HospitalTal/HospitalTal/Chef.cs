using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalTal
{
    class Chef : Cooking
    {
        public Chef(string name, int id, bool isSimple, bool isBachir, bool isMakeDecision,
            bool inDanger, bool isManager, bool isExpert) : base(name, id, false, true, true,
             false, false, true)
        {

        }
    }
}
