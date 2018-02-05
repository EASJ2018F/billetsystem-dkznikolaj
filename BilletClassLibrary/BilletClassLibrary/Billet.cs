using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BilletClassLibrary
{
    public class Billet
    {
        public bool Brobizz;
        private DayOfWeek _dato;
        private double _pris = 120;
        private double rabatBrobizz = 0.95;
        private double rabatWeekend = 0.80;
        
        public DayOfWeek Dato
        {
            get { return DayOfWeek.Sunday; }
            set { _dato = value; }
        }

        public double Pris
        {
            get {
                if (Brobizz == true && (Dato == DayOfWeek.Saturday || Dato == DayOfWeek.Sunday)) return _pris *= rabatWeekend *= rabatBrobizz;
                else if (Dato == DayOfWeek.Saturday || Dato == DayOfWeek.Sunday) return _pris *= rabatWeekend;
                
                return _pris; 
            }
            set { _pris = value; }
        }

        public double PrisUdenRabat
        {
            get { return _pris; }
            set { _pris = value; }
        }

        public double PrisMedKunBrobizzRabat
        {
            get
            {
                if (Brobizz == true) return _pris *= rabatBrobizz;
                return _pris;
            }
            set { _pris = value; }
        }
    }
}
