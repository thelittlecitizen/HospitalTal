using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalTal
{
    class Cooking : Workers
    {
        public Cooking(string name, int id, bool isSimple, bool isBachir, bool isMakeDecision,
             bool inDanger, bool isManager, bool isExpert) : base(name, id, isSimple, isBachir, isMakeDecision,
              inDanger, isManager, isExpert)
        {

        }
    }
}
