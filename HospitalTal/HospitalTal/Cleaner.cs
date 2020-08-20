using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HospitalTal
{
   
     public class Cleaner : Workers
    {

        public Cleaner(string name, int id, bool isSimple, bool isBachir, bool isMakeDecision,
            bool inDanger, bool isManager, bool isExpert) : base(name, id, isSimple, isBachir, isMakeDecision,
             inDanger, isManager, isExpert)
        {
           
        }
        
    }
}
