using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalTal
{
    public abstract class Workers
    {
        public string Name;
        int Id;
        //int NumberRisk;
        // double Salary;
        //bool IsProf;
        //bool IsAdmin;
        bool IsSimple;
        bool IsBachir;
        bool IsMakedecision;
        bool InDanger;
        bool IsManager;
        bool IsExpert;
        //private int numerRisk;

        public double Salary { get; set; }
        public int NumberRisk { get; set;  }

        public Workers(string name, int id, /*bool isProf, bool isAdmin,*/ bool isSimple, bool isBachir, bool isMakeDecision,
            bool inDanger, bool isManager, bool isExpert)
        {
            Name = name;
            Id = id;
            //Salary = salary;
            //IsProf = isProf;
            //IsAdmin = isAdmin;
            IsSimple = isSimple;
            IsBachir = isBachir;
            IsMakedecision = isMakeDecision;
            InDanger = inDanger;
            IsManager = isManager;
            IsExpert = isExpert;

        }

        public virtual double MoneyCalc(int hour, double pricePerHour)
        {
            double sum= 0;
            if (IsSimple== true)
                sum= sum+ hour * pricePerHour;
            if (IsBachir == true)
                sum= sum+ 1.5 * (hour * pricePerHour);
            if (IsMakedecision == true)
                sum= sum+ 1.5 * (200 * pricePerHour) + hour * pricePerHour;
            if (InDanger == true)
                sum= sum + (NumberRisk / 100) * (hour * pricePerHour) + (hour * pricePerHour);
            if (IsManager == true)
                return Salary;
            if (IsExpert == true)
                sum= sum+ 1.3 * (hour * pricePerHour);
            return sum;

           

        }
       
        

        
           

    }
}
